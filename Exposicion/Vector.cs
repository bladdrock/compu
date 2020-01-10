using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Exposicion
{
    class Vector:RepMat
    {
        public double x0;
        public double y0;
        public Color color0;
        public virtual void Encender(Bitmap lienzo)
        {
            int sx, sy;
            RepMat.pantalla(this.x0, this.y0, out sx, out sy);
            if (sx > 0 && sx < 600 && sy > 0 && sy < 500)
            {
                lienzo.SetPixel(sx, sy, color0);
            }
        }
        public virtual void Apagar(Bitmap lienzo)
        {
            color0 = Color.White;
            Encender(lienzo);
        }
    }
}
