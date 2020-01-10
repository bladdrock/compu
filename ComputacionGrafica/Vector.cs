using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ComputacionGrafica
{
    class Vector
    {
        public double X0 { get; set; }
        public double Y0 { get; set; }
        public Color Color0;

        public virtual void Encender(Bitmap pixel)
        {
            int SX0, SY0;
            Proceso Pant = new Proceso();
            Pant.Pantalla(X0, Y0, out SX0, out SY0);
            if (SX0 > 0 && SX0 < 560 && SY0 > 0 && SY0 < 400)
                pixel.SetPixel(SX0, SY0, Color0);
        }

        public virtual void Apagar(Bitmap pixel)
        {
            Color0 = Color.Black;
            int SX0, SY0;
            Proceso Pant = new Proceso();
            Pant.Pantalla(X0, Y0, out SX0, out SY0);
            if (SX0 > 0 && SX0 < 560 && SY0 > 0 && SY0 < 400)
                pixel.SetPixel(SX0, SY0, Color0);
        }
        public void setColorRGB(int red, int green, int blue)
        {
            this.Color0 = Color.FromArgb(red, green, blue);
        }

        ~Vector()
        { }
    }
}