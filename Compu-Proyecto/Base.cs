using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compu_Proyecto
{
    class Base
    {
        // V Computadora
        public static int Sx1 = 0;
        public static int Sy1 = 0;
        public static int Sx2 = 560;
        public static int Sy2 = 400;

        // V Real
        public static double X1 = -10;
        public static double Y1 = -7.14;
        public static double X2 = 10;
        public static double Y2 = 7.14;

        // constructor
        public Base() { }
        
        // destructor

        ~Base() { }

        //REAL X Y
        public void RealXY(double SX, double SY, out double X, out double Y)
        {
            X = -((((SX - Sx1) * (X1 - X2)) / (Sx1 - Sx2)) + X1);
            Y = -((((SY - Sy1) * (Y2 - Y1)) / (Sy1 - Sy2)) + Y2);
        }

        // proceso pantalla
        public void procesoPantlla(double x, double y, out int Sx, out int Sy)
        {
            Sx = (int)Math.Truncate((((Sx1 - Sx2) / (X1 - X2)) * (x - X2))) + Sx2;
            Sy = (int)Math.Truncate((((Sy1 - Sy2) / (Y2 - Y1)) * (y - Y2))) + Sy1;
        }
        // proceso pantalla
        public void procesoPantlla2(double x, double y, out int Sx, out int Sy)
        {
            Sx = (int)(((Sx1 - Sx2) / (X1 - X2)) * (x - X2)) + Sx2;
            Sy = (int)(((Sy1 - Sy2) / (Y2 - Y1)) * (y - Y2)) + Sy1;
        }

        // proceso carta
        public void procesoCarta(int Sx, int Sy, out double x, out double y)
        {
            x = ((((Sx - Sx2) * (X1 - X2)) / (Sx1 - Sx2)) + X2) ;
            y = ((((Sy - Sy1) * (Y2 - Y1)) / (Sy1 - Sy2)) + Y2) ;

        }
        public void procesoCarta2(int Sx, int Sy, out double x, out double y)
        {
            x = ((((Sx - Sx2) * (X1 - X2)) / (Sx1 - Sx2)) + X2) * 0.17;
            y = ((((Sy - Sy1) * (Y2 - Y1)) / (Sy1 - Sy2)) + Y2) * 0.17;

        }
    }
}
