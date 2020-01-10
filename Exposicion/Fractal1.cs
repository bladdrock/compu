using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Exposicion
{
    class Fractal1: Circunferencia
    {
        public double alfa, beta;        
        
        public void Arbol(Bitmap lienzo)
        {           
            Segmento s = new Segmento();
            s.x0 = x0;
            s.y0 = y0;
            double r1 = radio, alfa1 = alfa;
            if (radio>0.1)
            {
                s.xf = x0 + radio * Math.Cos(alfa);
                s.yf = y0 + radio * Math.Sin(alfa);
                s.color0 = color0;
                s.Encender(lienzo);

                // Arbol Derecha
                x0 = s.xf;
                y0 = s.yf;
                radio = radio / 2;
                alfa = alfa - beta;                
                Arbol(lienzo);/// llama al proceso recursivo

                // Arbol Izquierda
                x0 = s.xf;
                y0 = s.yf;
                radio = r1 / 2;
                alfa = alfa1 + beta;
                Arbol(lienzo);

                // Arbol Centro
                x0 = s.xf;
                y0 = s.yf;
                radio = r1 / 1.5;
                alfa = alfa1;                
                Arbol(lienzo);
            }
        }
        public void Arbol_Interpolado(Bitmap lienzo)
        {
            Segmento s = new Segmento();
            s.x0 = x0;
            s.y0 = y0;
            double r1 = radio, alfa1 = alfa;
            if (radio > 0.1)
            {
                s.xf = x0 + radio * Math.Cos(alfa);
                s.yf = y0 + radio * Math.Sin(alfa);
                int R = (int)(0);
                int G = (int)(85 * (3-radio));
                int B = (int)(85 * (3 - radio) + 66.666 * radio);
                s.color0 = Color.FromArgb(R, G, B);
                s.Encender(lienzo);

                // Arbol Derecha
                x0 = s.xf;
                y0 = s.yf;
                radio = radio / 2;
                alfa = alfa - beta;
                Arbol_Interpolado(lienzo);/// llama al proceso recursivo

                // Arbol Izquierda
                x0 = s.xf;
                y0 = s.yf;
                radio = r1 / 2;
                alfa = alfa1 + beta;
                Arbol_Interpolado(lienzo);

                // Arbol Centro
                x0 = s.xf;
                y0 = s.yf;
                radio = r1 / 1.7;
                alfa = alfa1;
                Arbol_Interpolado(lienzo);
            }
        }
        public void Arbol1(Bitmap lienzo)
        {
            Segmento s = new Segmento();
            s.x0 = x0;
            s.y0 = y0;
            double r1 = radio, alfa1 = alfa;
            if (radio > 0.1)
            {
                s.xf = x0 + radio * Math.Cos(alfa);
                s.yf = y0 + radio * Math.Sin(alfa);
                s.color0 = color0;
                s.Encender(lienzo);

                // Arbol Derecha
                x0 = s.xf;
                y0 = s.yf;
                radio = radio / 2;
                alfa = alfa - beta;
                Arbol1(lienzo);/// llama al proceso recursivo

                // Arbol Izquierda
                x0 = s.xf;
                y0 = s.yf;
                radio = r1 / 2;
                alfa = alfa1 + beta;
                Arbol1(lienzo);

                // Arbol Centro
                x0 = s.xf;
                y0 = s.yf;
                radio = r1/1.8;
                alfa = alfa1;
                Arbol1(lienzo);
            }
        }

        public void Estrella(Bitmap lienzo)
        {
            double aux = 0;
            Segmento s = new Segmento();            
            s.x0 = x0;
            s.y0 = y0;            
            do
            {
                s.xf = x0 + radio * Math.Cos(aux);
                s.yf = y0 + radio * Math.Sin(aux);
                s.color0 = color0;
                s.Encender(lienzo);
                aux = aux + alfa;
            } while (aux <= 2 * Math.PI);
        }

        public void aves(Bitmap lienzo)
        {
            Vector v = new Vector();
            double w, dw;
            w = Math.PI/6;
            dw = 0.001;
            do
            {
                v.x0 = x0 + radio * Math.Cos(w);
                v.y0 = y0 + radio * Math.Sin(w);
                v.color0 = color0;
                v.Encender(lienzo);
                w = w + dw;
            } while (w<=Math.PI);

            w = 0;
            dw = 0.001;
            do
            {
                v.x0 = (x0-(2*radio)) + radio * Math.Cos(w);
                v.y0 = y0 + radio * Math.Sin(w);
                v.color0 = color0;
                v.Encender(lienzo);
                w = w + dw;
            } while (w <= 5*Math.PI/6);
        }

        public int FractalManderbrot(double x0, double y0, out int colorM)
        {            
            double Xn, Yn, Xnn, Ynn, d = 0;
            colorM = 0;                       
            Xn = x0;
            Yn = y0;
            for (int i = 0; i < 100; i++)
            {
                //fractal de manderbrot
                Xnn = (Xn * Xn) - (Yn * Yn) + x0;
                Ynn = 2 * Xn * Yn + y0;
                d = Math.Sqrt(Math.Pow((Xnn - x0), 2) + Math.Pow((Ynn - y0), 2));
                if (d <= 2) // Si converge
                {
                    Xn = Xnn;
                    Yn = Ynn;                    
                }
                else //No convergen
                {
                    colorM = (i % 15)+1;                    
                    i = 100;
                }
            }
            return colorM;
        }

        public int FractalJulia(double x0, double y0, out int colorM)
        {
            double Xn, Yn, Xnn, Ynn, d = 0;
            colorM = 0;
            Xn = x0;
            Yn = y0;
            for (int i = 0; i <= 100; i++)
            {
                //fractal de julia
                Xnn = (Xn * Xn) - (Yn * Yn) - 1;
                Ynn = 2 * Xn * Yn + 0.25;               
                d = Math.Sqrt(Math.Pow((Xnn - 0), 2) + Math.Pow((Ynn - 0), 2));
                if (d <= 2) // Si converge
                {
                    Xn = Xnn;
                    Yn = Ynn;
                }
                else //No convergen
                {
                    colorM = (i % 15) + 1;
                    i = 100;
                }
            }
            return colorM;
        }        
    }
}
