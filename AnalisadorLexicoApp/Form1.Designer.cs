namespace AnalisadorLexicoApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIngresarTexto = new System.Windows.Forms.Button();
            this.btnTablaSimbolos = new System.Windows.Forms.Button();
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.Simbolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvSimbolos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcepciones = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSimbolos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresarTexto
            // 
            this.btnIngresarTexto.Location = new System.Drawing.Point(308, 37);
            this.btnIngresarTexto.Name = "btnIngresarTexto";
            this.btnIngresarTexto.Size = new System.Drawing.Size(145, 23);
            this.btnIngresarTexto.TabIndex = 0;
            this.btnIngresarTexto.Text = "Examinar...";
            this.btnIngresarTexto.UseVisualStyleBackColor = true;
            this.btnIngresarTexto.Click += new System.EventHandler(this.btnIngresarTexto_Click);
            // 
            // btnTablaSimbolos
            // 
            this.btnTablaSimbolos.Location = new System.Drawing.Point(12, 37);
            this.btnTablaSimbolos.Name = "btnTablaSimbolos";
            this.btnTablaSimbolos.Size = new System.Drawing.Size(141, 23);
            this.btnTablaSimbolos.TabIndex = 1;
            this.btnTablaSimbolos.Text = "Tabla Simbolos";
            this.btnTablaSimbolos.UseVisualStyleBackColor = true;
            this.btnTablaSimbolos.Click += new System.EventHandler(this.btnTablaSimbolos_Click);
            // 
            // btnAnalizar
            // 
            this.btnAnalizar.Location = new System.Drawing.Point(180, 90);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(75, 23);
            this.btnAnalizar.TabIndex = 2;
            this.btnAnalizar.Text = "Analizar";
            this.btnAnalizar.UseVisualStyleBackColor = true;
            this.btnAnalizar.Click += new System.EventHandler(this.btnAnalizar_Click);
            // 
            // Simbolo
            // 
            this.Simbolo.HeaderText = "Simbolo";
            this.Simbolo.Name = "Simbolo";
            this.Simbolo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Ubicacion
            // 
            this.Ubicacion.HeaderText = "Ubicacion";
            this.Ubicacion.Name = "Ubicacion";
            this.Ubicacion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Tipos
            // 
            this.Tipos.HeaderText = "Tipos";
            this.Tipos.Name = "Tipos";
            this.Tipos.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Tipos.Width = 200;
            // 
            // dtgvSimbolos
            // 
            this.dtgvSimbolos.AllowUserToAddRows = false;
            this.dtgvSimbolos.AllowUserToDeleteRows = false;
            this.dtgvSimbolos.AllowUserToResizeRows = false;
            this.dtgvSimbolos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSimbolos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Simbolo,
            this.Ubicacion,
            this.Tipos});
            this.dtgvSimbolos.Location = new System.Drawing.Point(30, 119);
            this.dtgvSimbolos.Name = "dtgvSimbolos";
            this.dtgvSimbolos.Size = new System.Drawing.Size(423, 289);
            this.dtgvSimbolos.TabIndex = 3;
            this.dtgvSimbolos.Text = "dataGridView1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingresar Texto";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 359);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Analisis";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnExcepciones
            // 
            this.btnExcepciones.Location = new System.Drawing.Point(159, 37);
            this.btnExcepciones.Name = "btnExcepciones";
            this.btnExcepciones.Size = new System.Drawing.Size(143, 23);
            this.btnExcepciones.TabIndex = 6;
            this.btnExcepciones.Text = "Excepciones";
            this.btnExcepciones.UseVisualStyleBackColor = true;
            this.btnExcepciones.Click += new System.EventHandler(this.btnExcepciones_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Excepciones de identificadores";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 456);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExcepciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvSimbolos);
            this.Controls.Add(this.btnAnalizar);
            this.Controls.Add(this.btnTablaSimbolos);
            this.Controls.Add(this.btnIngresarTexto);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Ingresar Texto";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSimbolos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarTexto;
        private System.Windows.Forms.Button btnTablaSimbolos;
        private System.Windows.Forms.Button btnAnalizar;
        private System.Windows.Forms.DataGridView dtgvSimbolos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Simbolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExcepciones;
        private System.Windows.Forms.Label label2;
    }
}

