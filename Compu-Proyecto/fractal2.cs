using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compu_Proyecto
{
    class Fractal2:Circunferencia
    {
        // constructor
        public Fractal2() { }
        // destructor
        ~Fractal2() { }

        public void Mandelbrot(double xm, double ym, out int colorM)
        {
            double xn, yn, xn1, yn1, d;
            int i = 0;
            xn = xm;
            yn = ym;

            do
            {
                xn1 = (Math.Pow(xn, 2) - Math.Pow(yn, 2)) + xm;
                yn1 = (2 * xn * yn) + ym;
                d = (Math.Pow((xn1 - xm), 2) + Math.Pow((yn1 - ym), 2)); //distancia
                xn = xn1;
                yn = yn1;
                i = i + 1;
            }
            while ((d <= 6) && (i <= 100));

            if (i <= 100)
            {
                //diverge
                colorM = (i % 14) + 1;
            }
            else
            {
                //converge
                colorM = 0;
            }
        }

        public void GrafMandelbrot(Bitmap lienzo, Color[] paleta3)
        {

            int sx, sy, color2 = 0;
            double xr, yr;

            LMatematica r = new LMatematica();

            for (sx = 0; sx < 560; sx++)
            {
                for (sy = 0; sy < 400; sy++)
                {
                    r.RealXY(sx, sy, out xr, out yr);
                    Fractal2 F = new Fractal2();
                    F.Mandelbrot(xr, yr, out color2);
                    lienzo.SetPixel(sx, sy, paleta3[color2]);
                }
            }
        }

        public void Julia(double xm, double ym, out int colorM)
        {
            double xn, yn, xn1, yn1, d;
            int i = 0;
            xn = xm;
            yn = ym;

            do
            {
                xn1 = (Math.Pow(xn, 2) - Math.Pow(yn, 2)) - 1;
                yn1 = (2 * xn * yn) + 0.25;
                d = (Math.Pow((xn1 - 0), 2) + Math.Pow((yn1 - 0), 2)); //distancia
                xn = xn1;
                yn = yn1;
                i = i + 1;
            }
            while ((d <= 4) && (i <= 100));

            if (i <= 100)
            {
                //diverge
                colorM = (i % 14) + 1;
            }
            else
            {
                //converge
                colorM = 0;
            }
        }

        public void GrafJulia(Bitmap lienzo, Color[] paleta0)
        {

            int sx, sy, color2 = 0;
            double xr, yr;

            LMatematica r = new LMatematica();

            for (sx = 0; sx < 560; sx++)
            {
                for (sy = 0; sy < 400; sy++)
                {
                    r.RealXY(sx, sy, out xr, out yr);
                    Fractal2 F = new Fractal2();
                    F.Julia(xr, yr, out color2);
                    lienzo.SetPixel(sx, sy, paleta0[color2]);
                }
            }
        }
    }
}
