using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace appCompuGrafica
{
    class cCircunferencia:cVector
    {
        public double rd;
        public double xf;
        public double yf;
        public double aR; //angulo R para rotacion

        public cCircunferencia() { }
        ~cCircunferencia() { }

        public void encender(Bitmap bmp)
        {
            cVector oVector = new cVector();
            double t = -Math.PI;
            double dt = 0.001;
            do
            {
                oVector.x0 = x0 + (rd * Math.Cos(t));
                oVector.y0 = y0 + (rd * Math.Sin(t));
                oVector.color = color;
                oVector.encender(bmp);
                t = t + dt;
            } while (t <= Math.PI);
        }

        public void funcionRaiz(Bitmap pixel)
        {
            cVector oVector = new cVector();
            oVector.color = Color.Blue;
            double j = 0;
            for(double i = -10; i <= 10; i += 0.001)
            {
                j = Math.Sqrt(i * i + 2);
                oVector.x0 = i;
                oVector.y0 = j;
                oVector.encender(pixel);
            }

            // x/sqrt(x^2+2)
            //y - y1 = m (x -x1)
            double x = 2;
            double m = x / Math.Sqrt(x * x + 2);
            double y1 = Math.Sqrt(x * x + 2);

            oVector.color = Color.Fuchsia;
            //double x = 2;
            //double dx = x / Math.Sqrt(x * x + 2);
            for (double i = -10; i <= 10; i += 0.001)
            {
                double y = (m*-1) * (x - i) + y1;
                //j = i / Math.Sqrt(i * i + 2);
                oVector.x0 = i;
                oVector.y0 = y;
                oVector.encender(pixel);
            }

            cSegmento oSeg = new cSegmento();
            oSeg.color = Color.Red;
            oSeg.x0 = -10;
            oSeg.y0 = -6;
            oSeg.Xf = 10;
            oSeg.Yf = 8;
            oSeg.encender(pixel);

        }
        //cCircunferencia
        public void animarTangente(Bitmap pixel, double x)
        {
            //Graficar la función pixel a pixel
            cVector oVector = new cVector();
            oVector.color = Color.Blue;
            double j = 0;
            for (double i = -10; i <= 10; i += 0.001)
            {
                //f(x) = cos(x)
                j = Math.Cos(i);
                oVector.x0 = i;
                oVector.y0 = j;
                oVector.encender(pixel);
            }
            //Hallar la pendiente atraves de la primera derivada de f(x)
            double m = - Math.Sin(x);
            if (m == 0)
                return;
            //Hallar y1 en el punto x
            double y1 = Math.Cos(x);
            //Crear la tangente de tipo cSegmento
            cSegmento tangente = new cSegmento();
            tangente.color = color;
            //Colocar las coordenadas de x0 y xf
            tangente.x0 = -10;
            tangente.Xf =  10;

            //Hallar y0, yf con la ecuación de la recta en los puntos extremos (-10,10)
            tangente.y0 = (m * -1) * (x + 10) + y1;
            tangente.Yf = (m * -1) * (x - 10) + y1;
            tangente.encender(pixel);
        }

        public void encenderLogo(Bitmap bmp)
        {
            cVector oVector = new cVector();
            double t = Math.PI*5/6;
            double dt = 0.001;
            do
            {
                oVector.x0 = x0 + (rd * Math.Cos(t));
                oVector.y0 = y0 + (rd * Math.Sin(t));
                oVector.color = color;
                oVector.encender(bmp);
                t = t + dt;
            } while (t <= Math.PI*2);

            t = 0;
            do
            {
                oVector.x0 = x0 + 2*rd + (rd * Math.Cos(t));
                oVector.y0 = y0  - 0.4 + (rd * Math.Sin(t));
                oVector.color = color;
                oVector.encender(bmp);
                t = t + dt;
            } while (t <= Math.PI );
        }

        public void rotar(double vx, double vy, double gama, out double rx, out double ry)
        {
            rx = (vx - x0) * Math.Cos(gama)- (vy - y0) * Math.Sin(gama) + x0;
            ry = (vx - x0) * Math.Sin(gama) + (vy - y0) * Math.Cos(gama) + y0;
        }

        public override void Apagar(Bitmap pixel)
        {
            this.color = Color.White;
            encender(pixel);
        }
    }
}
