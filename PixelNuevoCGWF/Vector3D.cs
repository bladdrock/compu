using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelNuevoCGWF
{
    class Vector3D : Vector
    {
        public double Z0;
        public Vector3D(double x0, double y0, double z0, Color color, Bitmap imprimir, PictureBox viewpoint) : base(x0, y0, color, imprimir, viewpoint)
        {
            this.Z0 = z0;

        }
        ~Vector3D() { }
        public void Axonometria(double x0, double y0, double z0, out double ax, out double ay)
        {
            double Alfa = Math.PI / 4;
            ax = y0 - (x0/2) * Math.Cos(Alfa);
            ay = z0 - (x0/2) * Math.Sin(Alfa);
        }
        public override void Encender()
        {
            double rx, ry;
            int Sx, Sy;
            Axonometria(X0, Y0, Z0, out rx, out ry);
            Pantalla19(rx, ry, out Sx, out Sy);
            if(Sx>0 && Sx<600 && Sy>0 && Sy < 460)
            {
                Imprimir.SetPixel(Sx, Sy, Color0);
                Viewpoint.Image = Imprimir;
            }

        }
        public override void Apagar()
        {
            Color0 = Color.WhiteSmoke;
            Encender();
        }
    }
}