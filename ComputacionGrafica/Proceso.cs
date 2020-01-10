using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputacionGrafica
{
    class Proceso
    {
        //ENTRADAS
        public int SX1 = 0;
        public int SY1 = 0;
        public int SX2 = 560;
        public int SY2 = 400;
        //SALIDAS
        public double X1 = -10;
        public double X2 = 10;
        public double Y1 = -7.14;
        public double Y2 = 7.14;

        public double s, p;

        /*public Proceso(int SX1, int SY1, int SX2, int SY2, int X1, int X2, int Y1, int Y2)
        {
            this.SX1 = SX1;
            this.SY1 = SY1;
            this.SX2 = SX2;
            this.SY2 = SY2;
            this.X1 = X1;
            this.X2 = X2;
            this.Y1 = Y1;
            this.Y2 = Y2;
        }*/

        public void Pantalla(double X, double Y, out int SX, out int SY)
        {
            SX = (int)(((SX1 - SX2) / (X1 - X2)) * (X - X1)) + SX1;
            SY = (int)(((SY1 - SY2) / (Y2 - Y1)) * (Y - Y2)) + SY1;
        }

        public void Carta(int SX, int SY, out double X, out double Y)
        {
            X = (SX - SX1) * ((X1 - X2) / (SX1 - SX2)) + X1;
            Y = (SY - SY2) * ((Y1 - Y2) / (SY2 - SY1)) + Y1;
        }

        public void Lagrange(double x, List<double> Vx, List<double> Vy, out double l)
        {
            s = 0;
            for(int i = 0; i < Vx.Count; i++)
            {
                p = 1;
                for(int j = 0; j < Vy.Count; j++)
                {
                    if (i != j)
                    {
                        p = p * ((x - Vx[j]) / (Vx[i]-Vx[j]));
                    }
                }
                s = s + (Vy[i] * p);
            }
            l = s;
        }

        public void Bezier(double t, List<double> Vx, List<double> Vy, out double Xt, out double Yt)
        {
            Xt = 0;
            Yt = 0;
            int n = Vx.Count - 1;
            for (int i = 0; i < Vx.Count; i++)
            {
                Xt = Xt + Vx[i] * (factorial(n) / (factorial(i) * factorial(n - i))) * Math.Pow(1 - t, n - i) * Math.Pow(t, i);
                Yt = Yt + Vy[i] * (factorial(n) / (factorial(i) * factorial(n - i))) * Math.Pow(1 - t, n - i) * Math.Pow(t, i);
            }
            
        }

        public void RegLineal(List<double> Vx, List<double> Vy, out double m, out double q)
        {
            double SX=0, SY=0;
                
            for(int i = 0; i < Vx.Count; i++)
                {
                SX = SX + Vx[i];
                SY = SY + Vy[i];
            }
            m = (((Vx.Count + 1) * SY) + SY) / ((Vx.Count + 2) * SX);
            q = (SY - m * SX) / (Vx.Count + 1);          

        }

        public static double factorial(double n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return (n * factorial(n - 1));
            }
        }
        ~Proceso()
        { }
    }
}
