using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIAP_JVE_Parallelepipede
{
    public partial class Form1 : Form
    {
        int iCompteur = 0;
        Point P1, P2,P3;


        Bitmap b;
        Graphics d;


        public Form1()
        {
            InitializeComponent();
        }
        
        

        private void Form1_Load(object sender, EventArgs e)
        {
            b = new Bitmap(this.Width, this.Height);
            d = this.CreateGraphics();
        }

        private void dessineLigne(Point Origine, Point Arrivee)
        {
            double a, r;
            a = (double)(Origine.Y - Arrivee.Y) / (double)(Origine.X - Arrivee.X);

            r = (double)(Origine.Y) - a * (double)(Origine.X);

            for (int q = Origine.X; q <= Arrivee.X; q++)
            {
                int y = (int)(a * q + r);
                if (y >= Origine.Y && y <= Arrivee.Y && q >= Origine.X && q <= Arrivee.X )
                {
                    b.SetPixel(q,y, Color.Black);
                }
            }
            return;
        }

        private void dessineRectangle(Point p1, Point p2,Color C1, Color C2, Boolean B)
        {
            if (B == true)
            {
                for (int j = 0; j < p2.Y - p1.Y; j++)
                {
                    if (j < (p2.Y - p1.Y) / 2)
                    {
                        for (int i = 0; i < p2.X - p1.X; i++)
                        {
                            b.SetPixel(p1.X + i, p1.Y + j, C1);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < p2.X - p1.X; i++)
                        {
                            b.SetPixel(p1.X + i, p1.Y + j, C2);
                        }
                    }
                }
            }else
            {
                for (int j = 0; j < p2.Y - p1.Y; j++)
                {
                    for (int i = 0; i < p2.X - p1.X; i++)
                    {
                        if (i < (p2.X - p1.X) / 2)
                        {
                            b.SetPixel(p1.X + i, p1.Y + j, C1);
                        }else
                        {
                            b.SetPixel(p1.X + i, p1.Y + j, C2);
                        }
                    }
                }
            }
            return;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Point P4 = new Point();
            Point P5 = new Point();
            Point P6 = new Point();
            dessineRectangle(P1, P2,Color.Yellow, Color.Red, true);
            P4.X = P3.X + P2.X - P1.X;
            P4.Y = P3.Y + P2.Y - P1.Y;
            dessineRectangle(P3, P4, Color.Blue, Color.Green,  false);
            dessineLigne(P1,P3);

            if (P2.X < P3.X && P2.Y < P3.Y)
            {
                dessineLigne(P2, P4);
            }
            P5.X = P1.X + P2.X - P1.X;
            P5.Y = P1.Y;
            P6.X = P3.X + P4.X - P3.X;
            P6.Y = P3.Y;
            dessineLigne(P5, P6);
            P5.Y = P1.Y + P2.Y - P1.Y;
            P5.X = P1.X;
            P6.Y = P3.Y + P4.Y - P3.Y;
            P6.X = P3.X;
            dessineLigne(P5, P6);

            e.Graphics.DrawImage(b, 0, 0);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            switch(iCompteur)
            {
                case 0:
                    P1 = new Point(e.X, e.Y);
                    iCompteur = 1;
                    
                    break;
                case 1:
                    P2 = new Point(e.X, e.Y);
                    iCompteur = 2;
                    break;
                case 2:
                    P3 = new Point(e.X, e.Y);
                    Refresh();
                    iCompteur = 3;
                    break;
            }
        }
    }
}
