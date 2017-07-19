using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClefRSA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerer_Click(object sender, EventArgs e)
        {
            int p = 0;
            int q = 0;
            int d = 0;
            int pq = 0;
            int E = 0;
            int iMDeCrypte = 0;
            string m = "";
            string c = "";
            string strM = "";
            string strASCIIMDecrypte = "";
            bool bp = false;
            bool bq = false;
            int i = 0;
            int iEInf = 0;
            const int iValTab = 20;
            int[] iCarASCIIm = new int[iValTab]; // 20 caractères max
            int[] iCarASCIICrypte = new int[iValTab]; // 20 caractères max
            int[] iCarASCIIDeCrypte = new int[iValTab]; // 20 caractères max
            int[] iCarASCIImDecrypte = new int[iValTab];// 20 caractères max

            p = Convert.ToInt32(tbxNbPremier1.Text);
            q = Convert.ToInt32(tbxNbPremier2.Text);
            m = tbxMessage.Text;

            /* Test si les nombres q et n sont premiers */
            for (i = 2; i < p; i++)
            {
                if(p % i == 0)
                {
                    bp = false;
                    i = p - 1;
                }
                else
                {
                    bp = true;
                }
            }
            for (i = 2; i < q; i++)
            {
                if (q % i == 0)
                {
                    bq = false;
                    i = q - 1;
                }
                else
                {
                    bq = true;
                }
            }

            if (bq && bp == true)
            {
                lblInformations.Text = "Les nombres sont premiers.";
                pq = ((p - 1) * (q - 1));
                E = Convert.ToInt32(tbxE.Text);
                if (pq % E != 0)
                {
                    lblInformations.Text = "E est validée, il n'a aucune relations avec (p-1) * (q-1).";
                    i = pq;
                    bool stop = false;
                    do
                    {
                        if ((E * i) % pq == 1 && i != E)
                        {
                            d = i;
                            lblInformations.Text = d.ToString();
                            stop = true;
                        }
                        i++;
                    } while (stop == false);

                    foreach(char cChar in m)
                    {
                        strM += Convert.ToString((int)cChar);
                    }
                    strM += "00";
                    int iPosCarASCIIm = 0;
                    for (int j = 0; j < 4; j ++)
                    {
                        iCarASCIIm[j] += Convert.ToInt32(strM.Substring(iPosCarASCIIm, 3));
                        iPosCarASCIIm += 3;
                        iCarASCIICrypte[j] = iCarASCIIm[j]^E % pq; // Cryptage
                        iCarASCIIDeCrypte[j] = iCarASCIICrypte[j] ^ d % pq; // DeCryptage
                        strASCIIMDecrypte += Convert.ToString(iCarASCIIDeCrypte[j]);
                    }
                    double dblDecrypte = 0;
                    dblDecrypte = Convert.ToDouble(strASCIIMDecrypte); // Récupération ASCII chiffre décrypté
                    iPosCarASCIIm = 0;
                    string strChaineDecrypte = "";
                    for (int j = 0; j < 6; j++)
                    {
                        iCarASCIImDecrypte[j] += Convert.ToInt32(strASCIIMDecrypte.Substring(iPosCarASCIIm, 2));
                        iPosCarASCIIm = iPosCarASCIIm + 2;
                        strChaineDecrypte += Convert.ToString((char)iCarASCIImDecrypte[j]);
                    }
                        lblInformations.Text = "Message Decrypté :" + strChaineDecrypte.ToString();
                }
                else
                {
                    lblInformations.Text = "E a une relation avec (p-1) * (q-1).";
                }
            }
            else
            {
                lblInformations.Text = "Les nombres ne sont pas premiers";
            }
        }
    }
}
