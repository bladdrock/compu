using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelNuevoCGWF
{
    public partial class Form1 : Form
    {
        Bitmap pantalla = new Bitmap(600, 460);
        double x0, y0, xf, yf;

        public List<double> VX = new List<double>();
        public List<double> VY = new List<double>();

        int contador = 0;
        private double radio;
        public int cont = 0;
        public Color[] Paleta;
        Color[] PaletaI2 = new Color[17];
        Color[] PaletaI4 = new Color[17];

        
        

        public Form1()
        {
            InitializeComponent();
        }

        

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        public void limpiar_pantalla()
        {
            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 460; j++)
                {
                    pantalla.SetPixel(i, j, Color.WhiteSmoke);
                }
            }
            pictureBox1.Image = pantalla;
        }
        private void btnClean_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pantalla;
            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 460; j++)
                {
                    pantalla.SetPixel(i, j, Color.WhiteSmoke);
                }
            }
                      
            cont = 0;
            VX.Clear();
            VY.Clear();
        }
        

        private void btnTarea1_Click(object sender, EventArgs e)
        {
            pantalla = new Bitmap(600, 460);
            Circunferencia c = new Circunferencia(-3, -1, 4, Color.Red, pantalla, pictureBox1);
            c.Encender();

            Circunferencia c1 = new Circunferencia(1, 1, 4.5, Color.Red, pantalla, pictureBox1);
            c1.Encender();

            Segmento s = new Segmento(4, -2, 4, 6, Color.Red, pantalla, pictureBox1);
            s.Encender();

            Segmento s1 = new Segmento(-3, 4, 6, 4, Color.Red, pantalla, pictureBox1);
            s1.Encender();

            Segmento s2 = new Segmento(-4, 5, 5, -1, Color.Red, pantalla, pictureBox1);
            s2.Encender();
        }

        

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            ClPantalla p1 = new ClPantalla();
            p1.Pantalla(e.X, e.Y, out xf, out yf);
            VX.Add(xf);
            VY.Add(yf);
            contador++;
            radio = Math.Sqrt(Math.Pow(xf - x0, 2) + Math.Pow(yf - y0, 2));
 
            
        }
        

        public void GraficarFuncion()
        {
            //Funcion 
            double x = -10, dx = 0.002;
            Vector vec = new Vector(0, 0, Color.Blue, pantalla, pictureBox1);
            do
            {
                vec.X0 = x;
                vec.Y0 = (5 * Math.Cos((Math.PI * x) / 10));

                //vec.Y0 = (x * (x - 10) * (x + 10)) / 75;
                vec.Color0 = Color.Blue;
                vec.Encender();
                x = x + dx;
            } while (x <= 10);
        }

        

        public void GraficaTangente(double x0)
        {
            double vy = (x0 * (x0 - 10) * (x0 + 10)) / 75;
            Circunferencia cir = new Circunferencia(x0, vy, 0.10, Color.Green, pantalla, pictureBox1);
            cir.Encender();

            double vx = -10, dx = 0.002;
            Vector vec = new Vector(0, 0, Color.Blue, pantalla, pictureBox1);
            double m = (3 * Math.Pow(x0, 2) - 100) / 75;
            do
            {
                vec.X0 = vx;
                vec.Y0 = ((m) * (vx - x0)) + vy;
                vec.Color0 = Color.Red;
                vec.Encender();
                vx += dx;
            } while (vx <= 10);
        }

        

        private void button42_Click(object sender, EventArgs e)
        {
            Segmento3D seg3d = new Segmento3D(0, 0, 0, 0, 4, 0, Color.Red, pantalla, pictureBox1);
            seg3d.Encender();
            Segmento3D seg3d1 = new Segmento3D(0, 0, 0, 0, 0, 4, Color.Red, pantalla, pictureBox1);
            seg3d1.Encender();
            Segmento3D seg3d2 = new Segmento3D(0, 0, 0, 4, 0, 0, Color.Red, pantalla, pictureBox1);
            seg3d2.Encender();
            Segmento3D seg3d4 = new Segmento3D(4, 0, 0, 4, 0, 4, Color.Red, pantalla, pictureBox1);
            seg3d4.Encender();
            Segmento3D seg3d5 = new Segmento3D(0, 0, 4, 4, 0, 4, Color.Red, pantalla, pictureBox1);
            seg3d5.Encender();
            Segmento3D seg3d6 = new Segmento3D(0, 4, 0, 0, 4, 4, Color.Red, pantalla, pictureBox1);
            seg3d6.Encender();
            Segmento3D seg3d7 = new Segmento3D(0, 4, 0, 4, 4, 0, Color.Red, pantalla, pictureBox1);
            seg3d7.Encender();
            Segmento3D seg3d8 = new Segmento3D(4, 0, 0, 4, 4, 0, Color.Red, pantalla, pictureBox1);
            seg3d8.Encender();
            Segmento3D seg3d9 = new Segmento3D(4, 4, 4, 4, 4, 0, Color.Red, pantalla, pictureBox1);
            seg3d9.Encender();
            Segmento3D seg3d10 = new Segmento3D(4, 4, 4, 4, 0, 4, Color.Red, pantalla, pictureBox1);
            seg3d10.Encender();
            Segmento3D seg3d11 = new Segmento3D(0, 0, 4, 0, 4, 4, Color.Red, pantalla, pictureBox1);
            seg3d11.Encender();
            Segmento3D seg3d12 = new Segmento3D(0, 4, 4, 4, 4, 4, Color.Red, pantalla, pictureBox1);
            seg3d12.Encender();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Segmento3D seg3d1 = new Segmento3D(0, 5, 0, 0, 8, 0, Color.Blue, pantalla, pictureBox1);
            seg3d1.Encender();
            Segmento3D seg3d2 = new Segmento3D(0, 5, 0, 3, 5, 0, Color.Blue, pantalla, pictureBox1);
            seg3d2.Encender();
            Segmento3D seg3d3 = new Segmento3D(0, 5, 0, 0, 5, 3, Color.Blue, pantalla, pictureBox1);
            seg3d3.Encender();
            Segmento3D seg3d4 = new Segmento3D(0, 5, 3, 0, 8, 3, Color.Blue, pantalla, pictureBox1);
            seg3d4.Encender();
            Segmento3D seg3d5 = new Segmento3D(0, 5, 3, 3, 5, 3, Color.Blue, pantalla, pictureBox1);
            seg3d5.Encender();
            Segmento3D seg3d6 = new Segmento3D(0, 8, 0, 0, 8, 3, Color.Blue, pantalla, pictureBox1);
            seg3d6.Encender();
            Segmento3D seg3d7 = new Segmento3D(0, 8, 0, 3, 8, 0, Color.Blue, pantalla, pictureBox1);
            seg3d7.Encender();
            Segmento3D seg3d8 = new Segmento3D(0, 8, 3, 3, 8, 3, Color.Blue, pantalla, pictureBox1);
            seg3d8.Encender();
            Segmento3D seg3d9 = new Segmento3D(3, 5, 0, 3, 5, 3, Color.Blue, pantalla, pictureBox1);
            seg3d9.Encender();
            Segmento3D seg3d10 = new Segmento3D(3, 5, 0, 3, 8, 0, Color.Blue, pantalla, pictureBox1);
            seg3d10.Encender();
            Segmento3D seg3d11 = new Segmento3D(3, 5, 3, 3, 8, 3, Color.Blue, pantalla, pictureBox1);
            seg3d11.Encender();
            Segmento3D seg3d12 = new Segmento3D(3, 8, 3, 3, 8, 0, Color.Blue, pantalla, pictureBox1);
            seg3d12.Encender();
        }

        

        private void button45_Click(object sender, EventArgs e)
        {
            Segmento3D seg3d1 = new Segmento3D(0, -5, 0, 0, -8, 0, Color.Green, pantalla, pictureBox1);
            seg3d1.Encender();
            Segmento3D seg3d2 = new Segmento3D(0, -5, 3, 0, -8, 3, Color.Green, pantalla, pictureBox1);
            seg3d2.Encender();
            Segmento3D seg3d3 = new Segmento3D(3, -8, 0, 0, -8, 0, Color.Green, pantalla, pictureBox1);
            seg3d3.Encender();
            Segmento3D seg3d4 = new Segmento3D(0, -5, 0, 3, -5, 0, Color.Green, pantalla, pictureBox1);
            seg3d4.Encender();
            Segmento3D seg3d5 = new Segmento3D(3, -5, 0, 3, -8, 0, Color.Green, pantalla, pictureBox1);
            seg3d5.Encender();
            Segmento3D seg3d6 = new Segmento3D(0, -8, 0, 0, -8, 3, Color.Green, pantalla, pictureBox1);
            seg3d6.Encender();
            Segmento3D seg3d7 = new Segmento3D(0, -5, 0, 0, -5, 3, Color.Green, pantalla, pictureBox1);
            seg3d7.Encender();
            Segmento3D seg3d8 = new Segmento3D(3, -8, 0, 3, -8, 3, Color.Green, pantalla, pictureBox1);
            seg3d8.Encender();
            Segmento3D seg3d9 = new Segmento3D(3, -5, 0, 3, -5, 3, Color.Green, pantalla, pictureBox1);
            seg3d9.Encender();
            Segmento3D seg3d10 = new Segmento3D(3, -8, 3, 3, -5, 3, Color.Green, pantalla, pictureBox1);
            seg3d10.Encender();
            Segmento3D seg3d11 = new Segmento3D(3, -5, 3, 0, -5, 3, Color.Green, pantalla, pictureBox1);
            seg3d11.Encender();
            Segmento3D seg3d12 = new Segmento3D(3, -8, 3, 0, -8, 3, Color.Green, pantalla, pictureBox1);
            seg3d12.Encender();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            Segmento3D seg3d1 = new Segmento3D(0, -5, 0, 0, -8, 0, Color.Green, pantalla, pictureBox1);
            seg3d1.Encender();
            Segmento3D seg3d3 = new Segmento3D(3, -8, 0, 0, -8, 0, Color.Green, pantalla, pictureBox1);
            seg3d3.Encender();
            Segmento3D seg3d4 = new Segmento3D(0, -5, 0, 3, -5, 0, Color.Green, pantalla, pictureBox1);
            seg3d4.Encender();
            Segmento3D seg3d5 = new Segmento3D(3, -5, 0, 3, -8, 0, Color.Green, pantalla, pictureBox1);
            seg3d5.Encender();
            Segmento3D seg3d6 = new Segmento3D(0, -8, 0, 1.5, -6.5, 3, Color.Green, pantalla, pictureBox1);
            seg3d6.Encender();
            Segmento3D seg3d7 = new Segmento3D(0, -5, 0, 1.5, -6.5, 3, Color.Green, pantalla, pictureBox1);
            seg3d7.Encender();
            Segmento3D seg3d8 = new Segmento3D(3, -8, 0, 1.5, -6.5, 3, Color.Green, pantalla, pictureBox1);
            seg3d8.Encender();
            Segmento3D seg3d9 = new Segmento3D(3, -5, 0, 1.5, -6.5, 3, Color.Green, pantalla, pictureBox1);
            seg3d9.Encender();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            Vector3D v3d = new Vector3D(0, 0, 0, Color.Red, pantalla, pictureBox1);
            double t, dt;
            t = 0;
            dt = 0.002;
            do
            {
                v3d.X0 = -1.5;
                v3d.Y0 = -8.1 + 1 * Math.Sin(t);
                v3d.Z0 = 0 + 1 * Math.Cos(t);
                v3d.Encender();
                t += dt;
            } while (t <= 2 * Math.PI);
            Vector3D v3d1 = new Vector3D(0, 0, 0, Color.Orange, pantalla, pictureBox1);
            t = 0;
            dt = 0.002;
            do
            {
                v3d1.X0 = -1.5 + 1 * Math.Sin(t);
                v3d1.Y0 = -6;
                v3d1.Z0 = 0.5 + 1 * Math.Cos(t);
                v3d1.Encender();
                t += dt;
            } while (t <= 2 * Math.PI);
            Vector3D v3d2 = new Vector3D(0, 0, 0, Color.Blue, pantalla, pictureBox1);
            t = 0;
            dt = 0.002;
            do
            {
                v3d2.X0 = -1.5 + 1 * Math.Sin(t);
                v3d2.Y0 = -7.5 + 1 * Math.Cos(t);
                v3d2.Z0 = 1.9;
                v3d2.Encender();
                t += dt;
            } while (t <= 2 * Math.PI);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            Espiral esp = new Espiral(3, 4, 0,2, 2, Color.Orange, pantalla, pictureBox1);
            esp.elasticidad = 2;
            do
            {
                esp.elasticidad += 0.2;
                esp.Color0 = Color.Orange;
                esp.Encender();
                Thread.Sleep(30);
                pictureBox1.Refresh();
                esp.Apagar();
            } while (esp.elasticidad <= 8);
            esp.elasticidad = 8;
            do
            {
                esp.elasticidad -= 0.2;
                esp.Color0 = Color.Orange;
                esp.Encender();
                Thread.Sleep(30);
                pictureBox1.Refresh();
                esp.Apagar();
            } while (esp.elasticidad > 2);
            esp.elasticidad = 2;
            esp.Color0 = Color.Orange;
            esp.Encender();

        }

        private void button49_Click(object sender, EventArgs e)
        {
            Poliedro poli = new Poliedro(0, 0, 0, 2.5, 4, 0,0,0, Color.Blue, pantalla, pictureBox1);
            poli.Encender();
            poli.altura = 4;
            poli.Encender();

        }

        

       

       

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int q = 0; q < 15; q++)
            {
                PaletaI2[q] = Color.FromArgb((int)(17 * q), (int)(17 * q), (int)(13 * q + 60)); // de azul marino a blanco
                PaletaI4[q] = Color.FromArgb((int)((-1) * 17 * q + 255), (int)((-1) * 17 * q + 255), (int)((-1) * 13 * q + 255)); // de blanco a azul marino
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            double w = 0;
            double ela = 4;
            ClEspiral obj = new ClEspiral(ela, 2, 1, 1, 0, Color.Black, pantalla, pictureBox1);
            do
            {
                obj.gama = w;
                obj.eje = 1;
                obj.Color0 = Color.Yellow;
                obj.Encender();
                Thread.Sleep(10);
                pictureBox1.Refresh();
                for (int i = 0; i < 600; i++)
                {
                    for (int j = 0; j < 460; j++)
                    {
                        pantalla.SetPixel(i, j, Color.WhiteSmoke);
                    }
                }
                w = w + 0.2;
            } while (w <= 2 * Math.PI);
            w = 0;
            do
            {
                obj.gama = w;
                obj.eje = 0;
                obj.Color0 = Color.Yellow;
                obj.Encender();
                Thread.Sleep(10);
                pictureBox1.Refresh();
                for (int i = 0; i < 600; i++)
                {
                    for (int j = 0; j < 460; j++)
                    {
                        pantalla.SetPixel(i, j, Color.WhiteSmoke);
                    }
                }
                w = w + 0.2;
            } while (w <= 2 * Math.PI);
            w = 0;
            do
            {
                obj.gama = w;
                obj.eje = 2;
                obj.Color0 = Color.Yellow;
                obj.Encender();
                Thread.Sleep(10);
                pictureBox1.Refresh();
                for (int i = 0; i < 600; i++)
                {
                    for (int j = 0; j < 460; j++)
                    {
                        pantalla.SetPixel(i, j, Color.WhiteSmoke);
                    }
                }
                w = w + 0.2;
            } while (w <= 2 * Math.PI);
            obj.gama = 2 * Math.PI;
            obj.eje = 2;
            obj.Color0 = Color.Yellow;
            obj.Encender();

        }

        private void button53_Click(object sender, EventArgs e)
        {
            pantalla = new Bitmap(600, 460);
            SuperficiesR sup = new SuperficiesR(0, 0, -3, 0, 0.1, 0,0, Color.Black, pantalla, pictureBox1);
            if (CbBxParabol.Text == "1") //Paraboloide hiperbólico
            {
                sup.tipo = 0;
                if (comboBox5.SelectedIndex == 0)
                {
                    sup.opcion = 0;
                }else if (comboBox5.SelectedIndex == 1)
                {
                    sup.opcion = 1;
                }
                else if (comboBox5.SelectedIndex == 2)
                {
                    sup.opcion = 2;
                }
                sup.Encender();
                
                //double i = 0;
                //do
                //{
                //    sup.Color0 = Color.Red;
                //    sup.gama = i;
                //    sup.eje = 0;
                //    sup.Encender();
                //    Thread.Sleep(10);
                //    pictureBox1.Refresh();
                //    limpiar_pantalla();
                //    //sup.Apagar();
                //    i = i + 0.2;
                //} while (i <= (2 * Math.PI));
                //i = 0;
                //do
                //{
                //    sup.Color0 = Color.Red;
                //    sup.gama = i;
                //    sup.eje = 2;
                //    sup.Encender();
                //    Thread.Sleep(10);
                //    pictureBox1.Refresh();
                //    //sup.Apagar();
                //    limpiar_pantalla();
                //    i = i + 0.2;
                //} while (i <= (2 * Math.PI));
                //i = 0;
                //do
                //{
                //    sup.Color0 = Color.Red;
                //    sup.gama = i;
                //    sup.eje = 1;
                //    sup.Encender();
                //    Thread.Sleep(10);
                //    pictureBox1.Refresh();
                //    //sup.Apagar();
                //    limpiar_pantalla();
                //    i = i + 0.2;
                //} while (i < (2 * Math.PI));
                //sup.Color0 = Color.Red;
                //sup.gama = 2 * Math.PI;
                //sup.Encender();
            }
            if (CbBxParabol.Text == "2")
            {
                sup.tipo = 1;
                if (comboBox5.SelectedIndex == 0)
                {
                    sup.opcion = 0;
                }
                else if (comboBox5.SelectedIndex == 1)
                {
                    sup.opcion = 1;
                }
                else if (comboBox5.SelectedIndex == 2)
                {
                    sup.opcion = 2;
                }
                sup.Encender();
            }
            if (CbBxParabol.Text == "3")
            {
                sup.tipo = 2;
                if (comboBox5.SelectedIndex == 0)
                {
                    sup.opcion = 0;
                }
                else if (comboBox5.SelectedIndex == 1)
                {
                    sup.opcion = 1;
                }
                else if (comboBox5.SelectedIndex == 2)
                {
                    sup.opcion = 2;
                }
                sup.Encender();
            }
            if(CbBxParabol.Text == "4")
            {
                sup.tipo = 3;
                if (comboBox5.SelectedIndex == 0)
                {
                    sup.opcion = 0;
                }
                else if (comboBox5.SelectedIndex == 1)
                {
                    sup.opcion = 1;
                }
                else if (comboBox5.SelectedIndex == 2)
                {
                    sup.opcion = 2;
                }
                sup.Encender();
                //double i = 0;
                //do
                //{
                //    sup.Color0 = Color.Red;
                //    sup.gama = i;
                //    sup.eje = 0;
                //    sup.Encender();
                //    Thread.Sleep(10);
                //    pictureBox1.Refresh();
                //    sup.Apagar();
                //    i = i + 0.2;
                //} while (i <= (2 * Math.PI));
                //i = 0;
                //do
                //{
                //    sup.Color0 = Color.Red;
                //    sup.gama = i;
                //    sup.eje = 2;
                //    sup.Encender();
                //    Thread.Sleep(10);
                //    pictureBox1.Refresh();
                //    sup.Apagar();
                //    i = i + 0.2;
                //} while (i <= (2 * Math.PI));
                //i = 0;
                //do
                //{
                //    sup.Color0 = Color.Red;
                //    sup.gama = i;
                //    sup.eje = 1;
                //    sup.Encender();
                //    Thread.Sleep(10);
                //    pictureBox1.Refresh();
                //    sup.Apagar();
                //    i = i + 0.2;
                //} while (i < (2 * Math.PI));
                //sup.Color0 = Color.Red;
                //sup.gama = 2 * Math.PI;
                //sup.Encender();
            }

        }
        public void Elipse()
        {
            Vector3D v3d2 = new Vector3D(0, 0, 0, Color.Red, pantalla, pictureBox1);
            double tt = 0;
            double ddt = 0.002;
            //double tp;
            //tp = Math.Pow(4, 2) + Math.Pow(3, 2);
            do
            {
                v3d2.X0 = 0 + 8 * Math.Sin(tt+4);
                v3d2.Y0 = 0 + 6 * Math.Cos(tt);
                v3d2.Z0 = 0;
                v3d2.Color0 = Color.Red;
                v3d2.Encender();
                v3d2.X0 = 4 + 1 * Math.Sin(tt);
                v3d2.Y0 = -3 + 1 * Math.Cos(tt);
                v3d2.Z0 = 0;
                v3d2.Color0 = Color.Orange;
                v3d2.Encender();
                tt += ddt;
            } while (tt <= 2 * Math.PI);
        }
        private void button54_Click(object sender, EventArgs e)
        {
            pantalla = new Bitmap(600, 460);
            Poliedro pir = new Poliedro(0, 0, 2, 2, 5, 0, 0, 2, Color.Blue, pantalla, pictureBox1);
            double w = 0;
            do
            {
                Elipse();
                //pir.Ejes();
                pir = new Poliedro(0, 0, 2, 2, 5, 0, w, 2, Color.Blue, pantalla, pictureBox1);
                pir.X0 = 0 + 8 * Math.Sin(w+4);
                pir.Y0 = 0 + 6 * Math.Cos(w);
                pir.EncenderPiramideInvertida();
                Thread.Sleep(40);
                pictureBox1.Refresh();
                //w = w + 0.31415926535;
                w = w + 0.26179938779;
                pir.ApagarP();
            } while (w <= (2 * Math.PI));
            pir = new Poliedro(pir.X0, pir.Y0, 2, 2, 5, 0, w, 2, Color.Blue, pantalla, pictureBox1);
            pir.EncenderPiramideInvertida();

            //Poliedro piramide = new Poliedro(3, -4, 3, 1, 5, 2,0,0, Color.Blue, pantalla, pictureBox1);
            //double t = 0;
            //piramide.eje = 2;
            //do
            //{
            //    piramide.gama = t;
            //    piramide.Color0 = Color.Blue;
            //    piramide.EncenderPiramideInvertida();
            //    Thread.Sleep(10);
            //    pictureBox1.Refresh();
            //    piramide.ApagarP();
            //    t += 0.3;
            //    piramide.Ejes();
            //} while (t <= 2 * Math.PI);
        }

        private void button55_Click(object sender, EventArgs e)
        {
            
        }

        private void CbBxParabol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void FractalKoch_Click_1(object sender, EventArgs e)
        {
        }

        private void button56_Click(object sender, EventArgs e)
        {
            Poliedro pol = new Poliedro(0, 0, 0, 2.5, 6, 3,0,0, Color.Blue, pantalla, pictureBox1);
            double w = 0;
            //Eje X
            pol.eje = 0;
            do
            {
                pol.gama = w;
                pol.Color0 = Color.Blue;
                pol.RotarEncender();
                Thread.Sleep(10);
                pictureBox1.Refresh();
                pol.Apagar();
                w += 0.3;
            } while (w <= 2 * Math.PI);

            //Eje Y
            w = 0;
            pol.eje = 1;
            do
            {
                pol.gama = w;
                pol.Color0 = Color.Blue;
                pol.RotarEncender();
                Thread.Sleep(10);
                pictureBox1.Refresh();
                pol.Apagar();
                w += 0.3;
            } while (w <= 2 * Math.PI);

            //Eje Z
            w = 0;
            pol.eje = 2;
            do
            {
                pol.gama = w;
                pol.Color0 = Color.Blue;
                pol.RotarEncender();
                Thread.Sleep(10);
                pictureBox1.Refresh();
                pol.Apagar();
                w += 0.3;
            } while (w <= 2 * Math.PI);
            pol.Color0 = Color.Blue;
            pol.Encender();
        }

        private void button57_Click(object sender, EventArgs e)
        {
            pantalla = new Bitmap(600, 460);

            if (comboBox6.SelectedIndex == 0)
            {
                SuperficieV sup = new SuperficieV(2, 1, -2, 3, 0, 1,0, Color.Red, pantalla, pictureBox1);
                if (comboBox5.SelectedIndex == 0)
                {
                    sup.opcion = 0;
                }
                else if (comboBox5.SelectedIndex == 1)
                {
                    sup.opcion = 1;
                }
                else if (comboBox5.SelectedIndex == 2)
                {
                    sup.opcion = 2;
                }
                sup.Encender();
            }
            else if (comboBox6.SelectedIndex == 1)
            {
                SuperficieV sup2 = new SuperficieV(0, -4, -2, 3, 0, 2,0, Color.Green, pantalla, pictureBox1);
                if (comboBox5.SelectedIndex == 0)
                {
                    sup2.opcion = 0;
                }
                else if (comboBox5.SelectedIndex == 1)
                {
                    sup2.opcion = 1;
                }
                else if (comboBox5.SelectedIndex == 2)
                {
                    sup2.opcion = 2;
                }
                sup2.Encender();
            }
            else if (comboBox6.SelectedIndex == 2)
            {
                SuperficieV sup1 = new SuperficieV(0, 4, 3, 3, 0, 3,0, Color.Black, pantalla, pictureBox1);
                if (comboBox5.SelectedIndex == 0)
                {
                    sup1.opcion = 0;
                }
                else if (comboBox5.SelectedIndex == 1)
                {
                    sup1.opcion = 1;
                }
                else if (comboBox5.SelectedIndex == 2)
                {
                    sup1.opcion = 2;
                }
                sup1.Encender();
            }
        }

        private void button58_Click(object sender, EventArgs e)
        {
            Vector v = new Vector(0,0, Color.Black, pantalla, pictureBox1);
            if (cont == 4)
            {
                v.Cuadrilatero1(VX[0], VY[0], VX[1], VY[1], VX[2], VY[2], VX[3], VY[3], 1);
                pictureBox1.Image = pantalla;
                
            }
            else
            {
                MessageBox.Show("No se han seleccionado puntos");
            }
            
        }

        

        private void button51_Click_1(object sender, EventArgs e)
        {
            Espiral esp = new Espiral(0, -4, 0, 3, 3, Color.Orange, pantalla, pictureBox1);
            esp.EncenderHorizontal();
        }

       

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //RX.Text = e.Location.X.ToString();
            //RY.Text = e.Location.Y.ToString();
            double Px, Py;
            ClPantalla m = new ClPantalla();
            m.Pantalla(e.X, e.Y, out Px, out Py);
            RX.Text = "X = " + Math.Round(Px,2);
            RY.Text = "Y = " + Math.Round(Py, 2);
        }

        

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ClPantalla p = new ClPantalla();
            p.Pantalla(e.X, e.Y, out x0, out y0);
        }


        private void RellenoInundacion(Point pt, Color ColorBorde,int num_relleno)
        {
            Stack<Point> pixels = new Stack<Point>();
            ColorBorde = pantalla.GetPixel(pt.X, pt.Y);
            pixels.Push(pt);
            int tcolor;
            while (pixels.Count > 0)
            {
                Point a = pixels.Pop();
                if (a.X < pantalla.Width && a.X > 0 && a.Y < pantalla.Height && a.Y > 0)
                {
                    if (pantalla.GetPixel(a.X, a.Y) == ColorBorde)
                    {
                        tcolor = (int)(Math.Abs(((int)((Math.Cos(a.X) * 15) + (Math.Sin(a.Y) * 15))) % 10));
                        if(num_relleno == 1)
                        {
                            pantalla.SetPixel(a.X, a.Y, PaletaI4[tcolor]);
                        }
                        if(num_relleno == 2)
                        {
                            pantalla.SetPixel(a.X, a.Y, PaletaI2[tcolor]);
                        }
                        pixels.Push(new Point(a.X - 1, a.Y));
                        pixels.Push(new Point(a.X + 1, a.Y));
                        pixels.Push(new Point(a.X, a.Y - 1));
                        pixels.Push(new Point(a.X, a.Y + 1));
                    }
                }
            }
        }
    }

}
