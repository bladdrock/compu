using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace appCompuGrafica
{
    class cEspiral : cVector3d
    {
        public double Altura;
        public override void encender(Bitmap lienzo)
        {
            cVector3d v3d = new cVector3d();
            cVector3d w3d = new cVector3d();
            double t = 0, dt = 0.001;
            for(t=0; t<= (6 * Math.PI); t+=dt)
            {
                v3d.x0 = x0 + (t/6) * Math.Cos(t);
                v3d.y0 = y0 + (t/6) * Math.Sin(t);
                v3d.z0 = z0 + t / Altura;
                v3d.encender(lienzo);
                Rotar3D(v3d.x0, v3d.y0, v3d.z0, alfa, eje0, out w3d.x0, out w3d.y0, out w3d.z0);
                w3d.color = Color.FromArgb(255 - (int)(t * 8.22), (int)(t * 13.53), 255 - (int)(t * 2.92));
               // w3d.color = color;
                w3d.encender(lienzo);
            };


        }

        public void Rotar3D(double vx, double vy, double vz, double beta, int eje, out double wx, out double wy, out double wz)
        {
            wx = 0;
            wy = 0;
            wz = 0;

            if (eje == 1)
            {  //eje x
                wx = vx;
                wy = vy * Math.Cos(beta) - vz * Math.Sin(beta);
                wz = vy * Math.Sin(beta) + vz * Math.Cos(beta);
            }
            if (eje == 0)
            {
                wx = vx * Math.Cos(beta) + vz * Math.Sin(beta);
                wy = vy;
                wz = -vx * Math.Sin(beta) + vz * Math.Cos(beta);
            }
            if (eje == 2)
            {
                wx = vx * Math.Cos(beta) - vy * Math.Sin(beta);
                wy = vx * Math.Sin(beta) + vy * Math.Cos(beta);
                wz = vz;
            }
        }

        public override void Apagar(Bitmap pixel)
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
