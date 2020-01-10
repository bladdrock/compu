namespace PixelNuevoCGWF
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnClearLines = new System.Windows.Forms.Button();
            this.button47 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClipLines = new System.Windows.Forms.Button();
            this.PBMonitor = new System.Windows.Forms.PictureBox();
            this.button44 = new System.Windows.Forms.Button();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.button12 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBMonitor)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Cyan;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Location = new System.Drawing.Point(12, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 566);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown_1);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(12, 574);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 34);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "SALIR";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Location = new System.Drawing.Point(150, 574);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(132, 34);
            this.btnClean.TabIndex = 7;
            this.btnClean.Text = "LIMPIAR";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(719, 574);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Coordenadas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(644, 584);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 51;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Engravers MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Brown;
            this.lblTitulo.Location = new System.Drawing.Point(915, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(485, 28);
            this.lblTitulo.TabIndex = 52;
            this.lblTitulo.Text = "GRAFICOS PR COMPUTADOR";
            // 
            // splitContainer1
            // 
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(12, 2);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.btnClearLines);
            this.splitContainer1.Panel1.Controls.Add(this.button47);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox9);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.btnClipLines);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.PBMonitor);
            this.splitContainer1.Size = new System.Drawing.Size(800, 566);
            this.splitContainer1.SplitterDistance = 44;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 54;
            this.splitContainer1.Visible = false;
            // 
            // btnClearLines
            // 
            this.btnClearLines.Location = new System.Drawing.Point(566, 9);
            this.btnClearLines.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearLines.Name = "btnClearLines";
            this.btnClearLines.Size = new System.Drawing.Size(111, 28);
            this.btnClearLines.TabIndex = 8;
            this.btnClearLines.Text = "LIMPIAR";
            this.btnClearLines.UseVisualStyleBackColor = true;
            // 
            // button47
            // 
            this.button47.Location = new System.Drawing.Point(685, 9);
            this.button47.Margin = new System.Windows.Forms.Padding(4);
            this.button47.Name = "button47";
            this.button47.Size = new System.Drawing.Size(111, 28);
            this.button47.TabIndex = 7;
            this.button47.Text = "SALIR";
            this.button47.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label9.Location = new System.Drawing.Point(250, 6);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 36);
            this.label9.TabIndex = 6;
            this.label9.Text = "Algoritmo Cohen Sutherland ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Items.AddRange(new object[] {
            "Lineas",
            "Poligono"});
            this.comboBox9.Location = new System.Drawing.Point(82, 9);
            this.comboBox9.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(160, 24);
            this.comboBox9.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "OPCIONES";
            // 
            // btnClipLines
            // 
            this.btnClipLines.Location = new System.Drawing.Point(448, 9);
            this.btnClipLines.Margin = new System.Windows.Forms.Padding(4);
            this.btnClipLines.Name = "btnClipLines";
            this.btnClipLines.Size = new System.Drawing.Size(111, 28);
            this.btnClipLines.TabIndex = 0;
            this.btnClipLines.Text = "RECORTAR";
            this.btnClipLines.UseVisualStyleBackColor = true;
            // 
            // PBMonitor
            // 
            this.PBMonitor.BackColor = System.Drawing.Color.Transparent;
            this.PBMonitor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBMonitor.BackgroundImage")));
            this.PBMonitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBMonitor.Location = new System.Drawing.Point(0, -60);
            this.PBMonitor.Margin = new System.Windows.Forms.Padding(4);
            this.PBMonitor.Name = "PBMonitor";
            this.PBMonitor.Size = new System.Drawing.Size(801, 645);
            this.PBMonitor.TabIndex = 55;
            this.PBMonitor.TabStop = false;
            this.PBMonitor.Visible = false;
            // 
            // button44
            // 
            this.button44.BackColor = System.Drawing.Color.Beige;
            this.button44.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button44.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button44.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button44.Location = new System.Drawing.Point(849, 148);
            this.button44.Margin = new System.Windows.Forms.Padding(4);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(145, 39);
            this.button44.TabIndex = 45;
            this.button44.Text = "Spline Cúbica";
            this.button44.UseVisualStyleBackColor = false;
            this.button44.Click += new System.EventHandler(this.button44_Click);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(885, 90);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(73, 21);
            this.radioButton9.TabIndex = 36;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Puntos";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(1014, 195);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(111, 21);
            this.radioButton11.TabIndex = 40;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "Añadir Datos";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(1032, 228);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 41;
            this.button12.Text = "Nuevo";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1449, 649);
            this.Controls.Add(this.button44);
            this.Controls.Add(this.radioButton9);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.radioButton11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBMonitor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClipLines;
        private System.Windows.Forms.Button button47;
        private System.Windows.Forms.Button btnClearLines;
        private System.Windows.Forms.PictureBox PBMonitor;
        private System.Windows.Forms.Button button44;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.Button button12;
    }
}

