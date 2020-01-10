using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelNuevoCGWF
{
    class CurvasV : Circunferencia
    {
        public int Tipo;
        public CurvasV(double x0, double y0, int tipo, double rd, Color color0, Bitmap imprimir, PictureBox viewpoint) : base(x0, y0, rd, color0, imprimir, viewpoint)
        {
            this.X0 = x0;
            this.Y0 = y0;
            this.Tipo = tipo; 
            this.Rd = rd;
            this.Color0 = color0;
            this.Imprimir = imprimir;
            this.Viewpoint = viewpoint;
        }

        ~CurvasV() { }

        public override void Encender()
        {
            Vector v = new Vector(X0, Y0, Color0, Imprimir, Viewpoint);
            double x = 0, dx = 0.002;
            switch (Tipo)
            {
                case 0:
                    do
                    {
                        v.X0 = X0 + Rd * Math.Cos(3 * x);
                        v.Y0 = Y0 + Rd * Math.Sin(2 * x);
                        v.Encender();
                        x = x + dx;
                    } while (x <= 2 * Math.PI);
                    break;
                case 1:
                    do
                    {
                        v.X0 = X0 + Rd * Math.Pow(Math.Cos(x),3);
                        v.Y0 = Y0 + Rd * Math.Pow(Math.Sin(x),3);
                        v.Encender();
                        x = x + dx;
                    } while (x <= 2 * Math.PI);
                    break;
                case 2:
                    do
                    {
                        v.X0 = X0 + Rd * (Math.Cos(4*x)*Math.Cos(x))/1.5;
                        v.Y0 = Y0 + Rd * (Math.Cos(4 * x) * Math.Sin(x)) / 1.5;
                        v.Encender();
                        x = x + dx;
                    } while (x <= 2 * Math.PI);
                    break;                    
            }
            
        }

    }
}
