using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace appCompuGrafica
{
    class GraficoV : cCircunferencia
    {
        public int tipo, opciones;

        public void encender(Bitmap bmp)
        {
            cVector vector = new cVector();
            double t = 0; double  dt = 0.001;
            
            switch (opciones)
            {
                case 0://teta
                    {
                        do
                        {
                            vector.x0 = x0 + (rd * Math.Cos(t));
                            vector.y0 = y0 + (rd * 1.4 * Math.Sin(t));
                            vector.color = Color.OrangeRed;
                            vector.encender(bmp);
                            t = t + dt;
                        } while (t <= 2 * Math.PI);

                        cSegmento sg1 = new cSegmento();
                        do
                        {
                            sg1.x0 = x0 - rd;
                            sg1.y0 = y0;
                            sg1.Xf = x0 + rd;
                            sg1.Yf = y0;
                            sg1.encender(bmp);
                            t = t + dt;
                        } while (t <= 1);
                    }
                    break;
                case 1:
                    {

                       cVector v = new cVector();
                       double t1 = Math.PI / 4;


                        do
                        {
                            v.x0 = x0 + (rd * Math.Cos(t1));
                            v.y0 = y0 + (rd * Math.Sin(t1));
                            v.color = Color.Black;
                            v.encender(bmp);
                            t1 = t1 + dt;
                        } while (t1 <= 7 * (Math.PI / 4));

                        cSegmento oSegmento = new cSegmento();
                        oSegmento.color = Color.Black;
                        oSegmento.x0 = 1.4;
                        oSegmento.y0 = 4.5;
                        oSegmento.Xf = 1.4;
                        oSegmento.Yf = -2;
                        oSegmento.encender(bmp);
                    }
                    break;
            }
            }
        }
    }
