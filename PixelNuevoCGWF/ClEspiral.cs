using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelNuevoCGWF
{

    class ClEspiral : Vector3D
    {
        //espiral
        public double elasticidd, rd, gama;
        public int eje;
        public ClEspiral(double Elasticidd, double rd, double x0, double y0, double z0, Color color0, Bitmap imprimir, PictureBox viewpoint) : base(x0, y0, z0, color0, imprimir, viewpoint)
        {
            this.elasticidd = Elasticidd;
            this.X0 = x0;
            this.Y0 = y0;
            this.Z0 = z0;
            this.rd = rd;
            this.Color0 = color0;
            this.Imprimir = imprimir;
            this.Viewpoint = viewpoint;
        }
        public override void Encender()
        {
            //Resorte
            Vector3D v3D = new Vector3D(0, 0, 0, Color.Blue, Imprimir, Viewpoint);
            Vector3D v3D1 = new Vector3D(0, 0, 0, Color.Blue, Imprimir, Viewpoint);
            double t = 0, dt = 0.002;

            //animacion
            do
            {
                v3D.X0 = X0 + rd * Math.Cos(t);
                v3D.Y0 = Y0 + rd * Math.Sin(t);
                v3D.Z0 = Z0 + (t / elasticidd);
                //v3D.Encender();
                RotacionEspacial(v3D.X0, v3D.Y0, v3D.Z0, gama, eje, out double x, out double y, out double z);
                v3D1.Color0 = Color.Red;
                v3D1.X0 = x;
                v3D1.Y0 = y;
                v3D1.Z0 = z;
                v3D1.Encender();
                t = t + dt;
            } while (t <= 6 * Math.PI);
        }

        public void RotacionEspacial(double Vx, double Vy, double Vz, double gama, int eje, out double Wx, out double Wy, out double Wz)
        {
            //eje 0 x
            Wx = Vx;
            Wy = Vy;
            Wz = Vy;

            if (eje == 0) //Eje X
            {
                Wx = Vx;
                Wy = Vy * Math.Cos(gama) - Vz * Math.Sin(gama);
                Wz = Vy * Math.Sin(gama) + Vz * Math.Cos(gama);
            }
            if (eje == 1) //Eje Y
            {
                Wx = Vx * Math.Cos(gama) + Vz * Math.Sin(gama);
                Wy = Vy;
                Wz = Vz * Math.Cos(gama) - Vx * Math.Sin(gama);
            }
            if (eje == 2) //Eje Z
            {
                Wx = Vx * Math.Cos(gama) - Vy * Math.Sin(gama);
                Wy = Vx * Math.Sin(gama) + Vy * Math.Cos(gama);
                Wz = Vz;
            }
        }
        public void apagarRotar(double gama, int eje)
        {
            Color0 = Color.WhiteSmoke;
            Encender();
        }
    }
}
