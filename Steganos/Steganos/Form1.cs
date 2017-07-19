using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Steganos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            //Affichage à l'utilisateur d'une boîte de dialogue de fichier.
            if (ofdOpener.ShowDialog() == DialogResult.OK)
            {
                pbxImage.Image = new Bitmap(ofdOpener.FileName);
            }
            ofdOpener.Dispose();
        }

        private void btnShowHiddenText_Click(object sender, EventArgs e)
        {
            //Ouverture du fichier dans un flux de fichier
            FileStream fs = File.OpenRead(ofdOpener.FileName);

            //Lecture des données pour les informations du bitmap
            byte[] array = new byte[26];            
            fs.Read(array, 0, 26);

            //Signature du fichier
            lblHiddenText.Text = "\nSignature: " + Convert.ToChar(array[0]) + Convert.ToChar(array[1]);

            //Taille du fichier
            lblHiddenText.Text += "\nTaille du fichier: " + BitConverter.ToInt32(array, 2);

            //Largeur du fichier
            lblHiddenText.Text += "\nLargeur de l'image: " + BitConverter.ToInt32(array, 18);

            //Hauteur du fichier
            lblHiddenText.Text += "\nHauteur de l'image: " + BitConverter.ToInt32(array, 22) + "\nTexte caché: ";

            //Initialisation d'un tableau qui contient le flux jusqu'au 4000ème byte.
            //Informations supplémentaires: nous avons que 50 caractères cachés.
            //-26 à cause du fs.read car celui-ci tant que le flux n'est pas fermé et ouvert à nouveau.
            byte[] arrayText = new byte[4000];
            fs.Read(arrayText, 0, 4000);
            int iByteOffset = 1000 - 26;
            byte c = 0;

            //parcours des bytes pour la recherche du texte caché
            for (int i = 0; i < 50; i++)
            {
                //Boucle char
                for(int j = 0; j < 8; j++)
                {
                    c >>= 1;
                    if ((arrayText[iByteOffset] & 1) == 1)
                    {
                       c |= 0x80;
                    }
                    iByteOffset += 7;
                }
                lblHiddenText.Text += (char)c;
                c = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
