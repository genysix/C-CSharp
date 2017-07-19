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
using System.IO;
using System.Numerics;
using System.Security.Cryptography;

namespace Codage
{
    public partial class Form1 : Form
    {
        public int n = 0,p=0,q=0;
        Stream myStream1,myStream2;

        public Form1()
        {
            InitializeComponent();
        }

        private ArrayList RechercheE(int p, int q)
        {
            int d = (p - 1) * (q - 1);

            ArrayList Al = new ArrayList();
            ArrayList AlDef = new ArrayList();

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

                }
            }

            return AlDef;
        }
        private ArrayList ListNbPremier()
        {
            ArrayList al = new ArrayList();

            al.Add(2);
            al.Add(3);
            al.Add(5);
            al.Add(7);
            al.Add(11);


            for (int i=2; i< 10000;i++)
            {
                bool test = true;
                for (int j=0;j<al.Count;j++)
                {
                    int t = (int)al[j];
                    if (i % t == 0)
                    {
                        test = false;
                    }
                }

                if(test==true)
                {
                    al.Add(i);
                }
            }

            return al;
        }

        private int EncrypteFile()
        {
            int i = 0,z=0;
            string d="";

            while (z != -1)
            {
                z = myStream1.ReadByte();
                if (z != -1)
                {
                    d += z.ToString();
                }
                
            } 
            
                while(d.Length % 3 != 0)
                {
                    d += "0";
                }
            
            string path = @"C:\Users\veillardje\Desktop\crypto\Test.txt.cry";
            if (!File.Exists(path))
            {
                File.CreateText(path);
            }
            else { 

                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    
                    int b = Convert.ToInt16(comboBox1.SelectedItem.ToString());
                    while (i < d.Length )
                    {
                        string r = d[i]+ "" +d[i+1] + "" + d[i+2];
                        int t = Convert.ToInt32(r);
                        BigInteger tt = BigInteger.Pow(t,b) % n;
                        int gg = (int)tt;
                        char cc = Convert.ToChar(gg);
                        sw.Write(cc);
                        i +=3;
                    }
                }
            }

            return i;
        }

        private int DecrypteFile()
        {
            int i = 0;
            string r = "";
            string Rpath = @"C:\Users\veillardje\Desktop\crypto\Test.txt.cry";
            
            // Create a file to write to.
            using (StreamReader sr = File.OpenText(Rpath))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    r = s;
                }

                int b = Convert.ToInt16(comboBox1.SelectedItem.ToString());
                while (i < r.Length)
                {
                    string rr = r[i] + "" + r[i + 1] + "" + r[i + 2] + "" + r[i+3];
                    int t = Convert.ToInt32(rr);
                    BigInteger tt = BigInteger.Pow(t, b) % n;
                    lblCrypte.Text += " " + tt;
                    i += 4;
                }

                
            }
            return i;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.BeginUpdate();
            comboBox3.BeginUpdate();
            ArrayList al = ListNbPremier();
            for (int i = 0; i < al.Count; i++)
            {
                comboBox2.Items.Add(al[i]);
                comboBox3.Items.Add(al[i]);
            }
            comboBox2.EndUpdate();
            comboBox3.EndUpdate();
        }

        private void btnCalculer_Click(object sender, EventArgs e)
        {
            p = Convert.ToInt16(comboBox2.SelectedItem.ToString());
            q = Convert.ToInt16(comboBox3.SelectedItem.ToString());
            ArrayList al = RechercheE(p,q);
            n = p * q;
            lblResultat.Text = Convert.ToString(n);
            lblPQ1.Text += ((p-1) * (q-1));
            comboBox1.Items.Clear();
            comboBox1.BeginUpdate();
            for (int i =0; i<al.Count;i++)
            {
                comboBox1.Items.Add(al[i]);
            }
            comboBox1.EndUpdate();
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            myStream1 = null;
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream1 = openFileDialog1.OpenFile()) != null)
                    {
                        int i = EncrypteFile();


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int i = DecrypteFile();
        }
    }
}
