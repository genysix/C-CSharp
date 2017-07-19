using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BufferCirculaire
{
    public partial class BufferCirculaire : Form
    {
        public BufferCirculaire()
        {
            InitializeComponent();
        }
        Circ BufferCirc = new Circ(6);
        char cGet;
        bool bEtatBuffer;

        private void btnPut_Click(object sender, EventArgs e)
        {
            bEtatBuffer = BufferCirc.PUT(Convert.ToChar(tbxCaractere.Text));
            if(bEtatBuffer == false)
            {
                lblErrors.Text = "Buffer Plein";
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            cGet = BufferCirc.GET();
            if (cGet == '\0')
            {
                lblErrors.Text = "Buffer Vide";
            }
                lblCaractere.Text = cGet.ToString();
        }
    }
}
