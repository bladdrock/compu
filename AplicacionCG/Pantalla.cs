using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCG
{
    class Pantalla
    {
        public static int Sx1 = 0;
        public static int Sx2 = 560;
        public static int Sy1 = 0;
        public static int Sy2 = 400;
        public static double X1 = -10;
        public static double X2 = 10;
        public static double Y1 = -7.14;
        public static double Y2 = 7.14;
        public static void Pantalla19(double X, double Y, out int Sx, out int Sy)
        {
           // Sx = (int)(((Pxmin - Pxmax) / (Xmin - Xmax)) * (X - Xmin) + Pxmin);
           Sx= (int)(((Sx1 - Sx2) / (X1 - X2)) * (X - X1) + Sx1);
            // Sy = (int)(((Pymin - Pymax) / (Ymax - Ymin)) * (Y - Ymax) + Pymin);
            Sy = (int)(((Sy1 - Sy2) / (Y2 - Y1)) * (Y - Y2) + Sy1);
        }
        public static void Carta(int Sx, int Sy, out double X, out double Y)
        {
          //X = ((Px - Pxmin) * ((Xmin - Xmax) / (Pxmin - Pxmax)) + Xmin);
            X = ((Sx - Sx1) * ((X1 - X2) / (Sx1 - Sx2)) + X1);
         // Y = ((Py - Pymax) * ((Ymin - Ymax) / (Pymax - Pymin)) + Ymin);
         // Y=((Sy - Sy2) * ((Y1 - Y2) / (Sy2 - Sy1)) + Y1);
            Y = ((Sy - Sy1) * ((Y2 - Y1) / (Sy1 - Sy2)) + Y2);

        }
        public static void Axonometria(double x, double y, double z, out double ax, out double ay)
        {
            ax = y - (x / 2) * Math.Cos(Math.PI / 4);
            ay = z - (x / 2) * Math.Sin(Math.PI / 4);

        }
        public void Rotar(double x, double y, double z, double gama, out double rx, out double ry, out double rz, int eje)
        {
            rx = x;
            ry = y;
            rz = z;

            if (eje == 0)
            {
                rx = x;
                ry = y * Math.Cos(gama) - z * Math.Sin(gama);
                rz = y * Math.Sin(gama) + z * Math.Cos(gama);
            }
            if (eje == 1)
            {
                rx = x * Math.Cos(gama) + z * Math.Sin(gama);
                ry = y;
                rz = -x * Math.Sin(gama) + z * Math.Cos(gama);
            }
            if (eje == 2)
            {
                rx = x * Math.Cos(gama) - y * Math.Sin(gama);
                ry = x * Math.Sin(gama) + y * Math.Cos(gama);
                rz = z;
            }

        }
    }
}
