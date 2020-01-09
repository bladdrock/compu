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

namespace Compu_Proyecto
{
    public partial class Form1 : Form
    {

        Color[] paleta0 = new Color[16];

        Color[] paleta1 = new Color[16];

        Color[] paleta2 = new Color[16];

        Color[] paleta3 = new Color[16];

        Bitmap lienzo = new Bitmap(560, 400);
        
        public double qX, qY; //coordenadas mause move
        public double PIX, PIY; //mouse DOWN
        public double PFX, PFY; //mouse UP
        double op = 0;
        double px = 0, py = 0, qx, qy, r;
        public int contCv = 0;
        public double[] vx = new double[50];
        public double[] vy = new double[50];
        public List<double> listVx = new List<double>();
        public List<double> listVy = new List<double>();


        Color[] Paleta = new Color[16];

        Pen goma;
        private Bitmap m_goma;
        //private Color color0;

        Bitmap grafico;
        Color color;

        public Form1()
        {
            InitializeComponent();
            //lienzo = new Bitmap(560, 400);

            goma = new Pen(Color.White, 10);//crear goma
            m_goma = new Bitmap(8, 8);
            Graphics g2 = Graphics.FromImage(m_goma);
            GraphicsUnit gu = GraphicsUnit.Pixel;
            g2.FillRectangle(Brushes.White, m_goma.GetBounds(ref gu));
            g2.Dispose();

            CenterToParent();
            CenterToScreen();
            grafico = new Bitmap(560, 400);
            pictureBox1.Image = grafico;
            color = Color.Blue;

            pictureBox1.Image = lienzo;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lienzo = new Bitmap(560, 400);

            paleta0[0] = Color.Black;
            paleta0[1] = Color.Navy;
            paleta0[2] = Color.Green;
            paleta0[3] = Color.Aqua;
            paleta0[4] = Color.Red;
            paleta0[5] = Color.Purple;
            paleta0[6] = Color.Maroon;
            paleta0[7] = Color.LightGray;
            paleta0[8] = Color.DarkGray;
            paleta0[9] = Color.Blue;
            paleta0[10] = Color.Linen;
            paleta0[11] = Color.Silver;
            paleta0[12] = Color.Teal;
            paleta0[13] = Color.Fuchsia;
            paleta0[14] = Color.Yellow;
            paleta0[15] = Color.White;

            for (int i = 0; i < 15; i++)
            {
                paleta1[i] = Color.FromArgb(17 * i, 0, 0);
            }

            for (int j = 0; j < 15; j++)
            {
                paleta2[j] = Color.FromArgb((31 * j) / 3, 255, 0);
            }

            for (int i = 0; i < 15; i++)
            {
                paleta3[i] = Color.FromArgb(0, 0, i);
            }
            for (int j = 5; j < 15; j++)
            {
                paleta3[j] = Color.FromArgb(0, (int)((230 * (j - 5)) / 225), 255);
            }
        }
        private void btnEncenPixel_Click(object sender, EventArgs e)
        {
            lienzo.SetPixel(200, 10, Color.Blue);
            pictureBox1.Image = lienzo;
        }

        private void btnSegDinamico_Click(object sender, EventArgs e)
        {
            op = 1;
        }

  

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           /* Base Bs = new Base();

            double r1 = 0.6;//jo
            double r2 = 0.15;//adio fijo

            Circunferencia objC = new Circunferencia();

             objC.X0 = PIX;
             objC.Y0 = PIY;

             vx[contCv] = PIX;
             vy[contCv] = PIY;
             contCv = contCv + 1;

             objC.Rad = r1;
           
             objC.color0 = Color.Blue;
             objC.Encender(lienzo);
             objC.Rad = r2;
             objC.color0 = Color.Red;
             objC.Encender(lienzo);

            pictureBox1.Image = lienzo;
            */
             
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Base Bas = new Base();
            Bas.procesoCarta(e.X, e.Y, out qX, out qY);
            lb_X.Text = "X = " + Math.Round(qX, 2);
            Refresh();
            lb_Y.Text = "Y = " + Math.Round(qY, 2);
            Refresh();
        }

    

        private void btnPlano_Click(object sender, EventArgs e)
        {
            Segmento segpl = new Segmento();
            segpl.X0 = 0;
            segpl.Y0 = 7.14;
            segpl.Xf = 0;
            segpl.Yf = -7.14;
            segpl.color0 = Color.Red;
            segpl.Encender(lienzo);
            segpl.X0 = 10;
            segpl.Y0 = 0;
            segpl.Xf = -10;
            segpl.Yf = 0;
            segpl.color0 = Color.Red;
            segpl.Encender(lienzo);
            pictureBox1.Image = lienzo;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            lienzo = new Bitmap(560, 400);
        }

        private void btnCircun_Click(object sender, EventArgs e)
        {
            op = 2;
        }

