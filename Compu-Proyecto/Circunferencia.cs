using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compu_Proyecto
{
    
    class Circunferencia:Vector
    {
        public Double Rad;


        // constructor 
        public Circunferencia() { }
        // destructor
        ~Circunferencia() { }


        public double t, dt; // 

        public override void Encender(Bitmap pixel)
        {
            Vector vCirc = new Vector(); // vector
            t = 0;
            dt = 0.001;
            do
            {
                vCirc.X0 = X0 + Rad * Math.Cos(t);
                vCirc.Y0 = Y0 + Rad * Math.Sin(t);
                vCirc.color0 = color0;
                vCirc.Encender(pixel);
                t = t + dt;
            } while (t <= 2 * Math.PI);
            //while (t <= tf);

        }
       
    }
    
}
