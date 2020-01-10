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
    public partial class ufractales : UserControl
    {
        public ufractales()
        {
            InitializeComponent();
        }

        Bitmap lienzo = new Bitmap(600,460);
        Color color1, color2, colorf = Color.White;
        List<double> puntosx = new List<double>();
        List<double> puntosy = new List<double>();
        int cont = 0;
        string tipo = "sierpinsky";
        double delta=0, alfa=Math.PI/2;
        public double px, py, qx, qy, factor=0;
        cArbol arbolS = new cArbol();

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar_pantalla();

        }

        public void limpiar_pantalla()
        {
            lienzo = null;
            lienzo = new Bitmap(600, 460);
            pictureBox1.Refresh();
            pictureBox1.BackColor = colorf;
            pictureBox1.Image = lienzo;
            puntosx.Clear();
            puntosy.Clear();
            double[] x = { -5, -3, 5 };
            double[] y = { -3, 3, 0 };
            puntosx.AddRange(x);
            puntosy.AddRange(y);
        }

        private void btnCantor_Click(object sender, EventArgs e)
        {
            //limpiar_pantalla();
            cFractal fractal = new cFractal();
            fractal.color = color1;
            fractal.color2 = color2;

            cSegmento figura = new cSegmento();
            figura.x0 = -8;
            figura.Xf = 8;
            figura.y0 = 6.5;
            figura.Yf = 6.5;
            figura.color = Color.White;

            if (chkAleatorio.Checked)
            {
                if (!chkCantor.Checked)
                    figura.color = Color.Black;
                figura.encender(lienzo);
                fractal.figura = cmbFiguras.Text.ToLower();
                fractal.Cantor3(figura, lienzo, pictureBox1);
                return;
            }

            if (chkFiguras.Checked)
            {
                if (!chkCantor.Checked)
                    figura.color = Color.Black;
                figura.encender(lienzo);
                fractal.figura = cmbFiguras.Text.ToLower();
                fractal.Cantor2(figura, lienzo, pictureBox1);
                return;
            }

            if (chkCantor.Checked)
            {
                figura.encender(lienzo);
                fractal.Cantor(figura, lienzo, pictureBox1);
                return;
            }

        }

        private void chkFiguras_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFiguras.Checked)
            {
                chkAleatorio.Checked = false;
                chkAleatorio.Visible = true;
                cmbFiguras.Visible = true;
                cmbFiguras.SelectedIndex = 0;
            }
            else
            {
                chkAleatorio.Checked = false;
                chkAleatorio.Visible = false;
                cmbFiguras.Visible = false;
            }
        }

        private void opColor1_Click(object sender, EventArgs e)
        {
            arbolS.encenderSegmentos(lienzo);
            pictureBox1.Image = lienzo;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                PictureBox pic = (PictureBox)sender;
                pic.BackColor = colorDialog1.Color;
                if (pic.Name == "opColor1")
                    color1 = colorDialog1.Color;
                else if (pic.Name == "opColor2")
                    color2 = colorDialog1.Color;
                else if (pic.Name == "pictureBox1")
                    colorf = colorDialog1.Color;
            }
        }

        private void ufractales_Load(object sender, EventArgs e)
        {
            color1 = opColor1.BackColor;
            color2 = opColor2.BackColor;
            colorf = Color.Black;
            limpiar_pantalla();
        }

        private void pictureBox1_BackColorChanged(object sender, EventArgs e)
        {
            btnLimpiar.BackColor = pictureBox1.BackColor;
        }

        private void btnArbol_Click(object sender, EventArgs e)
        {
            cFractal f = new cFractal();
            f.x0 = 0;
            f.y0 = 0;
            f.z0 = -8;
            f.alfa = 0;
            f.beta = Math.PI / 5;
            f.rd = 6;
            f.color = Color.Red;
            //f.Arbol_Interpolado(lienzo);
            f.Arbol_Interpolado2(lienzo,false);
            List<cSegmento> segmentos = f.segmentos;
            arbolS.segmentos = segmentos;
            //foreach (cSegmento s in segmentos)
            //{
            //    s.x0 += 2;
            //    s.Xf += 2;
            //    s.color = Color.Blue;
            //    s.encender(lienzo);
            //}

            //arbolS.x0 = 4;
            //arbolS.y0 = 0;
            //arbolS.segmentos = segmentos;
            //arbolS.encenderSegmentos(lienzo);

            //s.encender(lienzo);
            pictureBox1.Image = lienzo;
        }

        private void btnAnimacion_Click(object sender, EventArgs e)
        {
            List<double> Px = new List<double>() { -6.66, -1.66, 3.40, 6.66 };
            List<double> Py = new List<double>() { 2.33, 6.43, 5.35, -2.33 };

            cCurvasAjuste lagrange = new cCurvasAjuste(4, Px, Py, Color.Blue);
            lagrange.animarLagrange(lienzo);
            pictureBox1.Image = lienzo;
        }

        private void tbrPoliedro_Scroll(object sender, EventArgs e)
        {
            limpiar_pantalla();
            lblAltutaPol.Text = tbrAlturaPol.Value.ToString();
            lblRadioPol.Text = tbarRadioPol.Value.ToString();
            lblLadosPoli.Text = tbrPoliedro.Value.ToString();

            lblPolRotarX.Text = tbarPolRotarX.Value.ToString();
            lblPolRotarY.Text = tbarPolRotarY.Value.ToString();
            lblPolRotarZ.Text = tbarPolRotarZ.Value.ToString();

            cPoligono poligono = new cPoligono();
            TrackBar obj = (TrackBar)sender;
            
            int eje = 0;
            if (obj.Tag == "x")
            {
                eje = 2;
                poligono.factor = (double)obj.Value / 3;
            }

            else if (obj.Tag == "y")
            {
                eje = 0;
                poligono.factor = (double)obj.Value / 3;
            }

            else if (obj.Tag == "z")
            {
                eje = 1;
                poligono.factor = (double)obj.Value / 3;
            }
            else
            {
                eje = 2;
                poligono.factor = factor;
            }
               
            if(ckboxPiramide.Checked)
                poligono.encenderPiramide(lienzo, color1, eje, tbrPoliedro.Value, tbrZ.Value, tbrX.Value, tbrY.Value, tbarRadioPol.Value, tbrAlturaPol.Value);
            else
                poligono.encenderPoliedro(lienzo, color1, eje, tbrPoliedro.Value, tbrZ.Value, tbrX.Value, tbrY.Value, tbarRadioPol.Value, tbrAlturaPol.Value);
            pictureBox1.Image = lienzo;
        }


        private void ckboxPolAnimar_CheckedChanged(object sender, EventArgs e)
        {
            if(!timerPoliedro.Enabled)
                timerPoliedro.Start();
            else
                timerPoliedro.Stop();
        }


        private void timerPoliedro_Tick(object sender, EventArgs e)
        {
            limpiar_pantalla();
            cPoligono poligono = new cPoligono();
            factor += 0.3;
            poligono.Alfa = alfa;
            poligono.delta = delta;
            alfa = (alfa >= (Math.PI*5/2))?Math.PI/2: alfa + 0.05;
            delta = (delta >= (Math.PI * 2)) ? 0 : delta + 0.05;
            //poligono.factor = factor;
            poligono.color = color1;
            int eje = 2;
            if (ckboxPiramide.Checked)
            {
                poligono.encenderPiramideAn(lienzo, color1, eje, tbrPoliedro.Value, tbrZ.Value, tbrX.Value, tbrY.Value, tbarRadioPol.Value, tbrAlturaPol.Value);
            }
            else
            {
                poligono.encenderPoliedroAn(lienzo, color1, eje, tbrPoliedro.Value, tbrZ.Value, tbrX.Value, tbrY.Value, tbarRadioPol.Value, tbrAlturaPol.Value);
                //poligono.encenderPoliedro(lienzo, color1, 0, tbrPoliedro.Value, tbrZ.Value, tbrX.Value, tbrY.Value, tbarRadioPol.Value, tbrAlturaPol.Value);
            }
            pictureBox1.Image = lienzo;

        }

        private void tbarPolRotarX_Scroll(object sender, EventArgs e)
        {
            limpiar_pantalla();
            lblAltutaPol.Text = tbrAlturaPol.Value.ToString();
            lblRadioPol.Text = tbarRadioPol.Value.ToString();
            lblLadosPoli.Text = tbrPoliedro.Value.ToString();

            cPoligono poligono = new cPoligono();
            poligono.Alfa += (tbarPolRotarX.Value);
            poligono.encenderPoliedro(lienzo, color1, 0, tbrPoliedro.Value, tbrX.Value, tbrY.Value, tbrZ.Value, tbarRadioPol.Value, tbrAlturaPol.Value);
            pictureBox1.Image = lienzo;
        }

        private void btnFxxx_Click(object sender, EventArgs e)
        {
            cFractal fractal = new cFractal();
            fractal.color = color1;
            fractal.color2 = color2;

            cSegmento figura = new cSegmento();
            figura.x0 = -8;
            figura.Xf = 8;
            figura.y0 = 2.5;
            figura.Yf = 6.5;

            double m = (figura.Yf - figura.y0)/(figura.Xf - figura.x0);
            figura.color = Color.White;

            figura.encender(lienzo);
            double y0 = figura.y0;
            figura.y0 = m * (figura.y0);
            figura.Yf = m* figura.Yf;
            figura.encender(lienzo);
            pictureBox1.Image = lienzo;
            //fractal.Cantor(figura, lienzo, pictureBox1);

        }

        private void btnKoch_Click(object sender, EventArgs e)
        {
            cFractal fractal = new cFractal();
            //cFractal.Koch(Bitmap lienzo, int nveces, double x1, double y1, double x2, double y2)
            fractal.color = color1;
            int lados = tbarLados.Value;
            fractal.Koch(lienzo, lados, -7, 4, 7, 4);
            fractal.Koch(lienzo, lados, 0, -8, -7, 4);
            fractal.Koch(lienzo, lados, 7, 4, 0, -8);
            pictureBox1.Image = lienzo;
        }

        private void tbarSierpinskyNun_Scroll(object sender, EventArgs e)
        {
            lienzo = new Bitmap(600, 460);
            //limpiar_pantalla();
            lblSierpinskyNum.Text = tbarSierpinskyNun.Value.ToString();
            lblSierpinskyX.Text = tbarSierpinskyX.Value.ToString();

            cFractales2 oFractal = new cFractales2();
            oFractal.color = color1;
            oFractal.color2 = color2;
            oFractal.x0 = tbarSierpinskyX.Value;
            oFractal.y0 = tbarSierpinskyY.Value;
            //for (int i=0; i<3; i++)
            //{
            //    puntosx[i] += tbarSierpinskyX.Value;
            //    //puntosx[i] += tbarSierpinskyX.Value;
            //}
                
            oFractal.sierpinski(lienzo,tbarSierpinskyNun.Value,
                            puntosx[0], puntosy[0], puntosx[1], puntosy[1], puntosx[2], puntosy[2]);

            pictureBox1.Image = lienzo;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            cBase oBase = new cBase();
            oBase.carta(e.X, e.Y, out qx, out qy);
            puntosx.Add(qx);
            puntosy.Add(qy);
            cont++;

            if (tipo == "sierpinsky")
            {
                cCircunferencia punto = new cCircunferencia();
                if (cont == 1)
                {
                    puntosx[0] = qx;
                    puntosy[0] = qy;
                }
                else if (cont == 2)
                {
                    puntosx[1] = qx;
                    puntosy[1] = qy;
                }
                else
                {
                    puntosx[2] = qx;
                    puntosy[2] = qy;
                    cont = 0;
                }

                punto.x0 = qx;
                punto.y0 = qy;
                punto.color = color1;
                punto.rd = 0.1;
                punto.encender(lienzo);
                pictureBox1.Image = lienzo;
            }
            else
            {
                cCircunferencia punto = new cCircunferencia();
                punto.x0 = qx;
                punto.y0 = qy;
                punto.color = color1;
                punto.rd = 0.1;
                punto.encender(lienzo);
                pictureBox1.Image = lienzo;
            }
            
        }

        private void tbarLados_Scroll(object sender, EventArgs e)
        {
            limpiar_pantalla();
            lblLados.Text = tbarLados.Value.ToString();
            btnKoch_Click(sender, e);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            cBase oBase = new cBase();
            //double x, y;
            oBase.carta(e.X, e.Y, out qx, out qy);
            lblCoordenadas.Text = String.Format("x={0:0.000} ; y={1:0.000}", qx, qy);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {

        }

        //TRIANGULOS SIERPINSY
        private void btnSierpinsky_Click(object sender, EventArgs e)
        {
            tbarSierpinskyNun_Scroll(sender, e);
        }
    }
}
