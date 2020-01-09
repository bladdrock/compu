using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compu_Proyecto
{
    class Curvas : Vector
    {
        //---------- LAGRANGE ---------------------------------------------------
        //public double Lagrange(double x)
        public int NDatos;
        public double m, q;
        //public double[] vx =new double[1000];
        //public double[] vy=new double [1000];
        public List<double> Lvx = new List<double>();// 
        public List<double> Lvy = new List<double>();

        // constructor
        public Curvas() { }
        // destructor
        ~Curvas() { }

        public void Lagrange(double x, out double z)
        {
            double p, s = 0;
            for (int i = 0; i < NDatos; i++)
            {
                p = 1;
                for (int j = 0; j < NDatos; j++)
                {
                    if (i != j)
                    {
                        p = p * (x - Lvx[j]) / (Lvx[i] - Lvx[j]);
                    }
                }
                s = s + Lvy[i] * p;
            }
            z = s;
        }


        public void LagrangeEncender(Bitmap lienzo)
        {
            //double t = Lvx[0];
            double t = Lvx[0];
            double Lw, dt = 0.002;

            //Vector v = new Vector();


            Segmento v = new Segmento();

            do
            {
                Lagrange(t, out Lw);
                v.X0 = t;
                v.Y0 = Lw;
                Lagrange(t + dt, out Lw);
                v.X0 = t;
                v.Y0 = Lw;
                v.color0 = Color.Black;
                v.Encender(lienzo);
                t = t + dt;

            } while (t <= Lvx[NDatos - 1]);
        }

        //proceso de beizer
        public void Bezier(double t, List<Double> Vx, List<Double> Vy, out double Xt, out double Yt)
        {
            Xt = 0;
            Yt = 0;

            int n = Lvx.Count - 1;
            for (int i = 0; i <= n; i++)
            {
                Xt = Xt + Vx[i] * (Factorial(n) / (Factorial(i) * Factorial(n - i))) * Math.Pow(1 - t, n - i) * Math.Pow(t, i);
                Yt = Yt + Vy[i] * (Factorial(n) / (Factorial(i) * Factorial(n - i))) * Math.Pow(1 - t, n - i) * Math.Pow(t, i);
            }

        }
        //encenderbezier
        public void EncenderBezier(Bitmap pixel)
        {
            double t, dt = 0.001;
            Vector v = new Vector();
            v.color0 = color0;
            t = 0;

            double Xt, Yt;
            do
            {
                Bezier(t, Lvx, Lvy, out Xt, out Yt);
                v.X0 = Xt;
                v.Y0 = Yt;
                v.Encender(pixel);
                t = t + dt;
            } while (t <= 1);

        }


        public double Factorial(double n)
        {
            return (n <= 1) ? 1 : (n * Factorial(n - 1));
        }

        public void RegresionLineal( List<Double> Lvx, List<Double> Lvy, out double m, out double q)
        {
            double Sx = 0, Sy = 0;
            int n = Lvx.Count;
            for (int j = 0; j <= n; j++)
            {
                Sx = Sx + Lvx[j];
                Sy = Sy + Lvy[j];
            }
            m = ((n + 1) * Sy) + Sy / (n + 2) * Sx;
            q = (Sy - m * Sx) / n + 1;
            //http://www.aprendematematicas.org.mx/notas/Cpp.pdf
        }

        //Encender Reg Lineal
        public void EncenderRegLineal(Bitmap pixel)
        {

            double t, dt = 0.002;
            Segmento v = new Segmento();
            v.color0 = color0;
            t = 0;
            do
            {
                RegresionLineal(Lvx, Lvy, out m, out q);
                v.X0 = -10;
                v.Y0 =m;
                v.Xf = 10;
                v.Yf = (m * 10) + q;
                v.Encender(pixel);
                t = t + dt;
            } while (t <= 1);

        }
        /*

        public void Bezier(double t, out double xt, out double yt, int contador, double[] vx, double[] vy)
        {
            int i, nfac, ifac, nifac;
            int facnum = contador - 1;
            factorial(facnum, out nfac);
            xt = 0; yt = 0;
            for (i = 0; i <= facnum; i++)
            {
                factorial(i, out ifac);
                factorial((facnum - i), out nifac);
                xt = (vx[i] * (nfac / (ifac * nifac)) * (Math.Pow(t, i)) * (Math.Pow((1 - t), (facnum - i)))) + xt;
                yt = (vy[i] * (nfac / (ifac * nifac)) * (Math.Pow(t, i)) * (Math.Pow((1 - t), (facnum - i)))) + yt;
            }
        }

        public void factorial(int num, out int factorial)
        {
            factorial = 1;
            if (num == 0)
                factorial = 1;
            else
            {
                for (int i = 1; i < num + 1; i++)
                {
                    factorial = factorial * i;
                }
            }
        }
        */
    }
}

