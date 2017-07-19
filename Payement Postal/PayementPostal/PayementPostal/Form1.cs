using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayementPostal
{
    public partial class frmPayementPostal : Form
    {
        public frmPayementPostal()
        {
            InitializeComponent();

        }
        private void btnValideLigneCode_Click(object sender, EventArgs e)
        {
            bool bCheckNumCompte;
            bool bCheckNumRef;
            bool bCheckMontant;
            GestionBVR bvr = new GestionBVR();
            bCheckNumCompte = bvr.NumeroAdherent(tbxCompte.Text);
            bCheckNumRef = bvr.NumeroReference(tbxNumeroReference.Text);
            bCheckMontant = bvr.Montant(tbxMontant.Text);
            if (bCheckNumCompte == true && bCheckNumRef == true && bCheckMontant == true)
            {
                lblCheckDonneesBVR.Text = "Les données sont valides.";
            }
            else
            {
                lblCheckDonneesBVR.Text = "Les données sont érronnées, veuillez les vérifier.";
            }
        }
        private void sauvegarderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
