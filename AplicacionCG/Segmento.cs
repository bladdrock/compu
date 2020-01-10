using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AplicacionCG
{
    class Segmento : Vector
    {
        public double Xf;
        public double Yf;
        public Segmento(double x0, double y0, double xf, double yf, Color color0, Bitmap lienzo, PictureBox ventanaP)
            : base(x0, y0, color0, lienzo, ventanaP)

        {
            Xf = xf;
            Yf = yf;
        }
        public override void Encender()
        {
            double t = 0;
            double dt = 0.0013;
            Vector V = new Vector(0, 0, Color0, Lienzo, VentanaP);
            do
            {
                // V.X0 = X0 + (Xf + X0) * x;
                //V.Y0 = Y0 + (Yf - Y0) * x;
                V.X0 = X0 * (1 - t) + Xf * t;
                V.Y0 = Y0 * (1 - t) + Yf * t;
                V.Encender();
                t = t + dt;

            } while (t <= 1);
        }
        public override void Apagar()
        {
            Color0 = Color.Black;
            Encender();
        }
        ~Segmento()
        {
        }
    }
}