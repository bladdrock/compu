
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appCompuGrafica
{
    class cFractal : cCircunferencia
    {
        public Double alfa, beta, radioF, z0;

        public Color color2 = Color.White;

        public List<cSegmento> segmentos;

        public string figura;

        public cFractal()
        {
            segmentos = new List<cSegmento>();
        }

        public void luna(Bitmap bmp)
        {
            cCircunferencia circulo = new cCircunferencia();
            double W;
            circulo.x0 = 6;
            circulo.y0 = 4;
            circulo.rd = 0.7;

            //circulo.color = Color.Red;

            //circulo.encender(bmp);
            W = 0.7;
            do
            {
                circulo.rd = W;
                circulo.color = Color.FromArgb((int)(472 - 310 * W), (int)(472 - 310 * W), (int)(472 - 310 * W));
                circulo.encender(bmp);
                W += 0.035;
            } while (W <= 1.2);

            do
            {
                circulo.rd = W;
                circulo.color = Color.FromArgb((int)(237.6 - 132 * W), (int)(237.6 - 132 * W), (int)(237.6 - 132 * W));
                circulo.encender(bmp);
                W += 0.035;
            } while (W <= 1.8);
        }

        public void arbol(Bitmap lienzo)
        {
            cSegmento s = new cSegmento();
            s.x0 = x0;
            s.y0 = y0;
            double r1 = rd, alfa1 = alfa;
            if (rd > 0.1)
            {
                s.Xf = x0 + rd * Math.Cos(alfa);
                s.Yf = y0 + rd * Math.Sin(alfa);
                s.color = color;
                s.encender(lienzo);

                // Arbol Derecha
                x0 = s.Xf;
                y0 = s.Yf;
                rd = rd / 2;
                alfa = alfa - beta;
                arbol(lienzo);/// llama al proceso recursivo

                // Arbol Izquierda
                x0 = s.Xf;
                y0 = s.Yf;
                rd = r1 / 2;
                alfa = alfa1 + beta;
                arbol(lienzo);

                // Arbol Centro
                x0 = s.Xf;
                y0 = s.Yf;
                rd = r1 / 1.5;
                alfa = alfa1;
                arbol(lienzo);
            }
        }

        public void arbol2(Bitmap lienzo, double z0)
        {
            cSegmento3d s = new cSegmento3d();
            s.x0 = x0;
            s.y0 = y0;
            s.z0 = z0;
            double r1 = rd, alfa1 = alfa;
            if (rd > 0.1)
            {
                s.xf = x0 + rd * Math.Cos(alfa);
                s.yf = y0 + rd * Math.Sin(alfa);
                s.zf = z0 + rd;
                s.color = color;
                s.encender(lienzo);

                // Arbol Derecha
                x0 = s.xf;
                y0 = s.yf;
                rd = rd / 2;
                alfa = alfa - beta;
                arbol(lienzo);/// llama al proceso recursivo

                // Arbol Izquierda
                x0 = s.xf;
                y0 = s.yf;
                rd = r1 / 2;
                alfa = alfa1 + beta;
                arbol(lienzo);

                // Arbol Centro
                x0 = s.xf;
                y0 = s.yf;
                rd = r1 / 1.5;
                alfa = alfa1;
                arbol(lienzo);
            }
        }

        public void Arbol_Interpolado(Bitmap lienzo)
        {
            cSegmento s = new cSegmento();
            s.x0 = x0;
            s.y0 = y0;
            double r1 = rd, alfa1 = alfa;
            if (rd > 0.1)
            {
                s.Xf = x0 + rd * Math.Cos(alfa);
                s.Yf = y0 + rd * Math.Sin(alfa);
                int R = (int)(220 - (rd * 31));
                int G = (int)(220 - (rd * 10));
                int B = (int)(70 - (rd * 10));
                s.color = Color.FromArgb(R, G, B);
                s.encender(lienzo);

                // Arbol Derecha
                x0 = s.Xf;
                y0 = s.Yf;
                rd = rd / 2;
                alfa = alfa - beta;
                Arbol_Interpolado(lienzo);/// llama al proceso recursivo

                // Arbol Izquierda
                x0 = s.Xf;
                y0 = s.Yf;
                rd = r1 / 2;
                alfa = alfa1 + beta;
                Arbol_Interpolado(lienzo);

                // Arbol atras
                x0 = s.Xf;
                y0 = s.Yf;
                rd = r1 / 2;
                alfa = alfa1 + beta;
                Arbol_Interpolado(lienzo);

                // Arbol Centro
                x0 = s.Xf;
                y0 = s.Yf;
                rd = r1 / 1.7;
                alfa = alfa1;
                Arbol_Interpolado(lienzo);
            }
        }

        public void Arbol_Interpolado2(Bitmap lienzo, bool atras)
        {
            cSegmento3d s = new cSegmento3d();
            s.x0 = x0;
            s.y0 = y0;
            s.z0 = z0;
            double r1 = rd, alfa1 = alfa;
            if (rd > 0.2)
            {
                if (!atras) { 
                    s.xf = 0;
                    s.yf = y0 + rd * Math.Sin(alfa);
                    s.zf = z0 + rd * Math.Cos(alfa);
                }
                else
                {
                    s.xf = z0 + rd * Math.Cos(alfa);
                    s.yf = y0 + rd * Math.Sin(alfa);
                    s.zf = 0;
                }
                int R = (int)(220 - (rd * 31));
                int G = (int)(220 - (rd * 10));
                int B = (int)(70 - (rd * 10));
                s.color = Color.FromArgb(R, G, B);
                s.encender(lienzo);

                // Arbol Derecha
                z0 = s.zf;
                y0 = s.yf;
                rd = rd / 2;
                alfa = alfa - beta;
                Arbol_Interpolado2(lienzo,false);/// llama al proceso recursivo

                // Arbol Izquierda
                z0 = s.zf;
                y0 = s.yf;
                rd = r1 / 2;
                alfa = alfa1 + beta;
                Arbol_Interpolado2(lienzo,false);

                // Arbol Centro
                z0 = s.zf;
                y0 = s.yf;
                rd = r1 / 1.7;
                alfa = alfa1;
                Arbol_Interpolado2(lienzo,false);

                // Arbol atras
                x0 = s.zf;
                y0 = s.yf;
                //z0 = 0;
                rd = rd / 2;
                alfa = alfa - beta;
                Arbol_Interpolado2(lienzo, true);
            }
        }

        public void Arbol_Interpolado(Color ci, Color cf, Bitmap lienzo)
        {
            cSegmento s = new cSegmento();
            s.x0 = x0;
            s.y0 = y0;
            double r1 = rd, alfa1 = alfa;
            if (rd > 0.1)
            {
                s.Xf = x0 + rd * Math.Cos(alfa);
                s.Yf = y0 + rd * Math.Sin(alfa);
                int R = (int)(255 - (rd * 31));
                int G = (int)(220 - (rd * 10));
                int B = (int)(150-(rd * 10));
                s.color = Color.FromArgb(R, G, B);
                s.encender(lienzo);

                // Arbol Derecha
                x0 = s.Xf;
                y0 = s.Yf;
                rd = rd / 2;
                alfa = alfa - beta;
                Arbol_Interpolado(lienzo);/// llama al proceso recursivo

                // Arbol Izquierda
                x0 = s.Xf;
                y0 = s.Yf;
                rd = r1 / 2;
                alfa = alfa1 + beta;
                Arbol_Interpolado(lienzo);

                // Arbol Centro
                x0 = s.Xf;
                y0 = s.Yf;
                rd = r1 / 1.7;
                alfa = alfa1;
                Arbol_Interpolado(lienzo);
            }
        }

        public void Arbol1(Bitmap lienzo)
        {
            cSegmento s = new cSegmento();
            s.x0 = x0;
            s.y0 = y0;
            double r1 = rd, alfa1 = alfa;
            s.color = color;


            if (rd > 0.1)
            {
                s.Xf = x0 + rd * Math.Cos(alfa);
                s.Yf = y0 + rd * Math.Sin(alfa);
                s.encender(lienzo);
                segmentos.Add(s);

                // Arbol Derecha
                x0 = s.Xf;
                y0 = s.Yf;
                rd = rd / 2;
                alfa = alfa - beta;
                Arbol1(lienzo);/// llama al proceso recursivo

                // Arbol Izquierda
                x0 = s.Xf;
                y0 = s.Yf;
                rd = r1 / 2;
                alfa = alfa1 + beta*0.5;
                Arbol1(lienzo);

                // Arbol Centro
                x0 = s.Xf;
                y0 = s.Yf;
                rd = r1 / 1.8;
                alfa = alfa1;
                Arbol1(lienzo);
            }
        }

        public void ArbolSegmentos(Bitmap lienzo)
        {
            cSegmento s = new cSegmento();
            s.x0 = x0;
            s.y0 = y0;
            double r1 = rd, alfa1 = alfa;
            s.color = color;


            if (rd > 0.1)
            {
                s.Xf = x0 + rd * Math.Cos(alfa);
                s.Yf = y0 + rd * Math.Sin(alfa);
                //s.encender(lienzo);
                segmentos.Add(s);

                // Arbol Derecha
                x0 = s.Xf;
                y0 = s.Yf;
                rd = rd / 2;
                alfa = alfa - beta;
                ArbolSegmentos(lienzo);/// llama al proceso recursivo

                // Arbol Izquierda
                x0 = s.Xf;
                y0 = s.Yf;
                rd = r1 / 2;
                alfa = alfa1 + beta;
                ArbolSegmentos(lienzo);

                // Arbol Centro
                x0 = s.Xf;
                y0 = s.Yf;
                rd = r1 / 1.8;
                alfa = alfa1;
                ArbolSegmentos(lienzo);
            }
        }

        public void Estrella(Bitmap lienzo)
        {
            double aux = 0;
            cSegmento s = new cSegmento();
            s.x0 = x0;
            s.y0 = y0;
            do
            {
                s.Xf = x0 + rd * Math.Cos(aux);
                s.Yf = y0 + rd * Math.Sin(aux);
                s.color = color;
                s.encender(lienzo);
                aux = aux + alfa;
            } while (aux <= 2 * Math.PI);
        }

        public void Cantor(cSegmento s, Bitmap lienzo, PictureBox pictureBox1)
        {
            if (s.Yf <= -10)
                return;

            double m = (s.Yf - s.y0) / (s.Xf - s.x0);
            s.Yf -= 2;
            double d = (s.Xf - s.x0) / 3;
            if (d <= 0.01) return;
            cSegmento s1 = new cSegmento();
            s1.x0 = s.x0+2*m;
            s1.y0 = s.y0+2*m;
            s1.Xf = s1.x0 + d * Math.Cos(m);
            s1.Yf = s1.y0 + d * Math.Sin(m);
            cSegmento s2 = new cSegmento();
            s2.x0 = s.Xf + 2*m;
            s2.y0 = s.Yf + 2*m;
            s2.Xf = s2.x0 - d * Math.Cos(m);
            s2.Yf = s2.y0 - d * Math.Sin(m);
            s1.color = s2.color = s.color;
            s1.encender(lienzo);
            s2.encender(lienzo);
            pictureBox1.Image = lienzo;
            Thread.Sleep(10);
            pictureBox1.Refresh();

            Cantor(s1, lienzo, pictureBox1);
            Cantor(s2, lienzo, pictureBox1);
        }

        public void Cantor2(cSegmento s, Bitmap lienzo, PictureBox pictureBox1)
        {
            if (s.Yf <= -10)
                return;

            s.Yf -= 2;
            double d = (s.Xf - s.x0) / 3;
            if (d <= 0.01) return;

            cSegmento s1 = new cSegmento();
            s1.x0 = s.x0;
            s1.Xf = s.x0 + d;
            cSegmento s2 = new cSegmento();
            s2.x0 = s.Xf - d;
            s2.Xf = s.Xf;
            s1.y0 = s2.y0 = s.Yf;
            s1.Yf = s2.Yf = s.Yf;
            s1.color = s2.color = s.color;
            s1.encender(lienzo);
            s2.encender(lienzo);

            cFiguras c1 = new cFiguras();
            c1.x0 = s.x0 + d / 2;
            c1.color = color;
            cFiguras c2 = new cFiguras();
            c2.x0 = s.Xf - d / 2;
            c2.color = color2;
            c1.y0 = c2.y0 = s.Yf;
            c1.rd = c2.rd = d / 2;

            if (figura=="circulo")
            {
                c1.encender(lienzo);
                c2.encender(lienzo);
            }
            else if (figura == "lazo")
            {
                c1.lazo(lienzo);
                c2.lazo(lienzo);
            }
            else if (figura == "margarita")
            {
                c1.margarita(lienzo);
                c2.margarita(lienzo);
            }
            else if (figura == "hipociclo")
            {
                c1.hipociclo(lienzo);
                c2.hipociclo(lienzo);
            }

            pictureBox1.Image = lienzo;
            Thread.Sleep(10);
            pictureBox1.Refresh();

            Cantor2(s1, lienzo, pictureBox1);
            Cantor2(s2, lienzo, pictureBox1);
        }

        public void Cantor3(cSegmento s, Bitmap lienzo, PictureBox pictureBox1)
        {

            if (s.Yf <= -10)
                return;

            s.Yf -= 1;
            double d = (s.Xf - s.x0) / 3;
            if (d <= 0.01) return;

            cSegmento s1 = new cSegmento();
            s1.x0 = s.x0;
            s1.Xf = s.x0 + d;
            cSegmento s2 = new cSegmento();
            s2.x0 = s.Xf - d;
            s2.Xf = s.Xf;
            s1.y0 = s2.y0 = s.Yf;
            s1.Yf = s2.Yf = s.Yf;
            s1.color = s2.color = s.color;
            s1.encender(lienzo);
            s2.encender(lienzo);

            Random random = new Random();
            double nX = random.Next(-8, 8);
            double nY = random.Next(-6, 6);
            cFiguras c1 = new cFiguras();
            cFiguras c2 = new cFiguras();
            c1.rd = c2.rd = d / 1.5;
            c1.color = color;
            c1.x0 = nX;
            c1.y0 = nY;
            nX = random.Next(-8, 8);
            nY = random.Next(-6, 6);
            c2.color = color2;
            c2.x0 = nX;
            c2.y0 = nY;

            if (figura == "circulo")
            {
                c1.encender(lienzo);
                c2.encender(lienzo);
            }
            else if (figura == "lazo")
            {
                c1.lazo(lienzo);
                c2.lazo(lienzo);
            }
            else if (figura == "margarita")
            {
                c1.margarita(lienzo);
                c2.margarita(lienzo);
            }
            else if (figura == "hipociclo")
            {
                c1.hipociclo(lienzo);
                c2.hipociclo(lienzo);
            }

            pictureBox1.Image = lienzo;
            Thread.Sleep(50);
            pictureBox1.Refresh();

            Cantor3(s1, lienzo, pictureBox1);
            Cantor3(s2, lienzo, pictureBox1);
        }

        public void Koch(Bitmap lienzo, int nveces, double x1, double y1, double x2, double y2)
        {
            double dx = (x2 - x1) / 3;
            double dy = (y2 - y1) / 3;
            double xx = x1 + 3 * dx / 2 - dy * Math.Sin(Math.PI / 3);
            double yy = y1 + 3 * dy / 2 + dx * Math.Sin(Math.PI / 3);
            cSegmento S = new cSegmento();
            S.color = color;
            if (nveces <= 0)
            {
                //Segmento 
                S.x0 = x1;
                S.y0 = y1;
                S.Xf = x2;
                S.Yf = y2;
                S.encender(lienzo);
            }
            else
            {
                Koch(lienzo, nveces - 1, x1, y1, x1 + dx, y1 + dy);
                Koch(lienzo, nveces - 1, x1 + dx, y1 + dy, xx, yy);
                Koch(lienzo, nveces - 1, xx, yy, x2 - dx, y2 - dy);
                Koch(lienzo, nveces - 1, x2 - dx, y2 - dy, x2, y2);
            }
        }
    }
}