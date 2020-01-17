# Computación Grafica FIE ESPOCH

Repositorio público de código de interés de la materia.

Autores: Estudiantes 9no semestre período académico 2019 – 2020 

Docente: Ing. Bladimir Urgiles R. Ms.C.


private void spline()
{
	int n = 400; //da la pauta  razon entre puntos
	float[] x = new float[Nd];
	float[] y = new float[Nd];
	float[] xs = new float[n];
	// pasamos de double a float los datos de los vectores
	for (int i = 0; i < Nd; i++)
	{
		x[i] = (float)(Vx[i]);
		y[i] = (float)(Vy[i]);
	}
	float stepSize = (x[x.Length - 1] - x[0]) / n;
	for (int i = 0; i < n; i++)
		xs[i] = x[0] + i * stepSize;//lleno con puntos en X que esten  en el dominio de la grafica 
	CubicSpline spline = new CubicSpline();
	float[] ys = spline.FitAndEval(x, y, xs);// doy ps vectores  el vector con puntos en X (dominio)
	for (int i = 0; i < xs.Length; i++)
	{
		Vector vspline = new Vector();
		vspline.x0 = xs[i];
		vspline.y0 = ys[i];
		vspline.color0 = Color.Black;
		vspline.Encender(grafico);
		VentanaP.Image = grafico;
		vspline = null;
	}
	VentanaP.Image = grafico;
}
