namespace Compu_Proyecto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lb_X = new System.Windows.Forms.Label();
            this.lb_Y = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnPlano = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Animacion = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Mandelbrot = new System.Windows.Forms.Button();
            this.btn_Julia = new System.Windows.Forms.Button();
            this.btn_sierpinski = new System.Windows.Forms.Button();
            this.btn_hock = new System.Windows.Forms.Button();
            this.btn_Cantor = new System.Windows.Forms.Button();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.btnPoligono = new System.Windows.Forms.Button();
            this.btnLazo = new System.Windows.Forms.Button();
            this.btnSegDinamico = new System.Windows.Forms.Button();
            this.btnHiposila = new System.Windows.Forms.Button();
            this.btnMargarita = new System.Windows.Forms.Button();
            this.btnCircun = new System.Windows.Forms.Button();
            this.txtNumlados = new System.Windows.Forms.TextBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.btn_margarita = new System.Windows.Forms.Button();
            this.btn_poligono = new System.Windows.Forms.Button();
            this.btn_lazo = new System.Windows.Forms.Button();
            this.btn_circunferencia = new System.Windows.Forms.Button();
            this.btn_segmento = new System.Windows.Forms.Button();
            this.btn_hipolisa = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Inter_4colores = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnEncenPixel = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.button13 = new System.Windows.Forms.Button();
            this.P2comBoxCurvas = new System.Windows.Forms.ComboBox();
            this.button10 = new System.Windows.Forms.Button();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Animacion.SuspendLayout();
            this.tabControl4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage11.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(601, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(318, 388);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tabPage2.Controls.Add(this.tabControl4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(310, 362);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Parcial 2";
            // 
            // lb_X
            // 
            this.lb_X.AutoSize = true;
            this.lb_X.Location = new System.Drawing.Point(87, 434);
            this.lb_X.Name = "lb_X";
            this.lb_X.Size = new System.Drawing.Size(13, 13);
            this.lb_X.TabIndex = 2;
            this.lb_X.Text = "0";
            // 
            // lb_Y
            // 
            this.lb_Y.AutoSize = true;
            this.lb_Y.Location = new System.Drawing.Point(158, 434);
            this.lb_Y.Name = "lb_Y";
            this.lb_Y.Size = new System.Drawing.Size(13, 13);
            this.lb_Y.TabIndex = 3;
            this.lb_Y.Text = "0";
            this.lb_Y.Click += new System.EventHandler(this.lb_Y_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSalir.Location = new System.Drawing.Point(305, 429);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLimpiar.Location = new System.Drawing.Point(386, 429);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnPlano
            // 
            this.btnPlano.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPlano.Location = new System.Drawing.Point(467, 429);
            this.btnPlano.Name = "btnPlano";
            this.btnPlano.Size = new System.Drawing.Size(75, 23);
            this.btnPlano.TabIndex = 6;
            this.btnPlano.Text = "Plano";
            this.btnPlano.UseVisualStyleBackColor = false;
            this.btnPlano.Click += new System.EventHandler(this.btnPlano_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox1.Location = new System.Drawing.Point(23, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(560, 400);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Animacion
            // 
            this.Animacion.Controls.Add(this.btn_Cantor);
            this.Animacion.Controls.Add(this.btn_hock);
            this.Animacion.Controls.Add(this.btn_sierpinski);
            this.Animacion.Controls.Add(this.btn_Julia);
            this.Animacion.Controls.Add(this.btn_Mandelbrot);
            this.Animacion.Controls.Add(this.label1);
            this.Animacion.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animacion.Location = new System.Drawing.Point(4, 27);
            this.Animacion.Name = "Animacion";
            this.Animacion.Size = new System.Drawing.Size(284, 319);
            this.Animacion.TabIndex = 2;
            this.Animacion.Text = "Geometría Fractal";
            this.Animacion.UseVisualStyleBackColor = true;
            this.Animacion.Click += new System.EventHandler(this.Animacion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(0, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "EJEMPLOS DE GEOMETRÍAS FRACTALES";
            // 
            // btn_Mandelbrot
            // 
            this.btn_Mandelbrot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Mandelbrot.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mandelbrot.Location = new System.Drawing.Point(26, 78);
            this.btn_Mandelbrot.Name = "btn_Mandelbrot";
            this.btn_Mandelbrot.Size = new System.Drawing.Size(105, 30);
            this.btn_Mandelbrot.TabIndex = 4;
            this.btn_Mandelbrot.Text = "Mandelbrot";
            this.btn_Mandelbrot.UseVisualStyleBackColor = false;
            this.btn_Mandelbrot.Click += new System.EventHandler(this.btn_Mandelbrot_Click);
            // 
            // btn_Julia
            // 
            this.btn_Julia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Julia.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Julia.Location = new System.Drawing.Point(153, 78);
            this.btn_Julia.Name = "btn_Julia";
            this.btn_Julia.Size = new System.Drawing.Size(90, 30);
            this.btn_Julia.TabIndex = 5;
            this.btn_Julia.Text = "Julia";
            this.btn_Julia.UseVisualStyleBackColor = false;
            this.btn_Julia.Click += new System.EventHandler(this.btn_Julia_Click);
            // 
            // btn_sierpinski
            // 
            this.btn_sierpinski.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_sierpinski.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sierpinski.Location = new System.Drawing.Point(44, 222);
            this.btn_sierpinski.Name = "btn_sierpinski";
            this.btn_sierpinski.Size = new System.Drawing.Size(187, 30);
            this.btn_sierpinski.TabIndex = 7;
            this.btn_sierpinski.Text = "Triángulo Sierpinski";
            this.btn_sierpinski.UseVisualStyleBackColor = false;
            this.btn_sierpinski.Click += new System.EventHandler(this.btn_sierpinski_Click);
            // 
            // btn_hock
            // 
            this.btn_hock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_hock.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hock.Location = new System.Drawing.Point(153, 142);
            this.btn_hock.Name = "btn_hock";
            this.btn_hock.Size = new System.Drawing.Size(90, 30);
            this.btn_hock.TabIndex = 9;
            this.btn_hock.Text = "Koch ";
            this.btn_hock.UseVisualStyleBackColor = false;
            this.btn_hock.Click += new System.EventHandler(this.btn_hock_Click);
            // 
            // btn_Cantor
            // 
            this.btn_Cantor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Cantor.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cantor.Location = new System.Drawing.Point(26, 142);
            this.btn_Cantor.Name = "btn_Cantor";
            this.btn_Cantor.Size = new System.Drawing.Size(105, 30);
            this.btn_Cantor.TabIndex = 10;
            this.btn_Cantor.Text = "Cantor";
            this.btn_Cantor.UseVisualStyleBackColor = false;
            this.btn_Cantor.Click += new System.EventHandler(this.btn_Cantor_Click);
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.tabPage7);
            this.tabControl4.Controls.Add(this.tabPage11);
            this.tabControl4.Controls.Add(this.Animacion);
            this.tabControl4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl4.Location = new System.Drawing.Point(6, 6);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(292, 350);
            this.tabControl4.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(304, 356);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(296, 327);
            this.tabPage8.TabIndex = 5;
            this.tabPage8.Text = "Taylor";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(76, 81);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 2;
            this.button9.Text = "2 senx (x)";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(76, 151);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 5;
            this.button12.Text = "arcTg(x)";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.Lime;
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(296, 327);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "Tapetes";
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Location = new System.Drawing.Point(14, 164);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(242, 143);
            this.button6.TabIndex = 1;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(14, 20);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(242, 129);
            this.button5.TabIndex = 0;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Aquamarine;
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(296, 327);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Figuras";
            // 
            // tabControl3
            // 
            this.tabControl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl3.Location = new System.Drawing.Point(-4, 21);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(298, 296);
            this.tabControl3.TabIndex = 0;
            // 
            // tabPage10
            // 
            this.tabPage10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(290, 270);
            this.tabPage10.TabIndex = 1;
            this.tabPage10.Text = "Fig. Dinámicas";
            // 
            // btnPoligono
            // 
            this.btnPoligono.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPoligono.BackgroundImage")));
            this.btnPoligono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPoligono.Location = new System.Drawing.Point(19, 101);
            this.btnPoligono.Name = "btnPoligono";
            this.btnPoligono.Size = new System.Drawing.Size(77, 75);
            this.btnPoligono.TabIndex = 2;
            this.btnPoligono.Text = "Pligono";
            this.btnPoligono.UseVisualStyleBackColor = true;
            this.btnPoligono.Click += new System.EventHandler(this.btnPoligono_Click);
            // 
            // btnLazo
            // 
            this.btnLazo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLazo.BackgroundImage")));
            this.btnLazo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLazo.Location = new System.Drawing.Point(19, 186);
            this.btnLazo.Name = "btnLazo";
            this.btnLazo.Size = new System.Drawing.Size(77, 75);
            this.btnLazo.TabIndex = 3;
            this.btnLazo.Text = "Lazo";
            this.btnLazo.UseVisualStyleBackColor = true;
            this.btnLazo.Click += new System.EventHandler(this.btnLazo_Click);
            // 
            // btnSegDinamico
            // 
            this.btnSegDinamico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSegDinamico.BackgroundImage")));
            this.btnSegDinamico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSegDinamico.Location = new System.Drawing.Point(19, 13);
            this.btnSegDinamico.Name = "btnSegDinamico";
            this.btnSegDinamico.Size = new System.Drawing.Size(77, 75);
            this.btnSegDinamico.TabIndex = 0;
            this.btnSegDinamico.Text = "Segmento";
            this.btnSegDinamico.UseVisualStyleBackColor = true;
            this.btnSegDinamico.Click += new System.EventHandler(this.btnSegDinamico_Click);
            // 
            // btnHiposila
            // 
            this.btnHiposila.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHiposila.BackgroundImage")));
            this.btnHiposila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHiposila.Location = new System.Drawing.Point(180, 185);
            this.btnHiposila.Name = "btnHiposila";
            this.btnHiposila.Size = new System.Drawing.Size(78, 75);
            this.btnHiposila.TabIndex = 5;
            this.btnHiposila.Text = "Hiposila";
            this.btnHiposila.UseVisualStyleBackColor = true;
            this.btnHiposila.Click += new System.EventHandler(this.btnHiposila_Click);
            // 
            // btnMargarita
            // 
            this.btnMargarita.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMargarita.BackgroundImage")));
            this.btnMargarita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMargarita.Location = new System.Drawing.Point(180, 13);
            this.btnMargarita.Name = "btnMargarita";
            this.btnMargarita.Size = new System.Drawing.Size(78, 75);
            this.btnMargarita.TabIndex = 4;
            this.btnMargarita.Text = "Margarita";
            this.btnMargarita.UseVisualStyleBackColor = true;
            this.btnMargarita.Click += new System.EventHandler(this.btnMargarita_Click);
            // 
            // btnCircun
            // 
            this.btnCircun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCircun.BackgroundImage")));
            this.btnCircun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCircun.Location = new System.Drawing.Point(180, 101);
            this.btnCircun.Name = "btnCircun";
            this.btnCircun.Size = new System.Drawing.Size(78, 75);
            this.btnCircun.TabIndex = 1;
            this.btnCircun.Text = "Circunferencia";
            this.btnCircun.UseVisualStyleBackColor = true;
            this.btnCircun.Click += new System.EventHandler(this.btnCircun_Click);
            // 
            // txtNumlados
            // 
            this.txtNumlados.Location = new System.Drawing.Point(105, 129);
            this.txtNumlados.Name = "txtNumlados";
            this.txtNumlados.Size = new System.Drawing.Size(33, 20);
            this.txtNumlados.TabIndex = 6;
            // 
            // tabPage9
            // 
            this.tabPage9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(290, 270);
            this.tabPage9.TabIndex = 0;
            this.tabPage9.Text = "Fig. Estáticas";
            // 
            // btn_margarita
            // 
            this.btn_margarita.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_margarita.Location = new System.Drawing.Point(124, 105);
            this.btn_margarita.Name = "btn_margarita";
            this.btn_margarita.Size = new System.Drawing.Size(108, 30);
            this.btn_margarita.TabIndex = 3;
            this.btn_margarita.Text = "Margarita";
            this.btn_margarita.UseVisualStyleBackColor = true;
            this.btn_margarita.Click += new System.EventHandler(this.btn_margarita_Click);
            // 
            // btn_poligono
            // 
            this.btn_poligono.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_poligono.Location = new System.Drawing.Point(17, 105);
            this.btn_poligono.Name = "btn_poligono";
            this.btn_poligono.Size = new System.Drawing.Size(90, 30);
            this.btn_poligono.TabIndex = 2;
            this.btn_poligono.Text = "Polígono";
            this.btn_poligono.UseVisualStyleBackColor = true;
            this.btn_poligono.Click += new System.EventHandler(this.btn_poligono_Click);
            // 
            // btn_lazo
            // 
            this.btn_lazo.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lazo.Location = new System.Drawing.Point(17, 175);
            this.btn_lazo.Name = "btn_lazo";
            this.btn_lazo.Size = new System.Drawing.Size(90, 30);
            this.btn_lazo.TabIndex = 4;
            this.btn_lazo.Text = "Lazo";
            this.btn_lazo.UseVisualStyleBackColor = true;
            this.btn_lazo.Click += new System.EventHandler(this.btn_lazo_Click);
            // 
            // btn_circunferencia
            // 
            this.btn_circunferencia.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_circunferencia.Location = new System.Drawing.Point(124, 41);
            this.btn_circunferencia.Name = "btn_circunferencia";
            this.btn_circunferencia.Size = new System.Drawing.Size(108, 30);
            this.btn_circunferencia.TabIndex = 1;
            this.btn_circunferencia.Text = "Circunferencia";
            this.btn_circunferencia.UseVisualStyleBackColor = true;
            this.btn_circunferencia.Click += new System.EventHandler(this.btn_circunferencia_Click);
            // 
            // btn_segmento
            // 
            this.btn_segmento.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_segmento.Location = new System.Drawing.Point(17, 41);
            this.btn_segmento.Name = "btn_segmento";
            this.btn_segmento.Size = new System.Drawing.Size(90, 30);
            this.btn_segmento.TabIndex = 0;
            this.btn_segmento.Text = "Segmento";
            this.btn_segmento.UseVisualStyleBackColor = true;
            this.btn_segmento.Click += new System.EventHandler(this.btn_segmento_Click);
            // 
            // btn_hipolisa
            // 
            this.btn_hipolisa.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hipolisa.Location = new System.Drawing.Point(124, 175);
            this.btn_hipolisa.Name = "btn_hipolisa";
            this.btn_hipolisa.Size = new System.Drawing.Size(108, 30);
            this.btn_hipolisa.TabIndex = 5;
            this.btn_hipolisa.Text = "Hipolisa";
            this.btn_hipolisa.UseVisualStyleBackColor = true;
            this.btn_hipolisa.Click += new System.EventHandler(this.btn_hipolisa_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(296, 327);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Interpolacion";
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(15, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 80);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(144, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 80);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(15, 131);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 80);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(144, 131);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 80);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Inter_4colores
            // 
            this.Inter_4colores.Location = new System.Drawing.Point(15, 217);
            this.Inter_4colores.Name = "Inter_4colores";
            this.Inter_4colores.Size = new System.Drawing.Size(100, 80);
            this.Inter_4colores.TabIndex = 4;
            this.Inter_4colores.UseVisualStyleBackColor = true;
            this.Inter_4colores.Click += new System.EventHandler(this.Inter_4colores_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.ForeColor = System.Drawing.Color.Black;
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPage3.Size = new System.Drawing.Size(296, 327);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Pixel";
            // 
            // btnEncenPixel
            // 
            this.btnEncenPixel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEncenPixel.Location = new System.Drawing.Point(75, 104);
            this.btnEncenPixel.Name = "btnEncenPixel";
            this.btnEncenPixel.Size = new System.Drawing.Size(121, 62);
            this.btnEncenPixel.TabIndex = 0;
            this.btnEncenPixel.Text = "Encender Pixel";
            this.btnEncenPixel.UseVisualStyleBackColor = false;
            this.btnEncenPixel.Click += new System.EventHandler(this.btnEncenPixel_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(310, 362);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Parcial 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(19, 48);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 0;
            this.button7.Text = "2^x";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(177, 48);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 1;
            this.button8.Text = "Ln(x)";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.LightGreen;
            this.tabPage7.Controls.Add(this.button8);
            this.tabPage7.Controls.Add(this.button7);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(284, 321);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "Taylor";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(6, 44);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(121, 23);
            this.button13.TabIndex = 2;
            this.button13.Text = "Puntos Curvas";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // P2comBoxCurvas
            // 
            this.P2comBoxCurvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.P2comBoxCurvas.FormattingEnabled = true;
            this.P2comBoxCurvas.Items.AddRange(new object[] {
            "Poligonal",
            "Lagrange",
            "Beizer",
            "Regresión Lineal"});
            this.P2comBoxCurvas.Location = new System.Drawing.Point(6, 85);
            this.P2comBoxCurvas.Name = "P2comBoxCurvas";
            this.P2comBoxCurvas.Size = new System.Drawing.Size(121, 26);
            this.P2comBoxCurvas.TabIndex = 10;
            this.P2comBoxCurvas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(152, 68);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(102, 23);
            this.button10.TabIndex = 11;
            this.button10.Text = "Nueva curva";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click_1);
            // 
            // tabPage11
            // 
            this.tabPage11.BackColor = System.Drawing.Color.LightGreen;
            this.tabPage11.Controls.Add(this.button10);
            this.tabPage11.Controls.Add(this.P2comBoxCurvas);
            this.tabPage11.Controls.Add(this.button13);
            this.tabPage11.Location = new System.Drawing.Point(4, 25);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(284, 321);
            this.tabPage11.TabIndex = 1;
            this.tabPage11.Text = "Curvas de Ajuste";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(932, 464);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPlano);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lb_Y);
            this.Controls.Add(this.lb_X);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "COMPUTACION GRÁFICA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Animacion.ResumeLayout(false);
            this.Animacion.PerformLayout();
            this.tabControl4.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage11.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lb_X;
        private System.Windows.Forms.Label lb_Y;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnPlano;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl4;
        private System.Windows.Forms.TabPage Animacion;
        private System.Windows.Forms.Button btn_Cantor;
        private System.Windows.Forms.Button btn_hock;
        private System.Windows.Forms.Button btn_sierpinski;
        private System.Windows.Forms.Button btn_Julia;
        private System.Windows.Forms.Button btn_Mandelbrot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.Button btnPoligono;
        private System.Windows.Forms.Button btnLazo;
        private System.Windows.Forms.Button btnSegDinamico;
        private System.Windows.Forms.Button btnHiposila;
        private System.Windows.Forms.Button btnMargarita;
        private System.Windows.Forms.Button btnCircun;
        private System.Windows.Forms.TextBox txtNumlados;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.Button btn_margarita;
        private System.Windows.Forms.Button btn_poligono;
        private System.Windows.Forms.Button btn_lazo;
        private System.Windows.Forms.Button btn_circunferencia;
        private System.Windows.Forms.Button btn_segmento;
        private System.Windows.Forms.Button btn_hipolisa;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Inter_4colores;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnEncenPixel;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ComboBox P2comBoxCurvas;
        private System.Windows.Forms.Button button13;
    }
}

