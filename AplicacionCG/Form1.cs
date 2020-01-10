using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Algorithms;


namespace AplicacionCG
{
    public partial class Form1 : Form 
    {
        Bitmap Lienzo = new Bitmap(560, 400);
        public Form1()
        {
            InitializeComponent();
            
        }
       
        private void Limpiar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 560; i++)
                for(int j = 0; j < 400; j++)
            {
                    Lienzo.SetPixel(i, j, Color.Black);
            }
            VentanaP.Image = Lienzo;
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Superficie_Click(object sender, EventArgs e)
        {
            //SuperficieBS obj = new SuperficieBS(0, 0, 0, 5, Math.PI/2, 2, Color.Green, Lienzo, VentanaP);
            //    obj.Encender();
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    //encender seno cuadrado
                    SuperficieBS obj = new SuperficieBS(0, 0, 0, 0, Math.PI / 2, 2, Color.Green, Lienzo, VentanaP);
                    obj.Encender();

                    break;
                case 1:
                    //encender nube de puntos
                    SuperficieBS obj1 = new SuperficieBS(1, 1, 3, 2, Math.PI / 2, 2, Color.Green, Lienzo, VentanaP);
                    obj1.Encender();

                    break;
                case 2:
                    //superficie de la nube de puntos anterior
                    SuperficieBS obj2 = new SuperficieBS(0, 0, 0, 1, Math.PI / 2, 2, Color.Green, Lienzo, VentanaP);
                    obj2.Encender();

                    break;
                case 3:
                    //nube de puntos nueva superficie
                    SuperficieBS obj3 = new SuperficieBS(1, 1, 3, 4, Math.PI / 2, 2, Color.Green, Lienzo, VentanaP);
                    obj3.Encender();

                    break;
                case 4:
                    //encender nube y superficie
                    SuperficieBS obj4 = new SuperficieBS(0, 0, 0, 3, Math.PI / 2, 2, Color.Green, Lienzo, VentanaP);
                    obj4.Encender();

                    break;
                case 5:
                    //encendido optimizado bspline
                    SuperficieBS obj5 = new SuperficieBS(0, 0, 0, 5, Math.PI / 2, 2, Color.Green, Lienzo, VentanaP);
                    obj5.Encender();

                    break;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            }
    }
}
