using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compu_Proyecto
{
    class Fractal1:Circunferencia
    {
        public double alfa, beta, radio;

        public void Arbol(Bitmap lienzo)
        {
            double rx, ry, alfa1, beta1, radio1;
            Segmento s = new Segmento();
            s.X0 = X0;
            s.Y0 = Y0;
            s.Xf = 1;
            s.Yf = 1;
            alfa1 = alfa;
            beta1 = beta;
            radio1 = radio;

            if (radio > 0.1)
            {
                s.Xf = X0 + (radio * Math.Cos(alfa));
                s.Yf = Y0 + (radio * Math.Sin(alfa));
                rx = s.Xf;
                ry = s.Yf;
                s.color0 = color0;
                s.Encender(lienzo);

                X0 = s.Xf;
                Y0 = s.Yf;
                radio = radio / 2;
                alfa = alfa - beta;
                Arbol(lienzo);

                X0 = s.Xf;
                Y0 = s.Yf;
                radio = radio1 / 2;
                alfa = alfa1 + beta1;
                Arbol(lienzo);

                //X0 = s.Xf;
                //Y0 = s.Yf;
                //radio = radio1 / 4;
                //alfa = alfa1 + beta1;
                //Arbol(lienzo);

                //X0 = s.Xf;
                //Y0 = s.Yf;
                //radio = radio1 / 4;
                //alfa = alfa1 - beta1;
                //Arbol(lienzo);

                X0 = s.Xf;
                Y0 = s.Yf;
                radio = radio1 / 1.7;
                alfa = alfa1;
                Arbol(lienzo);
            }
        }

        /*
        public void Luna(Bitmap lienzo)
        {

            double rx = 0.002;

            Circunferencia c = new Circunferencia();
            c.x0 = 7;
            c.y0 = 4.5;
            c.radio = 1.3;
            c.color0 = Color.White;
            c.Encender(lienzo);

            do
            {
                c.radio = rx;
                int r = (int)(((241 / 1.3) * (1.3 - rx)) + ((220 / 1.3) * (rx)));
                int g = (int)(((246 / 1.3) * (1.3 - rx)) + ((223 / 1.3) * (rx)));
                int b = (int)(((248 / 1.3) * (1.3 - rx)) + ((225 / 1.3) * (rx)));
                c.color0 = Color.FromArgb(r, g, b);
                c.Encender(lienzo);
                rx = rx + 0.003;
            }
            while (c.radio <= 1.3);

            do
            {
                c.radio = rx;
                c.color0 = Color.FromArgb((int)(-(200 * (rx - 2)) / 0.7), (int)(-(255 * (rx - 2)) / 0.7), (int)(-(255 * (rx - 2)) / 0.7));
                c.Encender(lienzo);
                rx = rx + 0.003;
            }
            while (rx <= 1.6);
        }

        public void Luna1(Bitmap lienzo)
        {

            double rx = 0.002;

            Circunferencia c = new Circunferencia();
            c.x0 = 9;
            c.y0 = 0;
            c.radio = 0.9;
            c.color0 = Color.White;
            c.Encender(lienzo);

            do
            {
                c.radio = rx;
                int r = (int)(((241 / 0.9) * (0.9 - rx)) + ((220 / 0.9) * (rx)));
                int g = (int)(((246 / 0.9) * (0.9 - rx)) + ((223 / 0.9) * (rx)));
                int b = (int)(((248 / 0.9) * (0.9 - rx)) + ((225 / 0.9) * (rx)));
                c.color0 = Color.FromArgb(r, g, b);
                c.Encender(lienzo);
                rx = rx + 0.003;
            }
            while (c.radio <= 0.9);
        }

        public void Luna2(Bitmap lienzo)
        {

            double rx = 0.002;

            Circunferencia c = new Circunferencia();
            c.x0 = 9;
            c.y0 = 1.5;
            c.radio = 0.7;
            c.color0 = Color.White;
            c.Encender(lienzo);

            do
            {
                c.radio = rx;
                int r = (int)(((241 / 0.7) * (0.7 - rx)) + ((220 / 0.7) * (rx)));
                int g = (int)(((246 / 0.7) * (0.7 - rx)) + ((223 / 0.7) * (rx)));
                int b = (int)(((248 / 0.7) * (0.7 - rx)) + ((225 / 0.7) * (rx)));
                c.color0 = Color.FromArgb(r, g, b);
                c.Encender(lienzo);
                rx = rx + 0.003;
            }
            while (c.radio <= 0.7);
        }

        public void Estrella(Bitmap lienzo)
        {
            double w = 0;

            Segmento s = new Segmento();

            do
            {
                s.x0 = x0;
                s.y0 = y0;
                s.xf = x0 + (radio * Math.Cos(w));
                s.yf = y0 + (radio * Math.Sin(w));
                s.color0 = color0;
                s.Encender(lienzo);
                w = w + (Math.PI / 6);
            }
            while (w <= (2 * Math.PI));
        }
        */
    }
}
