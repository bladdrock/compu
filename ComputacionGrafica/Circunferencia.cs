using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ComputacionGrafica
{
    class Circunferencia:Vector
    {
        public double Rad;
        public override void Encender(Bitmap pixel)
        {
            double t = 0, dt = 0.005;
            Vector V = new Vector();
            do
            {
                V.X0 = X0 + Rad * Math.Cos(t);
                V.Y0 = Y0 + Rad * Math.Sin(t);
                V.Color0 = Color0;
                V.Encender(pixel);
                t = t + dt;
            } while (t <= (2 * Math.PI));
        }
        ~Circunferencia()
        { }
    }
}
