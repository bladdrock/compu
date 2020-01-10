namespace AplicacionCG
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
            this.VentanaP = new System.Windows.Forms.PictureBox();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Cerrar = new System.Windows.Forms.Button();
            this.Superficie = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.VentanaP)).BeginInit();
            this.SuspendLayout();
            // 
            // VentanaP
            // 
            this.VentanaP.BackColor = System.Drawing.Color.Black;
            this.VentanaP.Location = new System.Drawing.Point(12, 38);
            this.VentanaP.Name = "VentanaP";
            this.VentanaP.Size = new System.Drawing.Size(560, 400);
            this.VentanaP.TabIndex = 0;
            this.VentanaP.TabStop = false;
            // 
            // Limpiar
            // 
            this.Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpiar.Location = new System.Drawing.Point(625, 300);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 15;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(876, 300);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 29;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Superficie
            // 
            this.Superficie.Location = new System.Drawing.Point(788, 164);
            this.Superficie.Name = "Superficie";
            this.Superficie.Size = new System.Drawing.Size(147, 71);
            this.Superficie.TabIndex = 1;
            this.Superficie.Text = "Encender Superficie";
            this.Superficie.UseVisualStyleBackColor = true;
            this.Superficie.Click += new System.EventHandler(this.Superficie_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(641, 190);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1061, 483);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Superficie);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.VentanaP);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.VentanaP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox VentanaP;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.Button Superficie;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

