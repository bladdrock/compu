using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace appCompuGrafica
{
    class Hipociclo:cLazo
    {
        public void encender(Bitmap bmp)
        {
            cVector oVector = new cVector();
            double t = 0;
            double dt = 0.001;
            do
            {
                oVector.x0 = x0 + (rd * Math.Pow(Math.Sin(t), 3));
                oVector.y0 = y0 + (rd * Math.Pow(Math.Cos(t), 3));
                oVector.color = Color.Blue;
                oVector.encender(bmp);
                t = t + dt;
            } while (t <= 2*Math.PI);
        }
    }
}
