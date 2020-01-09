using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compu_Proyecto
{
    class Hiposila:Circunferencia
    {
        // alfa (t)=(sin(2t)), cos(3t)   ----lazo

        // constructor 
        public Hiposila() { }
        // destructor
        ~Hiposila() { }
        //double t, dt;
        public double op = 0;
        Vector vecLazo = new Vector(); // vector

        public override void Encender(Bitmap pixel)
        {
            t = 0;
            dt = 0.001;


            do
            {
                    vecLazo.X0 = X0 + Rad * (Math.Pow(Math.Sin(t), 3));
                    vecLazo.Y0 = Y0 + Rad * (Math.Pow(Math.Cos(t), 3));
                    vecLazo.color0 = color0;
                    vecLazo.Encender(pixel);
                    t = t + dt;
                

            } while (t <= 2 * Math.PI);



        }
    }
}
