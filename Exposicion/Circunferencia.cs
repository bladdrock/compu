using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Exposicion
{
    class Circunferencia : Vector
    {
        public Double radio;
        public double v1;
        public override void Encender(Bitmap lienzo)
        {
            double t = 0, dt = 0.001;

            Vector v = new Vector();
            do
            {
                v.x0 = x0 + radio * Math.Cos(t);
                v.y0 = y0 + radio * Math.Sin(t);
                v.color0 = color0;
                v.Encender(lienzo);
                t += dt;
            } while (t <= (2 * Math.PI));
        }

        
        }
    }

