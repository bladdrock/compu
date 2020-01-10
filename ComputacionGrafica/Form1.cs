using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ComputacionGrafica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
            this.seleccionado = 0;                        
            anim1.SizeMode = PictureBoxSizeMode.StretchImage;           
            anim2.SizeMode = PictureBoxSizeMode.StretchImage;
            colorBaseMapa = mapa.GetPixel(10, 10);
        }

        int seleccionado, SX, SY;
        double X, Y, X0, Y0;
        Bitmap mapa = new Bitmap(560, 400);
        Color colorBaseMapa;
        List<double> Vx = new List<double>();
        List<double> Vy = new List<double>();              
        
        private void Inundacion(Point pt, Color relleno)
        {

            Stack<Point> pixels = new Stack<Point>();
            Color ColorBorde = mapa.GetPixel(pt.X, pt.Y);
            pixels.Push(pt);            
            while (pixels.Count > 0)
            {
                Point a = pixels.Pop();
                if (a.X < mapa.Width && a.X > 0 && a.Y < mapa.Height && a.Y > 0)

                {
                    if (mapa.GetPixel(a.X, a.Y) == ColorBorde)
                    {                        
                        mapa.SetPixel(a.X, a.Y, relleno);
                        pixels.Push(new Point(a.X - 1, a.Y));
                        pixels.Push(new Point(a.X + 1, a.Y));
                        pixels.Push(new Point(a.X, a.Y - 1));
                        pixels.Push(new Point(a.X, a.Y + 1));
                    }
                }
            }
        }      

        private void PBLienzo_MouseMove(object sender, MouseEventArgs e)
        {          
            Point punto = Control.MousePosition;
            punto = PointToClient(punto);                        
            this.SX = punto.X;
            this.SY = punto.Y;            
            Proceso p = new Proceso();
            p.Carta(this.SX, this.SY, out this.X, out this.Y);
            this.X = Math.Round(X, 2);
            this.Y = Math.Round(Y, 2);
            this.txtX.Text = this.X.ToString();
            this.txtY.Text = this.Y.ToString();
        }
        
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            
            Bitmap aux = new Bitmap(560, 400);
            this.mapa = aux;
            this.PBLienzo.Image = this.mapa;
        }                
        
        private void PBLienzo_MouseLeave(object sender, EventArgs e)
        {
            this.txtX.Text = "";
            this.txtY.Text = "";
        }
        
        private void ARBtnPuntos_Click(object sender, EventArgs e)
        {
            this.seleccionado = 1;
        }

        private void ARBtnInundacion_Click(object sender, EventArgs e)
        {
            this.seleccionado = 2;                
        }

        private void ARBtnVisto_Click(object sender, EventArgs e)
        {
            try
            {
                Segmento s1 = new Segmento();
                s1.setColorRGB(0, 0, 0);

                for (int i = 0; i < (Vx.Count - 1); i++)
                {
                    s1.X0 = Vx[i];
                    s1.Y0 = Vy[i];
                    s1.Xf = Vx[i + 1];
                    s1.Yf = Vy[i + 1];
                    s1.Encender(mapa);
                }

                s1.X0 = Vx[Vx.Count - 1];
                s1.Y0 = Vy[Vx.Count - 1];
                s1.Xf = Vx[0];
                s1.Yf = Vy[0];
                s1.Encender(mapa);
                PBLienzo.Image = mapa;
                Vx.Clear();
                Vy.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique que haya trazado al menos un punto");
            }
            
        }

        private void ARBtnScanLine_Click(object sender, EventArgs e)
        {
            try
            {                
                    int R, G, B;
                    R = int.Parse(this.ARR.Text);
                    G = int.Parse(this.ARG.Text);
                    B = int.Parse(this.ARB.Text);
                    Boolean figura = false;
                    Color ColorRelleno = Color.FromArgb(R, G, B);
                    for (int i = 0; i < 560; i++)
                    {
                        Vx.Clear();
                        for (int j = 0; j < 400; j++)
                        {
                            if (colorBaseMapa != mapa.GetPixel(i, j))
                            {
                                figura = true;
                                Vx.Add(j);
                                for (int k = (int)Vx[0]; k < (int)Vx[Vx.Count - 1]; k++)
                                {
                                    mapa.SetPixel(i, k, ColorRelleno);
                                }
                            }
                        }
                    }
                    if (figura)
                    {
                        PBLienzo.Image = mapa;
                        Vx.Clear();
                    }
                    else
                    MessageBox.Show("El scanner no muestra ninguna figura en el lienzo para ser pintada");

            }
            catch(Exception)
            {
                MessageBox.Show("Defina el color del relleno en formato RGB");
            }            
        }        

        private void PBLienzo_MouseDown(object sender, MouseEventArgs e)
        {
            int R, G, B;
            R = 0;
            G = 0;
            B = 0;

            this.X0 = this.X;
            this.Y0 = this.Y;         
            
            if (this.seleccionado == 1)
            {                
                Circunferencia C = new Circunferencia();
                C.X0 = this.X0;
                C.Y0 = this.Y0;
                C.Rad = 0.10;
                C.setColorRGB(R,G,B);
                C.Encender(mapa);              
                Vx.Add(X0);
                Vy.Add(Y0);                
                PBLienzo.Image = mapa;
            }

            if (this.seleccionado == 2)
            {
                try
                {
                    Color figura = Color.FromArgb(R, G, B);
                    R = int.Parse(this.ARR.Text);
                    G = int.Parse(this.ARG.Text);
                    B = int.Parse(this.ARB.Text);
                    Color relleno = Color.FromArgb(R, G, B);
                    Point p = new Point(SX, SY);                    
                    Inundacion(p, relleno);                    
                    PBLienzo.Image = mapa;
                }
                catch(Exception)
                {
                    MessageBox.Show("Defina el color de relleno en formato RGB");
                }                
            }            
        }
    }

}