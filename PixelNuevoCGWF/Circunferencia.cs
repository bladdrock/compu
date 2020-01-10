using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelNuevoCGWF
{
    class Circunferencia : Vector
    {
        public double Rd;

        public Circunferencia(double x, double y, double rd, Color color, Bitmap imprimir, PictureBox viewpoint) : base(x, y, color, imprimir, viewpoint)
        {
            this.X0 = x;
            this.Y0 = y;
            this.Rd = rd; 
            this.Color0 = color;
            this.Imprimir = imprimir;
            this.Viewpoint = viewpoint;
        }

        ~Circunferencia() { }

        public override void Encender()
        {
            Vector v = new Vector(X0, Y0, Color0, Imprimir, Viewpoint);
            double x = 0, dx = 0.002;
            do
            {
                v.X0 = X0 + Rd * Math.Cos(x);
                v.Y0 = Y0 + Rd * Math.Sin(x);
                v.Encender();
                x += dx;
            } while (x<=2*Math.PI);
        }


        public void Ovalo()
        {
            Vector v = new Vector(X0, Y0, Color0, Imprimir, Viewpoint);
            double x = 0, dx = 0.002;
            do
            {
                v.X0 = X0 + 4 * Rd * Math.Cos(x);
                v.Y0 = Y0 + Rd * Math.Sin(x);
                v.Encender();
                x += dx;
            } while (x <= 2 * Math.PI);
        }
        public void medialuna()
        {
            double t = -0.10 * Math.PI, dt = 0.001;
            Vector objVector = new Vector(0, 0, Color0, Imprimir, Viewpoint);
            do
            {
                objVector.X0 = X0 + Rd * Math.Cos(t);
                objVector.Y0 = Y0 + Rd * Math.Sin(t);
                objVector.Encender();
                t = t + dt;

            } while (t <= 0.60 * Math.PI);

            Segmento objs = new Segmento(0, 0, 0, 0, Color0, Imprimir, Viewpoint);
            objs.X0 = X0 + Rd * Math.Cos(0.60 * Math.PI);
            objs.Y0 = Y0 + Rd * Math.Sin(0.60 * Math.PI);
            objs.Xf = X0 + Rd * Math.Cos(1.90 * Math.PI);
            objs.Yf = Y0 + Rd * Math.Sin(1.90 * Math.PI);
            objs.Encender();
        }
    }
}
