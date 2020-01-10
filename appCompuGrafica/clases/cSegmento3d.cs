using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appCompuGrafica
{
    class cSegmento3d:cVector3d
    {
        public double xf, yf, zf;

        public override void encender(Bitmap bmp)
        {
            double t = 0, dt = 0.002;
            cVector3d oV3d = new cVector3d();

            do
            {
                oV3d.x0 = x0 + (xf - x0) * t;
                oV3d.y0 = y0 + (yf - y0) * t;
                oV3d.z0 = z0 + (zf - z0) * t;
                oV3d.color = color;
                oV3d.encender(bmp);
                t += dt;
            }
            while (t <= 1);
        }
    }
}
