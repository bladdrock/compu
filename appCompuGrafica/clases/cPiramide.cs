using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appCompuGrafica
{
    class cPiramide:cCircunferencia3d
    {
        public int numLados;
        public double altura;
        public double teta;
        public double b;
        public void  encender(Bitmap lienzo)
        {  ///codigo para el poligono
            double beta = (Math.PI * 2) / numLados;  //toda la circunferencia lo vamos a dividir para los lados
            double alfa = 0;

            cSegmento3d s = new cSegmento3d();
            cSegmento3d t = new cSegmento3d();
            cVector3d w = new cVector3d();
           
            t.x0 = x0;
            t.y0 = y0;
            t.z0 = z0 + altura;
          
            for (int i = 1; i <= numLados; i++)
            {
                s.color = color;
                t.color = color;
                w.color = color;

                s.x0 = x0 + rd * Math.Cos(alfa);
                s.y0 = y0 + rd * Math.Sin(alfa);
                s.z0 = z0;
                s.color = Color.Red;
                alfa = alfa + beta;
                s.xf = x0 + rd * Math.Cos(alfa);
                s.yf = y0 + rd * Math.Sin(alfa);
                s.zf = z0;
               // s.Color0 = Color0;
                s.encender(lienzo);
                t.xf = s.xf; ///tmb puedo coger el punto final s.xf
                t.yf = s.yf;  ///tmb puedo coger el punto final s.yf
                t.zf = s.zf;  ///tmb puedo coger el punto final s.xf
                t.encender(lienzo);
                w.rotar3d(lienzo,t.xf, t.yf, t.zf, teta,1,out w.x0, out w.y0, out w.z0);  // beta  
                //w.x0 = w.rx;
                //w.y0 = w.ry;
                //w.z0 = w.rz;
                w.encender(lienzo);

            }
            
        }

        public void encender2(Bitmap lienzo)
        {  ///codigo para el poligono
            double beta = (Math.PI * 2) / numLados;  //toda la circunferencia lo vamos a dividir para los lados
            double alfa = 0;

            cSegmento3d p1 = new cSegmento3d();
            cSegmento3d p2 = new cSegmento3d();
            cSegmento3d lado = new cSegmento3d();
            cVector3d w = new cVector3d();

            for (int i = 1; i <= numLados; i++)
            {
                p1.color = color;
                lado.color = color;
                p2.color = color;

                p1.x0 = x0 + rd * Math.Cos(alfa);
                p1.y0 = y0 + rd * Math.Sin(alfa);
                p1.z0 = z0;
                p2.x0 = x0 + ( rd/2) * Math.Cos(alfa);
                p2.y0 = y0 + ( rd/2) * Math.Sin(alfa);
                p2.z0 = z0 + altura;
                //s.color = Color.Red;
                alfa = alfa + beta;
                p1.xf = x0 + rd * Math.Cos(alfa);
                p1.yf = y0 + rd * Math.Sin(alfa);
                p1.zf = z0;
                p2.xf = x0 + (rd / 2) * Math.Cos(alfa);
                p2.yf = y0 + (rd / 2) * Math.Sin(alfa);
                p2.zf = z0 + altura;
                // s.Color0 = Color0;
                p1.encender(lienzo);
                p2.encender(lienzo);
                p2.x0 = p1.xf;
                p2.y0 = p1.yf;
                p2.z0 = p1.zf;
                p2.encender(lienzo);
                //w.rotar3d(lienzo, t.xf, t.yf, t.zf, teta, 1, out w.x0, out w.y0, out w.z0);  // beta  
                //w.x0 = w.rx;
                //w.y0 = w.ry;
                //w.z0 = w.rz;
                //w.encender(lienzo);

            }

        }

    }
}
