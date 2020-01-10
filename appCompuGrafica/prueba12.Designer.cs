namespace appCompuGrafica
{
    partial class prueba12
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(prueba12));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCoordenadas = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_ejes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button10 = new System.Windows.Forms.Button();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.btnTriangulo = new System.Windows.Forms.Button();
            this.btnPintar1 = new System.Windows.Forms.Button();
            this.btnEjes = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.lblCoordenadas});
            this.statusStrip1.Location = new System.Drawing.Point(0, 549);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(875, 22);
            this.statusStrip1.TabIndex = 101;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(37, 17);
            this.toolStripStatusLabel2.Text = "          ";
            // 
            // lblCoordenadas
            // 
            this.lblCoordenadas.Name = "lblCoordenadas";
            this.lblCoordenadas.Size = new System.Drawing.Size(103, 17);
            this.lblCoordenadas.Text = "x=00.000 ; y=0.000";
            this.lblCoordenadas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_ejes
            // 
            this.btn_ejes.Location = new System.Drawing.Point(11, 524);
            this.btn_ejes.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ejes.Name = "btn_ejes";
            this.btn_ejes.Size = new System.Drawing.Size(56, 22);
            this.btn_ejes.TabIndex = 100;
            this.btn_ejes.Text = "EJES";
            this.btn_ejes.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(13, 64);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(578, 439);
            this.pictureBox1.TabIndex = 99;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(523, 524);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(48, 22);
            this.button10.TabIndex = 98;
            this.button10.Text = "SALIR";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfiguracion.BackColor = System.Drawing.Color.White;
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(70)))), ((int)(((byte)(190)))));
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Image = ((System.Drawing.Image)(resources.GetObject("btnConfiguracion.Image")));
            this.btnConfiguracion.Location = new System.Drawing.Point(777, 10);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(48, 52);
            this.btnConfiguracion.TabIndex = 107;
            this.btnConfiguracion.UseVisualStyleBackColor = false;
            // 
            // btnTriangulo
            // 
            this.btnTriangulo.BackColor = System.Drawing.Color.DarkViolet;
            this.btnTriangulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTriangulo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTriangulo.ForeColor = System.Drawing.Color.White;
            this.btnTriangulo.Location = new System.Drawing.Point(652, 166);
            this.btnTriangulo.Margin = new System.Windows.Forms.Padding(2);
            this.btnTriangulo.Name = "btnTriangulo";
            this.btnTriangulo.Size = new System.Drawing.Size(119, 43);
            this.btnTriangulo.TabIndex = 105;
            this.btnTriangulo.Text = "TRIANGULO";
            this.btnTriangulo.UseVisualStyleBackColor = false;
            // 
            // btnPintar1
            // 
            this.btnPintar1.BackColor = System.Drawing.Color.DarkViolet;
            this.btnPintar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPintar1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPintar1.ForeColor = System.Drawing.Color.White;
            this.btnPintar1.Location = new System.Drawing.Point(652, 110);
            this.btnPintar1.Margin = new System.Windows.Forms.Padding(2);
            this.btnPintar1.Name = "btnPintar1";
            this.btnPintar1.Size = new System.Drawing.Size(119, 43);
            this.btnPintar1.TabIndex = 106;
            this.btnPintar1.Text = "PINTAR 1";
            this.btnPintar1.UseVisualStyleBackColor = false;
            this.btnPintar1.Click += new System.EventHandler(this.btnPintar1_Click);
            // 
            // btnEjes
            // 
            this.btnEjes.FlatAppearance.BorderSize = 0;
            this.btnEjes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnEjes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjes.Image = ((System.Drawing.Image)(resources.GetObject("btnEjes.Image")));
            this.btnEjes.Location = new System.Drawing.Point(496, 64);
            this.btnEjes.Margin = new System.Windows.Forms.Padding(2);
            this.btnEjes.Name = "btnEjes";
            this.btnEjes.Size = new System.Drawing.Size(38, 40);
            this.btnEjes.TabIndex = 103;
            this.btnEjes.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(538, 64);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(38, 40);
            this.btnLimpiar.TabIndex = 104;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.label1.Location = new System.Drawing.Point(309, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 39);
            this.label1.TabIndex = 102;
            this.label1.Text = "PRUEBA PARCIAL 1";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(510, 65);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 40);
            this.button1.TabIndex = 108;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(552, 65);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 40);
            this.button3.TabIndex = 109;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // prueba12
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_ejes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.btnConfiguracion);
            this.Controls.Add(this.btnTriangulo);
            this.Controls.Add(this.btnPintar1);
            this.Controls.Add(this.btnEjes);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label1);
            this.Name = "prueba12";
            this.Size = new System.Drawing.Size(875, 571);
            this.Load += new System.EventHandler(this.prueba12_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblCoordenadas;
        private System.Windows.Forms.Button btn_ejes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Button btnTriangulo;
        private System.Windows.Forms.Button btnPintar1;
        private System.Windows.Forms.Button btnEjes;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}
