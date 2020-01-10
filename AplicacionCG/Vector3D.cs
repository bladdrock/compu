using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AplicacionCG
{
    class Vector3D : Vector
    {
        public double z0;
        public Vector3D(double x0, double y0, double z0, Color color0, Bitmap lienzo, PictureBox ventanaP) : base(x0, y0, color0, lienzo, ventanaP)
        {
            this.z0 = z0;
        }
        public override void Encender()
        {
            double ax, ay;
            int Sx, Sy;
            Pantalla.Axonometria(X0, Y0, z0, out ax, out ay);
            Pantalla.Pantalla19(ax, ay, out Sx, out Sy);
            if (Sx > 0 && Sx < 560 && Sy > 0 && Sy < 400)
            {
                Lienzo.SetPixel(Sx, Sy, Color0);
                VentanaP.Image = Lienzo;
            }
        }
        ~Vector3D()
        {
        }

    }
}