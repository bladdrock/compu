using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelNuevoCGWF
{
    class ClPantalla
    {
        int Pxmin=0;
        int Pxmax=600;
        int Pymin=0;
        int Pymax=460;
        int Xmin=-10;
        int Xmax=10;
        int Ymin=-8;
        int Ymax = 8;

        public void Pantalla19(double x, double y, out int Px, out int Py)
        {
            Px = (int)((Pxmin - Pxmax) / (Xmin - Xmax) * (x - Xmin)) + Pxmin;
            Py = (int)((Pymin - Pymax) / (Ymax - Ymin) * (y - Ymax)) + Pymin;
        }
        public void Pantalla(double x, double y, out double Px, out double Py)
        {
            //Px = ((Pxmin - Pxmax) / (Xmin - Xmax) * (x - Xmin)) + Pxmin;
            //Py = ((Pymin - Pymax) / (Ymax - Ymin) * (y - Ymax)) + Pymin;
            Px = (((x - Pxmin) * (Xmin - Xmax)) / (Pxmin - Pxmax)) + Xmin;
            Py = (((y - Pymin) * (Ymax - Ymin)) / (Pymin - Pymax)) + Ymax;
        }

    }
}
