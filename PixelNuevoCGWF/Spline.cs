using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelNuevoCGWF
{
    class Spline
    {
        List<double> h = new List<double>();
        List<double> alfa = new List<double>();
        List<double> l = new List<double>();
        List<double> u = new List<double>();
        List<double> z = new List<double>();

        public void coeficientesSpline(int cont, double[] vx, double[] vy, out double[] a, out double[] b, out double[] c, out double[] d)
        {
            a = new double[1000];
            b = new double[1000];
            c = new double[1000];
            d = new double[1000];
            double[] h = new double[260];
            double[] alfa = new double[260];
            double[] l = new double[260];
            double[] u = new double[260];
            double[] z = new double[260];
            int m = cont - 1;
            int j;

            for (int i = 1; i <= m; i = i + 1)
            {
                a[i] = vy[i];
            }

            for (int i = 0; i <= m; i = i + 1)
            {
                h[i] = vx[i + 1] - vx[i];
            }
            for (int i = 1; i <= m; i = i + 1)
            {

                alfa[i] = 3.0 * (vy[i + 1] * h[i - 1] - vy[i] * (vx[i + 1] - vx[i - 1]) + vy[i - 1] * h[i]) / (h[i] * h[i - 1]);

            }
            l[0] = 1.0;
            u[0] = 0.0;
            z[0] = 0.0;

            for (int i = 1; i <= m; i = i + 1)
            {
                l[i] = 2.0 * (vx[i + 1] - vx[i - 1]) - h[i - 1] * u[i - 1];
                u[i] = h[i] / l[i];
                z[i] = (alfa[i] - h[i - 1] * z[i - 1]) / l[i];
            }
            l[cont] = 1.0;
            z[cont] = 0.0;
            c[cont] = 0.0;

            for (int i = 0; i <= m; i = i + 1)
            {
                j = m - i;
                c[j] = z[j] - u[j] * c[j + 1];
                b[j] = (vy[j + 1] - vy[j]) / h[j] - h[j] * (c[j + 1] + 2 * c[j]) / 3;
                d[j] = (c[j + 1] - c[j]) / (3 * h[j]);
            }
        }

        public void funcSx(double t, int cont, double[] vx, double[] a, double[] b, double[] c, double[] d, out double sx)
        {
            sx = 0;
            for (int i = 0; i < cont; i = i + 1)
            {
                if (t >= vx[i] && t <= vx[i + 1])
                    sx = a[i] + b[i] * (t - vx[i]) + c[i] * (Math.Pow((t - vx[i]), 2)) + d[i] * (Math.Pow((t - vx[i]), 3));
            }
        }
    }
}
