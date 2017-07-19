using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreationRectangle
{
    public partial class Form1 : Form
    {
        int iCompteur = 0,j;
        Point P1, P2;

        Color tt;

        Bitmap b;
        Graphics d;


        
        
        public Color RandomColor()
        {
            Random _r = null;
            _r = new Random();
            return Color.FromArgb(_r.Next(0, 255), _r.Next(0, 255), _r.Next(0, 255));
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            b = new Bitmap(this.Width, this.Height);
            d = this.CreateGraphics();
        }

        private void BoucleForX(int iDepart,int iArrivee)
        {
            for (int i = iDepart; i < iArrivee; i++)
            {
                b.SetPixel(P1.X + i, P1.Y + j, tt);
            }
            return;
        }

        private void BoucleForY(int iDepart,int iArrivee)
        {
            for (j = iDepart; j < iArrivee; j++)
            {
                if (P1.X < P2.X)
                {
                    BoucleForX(0, P2.X - P1.X);
                }
                else
                {
                    BoucleForX(P2.X - P1.X, 0);
                }
            }
            return;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            tt = RandomColor();

            if (P1.Y < P2.Y)
            {
                BoucleForY(0,P2.Y - P1.Y);
            }
            else
            {
                BoucleForY(P2.Y - P1.Y,0);
            }
            e.Graphics.DrawImage(b, 0, 0);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (iCompteur == 0)
            {
                P1 = new Point(e.X, e.Y);
                iCompteur=1;
            }else
            {
                P2 = new Point(e.X, e.Y);
                Refresh();
                iCompteur=0;
            }
        }
    }
}
