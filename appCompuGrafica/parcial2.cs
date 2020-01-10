using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace appCompuGrafica
{
    public partial class parcial2 : UserControl
    {
        double[] vX = new double[10];
        double[] vY = new double[10];
        int cont = 0;

        Bitmap bmp = new Bitmap(600, 460);
        Bitmap bmp2 = new Bitmap(600, 460);
        public int op = 0;
        public int banderadown = -1, flag = 0;
        //Variables de Opciones
        public bool opOrigen;
        public int opGrosor;
        public Color opColor = Color.Black;

        //public string op;
        public double px, py, qx, qy;
        public double px1, py1, qx1, qy1;
        public double px2, py2, qx2, qy2;

        public List<double> puntosx = new List<double>(); // guarda ka coordena de inicio x //desde donde damos clic hasta que lo soltamos
        public List<double> puntosy = new List<double>(); //guarda ka coordena de inicio y //desde donde damos clic hasta hasta que lo soltamos

        public List<double> vx = new List<double>();

        public string[] paleta1 = new string[15] {"Black",      "Navy",     "Green",        "Red",
                                                  "Purple",     "Maroon",   "LightGray",    "DarkGray",
                                                  "Blue",       "Lime",     "Silver",       "Teal",
                                                  "Fuchsia",    "Yellow",   "White"};
        public Color[] paletaColor1 = new Color[16] {
                    Color.Black,     Color.Navy,            Color.Green,        Color.Aqua,
                    Color.Red,       Color.Purple,          Color.Maroon,       Color.LightGray,
                    Color.DarkGray,  Color.Blue,             Color.Lime,         Color.Silver,
                    Color.Teal,      Color.Fuchsia,         Color.Yellow,       Color.White };

        public Color[] paletaAzul = new Color[15];

        public Color[] paletaMadera = new Color[15];
        public Color[] paletaPiedra = new Color[15];

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            cBase oBase = new cBase();
            oBase.carta(e.X, e.Y, out qx, out qy);
            puntosx.Add(qx);
            puntosy.Add(qy);
            cont++;
            vx.Add(qx);
            vy.Add(qy);

            /*if (opOrigen == false)
            {
                //px1 = px; py1 = 0; qx1 = qx; qy1 = 0;
                cCircunferencia punto = new cCircunferencia();
                punto.color = Color.Red;
                punto.x0 = qx;
                punto.y0 = reflexion(qx);
                punto.rd = 0.2;
                punto.encender(bmp);
                pictureBox1.Image = bmp;

                cSegmento tangente = new cSegmento();
                tangente.x0 = -10;
                tangente.Xf = 10;
                //tangente.y0 = punto.y0+(punto.x0/10)*(-10-punto.x0);
                double m = -(punto.x0/10);
                tangente.y0 = (m * -10) + punto.y0 - ( m * punto.x0);
                tangente.Yf = (10 * m) + punto.y0 - (m * punto.x0);
                //tangente.Yf =  10*m + (punto.y0)-(m*-10);
                tangente.color = Color.Green;
                tangente.cortada(bmp,0.002);
                return;
            }*/

            if (opOrigen == false)
            {
                //px1 = px; py1 = 0; qx1 = qx; qy1 = 0;
                cCircunferencia punto = new cCircunferencia();
                punto.color = Color.Red;
                punto.x0 = qx;
                punto.y0 = qy;
                punto.rd = 0.2;
                punto.encender(bmp);
                pictureBox1.Image = bmp;

                return;
            }

            double distancia;//circunferencia
            switch (op)
            {
                case 0:
                    {//segmento
                        /*cSegmento s = new cSegmento();
                        s.color = Color.RoyalBlue;
                        s.x0 = px;
                        s.y0 = py;
                        s.Xf = qx;
                        s.Yf = qy;
                        s.encender(bmp);*/

                        cCuadrado oCuadra = new cCuadrado();
                        oCuadra.color = opColor;
                        oCuadra.x0 = px;
                        oCuadra.Xf = qx;
                        oCuadra.y0 = py;
                        oCuadra.Yf = qy;
                        oCuadra.encender(bmp);
                        bmp2 = bmp;
                        pictureBox1.Image = bmp;
                        //button2_Click(sender, e);
                        break;
                    }
                case 1:
                    {//circunferencia
                        distancia = Math.Sqrt(Math.Pow((qx - px), 2) + Math.Pow((qy - py), 2));
                        cCircunferencia cr = new cCircunferencia();
                        cr.x0 = px;
                        cr.y0 = py;
                        cr.rd = distancia;
                        cr.encender(bmp);

                        pictureBox1.Image = bmp;
                        break;
                    }
            }

            if (flag == 0)
            {
                px1 = px; py1 = py; qx1 = qx; qy1 = qy;
                flag++;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cSegmento sSuma = new cSegmento();
            sSuma.x0 = 0;
            sSuma.y0 = 0;
            sSuma.Xf = qx2 + qx1;
            sSuma.Yf = qy2 + qy1;
            sSuma.color = Color.Red;

            cSegmento sVector1 = new cSegmento();
            sVector1.x0 = sSuma.Xf;
            sVector1.y0 = sSuma.Yf;
            sVector1.Xf = qx2;
            sVector1.Yf = qy2;
            sVector1.color = Color.DarkGreen;
            sVector1.cortada(bmp2,0.005);

            cSegmento sVector2 = new cSegmento();
            sVector2.x0 = sSuma.Xf;
            sVector2.y0 = sSuma.Yf;
            sVector2.Xf = qx1;
            sVector2.Yf = qy1;
            sVector2.color = Color.DarkGreen;
            sVector2.cortada(bmp2,0.005);

            sSuma.encender(bmp2);

            pictureBox1.Image = bmp2;

            cVector vector1 = new cVector();
            vector1.x0 = (qx1 - px1);
            vector1.y0 = (qy1 - py1);

            cVector vector2 = new cVector();
            vector2.x0 = (qx2 - px2);
            vector2.y0 = (qy2 - py2);


            double pp = (vector1.x0*vector2.x0)+(vector1.y0 * vector2.y0);

            if (pp >= -0.5 && pp <= 0.5)
            {
                MessageBox.Show("SI son vectores Ortogonales!");
                toolStripStatusLabel2.Text = "ortogonales!";
            }
            else
                MessageBox.Show("NO son vectores Ortogonales!");

            flag = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cCircunferencia oCir = new cCircunferencia();
            oCir.funcionRaiz(bmp);

            pictureBox1.Image = bmp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            llenar_figuras(6);
            //pictureBox1.Image = bmp;
            
        }

        private void llenar_figuras(int numero)
        {
            int colorT;
            Graphics g = Graphics.FromImage(bmp);
            Brush aBrush = (Brush)Brushes.DarkOrange;
            for (int i = 0; i < 600; i++)
            {
                for (int j = 1; j < 460; j++)
                {
                    switch (numero)
                    {
                        case 0:
                            colorT = (i ^ 2 + j ^ 2) % 15;
                            bmp.SetPixel(i, j, paletaAzul[colorT]);
                            break;
                        case 1:
                            colorT = Math.Abs((int)(Math.Log(i * 3) + (j/2)) % 15);
                            bmp.SetPixel(i, j, paletaAzul[colorT]);
                            break;
                        case 2:
                            colorT = Math.Abs((int)(Math.Cos(i * i) + Math.Cos(j)) % 15)+5;
                            bmp.SetPixel(i, j, paletaAzul[colorT]);
                            break;
                        case 3:
                            colorT = Math.Abs((int)(Math.Cos(i * i * j)));
                            //colorT = (i ^ 2 + 2*i*j+ j ^ 2) % 15;
                            bmp.SetPixel(i, j, paletaAzul[colorT]);
                            break;
                        case 4:
                            colorT = (int)(100 + Math.Cos(i * j) + Math.Sqrt(3 * i)) % 15;
                            bmp.SetPixel(i, j, paletaColor1[colorT]);
                            break;
                        case 5:
                            colorT = Math.Abs((int)(Math.Cos(i*i)  + Math.Cos(j*j)) % 15)+1;
                            bmp.SetPixel(i, j, paletaAzul[colorT]);
                            break;
                        case 6:
                            //Brush aBrush = (Brush)Brushes.DarkOrange;
                            //colorT = Math.Abs((int)(Math.Cos(i * i) + Math.Cos(j * j)) % 15) + 1;
                            //Brush brush = new SolidBrush(paletaAzul[Math.Abs((int)(Math.Cos(i * i*j))) ]);
                            //Graphics g = Graphics.FromImage(bmp);
                            //g.FillRectangle(aBrush, i, j, 1, 1);
                            //colorT = (int)(i * j) % 15;

                            //double temp = (i * j * 5 + 20 * i / j) % 15;
                            //double temp = (i / Math.Cos(i*Math.PI/2)) % 15;
                            double temp = (i + Math.Cos(1 + i * Math.PI)) % 15;
                            colorT = (int)Math.Abs(temp);
                            //if (colorT < 0) colorT = 0;
                            bmp.SetPixel(i, j, paletaMadera[colorT]);
                            //g.FillRectangle(brush, i, j, 1, 1);
                            break;
                        case 7:
                             temp = (i * j*Math.E) % 10;
                            colorT = (int)Math.Abs(temp);
                            //if (colorT < 0) colorT = 0;
                            bmp.SetPixel(i, j, paletaPiedra[colorT]);
                            break;

                        case 8:
                            temp = (-i * j + Math.Sqrt(j*j)) % 10;
                            colorT = (int)Math.Abs(temp);
                            //if (colorT < 0) colorT = 0;
                            bmp.SetPixel(i, j, paletaAzul[colorT]);
                            //g.FillRectangle(brush, i, j, 1, 1);
                            break;
                    }
                    
                    //vector.encender(bmp);
                }
            }
            pictureBox1.Image = bmp;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenar_figuras(comboBox1.SelectedIndex);
            //llenar_paleta(paletaPiedra);
        }

        private void llenar_paleta(Color[] paleta)
        {
            int k = 0;
            foreach (var groupBox in Controls.OfType<GroupBox>())
            {
                foreach (var pictureBox in groupBox.Controls.OfType<PictureBox>())
                {
                    pictureBox.BackColor = paleta[k];
                    k++;
                }
            }
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            using (frmConfiguracion frm = new frmConfiguracion())
            {
                int[] colores = new int [15];
                frm.opColor1.BackColor = opColor;
                for (int i = 0; i <= 14; i++)
                {
                    colores[i] = paletaColor1[i].ToArgb();
                    //frm.colorDialog1.CustomColors = new int[] { paletaColor1[i].ToArgb(), 0xFF0000 };
                    //frm.colorDialog1.CustomColors = paletaColor1[i].ToArgb();
                };

                frm.colorDialog1.CustomColors = colores;

                DialogResult dr = new DialogResult();
                dr = frm.ShowDialog();

                if(dr == DialogResult.OK)
                {
                    opOrigen = frm.opOrigen.Value;
                    opColor = frm.opColor1.BackColor;
                }
                
            }
        }

        private string RevertColor(Color value)
        {
            return System.Drawing.ColorTranslator.ToHtml(value);
        }

        private void btnReflexion_Click(object sender, EventArgs e)
        {
            reflexion();
        }

        private void reflexion()
        {
            double t, dt = 0.002;
            cVector v = new cVector();
            t = -10;
            double Xt, Yt;
            mostrar_ejes();

            for (int i = 0; i <= 100; i++) { 
                do
                {

                v.x0 = t;
                v.y0 = (-(Math.Pow(t, 2)) + 100) / 20;
                //v.y0 = -((Math.Pow(t, 2) - 100) / 40)-7;
                v.color = Color.Blue;
                v.encender(bmp);

                /*cSegmento linea = new cSegmento();
                linea.x0 = t;
                linea.Xf = t;
                linea.y0 = v.y0;
                linea.Yf = -7.33;
                linea.color = Color.Black;
                linea.encender(bmp);*/

                t = t + dt;
                } while (t <= 10);
                t = (-10 + (0.1 * i));
            }
            pictureBox1.Image = bmp;
        }

        private double reflexion(double x)
        {
            double t, dt = 0.002;
            cVector v = new cVector();
            t = -10;

                v.x0 = x;
                v.y0 = (-Math.Pow(x, 2) + 100) / 20;
                v.color = Color.Black;

            return v.y0;
        }

        private void btnBandera_Click(object sender, EventArgs e)
        {
            Color colorT;
            Random rnd = new Random();

            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 460; j++)
                {
                    if (j <= 250)
                        bmp.SetPixel(i, j, Color.Black);
                    else
                        bmp.SetPixel(i, j, Color.FromArgb(0,(int)(1.34*j-335.52), (int)(1.34 * j - 335.52)));
                }
            }

            reflexion();
        }

        private void btnRegresion_Click(object sender, EventArgs e)
        {
            double sX = 0; double sY = 0;
            for (int i=0; i<cont;i++)
            {
                sX += vX[i];
                sY += vY[i];
            }
            cont = cont;
        }

        private void btnBesier_Click(object sender, EventArgs e)
        {

        }


        private void btnPintar_Click(object sender, EventArgs e)
        {
            cCurvasAjuste bezier = new cCurvasAjuste(vx.Count, vx, vy, Color.White);
            bezier.EncenderBezier(bmp);

            Margarita mar = new Margarita();
            mar.x0 = 6;
            mar.xf = 5;
            mar.y0 = 0;
            mar.yf = 5;
            mar.rd = 3;
            mar.color = Color.Orange;
            mar.encender(bmp);
            cSegmento seg = new cSegmento();
            seg.x0=6;
            seg.Xf = 6;
            seg.y0 = -1;
            seg.Yf = -5;
            seg.color = Color.Green;
            seg.encender(bmp);

            mar = new Margarita();
            mar.x0 = -5;
            mar.xf = 5;
            mar.y0 = -2;
            mar.yf = 5;
            mar.rd = 3;
            mar.color = Color.Orange;
            mar.encender(bmp);

            seg = new cSegmento();
            seg.x0 = -5;
            seg.Xf = -4;
            seg.y0 = -3;
            seg.Yf = -6;
            seg.color = Color.Green;
            seg.encender(bmp);

            cCuadrado cua = new cCuadrado();
            cua.x0 = 0;
            cua.Xf = 4;
            cua.y0 = -2;
            cua.Yf = -5;
            cua.color = Color.Black;
            cua.encender(bmp);

            pictureBox1.Image = bmp;
        }

        private void btnLuna_Click(object sender, EventArgs e)
        {
            cFractal f = new cFractal();

            f.luna(bmp);
            pictureBox1.Image = bmp;
        }

        private void btnArbol_Click(object sender, EventArgs e)
        {
            cFractal f = new cFractal();
            f.x0 = -2;
            f.y0 = -2;
            f.alfa = Math.PI/2;
            f.beta = Math.PI / 6;
            f.rd = 5;
            f.color = Color.Red;
            f.Arbol1(bmp);
            pictureBox1.Image = bmp;
        }

        private void btnMandelbrot_Click(object sender, EventArgs e)
        {
            cFractales2 oFractal = new cFractales2();
            oFractal.graficarMandelbrot(bmp);
            pictureBox1.Image = bmp;
        }

        private void btnJulia_Click(object sender, EventArgs e)
        {
            cFractales2 oFractal = new cFractales2();
            oFractal.graficarJulia(bmp);
            pictureBox1.Image = bmp;
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            double Px = -5, Py = -3;
            double Qx = -3, Qy = 3;
            double Rx = 5, Ry = 0;
            cSegmento oTriangulo = new cSegmento();
            oTriangulo.color = Color.Black;
            oTriangulo.x0 = Px;
            oTriangulo.Xf = Qx;
            oTriangulo.y0 = Py;
            oTriangulo.Yf = Qy;
            oTriangulo.encender(bmp);
            oTriangulo.x0 = Qx;
            oTriangulo.Xf = Rx;
            oTriangulo.y0 = Qy;
            oTriangulo.Yf = Ry;
            oTriangulo.encender(bmp);
            oTriangulo.x0 = Rx;
            oTriangulo.Xf = Px;
            oTriangulo.y0 = Ry;
            oTriangulo.Yf = Py;
            oTriangulo.encender(bmp);
            cFractales2 oFractal = new cFractales2();
            oFractal.sierpinski(bmp,Px, Py, Qx, Qy, Rx, Ry);

            pictureBox1.Image = bmp;
        }


        private void btnTriangulos_Click(object sender, EventArgs e)
        {
            double Px = -9, Py = -5;
            double Qx = -7, Qy = -6;
            double Rx = -8, Ry = 5;
            cSegmento oTriangulo = new cSegmento();
            oTriangulo.color = Color.Black;
            oTriangulo.x0 = Px;
            oTriangulo.Xf = Qx;
            oTriangulo.y0 = Py;
            oTriangulo.Yf = Qy;
            oTriangulo.encender(bmp);
            oTriangulo.x0 = Qx;
            oTriangulo.Xf = Rx;
            oTriangulo.y0 = Qy;
            oTriangulo.Yf = Ry;
            oTriangulo.encender(bmp);
            oTriangulo.x0 = Rx;
            oTriangulo.Xf = Px;
            oTriangulo.y0 = Ry;
            oTriangulo.Yf = Py;
            oTriangulo.encender(bmp);
            cFractales2 oFractal = new cFractales2();
            oFractal.sierpinski(bmp,Px, Py, Qx, Qy, Rx, Ry);

            Px = 7; Py = 5;
            Qx = -4; Qy = 6;
            Rx = 5; Ry = 2;

            oTriangulo.color = Color.Black;
            oTriangulo.x0 = Px;
            oTriangulo.Xf = Qx;
            oTriangulo.y0 = Py;
            oTriangulo.Yf = Qy;
            oTriangulo.encender(bmp);
            oTriangulo.x0 = Qx;
            oTriangulo.Xf = Rx;
            oTriangulo.y0 = Qy;
            oTriangulo.Yf = Ry;
            oTriangulo.encender(bmp);
            oTriangulo.x0 = Rx;
            oTriangulo.Xf = Px;
            oTriangulo.y0 = Ry;
            oTriangulo.Yf = Py;
            oTriangulo.encender(bmp);
            oFractal.sierpinski(bmp,Px, Py, Qx, Qy, Rx, Ry);
            pictureBox1.Image = bmp;
        }

        private void btnRotacion_Click(object sender, EventArgs e)
        {
            //cCircunferencia oCirculo = new cCircunferencia();
            cLazo oLazo = new cLazo();
            double w = 0;
            oLazo.x0 = 4;
            oLazo.y0 = -5;
            oLazo.rd = 1.5;
            oLazo.color = Color.DarkGreen;
            do
            {
                cSegmento oTriangulo = new cSegmento();
                oTriangulo.color = Color.Black;
                oTriangulo.x0 = -8;
                oTriangulo.Xf = 8;
                oTriangulo.y0 = -7;
                oTriangulo.Yf = -7;
                oTriangulo.color = Color.Red;
                oTriangulo.encender(bmp);

                oLazo.aR = w;
                w += 0.2;
                oLazo.x0 -= 0.2;
                oLazo.rotar(bmp);
                pictureBox1.Refresh();
                Thread.Sleep(100);
                oLazo.Apagar(bmp);
                bmp = new Bitmap(600, 460);
                pictureBox1.Image = bmp;
            }
            while (w <= 8);

            

            pictureBox1.Image = bmp;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            cSegmento oSeg = new cSegmento();
            oSeg.x0 = -4;
            oSeg.Xf = 4;
            oSeg.y0 = 6;
            oSeg.Yf = 6;
            oSeg.color = Color.Red;
            oSeg.encender(bmp);
            //pictureBox1.Image = bmp;

            cFractales2 oFractal = new cFractales2();
            pictureBox1.Image = bmp;
            Cantor(oSeg);
        }

        private void Cantor(cSegmento s)
        {
            if (s.Yf <= -5)
                return;
            s.Yf -= 2;

            double d = (s.Xf - s.x0) / 3;
            if (d <= 0.01) return;

            cSegmento s1 = new cSegmento();
            s1.x0 = s.x0;
            s1.y0 = s.Yf;
            s1.Xf = s.x0 + d;
            s1.Yf = s.Yf;
            s1.color = Color.Black;
            s1.encender(bmp);

            cSegmento s2 = new cSegmento();
            s2.x0 = s.Xf - d;
            s2.y0 = s.Yf;
            s2.Xf = s.Xf;
            s2.Yf = s.Yf;
            s2.color = Color.Black;
            s2.encender(bmp);
            Thread.Sleep(10);
            pictureBox1.Refresh();
            Cantor(s1);
            Cantor(s2);
        }

        private void btn3d_Click(object sender, EventArgs e)
        {
            cVector3d v3D = new cVector3d();
            v3D.color = Color.Black;
            double h=0;
            //do
            //{
            //    v3D.x0 = 2 * Math.Cos(h);
            //    v3D.y0 = 3 + 2 * Math.Sin(h);
            //    v3D.z0 = h / 5;
            //    v3D.encender(bmp);
            //    h += 0.01;
            //}
            //while (h <= 18);
            //pictureBox1.Image = bmp;

            //h = 0;
            //do
            //{
            //    v3D.x0 = h/5;
            //    v3D.y0 = 3 + 2 * Math.Sin(h);
            //    v3D.z0 = 2 * Math.Cos(h);
            //    v3D.encender(bmp);
            //    h += 0.01;
            //}
            //while (h <= 18);

            //do
            //{
            //    v3D.x0 = 0;
            //    v3D.y0 = 3 + 2 * Math.Sin(h);
            //    v3D.z0 = 2 * Math.Cos(h);
            //    v3D.encender(bmp);
            //    h += 0.01;
            //}
            //while (h <= Math.PI*2);

            cSegmento3d oSeg3d = new cSegmento3d();
            oSeg3d.color = Color.DarkGreen;
            oSeg3d.x0 = 0;
            oSeg3d.y0 = -7;
            oSeg3d.z0 = 0;
            oSeg3d.xf = 0;
            oSeg3d.yf = 7;
            oSeg3d.zf = 0;
            oSeg3d.encender(bmp);
            oSeg3d.y0 = 0;
            oSeg3d.yf = 0;
            oSeg3d.z0 = -10;
            oSeg3d.zf = 10;
            oSeg3d.encender(bmp);
            oSeg3d.y0 = 0;
            oSeg3d.yf = 0;
            oSeg3d.x0 = -10;
            oSeg3d.xf = 10;
            oSeg3d.z0 = -15;
            oSeg3d.zf = 15;
            oSeg3d.encender(bmp);

            //do
            //{
            //    v3D.color = Color.Blue;
            //    v3D.x0 = 0;
            //    v3D.y0 = 3 + (2 * Math.Pow(Math.Cos(h), 3));
            //    v3D.z0 = 3 + (2 * Math.Pow(Math.Sin(h), 3));
            //    v3D.encender(bmp);
            //    h += 0.01;
            //}
            //while (h <= Math.PI * 2);

            //h = 0;
            //do
            //{
            //    v3D.color = Color.Green;
            //    v3D.x0 = -3 + ((3 * Math.Cos(6 * h) * Math.Cos(h)) / 2);
            //    v3D.y0 = -3;
            //    v3D.z0 = 0 + ((3 * Math.Cos(6 * h) * Math.Sin(h)) / 2);
            //    v3D.encender(bmp);
            //    h += 0.01;
            //}
            //while (h <= Math.PI * 2);

            //h = 0;
            //do
            //{
            //    v3D.color = Color.OrangeRed;
            //    v3D.x0 = 4 + 2 * Math.Sin(2 * h);
            //    v3D.y0 = 3 + 2 * Math.Cos(3 * h);
            //    v3D.z0 = 0;
            //    v3D.encender(bmp);
            //    h += 0.01;
            //}
            //while (h <= Math.PI * 2);

            pictureBox1.Image = bmp;
        }

        private void btnPlano3d_Click(object sender, EventArgs e)
        {
            cSegmento3d oSeg3d = new cSegmento3d();
            oSeg3d.color = Color.Fuchsia;
            oSeg3d.x0 = 0;
            oSeg3d.y0 = 0;
            oSeg3d.z0 = 0;
            oSeg3d.xf = 0;
            oSeg3d.yf = 4;
            oSeg3d.zf = 0;
            oSeg3d.encender(bmp);
            oSeg3d.xf = 4;
            oSeg3d.yf = 0;
            oSeg3d.encender(bmp);
            oSeg3d.zf = 4;
            oSeg3d.xf = 0;
            oSeg3d.encender(bmp);

            oSeg3d.x0 = 0;
            oSeg3d.y0 = 0;
            oSeg3d.z0 = 4;
            oSeg3d.xf = 0;
            oSeg3d.yf = 4;
            oSeg3d.zf = 4;
            oSeg3d.encender(bmp);

            oSeg3d.x0 = 0;
            oSeg3d.y0 = 0;
            oSeg3d.z0 = 4;
            oSeg3d.xf = 4;
            oSeg3d.yf = 0;
            oSeg3d.zf = 4;
            oSeg3d.encender(bmp);

            oSeg3d.x0 = 4;
            oSeg3d.y0 = 0;
            oSeg3d.z0 = 0;
            oSeg3d.xf = 4;
            oSeg3d.yf = 0;
            oSeg3d.zf = 4;
            oSeg3d.encender(bmp);

            oSeg3d.x0 = 0;
            oSeg3d.y0 = 4;
            oSeg3d.z0 = 0;
            oSeg3d.xf = 0;
            oSeg3d.yf = 4;
            oSeg3d.zf = 4;
            oSeg3d.encender(bmp);

            oSeg3d.x0 = 0;
            oSeg3d.y0 = 4;
            oSeg3d.z0 = 0;
            oSeg3d.xf = 4;
            oSeg3d.yf = 4;
            oSeg3d.zf = 0;
            oSeg3d.encender(bmp);

            oSeg3d.color = Color.Blue;
            oSeg3d.x0 = 4;
            oSeg3d.y0 = 0;
            oSeg3d.z0 = 0;
            oSeg3d.xf = 4;
            oSeg3d.yf = 4;
            oSeg3d.zf = 0;
            oSeg3d.encender(bmp);

            oSeg3d.x0 = 4;
            oSeg3d.y0 = 4;
            oSeg3d.z0 = 0;
            oSeg3d.xf = 4;
            oSeg3d.yf = 4;
            oSeg3d.zf = 4;
            oSeg3d.encender(bmp);

            oSeg3d.y0 = 0;
            oSeg3d.z0 = 4;
            oSeg3d.encender(bmp);

            oSeg3d.x0 = 0;
            oSeg3d.y0 = 4;
            oSeg3d.z0 = 4;
            oSeg3d.encender(bmp);

            pictureBox1.Image = bmp;
        }

        private void btnEspiral_Click(object sender, EventArgs e)
        {
            cEspiral oEspiral = new cEspiral();
            oEspiral.color = Color.MidnightBlue;
            oEspiral.x0 = 3;
            oEspiral.y0 = -2;
            oEspiral.z0 = -1;
            oEspiral.Altura = 5;

            double w = 0;
            oEspiral.eje0 = 0;
            do
            {
                oEspiral.alfa = w;
                oEspiral.color = Color.Red;
                oEspiral.encender(bmp);
                pictureBox1.Image = bmp;
                Thread.Sleep(50);
                pictureBox1.Refresh();
                oEspiral.Apagar(bmp);
                w += 0.3;
            } while (w <= 2 * Math.PI);

            w = 0;
            oEspiral.eje0 = 1;
            do
            {
                oEspiral.alfa = w;
                oEspiral.color = Color.Red;
                oEspiral.encender(bmp);
                pictureBox1.Image = bmp;
                Thread.Sleep(50);
                pictureBox1.Refresh();
                oEspiral.Apagar(bmp);
                w += 0.3;
            } while (w <= 2 * Math.PI);

            w = 0;
            oEspiral.eje0 = 2;
            do
            {
                oEspiral.alfa = w;
                oEspiral.color = Color.Red;
                oEspiral.encender(bmp);
                pictureBox1.Image = bmp;
                Thread.Sleep(50);
                pictureBox1.Refresh();
                oEspiral.Apagar(bmp);
                w += 0.3;
            } while (w <= 2 * Math.PI);

            //cSegmento s = new cSegmento();
            //s.x0 = 0;
            //s.Xf = 3;
            //s.y0 = 0;
            //s.Yf = 4;
            //for (double i= 0; i <= 9; i+=0.1)
            //{
            //    s.x0 += i;
            //    s.Xf += i;
            //    s.color = Color.Blue;
            //    s.encender(bmp);
            //    pictureBox1.Image = bmp;
            //    Thread.Sleep(50);
            //    pictureBox1.Refresh();
            //    s.Apagar(bmp);
            //}

        }

        private void btnSuperficie_Click(object sender, EventArgs e)
        {
            cEspiral espiral = new cEspiral();
            espiral.x0 = 0;
            espiral.y0 = 0;
            espiral.z0 = 0;
            espiral.alfa = -90;
            espiral.Altura = 2;
            espiral.color = Color.Red;
            espiral.encender(bmp);
            pictureBox1.Image = bmp;
        }

        private void parcial2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                pictureBox1.BackColor = paletaAzul[i];
                MessageBox.Show("Color: R=" + paletaAzul[i].R + ", G=" + paletaAzul[i].G + ", B=" + paletaAzul[i].B);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cLazo lazo = new cLazo();
            lazo.color = Color.RoyalBlue;
            lazo.rd = 1.2;
            lazo.x0 = -8;
            lazo.y0 = 0;
            for (double i = -8; i <= 8; i += 0.5)
            {
                lazo.x0 = i;
                lazo.y0 = Math.Sin(i);
                lazo.color = Color.RoyalBlue;
                lazo.encender(bmp);
                pictureBox1.Image = bmp;
                Thread.Sleep(20);
                pictureBox1.Refresh();
                lazo.Apagar(bmp);
            }
            for (double i = 8; i >= -8; i -= 0.5)
            {
                lazo.x0 = i;
                lazo.y0 = Math.Sin(i);
                lazo.color = Color.RoyalBlue;
                lazo.encender(bmp);
                pictureBox1.Image = bmp;
                Thread.Sleep(20);
                pictureBox1.Refresh();
                lazo.Apagar(bmp);
            }


        }

        private void moverLazo(double xIni, double xFin, double yIni, double yFin, double velocidad)
        {
            cLazo lazo = new cLazo();
            lazo.color = Color.RoyalBlue;
            lazo.rd = 1.2;
            lazo.x0 = -8;
            lazo.y0 = 0;
            for (double i = xIni; i <= xFin; i += velocidad)
            {
                lazo.x0 = i;
                lazo.color = Color.RoyalBlue;
                lazo.encender(bmp);
                pictureBox1.Image = bmp;
                Thread.Sleep(20);
                pictureBox1.Refresh();
                lazo.Apagar(bmp);
            }
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
                vec.y0 = Math.Atan(x/2);
                vec.color = Color.Blue;
                vec.encender(bmp2);
                //vec.y0 = 1 + (2 * x) + (2 * Math.Pow(x, 2) + (4 / 3 * Math.Pow(x, 3)));
                //P(x) =16 + 23(x - 1) + 22(x - 1)2 + 7(x - 1)3
                //if(x!=0)
                //{
                    vec.y0 = 2 / ((x*x)+4) ;
                    vec.color = Color.HotPink;
                    vec.encender(bmp2);
                    vec.y0 = (-4*x) / (Math.Pow((x*x) + 4,2)) ;
                    vec.color = Color.Fuchsia;
                    vec.encender(bmp2);
                    vec.y0 = (4*((3*x*x)-4))/Math.Pow((x*x)+4,3);
                    vec.color = Color.Red;
                    vec.encender(bmp2);
                //}
                    
                x = x + dx;
            } while (x <= 10);
            pictureBox1.Image = bmp2;
        }

        private void cmbCurvas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCurvas.SelectedItem.ToString() == "Poligonal")
            {
                cCurvasAjuste lagrange = new cCurvasAjuste(puntosx.Count, puntosx, puntosy, Color.Red);
                lagrange.encenderPoligonal(bmp);

                List<double> Px = new List<double>();
                List<double> Py = new List<double>();
                ordenarPuntos(out Px, out Py);
                lagrange = new cCurvasAjuste(puntosx.Count, Px, Py, Color.Blue);
                lagrange.encenderPoligonal(bmp);
            }
            else if (cmbCurvas.SelectedItem.ToString() == "Lagrange")
            {
                List<double> Px = new List<double>();
                List<double> Py = new List<double>();
                ordenarPuntos(out Px, out Py);
                cCurvasAjuste lagrange = new cCurvasAjuste(puntosx.Count, Px, Py, Color.Blue);
                lagrange.encenderLagrange(bmp);

                lagrange = new cCurvasAjuste(vx.Count, vx, vy, Color.Red);
                lagrange.encenderLagrange(bmp);

            }
            else if (cmbCurvas.SelectedItem.ToString() == "Besier")
            {
                cCurvasAjuste bezier = new cCurvasAjuste(puntosx.Count, puntosx, puntosy, Color.Red);
                bezier.EncenderBezier(bmp);

                List<double> Px = new List<double>();
                List<double> Py = new List<double>();
                ordenarPuntos(out Px, out Py);
                bezier = new cCurvasAjuste(puntosx.Count, puntosx, puntosy, Color.Blue);
                bezier.EncenderBezier(bmp);
            }
            else if (cmbCurvas.SelectedItem.ToString() == "Spline")
            {

            }

            else if (cmbCurvas.SelectedItem.ToString() == "Regresion")
            {

                List<double> Px = new List<double>();
                List<double> Py = new List<double>();
                cCurvasAjuste regresion = new cCurvasAjuste(vx.Count, vx, vy, Color.Blue);
                ordenarPuntos(out vx, out vy);
                regresion.regresionLineal(bmp);
            }


            pictureBox1.Image = bmp2;
        }

        private void ordenarPuntos(out List<double> Px, out List<double> Py)
        {
            Px = puntosx.ToList();
            Py = vy.ToList();
            double x = 0, y = 0;
            for (int i = 0; i < cont - 1; i++)
            {
                for (int j = i + 1; j < cont; j++)
                {
                    if (Px[i] > Px[j])
                    {
                        x = Px[i];
                        y = Py[i];
                        Px[i] = Px[j];
                        Py[i] = Py[j];
                        Px[j] = x;
                        Py[j] = y;
                    }
                }
            }
        }

        private void btnReloj_Click(object sender, EventArgs e)
        {
            cCircunferencia circulo = new cCircunferencia();
            cSegmento horero = new cSegmento();
            cSegmento minutero = new cSegmento();
            circulo.x0 = minutero.x0 = 3;
            circulo.y0 = minutero.y0 = 1;
            circulo.rd = 3;
            circulo.color = Color.DarkBlue;
            circulo.encender(bmp);
            minutero.color = Color.OrangeRed;
            const double Pi= Math.PI;
            for(double i= Pi/2; i<= 2*Pi+ Pi/2; i+=0.1)
            {
                minutero.Xf = minutero.x0 + 2.6 * Math.Cos(i);
                minutero.Yf = minutero.y0 + 2.6 * Math.Sin(i);
                minutero.color = Color.OrangeRed;
                minutero.encender(bmp);
                pictureBox1.Image = bmp;
                Thread.Sleep(20);
                pictureBox1.Refresh();
                minutero.Apagar(bmp);
            }
            minutero.Xf = minutero.x0 + 2.6 * Math.Cos(2 * Pi + Pi / 2);
            minutero.Yf = minutero.y0 + 2.6 * Math.Sin(2 * Pi + Pi / 2);
            minutero.color = Color.OrangeRed;
            minutero.encender(bmp);
            pictureBox1.Image = bmp;
            //pictureBox1.Image = bmp;
        }

        //Form Principal
        private void btnTangente_Click(object sender, EventArgs e)
        {
            //Crear objeto oCir que contiene elmétodo animarTangente()
            cCircunferencia oCir = new cCircunferencia();
            //Ejecutar un bucle en donde vamos a hallar los puntos de tangencia con la funcion
            for(double i=-10; i<=10; i+=0.4)
            {
                oCir.color = Color.OrangeRed;
                //Establecer en la variable bmp la grafica de la tangente en en punto i
                oCir.animarTangente(bmp,i);
                pictureBox1.Image = bmp;
                //Pausa
                Thread.Sleep(20);
                pictureBox1.Refresh();
                //Apagar (Eliminar) la tangente trazada y actualizar bmp
                oCir.color = Color.White;
                oCir.animarTangente(bmp,i);
            }
            
        }

        private void btnPaisajef_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 600; i++)
            {
                for (int j = 300; j < 460; j++)
                {
                    bmp.SetPixel(i, j, Color.FromArgb(0, (int)(1.275 * (j - 300)), (int)(0.25 * (500 - j) + 1.275 * (j - 300))));
                }
            }

            for (int i = 0; i <= 599; i++)
            {
                for (int j = 0; j <= 299; j++)
                {
                    bmp.SetPixel(i, j, Color.FromArgb(0, 0, 50));
                }
            }

            //Luna
            cCircunferencia c = new cCircunferencia();
            c.x0 = 5;
            c.y0 = 5;
            double x = 0;
            do
            {
                c.rd = x;
                c.color = Color.White;
                c.encender(bmp);
                x = x + 0.03;
            } while (x <= 1.4);
            pictureBox1.Image = bmp;

            // Montana 
            cVector v = new cVector();
            x = -10;
            double var = 8;
            for (int i = 0; i <= 124; i++)
            {
                do
                {
                    v.x0 = x;
                    v.y0 = 2.5 * Math.Exp(-Math.Pow((x / 5), 2)) - var;
                    v.color = Color.Black;
                    v.encender(bmp);
                    x = x + 0.02;
                } while (x <= 10);
                x = -10;
                var = var + 0.02;
            }
            pictureBox1.Image = bmp;

            ///Destello Luna
            c.x0 = 5;
            c.y0 = 5;
            x = 1.4;
            do
            {
                c.rd = x;
                c.color = Color.FromArgb((int)(200 * (2.4 - x)), (int)(200 * (2.4 - x)), (int)(200 * (2.4 - x) + 50 * (x - 1.4)));
                c.encender(bmp);
                x = x + 0.03;
            } while (x <= 2.4);
            pictureBox1.Image = bmp;

            // Montana 
            v = new cVector();
            x = -10;
            double dt = 8;
            for (int i = 0; i <= 124; i++)
            {
                do
                {
                    v.x0 = x;
                    v.y0 = 2.5 * Math.Exp(-Math.Pow((x / 5), 2)) - var;
                    v.color = Color.Black;
                    v.encender(bmp);
                    x = x + 0.02;
                } while (x <= 10);
                x = -10;
                dt = dt + 0.02;
            }
            pictureBox1.Image = bmp;

            // Focos
            cCircunferencia c1 = new cCircunferencia();
            c1.x0 = -3.9;
            c1.y0 = 4;
            x = 0;
            do
            {
                c1.rd = x;
                c1.color = Color.Red;
                c1.encender(bmp);
                x = x + 0.03;
            } while (x <= 0.14);
            pictureBox1.Image = bmp;

            c1.x0 = -2.13;
            c1.y0 = 4;
            x = 0;
            do
            {
                c1.rd = x;
                c1.color = Color.Red;
                c1.encender(bmp);
                x = x + 0.03;
            } while (x <= 0.14);
            pictureBox1.Image = bmp;

            c1.x0 = -4.45;
            c1.y0 = 3.18;
            x = 0;
            do
            {
                c1.rd = x;
                c1.color = Color.Yellow;
                c1.encender(bmp);
                x = x + 0.03;
            } while (x <= 0.14);
            pictureBox1.Image = bmp;

            c1.x0 = -1.5;
            c1.y0 = 3.18;
            x = 0;
            do
            {
                c1.rd = x;
                c1.color = Color.Yellow;
                c1.encender(bmp);
                x = x + 0.03;
            } while (x <= 0.14);
            pictureBox1.Image = bmp;

            c1.x0 = -5.37;
            c1.y0 = 2;
            x = 0;
            do
            {
                c1.rd = x;
                c1.color = Color.Blue;
                c1.encender(bmp);
                x = x + 0.03;
            } while (x <= 0.14);
            pictureBox1.Image = bmp;

            c1.x0 = -0.67;
            c1.y0 = 2;
            x = 0;
            do
            {
                c1.rd = x;
                c1.color = Color.Blue;
                c1.encender(bmp);
                x = x + 0.03;
            } while (x <= 0.14);
            pictureBox1.Image = bmp;

            c1.x0 = -6.7;
            c1.y0 = 0.26;
            x = 0;
            do
            {
                c1.rd = x;
                c1.color = Color.Green;
                c1.encender(bmp);
                x = x + 0.03;
            } while (x <= 0.14);
            pictureBox1.Image = bmp;

            c1.x0 = 0.64;
            c1.y0 = 0.26;
            x = 0;
            do
            {
                c1.rd = x;
                c1.color = Color.Green;
                c1.encender(bmp);
                x = x + 0.03;
            } while (x <= 0.14);
            pictureBox1.Image = bmp;

            c1.x0 = -8.68;
            c1.y0 = -2.42;
            x = 0;
            do
            {
                c1.rd = x;
                c1.color = Color.Red;
                c1.encender(bmp);
                x = x + 0.03;
            } while (x <= 0.14);
            pictureBox1.Image = bmp;

            c1.x0 = 2.7;
            c1.y0 = -2.42;
            x = 0;
            do
            {
                c1.rd = x;
                c1.color = Color.Red;
                c1.encender(bmp);
                x = x + 0.03;
            } while (x <= 0.14);
            pictureBox1.Image = bmp;

            c1.x0 = -7.23;
            c1.y0 = -3.49;
            x = 0;
            do
            {
                c1.rd = x;
                c1.color = Color.Yellow;
                c1.encender(bmp);
                x = x + 0.03;
            } while (x <= 0.14);
            pictureBox1.Image = bmp;

            c1.x0 = 1.2;
            c1.y0 = -3.49;
            x = 0;
            do
            {
                c1.rd = x;
                c1.color = Color.Yellow;
                c1.encender(bmp);
                x = x + 0.03;
            } while (x <= 0.14);
            pictureBox1.Image = bmp;

            c1.x0 = -6.34;
            c1.y0 = -4.18;
            x = 0;
            do
            {
                c1.rd = x;
                c1.color = Color.Blue;
                c1.encender(bmp);
                x = x + 0.03;
            } while (x <= 0.14);
            pictureBox1.Image = bmp;

            c1.x0 = 0.33;
            c1.y0 = -4.18;
            x = 0;
            do
            {
                c1.rd = x;
                c1.color = Color.Blue;
                c1.encender(bmp);
                x = x + 0.03;
            } while (x <= 0.14);
            pictureBox1.Image = bmp;

            c1.x0 = -5;
            c1.y0 = -5.14;
            x = 0;
            do
            {
                c1.rd = x;
                c1.color = Color.Green;
                c1.encender(bmp);
                x = x + 0.03;
            } while (x <= 0.14);
            pictureBox1.Image = bmp;

            c1.x0 = -1;
            c1.y0 = -5.14;
            x = 0;
            do
            {
                c1.rd = x;
                c1.color = Color.Green;
                c1.encender(bmp);
                x = x + 0.03;
            } while (x <= 0.14);
            pictureBox1.Image = bmp;


            //Arboles
            cFractal f = new cFractal();
            f.x0 = -3;
            f.y0 = -6.24;
            f.radioF = 4;
            f.alfa = Math.PI / 2;
            f.beta = Math.PI / 2;
            f.color = Color.White;
            f.arbol(bmp);
            pictureBox1.Image = bmp;


            //Dibujar casa
            cCuadrado cuadro = new cCuadrado();
            cuadro.x0 = -9;
            cuadro.y0 = 1;
            cuadro.x1 = -4;
            cuadro.y1 = 1;
            cuadro.x2 = -9;
            cuadro.y2 = -4;
            cuadro.x3 = -4;
            cuadro.y3 = -4;
            cuadro.color = Color.Yellow;
            cuadro.rellenarCuadrilatero(bmp,Color.DarkSlateGray);
            pictureBox1.Image = bmp;

            // Arboles Izquierda
            f.x0 = -8;
            f.y0 = -7.8;
            f.radioF = 1.5;
            f.alfa = Math.PI / 2;
            f.beta = Math.PI / 4;
            f.color = Color.White;
            f.arbol(bmp);
            pictureBox1.Image = bmp;

            f.x0 = -4.2;
            f.y0 = -6.7;
            f.radioF = 1.8;
            f.alfa = Math.PI / 2;
            f.beta = Math.PI / 5;
            f.color = Color.White;
            f.arbol(bmp);
            pictureBox1.Image = bmp;

            // Arboles Derecha
            f.x0 = 8;
            f.y0 = -7.8;
            f.radioF = 2;
            f.alfa = Math.PI / 2;
            f.beta = Math.PI / 5;
            f.color = Color.White;
            f.arbol(bmp);
            pictureBox1.Image = bmp;

            f.x0 = 4;
            f.y0 = -6.7;
            f.radioF = 1.8;
            f.alfa = Math.PI / 2;
            f.beta = Math.PI / 5;
            f.color = Color.White;
            f.arbol(bmp);
            pictureBox1.Image = bmp;

            f.x0 = 2;
            f.y0 = -5.86;
            f.radioF = 0.8;
            f.alfa = Math.PI / 2;
            f.beta = Math.PI / 3;
            f.color = Color.White;
            f.arbol(bmp);
            pictureBox1.Image = bmp;

            f.x0 = 5.93;
            f.y0 = -7.39;
            f.radioF = 1;
            f.alfa = Math.PI / 2;
            f.beta = Math.PI / 4;
            f.color = Color.White;
            f.arbol(bmp);
            pictureBox1.Image = bmp;

            f.x0 = 0;
            f.y0 = -5.5;
            f.radioF = 0.3;
            f.alfa = Math.PI / 2;
            f.beta = Math.PI / 3;
            f.color = Color.White;
            f.arbol(bmp);
            pictureBox1.Image = bmp;

            // Estrellas
            f.x0 = -8.53;
            f.y0 = 0.64;
            f.radioF = 0.2;
            f.alfa = Math.PI / 5;
            f.color = Color.White;
            f.Estrella(bmp);
            pictureBox1.Image = bmp;

            f.x0 = -6;
            f.y0 = 7;
            f.rd = 0.2;
            f.alfa = Math.PI / 5;
            f.color = Color.White;
            f.Estrella(bmp);
            pictureBox1.Image = bmp;

            f.x0 = -9;
            f.y0 = 5.2;
            f.rd = 0.2;
            f.alfa = Math.PI / 5;
            f.color = Color.White;
            f.Estrella(bmp);
            pictureBox1.Image = bmp;

            f.x0 = 9;
            f.y0 = 7;
            f.rd = 0.2;
            f.alfa = Math.PI / 5;
            f.color = Color.White;
            f.Estrella(bmp);
            pictureBox1.Image = bmp;

            f.x0 = 9.4;
            f.y0 = 5.4;
            f.rd = 0.2;
            f.alfa = Math.PI / 5;
            f.color = Color.White;
            f.Estrella(bmp);
            pictureBox1.Image = bmp;

            f.x0 = 8;
            f.y0 = 3.8;
            f.rd = 0.2;
            f.alfa = Math.PI / 5;
            f.color = Color.White;
            f.Estrella(bmp);
            pictureBox1.Image = bmp;

            f.x0 = -3.5;
            f.y0 = 6;
            f.rd = 0.2;
            f.alfa = Math.PI / 5;
            f.color = Color.White;
            f.Estrella(bmp);
            pictureBox1.Image = bmp;

            f.x0 = 0;
            f.y0 = 7.5;
            f.rd = 0.2;
            f.alfa = Math.PI / 5;
            f.color = Color.White;
            f.Estrella(bmp);
            pictureBox1.Image = bmp;

            f.x0 = -7;
            f.y0 = 4;
            f.rd = 0.2;
            f.alfa = Math.PI / 5;
            f.color = Color.White;
            f.Estrella(bmp);
            pictureBox1.Image = bmp;

            f.x0 = -1;
            f.y0 = 5;
            f.rd = 0.2;
            f.alfa = Math.PI / 5;
            f.color = Color.White;
            f.Estrella(bmp);
            pictureBox1.Image = bmp;

            f.x0 = 1.2;
            f.y0 = 4.4;
            f.rd = 0.2;
            f.alfa = Math.PI / 5;
            f.color = Color.White;
            f.Estrella(bmp);
            pictureBox1.Image = bmp;

            f.x0 = 2.5;
            f.y0 = 5.25;
            f.rd = 0.2;
            f.alfa = Math.PI / 5;
            f.color = Color.White;
            f.Estrella(bmp);
            pictureBox1.Image = bmp;

            cVector v2 = new cVector();
            double w = Math.PI / 3;
            do
            {
                v2.x0 = 0.8 + 3 * Math.Cos(w);
                v2.y0 = 2.8 + 3 * Math.Sin(w);
                v2.color = Color.White;
                v2.encender(bmp);
                w = w + 0.01;
            } while (w <= Math.PI / 2);
            pictureBox1.Image = bmp;

            //f.x0 = 1.8;
            //f.y0 = 6.4;
            //f.radioF = 0.2;
            //f.alfa = Math.PI / 5;
            //f.color = Color.White;
            //f.Estrella(bmp);
            //pictureBox1.Image = bmp;

            //Vector v1 = new Vector();
            //w = Math.PI / 3;
            //do
            //{
            //    v1.x0 = 0.2 + 3 * Math.Cos(w);
            //    v1.y0 = 3.8 + 3 * Math.Sin(w);
            //    v1.color = Color.White;
            //    v1.Encender(bmp);
            //    w = w + 0.01;
            //} while (w <= Math.PI / 2);
            //pictureBox1.Image = bmp;

            //// Aves
            //f.x0 = 8.97;
            //f.y0 = -0.67;
            //f.rd = 0.2;
            //f.color = Color.White;
            //f.aves(bmp);
            //pictureBox1.Image = bmp;

            //f.x0 = 5.2;
            //f.y0 = 1.6;
            //f.rd = 0.2;
            //f.color = Color.White;
            //f.aves(bmp);
            //pictureBox1.Image = bmp;

            //f.x0 = 8.4;
            //f.y0 = 1;
            //f.rd = 0.5;
            //f.color = Color.White;
            //f.aves(bmp);
            //pictureBox1.Image = bmp;

            //f.x0 = 2.4;
            //f.y0 = 2;
            //f.rd = 0.5;
            //f.color = Color.White;
            //f.aves(bmp);
            //pictureBox1.Image = bmp;

            //f.x0 = 5;
            //f.y0 = -0.5;
            //f.rd = 0.6;
            //f.color = Color.White;
            //f.aves(bmp);
            //pictureBox1.Image = bmp;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            cCuadrado cuadro = new cCuadrado();
            cuadro.x0 = -7;
            cuadro.y0 = 2;
            cuadro.x1 = -2;
            cuadro.y1 = 2;
            cuadro.x2 = -7;
            cuadro.y2 = -4;
            cuadro.x3 = -2;
            cuadro.y3 = -4;
            cuadro.color = Color.Yellow;
            cuadro.rellenarCuadrilatero(bmp, Color.DarkSlateBlue);
            pictureBox1.Image = bmp;
        }

        private void btnCantor_Click(object sender, EventArgs e)
        {
            cFractal fractal = new cFractal();

            cSegmento figura = new cSegmento();
            figura.x0 = -8;
            figura.Xf = 8;
            figura.y0 = 6.5;
            figura.Yf = 6.5;
            figura.color = Color.White;
            figura.encender(bmp);
            fractal.Cantor3(figura, bmp,pictureBox1);

            //figura.x0 = -3;
            //figura.Xf = 7;
            //figura.y0 = figura.Yf = 5;

            figura.color = Color.Red;
            //fractal.Cantor3(figura, bmp);
            //pictureBox1.Image = bmp;

        }

        private void tbarArbol_ValueChanged(object sender, EventArgs e)
        {
            limpiar_pantalla();
            cFractal f = new cFractal();
            f.x0 = -2;
            f.y0 = -4;
            //f.alfa = Math.PI / 2;
            f.alfa = Math.PI / 2;
            f.beta = Math.PI / tbarArbol.Value;
            f.rd = 4;
            f.color = Color.Red;
            f.Arbol1(bmp);
            pictureBox1.Image = bmp;
        }

        private void tbarArbol_Scroll(object sender, EventArgs e)
        {

        }

        private void parcial2_Load(object sender, EventArgs e)
        {
            bmp2 = bmp;

            for(int i =0; i<15; i++)
            {
                //paletaAzul[i] = Color.FromArgb(0, 0, 100 + (int)(i * 10));
                paletaAzul[i] = Color.FromArgb(i*16, i*16, 100 + (int)(i * 10));
                paletaMadera[i] = Color.FromArgb((int)(140+(i*5.66)), (int)(i * 8.66), (int)(i*3.33));
                paletaPiedra[i] = Color.FromArgb((int)(75 + (i * 7)), (int)(75 + (i * 7)), (int)(75 + (i * 7)));
            }

            llenar_paleta(paletaColor1);


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            //px2 = px1; py2 = py1; qx2 = qx1; qy2 = qy1;
            //px1 = px; py1 = py; qx1 = qx; qy1 = qy;

            //oCuadra.encender(bmp);

            //bmp2 = bmp;
            //pictureBox1.Image = bmp2;

            /*Rectangle r = new Rectangle(0, 0, bmp.Width, bmp.Height);
            bmp2 = bmp.Clone(r, bmp.PixelFormat);*/
            //pictureBox1.Image = bmp2;
            //

            bmp2 = (Bitmap)pictureBox1.Image;
            //pictureBox2.Image = bmp2;

            //bmp.Save("B:\\bmp.jpg");
            //bmp2.Save("B:\\bmp2.jpg");

        }

        public List<double> vy = new List<double>();

        public parcial2()
        {
            InitializeComponent();
        }

        private void btnEjes_Click(object sender, EventArgs e)
        {
            mostrar_ejes();
        }

        private void mostrar_ejes()
        {
            cSegmento oSegmento = new cSegmento();
            oSegmento.color = Color.Black;
            oSegmento.x0 = -10;
            oSegmento.y0 = 0;
            oSegmento.Xf = 10;
            oSegmento.Yf = 0;
            oSegmento.encender(bmp2);

            oSegmento.x0 = 0;
            oSegmento.y0 = 7.33;
            oSegmento.Xf = 0;
            oSegmento.Yf = -7.33;
            oSegmento.encender(bmp2);

            for (int i = -7; i < 7; i++)
            {
                oSegmento.color = Color.Black;
                oSegmento.x0 = -10;
                oSegmento.y0 = i;
                oSegmento.Xf = 10;
                oSegmento.Yf = i;
                oSegmento.cortada(bmp2, 0.05);
            }

            pictureBox1.Image = bmp2;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            /*cBase oBase = new cBase();
            oBase.carta(e.X, e.Y, out px, out py);
            puntosx.Add(px);
            puntosy.Add(py);
            if (banderadown == 1)
            {
                vx.Add(px);
                vy.Add(py);
                cCircunferencia c = new cCircunferencia();
                c.x0 = px;
                c.y0 = py;
                c.rd = 0.15;
                c.encender(bmp);
                pictureBox1.Image = bmp;

            }*/
        }

        public void limpiar_pantalla()
        {
            bmp = null;
            bmp = new Bitmap(600, 460);
            bmp2 = new Bitmap(600, 460);

            pictureBox1.Image = bmp;
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar_pantalla();
            px = 0; py = 0; qx = 0; qy=0;
            px1 = 0; py1 = 0; qx1 = 0; qy1=0;
    }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            cBase oBase = new cBase();
            //double x, y;
            oBase.carta(e.X, e.Y, out qx, out qy);
            lblCoordenadas.Text = String.Format("x={0:0.000} ; y={1:0.000}", qx, qy);

            if (opOrigen == false) return;
            //bmp = null;
            bmp = new Bitmap(600, 440);

            Rectangle r = new Rectangle(0, 0, bmp.Width, bmp.Height);
            bmp = bmp2.Clone(r, bmp.PixelFormat);
            //pictureBox1.Image = bmp2;

            pictureBox1.Image = bmp;

            //cBase oBase = new cBase();
            //oBase.carta(e.X, e.Y, out qx, out qy);
            double distancia;//circunferencia
            //pictureBox1.Image = bmp2;

            mostrar_ejes();
            switch (op)
            {
                case 0:
                    {//segmento
                        /*cSegmento s = new cSegmento();
                        s.color = Color.RoyalBlue;
                        s.x0 = px;
                        s.y0 = py;
                        s.Xf = qx;
                        s.Yf = qy;
                        s.encender(bmp);*/

                        cCuadrado oCuadra = new cCuadrado();
                        oCuadra.color = opColor;
                        oCuadra.x0 = px;
                        oCuadra.Xf = qx;
                        oCuadra.y0 = py;
                        oCuadra.Yf = qy;
                        oCuadra.encender(bmp);
                        pictureBox1.Image = bmp;
                        //button2_Click(sender, e);
                        break;
                    }
                case 1:
                    {//circunferencia
                        distancia = Math.Sqrt(Math.Pow((qx - px), 2) + Math.Pow((qy - py), 2));
                        cCircunferencia cr = new cCircunferencia();
                        cr.x0 = px;
                        cr.y0 = py;
                        cr.rd = distancia;
                        cr.encender(bmp);
                        pictureBox1.Image = bmp;
                        break;
                    }
            }


        }
    }
}
