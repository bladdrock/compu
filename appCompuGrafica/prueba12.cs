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
    public partial class prueba12 : UserControl
    {
        public prueba12()
        {
            InitializeComponent();
        }

        public List<double> puntosx = new List<double>(); // guarda ka coordena de inicio x //desde donde damos clic hasta 
        public List<double> puntosy = new List<double>(); //guarda ka coordena de inicio y //desde donde damos clic hasta 
        public double Px, Py, Qx, Qy, x;//variables de salidas
        public Bitmap pixel = new Bitmap(600, 460);

        public Color[] paletaColor1 = new Color[15] {
                    Color.Black,        Color.Navy,         Color.Green,        Color.Red,
                    Color.Purple,       Color.Maroon,       Color.LightGray,    Color.DarkGray,
                    Color.Blue,         Color.Lime,         Color.Silver,       Color.Teal,
                    Color.Fuchsia,      Color.Yellow,       Color.White };

        private void prueba12_Load(object sender, EventArgs e)
        {

        }

        private void btnPintar1_Click(object sender, EventArgs e)
        {
            int sx, sy, ncolor;
            for(sx = 0; sx < 600; sx++)
            {
                for (sy = 0; sy < 460; sy++)
                {
                    ncolor = (int)((Math.Pow(sx, 2) + Math.Pow(sy, 2)) % 15);
                    pixel.SetPixel(sx, sy, paletaColor1[ncolor]);
                }
            }
            pictureBox1.Image = pixel;
        }

        private void button1_Click(object sender, EventArgs e)
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
            oSegmento.encender(pixel);

            oSegmento.x0 = 0;
            oSegmento.y0 = 7.33;
            oSegmento.Xf = 0;
            oSegmento.Yf = -7.33;
            oSegmento.encender(pixel);

            for (int i = -7; i < 7; i++)
            {
                oSegmento.color = Color.Black;
                oSegmento.x0 = -10;
                oSegmento.y0 = i;
                oSegmento.Xf = 10;
                oSegmento.Yf = i;
                oSegmento.cortada(pixel, 0.05);
            }

            pictureBox1.Image = pixel;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            cBase oBase = new cBase();
            oBase.carta(e.X, e.Y, out Qx, out Qy);
            double distancia;
            cSegmento s = new cSegmento();
            //CurvasV cv = new CurvasV();

            distancia = Math.Sqrt(Math.Pow((Qx - Px), 2) + Math.Pow((Qy - Py), 2));

            cCircunferencia cir = new cCircunferencia();
            cir.x0 = Px;
            cir.y0 = Py;
            cir.rd = distancia;
            cir.color = Color.Blue;
            cir.encenderLogo(pixel);
            pictureBox1.Image = pixel;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            cBase oBase = new cBase();
            oBase.carta(e.X, e.Y, out Px, out Py);
            //vx.Add(Px);
            //vy.Add(Py);
            puntosx.Add(Px);
            puntosy.Add(Py);
        }
    }
}
