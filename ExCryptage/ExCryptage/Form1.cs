using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Obtention de la classe : File
using System.Security.Cryptography; // Obtention de la classe : DESCryptoServiceProvider, RSACryptoServiceProvider, CryptoStream

namespace ExCryptage
{
    public partial class frmCryptage : Form
    {
        public frmCryptage()
        {
            InitializeComponent();
        }

        private void btnCrypterFichiers_Click(object sender, EventArgs e)
        {
            /* Repertoire du fichier à crypter */
            if (ofdFichierACrypter.ShowDialog() == DialogResult.OK)
            {   /* Repertoire de la clef publique que nous a envoyé notre correspondant */
                if (ofdClefPublique.ShowDialog() == DialogResult.OK)
                {
                    DESCryptoServiceProvider ClefSymetrique = new DESCryptoServiceProvider();
                    EncryptData(ofdFichierACrypter.FileName, ofdFichierACrypter.FileName + ".cry", ClefSymetrique.Key, ClefSymetrique.IV);
                    /* Tableau de la clef symétrique [Key : 8 | IV : 8] */
                    byte[] TabByteClefSymetrique = new byte[16];

                    for (int i = 0; i < 8; i++)
                    {   /* Récupération de la première partie de la clef symétrique */
                        TabByteClefSymetrique[i] = ClefSymetrique.Key[i];
                        /* Récupération de la deuxième partie de la clef directement [Rapport de position de IV + 8] */
                        TabByteClefSymetrique[i + 8] = ClefSymetrique.IV[i];
                    }
                    /* Écriture de la clef symétrique */
                    File.WriteAllBytes(ofdFichierACrypter.FileName + ".sym", TabByteClefSymetrique);

                    RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                    /* Lecture de la clef publique */
                    rsa.FromXmlString(File.ReadAllText(ofdClefPublique.FileName));
                    /* Clef symétrique cryptée */
                    File.WriteAllBytes(ofdFichierACrypter + ".sym.cry", rsa.Encrypt(File.ReadAllBytes(ofdFichierACrypter.FileName + ".sym"), true));
                }
            }
        }

        private void btnDecrypterFichiers_Click(object sender, EventArgs e)
        {
        DESCryptoServiceProvider des = new DESCryptoServiceProvider();
        RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            if (ofdClefSymetriqueCryptee.ShowDialog() == DialogResult.OK)
            {
                if(ofdFichierADecrypter.ShowDialog() == DialogResult.OK)
                {
                    rsa.FromXmlString(File.ReadAllText(ofdClefSymetriqueCryptee.FileName));
                    byte[] Clef = new byte[16];
                    byte[] Valeur = new byte[8];
                    byte[] KeyIV = new byte[8];

                    Clef = rsa.Decrypt(File.ReadAllBytes(ofdClefSymetriqueCryptee.FileName), true);

                    for (int i = 0; i < 8; i++)
                    {   /* Récupération de la première partie de la clef symétrique */
                        Valeur[i] = Clef[i];
                        /* Récupération de la deuxième partie de la clef directement [Rapport de position de IV + 8] */
                        KeyIV[i] = Clef[i + 8];
                    }
                    DecryptData(ofdFichierADecrypter.FileName + ".cry", ofdFichierADecrypter + "", Valeur, KeyIV);
                }
            }
        }

        private void btnGenererClefs_Click(object sender, EventArgs e)
        {
            /* Variables des clefs publiques et privés */
            string ClefPublique, ClefPrive;
            /* Variable du nom des clefs */
            string NomFichier = tbxClefs.Text;
            /* Permet de générer les clefs */
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            /* Ouverture de l'objet open file dialog */
            if(odfRepertoireClefs.ShowDialog() == DialogResult.OK)
            {
                /* Vérification si le répertoire source des clefs existe */
                if(Directory.Exists(odfRepertoireClefs.SelectedPath))
                {
                    /* Générations des clefs */
                    ClefPublique = rsa.ToXmlString(false);
                    ClefPrive = rsa.ToXmlString(true);

                    /* Écriture des clefs dans un fichier .xml */
                    // Clef Privé
                    StreamWriter file = new StreamWriter(odfRepertoireClefs.SelectedPath + "\\" + tbxClefs.Text + " - Privé.xml");
                    file.WriteLine(ClefPrive);
                    // Clef publique
                    file = new StreamWriter(odfRepertoireClefs.SelectedPath + "\\" + tbxClefs.Text + " - Publique.xml");
                    file.WriteLine(ClefPublique);
                    // Fermeture du file
                    file.Close();
                }
            }
        }

        /// <summary>
        /// Méthode pour crypter ds données
        /// </summary>
        /// <param name="inName">Fichier que l'on veut crypter</param>
        /// <param name="outName">Fichier crypté</param>
        /// <param name="desKey">Clé de cryptage</param>
        /// <param name="desIV">Partie complémentaire de la clé</param>
        private static void EncryptData(String inName, String outName, byte[] desKey, byte[] desIV)
        {
            //Create the file streams to handle the input and output files.
            FileStream fin = new FileStream(inName, FileMode.Open, FileAccess.Read);
            FileStream fout = new FileStream(outName, FileMode.OpenOrCreate, FileAccess.Write);
            fout.SetLength(0);

            //Create variables to help with read and write.
            byte[] bin = new byte[100]; //This is intermediate storage for the encryption.
            long rdlen = 0;              //This is the total number of bytes written.
            long totlen = fin.Length;    //This is the total length of the input file.
            int len;                     //This is the number of bytes to be written at a time.

            DES des = new DESCryptoServiceProvider();
            CryptoStream encStream = new CryptoStream(fout, des.CreateEncryptor(desKey, desIV), CryptoStreamMode.Write);

            //Read from the input file, then encrypt and write to the output file.
            while (rdlen < totlen)
            {
                len = fin.Read(bin, 0, 100);
                encStream.Write(bin, 0, len);
                rdlen = rdlen + len;
            }

            encStream.Close();
            fout.Close();
            fin.Close();
        }
        private static void DecryptData(String inName, String outName, byte[] desKey, byte[]desIV)
        {
            //Create the file streams to handle the input and output files.
            FileStream fin = new FileStream(inName, FileMode.Open, FileAccess.Read);
            FileStream fout = new FileStream(outName, FileMode.OpenOrCreate, FileAccess.Write);
            fout.SetLength(0);

            //Create variables to help with read and write.
            byte[] bin = new byte[100]; //This is intermediate storage for the encryption.
            long rdlen = 0;              //This is the total number of bytes written.
            long totlen = fin.Length;    //This is the total length of the input file.
            int len;                     //This is the number of bytes to be written at a time.

            SymmetricAlgorithm des = new DESCryptoServiceProvider();
            CryptoStream encStream = new CryptoStream(fout, des.CreateDecryptor(desKey, desIV), CryptoStreamMode.Write);

            //Read from the input file, then encrypt and write to the output file.
            while (rdlen < totlen)
            {
                len = fin.Read(bin, 0, 100);
                encStream.Write(bin, 0, len);
                rdlen = rdlen + len;
            }

            encStream.Close();
            fout.Close();
            fin.Close();
        }

    }
}
