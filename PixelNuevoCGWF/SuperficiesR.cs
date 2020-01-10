using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelNuevoCGWF
{
    class SuperficiesR : Espiral
    {
        public int tipo { set; get; }
        public int opcion { set; get; }
        public SuperficiesR(double x0, double y0, double z0, double rd, double el, int tip, int opc, Color color0, Bitmap lienzo, PictureBox ventanaP) : base(x0, y0, z0, rd, el, color0, lienzo, ventanaP)
        {
            this.tipo = tip;
            this.opcion = opc;
        }
        ~SuperficiesR() { }
        public override void Encender()
        {
            Vector3D v3D = new Vector3D(0, 0, 0, Color0, Imprimir, Viewpoint);
            Espiral esp = new Espiral(0, 0, 0, 2, 0.1, Color.Orange, Imprimir, Viewpoint);
            double t, dt, h, dh;

            double w3dx, w3dy, w3dz;
            //Paraboloide Hiperbolico

            double xx, yy;
            //Mallado
            int i, j,ci,cj;
            double rx, ry;
            double[,] Mx = new double[200, 200];
            double[,] My = new double[200, 200];
            t = -7; i=0;
            dt = 0.4;
            if (tipo == 0)
            {
                do
                {
                    h = -5; j=0;
                    dh = 0.4;
                    do
                    {
                        v3D.X0 = t;
                        v3D.Y0 = h;
                        v3D.Z0 = (Math.Pow(t, 2) - Math.Pow(h, 2)) * elasticidad;
                        esp.RotacionEspacial(v3D.X0, v3D.Y0, v3D.Z0, gama, eje, out w3dx, out w3dy, out w3dz);
                        v3D.X0 = w3dx;
                        v3D.Y0 = w3dy;
                        v3D.Z0 = w3dz;
                        //v3D.Encender();
                        v3D.Axonometria(v3D.X0, v3D.Y0, v3D.Z0,out rx,out ry);
                        Mx[i, j] = rx;
                        My[i, j] = ry;
                        h += dh;j++;
                    } while (h <= 5);
                    t += dt;i++;
                } while (t <= 7);
                ci = i - 1;
                cj = j - 1;

                if(opcion == 0)
                {
                    for (i = 0; i < ci; i++)
                    {
                        for (j = 0; j < cj; j++)
                        {
                                Cuadrilatero1(Mx[i, j], My[i, j], Mx[i + 1, j], My[i + 1, j], Mx[i + 1, j + 1], My[i + 1, j + 1], Mx[i, j + 1], My[i, j + 1], 0);
                            
                        }
                    }
                }else if (opcion==1)
                {
                    for (i = 0; i < ci; i++)
                    {
                        for (j = 0; j < cj; j++)
                        {
                          Cuadrilatero1(Mx[i, j], My[i, j], Mx[i + 1, j], My[i + 1, j], Mx[i + 1, j + 1], My[i + 1, j + 1], Mx[i, j + 1], My[i, j + 1], 1);
                            
                        }
                    }
                }else if(opcion ==2)
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

            //Paraboloide
            t = -7; i = 0;
            dt = 0.4;
            if (tipo == 1)
            {
                do
                {
                    h = -5; j = 0;
                    dh = 0.4;
                    do
                    {
                        v3D.X0 = t;
                        v3D.Y0 = h;
                        v3D.Z0 = (Math.Pow(t, 2) + Math.Pow(h, 2)) * elasticidad;
                        esp.RotacionEspacial(v3D.X0, v3D.Y0, v3D.Z0, gama, eje, out w3dx, out w3dy, out w3dz);
                        v3D.X0 = w3dx;
                        v3D.Y0 = w3dy;
                        v3D.Z0 = w3dz;
                        //v3D.Encender();
                        v3D.Axonometria(v3D.X0, v3D.Y0, v3D.Z0, out rx, out ry);
                        Mx[i, j] = rx;
                        My[i, j] = ry;
                        h += dh; j++;
                    } while (h <= 5);
                    t += dt; i++;
                } while (t <= 7);
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
            //Paraboloide
            Mx = new double[200, 200];
            My = new double[200, 200];
            t = -7; i = 0;
            dt = 0.4;
            if (tipo == 2)
            {
                do
                {
                    h = -5; j = 0;
                    dh = 0.4;
                    do
                    {
                        v3D.X0 = t;
                        v3D.Y0 = h;
                        v3D.Z0 = (t * Math.Sin(h) + h * Math.Cos(t)) * elasticidad;
                        esp.RotacionEspacial(v3D.X0, v3D.Y0, v3D.Z0, gama, eje, out w3dx, out w3dy, out w3dz);
                        v3D.X0 = w3dx;
                        v3D.Y0 = w3dy;
                        v3D.Z0 = w3dz;
                        v3D.Encender();
                        v3D.Axonometria(v3D.X0, v3D.Y0, v3D.Z0, out rx, out ry);
                        Mx[i, j] = rx;
                        My[i, j] = ry;
                        h += dh; j++;
                    } while (h <= 5);
                    t += dt; i++;
                } while (t <= 7);
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
            //Paraboloide propio
            Mx = new double[200, 200];
            My = new double[200, 200];
            t = -7; i = 0;
            dt = 0.4;
            if (tipo == 3)
            {
                do
                {
                    h = -5; j = 0;
                    dh = 0.4;
                    do
                    {
                        v3D.X0 = t;
                        v3D.Y0 = h;
                        v3D.Z0 = (2 * t * Math.Sin(t) + 2 * h * Math.Cos(h)) * elasticidad;
                        esp.RotacionEspacial(v3D.X0, v3D.Y0, v3D.Z0, gama, eje, out w3dx, out w3dy, out w3dz);
                        v3D.X0 = w3dx;
                        v3D.Y0 = w3dy;
                        v3D.Z0 = w3dz;
                        v3D.Encender();
                        v3D.Axonometria(v3D.X0, v3D.Y0, v3D.Z0, out rx, out ry);
                        Mx[i, j] = rx;
                        My[i, j] = ry;
                        h += dh; j++;
                    } while (h <= 5);
                    t += dt; i++;
                } while (t <= 7);
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

        public override void  Apagar()
        {
            Color0 = Color.Red;
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
