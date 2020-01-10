using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appCompuGrafica
{
    class cCuadrado3d:cSegmento3d
    {
        public double x1, x2, x3;
        public double y1, y2, y3;
        public double z1, z2, z3;
        public Color colorR;

        public cCuadrado3d() { }
        ~cCuadrado3d() { }


        public void encenderCuadrilatero(Bitmap bmp)
        {
            dibujarSegmento(x0, y0, z0, x1, y1, z1, bmp);
            dibujarSegmento(x1, y1, z1, x2, y2, z2, bmp);
            dibujarSegmento(x2, y2, z2, x3, y3, z3, bmp);
            dibujarSegmento(x3, y3, z3, x0, y0, z0, bmp);
        }

        public void encenderCubo(double lx, double ly, double lz,Bitmap bmp)
        {
            x1 = x2 = x3 = x0 ;
            y1 = y0 + ly;
            z1 = z0 ;

            y2 = y0 + ly;
            z2 = z0 + lz;

            y3 = y0;
            z3 = z3 + lz;
            encenderCuadrilatero(bmp);

            x1 = x1 - lx;
            y1 = y1 - ly;

            x2 = x2 - lx;
            y2 = y2 - ly;
            encenderCuadrilatero(bmp);

            x0 = x0 - lx;
            y0 = y0 + ly;

            x3 = x3 - lx;
            y3 = y3 + ly;
            encenderCuadrilatero(bmp);

            x1 = x0 + lx;
            y1 = y1 + ly ;

            x2 = x0 + lx;
            y2 = y2 + ly;
            encenderCuadrilatero(bmp);
        }

        public void dibujarSegmento(double X0, double Y0, double Z0, double Xf, double Yf, double Zf, Bitmap bmp)
        {
            cSegmento3d oSegmento = new cSegmento3d();
            oSegmento.color = color;
            oSegmento.x0 = X0;
            oSegmento.y0 = Y0;
            oSegmento.z0 = Z0;
            oSegmento.xf = Xf;
            oSegmento.yf = Yf;
            oSegmento.zf = Zf;
            oSegmento.encender(bmp);
        }

        public void rellenarCuadrilatero(Bitmap bmp)
        {
            cBase oBase = new cBase();
            cVector3d oV3d = new cVector3d();
            double ax, ay;
            int qx, qy;

            Graphics g = Graphics.FromImage(bmp);
            Pen rPen = new Pen(color,3);
            SolidBrush pen2 = new SolidBrush(color);

            PointF[] capPolygon = new PointF[4];

            hallarPunto(x0, y0, z0,0,capPolygon);
            hallarPunto(x1, y1, z1, 1, capPolygon);
            hallarPunto(x2, y2, z2, 2, capPolygon);
            hallarPunto(x3, y3, z3, 3, capPolygon);


            g.DrawPolygon(rPen, capPolygon);
            g.FillPolygon(pen2, capPolygon);
            bmp = new Bitmap(600, 440, g);
        }

        public void rellenarCuadrilatero2(Bitmap bmp)
        {
            cBase oBase = new cBase();
            cVector3d oV3d = new cVector3d();
            double ax, ay;
            int qx, qy;

            Graphics g = Graphics.FromImage(bmp);
            Pen rPen = new Pen(color, 3);
            SolidBrush pen2 = new SolidBrush(color);

            PointF[] capPolygon = new PointF[4];
            capPolygon[0] = new PointF((float)x0,(float)y0);
            capPolygon[1] = new PointF((float)x1, (float)y1);
            capPolygon[2] = new PointF((float)x2, (float)y2);
            capPolygon[3] = new PointF((float)x3, (float)y3);

            g.DrawPolygon(rPen, capPolygon);
            g.FillPolygon(pen2, capPolygon);
            bmp = new Bitmap(600, 440, g);
        }

        public void hallarPunto(double X0, double Y0, double Z0, int i, PointF[] puntos)
        {
            double ax, ay;
            int qx, qy;
            cBase oBase = new cBase();
            cVector3d oV3d = new cVector3d();

            oV3d.x0 = X0;
            oV3d.z0 = Y0;
            oV3d.y0 = Z0;
            oV3d.axonometria(oV3d.x0, oV3d.y0, oV3d.z0, out ax, out ay);
            oBase.pantalla(ax, ay, out qx, out qy);
            puntos[i] = new PointF(qx, qy);
        }

    }
}
