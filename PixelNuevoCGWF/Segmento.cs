using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelNuevoCGWF
{
    class Segmento : Vector
    {
        public double Xf, Yf;

        public Segmento(double x, double y, double xf, double yf, Color color,Bitmap imprimir, PictureBox viewpoint) : base (x,y,color,imprimir,viewpoint)
        {
            this.X0 = x;
            this.Y0 = y;
            this.Xf = xf;
            this.Yf = yf;
            this.Color0 = color;
            this.Imprimir = imprimir;
            this.Viewpoint = viewpoint;
        }

        ~Segmento() { }

        public override void Encender()
        {            
            //Matemática Vectorial

            Vector v = new Vector(X0, Y0, Color0, Imprimir, Viewpoint);
            double x = 0, dx = 0.002;
            do
            {
                v.X0 = X0 + (Xf - X0) * x;
                v.Y0 = Y0 + (Yf-Y0) * x;
                //v.Color0 = Color.FromArgb((int)(255 - (255 * x)), 0, (int)(255 * x));
                v.Encender();
                x += dx;
            } while (x <= 1);
        }
    }
}

