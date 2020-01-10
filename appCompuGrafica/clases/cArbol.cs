using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace appCompuGrafica
{
    class cArbol : cSegmento
    {
        public List<cSegmento> segmentos = new List<cSegmento>();
        public double x1, x2, x3, y1, y2, y3;
        public cArbol() { }
        ~cArbol() { }

        public void encenderSegmentos(Bitmap bmp)
        {
            cSegmento oSegmento = new cSegmento();

            //cSegmento s = new cSegmento();

            foreach (cSegmento s in segmentos)
            {
                s.x0 += 2;
                s.Xf += 2;
                s.color = Color.Green;
                s.encender(bmp);
            }

        }

        public void encenderCuadrilatero(Bitmap bmp)
        {
            cBase oBase = new cBase();
            cVector oVec = new cVector();
            int qx, qy;

            Graphics g = Graphics.FromImage(bmp);
            Pen rPen = new Pen(color, (float)0.1);
            SolidBrush pen2 = new SolidBrush(color);

            PointF[] capPolygon = new PointF[4];
            oBase.pantalla(x0, y0, out qx, out qy);
            capPolygon[0] = new PointF((float)qx, (float)qy);
            oBase.pantalla(x1, y1, out qx, out qy);
            capPolygon[1] = new PointF((float)qx, (float)qy);
            oBase.pantalla(x2, y2, out qx, out qy);
            capPolygon[2] = new PointF((float)qx, (float)qy);
            oBase.pantalla(x3, y3, out qx, out qy);
            capPolygon[3] = new PointF((float)qx, (float)qy);

            g.DrawPolygon(rPen, capPolygon);
            //g.FillPolygon(pen2, capPolygon);
            Bitmap bmp2 = new Bitmap(600, 440, g);
            bmp = bmp2;
            g.Dispose();
            bmp2.Dispose();
        }

        public void rellenarCuadrilatero(Bitmap bmp, Color relleno)
        {
            cBase oBase = new cBase();
            cVector oVec = new cVector();
            int qx, qy;

            Graphics g = Graphics.FromImage(bmp);
            Pen rPen = new Pen(color, (float)2);
            SolidBrush pen2 = new SolidBrush(relleno);

            PointF[] capPolygon = new PointF[4];
            oBase.pantalla(x0, y0, out qx, out qy);
            capPolygon[0] = new PointF((float)qx, (float)qy);
            oBase.pantalla(x1, y1, out qx, out qy);
            capPolygon[1] = new PointF((float)qx, (float)qy);
            oBase.pantalla(x3, y3, out qx, out qy);
            capPolygon[2] = new PointF((float)qx, (float)qy);
            oBase.pantalla(x2, y2, out qx, out qy);
            capPolygon[3] = new PointF((float)qx, (float)qy);

            g.DrawPolygon(rPen, capPolygon);
            g.FillPolygon(pen2, capPolygon);
            Bitmap bmp2 = new Bitmap(600, 440, g);
            bmp = bmp2;
            g.Dispose();
            bmp2.Dispose();
        }

        public void encenderComponentes(Bitmap bmp)
        {
            cSegmento oSegmento = new cSegmento();

            cSegmento s = new cSegmento();

            oSegmento.color = color;
            oSegmento.x0 = x0;
            oSegmento.y0 = y0;
            oSegmento.Xf = Xf;
            oSegmento.Yf = Yf;
            oSegmento.encender(bmp);

            oSegmento.color = Color.Violet;
            oSegmento.x0 = x0;
            oSegmento.y0 = y0;
            oSegmento.Xf = x0;
            oSegmento.Yf = Yf;

            oSegmento.cortada(bmp, 0.02);

            oSegmento.x0 = x0;
            oSegmento.y0 = y0;
            oSegmento.Xf = Xf;
            oSegmento.Yf = y0;
            oSegmento.cortada(bmp, 0.02);

            oSegmento.x0 = Xf;
            oSegmento.y0 = y0;
            oSegmento.Xf = Xf;
            oSegmento.Yf = Yf;
            oSegmento.cortada(bmp, 0.02);

            oSegmento.x0 = x0;
            oSegmento.y0 = Yf;
            oSegmento.Xf = Xf;
            oSegmento.Yf = Yf;
            oSegmento.cortada(bmp, 0.02);
        }
    }
}
