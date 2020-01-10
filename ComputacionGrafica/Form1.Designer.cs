namespace ComputacionGrafica
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
            this.PBLienzo = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.ARBtnVisto = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.ARG = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.ARR = new System.Windows.Forms.TextBox();
            this.ARB = new System.Windows.Forms.TextBox();
            this.anim2 = new System.Windows.Forms.PictureBox();
            this.anim1 = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.ARBtnPuntos = new System.Windows.Forms.Button();
            this.ARBtnInundacion = new System.Windows.Forms.Button();
            this.ARBtnScanLine = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.LblX = new System.Windows.Forms.Label();
            this.LblY = new System.Windows.Forms.Label();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBLienzo)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anim2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anim1)).BeginInit();
            this.SuspendLayout();
            // 
            // PBLienzo
            // 
            this.PBLienzo.BackColor = System.Drawing.Color.White;
            this.PBLienzo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBLienzo.Location = new System.Drawing.Point(0, 0);
            this.PBLienzo.Name = "PBLienzo";
            this.PBLienzo.Size = new System.Drawing.Size(560, 400);
            this.PBLienzo.TabIndex = 0;
            this.PBLienzo.TabStop = false;
            this.PBLienzo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PBLienzo_MouseDown);
            this.PBLienzo.MouseLeave += new System.EventHandler(this.PBLienzo_MouseLeave);
            this.PBLienzo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PBLienzo_MouseMove);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(593, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(383, 400);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage6.Controls.Add(this.ARBtnVisto);
            this.tabPage6.Controls.Add(this.label20);
            this.tabPage6.Controls.Add(this.ARG);
            this.tabPage6.Controls.Add(this.label21);
            this.tabPage6.Controls.Add(this.ARR);
            this.tabPage6.Controls.Add(this.ARB);
            this.tabPage6.Controls.Add(this.anim2);
            this.tabPage6.Controls.Add(this.anim1);
            this.tabPage6.Controls.Add(this.label19);
            this.tabPage6.Controls.Add(this.ARBtnPuntos);
            this.tabPage6.Controls.Add(this.ARBtnInundacion);
            this.tabPage6.Controls.Add(this.ARBtnScanLine);
            this.tabPage6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tabPage6.Location = new System.Drawing.Point(4, 24);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(375, 372);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Algoritmos de Relleno";
            // 
            // ARBtnVisto
            // 
            this.ARBtnVisto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ARBtnVisto.BackgroundImage")));
            this.ARBtnVisto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ARBtnVisto.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ARBtnVisto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ARBtnVisto.Location = new System.Drawing.Point(196, 240);
            this.ARBtnVisto.Name = "ARBtnVisto";
            this.ARBtnVisto.Size = new System.Drawing.Size(32, 27);
            this.ARBtnVisto.TabIndex = 44;
            this.ARBtnVisto.UseVisualStyleBackColor = true;
            this.ARBtnVisto.Click += new System.EventHandler(this.ARBtnVisto_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label20.Location = new System.Drawing.Point(99, 161);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(198, 19);
            this.label20.TabIndex = 43;
            this.label20.Text = "- COLOR DEL RELLENO -";
            // 
            // ARG
            // 
            this.ARG.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ARG.Location = new System.Drawing.Point(205, 194);
            this.ARG.Name = "ARG";
            this.ARG.Size = new System.Drawing.Size(51, 26);
            this.ARG.TabIndex = 41;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label21.Location = new System.Drawing.Point(52, 197);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(90, 19);
            this.label21.TabIndex = 39;
            this.label21.Text = "Color RGB";
            // 
            // ARR
            // 
            this.ARR.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ARR.Location = new System.Drawing.Point(148, 194);
            this.ARR.Name = "ARR";
            this.ARR.Size = new System.Drawing.Size(51, 26);
            this.ARR.TabIndex = 40;
            // 
            // ARB
            // 
            this.ARB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ARB.Location = new System.Drawing.Point(262, 194);
            this.ARB.Name = "ARB";
            this.ARB.Size = new System.Drawing.Size(51, 26);
            this.ARB.TabIndex = 42;
            // 
            // anim2
            // 
            this.anim2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.anim2.Image = ((System.Drawing.Image)(resources.GetObject("anim2.Image")));
            this.anim2.Location = new System.Drawing.Point(221, 58);
            this.anim2.Name = "anim2";
            this.anim2.Size = new System.Drawing.Size(94, 81);
            this.anim2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.anim2.TabIndex = 33;
            this.anim2.TabStop = false;
            // 
            // anim1
            // 
            this.anim1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.anim1.Image = ((System.Drawing.Image)(resources.GetObject("anim1.Image")));
            this.anim1.Location = new System.Drawing.Point(65, 58);
            this.anim1.Name = "anim1";
            this.anim1.Size = new System.Drawing.Size(93, 81);
            this.anim1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.anim1.TabIndex = 32;
            this.anim1.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(83, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(234, 19);
            this.label19.TabIndex = 29;
            this.label19.Text = "- ALGORITMOS DE RELLENO -";
            // 
            // ARBtnPuntos
            // 
            this.ARBtnPuntos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ARBtnPuntos.BackgroundImage")));
            this.ARBtnPuntos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ARBtnPuntos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ARBtnPuntos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ARBtnPuntos.Location = new System.Drawing.Point(148, 240);
            this.ARBtnPuntos.Name = "ARBtnPuntos";
            this.ARBtnPuntos.Size = new System.Drawing.Size(32, 27);
            this.ARBtnPuntos.TabIndex = 28;
            this.ARBtnPuntos.UseVisualStyleBackColor = true;
            this.ARBtnPuntos.Click += new System.EventHandler(this.ARBtnPuntos_Click);
            // 
            // ARBtnInundacion
            // 
            this.ARBtnInundacion.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ARBtnInundacion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ARBtnInundacion.Location = new System.Drawing.Point(218, 283);
            this.ARBtnInundacion.Name = "ARBtnInundacion";
            this.ARBtnInundacion.Size = new System.Drawing.Size(123, 43);
            this.ARBtnInundacion.TabIndex = 27;
            this.ARBtnInundacion.Text = "Inundación";
            this.ARBtnInundacion.UseVisualStyleBackColor = true;
            this.ARBtnInundacion.Click += new System.EventHandler(this.ARBtnInundacion_Click);
            // 
            // ARBtnScanLine
            // 
            this.ARBtnScanLine.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ARBtnScanLine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ARBtnScanLine.Location = new System.Drawing.Point(45, 283);
            this.ARBtnScanLine.Name = "ARBtnScanLine";
            this.ARBtnScanLine.Size = new System.Drawing.Size(113, 43);
            this.ARBtnScanLine.TabIndex = 26;
            this.ARBtnScanLine.Text = "Scan-Line";
            this.ARBtnScanLine.UseVisualStyleBackColor = true;
            this.ARBtnScanLine.Click += new System.EventHandler(this.ARBtnScanLine_Click);
            // 
            // LblX
            // 
            this.LblX.AutoSize = true;
            this.LblX.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblX.Location = new System.Drawing.Point(169, 408);
            this.LblX.Name = "LblX";
            this.LblX.Size = new System.Drawing.Size(22, 24);
            this.LblX.TabIndex = 3;
            this.LblX.Text = "X";
            // 
            // LblY
            // 
            this.LblY.AutoSize = true;
            this.LblY.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblY.Location = new System.Drawing.Point(268, 408);
            this.LblY.Name = "LblY";
            this.LblY.Size = new System.Drawing.Size(22, 24);
            this.LblY.TabIndex = 4;
            this.LblY.Text = "Y";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnLimpiar.Location = new System.Drawing.Point(718, 417);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(133, 52);
            this.BtnLimpiar.TabIndex = 22;
            this.BtnLimpiar.Text = "Limpiar pantalla";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // txtY
            // 
            this.txtY.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtY.Location = new System.Drawing.Point(296, 406);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(51, 26);
            this.txtY.TabIndex = 23;
            // 
            // txtX
            // 
            this.txtX.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX.Location = new System.Drawing.Point(197, 406);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(51, 26);
            this.txtX.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(981, 506);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.LblY);
            this.Controls.Add(this.LblX);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.PBLienzo);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PBLienzo)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anim2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anim1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBLienzo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label LblX;
        private System.Windows.Forms.Label LblY;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Button ARBtnInundacion;
        private System.Windows.Forms.Button ARBtnScanLine;
        private System.Windows.Forms.PictureBox anim1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button ARBtnPuntos;
        private System.Windows.Forms.PictureBox anim2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox ARG;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox ARR;
        private System.Windows.Forms.TextBox ARB;
        private System.Windows.Forms.Button ARBtnVisto;
    }
}

