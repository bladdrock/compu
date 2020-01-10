using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ComputacionGrafica
{
    class Segmento:Vector
    {
        public double Xf, Yf;
        public override void Encender(Bitmap pixel)
        {
            double t = 0, dt = 0.001;  //rango del segmento 0-1
            Vector V = new Vector();
            do
            {
                V.X0 = X0 * (1 - t) + (Xf * t); //formula de la ecuacion de la recta 
                V.Y0 = Y0 * (1 - t) + (Yf * t);
                V.Color0 = Color0;
                V.Encender(pixel);
                t = t + dt;
            }
            while (t <= 1);
        }
        ~Segmento()
        { }
    }
}
