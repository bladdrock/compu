using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace appCompuGrafica
{
    class cSegmento:cVector
    {
        public double Xf;
        public double Yf;
        public Color color;

        public cSegmento() { }
        ~cSegmento() { }

        public override void encender(Bitmap bmp)
        {
            cVector oVector = new cVector();
            oVector.color = color;
            double t = 0;
            double dt = 0.001;
            do
            {
                oVector.x0 = (x0 * (1 - t)) + (Xf * t);
                oVector.y0 = (y0 * (1 - t)) + (Yf * t);
                oVector.encender(bmp);
                t = t + dt;
            } while (t <= 1);
        }

        public void cortada(Bitmap bmp, double dt)
        {
            cVector oVector = new cVector();
            double t = 0;
            dt = (dt == 0) ? 0.001:dt;

            do
            {
                oVector.x0 = (x0 * (1 - t)) + (Xf * t);
                oVector.y0 = (y0 * (1 - t)) + (Yf * t);
                oVector.color = color;
                oVector.encender(bmp);
                t = t + dt;
            } while (t <= 1);
        }

        public void encenderLargo(Bitmap bmp, double medio, double largo)
        {
            largo /= 2;

            cVector oVector = new cVector();

            x0 = (medio - largo);
            Xf = (medio + largo);

            for (double i=x0;i<=Xf;i+=0.001)
            { 
                oVector.x0 = (x0 * (1 - i)) + (Xf * i);
                oVector.y0 = (y0 * (1 - i)) + (Yf * i);
                oVector.color = color;
                oVector.encender(bmp);
            }
        }

        public override void Apagar(Bitmap pixel)
        {
            this.color = Color.White;
            encender(pixel);
        }

        public double longitud()
        {
            return Math.Sqrt(Math.Pow(Xf - x0, 2) + Math.Pow(Yf - y0, 2));
        }
    }
}
