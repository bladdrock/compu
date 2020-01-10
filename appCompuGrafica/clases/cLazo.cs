using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace appCompuGrafica
{
    class cLazo:cCircunferencia
    {
        cVector Tv = new cVector();
        public void encender(Bitmap bmp)
        {
            double t = 0, dt = 0.001;

            do
            {
                cVector vector = new cVector();
                vector.x0 = x0 + rd * Math.Cos(3 * t);
                vector.y0 = y0 + rd * Math.Sin(2 * t);
                vector.color = color;
                vector.encender(bmp);
                t = t + dt;
            } while (t <= (Math.PI * 2));
        }

        public void rotar(Bitmap bmp)
        {
            double t = 0, dt = 0.001;
            double w = 0.02;
            do
            {
                cVector vector = new cVector();
                vector.x0 = x0 + rd * Math.Cos(3 * t);
                vector.y0 = y0 + rd * Math.Sin(2 * t);
                vector.color = color;
                rotar(vector.x0, vector.y0, aR, out Tv.x0,out Tv.y0);
                Tv.color = Color.Blue;
                Tv.encender(bmp);
                t = t + dt;
            } while (t <= (Math.PI * 2));
        }

        public void Apagar(Bitmap pixel)
        {
            this.color = Color.White;
            encender(pixel);
        }

    }
}
