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

        public  void EncenderGrueso()
        {
            Vector v = new Vector(X0, Y0, Color0, Imprimir, Viewpoint);
            int con = 0;
            do
            {


                double x = 0, dx = 0.002;
                do
                {
                    v.X0 = X0 + Rd * Math.Cos(x);
                    v.Y0 = Y0 + Rd * Math.Sin(x);
                    v.Encender();
                    x += dx;
                } while (x <= 2 * Math.PI);
                Rd = Rd - dx;
                con += 1;
            } while (con < 20);
        }
    }
}
