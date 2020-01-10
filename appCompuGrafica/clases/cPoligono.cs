using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appCompuGrafica
{
    class cPoligono:cCircunferencia3d
    {
        public int Nl;
        public double alto = 0;
        public double factor = 0;
        public double Alfa = Math.PI / 2;
        public Bitmap lienzo = new Bitmap(600, 460);
        public double delta = 0;
        cVector3d v = new cVector3d();

        double[] vX = new double[15];
        double[] vY = new double[15];

        double[] vXF = new double[15];
        double[] vYF = new double[15];

        public cPoligono() { }

        ~cPoligono() { }

        public void encender(Bitmap bmp)
        {

            double Alfa, Beta;
            Alfa = Math.PI / 2;
            Beta = 2 * Math.PI / Nl;
            //Beta = 2 * Math.PI / Nl;
            //Alfa = 0;

            cSegmento3d oS = new cSegmento3d();
            //cSegmento oS = new cSegmento();
            oS.z0 = oS.zf = z0;
            oS.color = color;

            for (int i= 0; i< Nl; i++)
            {
                vX[i] = x0 + rd * Math.Cos(Alfa);
                vY[i] = y0 + rd * Math.Sin(Alfa);

                oS.x0 = x0 + rd * Math.Cos(Alfa);
                oS.y0 = y0 + rd * Math.Sin(Alfa);
                oS.xf = x0 + rd * Math.Cos(Beta + Alfa);
                oS.yf = y0 + rd * Math.Sin(Beta + Alfa);
                oS.encender(bmp);
                Alfa += Beta;
            }

            //oS.color = Color.Black;
            //int k = 0;
            //oS.xf = vX[0];
            //oS.yf = vY[0];

            //for (int i=0; i < Nl; i++)
            //{
            //    oS.x0 = oS.xf;
            //    oS.y0 = oS.yf;
            //    k += 2;
            //    if (k > Nl)
            //    {
            //        k = 1;
            //        i--;
            //    }
            //    oS.xf = vX[k];
            //    oS.yf = vY[k];
            //    oS.encender(bmp);
            //}

            //oS.x0 = vX[0];
            //oS.y0 = vY[0];
            //oS.Xf = vX[2];
            //oS.Yf = vY[2];
            //oS.encender(bmp);

            //oS.x0 = oS.Xf;
            //oS.y0 = oS.Yf;
            //oS.Xf = vX[4];
            //oS.Yf = vY[4];
            //oS.encender(bmp);

            //oS.x0 = oS.Xf;
            //oS.y0 = oS.Yf;
            //oS.Xf = vX[1];
            //oS.Yf = vY[1];
            //oS.encender(bmp);

            //oS.x0 = oS.Xf;
            //oS.y0 = oS.Yf;
            //oS.Xf = vX[3];
            //oS.Yf = vY[3];
            //oS.encender(bmp);

            //oS.x0 = oS.Xf;
            //oS.y0 = oS.Yf;
            //oS.Xf = vX[5];
            //oS.Yf = vY[5];
            //oS.encender(bmp);
            //MessageBox.Show("Hola");
        }

        public void encnderPoliedro3d(Bitmap bmp)
        {
            cSegmento3d S3D = new cSegmento3d();
            cSegmento3d nSeg = new cSegmento3d();
            nSeg.color = color;
            double gama, beta;

            gama = 2 * Math.PI / Nl;
            beta = 0;

            for (int i = 0; i < Nl; i++)
            {
                nSeg.color = color;
                S3D.x0 = x0 + rd * Math.Cos(beta);
                S3D.y0 = y0 + rd * Math.Sin(beta);
                S3D.z0 = z0;
                S3D.xf = x0 + rd * Math.Cos(beta + gama);
                S3D.yf = y0 + rd * Math.Sin(beta + gama);
                S3D.zf = z0;
                //S3D.color = Color.Green;
                //S3D.encender(bmp);

                rotar3d(bmp, S3D.x0, S3D.y0, S3D.z0, Alfa + factor, eje0, out nSeg.x0, out nSeg.y0, out nSeg.z0);
                rotar3d(bmp, S3D.xf, S3D.yf, S3D.zf, Alfa + factor, eje0, out nSeg.xf, out nSeg.yf, out nSeg.zf);
                nSeg.encender(bmp);

                S3D.z0 = z0 + alto;
                S3D.zf = z0 + alto;
                //S3D.color = Color.Red;
                //S3D.encender(bmp);

                rotar3d(bmp, S3D.x0, S3D.y0, S3D.z0, Alfa + factor, eje0, out nSeg.x0, out nSeg.y0, out nSeg.z0);
                rotar3d(bmp, S3D.xf, S3D.yf, S3D.zf, Alfa + factor, eje0, out nSeg.xf, out nSeg.yf, out nSeg.zf);
                nSeg.encender(bmp);

                S3D.xf = S3D.x0;
                S3D.yf = S3D.y0;
                S3D.zf = S3D.z0 - alto;
                //S3D.encender(bmp);

                //nSeg.color = Color.Red;
                rotar3d(bmp, S3D.x0, S3D.y0, S3D.z0, Alfa + factor, eje0, out nSeg.x0, out nSeg.y0, out nSeg.z0);
                rotar3d(bmp, S3D.xf, S3D.yf, S3D.zf, Alfa + factor, eje0, out nSeg.xf, out nSeg.yf, out nSeg.zf);
                if (i == 0) nSeg.color = Color.White;
                nSeg.encender(bmp);
                beta = beta + gama;
            }
        }

        public void encenderPoliedro(Bitmap bmp)
        {
            double Alfa, Beta;
            Alfa = Math.PI / 2;
            Beta = 2 * Math.PI / Nl;

            cSegmento3d oS = new cSegmento3d();
            cSegmento3d oS2 = new cSegmento3d();
            cVector3d oV1 =new cVector3d();
            cSegmento3d recta = new cSegmento3d();
            //cSegmento oS = new cSegmento();
            //oS.z0 = oS.zf = z0;
            oS.color = recta.color = color;
            for (int i = 0; i < Nl; i++)
            {
                oS.z0 = oS.zf = z0;
                oS.x0 = x0 + rd * Math.Cos(Alfa);
                oS.y0 = y0 + rd * Math.Sin(Alfa);
                oS.xf = x0 + rd * Math.Cos(Beta + Alfa);
                oS.yf = y0 + rd * Math.Sin(Beta + Alfa);
                oS.rotar3d(bmp, oS.x0, oS.y0, oS.z0, Alfa + factor, 0, out oS2.x0, out oS2.y0, out oS2.z0);
                oS.encender(bmp);
                oS.z0 = oS.zf = z0 + alto;
                oS.encender(bmp);

                oS.rotar3d(bmp, oS.xf, oS.yf, oS.zf, Alfa + factor, 0, out oS2.xf, out oS2.yf, out oS2.zf);

                Alfa += Beta;

                recta.x0 = recta.xf = oS.x0;
                recta.y0 = recta.yf = oS.y0;
                recta.z0 = z0;
                recta.zf = z0 + alto;
                recta.encender(bmp);
            }
        }

        public void encenderPiramide(Bitmap bmp)
        {
            cSegmento3d S3D = new cSegmento3d();
            cSegmento3d nSeg = new cSegmento3d();
            nSeg.color = color;
            double gama, beta;

            gama = 2 * Math.PI / Nl;
            beta = 0;

            for (int i = 0; i < Nl; i++)
            {
                nSeg.color = color;
                S3D.x0 = x0 + rd * Math.Cos(beta);
                S3D.y0 = y0 + rd * Math.Sin(beta);
                S3D.xf = x0 + rd * Math.Cos(beta + gama);
                S3D.yf = y0 + rd * Math.Sin(beta + gama);
                //S3D.color = Color.Green;
                //S3D.encender(bmp);

                S3D.z0 = z0 + alto;
                S3D.zf = z0 + alto;
                //nSeg.color = Color.Red;

                rotar3d(bmp, S3D.x0, S3D.y0, S3D.z0, Alfa + factor, eje0, out nSeg.x0, out nSeg.y0, out nSeg.z0);
                rotar3d(bmp, S3D.xf, S3D.yf, S3D.zf, Alfa + factor, eje0, out nSeg.xf, out nSeg.yf, out nSeg.zf);
                nSeg.encender(bmp);

                S3D.x0 = x0;
                S3D.y0 = y0-2;
                S3D.z0 = z0;
                //S3D.encender(bmp);
                //nSeg.color = Color.Red;
                rotar3d(bmp, S3D.x0, S3D.y0, S3D.z0, Alfa + factor, eje0, out nSeg.xf, out nSeg.yf, out nSeg.zf);
                rotar3d(bmp, S3D.xf, S3D.yf, S3D.zf, Alfa + factor, eje0, out nSeg.x0, out nSeg.y0, out nSeg.z0);
                if (i == 0) nSeg.color = Color.White;
                nSeg.encender(bmp);
                beta = beta + gama;
            }
        }

        public void encenderPoliedro(Bitmap bmp, Color colorp,int eje, int nlados, double x, double y, double z, double radio, double altura)
        {
            x0 = x;
            y0 = y;
            z0 = z;
            eje0 = eje;
            rd = radio;
            Nl = nlados;
            alto = altura;
            color = colorp;
            encnderPoliedro3d(bmp);
        }

        public void encenderPoliedroAn(Bitmap bmp, Color colorp, int eje, int nlados, double x, double y, double z, double radio, double altura)
        {
            cCircunferencia3d v = new cCircunferencia3d() ;
            v.color = color;
            v.rd = 6;
            //delta += 0.2;
            Alfa += 0.2;

            v.x0 = x + 5 * Math.Cos(delta);
            v.y0 = y + 5 * Math.Sin(delta);
            v.z0 = z - 0;
            v.alfa = Alfa;
            //v.encender(bmp);

            x0 = v.x0-2;
            y0 = v.y0;
            z0 = v.z0-2;
            eje0 = 2;
            rd = radio;
            Nl = nlados;
            alto = altura;
            color = colorp;
            encnderPoliedro3d(bmp);
        }

        public void encenderPiramideAn(Bitmap bmp, Color colorp, int eje, int nlados, double x, double y, double z, double radio, double altura)
        {
            cCircunferencia3d v = new cCircunferencia3d();
            cCircunferencia vsol = new cCircunferencia();
            v.color = color;
            vsol.color = Color.Yellow;
            vsol.rd = 1;
            v.rd = 6;
            //delta += 0.2;
            //Alfa += 0.5;

            v.x0 = x0 + 6 * Math.Cos(delta);
            vsol.x0 = 0;
            vsol.y0 = -1;
            v.y0 = y0 + 6 * Math.Sin(delta);
            v.z0 = z - 0;
            v.alfa = Alfa;
            vsol.encender(bmp);
            v.encender(bmp);

            x0 = v.x0 ;
            y0 = v.y0 ;
            z0 = v.z0 ;
            eje0 = 2;
            rd = radio;
            Nl = nlados;
            alto = altura;
            color = colorp;
            encenderPiramide(bmp);
        }

        public void encenderPiramide(Bitmap bmp, Color colorp, int eje, int nlados, double x, double y, double z, double radio, double altura)
        {
            x0 = x;
            y0 = y;
            z0 = z;
            eje0 = eje;
            rd = radio;
            Nl = nlados;
            alto = altura;
            color = colorp;
            encenderPiramide(bmp);
        }

        public void Rotar3D(double vx, double vy, double vz, double beta, int eje, out double wx, out double wy, out double wz)
        {
            wx = 0;
            wy = 0;
            wz = 0;

            if (eje == 1)
            {  //eje x
                wx = vx;
                wy = vy * Math.Cos(beta) - vz * Math.Sin(beta);
                wz = vy * Math.Sin(beta) + vz * Math.Cos(beta);
            }
            if (eje == 0)
            {
                wx = vx * Math.Cos(beta) + vz * Math.Sin(beta);
                wy = vy;
                wz = -vx * Math.Sin(beta) + vz * Math.Cos(beta);
            }
            if (eje == 2)
            {
                wx = vx * Math.Cos(beta) - vy * Math.Sin(beta);
                wy = vx * Math.Sin(beta) + vy * Math.Cos(beta);
                wz = vz;
            }
        }

        public void encenderRadios(Bitmap bmp)
        {

            double Alfa, Beta;
            Double xi0, yi0, xf0, yf0;
            Alfa = Math.PI / 2;
            Beta = 2 * Math.PI / Nl;
            
            cSegmento oS = new cSegmento();
            cSegmento oR = new cSegmento();
            for (int i = 1; i <= Nl; i++)
            {
                oS.color = Color.Blue;
                oS.x0 = x0 + rd * Math.Cos(Alfa);
                oS.y0 = y0 + rd * Math.Sin(Alfa);
                oS.Xf = x0 + rd * Math.Cos(Beta + Alfa);
                oS.Yf = y0 + rd * Math.Sin(Beta + Alfa);
                oR.x0 = x0;
                oR.y0 = y0;
                oR.Xf = x0 + rd * Math.Cos(Alfa);
                oR.Yf = y0 + rd * Math.Sin(Alfa);
                oR.color = Color.Black;
                //oR.encender(bmp);
                oS.encender(bmp);
                Alfa += Beta;
            }
        }
    }
}




