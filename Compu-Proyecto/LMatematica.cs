using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compu_Proyecto
{
    class LMatematica
    {
        public static int sx1 = 0;
        public static int sy1 = 0;
        public static int sx2 = 560;
        public static int sy2 = 400;
        public static double x1 = -10;
        public static double x2 = 10;
        public static double y1 = -7.14;
        public static double y2 = 7.14;

        public void mPantalla(double X, double Y, out int SX, out int SY)
        {
            SX = 0; SY = 0;
            SX = (int)Math.Truncate(((sx1 - sx2) / (x1 - x2)) * (X - x1)) + sx1;
            SY = (int)Math.Truncate(((sy1 - sy2) / (y2 - y1)) * (Y - y1)) + sy2;

        }

        public static void Pantalla(double x, double y, out int sx, out int sy)
        {
            sx = (int)(((sx1 - sx2) * (x - x2)) / (x1 - x2)) + sx2;
            sy = (int)(((sy1 - sy2) * (y - y1)) / (y2 - y1)) + sy2;
        }

        public void RealXY(int sx, int sy, out double x, out double y)
        {
            x = ((((sx - sx2) * (x2 - x1)) / (sx2 - sx1)) + x2);
            y = ((((sy - sy1) * (y1 - y2)) / (sy2 - sy1)) + y2);
        }

        public void Dinamico(int px, int py, out double x, out double y)
        {
            x = Math.Round(((px - sx2) * (x2 - x1)) / (sx2 - sx1)) + x2;
            y = Math.Round(((py - sy1) * (y1 - y2)) / (sy2 - sy1)) + y2;
        }

        //public static void Axonometria(double x0, double y0, double z0, out double ax, out double ay)
        //{
        //    double r = 0.5, alfa = Math.PI / 4;
        //    ax = y0 - (r * x0 * Math.Cos(alfa));
        //    ay = z0 - (r * x0 * Math.Sin(alfa));
        //}

        /*public void Rotar3D(double x,double y,double z,double teta ,int eje,out double xr,out double yr,out double zr)
        {
            xr = 0;
            yr = 0;
            zr = 0;

            if (eje == 0) //eje x
            {
                xr = x;
                yr = y * Math.Cos(teta) - z * Math.Sin(teta);
                zr = y * Math.Sin(teta) + z * Math.Cos(teta);
            }

            if (eje == 1) //eje y
            {
                xr = x * Math.Cos(teta) + z * Math.Sin(teta);
                yr = y;
                zr = -x * Math.Sin(teta) + z * Math.Cos(teta);
            }

            if (eje == 2) //eje z
            {
                xr = x * Math.Cos(teta) - y * Math.Sin(teta);
                yr = x * Math.Sin(teta) + y * Math.Cos(teta);
                zr = z;
            }
        }*/

            /*
        public void Cuadrilatero(double px, double py, double qx, double qy, double rx, double ry, double sx, double sy, Color color0, Bitmap lienzo)
        {
            double t, dt;
            Vector v1 = new Vector();
            Vector v2 = new Vector();
            Vector v3 = new Vector();
            Vector v4 = new Vector();
            t = 0;
            dt = 0.01;
            do
            {
                v1.x0 = px + ((qx - px) * t);
                v1.y0 = py + ((qy - py) * t);
                v1.color0 = color0;
                v1.Encender(lienzo);

                v2.x0 = qx + ((rx - qx) * t);

                v2.y0 = qy + ((ry - qy) * t);
                v2.color0 = color0;
                v2.Encender(lienzo);

                v3.x0 = rx + ((sx - rx) * t);
                v3.y0 = ry + ((sy - ry) * t);
                v3.color0 = color0;
                v3.Encender(lienzo);

                v4.x0 = sx + ((px - sx) * t);
                v4.y0 = sy + ((py - sy) * t);
                v4.color0 = color0;
                v4.Encender(lienzo);
                t = t + dt;
            }
            while (t <= 1);
        }
        */
    }
}
