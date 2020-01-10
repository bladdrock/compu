using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelNuevoCGWF
{
    class Espiral : Circunferencia
    {
        public double elasticidad { set; get; }
        public double Z0 { set; get; }
        public double gama { set; get; }
        public int eje { set; get; }
        public Espiral(double x0, double y0, double z0, double rd, double el, Color color0, Bitmap imprimir, PictureBox viewpoint) : base(x0, y0, rd, color0, imprimir, viewpoint)
        {
            this.X0 = x0;
            this.Y0 = y0;
            this.Z0 = z0;
            this.gama = gama;
            this.eje = eje;
            this.elasticidad = el;
            this.Rd = rd;
            this.Color0 = color0;
            this.Imprimir = imprimir;
            this.Viewpoint = viewpoint;
        }

        ~Espiral() { }

        public override void Encender()
        {
            Vector3D v3d = new Vector3D(0, 0, 0, Color0, Imprimir, Viewpoint);
            Vector3D w3d = new Vector3D(0, 0, 0, Color0, Imprimir, Viewpoint);
            double t, dt;
            double k = elasticidad;
            t = 0;
            dt = 0.002;
            double w3dx, w3dy, w3dz;
            do
            {
                v3d.X0 = X0 + Rd * Math.Cos(t);
                v3d.Y0 = Y0 + Rd * Math.Sin(t);
                v3d.Z0 = Z0 + (t / k);
                v3d.Color0 = Color.Blue;
                RotacionEspacial(v3d.X0, v3d.Y0, v3d.Z0, gama, eje, out w3dx, out w3dy, out w3dz);
                w3d.X0 = w3dx;
                w3d.Y0 = w3dy;
                w3d.Z0 = w3dz;
                w3d.Encender();
                t += dt;
            } while (t <= 6 * Math.PI);
        }

        public  void EncenderGirado()
        {
            Vector3D v3d = new Vector3D(0, 0, 0, Color0, Imprimir, Viewpoint);
            Vector3D w3d = new Vector3D(0, 0, 0, Color0, Imprimir, Viewpoint);
            double t, dt;
            double k = elasticidad;
            t = 0;
            dt = 0.001;
            Rd = 0;
            double w3dx, w3dy, w3dz;
            do
            {
                v3d.X0 = X0 + t * Math.Cos(t);
                v3d.Y0 = Y0 + t * Math.Sin(t);
                v3d.Z0 = Z0 + (t / k);
                v3d.Color0 = Color.Blue;
                RotacionEspacial(v3d.X0, v3d.Y0, v3d.Z0, (Math.PI/4), 0, out w3dx, out w3dy, out w3dz);
                w3d.X0 = w3dx;
                w3d.Y0 = w3dy;
                w3d.Z0 = w3dz;
                w3d.Encender();
                t += dt;
            } while (t <= 6 * Math.PI);
        }

        public void EncenderHorizontal()
        {
            Vector3D v3d = new Vector3D(0, 0, 0, Color0, Imprimir, Viewpoint);
            Vector3D w3d = new Vector3D(0, 0, 0, Color0, Imprimir, Viewpoint);
            double t, dt;
            double k = elasticidad;
            t = 0;
            dt = 0.002;
            double w3dx, w3dy, w3dz;
            do
            {
                t += dt;
                v3d.X0 = X0 + Rd*-t * Math.Cos(t);
                v3d.Y0 = Y0 + (t / k);
                v3d.Z0 = Z0 + Rd*-t * Math.Sin(t);
                v3d.Color0 = Color.Blue;
                RotacionEspacial(v3d.X0, v3d.Y0, v3d.Z0, gama, eje, out w3dx, out w3dy, out w3dz);
                w3d.X0 = w3dx;
                w3d.Y0 = w3dy;
                w3d.Z0 = w3dz;
                w3d.Encender();
                
            } while (t <= 6 * Math.PI);
        }
        public virtual void apagar2()
        {
            Color0 = Color.WhiteSmoke;
            Encender();
        }

        public void RotacionEspacial(double Vx, double Vy, double Vz, double gama, int eje, out double Wx, out double Wy, out double Wz)
        {
            Wx = Vx;
            Wy = Vy;
            Wz = Vz;
            if (eje == 0) //Eje X
            {
                Wx = Vx;
                Wy = Vy * Math.Cos(gama) - Vz * Math.Sin(gama);
                Wz = Vy * Math.Sin(gama) + Vz * Math.Cos(gama);
            }
            if(eje == 1) //Eje Y
            {
                Wx = Vx * Math.Cos(gama) + Vz * Math.Sin(gama);
                Wy = Vy;
                Wz = (Vz * Math.Cos(gama)) - (Vx * Math.Sin(gama));
            }
            if (eje == 2) //Eje Z
            {
                Wx = Vx * Math.Cos(gama) - Vy * Math.Sin(gama);
                Wy = Vx * Math.Sin(gama) + Vy * Math.Cos(gama);
                Wz = Vz;
            }
        }

        internal void RotacionEspacial(double x0, double y0, double z0, object gama, object eje, out double w3dx, out double w3dy, out double w3dz)
        {
            throw new NotImplementedException();
        }
    }
}
