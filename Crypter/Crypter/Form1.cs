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

namespace Crypter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenere_Click(object sender, EventArgs e)
        {

        }

        private void btnCrypte_Click(object sender, EventArgs e)
        {
            FileStream fs = File.OpenRead(ofdOpener.FileName);
        }

        private void btnDecrypte_Click(object sender, EventArgs e)
        {

        }
    }
}
