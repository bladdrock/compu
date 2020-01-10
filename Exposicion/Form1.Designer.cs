namespace Exposicion
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
            this.btn_borrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VentanaP)).BeginInit();
            this.SuspendLayout();
            // 
            // VentanaP
            // 
            this.VentanaP.BackColor = System.Drawing.Color.White;
            this.VentanaP.Location = new System.Drawing.Point(114, 84);
            this.VentanaP.Margin = new System.Windows.Forms.Padding(4);
            this.VentanaP.Name = "VentanaP";
            this.VentanaP.Size = new System.Drawing.Size(800, 615);
            this.VentanaP.TabIndex = 1;
            this.VentanaP.TabStop = false;
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(960, 294);
            this.btn_borrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(100, 28);
            this.btn_borrar.TabIndex = 4;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(960, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 81);
            this.button1.TabIndex = 5;
            this.button1.Text = "Paisaje Fractal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "Paisajes Fractales";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 745);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.VentanaP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VentanaP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox VentanaP;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

