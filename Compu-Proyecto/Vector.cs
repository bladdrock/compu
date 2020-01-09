using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compu_Proyecto
{
    
    class Vector: LMatematica
    {
        public double X0, Y0; // posicion del vector 
        public Color color0; // color del vector 
        public Bitmap bit;
        public PictureBox lienzo3;
        public Graphics grafico;
    
        // constructor
        //constructor del vector
        public Vector(double x0s, double y0s, Color clr, Bitmap bi, PictureBox lienzos)
        {
            this.Y0 = y0s;
            this.X0 = x0s;
            this.color0 = clr;
            lienzo3 = lienzos;
            bit = bi;
            grafico = lienzo3.CreateGraphics();

        }
        public Vector() { }
        //Constructor
        public Vector(double x, double y, Color color)
        {

            this.X0 = x-5;
            this.Y0 = y-3.57;
            this.color0=color;
        }

        // destructor
        ~Vector() { }


        // Procesos
        public virtual void Encender(Bitmap pixel)
        {
            Base objBase = new Base();
            //// este el metodo encender pantalla para vectores
            int Sx0, Sy0;

            objBase.procesoPantlla(this.X0, this.Y0, out Sx0, out Sy0);
            if (Sx0 >= 0 && Sx0 < 560 && Sy0 >= 0 && Sy0 < 400)
            {
                //aqui recuerda cambiar a las dimensiones a las q estas trabajando
                pixel.SetPixel(Sx0, Sy0, color0);
            }
        }
        public virtual void Encender3()
        {
            int Sx0, Sy0;
            mPantalla(X0, Y0, out Sx0, out Sy0);
            if (Sx0 <= lienzo3.Width && Sx0 >= 0 && Sy0 <= lienzo3.Height && Sy0 >= 0)
                bit.SetPixel(Sx0, Sy0, color0);
            lienzo3.Image = bit;

        }

        // Procesos
        public virtual void Encender2(Bitmap pixel)
        {
            Base objBase = new Base();
            //// este el metodo encender pantalla para vectores
            int Sx0, Sy0;

            objBase.procesoPantlla2(this.X0, this.Y0, out Sx0, out Sy0);
            if (Sx0 > 0 && Sx0 < 560 && Sy0 > 0 && Sy0 < 400)
            {
                //aqui recuerda cambiar a las dimensiones a las q estas trabajando
                pixel.SetPixel(Sx0, Sy0, color0);
            }
        }

        public virtual void Apagar(Bitmap pixe)
        {
            color0 = Color.White;
            Encender(pixe);
        }

    }
    
    
}
