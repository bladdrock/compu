using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionCG
{
    class SuperficieBS : Vector3D
    {
        public int tipo, eje;
        public double alfa;
        public SuperficieBS(double x0, double y0, double z0, int tipo, double alfa, int eje, Color color0, Bitmap lienzo, PictureBox ventanaP)
            : base(x0, y0, z0, color0, lienzo, ventanaP)
        {
            this.tipo = tipo;
            this.alfa = alfa;
            this.eje = eje;
        }
        public override void Encender()
        {
            Vector3D V = new Vector3D(0, 0, 0, Color0, Lienzo, VentanaP);
            Vector3D W = new Vector3D(0, 0, 0, Color0, Lienzo, VentanaP);
            int i = 0, j;
            double[,] Mx = new double[200, 200];
            double[,] My = new double[200, 200];
            double x, dx, y, dy;
            double h, dh, t, dt = 0.7;
            x = -7;
            dx = 0.7;
            i = 0;
            int ci;
            int cj;

            if (tipo == 0)
            {
                double rx, ry;

                
                do
                {
                    j = 0;
                    y = -5;
                    dy = 0.7;
                    do
                    {
                        V.X0 = x;
                        V.Y0 = y;
                        V.z0 = (Math.Pow(Math.Sin(x), 2));
                        Rotar(V.X0, V.Y0, V.z0, alfa, out W.X0, out W.Y0, out W.z0, eje);
                        W.Encender();
                        Axonometria(W.X0, W.Y0, W.z0, out rx, out ry);
                        Mx[i, j] = rx;
                        My[i, j] = ry;
                        y = y + dy;
                        j++;
                    } while (y <= 5);
                    x = x + dx;
                    i++;
                } while (x <= 7);
                ci = i - 1;
                cj = j - 1;
                int Ni, Nj;
                Ni = i;
                Nj = j;
                Segmento S = new Segmento(0, 0, 0, 0, Color0, Lienzo, VentanaP);
                for (i = 1; i <= Ni - 2; i++)
                {
                    for (j = 1; j <= Nj; j++)
                    {
                        S.X0 = Mx[i, j];
                        S.Y0 = My[i, j];
                        S.Xf = Mx[i + 1, j];
                        S.Yf = My[i + 1, j];
                        S.Encender();
                    }
                }
                for (i = 1; i <= Ni; i++)
                {
                    for (j = 1; j <= Nj - 2; j++)
                    {
                        S.X0 = Mx[i, j];
                        S.Y0 = My[i, j];
                        S.Xf = Mx[i, j + 1];
                        S.Yf = My[i, j + 1];
                        S.Encender();
                    }
                }
            }

          
            if (tipo == 1)
            {
                double rx, ry;
                
                do
                {
                    j = 1;
                    y = -5;
                    dy = 0.7;
                    do
                    {
                        V.X0 = x;  //funcion predefinida
                        V.Y0 = y;
                        V.z0 = ((Math.Pow(x, 2) + Math.Pow(y, 2)) * 0.1);
                        Rotar(V.X0, V.Y0, V.z0, alfa, out W.X0, out W.Y0, out W.z0, eje);
                        W.Encender();
                        Axonometria(W.X0, W.Y0, W.z0, out rx, out ry);
                        Mx[i, j] = rx;
                        My[i, j] = ry;
                        y = y + dy;
                        j = j + 1;
                    } while (y <= 5);
                    x = x + dx;
                    i = i + 1;
                } while (x <= 6);
                int Ni, Nj;
                Ni = i;
                Nj = j;
                Segmento S = new Segmento(0, 0, 0, 0, Color0, Lienzo, VentanaP);
                for (i = 1; i <= Ni - 2; i++)
                {
                    for (j = 1; j <= Nj; j++)
                    {
                        S.X0 = Mx[i, j];
                        S.Y0 = My[i, j];
                        S.Xf = Mx[i + 1, j];
                        S.Yf = My[i + 1, j];
                        S.Encender();
                    }
                }
                for (i = 1; i <= Ni; i++)
                {
                    for (j = 1; j <= Nj - 2; j++)
                    {
                        S.X0 = Mx[i, j];
                        S.Y0 = My[i, j];
                        S.Xf = Mx[i, j + 1];
                        S.Yf = My[i, j + 1];
                        S.Encender();
                    }
                }
            }
            if (tipo == 2)
            {
                double rx, ry;
                do
                {
                    j = 1;
                    y = -5;
                    dy = 0.7;
                    do
                    {
                        V.X0 = x;
                        V.Y0 = y;
                        V.z0 = ((Math.Pow(x, 2) + Math.Pow(y, 2)) * 0.1);
                        Rotar(V.X0, V.Y0, V.z0, alfa, out W.X0, out W.Y0, out W.z0, eje);
                        W.Encender();
                        Axonometria(W.X0, W.Y0, W.z0, out rx, out ry);
                        Mx[i, j] = rx;
                        My[i, j] = ry;
                        y = y + dy;
                        j = j + 1;
                    } while (y <= 5);
                    x = x + dx;
                    i = i + 1;
                } while (x <= 6);
                int Ni, Nj;
                Ni = i;
                Nj = j;
                Segmento S = new Segmento(0, 0, 0, 0, Color0, Lienzo, VentanaP);
                for (i = 1; i <= Ni - 2; i++)
                {
                    for (j = 1; j <= Nj; j++)
                    {
                        S.X0 = Mx[i, j];
                        S.Y0 = My[i, j];
                        S.Xf = Mx[i + 1, j];
                        S.Yf = My[i + 1, j];
                        //S.Encender();
                    }
                }
                for (i = 1; i <= Ni; i++)
                {
                    for (j = 1; j <= Nj - 2; j++)
                    {
                        S.X0 = Mx[i, j];
                        S.Y0 = My[i, j];
                        S.Xf = Mx[i, j + 1];
                        S.Yf = My[i, j + 1];
                        // S.Encender();
                    }
                }
            }
            if (tipo == 3)
            {
                double rx, ry;
                do
                {
                    j = 1;
                    y = -5;
                    dy = 0.7;
                    do
                    {
                        V.X0 = x;
                        V.Y0 = y;
                        V.z0 = (x * Math.Sin(y) + y * Math.Cos(x)) * 0.1;
                        Rotar(V.X0, V.Y0, V.z0, alfa, out W.X0, out W.Y0, out W.z0, eje);
                        Axonometria(W.X0, W.Y0, W.z0, out rx, out ry);
                        W.Color0 = Color.Red;
                        W.Y0 = W.Y0 + 3;
                        W.X0 = W.X0 + 3;
                        W.Encender();
                        Mx[i, j] = rx;
                        My[i, j] = ry;
                        y = y + dy;
                        j = j + 1;
                    } while (y <= 5);
                    x = x + dx;
                    i = i + 1;
                } while (x <= 6);
                W.Color0 = Color.Green;
                int Ni, Nj;
                Ni = i;
                Nj = j;
                Segmento S = new Segmento(0, 0, 0, 0, Color0, Lienzo, VentanaP);
                for (i = 1; i <= Ni - 2; i++)
                {
                    for (j = 1; j <= Nj; j++)
                    {
                        S.X0 = Mx[i, j];
                        S.Y0 = My[i, j];
                        S.Xf = Mx[i + 1, j];
                        S.Yf = My[i + 1, j];
                        S.Encender();
                    }
                }
                for (i = 1; i <= Ni; i++)
                {
                    for (j = 1; j <= Nj - 2; j++)
                    {
                        S.X0 = Mx[i, j];
                        S.Y0 = My[i, j];
                        S.Xf = Mx[i, j + 1];
                        S.Yf = My[i, j + 1];
                        S.Encender();
                    }
                }
            }

            if (tipo == 4)
            {
                double rx, ry;
                do
                {
                    j = 1;
                    y = -5;
                    dy = 0.7;
                    do
                    {
                        V.X0 = x;
                        V.Y0 = y;
                        V.z0 = (x * Math.Sin(y) + y * Math.Cos(x)) * 0.1;
                        Rotar(V.X0, V.Y0, V.z0, alfa, out W.X0, out W.Y0, out W.z0, eje);
                        W.Encender();
                        Axonometria(W.X0, W.Y0, W.z0, out rx, out ry);
                        Mx[i, j] = rx;
                        My[i, j] = ry;
                        y = y + dy;
                        j = j + 1;
                    } while (y <= 5);
                    x = x + dx;
                    i = i + 1;
                } while (x <= 6);
                int Ni, Nj;
                Ni = i;
                Nj = j;
                Segmento S = new Segmento(0, 0, 0, 0, Color0, Lienzo, VentanaP);
                for (i = 1; i <= Ni - 2; i++)
                {
                    for (j = 1; j <= Nj; j++)
                    {
                        S.X0 = Mx[i, j];
                        S.Y0 = My[i, j];
                        S.Xf = Mx[i + 1, j];
                        S.Yf = My[i + 1, j];
                        //S.Encender();
                    }
                }
                for (i = 1; i <= Ni; i++)
                {
                    for (j = 1; j <= Nj - 2; j++)
                    {
                        S.X0 = Mx[i, j];
                        S.Y0 = My[i, j];
                        S.Xf = Mx[i, j + 1];
                        S.Yf = My[i, j + 1];
                        //S.Encender();
                    }
                }
            }

            if (tipo == 5)
            {
                int Ci;
                int Cj;
                t = 0;
                dt = 0.4; ;
                do
                {
                    h = -5;
                    j = 0; // Contador para Mallado
                    dh = 0.4;
                    do
                    {
                        V.X0 = X0 + t;
                        V.Y0 = Y0 + h;
                        V.z0 = z0 + ((Math.Pow(t, 2) - Math.Pow(h, 2)) * 0.1);
                        //V.Encender(); //Encendido sin rotación
                        Rotar(V.X0, V.Y0, V.z0, alfa, out W.X0, out W.Y0, out W.z0, eje);
                        Axonometria(W.X0, W.Y0, W.z0, out double Rx, out double Ry);
                        W.Y0 = W.Y0 + 3;
                        W.X0 = W.X0 +3;
                        W.Color0 = Color.Red;
                        W.Encender(); //Encendido sin rotación
                        W.Color0 = Color.Green;
                        Mx[i, j] = Rx;
                        My[i, j] = Ry;
                        h += dh;
                        j++; //Aumenta contador
                    } while (h <= 5);
                    t += dt;
                    i++; //Aumenta contador
                } while (t <= 7);
                //Contadores para las matrices
                Ci = i - 1;
                Cj = j - 1;
                for (i = 0; i < Ci; i++)
                {
                    for (j = 0; j < Cj; j++)
                    {
                        //Bspline(Mx[i, j], My[i, j], Mx[i + 1, j], My[i + 1, j], Mx[i + 1, j + 1], My[i + 1, j + 1], Mx[i, j + 1], My[i, j + 1], 1);
                        Bspline(Mx[i, j], My[i, j], Mx[i + 1, j], My[i + 1, j], Mx[i + 1, j + 1], My[i + 1, j + 1], Mx[i, j + 1], My[i, j + 1], 1);
                    }
                }
                
            }

        }


        public void Bspline(double Px, double Py, double Qx, double Qy, double Rx, double Ry, double Tx, double Ty, int tipo)
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
            if (tipo == 0)
            {
                pn = new Pen(Color.Green, 1);          //// Color Perfil
                g = Graphics.FromImage(Lienzo);
                g.DrawPolygon(pn, p);
                g.FillPolygon(new SolidBrush(Color.Transparent), p);  //// Color Relleno 
                VentanaP.Image = Lienzo;

            }
            if (tipo == 1)
            {
                pn = new Pen(Color.Green, 1);          //// Color Perfil
                g = Graphics.FromImage(Lienzo);
                g.DrawPolygon(pn, p);
                g.FillPolygon(new SolidBrush(Color.Transparent), p);  //// Color Relleno 
                VentanaP.Image = Lienzo;
            }
            if (tipo == 2)
            {
                pn = new Pen(Color.Fuchsia, 1);          //// Color Perfil
                g = Graphics.FromImage(Lienzo);
                g.DrawPolygon(pn, p);
                g.FillPolygon(new SolidBrush(Color.Gray), p);  //// Color Relleno 
                VentanaP.Image = Lienzo;
            }
        }

    }
}
