using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace chercheE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p = 29, q = 37, g = 1;

            int d = (p - 1) * (q - 1);

            ArrayList Al = new ArrayList();
            ArrayList AlDef = new ArrayList();

            label1.Text = "Liste des diviseurs de e : \n";


            for (int i = 2; i < d; i++)
            {
                if (d % i == 0)
                {
                    Al.Add(i);

                }

            }

            for (int i = 2; i < d; i++)
            {
                bool test = true;
                for (int j = 0; j < Al.Count; j++)
                {
                    int t = (int)Al[j];
                    if (i % t == 0)
                    {
                        test = false;
                    }

                }

                if (test == true)
                {
                    AlDef.Add(i);
                    label1.Text += i + " ";
                    g++;

                }
                if (g % 15 == 0)
                {
                    label1.Text += "\n";
                    g++;
                }
            }
        }
    }
}
