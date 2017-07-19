using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMonPoint
{
    

    class MonPoint
    {
        private int x;
        private int y;
        private static int n;




        public MonPoint()
        {
            x = 320;
            y = 240;
            n++;
        }

        public MonPoint(int x, int y)
        {
            Initialize(x, y);
            n++;
        }

        ~MonPoint()
        {
            n--;
        }

        public int X
        {
            get
            {
                return x;
            }
            
            set
            {
                Initialize(value,y);
            }       
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                Initialize(x,value);
            }
        }

        public int N
        {
            get
            {
                return n;
            }

            
        }

        private void Initialize(int abs,int ord)
        {
            if(abs >= 0 && abs <= 640)
            {
                x = abs;
            }else
            {
                if(abs < -1)
                {
                    x = 0;
                }
                if(abs > 641)
                {
                    x = 640;
                }
            }

            if(ord >= 0 && ord <= 480)
            {
                y = ord;
            }
            else
            {
                if(ord < 0)
                {
                    y = 0;
                }
                if(ord>481)
                {
                    y = 480;
                }
            }
        }
        public void Deplace(int dx, int dy){Initialize(x + dx, y + dy); }

        public double Scalaire(MonPoint P)
        {
            return x * P.X  + y * P.Y;
        }

        public void Permute(MonPoint P)
        {
            int Change;

            Change = x;
            x = P.X;
            P.X = Change;
            Change = y;
            y = P.Y;
            P.Y = Change;
        }

        public void Addition(MonPoint P)
        {
            Initialize(x + P.X, y + P.Y);
        }

        public static MonPoint Somme(MonPoint P1, MonPoint P2)
        {
            MonPoint P3 = new MonPoint(P1.X + P2.X, P1.Y + P2.Y);

            return P3;
        }

        public override String ToString()
        {
            return "x=" + x.ToString() + " y=" + y.ToString() + " n=" + n.ToString();
        }
    }
}
