using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appCompuGrafica
{
    class cBase
    {
        //Limites del pictureBox
        public static int Xpmin = 0;
        public static int Ypmin = 0;
        public static int Xpmax = 600;
        public static int Ypmax = 460;

        //Limites del monitor
        public static double Xmin = -10;
        public static double Xmax = 10;
        public static double Ymin = -8;
        public static double Ymax = 8;

        //Constructor
        public cBase() { }
        ~cBase() { }

        //funcion de los puntos para la pantalla
        public void pantalla(double X, double Y, out int Xp, out int Yp)
        {
            Xp = (int)((Xpmin - Xpmax) / (Xmin - Xmax) * (X - Xmax) + Xpmax);
            Yp = (int)((Ypmin - Ypmax) / (Ymax - Ymin) * (Y - Ymax) + Ypmin);
        }

        //funcion de los puntos reales
        public void carta( int Xp, int Yp, out double X, out double Y)
        {
            X = (((Xp - Xpmax) * (Xmin - Xmax)) / (Xpmin - Xpmax)) + Xmax;
            Y = (((Yp - Ypmin) * (Ymax - Ymin)) / (Ypmin - Ypmax)) + Ymax;
        }
    }
}
