using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appCompuGrafica
{
    class cVector
    {
        public double x0, y0;
        public Color color;

        public cVector() { }
        ~cVector() { }

        public virtual void encender(Bitmap bmp)
        {
            int Xe, Ye;
            cBase oBase = new cBase();
            oBase.pantalla(this.x0, this.y0, out Xe, out Ye);
            if (Xe > 0 && Xe < 600 && Ye > 0 && Ye < 460)
            {
                bmp.SetPixel(Xe, Ye, color);
            }
        }

        public virtual void Apagar(Bitmap pixel)
        {
            //int sx, sy;
            //Base.ProcesoPantalla(this.x0, this.y0, out sx, out sy);
            //if (sx > 0 && sx < 600 && sy > 0 && sy < 440)
            //    pixel.SetPixel(sx, sy, Color.White);
            this.color = Color.White;
            encender(pixel);
        }
    }
}
