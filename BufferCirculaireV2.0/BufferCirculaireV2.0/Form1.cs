using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BufferCirculaireV2._0
{
    public partial class frmBufferCirculaire : Form
    {
        public frmBufferCirculaire()
        {
            InitializeComponent();
        }

        Circ BufferCirculaire = new Circ(6);
        char c;
        bool bErreurBuffer;

        private void btnPut_Click(object sender, EventArgs e)
        {
            bErreurBuffer = BufferCirculaire.Put(Convert.ToChar(tbxCaractere.Text));
            if(bErreurBuffer == false)
            {
                lblErrors.Text = "Buffer Plein";
            }
            else
            {
                lblErrors.Text = "";
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            c = BufferCirculaire.Get();
            if(c == '\0')
            {
                lblErrors.Text = "Buffer Vide";
            }
            else
            {
                lblErrors.Text = "";
            }
            lblCaractere.Text = c.ToString();
        }
    }
}
