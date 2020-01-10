using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appCompuGrafica
{
    class cCurvasAjuste
    {
        List<double> vx1 = new List<double>();
        List<double> vy1 = new List<double>();
        public int nd, n;
        private Color Color;
        public cCurvasAjuste()
        { }

        public cCurvasAjuste(int ndatos, List<double> vx, List<double> vy, Color c)
        {
            this.nd = ndatos;
            this.vx1 = vx;
            this.vy1 = vy;
            Color = c;
        }

        //proceso de lagrange
        public void lagrange(double x, out double z)
        {
            double p, s = 0;

            for (int i = 0; i < nd; i++)
            {
                p = 1;
                for (int j = 0; j < nd; j++)
                {
                    if (j != i)
                    {
                        p = p * (x - vx1[j]) / (vx1[i] - vx1[j]);
                    }
                }

                s = s + vy1[i] * p;

            }
            z = s;
        }


        // para encender lagrange
        public void encenderLagrange(Bitmap pixel)
        {
            double t = vx1[0];
            double Lw, dt = 0.002;
            do
            {
                cVector v = new cVector();
                lagrange(t, out Lw);
                v.x0 = t;
                v.y0 = Lw;
                v.color = Color;
                v.encender(pixel);
                t = t + dt;
            } while (t <= vx1[nd - 1]);
        }

        // animar lagrange
        public void animarLagrange(Bitmap pixel)
        {

            double t = vx1[0];
            double Lw, dt = 0.002;
            cCircunferencia v = new cCircunferencia();
            v.rd = 1;
            do
            {
                lagrange(t, out Lw);
                v.x0 = t;
                v.y0 = Lw;
                v.color = Color;
                v.encender(pixel);
                t = t + dt;
            } while (t <= vx1[nd - 1]);
        }

        public void encenderPoligonal(Bitmap pixel)
        {
            cSegmento v = new cSegmento();
            v.color = Color;
            for (int i= 0; i < nd-1; i++)
            {
                v.x0 = vx1[i];
                v.y0 = vy1[i];
                v.Xf = vx1[i+1];
                v.Yf = vy1[i+1];
                v.encender(pixel);
            }
        }

        //polinomio de beizer
        //factorial
        public double Factorial(double n)
        {
          return (n <= 1)?1: (n * Factorial(n - 1));
        }


        //proceso de beizer
        public void Bezier(double t, List<Double> Vx, List<Double> Vy, out double Xt, out double Yt)
        {
            Xt = 0;
            Yt = 0;

            int n = vx1.Count - 1;
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
            cVector v = new cVector();
            v.color = Color;
            t = 0;

            double Xt, Yt;
            do
            {
                Bezier(t, vx1, vy1, out Xt, out Yt);
                v.x0 = Xt;
                v.y0 = Yt;
                //v.color = Color.FromArgb((int)(255*t),Color.G, (int)(255 * t));
                v.encender(pixel);
                t = t + dt;
            } while (t <= 1);

        }

        public void regresionLineal(Bitmap bmp)
        {
            double a, b=0;
            double pxy, sx, sy, sx2, sy2;
            pxy = sx = sy = sx2 = sy2 = 0.0;
            for (int i = 0; i < nd; i++)
            {
                sx += vx1[i];
                sy += vy1[i];
                sx2 += vx1[i] * vx1[i];
                sy2 += vy1[i] * vy1[i];
                pxy += vx1[i] * vy1[i];
            }

            cSegmento oSegmento = new cSegmento();
            oSegmento.color = Color;

            a = (nd * pxy - sx * sy) / (nd * sx2 - sx * sx);
            b = (sy - a * sx) / nd;

            sx = sx / nd;
            sy = sy / nd;
            double y = a + b*sx ;
            oSegmento.x0 = sx;
            oSegmento.y0 = sy;
            oSegmento.Xf = -10;
            y = a + b * -10;
            oSegmento.Yf = y; 
            oSegmento.encender(bmp);

            oSegmento.x0 = 0;
            oSegmento.y0 = b;
            oSegmento.Xf = 10;
            y = a + (b) * (10);
            oSegmento.Yf = y;
            oSegmento.encender(bmp);
        }

        public double correlacionLineal()
        {
            //valores medios
            double suma = 0.0;
            for (int i = 0; i < n; i++)
            {
                suma += vx1[i];
            }
            double mediaX = suma / n;

            suma = 0.0;
            for (int i = 0; i < n; i++)
            {
                suma += vy1[i];
            }
            double mediaY = suma / n;
            //coeficiente de correlación
            double pxy, sx2, sy2;
            pxy = sx2 = sy2 = 0.0;
            for (int i = 0; i < n; i++)
            {
                pxy += (vx1[i] - mediaX) * (vy1[i] - mediaY);
                sx2 += (vx1[i] - mediaX) * (vx1[i] - mediaX);
                sy2 += (vy1[i] - mediaY) * (vy1[i] - mediaY);
            }
            return pxy / Math.Sqrt(sx2 * sy2);
        }


        ////
        ////Spline
        //public static double[] Spline(double w, List<Double> Vx, List<Double> Vy)
        //{
        //    int i;
        //    int n = Vx.Count;
        //    double[] h = new double[100];
        //    double[] b = new double[100];
        //    double[] u = new double[100];
        //    double[] v = new double[100];
        //    double[] z = new double[100];
        //    double[] A = new double[100];
        //    double[] B = new double[100];
        //    double[] C = new double[100];
        //    double[] S = new double[100];

        //    for (i = 0; i < n - 1; i++)
        //    {
        //        h[i] = Vx[i + 1] - Vx[i];
        //        b[i] = 6 * (Vy[i + 1] - Vy[i]) / h[i];
        //    }
        //    u[i] = 2 * (h[0] + h[1]);
        //    v[i] = b[i] - b[0];
        //    for (i = 2; i < n - 1; i++)
        //    {
        //        u[i] = 2 * (h[i] + h[i - 1]) - Math.Pow(h[i - 1], 2) / u[i - 1];
        //        v[i] = b[i] - b[i - 1] - (h[i - 1] * v[i - 1]) / u[i - 1];
        //    }
        //    z[n] = 0;
        //    for (i = n - 1; i > 1; i--)
        //    {
        //        z[i] = (v[i] - h[i] * z[i + 1]) / u[i];
        //    }
        //    z[0] = 0;
        //    for (i = 0; i < n - 1; i++)
        //    {
        //        A[i] = (1 / 6 * (h[i])) * (z[i + 1] - z[i]);
        //        B[i] = (z[i] / 2);
        //        C[i] = -(h[i] / 6) * z[i + 1] - (h[i] / 3) * z[i] + (1 / h[i]) * (Vy[i + 1] - Vy[i]);
        //    }
        //    for (i = 0; i < n - 1; i++)
        //    {
        //        S[i] = Vy[i] + (w + Vx[i]) * (C[i] + (w - Vx[i]) * B[i] + (w - Vx[i]) * A[i]);
        //    }
        //    return S;
        //}


    }
}
