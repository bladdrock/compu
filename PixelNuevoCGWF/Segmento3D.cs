using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelNuevoCGWF
{
    class Segmento3D : Vector3D
    {
        public double Xf;

        public double Yf;

        public double Zf;
        public Segmento3D(double x0, double y0, double z0, double xf, double yf, double zf, Color color, Bitmap imprimir, PictureBox viewpoint) : base(x0, y0, z0, color, imprimir, viewpoint)
        {

            Xf = xf;
            Yf = yf;
            Zf = zf;
            this.Color0 = color;
            this.Imprimir = imprimir;
            this.Viewpoint = viewpoint;
        }
        public override void Encender()
        {
            double x = 0;
            double dx = 0.002;
            Vector3D v3D = new Vector3D(0, 0, 0, Color0, Imprimir, Viewpoint);
            do
            {
                v3D.X0 = X0 + (Xf - X0) * x;
                v3D.Y0 = Y0 + (Yf - Y0) * x;
                v3D.Z0 = Z0 + (Zf - Z0) * x;
                v3D.Color0 = Color0;
                v3D.Encender();
                x = x + dx;
            } while (x <= 1);
        }
    }
}
