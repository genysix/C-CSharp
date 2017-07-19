using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace troisSages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Random r = new Random();

            Point p1 = new Point(10, 10);
            Point p2 = new Point(this.Width - 40, 10);
            Point p3 = new Point((this.Width - 40) / 2, this.Height - 40);
            Point pCailloux = new Point(150, 150);
            int o=0, q=5;
            

            Bitmap b = new Bitmap(this.Width, this.Height);

            b.SetPixel(0, 0, Color.Red);

            e.Graphics.DrawEllipse(Pens.Black, p1.X, p1.Y, q, q);
            e.Graphics.DrawEllipse(Pens.Black, p2.X, p2.Y, q, q);
            e.Graphics.DrawEllipse(Pens.Black, p3.X, p3.Y, q, q);

            for (int i = 0; i <= 10000; i++)
            {
                o= r.Next(1, 4);
                switch (o)
                {
                    case 1:
                        pCailloux.Y = (pCailloux.Y + p1.Y)/2;
                        pCailloux.X = (pCailloux.X + p1.X)/2;
                        break;
                    case 2:
                        pCailloux.Y = (pCailloux.Y + p2.Y) / 2;
                        pCailloux.X = (pCailloux.X + p2.X) / 2;
                        break;
                    case 3:
                        pCailloux.Y = (pCailloux.Y + p3.Y) / 2;
                        pCailloux.X = (pCailloux.X + p3.X) / 2;
                        break;
                    default:
                        i--;
                        break;
                    
                }
                b.SetPixel(pCailloux.X, pCailloux.Y, Color.Blue);
            }

            e.Graphics.DrawImage(b, 0, 0);
        }
    }
}
