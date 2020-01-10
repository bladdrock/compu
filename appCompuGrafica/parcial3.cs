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
    public partial class parcial3 : UserControl
    {
        double[] vX = new double[10];
        double[] vY = new double[10];
        int cont = 0;

        Bitmap bmp = new Bitmap(600, 460);
        Bitmap bmp2 = new Bitmap(600, 460);
        Bitmap tapete = new Bitmap(600, 460);
        public int op = 0;
        public int banderadown = -1, flag = 0;
        //Variables de Opciones
        public bool opOrigen;
        public int opGrosor;
        public Color opColor1 = Color.Black;
        public Color opColor2 = Color.RoyalBlue;

        //public string op;
        public double px, py, qx, qy;
        public double px1, py1, qx1, qy1;
        public double px2, py2, qx2, qy2;

        public List<double> puntosx = new List<double>(); // guarda ka coordena de inicio x //desde donde damos clic hasta que lo soltamos
        public List<double> puntosy = new List<double>(); //guarda ka coordena de inicio y //desde donde damos clic hasta hasta que lo soltamos

        public List<double> vx = new List<double>();

        public Color[] paletaAzul = new Color[15];
        public Color[] paletaMadera = new Color[15];
        public Color[] paletaPiedra = new Color[15];

        public Color[] paletaColor1 = new Color[15] {
                    Color.Black,        Color.Navy,         Color.Green,        Color.Red,
                    Color.Purple,       Color.Maroon,       Color.LightGray,    Color.DarkGray,
                    Color.Blue,         Color.Lime,         Color.Silver,       Color.Teal,
                    Color.Fuchsia,      Color.Yellow,       Color.White };


        private void btnPlano3d_Click(object sender, EventArgs e)
        {

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

            pictureBox1.Image = bmp;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            cBase oBase = new cBase();
            oBase.carta(e.X, e.Y, out qx, out qy);
            if (cont == 4) { 
                cont=0;
                vx.Clear();
                vy.Clear();
            }
            vX[cont] = qx;
            vY[cont] = qy;
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
                punto.rd = 0.1;
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
                        oCuadra.color = opColor1;
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

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            using (frmConfiguracion frm = new frmConfiguracion())
            {
                int[] colores = new int [15];
                frm.opColor1.BackColor = opColor1;
                frm.opColor2.BackColor = opColor2;
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
                    //opOrigen = frm.opOrigen.Value;
                    opColor1 = frm.opColor1.BackColor;
                    opColor2 = frm.opColor2.BackColor;
                }
                
            }
        }

        private void btnCuadrilatero_Click(object sender, EventArgs e)
        {
            cCuadrado3d oCuadra = new cCuadrado3d();
            oCuadra.color = opColor1;
            //oCuadra.x0 = 0;
            //oCuadra.y0 = 1;
            //oCuadra.z0 = 0;
            //oCuadra.x1 = 0;
            //oCuadra.y1 = -2;
            //oCuadra.z1 = 2;
            //oCuadra.x2 = 0;
            //oCuadra.y2 = 0;
            //oCuadra.z2 = 7;
            //oCuadra.x3 = 0;
            //oCuadra.y3 = 4;
            //oCuadra.z3 = 5;
            oCuadra.x0 = 0;
            oCuadra.y0 = 1;
            oCuadra.z0 = 0;
            oCuadra.x1 = 0;
            oCuadra.y1 = -2;
            oCuadra.z1 = 2;
            oCuadra.x2 = 0;
            oCuadra.y2 = 0;
            oCuadra.z2 = 7;
            oCuadra.x3 = -3;
            oCuadra.y3 = 4;
            oCuadra.z3 = 2;
            oCuadra.encenderCuadrilatero(bmp);
            pictureBox1.Image = bmp;

            //cCuadrado oCuadra2 = new cCuadrado();
            //oCuadra2.color = Color.Blue;
            //oCuadra2.x0 = 0;
            //oCuadra2.y0 = 1;
            //oCuadra2.x1 = 2;
            //oCuadra2.y1 = -2;
            //oCuadra2.x2 = 7;
            //oCuadra2.y2 = 0;
            //oCuadra2.x3 = 5;
            //oCuadra2.y3 = 4;
            //oCuadra2.encenderCuadrilatero(bmp);
            //pictureBox1.Image = bmp;
        }

        private void btnRelleno_Click(object sender, EventArgs e)
        {

            //pictureBox1.Image = bmp;
            if (vx.Count<4)
            {
                MessageBox.Show("faltan puntos");
                return;
            }
            cCuadrado oCuadra = new cCuadrado();
            oCuadra.color = Color.Orange;

            oCuadra.x0 = vx[0];
            oCuadra.y0 = vy[0];
            oCuadra.x1 = vx[1];
            oCuadra.y1 = vy[1];
            oCuadra.x2 = vx[2];
            oCuadra.y2 = vy[2];
            oCuadra.x3 = vx[3];
            oCuadra.y3 = vy[3];
            // oCuadra.rellenarCuadrilatero(bmp,Color.Red);
            bmp = oCuadra.rellenarCuadrilateroTapete(tapete, bmp, Color.Red);
            //System.Drawing.Graphics g;
            //g = pictureBox1.CreateGraphics();
            //RepertoryImage(g);
            //bmp = new Bitmap(600, 440, g);
            pictureBox1.Image = bmp;

            return;

        }

        public static void RepertoryImage(Graphics drawDestination)
        {
            Pen rPen = new Pen(Color.Black);
            SolidBrush pen2 = new SolidBrush(Color.Green);

            PointF[] capPolygon = new PointF[4];
            capPolygon[0] = new PointF(0, 100);
            capPolygon[1] = new PointF(200, -2);
            capPolygon[2] = new PointF(70, 100);
            capPolygon[3] = new PointF(500, 400);
            drawDestination.DrawPolygon(Pens.Black, capPolygon);
            drawDestination.FillPolygon(pen2, capPolygon);

            drawDestination.DrawLine(rPen, 65, 20, 65, 60);
        }

        private void cmbSuperficie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSuperficie.SelectedIndex == 0)
            {
                cSuperficie oSuper = new cSuperficie();
                oSuper.elasticidad = 0.15;
                oSuper.color = opColor1;
                oSuper.encenderMallado(bmp,1);
                pictureBox1.Image = bmp;
            }
            else if (cmbSuperficie.SelectedIndex == 1)
            {
                opColor1 = Color.Black;
                opColor2 = Color.YellowGreen;
                cSuperficie oSuper = new cSuperficie();
                oSuper.elasticidad = 0.15;
                oSuper.colorRelleno = opColor2;
                oSuper.color = opColor1;
                oSuper.rellenar(bmp);
                pictureBox1.Image = bmp;
                oSuper.encenderMallado(bmp,1);
                pictureBox1.Image = bmp;
            }
            else if (cmbSuperficie.SelectedIndex == 2)
            {
                cSuperficie oSuper = new cSuperficie();
                oSuper.elasticidad = 0.15;
                oSuper.color = Color.Black;
                oSuper.encenderSuperficie(bmp);
                pictureBox1.Image = bmp;
            }
            else if (cmbSuperficie.SelectedIndex == 3)
            {
                cSuperficie oSuper = new cSuperficie();
                oSuper.elasticidad = 0.15;
                oSuper.color = opColor1;
                oSuper.colorRelleno = opColor2;
                oSuper.rellenar2(bmp);
                pictureBox1.Image = bmp;
            }
            else if (cmbSuperficie.SelectedIndex == 4)
            {
                //cSuperficie2 oSuper = new cSuperficie2();
                //oSuper.factor = 0.15;
                //oSuper.color = opColor1;
                //oSuper.ParraboloideHiperbolicoS(bmp);
                ////oSuper.rellenar2(bmp);
                //pictureBox1.Image = bmp;
            }
        }

        private void btnCubo_Click(object sender, EventArgs e)
        {
            cCircunferencia3d cir = new cCircunferencia3d();
            cir.rd = 1.8;
            cir.color = Color.OrangeRed;
            cir.encender(bmp);
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

            //oSeg3d.color = Color.Red;
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

            //Cubo 2
            cCuadrado3d oCuadra = new cCuadrado3d();
            oCuadra.color = Color.Green;
            oCuadra.x0 = 2;
            oCuadra.y0 = 0;
            oCuadra.z0 = -3;
            oCuadra.x1 = 2;
            oCuadra.y1 = 0;
            oCuadra.z1 = 2;
            oCuadra.x2 = 7;
            oCuadra.y2 = 0;
            oCuadra.z2 = 2;
            oCuadra.x3 = 7;
            oCuadra.y3 = 0;
            oCuadra.z3 = -3;
            oCuadra.encenderCuadrilatero(bmp);

            oCuadra.x0 = 7;
            oCuadra.y0 = -4;
            oCuadra.z0 = -3;
            oCuadra.x1 = 7;
            oCuadra.y1 = -4;
            oCuadra.z1 = 2;
            oCuadra.encenderCuadrilatero(bmp);

            oCuadra.x2 = 2;
            oCuadra.y2 = -4;
            oCuadra.z2 = 2;
            oCuadra.x3 = 2;
            oCuadra.y3 = -4;
            oCuadra.z3 = -3;
            oCuadra.encenderCuadrilatero(bmp);

            oCuadra.x0 = 2;
            oCuadra.y0 = 0;
            oCuadra.z0 = -3;
            oCuadra.x1 = 2;
            oCuadra.y1 = 0;
            oCuadra.z1 = 2;
            oCuadra.encenderCuadrilatero(bmp);
            pictureBox1.Image = bmp;

            //Cubo 3 dinamico desde el origen
            oCuadra.color = Color.Black;
            oCuadra.encenderCubo(6, 6, 6, bmp);
        }

        private void btnParabola_Click(object sender, EventArgs e)
        {

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

            pictureBox1.Image = bmp;
        }

        private void btnEstirarEspiral_Click(object sender, EventArgs e)
        {
            cEspiral oEspiral = new cEspiral();
           
            oEspiral.x0 = 0;
            oEspiral.y0 = 0;
            oEspiral.z0 = 0;
            oEspiral.Altura = 3;
            double alfa = Math.PI/4;
            double cont = 0;
            double w = 0;
            oEspiral.eje0 = 0;
            for(int i=0; i<3;i++)
            {
                oEspiral.eje0 = i;
                do
                {
                    oEspiral.alfa = w;
                    oEspiral.color = Color.FromArgb((int)(cont * 13), 255,0);
                    oEspiral.encender(bmp);
                    pictureBox1.Image = bmp;
                    Thread.Sleep(50);
                    pictureBox1.Refresh();
                    oEspiral.Apagar(bmp);
                    w += 0.5;
                    cont += 0.5;
                } while (w <= Math.PI*2);
                //btnCuadrilatero.Text = w.ToString();
                w = 0;
            }



        }

        private void btnPoliedro_Click(object sender, EventArgs e)
        {
            cPoligono poligono = new cPoligono();
            poligono.x0 = -4;
            poligono.y0 = 4;
            poligono.z0 = -4;
            poligono.rd = 2;
            poligono.Nl = 6;
            poligono.alto = 8;
            poligono.color = Color.Blue;
            poligono.encenderPoliedro(bmp);
            pictureBox1.Image = bmp;
        }

        private void btnSuperficie_Click(object sender, EventArgs e)
        {
            limpiar_pantalla();
            lblSuperElasticidad.Text = tbarSuperElast.Value.ToString();
            cmbSuperficies_SelectedIndexChanged(sender, e);
            //cSuperficie oSuper = new cSuperficie();
            //    oSuper.elasticidad = (double)(tbarSuperElast.Value)/10;
            //    oSuper.color = Color.Black;
            //    oSuper.encender1(bmp);
            //    pictureBox1.Image = bmp;
        }

        private void cmbSuperficies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSuperficies.SelectedIndex == 0)
            {
                cSuperficie oSuper = new cSuperficie();
                oSuper.elasticidad = (double)(tbarSuperElast.Value) / 10;
                oSuper.color = opColor1;
                oSuper.x0 = tbrX.Value;
                oSuper.encenderMallado(bmp,2);
                pictureBox1.Image = bmp;

                //limpiar_pantalla();
                lblSuperElasticidad.Text = tbarSuperElast.Value.ToString();

                //cSuperficie oSuper = new cSuperficie();
                //oSuper.elasticidad = (double)(tbarSuperElast.Value) / 10;
                //oSuper.color = Color.Black;
                //oSuper.x0 = tbrX.Value;
                //oSuper.encender1(bmp);
                //pictureBox1.Image = bmp;
            }
            else if (cmbSuperficies.SelectedIndex == 1)
            {
                limpiar_pantalla();
                lblSuperElasticidad.Text = tbarSuperElast.Value.ToString();

                cSuperficie oSuper = new cSuperficie();
                oSuper.elasticidad = (double)(tbarSuperElast.Value) / 10;
                oSuper.color = Color.Black;
                oSuper.encenderMallado(bmp,3);
                pictureBox1.Image = bmp;
            }
            else if (cmbSuperficies.SelectedIndex == 2)
            {
                limpiar_pantalla();
                lblSuperElasticidad.Text = tbarSuperElast.Value.ToString();

                cSuperficie oSuper = new cSuperficie();
                oSuper.elasticidad = (double)(tbarSuperElast.Value) / 10;
                oSuper.color = Color.Black;
                oSuper.encender13(bmp);
                pictureBox1.Image = bmp;
            }
            else if (cmbSuperficies.SelectedIndex == 3)
            {
                cSuperficie oSuper = new cSuperficie();
                oSuper.elasticidad = 0.15;
                oSuper.color = opColor1;
                oSuper.colorRelleno = opColor2;
                oSuper.encender2(bmp);
                pictureBox1.Image = bmp;
            }
        }

        private void btnPiramide_Click(object sender, EventArgs e)
        {
            cPiramide pd = new cPiramide();
            pd.x0 = 0;
            pd.y0 = -3;
            pd.z0 = -3;
            pd.rd = 4;
            pd.teta = Math.PI / 4;
            pd.altura = 7;
            pd.numLados = 7;
            pd.color = Color.Blue;
            pd.encender(bmp);
            pictureBox1.Image = bmp;
        }

        private void btnCilindro_Click(object sender, EventArgs e)
        {
            cSuperficieV superficie = new cSuperficieV();
            //superficie.x0 = -5;
            //superficie.y0 = 4;
            //superficie.z0 = -6;
            superficie.rd = 2.5;
            //superficie.color = Color.Blue;
            //superficie.encender(bmp);

            superficie.x0 = 4;
            superficie.y0 = 4;
            superficie.z0 = 4;
            superficie.color = Color.Red;
            superficie.encender1(bmp);

            //superficie.x0 = -8;
            //superficie.y0 = 0;
            //superficie.z0 = -4;
            //superficie.color = Color.Green;
            //superficie.encender12(bmp);
            pictureBox1.Image = bmp;
        }

        private void cmbTapetes_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenar_figuras(cmbTapetes.SelectedIndex);
        }

        private Bitmap llenar_figuras(int numero)
        {
            int colorT;

            for (int i = 0; i < 600; i++)
            {
                for (int j = 1; j < 460; j++)
                {
                    switch (numero)
                    {
                        case 0:
                            colorT = (i ^ 2 + j ^ 2) % 15;
                            tapete.SetPixel(i, j, paletaAzul[colorT]);
                            break;
                        case 1:
                            colorT = Math.Abs((int)(Math.Log(i * 3) + (j / 2)) % 15);
                            tapete.SetPixel(i, j, paletaAzul[colorT]);
                            break;
                        case 2:
                            colorT = Math.Abs((int)(Math.Cos(i * i) + Math.Cos(j)) % 15) + 5;
                            tapete.SetPixel(i, j, paletaAzul[colorT]);
                            break;
                        case 3:
                            colorT = (int)(100 + Math.Cos(i * j) - Math.Sqrt(i / 4)) % 15;
                            //colorT = (i ^ 2 + 2*i*j+ j ^ 2) % 15;
                            tapete.SetPixel(i, j, paletaAzul[colorT]);
                            break;
                        case 4:
                            colorT = (int)(100 + Math.Cos(i * j) - Math.Sqrt(i / 4)) % 15;
                            tapete.SetPixel(i, j, paletaColor1[colorT]);
                            break;
                        case 5:
                            colorT = Math.Abs((int)(Math.Cos(i * i) + Math.Cos(j * j)) % 15) + 1;
                            tapete.SetPixel(i, j, paletaAzul[colorT]);
                            break;
                        case 6:

                            double temp = (i + Math.Cos(1 + i * Math.PI)) % 15;
                            colorT = (int)Math.Abs(temp);
                            //if (colorT < 0) colorT = 0;
                            tapete.SetPixel(i, j, paletaMadera[colorT]);
                            //g.FillRectangle(brush, i, j, 1, 1);
                            break;
                        case 7:
                            temp = (i * j * Math.E) % 10;
                            colorT = (int)Math.Abs(temp);
                            //if (colorT < 0) colorT = 0;
                            tapete.SetPixel(i, j, paletaPiedra[colorT]);
                            break;

                        case 8:
                            temp = (-i * j + Math.Sqrt(j * j)) % 10;
                            colorT = (int)Math.Abs(temp);
                            //if (colorT < 0) colorT = 0;
                            tapete.SetPixel(i, j, paletaAzul[colorT]);
                            //g.FillRectangle(brush, i, j, 1, 1);
                            break;
                    }

                    //vector.encender(bmp);
                }
            }
            return tapete;
        }

        private void parcial3_Load(object sender, EventArgs e)
        {
            bmp2 = bmp;

            for (int i = 0; i < 15; i++)
            {
                //paletaAzul[i] = Color.FromArgb(0, 0, 100 + (int)(i * 10));
                paletaAzul[i] = Color.FromArgb(i * 16, i * 16, 100 + (int)(i * 10));
                paletaMadera[i] = Color.FromArgb((int)(140 + (i * 5.66)), (int)(i * 8.66), (int)(i * 3.33));
                paletaPiedra[i] = Color.FromArgb((int)(75 + (i * 7)), (int)(75 + (i * 7)), (int)(75 + (i * 7)));
            }
            cmbTapetes.SelectedIndex = 7;
        }

        private void btnPiramidet_Click(object sender, EventArgs e)
        {
            cPiramide pd = new cPiramide();
            pd.x0 = 0;
            pd.y0 = -3;
            pd.z0 = -3;
            pd.rd = 4;
            pd.teta = Math.PI / 4;
            pd.altura = 7;
            pd.numLados = 7;
            pd.color = Color.Blue;
            pd.encender2(bmp);
            pictureBox1.Image = bmp;
        }

        private string RevertColor(Color value)
        {
            return System.Drawing.ColorTranslator.ToHtml(value);
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

            //bmp = (Bitmap)pictureBox1.Image;
            //pictureBox2.Image = bmp2;

            //bmp.Save("B:\\bmp.jpg");
            //bmp2.Save("B:\\bmp2.jpg");

        }

        public List<double> vy = new List<double>();

        public parcial3()
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
            oSegmento.encender(bmp);

            oSegmento.x0 = 0;
            oSegmento.y0 = 7;
            oSegmento.Xf = 0;
            oSegmento.Yf = -7;
            oSegmento.encender(bmp);

            for (int i = -7; i < 7; i++)
            {
                oSegmento.color = Color.Black;
                oSegmento.x0 = -10;
                oSegmento.y0 = i;
                oSegmento.Xf = 10;
                oSegmento.Yf = i;
                oSegmento.cortada(bmp, 0.05);
            }

            pictureBox1.Image = bmp;
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
            bmp = new Bitmap(600, 440);
            bmp2 = new Bitmap(600, 440);
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
            if (opOrigen == false) return;
            //bmp = null;
            bmp = new Bitmap(600, 440);

            Rectangle r = new Rectangle(0, 0, bmp.Width, bmp.Height);
            bmp = bmp2.Clone(r, bmp.PixelFormat);
            //pictureBox1.Image = bmp2;

            pictureBox1.Image = bmp;

            cBase oBase = new cBase();
            //double x, y;
            oBase.carta(e.X, e.Y, out qx, out qy);
            lblCoordenadas.Text = String.Format("x={0:0.000} ; y={1:0.000}", qx, qy);

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
                        oCuadra.color = opColor1;
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
