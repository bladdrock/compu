using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PixelNuevoCGWF
{
    class Vector : pantalla
    {

        public double X0 { get; set; }
        public double Y0 { get; set; }
        public Color Color0 { get; set; }
        public Color Color1 { get; set; }
        public Bitmap Imprimir { get; set; }
        public PictureBox Viewpoint { get; set; }

        public Vector (double _X0, double _Y0, Color _Color0, Bitmap _Imprimir, PictureBox _Viewpoint)
        {
            X0 = _X0;
            Y0 = _Y0;
            Color0 = _Color0;
            Imprimir = _Imprimir;
            Viewpoint = _Viewpoint; 
        }

        ~ Vector() { }

        public virtual void Encender()
        {
            int SX, SY;
            Pantalla19(X0, Y0, out SX, out SY);
            if(SX >= 0 && SX < 600 && SY >= 0 && SY < 460){
                Imprimir.SetPixel(SX, SY, Color0);
                Viewpoint.Image = Imprimir; 
            }
        }

        public virtual void Apagar()
        {
            Color0 = Color.Cyan;
            Encender(); 
        }
    }
}
