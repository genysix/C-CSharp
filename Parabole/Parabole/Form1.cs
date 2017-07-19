using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parabole
{
    public partial class Form1 : Form
    {
        int iCompteur = 3;
        Point P1, P2, P3;
        double a, r, c;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Bitmap b = new Bitmap(this.Width, this.Height);
            Graphics d = this.CreateGraphics();
            SolidBrush brus = new SolidBrush(Color.Blue);

            switch (iCompteur)
            {
                case 0:
                    
                    for (int i = 0; i < this.Width; i++)
                    {
                        b.SetPixel(i, P1.Y, Color.Blue);
                    }
                    e.Graphics.DrawImage(b, 0, 0);
                    iCompteur++;
                    break;
                case 1:
                    
                    a = ((double)(P1.Y) - (double)(P2.Y)) / ((double)(P1.X) - (double)(P2.X));

                    r = (double)(P1.Y) - a * (double)(P1.X);

                    for (int i = 0; i < this.Width; i++)
                    {
                        b.SetPixel(i,(int)(a * i + r), Color.Red);    
                    }
                    e.Graphics.DrawImage(b, 0, 0);
                    iCompteur++;
                    break;
                case 2:
                    r = (double)((P2.X * P2.X * (P1.Y - P3.Y) - (P1.X * P1.X) * (P2.Y - P3.Y) - (P3.X * P3.X) * (P1.Y - P2.Y))) / ((P2.X * P2.X - P2.X * (P1.X + P3.X) + P3.X * P1.X) * (P1.X - P3.X));
                    a = (P1.Y - P2.Y - r * P1.X + r * P2.X) / (P1.X * P1.X - P2.X * P2.X);
                    c = -a * (P1.X * P1.X) - r * P1.X + P1.Y;


                    for (int i = 0; i < this.Width; i++)
                    {
                        int J = (int)(a * i * i + r * i + c);

                        if (J >= 0 && J < this.Height)
                        {
                            b.SetPixel(i, J, Color.Green);
                        }
                    }
                    e.Graphics.DrawImage(b, 0, 0);
                    iCompteur++;
                    break;
                case 3:
                    e.Graphics.DrawImage(b, 0, 0);
                    iCompteur = 0;
                    break;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            switch (iCompteur)
            {
                case 0:
                    P1 = new Point();
                    P2 = new Point();
                    P3 = new Point();
                    P1 = new Point(e.X, e.Y);
                    break;
                case 1:
                    P2 = new Point(e.X, e.Y);
                    break;
                case 2:
                    P3 = new Point(e.X, e.Y);
                    break;
                case 3:
                    break;
            }
            Refresh();
        }
    }
}
