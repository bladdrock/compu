﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appCompuGrafica
{
    class cSuperficie:cVector3d
    {
        public double elasticidad=1;
        public Color colorRelleno;
        Double[,] M1 = new Double[100, 100];
        Double[,] M2 = new Double[100, 100];

        public void figuraMemoria(Bitmap bmp, out int i, out int j)
        {
            cVector3d v3D = new cVector3d();
            cVector3d w3D = new cVector3d();

            double t = -5, dt = 0.1, h = -5, dh = 0.3, ax = 0, ay = 0;
            i = 0; j = 0;
            int ni = 0, nj = 0;
            h = -5;

            do
            {
                j = 0;
                h = -5;
                do
                {
                    v3D.x0 = t;
                    v3D.y0 = h;
                    v3D.z0 = ((t * t) - (h * h)) * elasticidad;

                    v3D.color = color;
                    v3D.rotar3d(bmp, v3D.x0, v3D.y0, v3D.z0, 0, 2, out w3D.x0, out w3D.y0, out w3D.z0);
                    axonometria(w3D.x0, w3D.y0, w3D.z0, out ax, out ay);
                    M1[i, j] = ax;
                    M2[i, j] = ay;
                    h += dh;
                    j++;
                } while (h <= Math.PI * 2);
                t += dt;
                i++;

            } while (t <= Math.PI);
        }

        public void encenderMallado(Bitmap bmp, int figura)
        {
            int i=1, j=1;

            switch (figura)
            {
                case 1:
                    figuraMemoria(bmp, out i, out j);
                    break;
                case 2:
                    figuraMemoria2(bmp, out i, out j);
                    break;
                case 3:
                    figuraMemoria3(bmp, out i, out j);
                    break;
            }

            cCuadrado cuadrado = new cCuadrado();
            for (int x = 0; x < i-1; x++)
            {
                for (int y = 0; y < j-1 ; y++)
                {
                    cuadrado.x0 = M1[x, y];
                    cuadrado.y0 = M2[x, y];
                    cuadrado.x1 = M1[x + 1, y];
                    cuadrado.y1 = M2[x + 1, y];
                    cuadrado.x2 = M1[x + 1, y + 1];
                    cuadrado.y2 = M2[x + 1, y + 1];
                    cuadrado.x3 = M1[x, y + 1];
                    cuadrado.y3 = M2[x, y + 1];

                    cuadrado.color = color;

                    cuadrado.encenderCuadrilatero(bmp);
                }
            }

        }

        public void rellenar(Bitmap bmp)
        {
            Double[,] M1 = new Double[100, 100];
            Double[,] M2 = new Double[100, 100];
            cVector3d v3D = new cVector3d();
            cVector3d w3D = new cVector3d();
            double t = -5, dt = 0.3, h = -5, dh = 0.3, ax = 0, ay = 0;
            int i = 0, j = 0;
            h = -5;

            do
            {
                j = 0;
                h = -5;
                do
                {
                    v3D.x0 = t;
                    v3D.y0 = h;
                    v3D.z0 = ((t * t) - (h * h)) * elasticidad;

                    v3D.color = color;
                    v3D.rotar3d(bmp, v3D.x0, v3D.y0, v3D.z0, 0, 2, out w3D.x0, out w3D.y0, out w3D.z0);
                    axonometria(w3D.x0, w3D.y0, w3D.z0, out ax, out ay);
                    M1[i, j] = ax;
                    M2[i, j] = ay;
                    h += dh;
                    j++;
                } while (h <= Math.PI * 2);
                t += dt;
                i++;

            } while (t <= Math.PI);

            cCuadrado cuadrado = new cCuadrado();
            for (int x = 0; x < i - 1; x++)
            {
                for (int y = 0; y < j - 1; y++)
                {
                    cuadrado.x0 = M1[x, y];
                    cuadrado.y0 = M2[x, y];
                    cuadrado.x1 = M1[x + 1, y];
                    cuadrado.y1 = M2[x + 1, y];
                    cuadrado.x2 = M1[x + 1, y + 1];
                    cuadrado.y2 = M2[x + 1, y + 1];
                    cuadrado.x3 = M1[x, y + 1];
                    cuadrado.y3 = M2[x, y + 1];
                    cuadrado.color = color;
                    cuadrado.rellenarCuadrilatero(bmp, colorRelleno);
                }
            }
        }

        public void figuraMemoria2(Bitmap bmp, out int i, out int j)
        {
            i = 0; j = 0; 
            cVector3d v3D = new cVector3d();
            cVector3d w3D = new cVector3d();
            double t=-5, dt=0.3, h=-5, dh=0.2, ax = 0, ay = 0;

            do
            {
                h = -5;
                dh = 0.3;
                j = 0;
                do
                {
                    v3D.x0 = t;
                    v3D.y0 = h;

                    v3D.z0 = ((t * t) - (h * h))*elasticidad-2;
                    v3D.rotar3d(bmp, x0, v3D.y0, v3D.z0, 0, 0, out w3D.x0, out w3D.y0, out w3D.z0);
                    axonometria(w3D.x0, w3D.y0, w3D.z0, out ax, out ay);
                    M1[i, j] = ax;
                    M2[i, j] = ay;
                    v3D.color = color;
                    //v3D.encender(bmp);
                    h += dh;
                    j++;
                } while (h <= 5);
                t += dt;
                i++;
            } while (t <= 7);
        }

        public void figuraMemoria3(Bitmap bmp, out int i, out int j)
        {
            i = 0; j = 0;
            cVector3d v3D = new cVector3d();
            cVector3d w3D = new cVector3d();
            double t = -5, dt = 0.3, h = -5, dh = 0.2, ax = 0, ay = 0;

            do
            {
                h = -5;
                dh = 0.3;
                j = 0;
                do
                {
                    v3D.x0 = t;
                    v3D.y0 = h;

                    v3D.z0 = ((t * t) + (h * h)) * elasticidad - 2;
                    v3D.rotar3d(bmp, x0, v3D.y0, v3D.z0, 1, 0, out w3D.x0, out w3D.y0, out w3D.z0);
                    axonometria(w3D.x0, w3D.y0, w3D.z0, out ax, out ay);
                    M1[i, j] = ax;
                    M2[i, j] = ay;
                    v3D.color = color;
                    //v3D.encender(bmp);
                    h += dh;
                    j++;
                } while (h <= 5);
                t += dt;
                i++;
            } while (t <= 7);
        }

        public void encender13(Bitmap bmp)
        {
            cVector3d v3D = new cVector3d();
            double t = -5, dt = 0.3, h = -5, dh = 0.2;

            do
            {
                h = -5;
                dh = 0.3;
                do
                {
                    v3D.x0 = t;
                    v3D.y0 = h;
                    v3D.z0 = (Math.Sin(t) + h*Math.Cos(h)) * elasticidad;
                    v3D.color = color;
                    v3D.encender(bmp);
                    h += dh;
                } while (h <= 5);
                t += dt;

            } while (t <= 7);
        }


        public void encenderSuperficie(Bitmap bmp)
        {
            cVector3d v3D = new cVector3d();
            cVector3d w3D = new cVector3d();

            double t = -5, dt = 0.3, h = -5, dh = 0.3, ax = 0, ay = 0;
            int i = 0, j = 0;
            int ni = 0, nj = 0;
            h = -5;

            do
            {
                j = 0;
                h = -5;
                do
                {
                    v3D.x0 = t;
                    v3D.y0 = h;
                    v3D.z0 = ((t * t) - (h * h)) * elasticidad;

                    v3D.color = color;
                    v3D.rotar3d(bmp, v3D.x0, v3D.y0, v3D.z0, 0, 2, out w3D.x0, out w3D.y0, out w3D.z0);
                    axonometria(w3D.x0, w3D.y0, w3D.z0, out ax, out ay);
                    M1[i, j] = ax;
                    M2[i, j] = ay;
                    v3D.encender(bmp);
                    h += dh;
                    j++;
                } while (h <= Math.PI * 2);
                t += dt;
                i++;

            } while (t <= Math.PI);
        }

        public void encender2(Bitmap bmp)
        {
            cVector3d v3D = new cVector3d();
            double t = -7, dt = 0.3, h = -5, dh = 0.3;

            do
            {
                h = -5;
                dh = 0.3;
                do
                {
                    v3D.x0 = t;
                    v3D.y0 = h;
                    v3D.z0 = (((t * t) + (h * h))-0.2) * elasticidad;
                    v3D.color = color;
                    v3D.encender(bmp);
                    h += dh;
                } while (h <= 5);
                t += dt;

            } while (t <= 7);
        }

        public void encender3(Bitmap bmp)
        {
            cVector3d v3D = new cVector3d();
            double t = -7, dt = 0.3, h = -5, dh = 0.3;

            do
            {
                h = -5;
                dh = 0.3;
                do
                {
                    v3D.x0 = t;
                    v3D.y0 = h;
                    v3D.z0 = ((t * Math.Tan(h)) + (h * Math.Cos(2*t))) * elasticidad ;
                    v3D.color = color;
                    v3D.encender(bmp);
                    h += dh;
                } while (h <= 5);
                t += dt;

            } while (t <= 7);
        }

        public void encenderMallado2(Bitmap bmp)
        {
            Double[,] M1 = new Double[100, 100];
            Double[,] M2 = new Double[100, 100];

            cVector3d v3D = new cVector3d();
            double t = -5, dt = 0.3, h = -5, dh = 0.3, ax = 0, ay = 0;
            int i = 0, j = 0, ni = 0, nj = 0;
            h = -5;

            do
            {
                j = 0;
                h = -5;
                do
                {
                    v3D.x0 = t;
                    v3D.y0 = h;
                    v3D.z0 = ((t * Math.Tan(h)) + (h * Math.Cos(2 * t))) * elasticidad;
                    v3D.color = color;
                    //v3D.encender(bmp);
                    axonometria(v3D.x0, v3D.y0, v3D.z0, out ax, out ay);
                    M1[i, j] = ax;
                    M2[i, j] = ay;
                    h += dh;
                    j++;
                } while (h <= Math.PI * 2);
                t += dt;
                i++;

            } while (t <= Math.PI);

            cCuadrado cuadrado = new cCuadrado();
            for (int x = 0; x < i - 1; x++)
            {
                for (int y = 0; y < j - 1; y++)
                {
                    cuadrado.x0 = M1[x, y];
                    cuadrado.y0 = M2[x, y];
                    cuadrado.x1 = M1[x + 1, y];
                    cuadrado.y1 = M2[x + 1, y];
                    cuadrado.x2 = M1[x + 1, y + 1];
                    cuadrado.y2 = M2[x + 1, y + 1];
                    cuadrado.x3 = M1[x, y + 1];
                    cuadrado.y3 = M2[x, y + 1];

                    cuadrado.color = color;

                    cuadrado.encenderCuadrilatero(bmp);
                }
            }

        }

        public void rellenar2(Bitmap bmp)
        {
            Double[,] M1 = new Double[100, 100];
            Double[,] M2 = new Double[100, 100];
            cVector3d v3D = new cVector3d();
            double t = -5, dt = 0.3, h = -5, dh = 0.3, ax = 0, ay = 0;
            int i = 0, j = 0;
            h = -5;

            do
            {
                j = 0;
                h = -5;
                do
                {
                    v3D.x0 = t;
                    v3D.y0 = h;
                    v3D.z0 = ((t * Math.Tan(h)) + (h * Math.Cos(2 * t))) * elasticidad;
                    axonometria(v3D.x0, v3D.y0, v3D.z0, out ax, out ay);
                    M1[i, j] = ax;
                    M2[i, j] = ay;
                    h += dh;
                    j++;
                } while (h <= Math.PI * 2);
                t += dt;
                i++;

            } while (t <= Math.PI);

            cCuadrado cuadrado = new cCuadrado();
            for (int x = 0; x < i - 1; x++)
            {
                for (int y = 0; y < j - 1; y++)
                {
                    cuadrado.x0 = M1[x, y];
                    cuadrado.y0 = M2[x, y];
                    cuadrado.x1 = M1[x + 1, y];
                    cuadrado.y1 = M2[x + 1, y];
                    cuadrado.x2 = M1[x + 1, y + 1];
                    cuadrado.y2 = M2[x + 1, y + 1];
                    cuadrado.x3 = M1[x, y + 1];
                    cuadrado.y3 = M2[x, y + 1];
                    cuadrado.color = color;
                    //cuadrado.colorRelleno = colorRelleno;
                    cuadrado.rellenarCuadrilatero(bmp, colorRelleno);
                }
            }
        }
    }
}
