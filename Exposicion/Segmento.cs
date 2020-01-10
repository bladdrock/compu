using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Exposicion
{
    class Segmento : Vector
    {
        public double xf, yf;
        public override void Encender(Bitmap lienzo)
        {
            Vector v = new Vector();
            double t = 0, dt = 0.001;
            do
            {
                v.x0 = x0 * (1 - t) + xf * (t);
                v.y0 = y0 * (1 - t) + yf * (t);                
                v.color0 = color0;
                v.Encender(lienzo);
                t = t + dt;
            } while (t <= 1);
        }        
    }
}
