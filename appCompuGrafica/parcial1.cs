using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appCompuGrafica
{
    public partial class parcial1 : UserControl
    {
        Bitmap bmp = new Bitmap(600, 460);
        public double px, py, qx, qy;

        public Color[] paletaColor1 = new Color[15] {
                    Color.Black,        Color.Navy,         Color.Green,        Color.Aqua,
                    Color.Red,          Color.Maroon,       Color.LightGray,    Color.DarkGray,
                    Color.Blue,         Color.Lime,         Color.Silver,       Color.Teal,
                    Color.Fuchsia,      Color.Yellow,       Color.White };

        public parcial1()
        {
            InitializeComponent();
        }


        private void btnEjes_Click(object sender, EventArgs e)
        {
            cSegmento oSegmento = new cSegmento();
            oSegmento.color = Color.Red;
            oSegmento.x0 = -10;
            oSegmento.y0 = 0;
            oSegmento.Xf = 10;
            oSegmento.Yf = 0;
            oSegmento.encender(bmp);
            pictureBox1.Image = bmp;

            oSegmento.x0 = 0;
            oSegmento.y0 = 8;
            oSegmento.Xf = 0;
            oSegmento.Yf = -8;
            oSegmento.encender(bmp);
            pictureBox1.Image = bmp;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double radio = 0;
            int lados = 2;
            /*while(radio <= 10)
            {
                Poligono oPol = new Poligono();
                oPol.Nl = lados;
                oPol.rd = radio;
                oPol.color = Color.Black;
                //oPol.encenderRadios(bmp);
                oPol.encender(bmp);
                pictureBox1.Image = bmp;
                radio += 1;
                lados++;
            }*/

            cPoligono oPol = new cPoligono();
            oPol.Nl = 5;
            oPol.rd = 4;
            oPol.color = Color.Black;
            //oPol.encenderRadios(bmp);
            oPol.encender(bmp);
            pictureBox1.Image = bmp;
        }

        private void parcial1_Load(object sender, EventArgs e)
        {

        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            double px, pq, qx, qy, rx, ry;
            cSegmento seg = new cSegmento();
            seg.color = Color.Black;
            px = -3; py = -1;
            qx = 2; qy = 6;
            rx = 8; ry = 0;
            seg.x0 = px; seg.y0 = py; seg.Xf = qx; seg.Yf = qy;
            seg.encender(bmp);
            seg.x0 = qx; seg.y0 = qy; seg.Xf = rx; seg.Yf = ry;
            seg.encender(bmp);
            seg.x0 = rx; seg.y0 = ry; seg.Xf = px; seg.Yf = py;
            seg.encender(bmp);

            double m2 = (qy-py)/(qx-px);
            double m = (1/m2)*-1;
            double y1 = m * (-10 - 7);
            seg.color = Color.Blue;
            seg.x0 = rx; seg.y0 = ry; seg.Xf = -10; seg.Yf = y1;
            seg.encender(bmp);

            double xm = 0, ym = 0;
            xm = qx+(rx - qx)/2;
            ym = Math.Abs((ry - qy)/2);
            m2 = (qy - ry) / (qx - rx);
            m = (1 / m2) * -1;
            y1 = m * (-10 - 7);
            seg.color = Color.Red;

            seg.x0 = xm; seg.y0 = ym; seg.Xf = px; seg.Yf = -3;
            seg.encender(bmp);


            seg.x0 = xm; seg.y0 = ym; seg.Xf = px; seg.Yf = -3;
            seg.encender(bmp);

            seg.x0 = rx; seg.y0 = ry;
            seg.Xf = -3; seg.Yf = 4;
            seg.encender(bmp);
            //m2 = ()/()
            pictureBox1.Image = bmp;
        }


        private void btnTaylor_Click(object sender, EventArgs e)
        {
            cVector vec = new cVector();
            double x, dx;
            x = -10;
            dx = 0.001;
            do
            {
                vec.x0 = x;
                //vec.y0 = Math.Exp(2 * x);
                //P(x) = 7x3 + x2 + 8 
                //vec.y0 = 7*Math.Pow(x,3)+ Math.Pow(x, 2) + 8;
                //P(x) = cos(x)
                vec.y0 = 2 * Math.Atan(x);
                vec.color = Color.Blue;
                vec.encender(bmp);
                //vec.y0 = 1 + (2 * x) + (2 * Math.Pow(x, 2) + (4 / 3 * Math.Pow(x, 3)));
                //P(x) =16 + 23(x - 1) + 22(x - 1)2 + 7(x - 1)3
                //if(x!=0)
                //{
                //vec.y0 = 1.57 + (x-1) -0.5 * (x-1) * (x - 1);
                //vec.color = Color.HotPink;
                //vec.encender(bmp);
                vec.y0 = 1.57 + (x - 1) - 0.5 * (x - 1) * (x - 1);
                vec.color = Color.Green;
                vec.encender(bmp);
                //}

                x = x + dx;
            } while (x <= 10);
            pictureBox1.Image = bmp;
        }

        private void btnTaylor2_Click(object sender, EventArgs e)
        {
            cVector vec = new cVector();
            double x, dx;
            x = -10;
            dx = 0.001;
            do
            {
                vec.x0 = x;
                //vec.y0 = Math.Exp(2 * x);
                //P(x) = 7x3 + x2 + 8 
                //vec.y0 = 7*Math.Pow(x,3)+ Math.Pow(x, 2) + 8;
                //P(x) = cos(x)
                vec.y0 = 2 * Math.Sin(x / 1.5);
                vec.color = Color.Blue;
                vec.encender(bmp);
                //vec.y0 = 1 + (2 * x) + (2 * Math.Pow(x, 2) + (4 / 3 * Math.Pow(x, 3)));
                //P(x) =16 + 23(x - 1) + 22(x - 1)2 + 7(x - 1)3
                //if(x!=0)
                //{
                vec.y0 = 0 + 1.333 * x;
                vec.color = Color.HotPink;
                vec.encender(bmp);
                vec.y0 = 0 + 1.333 * x + 0.098 * Math.Pow(x, 3);
                vec.color = Color.Green;
                vec.encender(bmp);
                //}

                x = x + dx;
            } while (x <= 10);
            pictureBox1.Image = bmp;
        }

        public void limpiar_pantalla()
        {
            bmp = null;
            bmp = new Bitmap(600, 460);
            pictureBox1.Image = bmp;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar_pantalla();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            cBase oBase = new cBase();
            oBase.carta(e.X, e.Y, out qx, out qy);
            lblCoordenadas.Text = String.Format("x={0:0.000} ; y={0:0.000}", qx,qy);
        }
    }
}
