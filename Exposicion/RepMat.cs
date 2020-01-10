using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Exposicion
{
    class RepMat
    {
        static int sx1 = 0;
        public static int sx2 = 600;
        static int sy1 = 0;        
        public static int sy2 = 500;
        public static double x1 = -10;
        public static double y1 = -8;
        public static double x2 = 10;
        public static double y2 = 8;

        public static void pantalla(double x, double y, out int sx, out int sy)
        {
            sx = (int)Math.Truncate((((sx2 - sx1) / (x2 - x1)) * (x - x2)) + sx2);
            sy = (int)Math.Truncate((((sy1 - sy2) / (y2 - y1)) * (y - y2)) + sy1);
        }

        public void carta(int px, int py, out double x, out double y)
        {
            x = (((px - sx2) * (x2 - x1)) / (sx2 - sx1)) + x2;
            y = (((py - sy1) * (y1 - y2)) / (sy2 - sy1)) + y2;
        }      
        
        public double Lagrange(double x, double[] vx, double[] vy, int cont)
        {
            double s = 0;
            double p;
            for (int i = 0; i < cont; i++)
            {
                p = 1;
                for (int j = 0; j < cont; j++)
                {
                    if (i != j)
                    {
                        p = p * (x - vx[j]) / (vx[i] - vx[j]);
                    }
                }
                s = s + vy[i] * p;
            }
            return (s);
        }

        public void Bezier(double t, out double xt, out double yt, int contador, double[] vx, double[] vy)
        {
            int i, nfac, ifac, nifac;
            int facnum = contador - 1;
            factorial(facnum, out nfac);
            xt = 0; yt = 0;
            for (i = 0; i <= facnum; i++)
            {
                factorial(i, out ifac);
                factorial((facnum - i), out nifac);
                xt = (vx[i] * (nfac / (ifac * nifac)) * (Math.Pow(t, i)) * (Math.Pow((1 - t), (facnum - i)))) + xt;
                yt = (vy[i] * (nfac / (ifac * nifac)) * (Math.Pow(t, i)) * (Math.Pow((1 - t), (facnum - i)))) + yt;
            }
        }

        public void factorial(int num, out int factorial)
        {
            factorial = 1;
            if (num == 0)
                factorial = 1;
            else
            {
                for (int i = 1; i < num + 1; i++)
                {
                    factorial = factorial * i;
                }
            }
        }

        public void RotarD(double x, double y, double dx, double dy, double teta, out double ry, out double rx)
        {
            rx = ((x - dx) * Math.Cos(teta)) - ((y - dy) * Math.Sin(teta)) + dx;
            ry = ((x - dx) * Math.Sin(teta)) + ((y - dy) * Math.Cos(teta)) + dy;
        }

        public void RotarI(double x, double y, double dx, double dy, double teta, out double rx, out double ry)
        {
            rx = ((x - dx) * Math.Cos(teta)) - ((y - dy) * Math.Sin(teta)) + dx;
            ry = ((x - dx) * Math.Sin(teta)) + ((y - dy) * Math.Cos(teta)) + dy;
        }

        public static void Axonometria(double x, double y, double z, out double ax, out double ay)
        {
            double ro = 0.5;
            double alfa = Math.PI / 4; // = 45°
            ax = y - ro * x * Math.Cos(alfa);
            ay = z - ro * x * Math.Sin(alfa);
        }

        public static void Cuadrilatero(double Px, double Py, double Qx, double Qy, double Rx, double Ry, double Sx, double Sy, Color color0, Bitmap lienzo)
        {
            double t, dt;
            Vector v1 = new Vector();
            Vector v2 = new Vector();
            Vector v3 = new Vector();
            Vector v4 = new Vector();
            t = 0;
            dt = 0.01;
            do
            {
                v1.x0 = Px + ((Qx - Px) * t);
                v1.y0 = Py + ((Qy - Py) * t);
                v1.color0 = color0;
                v1.Encender(lienzo);

                v2.x0 = Qx + ((Rx - Qx) * t);
                v2.y0 = Qy + ((Ry - Qy) * t);
                v2.color0 = color0;
                v2.Encender(lienzo);

                v3.x0 = Rx + ((Sx - Rx) * t);
                v3.y0 = Ry + ((Sy - Ry) * t);
                v3.color0 = color0;
                v3.Encender(lienzo);

                v4.x0 = Sx + ((Px - Sx) * t);
                v4.y0 = Sy + ((Py - Sy) * t);
                v4.color0 = color0;
                v4.Encender(lienzo);

                t = t + dt;
            } while (t <= 1);
        }

        public static void Cuadrilatero2(double Px, double Py, double Qx, double Qy, double Rx, double Ry, double Tx, double Ty, Color color0, Bitmap lienzo)
        {
            int SPx, SPy, SQx, SQy, SRx, SRy, STx, STy;
            pantalla(Px, Py, out SPx, out SPy);
            pantalla(Qx, Qy, out SQx, out SQy);
            pantalla(Rx, Ry, out SRx, out SRy);
            pantalla(Tx, Ty, out STx, out STy);
            Point p1 = new Point(SPx, SPy);
            Point p2 = new Point(SQx, SQy);
            Point p3 = new Point(SRx, SRy);
            Point p4 = new Point(STx, STy);
            Point[] p = { p1, p2, p3, p4 };
            Pen pn = new Pen(Color.Green, 2);          //// Color Perfil
            Graphics g = Graphics.FromImage(lienzo);
            g.DrawPolygon(pn, p);
            g.FillPolygon(new SolidBrush(Color.Blue), p);  //// Color Relleno                   
        }

        public static void Cuadrilatero3(double Px, double Py, double Qx, double Qy, double Rx, double Ry, double Tx, double Ty, Color color0, Bitmap lienzo)
        {
            int SPx, SPy, SQx, SQy, SRx, SRy, STx, STy;
            pantalla(Px, Py, out SPx, out SPy);
            pantalla(Qx, Qy, out SQx, out SQy);
            pantalla(Rx, Ry, out SRx, out SRy);
            pantalla(Tx, Ty, out STx, out STy);
            Point p1 = new Point(SPx, SPy);
            Point p2 = new Point(SQx, SQy);
            Point p3 = new Point(SRx, SRy);
            Point p4 = new Point(STx, STy);
            Point[] p = { p1, p2, p3, p4 };
            Pen pn = new Pen(Color.Fuchsia, 2);       //// Color Perfil
            Graphics g = Graphics.FromImage(lienzo);
            g.DrawPolygon(pn, p);
            g.FillPolygon(new SolidBrush(Color.LightGray), p);  //// Color Relleno
        }

        public static void Cuadrilatero4(double Px, double Py, double Qx, double Qy, double Rx, double Ry, double Tx, double Ty, Color color0, Color color1,Bitmap lienzo)
        {
            int SPx, SPy, SQx, SQy, SRx, SRy, STx, STy;
            pantalla(Px, Py, out SPx, out SPy);
            pantalla(Qx, Qy, out SQx, out SQy);
            pantalla(Rx, Ry, out SRx, out SRy);
            pantalla(Tx, Ty, out STx, out STy);
            Point p1 = new Point(SPx, SPy);
            Point p2 = new Point(SQx, SQy);
            Point p3 = new Point(SRx, SRy);
            Point p4 = new Point(STx, STy);
            Point[] p = { p1, p2, p3, p4 };
            Pen pn = new Pen(color0, 2);       //// Color Perfil
            Graphics g = Graphics.FromImage(lienzo);
            g.DrawPolygon(pn, p);
            g.FillPolygon(new SolidBrush(color1), p);  //// Color Relleno              

        }


        public void Cuadrilatero22(double Px, double Py, double Qx, double Qy, double Rx, double Ry, double Tx, double Ty, Color color0, Bitmap lienzo)
        {
            RepMat m = new RepMat();
            int SPx, SPy, SQx, SQy, SRx, SRy, STx, STy;
            pantalla(Px, Py, out SPx, out SPy);
            pantalla(Qx, Qy, out SQx, out SQy);
            pantalla(Rx, Ry, out SRx, out SRy);
            pantalla(Tx, Ty, out STx, out STy);
            Point p1 = new Point(SPx, SPy);
            Point p2 = new Point(SQx, SQy);
            Point p3 = new Point(SRx, SRy);
            Point p4 = new Point(STx, STy);
            Point[] p = { p1, p2, p3, p4 };
            Pen pn = new Pen(color0, 1);          //// Color Perfil
            Graphics g = Graphics.FromImage(lienzo);
            g.DrawPolygon(pn, p);
            g.FillPolygon(new SolidBrush(color0), p);  //// Color Relleno                   
        }


        public void Rotar_eje(double x, double y, double z, double teta, string eje, out double rx, out double ry, out double rz)
        {
            rx = 0;
            ry = 0;
            rz = 0;
            if (eje == "X")
            {
                rx = x;
                ry = y * Math.Cos(teta) - z * Math.Sin(teta);
                rz = y * Math.Sin(teta) + z * Math.Cos(teta);
            }
            else
            if (eje == "Y")
            {
                ry = y;
                rx = x * Math.Cos(teta) + z * Math.Sin(teta);
                rz = -x * Math.Sin(teta) + z * Math.Cos(teta);
            }
            else
                if (eje == "Z")
            {
                rz = z;
                rx = x * Math.Cos(teta) - y * Math.Sin(teta);
                ry = x * Math.Sin(teta) + y * Math.Cos(teta);
            }
        }
    }
}