        private void btnPoligono_Click(object sender, EventArgs e)
        {
            op = 3;
        }

        private void btnLazo_Click(object sender, EventArgs e)
        {
            op = 4;
        }

        private void btnMargarita_Click(object sender, EventArgs e)
        {
            op = 6;
        }

        private void btnHiposila_Click(object sender, EventArgs e)
        {
            op = 5;
        }

        

        private void btn_segmento_Click(object sender, EventArgs e)
        {
            // Segmento
            Segmento obj = new Segmento
            {
                color0 = Color.Red,
                X0 = 0,
                Y0 = 0,
                Xf = 0,
                Yf = 7

            };
            obj.Encender(lienzo);
            pictureBox1.Image = lienzo;
            
        }

        private void btn_circunferencia_Click(object sender, EventArgs e)
        {
            Circunferencia objC = new Circunferencia();                
            objC.X0 = 0;
            objC.Y0 = 0;
            objC.Rad = 4;

            objC.color0 = Color.Blue;
            objC.Encender(lienzo);
            pictureBox1.Image = lienzo;
        }

        private void btn_poligono_Click(object sender, EventArgs e)
        {
           
                Poligono objP = new Poligono();
                objP.X0 = 0;
                objP.Y0 = 0;
                objP.Rad = 4;
                objP.Nlados = 5;
                objP.color0 = Color.Blue;
                objP.Encender(lienzo);
                pictureBox1.Image = lienzo;
            
        }

        private void btn_margarita_Click(object sender, EventArgs e)
        {
            MArgarita objH = new MArgarita();
            objH.X0 = 0;
            objH.Y0 = 0;
            objH.Rad = 4;
            objH.color0 = Color.Green;
            objH.Encender(lienzo);
            pictureBox1.Image = lienzo;
        }

        private void btn_lazo_Click(object sender, EventArgs e)
        {
            Lazo objL = new Lazo();
            objL.X0 = 0;
            objL.Y0 = 0;
            objL.Rad = 4;
            objL.color0 = Color.Blue;
            objL.Encender(lienzo);
            pictureBox1.Image = lienzo;
        }

