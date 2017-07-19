using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stetanos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        Stream myStream1;
        int Longueur;

        private int ConvertHex ()
        {
            int i = myStream1.ReadByte(), j = myStream1.ReadByte(), k = myStream1.ReadByte(), l = myStream1.ReadByte(), m = 0;
            m = l * 16777216 + k * 65536 + j * 256 + i * 1;

            return m;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myStream1 = null;
            openFileDialog1.Filter = "Bitmap files (*.bmp)|*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.ImageLocation = openFileDialog1.FileName;
                    if ((myStream1 = openFileDialog1.OpenFile()) != null)
                    {
                        
                        using (myStream1)
                        {
                            label1.Text = "Signature :" + Convert.ToChar(myStream1.ReadByte());
                            label1.Text = label1.Text + Convert.ToChar(myStream1.ReadByte()) + "\n";
                            int m = ConvertHex();
                            Longueur = m;
                            label1.Text = label1.Text + "Taille :" + m + "\n";
                            myStream1.ReadByte(); myStream1.ReadByte(); myStream1.ReadByte(); myStream1.ReadByte();
                            myStream1.ReadByte(); myStream1.ReadByte(); myStream1.ReadByte(); myStream1.ReadByte();
                            myStream1.ReadByte(); myStream1.ReadByte(); myStream1.ReadByte(); myStream1.ReadByte();
                            m = ConvertHex();
                            pictureBox1.Width = m;
                            label1.Text = label1.Text + "Largeur :" + m + "\n";
                            m = ConvertHex();
                            pictureBox1.Height = m;
                            label1.Text = label1.Text + "Hauteur :" + m + "\n";

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            myStream1 = openFileDialog1.OpenFile();
            
                        
            int[] j = new int[8];
            int g = 1, h = 0, m = 0;
            label1.Text = "le message secret est : \n";
            
            for (int i = 0; i<1000;i++)
            {
                myStream1.ReadByte();
            }
            
            for (int i = 0; i < 50*8*7; i++)
            {
                m = myStream1.ReadByte();
                if (i % 7 == 0)
                {
                    
                    if ((m & 1) == 0)
                    {
                        j[h] = 0;
                        h++;
                    }
                    else
                    {
                        j[h] = 1;
                        h++;
                    }
                    if (h == 8)
                    {
                        int f = j[7] * 128 + j[6] * 64 + j[5] * 32 + j[4] * 16 + j[3] * 8 + j[2] * 4 + j[1] * 2 + j[0] * 1;
                        label1.Text = label1.Text + Convert.ToChar(f) + " ";
                        g++;
                        h = 0;
                    }
                    if (g % 30 == 0)
                    {
                        label1.Text = label1.Text + "\n";
                        g = 1;
                    }
                }
            }
        }
    }
}
