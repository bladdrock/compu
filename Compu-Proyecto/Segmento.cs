using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compu_Proyecto
{
    class Segmento:Vector
    {
        public double Xf, Yf;

        // constructor
        public Segmento(double x0c, double y0c, double xfc, double yfc, Color clc, Bitmap bi, PictureBox pic)
        {
            X0 = x0c;
            Y0 = y0c;
            this.Xf = xfc;
            this.Yf = yfc;
            bit = bi;
            color0 = clc;
            lienzo3 = pic;

        }
        public Segmento() { }
        // destructor
        ~Segmento() { }

        
        public override void Encender(Bitmap pixel)
        {
            double t, dt;
            Vector vec = new Vector();
            t = 0;
            dt = 0.001;
            do
            {
                vec.X0 = X0 * (1 - t) + (Xf * t);
                vec.Y0 = Y0 * (1 - t) + (Yf * t);
                vec.color0 = color0;
                vec.Encender(pixel);
                t = t + dt;
            }
            while (t <= 1);
        }

        public override void Encender3()
        {
            //d mide la distancia de los punto señanalados
            //formula normal d= rais cuadrada de ((X0-Xf)+(Yo-Yf)2)
            //double t = 0;
            //double d = Math.Abs((x0 - Xf) + (y0 - Yf));
            //double dt = ((1 / (10 * (d + 1))));
            double t = 0, dt = 0.001;
            Vector vec = new Vector(0, 0, color0, bit, lienzo3);
            do
            {
                vec.X0 = (X0 * (1 - t) + Xf * t)*0.85;
                vec.Y0 = (Y0 * (1 - t) + Yf * t)*0.85;
                // vec.color0 =  Color.FromArgb((int)(255), (int)(255*t/1), (int)(20 *(t-1)/-1));
                vec.Encender3();
                t += dt;
            } while (t <= 1);
        }

    }
}