        private void btn_hipolisa_Click(object sender, EventArgs e)
        {
            Hiposila objM = new Hiposila();
            objM.X0 = 0;
            objM.Y0 = 0;
            objM.Rad = 4;
            objM.color0 = Color.Blue;
            objM.Encender(lienzo);
            pictureBox1.Image = lienzo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    if(j<200)
                    { lienzo.SetPixel(i, j, Color.Red);}
                    else
                    { lienzo.SetPixel(i, j, Color.Blue); }
                }
            }
            pictureBox1.Image = lienzo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    lienzo.SetPixel(i, j, Color.FromArgb((int)(-0.637 * j + 255), 0, (int)(0.637 * j)));
                }
            }
            pictureBox1.Image = lienzo;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    if (j <= 200)
                    {
                        lienzo.SetPixel(i, j, Color.FromArgb((int) (255-(1.275* j)),(int)(1.275 * j), 0));
                    }
                    else
                    {
                        lienzo.SetPixel(i, j, Color.FromArgb(0, (int)(510 - (1.275 * j)), (int)(-255 + (1.275 * j))));
                    }
                }
            }
            pictureBox1.Image = lienzo;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    if(j>i)
                        lienzo.SetPixel(i, j, Color.FromArgb((int)(-0.637 * i + 255), 0, (int)(0.637 * i)));
                    else
                        lienzo.SetPixel(i, j, Color.FromArgb((int)(-0.637 * j )+ 255, 0, (int)(0.637 * j)));

                }
            }
            pictureBox1.Image = lienzo;
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            Color[] paleta1 = new Color[16];
            
            paleta1[0] = Color.Black;
            paleta1[1] = Color.Navy;
            paleta1[2] = Color.Green;
            paleta1[3] = Color.Aqua;
            paleta1[4] = Color.Red;
            paleta1[5] = Color.Purple;
            paleta1[6] = Color.Maroon;
            paleta1[7] = Color.LightGray;
            paleta1[8] = Color.DarkGray;
            paleta1[9] = Color.Blue;
            paleta1[10] = Color.Lime;
            paleta1[11] = Color.Silver;
            paleta1[12] = Color.Teal;
            paleta1[13] = Color.Fuchsia;
            paleta1[14] = Color.Yellow;
            paleta1[15] = Color.White;

            int ColorP = 1;
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    ColorP =(((i*i)/19) + (j) )% 15;
                    lienzo.SetPixel(i, j, paleta1[ColorP]);
                    pictureBox1.Image = lienzo;

                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Color[] Paleta2 = new Color[16];
            Paleta2[0] = Color.FromArgb(255, 255, 120);
            Paleta2[15] = Color.FromArgb(110, 10, 30);

            int ColorP;
            for (int i = 0; i < 16; i++)
            {
                Paleta2[i] = Color.FromArgb((int)(-9.67 * i) + 255, (int)(-14.34 * i) + 255, (int)(-6 * i) + 120);

            }
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; ++j)
                {

                    ColorP = (int)(((i + j))) % 15;

                    lienzo.SetPixel(i, j, Paleta2[ColorP]);
                    pictureBox1.Image = lienzo;


                }

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double t, dt;
            Vector vec = new Vector();
            t = -9;
            dt = 0.002;
            do
            {
                vec.X0 = t;
                vec.Y0 = 0;
                vec.color0 = Color.Blue;
                vec.Encender(lienzo);
                t = t + dt;

            }
            while (t <= 9);
            pictureBox1.Image = lienzo;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double t, dt;
            Vector vec = new Vector();
            t = -9;
            dt = 0.002;
            do
            {
                vec.X0 = t;
                vec.Y0 = 0 + (1.33) * t;
                vec.color0 = Color.Green;
                vec.Encender(lienzo);
                t = t + dt;

            }
            while (t <= 9);
            pictureBox1.Image = lienzo;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double t, dt;
            Vector vec = new Vector();
            t = -9;
            dt = 0.002;
            do
            {
                vec.X0 = t;
                vec.Y0 = 2 * Math.Sin((t / 1.5));
                vec.color0 = Color.Blue;
                vec.Encender(lienzo);
                vec.Y0 = 0 + (1.33) * t + 0;
                vec.color0 = Color.Green;
                vec.Encender(lienzo);
                vec.Y0 = 0 + (1.33) * t + 0 - 0.098 * (Math.Pow((t), 3));
                vec.color0 = Color.Red;
                vec.Encender(lienzo);
                t = t + dt;

            }
            while (t <= 9);
            pictureBox1.Image = lienzo;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double t, dt;
            Vector vec = new Vector();
            t = -9;
            dt = 0.002;
            do
            {
                vec.X0 = t;
                vec.Y0 = 1.57;
                vec.color0 = Color.Green;
                vec.Encender(lienzo);
                t = t + dt;

            }
            while (t <= 9);
            pictureBox1.Image = lienzo;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double t, dt;
            Vector vec = new Vector();
            t = -9;
            dt = 0.002;
            do
            {
                vec.X0 = t;
                vec.Y0 = 1.37 + (t - 1);
                vec.color0 = Color.Blue;
                vec.Encender(lienzo);
                t = t + dt;

            }
            while (t <= 9);
            pictureBox1.Image = lienzo;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double t, dt;
            Vector vec = new Vector();
            t = -10;
            dt = 0.002;
            do
            {
                vec.X0 = t;
                vec.Y0 = 2 * Math.Atan(t);
                vec.color0 = Color.Green;
                vec.Encender(lienzo);
                vec.Y0 = 1.57;
                vec.color0 = Color.Yellow;
                vec.Encender(lienzo);
                vec.Y0 = 1.57 + (t - 1);
                vec.color0 = Color.Red;
                vec.Encender(lienzo);
                vec.Y0 = 1.57 + (t - 1) - 0.5 * Math.Pow((t - 1), 2);
                vec.color0 = Color.BlueViolet;
                vec.Encender(lienzo);
                t = t + dt;

            }
            while (t <= 9);
            pictureBox1.Image = lienzo;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            double t, dt;
            Vector vec = new Vector();
            t = -9;
            dt = 0.002;
            do
            {
                vec.X0 = t;
                vec.Y0 = 1;
                vec.color0 = Color.Green;
                vec.Encender(lienzo);
                
                vec.X0 = t;
                vec.Y0 = 1+0.69*t;
                vec.color0 = Color.Blue;
                vec.Encender(lienzo);

                vec.X0 = t;
                vec.Y0 = 1 + 0.69 * t + 0.24*Math.Pow(t,2);
                vec.color0 = Color.Brown;
                vec.Encender(lienzo);

                vec.X0 = t;
                vec.Y0 = 1 + 0.69 * t + 0.24 * Math.Pow(t, 2)+ 0.05 * Math.Pow(t, 3);
                vec.color0 = Color.Yellow;
                vec.Encender(lienzo);

                vec.X0 = t;
                vec.Y0 = 1 + 0.693 * t + 0.240 * Math.Pow(t, 2) + 0.055 * Math.Pow(t, 3)+ 0.009 * Math.Pow(t, 4);
                vec.color0 = Color.Violet;
                vec.Encender(lienzo);

                t = t + dt;

            }
            while (t <= 9);
            pictureBox1.Image = lienzo;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            double t, dt;
            Vector vec = new Vector();
            t = -9;
            dt = 0.002;
            do
            {
                vec.X0 = t;
                vec.Y0 = 0;
                vec.color0 = Color.Violet;
                vec.Encender(lienzo);

                vec.X0 = t;
                vec.Y0 = 0+(t-1);
                vec.color0 = Color.Blue;
                vec.Encender(lienzo);

                vec.X0 = t;
                vec.Y0 = 0 + (t - 1)-0.5*Math.Pow((t-1),2);
                vec.color0 = Color.Green;
                vec.Encender(lienzo);

                vec.X0 = t;
                vec.Y0 = 0 + (t - 1) - 0.5 * Math.Pow((t - 1), 2)+0.33 * Math.Pow((t - 1), 3);
                vec.color0 = Color.Brown;
                vec.Encender(lienzo);

                vec.X0 = t;
                vec.Y0 = 0 + (t - 1) - 0.5 * Math.Pow((t - 1), 2) + 0.33 * Math.Pow((t - 1), 3)-0.25 * Math.Pow((t - 1), 4);
                vec.color0 = Color.Yellow;
                vec.Encender(lienzo);

                t = t + dt;
            }
            while (t <= 9);
            pictureBox1.Image = lienzo;
        }

        private void lb_Y_Click(object sender, EventArgs e)
        {

        }
        

        private void button13_Click(object sender, EventArgs e)
        {
            op = 7;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (P2comBoxCurvas.SelectedIndex == 0)
            {
                //MessageBox.Show("Poligonal " + contCv + " puntos");
                Segmento segCurvas = new Segmento();
                for (int i = 1; i < contCv; i++)
                {
                    segCurvas.X0 = vx[i];
                    segCurvas.Y0 = vy[i];
                    segCurvas.Xf = vx[i + 1];
                    segCurvas.Yf = vy[i + 1];
                    segCurvas.color0 = Color.Blue;
                    segCurvas.Encender(lienzo);

                }
                pictureBox1.Image = lienzo;

            }
            if (P2comBoxCurvas.SelectedIndex == 1)
            {
                //MessageBox.Show("Lagrange " + contCv);
                Curvas curAj = new Curvas
                {
                    Lvx = listVx,
                    Lvy = listVy,
                    NDatos = contCv,
                    color0 = Color.Green
                };
                curAj.LagrangeEncender(lienzo);
                pictureBox1.Image = lienzo;

            }
            if (P2comBoxCurvas.SelectedIndex == 2)
            {

                Curvas B = new Curvas();

                B.Lvx = listVx;
                B.Lvy = listVy;
                B.NDatos = contCv;
                B.color0 = Color.Green;
                
                B.EncenderBezier(lienzo);
                pictureBox1.Image = lienzo;

            }
            if (P2comBoxCurvas.SelectedIndex == 3)
            {
                Vector vec = new Vector();
                double Sx = 0, Sy = 0, Sxx = 0, Sxy = 0;
                double m = 0;
                for (int i = 0; i < contCv; i++)
                {

                    Sx += vx[i];
                    Sy += vy[i];
                    Sxx += Math.Pow(vx[i], 2);
                    Sxy += vx[i] * vy[i];
                }
                m = (contCv * Sxy - (Sx * Sy)) / (contCv * Sxx - Math.Pow(Sx, 2));
                double q = 0;
                q = (Sy - m * Sx) / contCv;
                // Graficar
                Segmento seg = new Segmento();
                seg.X0 = -10;
                seg.Y0 = m * (-10) + q;
                seg.Xf = 10;
                seg.Yf = m * (10) + q;
                seg.color0 = Color.Green;

                seg.Encender(lienzo);
                pictureBox1.Image = lienzo;
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            contCv = 0;
            
        }

        private void button11_Click_2(object sender, EventArgs e)
        {
            /*
            Segmento s = new Segmento();
            s.X0 = 1;
            s.Y0 = 2;
            s.Xf = 3.96;
            s.Yf = 7.14;
            s.Encender(lienzo);
            s.color0=Color.Green;
            pictureBox1.Image = lienzo;

            */
            Circunferencia c = new Circunferencia();
            double t = 0, dt = 0.2;
            do
            {
                c.X0 = 1 * (1 - t) + (3.96 * t);
                c.Y0 = 2 * (1 - t) + (7.14 * t);
                c.Rad = 0.2;
                c.Encender(lienzo);
                t = t + dt;
            }
            while (t <= 1);
            c.color0 = Color.Black;
            pictureBox1.Image = lienzo;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            Segmento s = new Segmento();
            s.X0 = 1;
            s.Y0 = 2;
            s.Xf = 3.96;
            s.Yf = 7.14;
            s.color0 = Color.Red;
            s.Encender(lienzo);
            s.X0 = 3.96;
            s.Y0 = 7.14;
            s.Xf = 10;
            s.Yf = -3.31;
            s.color0 = Color.Green;
            s.Encender(lienzo);
            pictureBox1.Image = lienzo;
            
            /*
            Circunferencia c = new Circunferencia();
            c.Rad = 2;
            c.X0 = 0;
            c.Y0 = 0;
            c.color0 = Color.Green;
            c.Encender(lienzo);
            pictureBox1.Refresh();
            Thread.Sleep(2000);
            c.Apagar(lienzo);
            pictureBox1.Image = lienzo;
            */
        }

        private void Regresion_Click(object sender, EventArgs e)
        {
            Vector vec = new Vector();
            double Sx=0, Sy=0, Sxx=0, Sxy=0;
            double m = 0;
            for (int i = 0; i < contCv; i++) {

                Sx += vx[i];
                Sy += vy[i];
                Sxx += Math.Pow(vx[i], 2);
                Sxy += vx[i] * vy[i];
            }
            m = (contCv * Sxy - (Sx * Sy))/(contCv* Sxx - Math.Pow(Sx,2));
            double q=0;
            q = (Sy-m* Sx)/ contCv;
            // Graficar
            Segmento seg = new Segmento();
            seg.X0 = -10;
            seg.Y0 = m * (-10) + q;
            seg.Xf = 10;
            seg.Yf= m * (10) + q;
            seg.color0 = Color.Green;

            seg.Encender(lienzo);
            pictureBox1.Image = lienzo;
        }

        private void animaccionCir_Click(object sender, EventArgs e)
        {
            double t=0,dt=0.1;
   
            Circunferencia Cir = new Circunferencia();
            do
            {
                Cir.X0 = 1*(1-t)+(3.96*t);
                Cir.Y0 = 2 * (1 - t) + (7.14 * t);
                Cir.Rad = .3;
                Cir.color0 = Color.Green;
                Cir.Encender(lienzo);
                pictureBox1.Image =lienzo;
                t=t+dt;
                
                //Thread.Sleep(30);
                //pictureBox1.Refresh();
                //Cir.Apagar(lienzo);
            } while (t<=1);

            t = 0;
            dt = 0.05;

            do
            {
                Cir.X0 = 3.96 * (1 - t) + (10 * t);
                Cir.Y0 = 7.14 * (1 - t) + (-3.31 * t);
                Cir.Rad = .3;
                Cir.color0 = Color.Green;
                Cir.Encender(lienzo);
                pictureBox1.Image = lienzo;
                t+=dt;

                //Thread.Sleep(30);
                //pictureBox1.Refresh();
                //Cir.Apagar(lienzo);
            } while (t <= 1);

           // -----------------GRAFICAR SENO DE ARRIBA A BAJO------------ -
           //double w = 7.33;
           // do
           // {
           //     Cir.X0 = Math.Sin(w) - 3;
           //     Cir.Y0 = w;
           //     Cir.Rad = 0.3;
           //     Cir.color0 = Color.Green;
           //     Cir.Encender(lienzo);
           //     pictureBox1.Image = lienzo;
           //     w = w - 0.3;
           //     //Thread.Sleep(50);
           //     //VentanaP.Refresh();
           //     //Cir.Apagar(Lienzo);
           // } while (w >= -7.33);
        }

        private void Cir_Desaparecer_Click(object sender, EventArgs e)
        {
            Circunferencia Cir = new Circunferencia();
                Cir.X0 = 0;
                Cir.Y0 = 0;
                Cir.Rad = 4;
                Cir.color0 = Color.Blue;
                Cir.Encender(lienzo);
                pictureBox1.Image = lienzo;
            pictureBox1.Refresh();
            Thread.Sleep(1500);
                
                Cir.Apagar(lienzo);
        }

        private void Inter_4colores_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 400; i++)
            {
                for (int j = 200; j < 400; j++)
                {
                    if (j > i)
                        lienzo.SetPixel(i, j, Color.FromArgb((int)(-0.637 * i + 255), 0, (int)(0.637 * i)));
                    else
                        lienzo.SetPixel(i, j, Color.FromArgb((int)(-0.637 * i) + 255, 0, (int)(0.637 * i)));

                }
            }
            for (int i = 200; i < 400; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    if (j > i)
                        lienzo.SetPixel(i, j, Color.FromArgb((int)(-0.637 * i) + 255, 0, (int)(0.637 * i)));
                    else
                        lienzo.SetPixel(i, j, Color.FromArgb((int)(-0.637 * j) + 255, 0, (int)(0.637 * j)));

                }
            }
           
            pictureBox1.Image = lienzo;
        }

        private void btn_Arbol_Click(object sender, EventArgs e)
        {
            Fractal1 frac = new Fractal1();

            frac.X0 = -4.5;
            frac.Y0 = -7;
            frac.radio = 4.5;
            frac.alfa = Math.PI / 2;
            frac.beta = Math.PI / 2;
            frac.color0 = Color.Red;
            frac.Arbol(lienzo);
            pictureBox1.Image = lienzo;

            frac.X0 = 4.5;
            frac.Y0 = -7;
            frac.radio = 5.8;
            frac.alfa = Math.PI / 2;
            frac.beta = Math.PI / 6;
            frac.color0 = Color.Blue;
            frac.Arbol(lienzo);
            pictureBox1.Image = lienzo;

            /*
            frac.X0 = -3;
            frac.Y0 = 2;
            frac.radio = 1.2;
            frac.alfa = Math.PI / 2;
            frac.beta = Math.PI / 2;
            frac.color0 = Color.Green;
            frac.Arbol(lienzo);
            pictureBox1.Image = lienzo;
            
            frac.X0 = -1;
            frac.Y0 = -4;
            frac.radio = 2;
            frac.alfa = Math.PI / 2;
            frac.beta = Math.PI / 3;
            frac.color0 = Color.Green;
            frac.Arbol(lienzo);
            pictureBox1.Image = lienzo;

            frac.X0 = 5;
            frac.Y0 = 0;
            frac.radio = 0.9;
            frac.alfa = Math.PI / 2;
            frac.beta = Math.PI / 3;
            frac.color0 = Color.Green;
            frac.Arbol(lienzo);
            pictureBox1.Image = lienzo;
            */
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
                pictureBox1.Dispose();
            
        }

        private void btn_sierpinski_Click(object sender, EventArgs e)
        {
            double Px = -6, Rx = 0, Qx = 6;
            double Py = -4, Ry = 6, Qy = -4;

            double Mx, Nx, Sx;
            double My, Ny, Sy;

            Segmento seg = new Segmento();
            seg.X0 = Px;
            seg.Y0 = Py;
            seg.Xf = Rx;
            seg.Yf = Ry;
            seg.color0 = Color.Red;
            seg.Encender(lienzo);

            Mx = (Px + Rx) / 2;
            My = (Py + Ry) / 2;

            seg.X0 = Rx;
            seg.Y0 = Ry;
            seg.Xf = Qx;
            seg.Yf = Qy;
            seg.color0 = Color.Red;
            seg.Encender(lienzo);

            Nx = (Rx + Qx) / 2;
            Ny = (Ry + Qy) / 2;

            seg.X0 = Qx;
            seg.Y0 = Qy;
            seg.Xf = Px;
            seg.Yf = Py;
            seg.color0 = Color.Red;
            seg.Encender(lienzo);

            Sx = (Px + Qx) / 2;
            Sy = (Py + Qy) / 2;

            Fractal fractal = new Fractal();
            fractal.Sierpinski(Px, Py, Rx, Ry, Qx, Qy, lienzo);

            pictureBox1.Image = lienzo;
        }

        private void Animacion_Click(object sender, EventArgs e)
        {

        }

        int isSierpinskiCarpetPixelFilled(int x, int y)
        {
            while (x > 0 || y > 0)
            {
                if (x % 3 == 1 && y % 3 == 1)
                {
                    return 0;
                }
                x /= 3;
                y /= 3;
            }
            return 1;
        }
        /*
        private void btn_AlfombraSierpinski_Click(object sender, EventArgs e)
        {            
            double sx = -10;
            do
            {
                double sy = -7.14;
                do
                {
                    if (isSierpinskiCarpetPixelFilled((int)(sx), (int)(sy)) == 0)
                    {
                        Vector v = new Vector(sx, sy, Color.Red);
                        v.Encender(lienzo);
                    }
                    sy += 0.03;
                    
                } while (sy < 7.14);
                //pictureBox1.Image = lienzo;
                sx += 0.03;
            } while (sx < 10);
            
            pictureBox1.Image = lienzo;
        }*/
        private void btn_AlfombraSierpinski_Click(object sender, EventArgs e)
        {

            for (double i = -10; i<=10; i += 0.03)
            {
                for(double j= -7.14; j<=7.14; j+= 0.03)
                {
                    if (isSierpinskiCarpetPixelFilled((int)(i), (int)(j)) == 0)
                    {
                        Vector v = new Vector(i, j, Color.Blue);
                        v.Encender(lienzo);
                    }
                }
            }
           

            pictureBox1.Image = lienzo;
        }

        public void Koch(int i, double xp12, double yp12, double xp22, double yp22)
        {
            double sin60 = Math.Sin(3.14 / 3);
            double dx = (xp22 - xp12) / 3;
            double dy = (yp22 - yp12) / 3;
            double xx = xp12 + 3 * dx / 2 - dy * sin60;
            double yy = yp12 + 3 * dy / 2 + dx * sin60;

            if (i <= 0)
            {

                Segmento sec = new Segmento(xp12, yp12, xp22, yp22, color, lienzo, pictureBox1);
                sec.color0 = Color.Blue;
                sec.Encender3();
            }
            else
            {
                Koch(i - 1, xp12, yp12, xp12 + dx, yp12 + dy);
                Koch(i - 1, xp12 + dx, yp12 + dy, xx, yy);
                Koch(i - 1, xx, yy, xp22 - dx, yp22 - dy);
                Koch(i - 1, xp22 - dx, yp22 - dy, xp22, yp22);
            }

        }

        private void btn_hock_Click(object sender, EventArgs e)
        {
            Koch(3, -5, 5, 5, 5);
            Koch(3, 0, -5, -5, 5);
            Koch(3, 5, 5, 0, -5);
        }

        private void btn_Cantor_Click(object sender, EventArgs e)
        {
            Segmento s = new Segmento();
            s.X0 = -4;
            s.Y0 = 6;
            s.Xf = 4;
            s.Yf = 6;
            s.color0 = Color.Blue;
            s.Encender(lienzo);
            pictureBox1.Image = lienzo;
            Cantor(s);
        }

        private void Cantor(Segmento s)
        {
            if (s.Yf <= -4)
                return;
            s.Yf -= 1;

            double d = (s.Xf - s.X0) / 3;
            Segmento s1 = new Segmento();
            s1.X0 = s.X0;
            s1.Y0 = s.Yf;
            s1.Xf = s.X0 + d;
            s1.Yf = s.Yf;
            s1.color0 = Color.Blue;
            s1.Encender(lienzo);
        
            Segmento s2 = new Segmento();
            s2.X0 = s.Xf - d;
            s2.Y0 = s.Yf;
            s2.Xf = s.Xf;
            s2.Yf = s.Yf;
            s2.color0 = Color.Blue;
            s2.Encender(lienzo);
            //Thread.Sleep(10);
            pictureBox1.Refresh();
            Cantor(s1);
            Cantor(s2);
        }

        private void Trazar_puntos_Click(object sender, EventArgs e)
        {
            // Graficar
            Segmento seg = new Segmento();
            seg.X0 = 1;
            seg.Y0 = 2;
            seg.Xf = 3.96;
            seg.Yf = 7.14;
            seg.color0 = Color.Blue;
            seg.Encender(lienzo);
            pictureBox1.Image = lienzo;
            seg.X0 = 3.96;
            seg.Y0 = 7.14;
            seg.Xf = 10;
            seg.Yf = -3.33;
            seg.color0 = Color.Blue;
            seg.Encender(lienzo);
            pictureBox1.Image = lienzo;
        }

        private void btn_Mandelbrot_Click(object sender, EventArgs e)
        {
            Base Bs = new Base();
            Fractal Fract = new Fractal();
            int ColorF;
            double rx, ry;

            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    //Paleta0[1] = Color.Black;
                    Bs.procesoCarta2(i, j, out rx, out ry);
                    Fract.Mandelbrot(rx, ry, out ColorF);
                    lienzo.SetPixel(i, j, paleta1[ColorF]);
                    pictureBox1.Image = lienzo;
                }
            }
        }

        private void btn_Julia_Click(object sender, EventArgs e)
        {
            Base Bs = new Base();
            int colorD;

            Fractal fract = new Fractal();
            double rx, ry;

            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    //Paleta0[1] = Color.Black;
                    Bs.procesoCarta2(i, j, out rx, out ry);
                    fract.Julia(rx, ry, out colorD);
                    lienzo.SetPixel(i, j, paleta1[colorD]);
                }
            }
            pictureBox1.Image = lienzo;
        }

        private void btn_Zoom_Click(object sender, EventArgs e)
        {
            op = 8;
        }



        //-----------------------------------------------------------------

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            int Xpost, Ypost;
            Base Bs = new Base();
            Xpost = e.X;        // obtengo la coordenada x
                                // Xpost = MousePosition.X;
            Ypost = e.Y;       //obtengo la coordenada y, 
            Bs.procesoCarta(Xpost, Ypost, out PFX, out PFY);

            double radio = Math.Sqrt(Math.Pow((PFX - PIX), 2) + Math.Pow((PFY - PIY), 2));// calcue el radio dinamicamente de la circunferencia 
            switch (op)
            {
                case 1:
                    Segmento seg = new Segmento();
                    seg.X0 = PIX;
                    seg.Y0 = PIY;
                    seg.Xf = PFX;
                    seg.Yf = PFY;
                    seg.color0 = Color.Blue;
                    seg.Encender(lienzo);
                    pictureBox1.Image = lienzo;
                    break;

                case 2:
                    Circunferencia objC = new Circunferencia();
                    objC.X0 = PIX;
                    objC.Y0 = PIY;
                    objC.Rad = radio;
                    objC.color0 = Color.Blue;
                    objC.Encender(lienzo);
                    pictureBox1.Image = lienzo;
                    break;
                case 3:
                    int lados = Int32.Parse(txtNumlados.Text);
                    if (lados < 3)
                    {
                        MessageBox.Show("ERROR: Un poligono debe tener minimo 3 lados", "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    }
                    else
                    { 
                    Poligono objP = new Poligono();
                    objP.X0 = PIX;
                    objP.Y0 = PIY;
                    objP.Rad = radio;
                    objP.Nlados = lados;
                    objP.color0 = Color.Blue;
                    objP.Encender(lienzo);
                    pictureBox1.Image = lienzo;
                    }
                    break;
                case 4:
                    Lazo objL = new Lazo();
                    objL.X0 = PIX;
                    objL.Y0 = PIY;
                    objL.Rad = radio;
                    objL.color0 = Color.Blue;
                    objL.Encender(lienzo);
                    pictureBox1.Image = lienzo;
                    break;
                case 5:
                    Hiposila objM = new Hiposila();
                    objM.X0 = PIX;
                    objM.Y0 = PIY;
                    objM.Rad = radio;
                    objM.color0 = Color.Blue;
                    objM.Encender(lienzo);
                    pictureBox1.Image = lienzo;
                    break;
                case 6:
                    MArgarita objH = new MArgarita();
                    objH.X0 = PIX;
                    objH.Y0 = PIY;
                    objH.Rad = radio;
                    objH.color0 = Color.Green;
                    objH.Encender(lienzo);
                    pictureBox1.Image = lienzo;
                    break;
                case 7:
                    contCv = contCv + 1;
                    //label3.Text = contCv.ToString();
                    Circunferencia circu1 = new Circunferencia();
                    circu1.X0 = PIX;
                    circu1.Y0 = PIY;
                    circu1.Rad = 0.06;
                    circu1.color0 = Color.Blue;
                    circu1.Encender(lienzo);
                    pictureBox1.Image = lienzo;

                    circu1.Rad = 0.15;
                    circu1.color0 = Color.Red;
                    circu1.Encender(lienzo);
                    pictureBox1.Image = lienzo;

                    //aumentar la posicion de los vectores 
                    vx[contCv] = PIX;//xo
                    vy[contCv] = PIY;

                    listVx.Add(PIX);
                    listVy.Add(PIY);
                    break;
                case 8:
                    /*int nx, ny;
                Fractal2 mand = new Fractal2();
                Poligono uno = new Poligono();
                uno.x0 = px;
                uno.y0 = py;
                uno.radio = r;
                uno.color0 = Color.White;
                uno.Zoom(lienzo);

                //proceso pantalla
                mx = uno.x0;
                my = uno.y0;
                LMatematica.Pantalla(mx, my, out nx, out ny);
                x = nx;
                y = ny;
                mand.Mandelbrot(x, y, out col);
                lienzo.SetPixel(nx,ny,paleta0[col]);
                //Fractal2 man = new Fractal2();
                //mand.GrafMandelbrot(lienzo, paleta0);
                EspacioT.Image = lienzo;
                */

                    double mx, my, kx, ky, rx, ry, nx, ny;
                    r = 5;
                    mx = qx - r / 2;
                    my = qy + r / 2;
                    nx = qx + r / 2;
                    ny = qy + r / 2;
                    kx = qx - r / 2;
                    ky = qy - r / 4;
                    rx = qx + r / 2;
                    ry = qy - r / 4;
                    Segmento s = new Segmento();
                    s.X0 = mx;
                    s.Y0 = my;
                    s.Xf = nx;
                    s.Yf = ny;
                    s.color0 = Color.White;
                    s.Encender(lienzo);
                    s.X0 = mx;
                    s.Y0 = my;
                    s.Xf = kx;  //mx,my=10 nx,ny=20 kx,ky=2 r=50
                    s.Yf = ky;
                    s.color0 = Color.White;
                    s.Encender(lienzo);
                    s.X0 = kx;
                    s.Y0 = ky;
                    s.Xf = rx;
                    s.Yf = ry;
                    s.color0 = Color.White;
                    s.Encender(lienzo);
                    s.X0 = nx;
                    s.Y0 = ny;
                    s.Xf = rx;
                    s.Yf = ry;
                    s.color0 = Color.White;
                    s.Encender(lienzo);
                    pictureBox1.Image = lienzo;
                    LMatematica.x2 = nx;
                    LMatematica.y2 = ny;
                    LMatematica.x1 = kx;
                    LMatematica.y1 = ky;
                    pictureBox1.Image = lienzo;
                    op = -1;
                    Fractal2 man = new Fractal2();
                    man.GrafMandelbrot(lienzo, paleta0);
                    break;
            }
            }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            int Xpost, Ypost;

            Base Bs = new Base();

            Xpost = e.X;        // obtengo la coordenada x
            Ypost = e.Y;       //obtengo la coordenada y
            Bs.procesoCarta2(Xpost, Ypost, out PIX, out PIY);
        }

 
    }
}
