using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace appCompuGrafica
{
    class cCuadrado:cSegmento
    {
        public double x1, x2, x3;
        public double y1, y2, y3;
        public Color colorRelleno;

        public cCuadrado() { }
        ~cCuadrado() { }

        public void encenderCuadrado(Bitmap bmp)
        {
            cSegmento oSegmento = new cSegmento();

            cSegmento s = new cSegmento();

            oSegmento.color = color;
            oSegmento.x0 = x0;
            oSegmento.y0 = y0;
            oSegmento.Xf = x1;
            oSegmento.Yf = y0;
            oSegmento.encender(bmp);

            oSegmento.color = color;
            oSegmento.x0 = x1;
            oSegmento.y0 = y1;
            oSegmento.Xf = x1;
            oSegmento.Yf = y3;
            oSegmento.encender(bmp);

            oSegmento.x0 = x3;
            oSegmento.y0 = y3;
            oSegmento.Xf = x2;
            oSegmento.Yf = y3;
            oSegmento.encender(bmp);

            oSegmento.x0 = x2;
            oSegmento.y0 = y2;
            oSegmento.Xf = x2;
            oSegmento.Yf = y0;
            oSegmento.encender(bmp);
        }

        public void encenderCuadrilatero(Bitmap bmp)
        {
            cBase oBase = new cBase();
            cVector oVec = new cVector();
            int qx, qy;

            //cCircunferencia circulo = new cCircunferencia();
            //circulo.rd = 3;
            //circulo.x0 = circulo.y0 = 0;
            //circulo.color = Color.Green;
            //circulo.encender(bmp);
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
            //Bitmap bmp2 = new Bitmap(600, 440, g);
            //bmp = bmp2;
            g.Dispose();
            //bmp2.Dispose();
        }

        public void rellenarCuadrilatero(Bitmap bmp,  Color relleno)
        {
            cBase oBase = new cBase();
            cVector oVec = new cVector();
            int qx, qy;

            Graphics g = Graphics.FromImage(bmp);
            Pen rPen = new Pen(color, (float)0.1);
            SolidBrush pen2 = new SolidBrush(relleno);

            PointF[] capPolygon = new PointF[4];
            oBase.pantalla(x0, y0, out qx, out qy);
            capPolygon[0] = new PointF((float)qx, (float)qy);
            oBase.pantalla(x1, y1, out qx, out qy);
            capPolygon[1] = new PointF((float)qx, (float)qy);
            oBase.pantalla(x2, y2, out qx, out qy);
            capPolygon[2] = new PointF((float)qx, (float)qy);
            oBase.pantalla(x3, y3, out qx, out qy);
            capPolygon[3] = new PointF((float)qx, (float)qy);

            //g.DrawPolygon(rPen, capPolygon);
            g.FillPolygon(pen2, capPolygon);
            //Bitmap bmp2 = new Bitmap(600, 440, g);
            //bmp = bmp2;
            g.Dispose();
            //bmp2.Dispose();
        }

        public Bitmap rellenarCuadrilateroTapete(Bitmap tapete, Bitmap lienzo, Color relleno)
        {
            cBase oBase = new cBase();
            cVector oVec = new cVector();
            int qx, qy;
            Bitmap bmp2 = new Bitmap(600,440);


            Graphics g = Graphics.FromImage(lienzo);
            Pen rPen = new Pen(relleno, (float)0.1);
            SolidBrush pen2 = new SolidBrush(relleno);

            cCircunferencia punto = new cCircunferencia();
            punto.color = Color.Red; punto.rd = 0.2;

            PointF[] capPolygon = new PointF[4];
            oBase.pantalla(x0, y0, out qx, out qy);
            capPolygon[0] = new PointF((float)qx, (float)qy);

            oBase.pantalla(x1, y1, out qx, out qy);
            capPolygon[1] = new PointF((float)qx, (float)qy);
            oBase.pantalla(x2, y2, out qx, out qy);
            capPolygon[2] = new PointF((float)qx, (float)qy);
            oBase.pantalla(x3, y3, out qx, out qy);
            capPolygon[3] = new PointF((float)qx, (float)qy);

            TextureBrush tb = new TextureBrush(tapete);

            g.FillPolygon(tb, capPolygon);
            g.DrawPolygon(rPen, capPolygon);
            //bmp2 = new Bitmap(600, 440, g);
            return lienzo;
            //g.Dispose();
            //bmp2.Dispose();
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

            oSegmento.cortada(bmp,0.02);

            oSegmento.x0 = x0;
            oSegmento.y0 = y0;
            oSegmento.Xf = Xf;
            oSegmento.Yf = y0;
            oSegmento.cortada(bmp,0.02);

            oSegmento.x0 = Xf;
            oSegmento.y0 = y0;
            oSegmento.Xf = Xf;
            oSegmento.Yf = Yf;
            oSegmento.cortada(bmp,0.02);

            oSegmento.x0 = x0;
            oSegmento.y0 = Yf;
            oSegmento.Xf = Xf;
            oSegmento.Yf = Yf;
            oSegmento.cortada(bmp,0.02);
        }
    }
}
