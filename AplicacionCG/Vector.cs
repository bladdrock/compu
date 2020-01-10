using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionCG
{
    class Vector : Pantalla
    {
        public double X0;
        public double Y0;
        public Color Color0;
        public Bitmap Lienzo;
        public PictureBox VentanaP;
        public Vector(double x0, double y0, Color color0, Bitmap lienzo, PictureBox ventanaP)
        {
            X0 = x0;
            Y0 = y0;
            Color0 = color0;
            Lienzo = lienzo;
            VentanaP = ventanaP;

        }
        public Vector(Color color0, Bitmap lienzo, PictureBox ventanaP)
        {
            Color0 = color0;
            Lienzo = lienzo;
            VentanaP = ventanaP;
        }
        public virtual void Encender()
        {
            Pantalla.Pantalla19(this.X0, this.Y0, out int Sx, out int Sy);
            if (Sx > 0 && Sx < 560 && Sy > 0 && Sy < 400)
            {
                Lienzo.SetPixel(Sx, Sy, Color0);
                VentanaP.Image = Lienzo;
            }
        }
        public virtual void Apagar()
        {
            Color0 = Color.Black;
            Encender();
        }
        ~Vector()
        {
        }
    }

}
