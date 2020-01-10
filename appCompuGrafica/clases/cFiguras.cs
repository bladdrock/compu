using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appCompuGrafica
{
    class cFiguras:cCircunferencia
    {
        public void margarita(Bitmap bmp)
        {
            cVector oVector = new cVector();
            oVector.color = color;
            double t = 0;
            double dt = 0.001;
            do
            {
                oVector.x0 = x0 + ((rd * Math.Cos(6 * t) * Math.Cos(t)) / 2);
                oVector.y0 = y0 + ((rd * Math.Cos(6 * t) * Math.Sin(t)) / 2);
                oVector.encender(bmp);
                t = t + dt;
            } while (t <= 2 * Math.PI);
        }

        public void lazo(Bitmap bmp)
        {
            double t = 0, dt = 0.001;
            cVector vector = new cVector();
            vector.color = color;
            do
            {
                vector.x0 = x0 + rd * Math.Cos(3 * t);
                vector.y0 = y0 + rd * Math.Sin(2 * t);
                vector.encender(bmp);
                t = t + dt;
            } while (t <= (Math.PI * 2));
        }

        public void hipociclo(Bitmap bmp)
        {
            cVector oVector = new cVector();
            oVector.color = color;
            double t = 0;
            double dt = 0.001;
            do
            {
                oVector.x0 = x0 + (rd * Math.Pow(Math.Sin(t), 3));
                oVector.y0 = y0 + (rd * Math.Pow(Math.Cos(t), 3));
                oVector.encender(bmp);
                t = t + dt;
            } while (t <= 2 * Math.PI);
        }
    }
}
