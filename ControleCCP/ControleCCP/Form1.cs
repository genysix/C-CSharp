using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleCCP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        class ControleCCP
        {
            
                

            int[,] Modulo10 = new int[10, 11] {
            {0,9,4,6,8,2,7,1,3,5,0},
            {9,4,6,8,2,7,1,3,5,0,9},
            {4,6,8,2,7,1,3,5,0,9,8},
            {6,8,2,7,1,3,5,0,9,4,7},
            {8,2,7,1,3,5,0,9,4,6,6},
            {2,7,1,3,5,0,9,4,6,8,5},
            {7,1,3,5,0,9,4,6,8,2,4},
            {1,3,5,0,9,4,6,8,2,7,3},
            {3,5,0,9,4,6,8,2,7,1,2},
            {5,0,9,4,6,8,2,7,1,3,1},
            };
            // Selon Postfinance
             
            private int Switch(char c)
            {
                int k = 0;
                switch (c)
                {
                    case '0':
                        k = 0;
                        break;
                    case '1':
                        k = 1;
                        break;
                    case '2':
                        k = 2;
                        break;
                    case '3':
                        k = 3;
                        break;
                    case '4':
                        k = 4;
                        break;
                    case '5':
                        k = 5;
                        break;
                    case '6':
                        k = 6;
                        break;
                    case '7':
                        k = 7;
                        break;
                    case '8':
                        k = 8;
                        break;
                    case '9':
                        k = 9;
                        break;
                }

                return k;
            }

            public bool OK (string chaine)
            {
                int i = 0, j=0;

                while(chaine.Length - j > 1)
                {
                    
                    if (chaine[j] != '-')
                    {
                        i = Modulo10[i, Switch(chaine[j])];
                    }
                    j++;
                }
                
                if (Modulo10[i,10] == Switch(chaine[j]))
                {
                    return true;
                } else {
                    return false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControleCCP c = new ControleCCP();

            if(c.OK(textBox1.Text) == true)
            {
                button2.ImageIndex = 1;
            }else
            {
                button2.ImageIndex = 0;
                //button2.Image = Image.FromFile("FAUX.png");
            }
        }
    }
}
