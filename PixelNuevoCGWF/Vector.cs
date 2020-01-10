using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelNuevoCGWF
{
    class Vector : ClPantalla
    {

        public double X0 { get; set; }
        public double Y0 { get; set; }
        public Color Color0 { get; set; }
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
            Color0 = Color.WhiteSmoke;
            Encender(); 
        }

        public void Cuadrilatero1(double Px, double Py, double Qx, double Qy, double Rx, double Ry, double Tx, double Ty, int tipo)
        {
            int SPx, SPy, SQx, SQy, SRx, SRy, STx, STy;
            Pantalla19(Px, Py, out SPx, out SPy);
            Pantalla19(Qx, Qy, out SQx, out SQy);
            Pantalla19(Rx, Ry, out SRx, out SRy);
            Pantalla19(Tx, Ty, out STx, out STy);
            Point p1 = new Point(SPx, SPy);
            Point p2 = new Point(SQx, SQy);
            Point p3 = new Point(SRx, SRy);
            Point p4 = new Point(STx, STy);
            Point[] p = { p1, p2, p3, p4 };
            Pen pn;         //// Color Perfil
            Graphics g;     //// Color Relleno 

            if (tipo==0)
            {
                pn = new Pen(Color.Green, 2);          //// Color Perfil
                g = Graphics.FromImage(Imprimir);
                g.DrawPolygon(pn, p);
                g.FillPolygon(new SolidBrush(Color.WhiteSmoke), p);  //// Color Relleno 
                Viewpoint.Image = Imprimir;

            }
            else if (tipo == 1)
            {
                pn = new Pen(Color.Green, 2);          //// Color Perfil
                g = Graphics.FromImage(Imprimir);
                g.DrawPolygon(pn, p);
                g.FillPolygon(new SolidBrush(Color.Blue), p);  //// Color Relleno 
                Viewpoint.Image = Imprimir;

            }
            else if (tipo == 2)
            {
                pn = new Pen(Color.Fuchsia, 2);          //// Color Perfil
                g = Graphics.FromImage(Imprimir);
                g.DrawPolygon(pn, p);
                g.FillPolygon(new SolidBrush(Color.Gray), p);  //// Color Relleno 
                Viewpoint.Image = Imprimir;

            }
        }
        public void Cuadrilatero(double Px, double Py, double Qx, double Qy, double Rx, double Ry, double Tx, double Ty, int tipo)
        {
            Segmento ss = new Segmento(Px, Py, Qx, Qy, Color.Green, Imprimir, Viewpoint);
            Segmento ss1 = new Segmento(Qx, Qy, Rx, Ry, Color.Green, Imprimir, Viewpoint);
            Segmento ss2 = new Segmento(Rx, Ry, Tx, Ty, Color.Green, Imprimir, Viewpoint);
            Segmento ss3 = new Segmento(Tx, Ty, Px, Py, Color.Green, Imprimir, Viewpoint);
            Segmento s = new Segmento(Px, Py, Qx, Qy, Color.Fuchsia, Imprimir, Viewpoint);
            Segmento s1 = new Segmento(Qx, Qy, Rx, Ry, Color.Fuchsia, Imprimir, Viewpoint);
            Segmento s2 = new Segmento(Rx, Ry, Tx, Ty, Color.Fuchsia, Imprimir, Viewpoint);
            Segmento s3 = new Segmento(Tx, Ty, Px, Py, Color.Fuchsia, Imprimir, Viewpoint);
            int x, y;
            Pantalla19((Px + Rx) / 2, (Py + Ry) / 2, out x, out y);
            Point pt2 = new Point(x, y);
            if (tipo == 0)
            {
                ss.Encender();
                ss1.Encender();
                ss2.Encender();
                ss3.Encender();
                RellenoInundacion(pt2, Color.Green, Color.Transparent);
                Viewpoint.Image = Imprimir;
            }
            if (tipo == 1)
            {
                ss.Encender();
                ss1.Encender();
                ss2.Encender();
                ss3.Encender();
                RellenoInundacion(pt2, Color.Green, Color.Blue);
            }
            if (tipo == 2)
            {
                s.Encender();
                s1.Encender();
                s2.Encender();
                s3.Encender();
                RellenoInundacion(pt2, Color.Fuchsia, Color.Gray);
            }
        }
        private void RellenoInundacion(Point pt, Color ColorBorde, Color ColorFondo)
        {
            Stack<Point> pixels = new Stack<Point>();
            ColorBorde = Imprimir.GetPixel(pt.X, pt.Y);
            pixels.Push(pt);
            while (pixels.Count > 0)
            {
                Point a = pixels.Pop();
                if (a.X < Imprimir.Width && a.X > 0 && a.Y < Imprimir.Height && a.Y > 0)
                {
                    if (Imprimir.GetPixel(a.X, a.Y) == ColorBorde)
                    {
                        Imprimir.SetPixel(a.X, a.Y, ColorFondo);
                        pixels.Push(new Point(a.X - 1, a.Y));
                        pixels.Push(new Point(a.X + 1, a.Y));
                        pixels.Push(new Point(a.X, a.Y - 1));
                        pixels.Push(new Point(a.X, a.Y + 1));
                    }
                }
            }
            Viewpoint.Refresh();
            return;
        }

    }
}
