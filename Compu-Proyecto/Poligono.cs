using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compu_Proyecto
{
    
    class Poligono:Circunferencia
    {
        public int Nlados;
        //public double t, dt;
        //public double t;

        // constructor 
        public Poligono() { }

        // destructor
        ~Poligono() { }

        public override void Encender(Bitmap pixel)
        {
            Segmento seg = new Segmento();

            t = Math.PI / 2;
            dt = 2 * (Math.PI) / Nlados;

            do
            {
                seg.X0 = X0 + Rad * Math.Cos(t);
                seg.Y0 = Y0 + Rad * Math.Sin(t);
                seg.Xf = X0 + Rad * Math.Cos(t + dt);
                seg.Yf = X0 + Rad * Math.Sin(t + dt);
                seg.color0 = color0;
                seg.Encender(pixel);
                t = t + dt;
            } while (t <= (2.5 * Math.PI));//5*Math.PI/2

        }
    }
    
}
