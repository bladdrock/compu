using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace appCompuGrafica
{
	class cSuperficie2 : cEspiral
	{
		public double factor;
		
		//PARRABOLOIDE HIPERBOLICO
		public void ParraboloideHiperbolico(Bitmap lienzo)
		{
			cVector3d v = new cVector3d();
            cVector3d w = new cVector3d();
			double t, dt;
			double h, dh;
			t = -7;
			dt = 0.2;
			do
			{
				h = -5;
				dh = 0.2;
				do
				{
					v.x0 = t;
					v.y0 = h;
					v.z0 = (t * t - h * h) * dh;
					v.color = color;
					v.encender(lienzo);
					h +=  dh;
				} while (h <= 5);
				t = t + dt;
			} while (t <= 7);			
		}

		public void ParraboloideHiperbolico1(Bitmap lienzo)
		{
			cVector3d v = new cVector3d();
			double t, dt;
			double h, dh;
			t = -7;
			dt = 0.2;
			do
			{
				h = -5;
				dh = 0.2;
				do
				{
					v.x0 = t;
					v.y0 = h;
					v.z0 = (t * t + h * h) * dh;
					v.color = color;
					v.encender(lienzo);
					h += dh;
				} while (h <= 5);
				t = t + dt;
			} while (t <= 7);
		}

		public void ParraboloideHiperbolico2(Bitmap lienzo)
		{
			cVector3d v = new cVector3d();
			double t, dt;
			double h, dh;
			t = -7;
			dt = 0.2;
			do
			{
				h = -5;
				dh = 0.2;
				do
				{
					v.x0 = t;
					v.y0 = h;
					v.z0 = (t*Math.Sin(h)+h*Math.Cos(t)) * dh;
					v.color = color;
					v.encender(lienzo);
					h += dh;
				} while (h <= 5);
				t = t + dt;
			} while (t <= 7);
		}

		//PARABOLOIDE HIPERBOLICO SOMBREADO
		//public void ParraboloideHiperbolicoS(Bitmap lienzo)
		//{
		//	cVector3d v = new cVector3d();
		//	//para mallado
		//	double[,] M1 = new double[1000, 1000];
		//	double[,] M2 = new double[1000, 1000];
		//	int i, j, ni, nj;
		//	double t, dt;
		//	double h, dh;
		//	double ax, ay;
		//	t = -6;
		//	i = 0;
		//	dt = 0.3;
		//	do
		//	{
		//		h = -5;
		//		j = 0;
		//		dh = 0.3;
		//		do
		//		{
		//			v.x0 = t;
		//			v.y0 = h;
		//			v.z0 = (t * t - h * h) * 0.1;
		//			v.color = color;
		//			//v.encender(lienzo);
		//			cVector3d.Axonometria1(v.x0, v.y0, v.z0, out ax, out ay);
		//			M1[i, j] = ax;
		//			M2[i, j] = ay;
		//			h = h + dh;
		//			j = j + 1;
		//		} while (h <= 5);
		//		t = t + dt;
		//		i = i + 1;
		//	} while (t <= 6);
		//	ni = i;
		//	nj = j;
		//	for (i = 0; i < ni - 1; i++)
		//	{
		//		for (j = 0; j < nj - 1; j++)
		//		{
		//			double xx, yy;
		//			xx = (M1[i + 1, j] - M1[i, j]) * (M2[i + 1, j + 1] - M2[i + 1, j]);
		//			yy = (M1[i + 1, j + 1] - M1[i + 1, j]) * (M2[i + 1, j] - M2[i, j]);
		//			Cuadrilatero3 c = new Cuadrilatero3();
		//			if ((xx - yy) > 0)
		//			{
		//				c.Cuadrilatero(M1[i, j], M2[i, j], M1[i + 1, j], M2[i + 1, j], M1[i + 1, j + 1], M2[i + 1, j + 1], M1[i, j + 1], M2[i, j + 1], Color.Green, Color.Blue, lienzo);
		//			}
		//			else
		//			{
		//				c.Cuadrilatero(M1[i, j], M2[i, j], M1[i + 1, j], M2[i + 1, j], M1[i + 1, j + 1], M2[i + 1, j + 1], M1[i, j + 1], M2[i, j + 1], Color.Fuchsia, Color.Gray, lienzo);
		//			}

		//		}
		//	}
		//}

		////PARABOLOIDE HIPERBOLICO RELLENO

		//public void ParraboloideHiperbolicoR(Bitmap lienzo)
		//{
		//	cVector3d v = new cVector3d();
		//	//para mallado
		//	double[,] M1 = new double[1000, 1000];
		//	double[,] M2 = new double[1000, 1000];
		//	int i, j, ni, nj;
		//	double t, dt;
		//	double h, dh;
		//	double ax, ay;
		//	t = -6;
		//	i = 0;
		//	dt = 0.3;
		//	do
		//	{
		//		h = -5;
		//		j = 0;
		//		dh = 0.3;
		//		do
		//		{
		//			v.x0 = t;
		//			v.y0 = h;
		//			v.z0 = (t * t - h * h) * 0.1;
		//			v.color = color;
		//			v.encender(lienzo);
		//			cVector3d.Axonometria1(v.x0, v.y0, v.z0, out ax, out ay);
		//			M1[i, j] = ax;
		//			M2[i, j] = ay;
		//			h = h + dh;
		//			j = j + 1;
		//		} while (h <= 5);
		//		t = t + dt;
		//		i = i + 1;
		//	} while (t <= 6);
		//	ni = i;
		//	nj = j;
		//	for (i = 0; i < ni - 1; i++)
		//	{
		//		for (j = 0; j < nj - 1; j++)
		//		{
					
		//			Cuadrilatero3 c = new Cuadrilatero3();
		//			c.Cuadrilatero(M1[i, j], M2[i, j], M1[i + 1, j], M2[i + 1, j], M1[i + 1, j + 1], M2[i + 1, j + 1], M1[i, j + 1], M2[i, j + 1], Color.LemonChiffon, Color.Transparent, lienzo);
				
		//		}
		//	}
		//}

		////PARABOLOIDE HIPERBOLICO MALLADO

		//public void ParraboloideHiperbolicoM(Bitmap lienzo)
		//{
		//	cVector3d v = new cVector3d();
		//	double t, dt;
		//	double h, dh;
		//	//para mallado
		//	double[,] M1 = new double[1000, 1000];
		//	double[,] M2 = new double[1000, 1000];
		//	int i, j, ni, nj;
		//	double ax, ay;
		//	t = -7;
		//	i = 0;
		//	dt = 0.3;
		//	do
		//	{
		//		h = -5;
		//		j = 0;
		//		dh = 0.3;
		//		do
		//		{
		//			v.x0 = t;
		//			v.y0 = h;
		//			v.z0 = (t * t - h * h) * 0.1;
		//			v.color = color;
		//			v.encender(lienzo);
		//			cVector3d.Axonometria1(v.x0, v.y0, v.z0, out ax, out ay);
		//			M1[i, j] = ax;
		//			M2[i, j] = ay;
		//			h = h + dh;
		//			j = j + 1;
		//		} while (h <= 5);
		//		t = t + dt;
		//		i = i + 1;
		//	} while (t <= 6);
		//	ni = i;
		//	nj = j;
		//	for (i = 0; i < ni - 1; i++)
		//	{
		//		for (j = 0; j < nj - 1; j++)
		//		{

		//			Cuadrilatero3 c = new Cuadrilatero3();
		//			c.Cuadrilatero(M1[i, j], M2[i, j], M1[i + 1, j], M2[i + 1, j], M1[i + 1, j + 1], M2[i + 1, j + 1], M1[i, j + 1], M2[i, j + 1],Color.Gray, Color.Transparent, lienzo);

		//		}
		//	}
		//}

		//// PARRABOLOIDE 
		//public void Parraboloide(Bitmap lienzo)
		//{
		//	cVector3d v3d = new cVector3d();
		//	double t = -7, dt = 0.2, h, dh;
		//	do
		//	{
		//		h = -5;
		//		dh = 0.3;
		//		do
		//		{
		//			v3d.x0 = t;
		//			v3d.y0 = h;
		//			v3d.z0 = (t * t + h * h) * factor - 5;
		//			v3d.color = color;
		//			v3d.encender(lienzo);
		//			h = h + dh;
		//		} while (h <= 5);
		//		t = t + dt;
		//	} while (t <= 7);
		//}


		////PARABOLOIDE SOMBREADO

		//public void ParraboloideS(Bitmap lienzo)
		//{
		//	cVector3d v = new cVector3d();
		//	//para mallado
		//	double[,] M1 = new double[1000, 1000];
		//	double[,] M2 = new double[1000, 1000];
		//	int i, j, ni, nj;
		//	double t, dt;
		//	double h, dh;
		//	double ax, ay;
		//	t = -6;
		//	i = 0;
		//	dt = 0.3;
		//	do
		//	{
		//		h = -5;
		//		j = 0;
		//		dh = 0.3;
		//		do
		//		{
		//			v.x0 = t;
		//			v.y0 = h;
		//			v.z0 = (t * t + h * h) * factor - 5;
		//			v.color = color;
		//			v.encender(lienzo);
		//			cVector3d.Axonometria1(v.x0, v.y0, v.z0, out ax, out ay);
		//			M1[i, j] = ax;
		//			M2[i, j] = ay;
		//			h = h + dh;
		//			j = j + 1;
		//		} while (h <= 5);
		//		t = t + dt;
		//		i = i + 1;
		//	} while (t <= 6);
		//	ni = i;
		//	nj = j;
		//	for (i = 0; i < ni - 1; i++)
		//	{
		//		for (j = 0; j < nj - 1; j++)
		//		{
		//			double xx, yy;
		//			xx = (M1[i + 1, j] - M1[i, j]) * (M2[i + 1, j + 1] - M2[i + 1, j]);
		//			yy = (M1[i + 1, j + 1] - M1[i + 1, j]) * (M2[i + 1, j] - M2[i, j]);
		//			Cuadrilatero3 c = new Cuadrilatero3();
		//			if ((xx - yy) > 0)
		//			{
		//				c.Cuadrilatero(M1[i, j], M2[i, j], M1[i + 1, j], M2[i + 1, j], M1[i + 1, j + 1], M2[i + 1, j + 1], M1[i, j + 1], M2[i, j + 1], Color.Green, Color.Blue, lienzo);
		//			}
		//			else
		//			{
		//				c.Cuadrilatero(M1[i, j], M2[i, j], M1[i + 1, j], M2[i + 1, j], M1[i + 1, j + 1], M2[i + 1, j + 1], M1[i, j + 1], M2[i, j + 1], Color.Fuchsia, Color.Gray, lienzo);
		//			}

		//		}
		//	}
		//}

		////PARABOLOIDE RELLENO

		//public void ParraboloideR(Bitmap lienzo)
		//{
		//	cVector3d v = new cVector3d();
		//	//para mallado
		//	double[,] M1 = new double[1000, 1000];
		//	double[,] M2 = new double[1000, 1000];
		//	int i, j, ni, nj;
		//	double t, dt;
		//	double h, dh;
		//	double ax, ay;
		//	t = -6;
		//	i = 0;
		//	dt = 0.3;
		//	do
		//	{
		//		h = -5;
		//		j = 0;
		//		dh = 0.3;
		//		do
		//		{
		//			v.x0 = t;
		//			v.y0 = h;
		//			v.z0 = (t * t + h * h) * factor - 5; 
		//			v.color = color;
		//			v.encender(lienzo);
		//			cVector3d.Axonometria1(v.x0, v.y0, v.z0, out ax, out ay);
		//			M1[i, j] = ax;
		//			M2[i, j] = ay;
		//			h = h + dh;
		//			j = j + 1;
		//		} while (h <= 5);
		//		t = t + dt;
		//		i = i + 1;
		//	} while (t <= 6);
		//	ni = i;
		//	nj = j;
		//	for (i = 0; i < ni - 1; i++)
		//	{
		//		for (j = 0; j < nj - 1; j++)
		//		{

		//			Cuadrilatero3 c = new Cuadrilatero3();
		//			c.Cuadrilatero(M1[i, j], M2[i, j], M1[i + 1, j], M2[i + 1, j], M1[i + 1, j + 1], M2[i + 1, j + 1], M1[i, j + 1], M2[i, j + 1], Color.Fuchsia, Color.Transparent, lienzo);

		//		}
		//	}
		//}

		////PARABOLOIDE MALLADO

		//public void ParraboloideM(Bitmap lienzo)
		//{
		//	cVector3d v = new cVector3d();
		//	double t, dt;
		//	double h, dh;
		//	//para mallado
		//	double[,] M1 = new double[1000, 1000];
		//	double[,] M2 = new double[1000, 1000];
		//	int i, j, ni, nj;
		//	double ax, ay;
		//	t = -6;
		//	i = 0;
		//	dt = 0.3;
		//	do
		//	{
		//		h = -5;
		//		j = 0;
		//		dh = 0.3;
		//		do
		//		{
		//			v.x0 = t;
		//			v.y0 = h;
		//			v.z0 = (t * t + h * h) * factor - 5;
		//			v.color = color;
		//			v.encender(lienzo);
		//			cVector3d.Axonometria1(v.x0, v.y0, v.z0, out ax, out ay);
		//			M1[i, j] = ax;
		//			M2[i, j] = ay;
		//			h = h + dh;
		//			j = j + 1;
		//		} while (h <= 5);
		//		t = t + dt;
		//		i = i + 1;
		//	} while (t <= 6);
		//	ni = i;
		//	nj = j;
		//	for (i = 0; i < ni - 1; i++)
		//	{
		//		for (j = 0; j < nj - 1; j++)
		//		{

		//			Cuadrilatero3 c = new Cuadrilatero3();
		//			c.Cuadrilatero(M1[i, j], M2[i, j], M1[i + 1, j], M2[i + 1, j], M1[i + 1, j + 1], M2[i + 1, j + 1], M1[i, j + 1], M2[i, j + 1],Color.Gray, Color.Gray ,lienzo);

		//		}
		//	}
		//}


		////SUPER1

		//public void super(Bitmap lienzo)
		//{
		//	cVector3d v3d = new cVector3d();
		//	double t = -7, dt = 0.3, h, dh;
		//	do
		//	{
		//		h = -5;
		//		dh = 0.3;
		//		do
		//		{
		//			v3d.x0 = t;
		//			v3d.y0 = h;
		//			v3d.z0 = (t * Math.Sin(h) + h * Math.Cos(t)) * factor;
		//			v3d.color = color;
		//			v3d.encender(lienzo);
		//			h = h + dh;
		//		} while (h <= 5);
		//		t = t + dt;
		//	} while (t <= 7);
		//}



		////SUPER1 SOMBREADO

		//public void SuperS(Bitmap lienzo)
		//{
		//	cVector3d v = new cVector3d();
		//	//para mallado
		//	double[,] M1 = new double[1000, 1000];
		//	double[,] M2 = new double[1000, 1000];
		//	int i, j, ni, nj;
		//	double t, dt;
		//	double h, dh;
		//	double ax, ay;
		//	t = -6;
		//	i = 0;
		//	dt = 0.3;
		//	do
		//	{
		//		h = -5;
		//		j = 0;
		//		dh = 0.3;
		//		do
		//		{
		//			v.x0 = t;
		//			v.y0 = h;
		//			v.z0 = (t * Math.Sin(h) + h * Math.Cos(t)) * factor;
		//			v.color = color;
		//			//v.encender(lienzo);
		//			cVector3d.Axonometria1(v.x0, v.y0, v.z0, out ax, out ay);
		//			M1[i, j] = ax;
		//			M2[i, j] = ay;
		//			h = h + dh;
		//			j = j + 1;
		//		} while (h <= 5);
		//		t = t + dt;
		//		i = i + 1;
		//	} while (t <= 6);
		//	ni = i;
		//	nj = j;
		//	for (i = 0; i < ni; i++)
		//	{
		//		for (j = 0; j < nj; j++)
		//		{
		//			double xx, yy;
		//			xx = (M1[i + 1, j] - M1[i, j]) * (M2[i + 1, j + 1] - M2[i + 1, j]);
		//			yy = (M1[i + 1, j + 1] - M1[i + 1, j]) * (M2[i + 1, j] - M2[i, j]);
		//			Cuadrilatero3 c = new Cuadrilatero3();
		//			if ((xx - yy) > 0)
		//			{
		//				c.Cuadrilatero(M1[i, j], M2[i, j], M1[i + 1, j], M2[i + 1, j], M1[i + 1, j + 1], M2[i + 1, j + 1], M1[i, j + 1], M2[i, j + 1], Color.Green, Color.Blue, lienzo);
		//			}
		//			else
		//			{
		//				c.Cuadrilatero(M1[i, j], M2[i, j], M1[i + 1, j], M2[i + 1, j], M1[i + 1, j + 1], M2[i + 1, j + 1], M1[i, j + 1], M2[i, j + 1], Color.Fuchsia, Color.Gray, lienzo);
		//			}

		//		}
		//	}
		//}

		////SUPER1 RELLENO

		//public void SuperR(Bitmap lienzo)
		//{
		//	cVector3d v = new cVector3d();
		//	//para mallado
		//	double[,] M1 = new double[1000, 1000];
		//	double[,] M2 = new double[1000, 1000];
		//	int i, j, ni, nj;
		//	double t, dt;
		//	double h, dh;
		//	double ax, ay;
		//	t = -6;
		//	i = 0;
		//	dt = 0.3;
		//	do
		//	{
		//		h = -5;
		//		j = 0;
		//		dh = 0.3;
		//		do
		//		{
		//			v.x0 = t;
		//			v.y0 = h;
		//			v.z0 = (t * Math.Sin(h) + h * Math.Cos(t)) * factor;
		//			v.color = color;
		//			//v.encender(lienzo);
		//			cVector3d.Axonometria1(v.x0, v.y0, v.z0, out ax, out ay);
		//			M1[i, j] = ax;
		//			M2[i, j] = ay;
		//			h = h + dh;
		//			j = j + 1;
		//		} while (h <= 5);
		//		t = t + dt;
		//		i = i + 1;
		//	} while (t <= 6);
		//	ni = i;
		//	nj = j;
		//	for (i = 0; i < ni; i++)
		//	{
		//		for (j = 0; j < nj; j++)
		//		{

		//			Cuadrilatero3 c = new Cuadrilatero3();
		//			c.Cuadrilatero(M1[i, j], M2[i, j], M1[i + 1, j], M2[i + 1, j], M1[i + 1, j + 1], M2[i + 1, j + 1], M1[i, j + 1], M2[i, j + 1], Color.Fuchsia, Color.Transparent, lienzo);

		//		}
		//	}
		//}

		////SUPER1 MALLADO

		//public void SuperM(Bitmap lienzo)
		//{
		//	cVector3d v = new cVector3d();
		//	double t, dt;
		//	double h, dh;
		//	//para mallado
		//	double[,] M1 = new double[1000, 1000];
		//	double[,] M2 = new double[1000, 1000];
		//	int i, j, ni, nj;
		//	double ax, ay;
		//	t = -7;
		//	i = 0;
		//	dt = 0.3;
		//	do
		//	{
		//		h = -5;
		//		j = 0;
		//		dh = 0.3;
		//		do
		//		{
		//			v.x0 = t;
		//			v.y0 = h;
		//			v.z0 = (t * Math.Sin(h) + h * Math.Cos(t)) * factor;
		//			v.color = color;
		//			//v.encender(lienzo);
		//			cVector3d.Axonometria1(v.x0, v.y0, v.z0, out ax, out ay);
		//			M1[i, j] = ax;
		//			M2[i, j] = ay;
		//			h = h + dh;
		//			j = j + 1;
		//		} while (h <= 5);
		//		t = t + dt;
		//		i = i + 1;
		//	} while (t <= 6);
		//	ni = i;
		//	nj = j;
		//	for (i = 0; i < ni; i++)
		//	{
		//		for (j = 0; j < nj; j++)
		//		{

		//			Cuadrilatero3 c = new Cuadrilatero3();
		//			c.Cuadrilatero(M1[i, j], M2[i, j], M1[i + 1, j], M2[i + 1, j], M1[i + 1, j + 1], M2[i + 1, j + 1], M1[i, j + 1], M2[i, j + 1], Color.Gray, Color.Gray, lienzo);

		//		}
		//	}
		//}



		//// ESFERA
		//public void Super1(Bitmap lienzo)
		//{
		//	cVector3d v3d = new cVector3d();
		//	double t = 0, dt = 0.3, h, dh;
		//	do
		//	{			
		//		h = 0;
		//		dh = 0.3;
		//		do
		//		{
		//			v3d.x0 = x0 + 1.5 * Math.Sin(h) * Math.Cos(t);
		//			v3d.y0 = y0 + 1.5 * Math.Sin(h) * Math.Sin(t);
		//			v3d.z0 = z0 + 1.5 * Math.Cos(h);
		//			v3d.color = color;
		//			v3d.encender(lienzo);					
		//			h = h + dh;
		//		} while (h <= Math.PI);
		//		t = t + dt;
		//	} while (t <= 2*Math.PI);
		//}

		////SUPER1 MALLADO

		//public void Super1M(Bitmap lienzo)
		//{
		//	cVector3d v = new cVector3d();
		//	double t, dt;
		//	double h, dh;
		//	//para mallado
		//	double[,] M1 = new double[1000, 1000];
		//	double[,] M2 = new double[1000, 1000];
		//	int i, j, ni, nj;
		//	double ax, ay;
		//	t = -5;
		//	i = 0;
		//	dt = 0.5;
		//	do
		//	{
		//		h = -5;
		//		j = 0;
		//		dh = 0.5;
		//		do
		//		{
		//			v.x0 = x0 + 3 * Math.Sin(h) * Math.Cos(t);
		//			v.y0 = y0 + 3 * Math.Sin(h) * Math.Sin(t);
		//			v.z0 = z0 + 3 * Math.Cos(h);
		//			v.color = color;
		//			//v.encender(lienzo);
		//			cVector3d.Axonometria1(v.x0, v.y0, v.z0, out ax, out ay);
		//			M1[i, j] = ax;
		//			M2[i, j] = ay;
		//			h = h + dh;
		//			j = j + 1;
		//		} while (h <= 5);
		//		t = t + dt;
		//		i = i + 1;
		//	} while (t <= 6);
		//	ni = i;
		//	nj = j;
		//	for (i = 0; i < ni; i++)
		//	{
		//		for (j = 0; j < nj; j++)
		//		{

		//			Cuadrilatero3 c = new Cuadrilatero3();
		//			c.Cuadrilatero(M1[i, j], M2[i, j], M1[i + 1, j], M2[i + 1, j], M1[i + 1, j + 1], M2[i + 1, j + 1], M1[i, j + 1], M2[i, j + 1], Color.LavenderBlush, Color.Transparent, lienzo);

		//		}
		//	}
		//}



		////SUPER1 SOMBREADO

		//public void Super1S(Bitmap lienzo)
		//{
		//	cVector3d v = new cVector3d();
		//	//para mallado
		//	double[,] M1 = new double[1000, 1000];
		//	double[,] M2 = new double[1000, 1000];
		//	int i, j, ni, nj;
		//	double t, dt;
		//	double h, dh;
		//	double ax, ay;
		//	t = -6;
		//	i = 0;
		//	dt = 0.3;
		//	do
		//	{
		//		h = -5;
		//		j = 0;
		//		dh = 0.3;
		//		do
		//		{
		//			v.x0 = x0 + 3 * Math.Sin(h) * Math.Cos(t);
		//			v.y0 = y0 + 3 * Math.Sin(h) * Math.Sin(t);
		//			v.z0 = z0 + 3 * Math.Cos(h);
		//			v.color = color;
		//			//v.encender(lienzo);
		//			cVector3d.Axonometria1(v.x0, v.y0, v.z0, out ax, out ay);
		//			M1[i, j] = ax;
		//			M2[i, j] = ay;
		//			h = h + dh;
		//			j = j + 1;
		//		} while (h <= 5);
		//		t = t + dt;
		//		i = i + 1;
		//	} while (t <= 6);
		//	ni = i;
		//	nj = j;
		//	for (i = 0; i < ni; i++)
		//	{
		//		for (j = 0; j < nj; j++)
		//		{
		//			double xx, yy;
		//			xx = (M1[i + 1, j] - M1[i, j]) * (M2[i + 1, j + 1] - M2[i + 1, j]);
		//			yy = (M1[i + 1, j + 1] - M1[i + 1, j]) * (M2[i + 1, j] - M2[i, j]);
		//			Cuadrilatero3 c = new Cuadrilatero3();
		//			if ((xx - yy) > 0)
		//			{
		//				c.Cuadrilatero(M1[i, j], M2[i, j], M1[i + 1, j], M2[i + 1, j], M1[i + 1, j + 1], M2[i + 1, j + 1], M1[i, j + 1], M2[i, j + 1], Color.Green, Color.Blue, lienzo);
		//			}
		//			else
		//			{
		//				c.Cuadrilatero(M1[i, j], M2[i, j], M1[i + 1, j], M2[i + 1, j], M1[i + 1, j + 1], M2[i + 1, j + 1], M1[i, j + 1], M2[i, j + 1], Color.Fuchsia, Color.Gray, lienzo);
		//			}

		//		}
		//	}
		//}

		////SUPER1 RELLENO

		//public void Super1R(Bitmap lienzo)
		//{
		//	cVector3d v = new cVector3d();
		//	//para mallado
		//	double[,] M1 = new double[1000, 1000];
		//	double[,] M2 = new double[1000, 1000];
		//	int i, j, ni, nj;
		//	double t, dt;
		//	double h, dh;
		//	double ax, ay;
		//	t = -6;
		//	i = 0;
		//	dt = 0.3;
		//	do
		//	{
		//		h = -5;
		//		j = 0;
		//		dh = 0.3;
		//		do
		//		{
		//			v.x0 = x0 + 3 * Math.Sin(h) * Math.Cos(t);
		//			v.y0 = y0 + 3 * Math.Sin(h) * Math.Sin(t);
		//			v.z0 = z0 + 3 * Math.Cos(h);
		//			v.color = color;
		//			//v.encender(lienzo);
		//			cVector3d.Axonometria1(v.x0, v.y0, v.z0, out ax, out ay);
		//			M1[i, j] = ax;
		//			M2[i, j] = ay;
		//			h = h + dh;
		//			j = j + 1;
		//		} while (h <= 5);
		//		t = t + dt;
		//		i = i + 1;
		//	} while (t <= 6);
		//	ni = i;
		//	nj = j;
		//	for (i = 0; i < ni; i++)
		//	{
		//		for (j = 0; j < nj; j++)
		//		{

		//			Cuadrilatero3 c = new Cuadrilatero3();
		//			c.Cuadrilatero(M1[i, j], M2[i, j], M1[i + 1, j], M2[i + 1, j], M1[i + 1, j + 1], M2[i + 1, j + 1], M1[i, j + 1], M2[i, j + 1], Color.Fuchsia, Color.Gray, lienzo);

		//		}
		//	}
		//}

		//// CILINDRO
		//public void cilindro(Bitmap lienzo)
		//{
		//	cVector3d V3D = new cVector3d();
		//	double t = 0, dt = 0.3, h, dh;
		//	do
		//	{
		//		h = 0;
		//		dh = 0.1;
		//		do
		//		{
		//			V3D.x0 = x0 + 3 * Math.Cos(h);
		//			V3D.y0 = y0 + 3 * Math.Sin(h);
		//			V3D.z0 = z0 + t;
		//			V3D.color = color;
		//			V3D.encender(lienzo);
		//			h = h + dh;
		//		} while (h <= (2 * Math.PI) + 0.3);
		//		t = t + dt;
		//	} while (t <= 4);
		//}

		//public void torroide(Bitmap lienzo)
		//{
		//	cVector3d V3D = new cVector3d();
		//	double t = 0, dt = 0.3, h, dh;
		//	double R1,RD;
		//	t = 0;
		//	dt = 0.1;
		//	RD = 3;
		//	R1 = RD / 4;
		//	do
		//	{
		//		h = 0;
		//		dh = 0.1;
		//		do
		//		{
		//			V3D.x0 = (x0 + RD + R1 * Math.Cos(t)) * Math.Cos(h);
		//			V3D.y0 = (y0 + RD + R1 * Math.Cos(t)) * Math.Sin(h);
		//			V3D.z0 = z0 + R1 * Math.Sin(t);
		//			V3D.color = color;
		//			V3D.encender(lienzo);
		//			h = h + dh;
		//		} while (h >= 0 && h <= 2 * Math.PI);
		//		t = t + dt;
		//	} while (t >= -1 * Math.PI && t <= 2 * Math.PI);
		//}


		//public void cilindroM(Bitmap lienzo)
		//{
			
		//	cVector3d v = new cVector3d();
		//	double t, dt;
		//	double h, dh;
		//	//para mallado
		//	double[,] M1 = new double[1000, 1000];
		//	double[,] M2 = new double[1000, 1000];
		//	int i, j, ni, nj;
		//	double ax, ay;
		//	t = 0;
		//	i = 0;
		//	dt = 0.1;
		//	do
		//	{
		//		h = 0;
		//		j = 0;
		//		dh = 0.1;
		//		do
		//		{
		//			v.x0 = x0 + 3 * Math.Cos(h);
		//			v.y0 = y0 + 3 * Math.Sin(h);
		//			v.z0 = z0 + t;
		//			v.color = color;
		//			//v.encender(lienzo);
		//			cVector3d.Axonometria1(v.x0, v.y0, v.z0, out ax, out ay);
		//			M1[i, j] = ax;
		//			M2[i, j] = ay;
		//			h = h + dh;
		//			j = j + 1;
		//		} while (h <= (2 * Math.PI) + 0.3);
		//		t = t + dt;
		//		i = i + 1;
		//	} while (t <= 4);
		//	ni = i;
		//	nj = j;
		//	for (i = 0; i < ni; i++)
		//	{
		//		for (j = 0; j < nj; j++)
		//		{

		//			Cuadrilatero3 c = new Cuadrilatero3();
		//			c.Cuadrilatero(M1[i, j], M2[i, j], M1[i + 1, j], M2[i + 1, j], M1[i + 1, j + 1], M2[i + 1, j + 1], M1[i, j + 1], M2[i, j + 1], Color.Gray, Color.Gray, lienzo);

		//		}
		//	}
		//}

		//Superficie Inventada

		public void superficieInventada(Bitmap lienzo)
		{
			cVector3d v = new cVector3d();
			//para mallado
			double[,] M1 = new double[1000, 1000];
			double[,] M2 = new double[1000, 1000];
			int i, j, ni, nj;
			double t, dt;
			double h, dh;
			double ax, ay;
			t = -6;
			i = 0;
			dt = 0.3;
			do
			{
				h = -5;
				j = 0;
				dh = 0.3;
				do
				{
                    v.x0 = t;
					v.y0 = h;
					v.z0 = Math.Abs(Math.Pow(t, 2) - 4) / 14;
					v.color = color;
					v.encender(lienzo);
					v.axonometria(v.x0, v.y0, v.z0, out ax, out ay);
					M1[i, j] = ax;
					M2[i, j] = ay;

                    h = h + dh;
					j = j + 1;
				} while (h <= 5);
				t = t + dt;
				i = i + 1;
			} while (t <= 6);
			ni = i;
			nj = j;
			for (i = 0; i < ni - 1; i++)
			{
				for (j = 0; j < nj - 1; j++)
				{
					//c.encenderCuadrilatero(M1[i, j], M2[i, j], M1[i + 1, j], M2[i + 1, j], M1[i + 1, j + 1], M2[i + 1, j + 1], M1[i, j + 1], M2[i, j + 1], Color.LemonChiffon, Color.Transparent, lienzo);

				}
			}
		}
	}
}
