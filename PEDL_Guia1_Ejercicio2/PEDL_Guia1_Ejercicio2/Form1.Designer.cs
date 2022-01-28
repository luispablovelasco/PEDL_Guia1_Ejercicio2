namespace PEDL_Guia1_Ejercicio2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nUPX = new System.Windows.Forms.NumericUpDown();
            this.nUPY = new System.Windows.Forms.NumericUpDown();
            this.nuptamaño = new System.Windows.Forms.NumericUpDown();
            this.btndraw = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbcolores = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nUPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuptamaño)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 284);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Area de Dibujo";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Circulo",
            "Rectangulo"});
            this.listBox1.Location = new System.Drawing.Point(394, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(230, 43);
            this.listBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tamaño:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Y:";
            // 
            // nUPX
            // 
            this.nUPX.Location = new System.Drawing.Point(483, 167);
            this.nUPX.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nUPX.Name = "nUPX";
            this.nUPX.Size = new System.Drawing.Size(102, 20);
            this.nUPX.TabIndex = 6;
            // 
            // nUPY
            // 
            this.nUPY.Location = new System.Drawing.Point(483, 206);
            this.nUPY.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nUPY.Name = "nUPY";
            this.nUPY.Size = new System.Drawing.Size(102, 20);
            this.nUPY.TabIndex = 7;
            // 
            // nuptamaño
            // 
            this.nuptamaño.Location = new System.Drawing.Point(494, 130);
            this.nuptamaño.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nuptamaño.Name = "nuptamaño";
            this.nuptamaño.Size = new System.Drawing.Size(103, 20);
            this.nuptamaño.TabIndex = 8;
            // 
            // btndraw
            // 
            this.btndraw.Location = new System.Drawing.Point(429, 289);
            this.btndraw.Name = "btndraw";
            this.btndraw.Size = new System.Drawing.Size(167, 35);
            this.btndraw.TabIndex = 9;
            this.btndraw.Text = "DIBUJAR";
            this.btndraw.UseVisualStyleBackColor = true;
            this.btndraw.Click += new System.EventHandler(this.btndraw_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Color:";
            // 
            // cmbcolores
            // 
            this.cmbcolores.FormattingEnabled = true;
            this.cmbcolores.Location = new System.Drawing.Point(494, 243);
            this.cmbcolores.Name = "cmbcolores";
            this.cmbcolores.Size = new System.Drawing.Size(103, 21);
            this.cmbcolores.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 351);
            this.Controls.Add(this.cmbcolores);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btndraw);
            this.Controls.Add(this.nuptamaño);
            this.Controls.Add(this.nUPY);
            this.Controls.Add(this.nUPX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nUPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuptamaño)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nUPX;
        private System.Windows.Forms.NumericUpDown nUPY;
        private System.Windows.Forms.NumericUpDown nuptamaño;
        private System.Windows.Forms.Button btndraw;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbcolores;
    }
}

