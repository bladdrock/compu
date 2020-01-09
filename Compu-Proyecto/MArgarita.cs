using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compu_Proyecto
{
    class MArgarita:Circunferencia
    {
        // alfa (t)=(sin(2t)), cos(3t)   ----lazo

        // constructor 
        public MArgarita() { }
        // destructor
        ~MArgarita() { }
        //double t, dt;
        public double op = 0;
        Vector vecLazo = new Vector(); // vector

        public override void Encender(Bitmap pixel)
        {
            t = 0;
            dt = 0.001;


            do
            {
           
                    vecLazo.X0 = X0 + Rad * ((Math.Cos(4 * t)) * (Math.Cos(t)));
                    vecLazo.Y0 = Y0 + Rad * ((Math.Cos(4 * t)) * (Math.Sin(t)));
                    vecLazo.color0 = color0;
                    vecLazo.Encender(pixel);
                    t = t + dt;
           

            } while (t <= 2 * Math.PI);



        }
    }
}
