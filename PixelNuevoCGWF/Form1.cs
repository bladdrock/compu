using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;
using info.lundin.math;
using Algorithms;


using System.Collections;
using System.Reflection;
using System.Diagnostics;


namespace PixelNuevoCGWF
{
    public partial class Form1 : Form
    {
        Bitmap pantalla = new Bitmap(600, 460);
        public Bitmap lienzo = new Bitmap(600, 500);
        Color Color0;
        public double x0, y0, xf, yf;
        private double rd;
        int i = 1;
        char op;
        public List<double> Vx = new List<double>();
        public List<double> Vy = new List<double>();
        Color[] Paleta0 = new Color[17];
        Color[] Paleta1 = new Color[17];
        Color[] Paleta2 = new Color[17];
        Color[] Paleta3 = new Color[17];
        int SX, SY;
        double X, Y;

        public double[] vx = new double[1000];
        public double[] vy = new double[1000];
        int cont = 0;
        private const int opacity = 127;

        private List<Tuple<PointF, PointF>> _lines = new List<Tuple<PointF, PointF>>();

      

        public Form1()
        {
            InitializeComponent();
        }




        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            string x = e.Location.ToString();
            label1.Text = x;
            Point punto = Control.MousePosition;
            punto = PointToClient(punto);
            this.SX = punto.X;
            this.SY = punto.Y;
            pantalla p = new pantalla();
            p.Pantalla(this.SX, this.SY, out this.X, out this.Y);
            // pantalla = new Bitmap(600, 460);


        }


        //esto spline

        private void button44_Click(object sender, EventArgs e)
        {
            if (cont < 3)
            {
                MessageBox.Show("Se admiten valores mayores a tres puntos.");
            }
            else
            {
                double[] a;
                double[] b;
                double[] c;
                double[] d;
                double sx;
                double t, dt;
                t = Vx[0];
                dt = 0.01;

                Spline s = new Spline();
                do
                {
                    s.coeficientesSpline(cont, vx, vy, out a, out b, out c, out d);
                    s.funcSx(t, cont, vx, vy, b, c, d, out sx);
                    Vector v = new Vector(1, 5, Color.Green, pantalla, pictureBox1);
                    v.X0 = t;
                    v.Y0 = sx;
                    v.Color0 = Color.Green;
                    v.Encender();
                    t = t + dt;
                } while (t <= vx[cont]);
                pictureBox1.Image = pantalla;
            }
        }

        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            pantalla p = new pantalla();
            p.Pantalla(e.X, e.Y, out x0, out y0);
        }









        //esto no 

        private void button12_Click(object sender, EventArgs e)
        {
            Vx.Clear();
            Vy.Clear();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            pantalla = new Bitmap(600, 460);
            pictureBox1.Image = pantalla;
            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 460; j++)
                {
                    pantalla.SetPixel(i, j, Color.Cyan);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //hasta aqui

    

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pantalla p = new pantalla();
            p.Pantalla(e.X, e.Y, out x0, out y0);

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pantalla p1 = new pantalla();
            p1.Pantalla(e.X, e.Y, out xf, out yf);
            //Vx.Add(x0);
            //Vy.Add(y0);
            rd = Math.Sqrt(Math.Pow(xf - x0, 2) + Math.Pow(yf - y0, 2));
          if (radioButton9.Checked || radioButton11.Checked)
            {

                Circunferencia c1 = new Circunferencia(x0, y0, 0.06, Color.Blue, pantalla, pictureBox1);
                Circunferencia c2 = new Circunferencia(x0, y0, 0.15, Color.Red, pantalla, pictureBox1);
                c2.Encender();
                c1.Encender();
                Vx.Add(x0);
                Vy.Add(y0);
                i += 1;
                cont += 1;
                vx[cont] = x0;
                vy[cont] = y0;
            }

        }
    }
}

