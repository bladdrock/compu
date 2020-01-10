using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appCompuGrafica
{
    class cFractales2:cVector
    {
        public Color[] paletaColor = new Color[15] {
                    Color.Black,        Color.Navy,         Color.Green,        Color.Red,
                    Color.Purple,       Color.Maroon,       Color.LightGray,    Color.DarkGray,
                    Color.Blue,         Color.Lime,         Color.Silver,       Color.Teal,
                    Color.Fuchsia,      Color.Yellow,       Color.White };

        public Color[] paletaColor2 = new Color[16];
        public Color color2 = new Color();
        
        public cFractales2()
        {
            paletaColor2[0] = Color.Black;
            for (int i=0; i<15; i++)
            {
                paletaColor2[i+1] = Color.FromArgb(0, (int)(18.214 * i), 255);
            }
        }

        public Color mandelbrot(double x0, double y0)
        {
            double Xn1, Xn, Yn1, Yn, radio;
            int i = 0;
            Xn = x0; Yn = y0;
            do
            {
                Xn1 = Math.Pow(Xn, 2) - Math.Pow(Yn, 2) + x0;
                Yn1 = 2 * Xn * Yn + y0;
                radio = Math.Sqrt(Math.Pow(Xn1 - x0, 2) + Math.Pow(Yn1 - y0, 2));
                Xn = Xn1;
                Yn = Yn1;
                i++;                    
            }
            while (i <= 100 && radio<=2);

            return (radio<2)?Color.Black:paletaColor2[(i % 15)];
        }

        public Color julia(double x0, double y0)
        {
            double Xn1, Xn, Yn1, Yn, radio;
            int i = 0;
            Xn = x0; Yn = y0;
            do
            {
                Xn1 = Math.Pow(Xn, 2) - Math.Pow(Yn, 2) - 1;
                Yn1 = 2 * Xn * Yn + 0.25;
                radio = Math.Sqrt(Math.Pow(Xn1 - 0, 2) + Math.Pow(Yn1 - 0, 2));
                Xn = Xn1;
                Yn = Yn1;
                i++;
            }
            while (i <= 100 && radio <= 2);

            return (radio < 2) ? Color.Black : paletaColor[(i % 15)];
        }

        public void graficarMandelbrot(Bitmap bmp)
        {
            double rx, ry;
            //int cmodel;
            cBase oBase = new cBase();
            for (int i=0;i<600;i++)
                for (int j = 0; j < 440; j++)
                {
                    oBase.carta(i, j, out rx, out ry);
                    x0 = i;y0 = j;
                    color= mandelbrot(rx, ry);
                    //encender(bmp);
                    bmp.SetPixel(i, j, color);
                }
        }

        public void graficarJulia(Bitmap bmp)
        {
            double rx, ry;
            //int cmodel;
            cBase oBase = new cBase();
            for (int i = 0; i < 600; i++)
                for (int j = 0; j < 440; j++)
                {
                    oBase.carta(i, j, out rx, out ry);
                    x0 = i; y0 = j;
                    color = julia(rx, ry);
                    //encender(bmp);
                    bmp.SetPixel(i, j, color);
                }
        }

        public void sierpinski(Bitmap bmp,double Px, double Py, double Qx, double Qy, double Rx, double Ry)
        {
            double Mx = (Px + Qx) / 2;
            double My = (Py + Qy) / 2;
            double Nx = (Rx + Qx) / 2;
            double Ny = (Ry + Qy) / 2;
            double Sx = (Px + Rx) / 2;
            double Sy = (Py + Ry) / 2;

            double dt = Math.Sqrt(Math.Pow(Mx - Nx, 2) + Math.Pow(My - Ny, 2));
            cSegmento oTriangulo = new cSegmento();
            oTriangulo.color = color2;
            //Segun dF = 0.1 formula distancia
            if (dt > 0.1)
            {
                oTriangulo.x0 = Mx; //Mx
                oTriangulo.Xf = Nx; //Nx
                oTriangulo.y0 = My; //My
                oTriangulo.Yf = Ny; //Ny
                oTriangulo.encender(bmp);
                oTriangulo.x0 = Nx; //Nx
                oTriangulo.Xf = Sx; //Sx
                oTriangulo.y0 = Ny; //Ny
                oTriangulo.Yf = Sy; //Sy
                oTriangulo.encender(bmp);
                oTriangulo.x0 = Sx; //Sx
                oTriangulo.Xf = Mx; //Mx
                oTriangulo.y0 = Sy; //Ny
                oTriangulo.Yf = My; //My
                oTriangulo.encender(bmp);
                sierpinski(bmp,Nx, Ny, Sx, Sy, Rx, Ry);
                sierpinski(bmp,Mx, My, Px, Py, Sx, Sy);
                sierpinski(bmp,Nx, Ny, Qx, Qy, Mx, My);
                //numero--;
            }
            else
            {
                //Sierpinski(pixel, nveces - 1, x1, y1, pmx1, pmy1);
                return;
            }

        }

        public void sierpinski(Bitmap lienzo, int n, double Px, double Py, double Qx, double Qy, double Rx, double Ry)
        {
            double Mx = (Px + Qx) / 2;
            double My = (Py + Qy) / 2;
            double Nx = (Rx + Qx) / 2;
            double Ny = (Ry + Qy) / 2;
            double Sx = (Px + Rx) / 2;
            double Sy = (Py + Ry) / 2;
            double dt = Math.Sqrt(Math.Pow(Mx - Nx, 2) + Math.Pow(My - Ny, 2));

            cSegmento oTriangulo = new cSegmento();
            oTriangulo.color = color;
            oTriangulo.x0 = Px+x0;
            oTriangulo.Xf = Qx+x0;
            oTriangulo.y0 = Py+y0;
            oTriangulo.Yf = Qy+y0;
            oTriangulo.encender(lienzo);
            oTriangulo.x0 = Qx+x0;
            oTriangulo.Xf = Rx+x0;
            oTriangulo.y0 = Qy+y0;
            oTriangulo.Yf = Ry+y0;
            oTriangulo.encender(lienzo);
            oTriangulo.x0 = Rx+x0;
            oTriangulo.Xf = Px+x0;
            oTriangulo.y0 = Ry+y0;
            oTriangulo.Yf = Py+y0;
            oTriangulo.encender(lienzo);
            //Segun dF = 0.1 formula distancia
            if (dt > 0.1 && n>=1)
            {
                oTriangulo.x0 = Mx+x0; //Mx
                oTriangulo.Xf = Nx+x0; //Nx
                oTriangulo.y0 = My+y0; //My
                oTriangulo.Yf = Ny+y0; //Ny
                oTriangulo.encender(lienzo);
                oTriangulo.x0 = Nx+x0; //Nx
                oTriangulo.Xf = Sx+x0; //Sx
                oTriangulo.y0 = Ny+y0; //Ny
                oTriangulo.Yf = Sy+y0; //Sy
                oTriangulo.encender(lienzo);
                oTriangulo.x0 = Sx+x0; //Sx
                oTriangulo.Xf = Mx+x0; //Mx
                oTriangulo.y0 = Sy+y0; //Ny
                oTriangulo.Yf = My+y0; //My
                oTriangulo.encender(lienzo);
                sierpinski(lienzo,n-1, Nx, Ny, Sx, Sy, Rx, Ry);
                sierpinski(lienzo,n-1, Mx, My, Px, Py, Sx, Sy);
                sierpinski(lienzo,n-1, Nx, Ny, Qx, Qy, Mx, My);
            }
            else
            {
                //Sierpinski(pixel, nveces - 1, x1, y1, pmx1, pmy1);
                return;
            }

        }
    }
}
