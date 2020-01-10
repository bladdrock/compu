using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelNuevoCGWF
{
    class SuperficieV:Espiral
    {
        public int tipo { set; get; }
        public int opcion { set; get; }
        public double gama { set; get; }
        public int eje { set; get; }
        public SuperficieV(double x0, double y0, double z0, double rd, double el, int tip, int opcion,Color color0, Bitmap lienzo, PictureBox ventanaP) : base(x0, y0, z0, rd, el, color0, lienzo, ventanaP)
        {
            this.tipo = tip;
            this.X0 = x0;
            this.Y0 = y0;
            this.Z0 = z0;
            this.opcion = opcion;
        }
        ~SuperficieV() { }

        public override void Encender()
        {
            Vector3D v3D = new Vector3D(X0, Y0, Z0, Color0, Imprimir, Viewpoint);
            Vector3D w3d = new Vector3D(X0, Y0, Z0, Color0, Imprimir, Viewpoint);
            double t, dt, h, dh;

            double w3dx, w3dy, w3dz;

            double xx, yy;
            //Mallado
            int i, j, ci, cj;
            double rx, ry;
            double[,] Mx = new double[200, 200];
            double[,] My = new double[200, 200];

            if (tipo == 1)
            {
                t = 0; i = 0;
                dt = Math.PI/12;
                do
                {
                    h = 0; j = 0;
                    dh = Math.PI/12;
                    do
                    {
                        v3D.X0 = X0 + Rd * Math.Cos(t);
                        v3D.Y0 = Y0 + Rd * Math.Sin(t);
                        v3D.Z0 = Z0 + h;
                        Rotacion3D(v3D.X0, v3D.Y0, v3D.Z0, gama, eje, out w3dx, out w3dy, out w3dz);
                        w3d.X0 = w3dx;
                        w3d.Y0 = w3dy;
                        w3d.Z0 = w3dz;
                        //w3d.Encender();
                        v3D.Axonometria(v3D.X0, v3D.Y0, v3D.Z0, out rx, out ry);
                        Mx[i, j] = rx;
                        My[i, j] = ry;
                        h += dh;j++;
                    } while (h <= (2.5*Math.PI));
                    t += dt;i++;
                } while (t <= (2 * Math.PI));
                ci = i - 1;
                cj = j - 1;

                if (opcion == 0)
                {
                    for (i = 0; i < ci; i++)
                    {
                        for (j = 0; j < cj; j++)
                        {
                            Cuadrilatero1(Mx[i, j], My[i, j], Mx[i + 1, j], My[i + 1, j], Mx[i + 1, j + 1], My[i + 1, j + 1], Mx[i, j + 1], My[i, j + 1], 0);

                        }
                    }
                }
                else if (opcion == 1)
                {
                    for (i = 0; i < ci; i++)
                    {
                        for (j = 0; j < cj; j++)
                        {
                            Cuadrilatero1(Mx[i, j], My[i, j], Mx[i + 1, j], My[i + 1, j], Mx[i + 1, j + 1], My[i + 1, j + 1], Mx[i, j + 1], My[i, j + 1], 1);

                        }
                    }
                }
                else if (opcion == 2)
                {
                    for (i = 0; i < ci; i++)
                    {
                        for (j = 0; j < cj; j++)
                        {
                            xx = (Mx[i + 1, j] - Mx[i, j]) * (My[i + 1, j + 1] - My[i + 1, j]);
                            yy = (Mx[i + 1, j + 1] - Mx[i + 1, j]) * (My[i + 1, j] - My[i, j]);
                            if ((xx - yy) > 0)
                            {
                                Cuadrilatero1(Mx[i, j], My[i, j], Mx[i + 1, j], My[i + 1, j], Mx[i + 1, j + 1], My[i + 1, j + 1], Mx[i, j + 1], My[i, j + 1], 1);
                            }
                            else
                            {
                                Cuadrilatero1(Mx[i, j], My[i, j], Mx[i + 1, j], My[i + 1, j], Mx[i + 1, j + 1], My[i + 1, j + 1], Mx[i, j + 1], My[i, j + 1], 2);
                            }
                        }
                    }
                }

            }

            Mx = new double[200, 200];
            My = new double[200, 200];

            if (tipo == 2)
            {
                h = 0;i = 0;
                dh = Math.PI/15;
                do
                {
                    t = 0;j = 0;
                    dt = Math.PI / 15;
                    do
                    {
                        v3D.X0 = X0 + Rd * Math.Cos(t) * Math.Sin(h);
                        v3D.Y0 = Y0 + Rd * Math.Sin(t) * Math.Sin(h);
                        v3D.Z0 = Z0 + Rd * Math.Cos(h);
                        Rotacion3D(v3D.X0, v3D.Y0, v3D.Z0, gama, eje, out w3dx, out w3dy, out w3dz);
                        w3d.X0 = w3dx;
                        w3d.Y0 = w3dy;
                        w3d.Z0 = w3dz;
                        //w3d.Encender();
                        v3D.Axonometria(v3D.X0, v3D.Y0, v3D.Z0, out rx, out ry);
                        Mx[i, j] = rx;
                        My[i, j] = ry;
                        t += dt;j++;
                    } while (t <= (2.5 * Math.PI));
                    h += dh;i++;
                } while (h <= Math.PI);

                ci = i - 1;
                cj = j - 1;

                //Proceso de Mallado
                if (opcion == 0)
                {
                    for (i = 0; i < ci; i++)
                    {
                        for (j = 0; j < cj; j++)
                        {
                            Cuadrilatero1(Mx[i, j], My[i, j], Mx[i + 1, j], My[i + 1, j], Mx[i + 1, j + 1], My[i + 1, j + 1], Mx[i, j + 1], My[i, j + 1], 0);

                        }
                    }
                }
                else if (opcion == 1)
                {
                    for (i = 0; i < ci; i++)
                    {
                        for (j = 0; j < cj; j++)
                        {
                            Cuadrilatero1(Mx[i, j], My[i, j], Mx[i + 1, j], My[i + 1, j], Mx[i + 1, j + 1], My[i + 1, j + 1], Mx[i, j + 1], My[i, j + 1], 1);

                        }
                    }
                }
                else if (opcion == 2)
                {
                    for (i = 0; i < ci; i++)
                    {
                        for (j = 0; j < cj; j++)
                        {
                            xx = (Mx[i + 1, j] - Mx[i, j]) * (My[i + 1, j + 1] - My[i + 1, j]);
                            yy = (Mx[i + 1, j + 1] - Mx[i + 1, j]) * (My[i + 1, j] - My[i, j]);
                            if ((xx - yy) > 0)
                            {
                                Cuadrilatero1(Mx[i, j], My[i, j], Mx[i + 1, j], My[i + 1, j], Mx[i + 1, j + 1], My[i + 1, j + 1], Mx[i, j + 1], My[i, j + 1], 1);
                            }
                            else
                            {
                                Cuadrilatero1(Mx[i, j], My[i, j], Mx[i + 1, j], My[i + 1, j], Mx[i + 1, j + 1], My[i + 1, j + 1], Mx[i, j + 1], My[i, j + 1], 2);
                            }
                        }
                    }
                }
            }

            Mx = new double[200, 200];
            My = new double[200, 200];

            if (tipo == 3)
            {
                double R = Rd;
                double r = Rd/3;
                h = 0;i = 0;
                dh = Math.PI / 12;
                do
                {
                    t = 0; j = 0;
                    dt = Math.PI / 12;
                    do
                    {
                        v3D.X0 = X0 + Math.Cos(h) * (R + r * Math.Cos(t));
                        v3D.Y0 = Y0 + Math.Sin(h) * (R + r * Math.Cos(t));
                        v3D.Z0 = Z0 + r * Math.Sin(t);
                        Rotacion3D(v3D.X0, v3D.Y0, v3D.Z0, gama, eje, out w3dx, out w3dy, out w3dz);
                        w3d.X0 = w3dx;
                        w3d.Y0 = w3dy;
                        w3d.Z0 = w3dz;
                        //w3d.Encender();
                        v3D.Axonometria(v3D.X0, v3D.Y0, v3D.Z0, out rx, out ry);
                        Mx[i, j] = rx;
                        My[i, j] = ry;
                        t += dt; j++;
                    } while (t <= (2 *Math.PI));
                    h += dh;i++;
                } while (h <= (2 * Math.PI));

                ci = i - 1;
                cj = j - 1;

                //Proceso de Mallado
                if (opcion == 0)
                {
                    for (i = 0; i < ci; i++)
                    {
                        for (j = 0; j < cj; j++)
                        {
                            Cuadrilatero1(Mx[i, j], My[i, j], Mx[i + 1, j], My[i + 1, j], Mx[i + 1, j + 1], My[i + 1, j + 1], Mx[i, j + 1], My[i, j + 1], 0);

                        }
                    }
                }
                else if (opcion == 1)
                {
                    for (i = 0; i < ci; i++)
                    {
                        for (j = 0; j < cj; j++)
                        {
                            Cuadrilatero1(Mx[i, j], My[i, j], Mx[i + 1, j], My[i + 1, j], Mx[i + 1, j + 1], My[i + 1, j + 1], Mx[i, j + 1], My[i, j + 1], 1);

                        }
                    }
                }
                else if (opcion == 2)
                {
                    for (i = 0; i < ci; i++)
                    {
                        for (j = 0; j < cj; j++)
                        {
                            xx = (Mx[i + 1, j] - Mx[i, j]) * (My[i + 1, j + 1] - My[i + 1, j]);
                            yy = (Mx[i + 1, j + 1] - Mx[i + 1, j]) * (My[i + 1, j] - My[i, j]);
                            if ((xx - yy) > 0)
                            {
                                Cuadrilatero1(Mx[i, j], My[i, j], Mx[i + 1, j], My[i + 1, j], Mx[i + 1, j + 1], My[i + 1, j + 1], Mx[i, j + 1], My[i, j + 1], 1);
                            }
                            else
                            {
                                Cuadrilatero1(Mx[i, j], My[i, j], Mx[i + 1, j], My[i + 1, j], Mx[i + 1, j + 1], My[i + 1, j + 1], Mx[i, j + 1], My[i, j + 1], 2);
                            }
                        }
                    }
                }
            }

        }

        public void Rotacion3D(double Vx, double Vy, double Vz, double gama, int eje, out double Wx, out double Wy, out double Wz)
        {
            Wx = Vx;
            Wy = Vy;
            Wz = Vz;
            if (eje == 0) //Eje X
            {
                Wx = Vx;
                Wy = Vy * Math.Cos(gama) - Vz * Math.Sin(gama);
                Wz = Vy * Math.Sin(gama) + Vz * Math.Cos(gama);
            }
            if (eje == 1) //Eje Y
            {
                Wx = Vx * Math.Cos(gama) + Vz * Math.Sin(gama);
                Wy = Vy;
                Wz = (Vz * Math.Cos(gama)) - (Vx * Math.Sin(gama));
            }
            if (eje == 2) //Eje Z
            {
                Wx = Vx * Math.Cos(gama) - Vy * Math.Sin(gama);
                Wy = Vx * Math.Sin(gama) + Vy * Math.Cos(gama);
                Wz = Vz;
            }
        }

        public void ApagarC()
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
            if (tipo == 0)
            {
                pn = new Pen(Color.Green, 1);          //// Color Perfil
                g = Graphics.FromImage(Imprimir);
                g.DrawPolygon(pn, p);
                g.FillPolygon(new SolidBrush(Color.Transparent), p);  //// Color Relleno 
                Viewpoint.Image = Imprimir;

            }
            if (tipo == 1)
            {
                pn = new Pen(Color.Green, 1);          //// Color Perfil
                g = Graphics.FromImage(Imprimir);
                g.DrawPolygon(pn, p);
                g.FillPolygon(new SolidBrush(Color.Blue), p);  //// Color Relleno 
                Viewpoint.Image = Imprimir;
            }
            if (tipo == 2)
            {
                pn = new Pen(Color.Fuchsia, 1);          //// Color Perfil
                g = Graphics.FromImage(Imprimir);
                g.DrawPolygon(pn, p);
                g.FillPolygon(new SolidBrush(Color.Gray), p);  //// Color Relleno 
                Viewpoint.Image = Imprimir;
            }
        }
    }
}
