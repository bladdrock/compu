using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exposicion
{
    public partial class Form1 : Form
    {
        public Bitmap lienzo = new Bitmap(600, 500);
        double xf = 0, yf = 0;
        int tipo_fractal = 0;
        int contadorPuntos;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 600; i++)
            {
                for (int j = 300; j < 500; j++)
                {
                    lienzo.SetPixel(i, j, Color.FromArgb(0, (int)(1.275 * (j - 300)), (int)(0.25 * (500 - j) + 1.275 * (j - 300))));
                }
            }

            for (int i = 0; i <= 599; i++)
            {
                for (int j = 0; j <= 299; j++)
                {
                    lienzo.SetPixel(i, j, Color.FromArgb(0, 0, 50));
                }
            }

            //Luna
            Circunferencia c = new Circunferencia();
            c.x0 = 5;
            c.y0 = 5;
            double x = 0;
            do
            {
                c.radio = x;
                c.color0 = Color.White;
                c.Encender(lienzo);
                x = x + 0.03;
            } while (x <= 1.4);
            VentanaP.Image = lienzo;

            ///Destello Luna
            c.x0 = 5;
            c.y0 = 5;
            x = 1.4;
            do
            {
                c.radio = x;
                c.color0 = Color.FromArgb((int)(200 * (2.4 - x)), (int)(200 * (2.4 - x)), (int)(200 * (2.4 - x) + 50 * (x - 1.4)));
                c.Encender(lienzo);
                x = x + 0.03;
            } while (x <= 2.4);
            VentanaP.Image = lienzo;

            // Montana 
            Vector v = new Vector();
            x = -10;
            double var = 8;
            for (int i = 0; i <= 124; i++)
            {
                do
                {
                    v.x0 = x;
                    v.y0 = 2.5 * Math.Exp(-Math.Pow((x / 5), 2)) - var;
                    v.color0 = Color.Black;
                    v.Encender(lienzo);
                    x = x + 0.02;
                } while (x <= 10);
                x = -10;
                var = var + 0.02;
            }
            VentanaP.Image = lienzo;

            // Focos
            Circunferencia c1 = new Circunferencia();
            c1.x0 = -3.9;
            c1.y0 = 4;
            x = 0;
            do
            {
                c1.radio = x;
                c1.color0 = Color.Red;
                c1.Encender(lienzo);
                x = x + 0.03;
            } while (x <= 0.14);
            VentanaP.Image = lienzo;

            c1.x0 = -2.13;
            c1.y0 = 4;
            x = 0;
            do
            {
                c1.radio = x;
                c1.color0 = Color.Red;
                c1.Encender(lienzo);
                x = x + 0.03;
            } while (x <= 0.14);
            VentanaP.Image = lienzo;

            c1.x0 = -4.45;
            c1.y0 = 3.18;
            x = 0;
            do
            {
                c1.radio = x;
                c1.color0 = Color.Yellow;
                c1.Encender(lienzo);
                x = x + 0.03;
            } while (x <= 0.14);
            VentanaP.Image = lienzo;

            c1.x0 = -1.5;
            c1.y0 = 3.18;
            x = 0;
            do
            {
                c1.radio = x;
                c1.color0 = Color.Yellow;
                c1.Encender(lienzo);
                x = x + 0.03;
            } while (x <= 0.14);
            VentanaP.Image = lienzo;

            c1.x0 = -5.37;
            c1.y0 = 2;
            x = 0;
            do
            {
                c1.radio = x;
                c1.color0 = Color.Blue;
                c1.Encender(lienzo);
                x = x + 0.03;
            } while (x <= 0.14);
            VentanaP.Image = lienzo;

            c1.x0 = -0.67;
            c1.y0 = 2;
            x = 0;
            do
            {
                c1.radio = x;
                c1.color0 = Color.Blue;
                c1.Encender(lienzo);
                x = x + 0.03;
            } while (x <= 0.14);
            VentanaP.Image = lienzo;

            c1.x0 = -6.7;
            c1.y0 = 0.26;
            x = 0;
            do
            {
                c1.radio = x;
                c1.color0 = Color.Green;
                c1.Encender(lienzo);
                x = x + 0.03;
            } while (x <= 0.14);
            VentanaP.Image = lienzo;

            c1.x0 = 0.64;
            c1.y0 = 0.26;
            x = 0;
            do
            {
                c1.radio = x;
                c1.color0 = Color.Green;
                c1.Encender(lienzo);
                x = x + 0.03;
            } while (x <= 0.14);
            VentanaP.Image = lienzo;

            c1.x0 = -8.68;
            c1.y0 = -2.42;
            x = 0;
            do
            {
                c1.radio = x;
                c1.color0 = Color.Red;
                c1.Encender(lienzo);
                x = x + 0.03;
            } while (x <= 0.14);
            VentanaP.Image = lienzo;

            c1.x0 = 2.7;
            c1.y0 = -2.42;
            x = 0;
            do
            {
                c1.radio = x;
                c1.color0 = Color.Red;
                c1.Encender(lienzo);
                x = x + 0.03;
            } while (x <= 0.14);
            VentanaP.Image = lienzo;

            c1.x0 = -7.23;
            c1.y0 = -3.49;
            x = 0;
            do
            {
                c1.radio = x;
                c1.color0 = Color.Yellow;
                c1.Encender(lienzo);
                x = x + 0.03;
            } while (x <= 0.14);
            VentanaP.Image = lienzo;

            c1.x0 = 1.2;
            c1.y0 = -3.49;
            x = 0;
            do
            {
                c1.radio = x;
                c1.color0 = Color.Yellow;
                c1.Encender(lienzo);
                x = x + 0.03;
            } while (x <= 0.14);
            VentanaP.Image = lienzo;

            c1.x0 = -6.34;
            c1.y0 = -4.18;
            x = 0;
            do
            {
                c1.radio = x;
                c1.color0 = Color.Blue;
                c1.Encender(lienzo);
                x = x + 0.03;
            } while (x <= 0.14);
            VentanaP.Image = lienzo;

            c1.x0 = 0.33;
            c1.y0 = -4.18;
            x = 0;
            do
            {
                c1.radio = x;
                c1.color0 = Color.Blue;
                c1.Encender(lienzo);
                x = x + 0.03;
            } while (x <= 0.14);
            VentanaP.Image = lienzo;

            c1.x0 = -5;
            c1.y0 = -5.14;
            x = 0;
            do
            {
                c1.radio = x;
                c1.color0 = Color.Green;
                c1.Encender(lienzo);
                x = x + 0.03;
            } while (x <= 0.14);
            VentanaP.Image = lienzo;

            c1.x0 = -1;
            c1.y0 = -5.14;
            x = 0;
            do
            {
                c1.radio = x;
                c1.color0 = Color.Green;
                c1.Encender(lienzo);
                x = x + 0.03;
            } while (x <= 0.14);
            VentanaP.Image = lienzo;


            //Arboles
            Fractal1 f = new Fractal1();
            f.x0 = -3;
            f.y0 = -6.24;
            f.radio = 4;
            f.alfa = Math.PI / 2;
            f.beta = Math.PI / 2;
            f.color0 = Color.White;
            f.Arbol(lienzo);
            VentanaP.Image = lienzo;

            // Arboles Izquierda
            f.x0 = -8;
            f.y0 = -7.8;
            f.radio = 1.5;
            f.alfa = Math.PI / 2;
            f.beta = Math.PI / 5;
            f.color0 = Color.White;
            f.Arbol(lienzo);
            VentanaP.Image = lienzo;

            f.x0 = -4.2;
            f.y0 = -6.7;
            f.radio = 0.8;
            f.alfa = Math.PI / 2;
            f.beta = Math.PI / 5;
            f.color0 = Color.White;
            f.Arbol(lienzo);
            VentanaP.Image = lienzo;

            // Arboles Derecha
            f.x0 = 8;
            f.y0 = -7.8;
            f.radio = 2;
            f.alfa = Math.PI / 2;
            f.beta = Math.PI / 5;
            f.color0 = Color.White;
            f.Arbol(lienzo);
            VentanaP.Image = lienzo;

            f.x0 = 4;
            f.y0 = -6.7;
            f.radio = 1.8;
            f.alfa = Math.PI / 2;
            f.beta = Math.PI / 5;
            f.color0 = Color.White;
            f.Arbol(lienzo);
            VentanaP.Image = lienzo;

            f.x0 = 2;
            f.y0 = -5.86;
            f.radio = 0.8;
            f.alfa = Math.PI / 2;
            f.beta = Math.PI / 3;
            f.color0 = Color.White;
            f.Arbol1(lienzo);
            VentanaP.Image = lienzo;

            f.x0 = 5.93;
            f.y0 = -7.39;
            f.radio = 1;
            f.alfa = Math.PI / 2;
            f.beta = Math.PI / 4;
            f.color0 = Color.White;
            f.Arbol1(lienzo);
            VentanaP.Image = lienzo;

            f.x0 = 0;
            f.y0 = -5.5;
            f.radio = 0.3;
            f.alfa = Math.PI / 2;
            f.beta = Math.PI / 3;
            f.color0 = Color.White;
            f.Arbol1(lienzo);
            VentanaP.Image = lienzo;

            // Estrellas
            f.x0 = -8.53;
            f.y0 = 0.64;
            f.radio = 0.2;
            f.alfa = Math.PI / 5;
            f.color0 = Color.White;
            f.Estrella(lienzo);
            VentanaP.Image = lienzo;

            f.x0 = -6;
            f.y0 = 7;
            f.radio = 0.2;
            f.alfa = Math.PI / 5;
            f.color0 = Color.White;
            f.Estrella(lienzo);
            VentanaP.Image = lienzo;

            f.x0 = -9;
            f.y0 = 5.2;
            f.radio = 0.2;
            f.alfa = Math.PI / 5;
            f.color0 = Color.White;
            f.Estrella(lienzo);
            VentanaP.Image = lienzo;

            f.x0 = 9;
            f.y0 = 7;
            f.radio = 0.2;
            f.alfa = Math.PI / 5;
            f.color0 = Color.White;
            f.Estrella(lienzo);
            VentanaP.Image = lienzo;

            f.x0 = 9.4;
            f.y0 = 5.4;
            f.radio = 0.2;
            f.alfa = Math.PI / 5;
            f.color0 = Color.White;
            f.Estrella(lienzo);
            VentanaP.Image = lienzo;

            f.x0 = 8;
            f.y0 = 3.8;
            f.radio = 0.2;
            f.alfa = Math.PI / 5;
            f.color0 = Color.White;
            f.Estrella(lienzo);
            VentanaP.Image = lienzo;

            f.x0 = -3.5;
            f.y0 = 6;
            f.radio = 0.2;
            f.alfa = Math.PI / 5;
            f.color0 = Color.White;
            f.Estrella(lienzo);
            VentanaP.Image = lienzo;

            f.x0 = 0;
            f.y0 = 7.5;
            f.radio = 0.2;
            f.alfa = Math.PI / 5;
            f.color0 = Color.White;
            f.Estrella(lienzo);
            VentanaP.Image = lienzo;

            f.x0 = -7;
            f.y0 = 4;
            f.radio = 0.2;
            f.alfa = Math.PI / 5;
            f.color0 = Color.White;
            f.Estrella(lienzo);
            VentanaP.Image = lienzo;

            f.x0 = -1;
            f.y0 = 5;
            f.radio = 0.2;
            f.alfa = Math.PI / 5;
            f.color0 = Color.White;
            f.Estrella(lienzo);
            VentanaP.Image = lienzo;

            f.x0 = 1.2;
            f.y0 = 4.4;
            f.radio = 0.2;
            f.alfa = Math.PI / 5;
            f.color0 = Color.White;
            f.Estrella(lienzo);
            VentanaP.Image = lienzo;

            f.x0 = 2.5;
            f.y0 = 5.25;
            f.radio = 0.2;
            f.alfa = Math.PI / 5;
            f.color0 = Color.White;
            f.Estrella(lienzo);
            VentanaP.Image = lienzo;

            Vector v2 = new Vector();
            double w = Math.PI / 3;
            do
            {
                v2.x0 = 0.8 + 3 * Math.Cos(w);
                v2.y0 = 2.8 + 3 * Math.Sin(w);
                v2.color0 = Color.White;
                v2.Encender(lienzo);
                w = w + 0.01;
            } while (w <= Math.PI / 2);
            VentanaP.Image = lienzo;

            f.x0 = 1.8;
            f.y0 = 6.4;
            f.radio = 0.2;
            f.alfa = Math.PI / 5;
            f.color0 = Color.White;
            f.Estrella(lienzo);
            VentanaP.Image = lienzo;

            Vector v1 = new Vector();
            w = Math.PI / 3;
            do
            {
                v1.x0 = 0.2 + 3 * Math.Cos(w);
                v1.y0 = 3.8 + 3 * Math.Sin(w);
                v1.color0 = Color.White;
                v1.Encender(lienzo);
                w = w + 0.01;
            } while (w <= Math.PI / 2);
            VentanaP.Image = lienzo;

            // Aves
            f.x0 = 8.97;
            f.y0 = -0.67;
            f.radio = 0.2;
            f.color0 = Color.White;
            f.aves(lienzo);
            VentanaP.Image = lienzo;

            f.x0 = 5.2;
            f.y0 = 1.6;
            f.radio = 0.2;
            f.color0 = Color.White;
            f.aves(lienzo);
            VentanaP.Image = lienzo;

            f.x0 = 8.4;
            f.y0 = 1;
            f.radio = 0.5;
            f.color0 = Color.White;
            f.aves(lienzo);
            VentanaP.Image = lienzo;

            f.x0 = 2.4;
            f.y0 = 2;
            f.radio = 0.5;
            f.color0 = Color.White;
            f.aves(lienzo);
            VentanaP.Image = lienzo;

            f.x0 = 5;
            f.y0 = -0.5;
            f.radio = 0.6;
            f.color0 = Color.White;
            f.aves(lienzo);
            VentanaP.Image = lienzo;
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            limpiar();
            contadorPuntos = 0;
        }
        public void limpiar()
        {
            lienzo = null;
            lienzo = new Bitmap(600, 500);
            VentanaP.Image = lienzo;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
