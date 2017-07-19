using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CacheJpeg
{
    public partial class Form2 : Form1
    {
        bool test = false;
        public Form2(bool t)
        {
            InitializeComponent();
            test = t;
        }
        

        private void Form2_Load(object sender, EventArgs e)
        {
            btnHide.Hide();
            btnShow.Hide();
            if(test == false)
            {
                label1.Text = "Entrer le mot de passe pour extraire le fichier JPEG";
            }
            else
            {
                label1.Text = "Entrez le mot de passe pour encrypter le fichier JPEG";
            }
        }

        private void btnValide_Click(object sender, EventArgs e)
        {
            strPassword = textBox1.Text;

            Close();
        }
    }
}
