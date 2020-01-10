namespace appCompuGrafica
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelIzquierda = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFractales = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panelDinamico = new System.Windows.Forms.Panel();
            this.panelHerramientas = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnTools = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panelIzquierda.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(145)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(188, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 46);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "COMPUTACION GRAFICA";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Purple;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(836, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "_";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(876, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelIzquierda
            // 
            this.panelIzquierda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(145)))));
            this.panelIzquierda.Controls.Add(this.panel3);
            this.panelIzquierda.Controls.Add(this.button5);
            this.panelIzquierda.Controls.Add(this.button3);
            this.panelIzquierda.Controls.Add(this.button4);
            this.panelIzquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzquierda.Location = new System.Drawing.Point(0, 0);
            this.panelIzquierda.Name = "panelIzquierda";
            this.panelIzquierda.Size = new System.Drawing.Size(188, 644);
            this.panelIzquierda.TabIndex = 1;
            this.panelIzquierda.Paint += new System.Windows.Forms.PaintEventHandler(this.panelIzquierda_Paint);
            // 
            // btnFractales
            // 
            this.btnFractales.BackColor = System.Drawing.Color.White;
            this.btnFractales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFractales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(145)))));
            this.btnFractales.Location = new System.Drawing.Point(0, 0);
            this.btnFractales.Name = "btnFractales";
            this.btnFractales.Size = new System.Drawing.Size(185, 48);
            this.btnFractales.TabIndex = 0;
            this.btnFractales.Tag = "4";
            this.btnFractales.Text = "  Fractales";
            this.btnFractales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFractales.UseVisualStyleBackColor = false;
            this.btnFractales.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnFractales);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 125);
            this.panel3.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(145)))));
            this.button3.Location = new System.Drawing.Point(3, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 48);
            this.button3.TabIndex = 0;
            this.button3.Tag = "1";
            this.button3.Text = "  Primer Parcial";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(145)))));
            this.button4.Location = new System.Drawing.Point(3, 242);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 48);
            this.button4.TabIndex = 0;
            this.button4.Tag = "2";
            this.button4.Text = "  Segundo Parcial";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(145)))));
            this.button5.Location = new System.Drawing.Point(3, 134);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(185, 48);
            this.button5.TabIndex = 0;
            this.button5.Tag = "3";
            this.button5.Text = "Grupo 1";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelDinamico
            // 
            this.panelDinamico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDinamico.Location = new System.Drawing.Point(188, 46);
            this.panelDinamico.Name = "panelDinamico";
            this.panelDinamico.Size = new System.Drawing.Size(916, 598);
            this.panelDinamico.TabIndex = 3;
            this.panelDinamico.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDinamico_Paint);
            // 
            // panelHerramientas
            // 
            this.panelHerramientas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHerramientas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(145)))));
            this.panelHerramientas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panelHerramientas.Location = new System.Drawing.Point(187, 52);
            this.panelHerramientas.Name = "panelHerramientas";
            this.panelHerramientas.Size = new System.Drawing.Size(916, 10);
            this.panelHerramientas.TabIndex = 4;
            this.panelHerramientas.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnTools
            // 
            this.btnTools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTools.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnTools.AutoSize = true;
            this.btnTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(145)))));
            this.btnTools.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTools.FlatAppearance.BorderSize = 0;
            this.btnTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTools.Image = global::appCompuGrafica.Properties.Resources.maintenance_24px;
            this.btnTools.Location = new System.Drawing.Point(1074, 52);
            this.btnTools.Name = "btnTools";
            this.btnTools.Size = new System.Drawing.Size(30, 30);
            this.btnTools.TabIndex = 5;
            this.btnTools.UseVisualStyleBackColor = false;
            this.btnTools.CheckedChanged += new System.EventHandler(this.btnTools_CheckedChanged);
            // 
            // Principal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1104, 644);
            this.Controls.Add(this.btnTools);
            this.Controls.Add(this.panelHerramientas);
            this.Controls.Add(this.panelDinamico);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelIzquierda);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Principal";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelIzquierda.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel panelIzquierda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDinamico;
        private System.Windows.Forms.GroupBox panelHerramientas;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox btnTools;
        private System.Windows.Forms.Button btnFractales;
    }
}

