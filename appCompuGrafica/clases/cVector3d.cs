using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace appCompuGrafica
{
    class cVector3d:cVector
    {
        public double z0, alfa= Math.PI / 4;
        public int eje0 = 2;

        public void axonometria(double X0, double Y0, double Z0, out double ax, out double ay)
        {
            double x0 = 0.3;
            double alfa = Math.PI / 4; // = 45°
            ax = Y0 -  X0/2 * Math.Cos(alfa);
            ay = Z0 -  X0/2 * Math.Sin(alfa);
        }

        override public void encender(Bitmap bmp)
        {
            double ax, ay;
            int sx, sy;

            axonometria(x0, y0, z0, out ax, out ay);
            cBase oBase = new cBase();
            oBase.pantalla(ax, ay, out sx, out sy);
            if (sx > 0 && sx < 600 && sy > 0 && sy < 440)
            {
                bmp.SetPixel(sx, sy, color);
            }
        }

        public virtual void rotar3d(Bitmap lienzo, double vx, double vy, double vz, double beta, int eje, out double wx, out double wy, out double wz)
        {
            wx = 0; wy = 0; wz = 0;
            if (eje == 0) //Eje X
            {
                wx = vx;
                wy = vy * Math.Cos(beta) - vz * Math.Sin(beta);
                wz = vy * Math.Sin(beta) + vz * Math.Cos(beta);
            }
            else if (eje == 1) //Eje Y
            {
                wx = vx * Math.Cos(beta) + vz * Math.Sin(beta);
                wy = vy;
                wz = -vx * Math.Sin(beta) + vz * Math.Cos(beta);
            }
            else if (eje == 2) //Eje Z
            {
                wx = vx * Math.Cos(beta) - vy * Math.Sin(beta);
                wy = vx * Math.Sin(beta) + vy * Math.Cos(beta); ;
                wz = vz;
            }
        }

        public virtual void Apagar(Bitmap pixel)
        {
            //int sx, sy;
            //Base.ProcesoPantalla(this.x0, this.y0, out sx, out sy);
            //if (sx > 0 && sx < 600 && sy > 0 && sy < 440)
            //    pixel.SetPixel(sx, sy, Color.White);
            this.color = Color.White;
            encender(pixel);
        }
    }
}
