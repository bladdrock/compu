using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appCompuGrafica
{
    class Margarita:cLazo
    {
        public void encender(Bitmap bmp)
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
    }
}
