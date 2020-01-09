using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compu_Proyecto
{
    class Fractal
    {
        public Fractal()
        {
        }
        ~Fractal()
        { }

        public void Mandelbrot(double X0, double Y0, out int ColorM)
        {
            double Xn1, Yn1, Xn, Yn, d;
            Xn = X0;
            Yn = Y0;
            ColorM = 0;
            int conti = 0;
            do //El 100 es depende donde querramo ubicar al fractal
            {

                Xn1 = Math.Pow(Xn, 2) - (Math.Pow(Yn, 2)) + X0;
                Yn1 = (2 * Xn * Yn) + Y0;

                d = Math.Sqrt(Math.Pow(Xn1 - X0, 2) + Math.Pow(Yn1 - Y0, 2));

                if (d >= 2)
                {
                    break;
                }
                else
                {
                    Xn = Xn1;
                    Yn = Yn1;
                    conti = conti + 1;
                }

            } while (d <= 2 && conti <= 100);

            if (conti >= 100) //converge
            {
                ColorM = 0;
            }
            else// no converge
            {

                ColorM = (conti % 15 + 1);
            }
        }

        public void Julia(double X0, double Y0, out int ColorM)
        {
            double Xn1, Yn1, Xn, Yn, d;
            Xn = X0;
            Yn = Y0;
            ColorM = 0;
            int conti = 0;
            do //El 100 es depende donde querramo ubicar al fractal
            {

                Xn1 = Math.Pow(Xn, 2) - (Math.Pow(Yn, 2)) - 1;
                Yn1 = (2 * Xn * Yn) + 0.25;

                d = Math.Sqrt(Math.Pow(Xn1,2 ) + Math.Pow(Yn1 , 2));

                if (d >= 2)
                {

                    break;
                }
                else
                {
                    Xn = Xn1;
                    Yn = Yn1;
                    conti = conti + 1;
                }

            } while (d <= 2 && conti <= 100);

            if (conti >= 100) //converge
            {
                ColorM = 0;
            }
            else// no converge
            {

                ColorM = (conti % 15 + 1);
            }
        }
        public void Sierpinski(double Px, double Py, double Rx, double Ry, double Qx, double Qy, Bitmap lienzo)
        {

            double Mx, Nx, Sx;
            double My, Ny, Sy;


            Mx = (Px + Rx) / 2;
            My = (Py + Ry) / 2;


            Nx = (Rx + Qx) / 2;
            Ny = (Ry + Qy) / 2;

            Sx = (Px + Qx) / 2;
            Sy = (Py + Qy) / 2;

            Segmento seg = new Segmento();

            seg.X0 = Mx;
            seg.Y0 = My;
            seg.Xf = Nx;
            seg.Yf = Ny;
            seg.color0 = Color.Blue;
            seg.Encender(lienzo);

            seg.X0 = Nx;
            seg.Y0 = Ny;
            seg.Xf = Sx;
            seg.Yf = Sy;
            seg.color0 = Color.Blue;
            seg.Encender(lienzo);

            seg.X0 = Sx;
            seg.Y0 = Sy;
            seg.Xf = Mx;
            seg.Yf = My;
            seg.color0 = Color.Blue;
            seg.Encender(lienzo);


            double d = Math.Sqrt(Math.Pow(Sx - Mx, 2) + Math.Pow(Sy - My, 2));

            if (d > 0.1)
            {
                Sierpinski(Sx, Sy, Nx, Ny, Qx, Qy, lienzo);
                Sierpinski(Sx, Sy, Mx, My, Px, Py, lienzo);
                Sierpinski(Mx, My, Rx, Ry, Nx, Ny, lienzo);
            }

        }
        public void Cantor(Bitmap lienzo, int nveces, double x1, double y1, double x2, double y2)
        {
            Segmento S = new Segmento();
            S.X0 = x1;
            S.Y0 = y1 + 1;
            S.Xf = x2;
            S.Yf = y2 + 1;
            S.color0 = Color.Blue;
            S.Encender(lienzo);

            double dx = (x2 - x1) / 3;
            double gdx = x1 + dx;
            double gdx2 = x2 - dx;
            if (nveces > 0.1)
            {
                S.X0 = gdx2;
                S.Y0 = y1;
                S.Xf = x2;
                S.Yf = y2;
                S.color0 = Color.Blue;
                S.Encender(lienzo);
                Cantor(lienzo, nveces - 1, gdx2, y1 - 1, x2, y2 - 1);

                S.X0 = x1;
                S.Y0 = y1;
                S.Xf = gdx;
                S.Yf = y2;
                S.color0 = Color.Blue;
                S.Encender(lienzo);
                Cantor(lienzo, nveces - 1, x1, y1 - 1, gdx, y2 - 1);
            }

        }
    }
}
