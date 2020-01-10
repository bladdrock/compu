using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelNuevoCGWF
{
    class Poliedro:Poligono
    {
        public double altura { set; get; }
        public double Z0 { set; get; }
        public double gama { set; get; }
        public int eje { set; get; }
        public Poliedro(double x0, double y0, double z0, double rd, int nl, double altura, double gama,int eje, Color color0, Bitmap imprimir, PictureBox viewpoint) : base(x0, y0, rd, nl, color0, imprimir, viewpoint)
        {
            this.X0 = x0;
            this.Y0 = y0;
            this.Z0 = z0;
            this.Rd = rd;
            this.altura = altura;
            this.gama = gama;
            this.eje = eje;
            this.NL = nl;
            this.Color0 = color0;
            this.Imprimir = imprimir;
            this.Viewpoint = viewpoint;
        }

        ~Poliedro() { }

        public override void Encender()
        {
            double A, B,aux,aux2;
            B = (2 * Math.PI) / NL;
            A = Math.PI / 2;
            Segmento3D s = new Segmento3D(0, 0, 0, 1,1,1, Color0, Imprimir, Viewpoint);
            for (int j = 0; j < NL; j++)
            {
                s.X0 = X0 + Rd * Math.Cos(A);
                s.Y0 = Y0 + Rd * Math.Sin(A);
                s.Z0 = Z0;
                s.Xf = X0 + Rd * Math.Cos(A + B);
                s.Yf = Y0 + Rd * Math.Sin(A + B);
                s.Zf = Z0;
                aux = s.Zf;
                s.Encender();
                s.Z0 = Z0 + altura;
                s.Zf = Z0 + altura;
                aux2 = s.Zf;
                s.Encender();
                Segmento3D s1 = new Segmento3D(s.X0, s.Y0, aux, s.X0, s.Y0,aux2, Color0, Imprimir, Viewpoint);
                s1.Encender();
                A = A + B;
            }
        }

        public void Rotacion3D(double Vx, double Vy, double Vz, double gama, int eje, out double Wx, out double Wy, out double Wz)
        {
            Wx = Vx;
            Wy = Vy;
            Wz = Vz;
            if (eje == 0) //Eje X
            {
                Wx = Vx;
                Wy = Vy * Math.Cos(gama) - Vz * Math.Sin(gama);
                Wz = Vy * Math.Sin(gama) + Vz * Math.Cos(gama);
            }
            if (eje == 1) //Eje Y
            {
                Wx = Vx * Math.Cos(gama) + Vz * Math.Sin(gama);
                Wy = Vy;
                Wz = (Vz * Math.Cos(gama)) - (Vx * Math.Sin(gama));
            }
            if (eje == 2) //Eje Z
            {
                Wx = Vx * Math.Cos(gama) - Vy * Math.Sin(gama);
                Wy = Vx * Math.Sin(gama) + Vy * Math.Cos(gama);
                Wz = Vz;
            }
        }

        public void RotarEncender()
        {
            double A, B;
            B = (2 * Math.PI) / NL;
            A = Math.PI / 2;
            Segmento3D s = new Segmento3D(0, 0, 0, 0,0,0, Color0, Imprimir, Viewpoint);
            Segmento3D ws = new Segmento3D(0, 0, 0, 0, 0 ,0, Color0, Imprimir, Viewpoint);
            double z0aux = s.Z0;
            double zfaux = s.Zf;
            for (int j = 0; j < NL; j++)
            {
                s.X0 = X0 + Rd * Math.Cos(A);
                s.Y0 = Y0 + Rd * Math.Sin(A);
                s.Z0 = z0aux;
                s.Xf = X0 + Rd * Math.Cos(A + B);
                s.Yf = Y0 + Rd * Math.Sin(A + B);
                s.Zf = zfaux;
                //s.Encender();
                double wx0, wy0, wz0, wxf, wyf, wzf;
                Rotacion3D(s.X0, s.Y0, s.Z0, gama, eje, out wx0, out wy0, out wz0);
                ws.X0 = wx0;
                ws.Y0 = wy0;
                ws.Z0 = wz0;
                Rotacion3D(s.Xf, s.Yf, s.Zf, gama, eje, out wxf, out wyf, out wzf);
                ws.Xf = wxf;
                ws.Yf = wyf;
                ws.Zf = wzf;
                ws.Encender();

                s.Z0 += altura;
                s.Zf += altura;
                //s.Encender();
                Rotacion3D(s.X0, s.Y0, s.Z0, gama, eje, out wx0, out wy0, out wz0);
                ws.X0 = wx0;
                ws.Y0 = wy0;
                ws.Z0 = wz0;
                Rotacion3D(s.Xf, s.Yf, s.Zf, gama, eje, out wxf, out wyf, out wzf);
                ws.Xf = wxf;
                ws.Yf = wyf;
                ws.Zf = wzf;
                ws.Encender();

                Segmento3D s1 = new Segmento3D(0,0,0,0,0,0, Color0, Imprimir, Viewpoint);
                s1.X0 = s.X0;
                s1.Xf = s.X0;
                s1.Y0 = s.Y0;
                s1.Yf = s.Y0;
                s1.Z0 = z0aux;
                s1.Zf = s.Zf;
                Rotacion3D(s1.X0, s1.Y0, s1.Z0, gama, eje, out wx0, out wy0, out wz0);
                ws.X0 = wx0;
                ws.Y0 = wy0;
                ws.Z0 = wz0;
                Rotacion3D(s1.Xf, s1.Yf, s1.Zf, gama, eje, out wxf, out wyf, out wzf);
                ws.Xf = wxf;
                ws.Yf = wyf;
                ws.Zf = wzf;
                ws.Encender();
                A = A + B;
            }
        }

        public void EncenderPiramide(double t)
        {
            double A, B;
            B = (2 * Math.PI) / NL;
            A = Math.PI / 2;
            Segmento3D piram = new Segmento3D(X0, Y0, Z0, X0, Y0, Z0, Color0, Imprimir, Viewpoint);
            Segmento3D ws = new Segmento3D(X0, Y0, Z0, X0, Y0, Z0, Color0, Imprimir, Viewpoint);
            double z0aux = piram.Z0;
            double zfaux = piram.Zf;
            for (int j = 0; j < NL; j++)
            {
                piram.X0 = X0 + Rd * Math.Cos(A);
                piram.Y0 = Y0 + Rd * Math.Sin(A);
                piram.Z0 = z0aux;
                piram.Xf = X0 + Rd * Math.Cos(A + B);
                piram.Yf = Y0 + Rd * Math.Sin(A + B);
                piram.Zf = zfaux;
                //s.Encender();
                double wx0, wy0, wz0, wxf, wyf, wzf;
                Rotacion2(X0, Y0, Z0, piram.X0, piram.Y0, piram.Z0, gama, eje, out wx0, out wy0, out wz0);
                ws.X0 = wx0;
                ws.Y0 = wy0;
                ws.Z0 = wz0;
                Rotacion2(X0, Y0, Z0, piram.Xf, piram.Yf, piram.Zf, gama, eje, out wxf, out wyf, out wzf);
                ws.Xf = wxf;
                ws.Yf = wyf;
                ws.Zf = wzf;
                ws.Encender();

                Segmento3D s1 = new Segmento3D(X0, Y0, Z0, X0, Y0, Z0, Color0, Imprimir, Viewpoint);
                s1.X0 = piram.X0;
                s1.Xf = X0;
                s1.Y0 = piram.Y0;
                s1.Yf = Y0;
                s1.Z0 = piram.Z0;
                s1.Zf = -altura;
                Rotacion2(X0, Y0, Z0, s1.X0, s1.Y0, s1.Z0, gama, eje, out wx0, out wy0, out wz0);
                s1.X0 = wx0;
                s1.Y0 = wy0;
                s1.Z0 = wz0;
                s1.Encender();
                A = A + B;
            }
        }

        //Rotacion con respecto acualquier eje
        public void Rotacion2(double x, double y, double z, double Vx, double Vy, double Vz, double Gama, int eje, out double Wx, out double Wy, out double Wz)
        {
            Wx = Vx;
            Wy = Vy;
            Wz = Vz;
            if (eje == 0) //eje X
            {
                Wx = Vx;
                Wy = ((Vy - y) * Math.Cos(Gama)) - ((Vz - z) * Math.Sin(Gama)) + y;
                Wz = ((Vy - y) * Math.Sin(Gama)) + ((Vz - z) * Math.Cos(Gama)) + z;
            }
            if (eje == 1) //eje Y
            {
                Wx = ((Vx - x) * Math.Cos(Gama)) + ((Vz - z) * Math.Sin(Gama)) + x;
                Wy = Vy;
                Wz = -((Vx - x) * Math.Sin(Gama)) + ((Vz - z) * Math.Cos(Gama)) + z;
            }
            if (eje == 2) //eje Z
            {
                Wx = ((Vx - x) * Math.Cos(Gama)) - ((Vy - y) * Math.Sin(Gama)) + x;
                Wy = ((Vx - x) * Math.Sin(Gama)) + ((Vy - y) * Math.Cos(Gama)) + y;
                Wz = Vz;
            }
        }

        public void EncenderPiramideInvertida()
        {
            double Wxx1, Wyy1, Wzz1, Wxx2, Wyy2, Wzz2;
            Segmento3D S3D = new Segmento3D(X0, Y0, Z0, X0, Y0, Z0, Color0, Imprimir, Viewpoint);
            Segmento3D S3DLados = new Segmento3D(X0, Y0, Z0, X0, Y0, Z0, Color0, Imprimir, Viewpoint);
            Segmento3D S3D2 = new Segmento3D(X0, Y0, Z0, X0, Y0, Z0, Color0, Imprimir, Viewpoint);
            Segmento3D S3DLados2 = new Segmento3D(X0, Y0, Z0, X0, Y0, Z0, Color0, Imprimir, Viewpoint);
            double B = ((2 * Math.PI) / NL);
            double A = Math.PI / 2;
            double auxalt1, auxalt2, auxpunto;
            auxalt1 = S3D.Z0;
            auxalt2 = S3D.Zf;
            auxpunto = S3D.Y0;

            for (int i = 0; i < NL; i++)
            {
                S3D.Z0 = auxalt1;
                S3D.Zf = auxalt2;
                S3D.X0 = X0 + Rd * Math.Cos(A);
                S3D.Y0 = Y0 + Rd * Math.Sin(A);
                S3D.Xf = X0 + Rd * Math.Cos(A + B);
                S3D.Yf = Y0 + Rd * Math.Sin(A + B);
                //S3D.Encender();

                Rotacion2(X0, Y0, Z0, S3D.X0, S3D.Y0, S3D.Z0, gama, eje, out Wxx1, out Wyy1, out Wzz1);
                Rotacion2(X0, Y0, Z0, S3D.Xf, S3D.Yf, S3D.Zf, gama, eje, out Wxx2, out Wyy2, out Wzz2);
                S3D2 = new Segmento3D(Wxx1, Wyy1, Wzz1, Wxx2, Wyy2, Wzz2, Color0, Imprimir, Viewpoint);
                S3D2.Encender();

                S3DLados.X0 = S3D.X0;
                S3DLados.Y0 = S3D.Y0;
                S3DLados.Xf = X0;
                S3DLados.Yf = Y0;
                S3DLados.Zf = 0 - altura;
                //S3DLados.Encender();

                Rotacion2(X0, Y0, Z0, S3DLados.X0, S3DLados.Y0, S3DLados.Z0, gama, eje, out Wxx1, out Wyy1, out Wzz1);
                Rotacion2(X0, Y0, Z0, S3DLados.Xf, S3DLados.Yf, S3DLados.Zf, gama, eje, out Wxx2, out Wyy2, out Wzz2);
                S3DLados2 = new Segmento3D(Wxx1, Wyy1, Wzz1, Wxx2, Wyy2, Wzz2, Color0, Imprimir, Viewpoint);
                S3DLados2.Encender();
                A = A + B;
            }
        }

        public void EncenderPiramideElipse()
        {
            double Wxx1, Wyy1, Wzz1, Wxx2, Wyy2, Wzz2;
            Segmento3D S3D = new Segmento3D(X0, Y0, Z0, X0, Y0, Z0, Color0, Imprimir, Viewpoint);
            Segmento3D S3DLados = new Segmento3D(X0, Y0, Z0, X0, Y0, Z0, Color0, Imprimir, Viewpoint);
            Segmento3D S3D2 = new Segmento3D(X0, Y0, Z0, X0, Y0, Z0, Color0, Imprimir, Viewpoint);
            Segmento3D S3DLados2 = new Segmento3D(X0, Y0, Z0, X0, Y0, Z0, Color0, Imprimir, Viewpoint);
            double B = ((2 * Math.PI) / NL);
            double A = Math.PI / 2;
            double auxalt1, auxalt2;
            auxalt1 = S3D.Z0;
            auxalt2 = S3D.Zf;

            for (int i = 0; i < NL; i++)
            {
                S3D.Z0 = auxalt1;
                S3D.Zf = auxalt2;
                S3D.X0 = X0 + Rd * Math.Cos(A);
                S3D.Y0 = Y0 + Rd * Math.Sin(A);
                S3D.Xf = X0 + Rd * Math.Cos(A + B);
                S3D.Yf = Y0 + Rd * Math.Sin(A + B);
                //S3D.Encender();

                Rotacion3D(S3D.X0, S3D.Y0, S3D.Z0, gama, eje, out Wxx1, out Wyy1, out Wzz1);
                Rotacion3D(S3D.Xf, S3D.Yf, S3D.Zf, gama, eje, out Wxx2, out Wyy2, out Wzz2);
                S3D2 = new Segmento3D(Wxx1, Wyy1, Wzz1, Wxx2, Wyy2, Wzz2, Color0, Imprimir, Viewpoint);
                S3D2.Encender();

                S3DLados.X0 = S3D.X0;
                S3DLados.Y0 = S3D.Y0;
                S3DLados.Xf = X0;
                S3DLados.Yf = Y0;
                S3DLados.Zf = 0 - altura;
                //S3DLados.Encender();

                Rotacion3D(S3DLados.X0, S3DLados.Y0, S3DLados.Z0, gama, eje, out Wxx1, out Wyy1, out Wzz1);
                Rotacion3D(S3DLados.Xf, S3DLados.Yf, S3DLados.Zf, gama, eje, out Wxx2, out Wyy2, out Wzz2);
                S3DLados2 = new Segmento3D(Wxx1, Wyy1, Wzz1, Wxx2, Wyy2, Wzz2, Color0, Imprimir, Viewpoint);
                S3DLados2.Encender();

                A = A + B;
            }
        }

        public void Ejes()
        {
            //Ejes 
            //EjeY
            Segmento3D ejes = new Segmento3D(0, 0, 0, 0, 10, 0, Color.Black, Imprimir, Viewpoint);
            ejes.Encender();
            //EjeX
            ejes.Xf = 24;
            ejes.Yf = 0;
            ejes.Encender();
            //EjeZ
            ejes.Xf = 0;
            ejes.Zf = 8;
            ejes.Encender();
        }
        public override void Apagar()
        {
            Color0 = Color.WhiteSmoke;
            RotarEncender();
        }

        public void ApagarP()
        {
            Color0 = Color.WhiteSmoke;
            //EncenderPiramide(0);
            EncenderPiramideInvertida();
        }
    }
}
