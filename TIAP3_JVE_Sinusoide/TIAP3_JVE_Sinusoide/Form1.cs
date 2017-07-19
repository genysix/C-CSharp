using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIAP3_JVE_Sinusoide
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Bitmap b = new Bitmap(e.ClipRectangle.Width, e.ClipRectangle.Height);
            

            for (double i= -1.0; i<1.0; i+=0.001)
            {
                double dblCos = Math.Cos(i * 2 * Math.PI);
                double y =- dblCos * e.ClipRectangle.Height / 2 + e.ClipRectangle.Height / 2 -1;
                double x = i * e.ClipRectangle.Width;
                if (y > 0 && y <= e.ClipRectangle.Height && x>0 && x<= e.ClipRectangle.Width)
                {
                    b.SetPixel((int)x, (int)y, Color.Blue);
                }
            }

            e.Graphics.DrawImage(b, 0, 0);
        }
        
    }
}
