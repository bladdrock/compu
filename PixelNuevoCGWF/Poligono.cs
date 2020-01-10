using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelNuevoCGWF
{
    class Poligono : Circunferencia
    {
        public int NL { get; set; }

        public Poligono(double x0, double y0, double rd, int nl, Color color0, Bitmap imprimir, PictureBox viewpoint) : base(x0, y0, rd, color0, imprimir, viewpoint)
        {
            this.X0 = x0;
            this.Y0 = y0;
            this.Rd = rd;
            this.Color0 = color0;
            this.Imprimir = imprimir;
            this.Viewpoint = viewpoint;
            this.NL = nl;
        }

        ~Poligono() { }

        public override void Encender()
        {
            double A, B;
            B = (2 * Math.PI) / NL;
            A = Math.PI / 2;
            Segmento s = new Segmento(0, 0, 0, 0, Color0, Imprimir, Viewpoint);
            //for (int i = 1; i < 30; i = i + 2) ///Paracrear tela de araña
            //{
            for (int j = 0; j < NL; j++)
            {
                s.X0 = X0 + Rd * Math.Cos(A);
                s.Y0 = Y0 + Rd * Math.Sin(A);
                s.Xf = X0 + Rd * Math.Cos(A + B);
                s.Yf = Y0 + Rd * Math.Sin(A + B);
                s.Encender();

                Segmento seg1 = new Segmento(X0, Y0, s.Xf, s.Yf, Color0, Imprimir, Viewpoint);
                seg1.Encender();

                A = A + B;
            }
            //Rd = Rd + 1;
            //}
        }
        public void Encender2()
        {
            double A, B;
            B = 2 * Math.PI / NL;
            A = Math.PI / 4;
            Segmento s = new Segmento(0, 0, 0, 0, Color0, Imprimir, Viewpoint);
            for (int j = 0; j < NL; j++)
            {
                s.X0 = X0 + Rd * Math.Cos(A);
                s.Y0 = Y0 + Rd * Math.Sin(A);
                s.Xf = X0 + Rd * Math.Cos(A + B);
                s.Yf = Y0 + Rd * Math.Sin(A + B);
                s.Encender();
                A = A + B;
            }
        }
        public void EncenderEdfiVer()
        {
            double A, B;
            B = 2 * Math.PI / NL;
            A = Math.PI / 4;
            Segmento s = new Segmento(0, 0, 0, 0, Color0, Imprimir, Viewpoint);
            for (int j = 0; j < NL; j++)
            {
                s.X0 = X0 + Rd * Math.Cos(A);
                s.Y0 = Y0 + 2 * Rd * Math.Sin(A);
                s.Xf = X0 + Rd * Math.Cos(A + B);
                s.Yf = Y0 + 2 * Rd * Math.Sin(A + B);
                s.Encender();
                A = A + B;
            }
        }
        public void EncenderEdfiHor()
        {
            double A, B;
            B = 2 * Math.PI / NL;
            A = Math.PI / 4;
            Segmento s = new Segmento(0, 0, 0, 0, Color0, Imprimir, Viewpoint);
            for (int j = 0; j < NL; j++)
            {
                s.X0 = X0 + 2 * Rd * Math.Cos(A);
                s.Y0 = Y0 + Rd * Math.Sin(A);
                s.Xf = X0 + 2 * Rd * Math.Cos(A + B);
                s.Yf = Y0 + Rd * Math.Sin(A + B);
                s.Encender();
                A = A + B;
            }
        }
        public void EncenderEstrella5()
        {
            Segmento S = new Segmento(0, 0, 0, 0, Color0, Imprimir, Viewpoint);
            double alfa = (2 * Math.PI) / 5;
            double beta = Math.PI / 2;

            do
            {
                S.X0 = X0 + Rd * Math.Cos(beta);
                S.Y0 = Y0 + Rd * Math.Sin(beta);
                beta += alfa;
                S.Xf = X0 + Rd * Math.Cos(beta + alfa);
                S.Yf = Y0 + Rd * Math.Sin(beta + alfa);
                S.Color0 = Color0;
                S.Encender();
            } while (beta <= ((5 * Math.PI) / 2));
        }

        public void EncenderEstrella6()
        {
            Segmento S = new Segmento(0, 0, 0, 0, Color0, Imprimir, Viewpoint);
            double alfa = (2 * Math.PI) / 6;
            double beta = Math.PI / 2;

            do
            {
                S.X0 = X0 + Rd * Math.Cos(beta);
                S.Y0 = Y0 + Rd * Math.Sin(beta);
                beta += alfa;
                S.Xf = X0 + Rd * Math.Cos(beta + alfa);
                S.Yf = Y0 + Rd * Math.Sin(beta + alfa);
                S.Color0 = Color0;
                S.Encender();
            } while (beta <= (2 * Math.PI + Math.PI / 2));
        }
    }
}
