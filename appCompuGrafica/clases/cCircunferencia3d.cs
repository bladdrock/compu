using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appCompuGrafica
{
    class cCircunferencia3d : cSegmento3d
    {
        public double rd = 1;
        public Color colorR;

        public cCircunferencia3d() { }
        ~cCircunferencia3d() { }

        public void encender(Bitmap bmp)
        {
            cVector3d v = new cVector3d();
            v.color = color;
            for (double i = 0; i <= Math.PI * 2; i += 0.002)
            {
                v.x0 = 4.5 + rd * Math.Cos(i);
                v.y0 = -0.5 + rd * Math.Sin(i);
                v.z0 = 0;
                v.encender(bmp);
            }
        }

        public void encender3(Bitmap bmp)
        {
            cVector3d v = new cVector3d();
            v.color = color;
            for(double i=0;i<=Math.PI*2; i += 0.002)
            {
                v.x0 = 4.5 + rd * Math.Cos(i);
                v.y0 = -0.5 + rd * Math.Sin(i);
                v.z0 = 0;
                v.encender(bmp);
            }
            for (double i = 0; i <= Math.PI * 2; i += 0.002)
            {
                v.z0 = -4.5 + rd * Math.Cos(i);
                v.y0 = -3 + rd * Math.Sin(i);
                v.x0 = 0;
                v.encender(bmp);
            }
            for (double i = 0; i <= Math.PI * 2; i += 0.002)
            {
                v.x0 = -1 + rd * Math.Cos(i);
                v.z0 = -4 + rd * Math.Sin(i);
                v.y0 = 0;
                v.encender(bmp);
            }
        }


    }
}
