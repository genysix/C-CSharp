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

namespace LectureBMP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* Attributs */
        int iTaille = 0;
        int iOctet = 0;
        int iLettre = 0;
        string strChaineTaille = "";
        string strMot;
        BinaryReader brReader;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (openFileDialogBMP.ShowDialog() == DialogResult.OK)
            {
                // Appel de l'open file, saisie du fichier par l'utilisateur
                lblNomFichier.Text = openFileDialogBMP.FileName; // Affichage du nom du fichier
                /* Ouverture du fichier */
                FileStream fsStream = File.Open(openFileDialogBMP.FileName, FileMode.Open, FileAccess.Read); // Ouverture du fichier géré dans un Stream
                /* Lecture des deux premiers bytes (entête 2 bytes) */
                byte[] TabByte = new byte[5000]; // Création d'un tableau de 5000 bytes
                fsStream.Read(TabByte, 0, 5000); // Lecture des 5000 premiers bytes et stockage dans un tableau
                lblSignature.Text += (char)TabByte[0];
                lblSignature.Text += Convert.ToChar(TabByte[1]); // même ligne que la précédente
                /* Calcul de la taille (taille 4 bytes) */
                iTaille = BitConverter.ToInt32(TabByte, 2); // Taille sur 32 bits
                lblTaille.Text += iTaille.ToString();
                /* Calcul de la hauteur */
                iTaille = BitConverter.ToInt32(TabByte, 18); // Largeur sur 32 bits
                lblLargeur.Text += iTaille.ToString();
                /* Calcul de la largeur */
                iTaille = BitConverter.ToInt32(TabByte, 22); // Hauteur sur 32 bits
                lblHauteur.Text += iTaille.ToString();

                /* Message Caché */
                // Répartir l'octet valant A répartis entre les 7 prochains octets au niveau du bit de poids faible
                int iOctet = 1000;
                
                for (int i = 0; i < 50; i++) // 50 caractères
                {
                    char cOctet = '\0';
                    for (int j = 0; j < 7; j++) // 8 bits
                    {
                        if ((TabByte[iOctet] & 1) == 0) // Si le bit de poid faible vaut 0
                        {
                            cOctet |= (char)0;
                        }
                        else
                        {
                            cOctet |= (char)128;
                        }
                        cOctet >>= 1;
                        iOctet += 7;
                    }
                    iOctet += 7;
                    lblMessageCache.Text += cOctet;
                }        
            }


                /*
                BinaryReader brReader = new BinaryReader(fsStream);

                int a = brReader.ReadByte();
                int b = brReader.ReadByte();
                char charA = (char)a;
                char charB = (char)b;
                lblSignature.Text = charA.ToString() + charB.ToString();

            }

            for (int i = 0; i <= 4; i++)
            {
                // Lecture des 4 octets (taille)
                iTailleOctet = brReader.ReadByte();
                iTailleTotale = iTailleTotale + iTailleOctet;
            }
            lblTaille.Text = iTailleTotale.ToString(); // Affichage de la taille
            */
        }
    }
}
