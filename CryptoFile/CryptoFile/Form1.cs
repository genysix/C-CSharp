using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Collections;

namespace CryptoFile
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
            
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


            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
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

        /// <summary>
        /// Méthode pour décrypter ds données
        /// </summary>
        /// <param name="inName">Fichier que l'on veut crypter</param>
        /// <param name="outName">Fichier crypté</param>
        /// <param name="desKey">Clé de cryptage</param>
        /// <param name="desIV">Partie complémentaire de la clé</param>
        private static void UncryptData(String inName, String outName, byte[] desKey, byte[] desIV)
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


            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            CryptoStream encStream = new CryptoStream(fout, des.CreateDecryptor(desKey,desIV), CryptoStreamMode.Write);

            //Read from the input file, then encrypt and write to the output file.
            while (rdlen < totlen)
            {
                len = fin.Read(bin, 0, 100);
                encStream.Write(bin, 0, len);
                rdlen = rdlen + len;
            }

            encStream.Flush();

            encStream.Close() ;

            fout.Close();
            fin.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            FolderBrowserDialog Fold = new FolderBrowserDialog();

            if (Fold.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(Fold.SelectedPath + "\\"+ textBox1.Text + ".Prive.xml", RSA.ToXmlString(true));
                File.WriteAllText(Fold.SelectedPath + "\\"+ textBox1.Text + ".Public.xml", RSA.ToXmlString(false));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Title = "Sélectionnez le fichier à crypter";
            openFileDialog1.RestoreDirectory = true;

            OpenFileDialog info = new OpenFileDialog();

            info.Title = "Sélectionnez la clé publique";
            info.Filter = "public xml (*.public.xml)|*.public.xml";

            if (openFileDialog1.ShowDialog() == DialogResult.OK && info.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DESCryptoServiceProvider DES = new DESCryptoServiceProvider();

                    string outName = openFileDialog1.FileName+".cry";
                    
                    RSA.FromXmlString(File.ReadAllText(info.FileName));

                    EncryptData(openFileDialog1.FileName, outName, DES.Key, DES.IV);

                    byte[] bite = new byte[16];
                    for(int i=0;i<8;i++)
                    {
                        bite[i] = DES.Key[i];
                    }
                    for (int i = 8; i < 16; i++)
                    {
                        bite[i] = DES.IV[i-8];
                    }
                    
                    outName = openFileDialog1.FileName + ".sym";
                    File.WriteAllBytes(outName,bite);
                    string erere = outName + ".cry";

                    File.WriteAllBytes(erere, RSA.Encrypt(File.ReadAllBytes(outName), true));


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog Suiv = new OpenFileDialog();
            OpenFileDialog SuivDES = new OpenFileDialog();

            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();

            Suiv.Tag = "Sélectionnez la clé symétrique cryptée";
            Suiv.Filter = "sym.cry files (*.sym.cry)|*.sym.cry";
            Suiv.RestoreDirectory = true;

            SuivDES.Tag = "Sélectionnez votre clé crypté privée";
            SuivDES.Filter = "prive xml (*.prive.xml)|*.prive.xml";
            SuivDES.RestoreDirectory = true;

            Suiv.ShowDialog();
            SuivDES.ShowDialog();

            RSA.FromXmlString(File.ReadAllText(SuivDES.FileName));

            File.WriteAllBytes(Suiv.FileName.Remove(Suiv.FileName.Length - 4, 4),
                RSA.Decrypt(File.ReadAllBytes(Suiv.FileName), true));

            
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Title = "Sélectionnez le fichier à décrypter";
            openFileDialog1.Filter = "cry files (*.cry)|*.cry";
            openFileDialog1.RestoreDirectory = true;

            OpenFileDialog info = new OpenFileDialog();

            

            info.Title = "Sélectionnez la clé symétrique";
            info.Filter = "sym files (*.sym)|*.sym";

            if (openFileDialog1.ShowDialog() == DialogResult.OK && info.ShowDialog() == DialogResult.OK)
            {
                try
                {
                   

                    byte[] infoDES = File.ReadAllBytes(info.FileName);
                    byte[] InfoDESKey = new byte[8];
                    byte[] InfoDESIV = new byte[8];
                    int a = 0;
                    for (a = 0; a < 8; a++)
                    {
                        InfoDESKey[a] = infoDES[a];
                    }
                    for (a = 8; a < 16; a++)
                    {
                        InfoDESIV[a-8] = infoDES[a];
                    }


                    UncryptData(openFileDialog1.FileName, openFileDialog1.FileName.Remove(openFileDialog1.FileName.Length - 4), InfoDESKey, InfoDESIV);

                    
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
