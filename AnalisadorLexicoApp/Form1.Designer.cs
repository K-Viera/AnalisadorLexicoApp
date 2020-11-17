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
            this.button1 = new System.Windows.Forms.Button();
            this.btnAnalizarTokens = new System.Windows.Forms.Button();
            this.Token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TokenId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lexema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvTokens = new System.Windows.Forms.DataGridView();
            this.btnAritmetica = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrueba = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSimbolos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTokens)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresarTexto
            // 
            this.btnIngresarTexto.Location = new System.Drawing.Point(518, 36);
            this.btnIngresarTexto.Name = "btnIngresarTexto";
            this.btnIngresarTexto.Size = new System.Drawing.Size(145, 23);
            this.btnIngresarTexto.TabIndex = 0;
            this.btnIngresarTexto.Text = "Examinar...";
            this.btnIngresarTexto.UseVisualStyleBackColor = true;
            this.btnIngresarTexto.Click += new System.EventHandler(this.btnIngresarTexto_Click);
            // 
            // btnTablaSimbolos
            // 
            this.btnTablaSimbolos.Location = new System.Drawing.Point(177, 37);
            this.btnTablaSimbolos.Name = "btnTablaSimbolos";
            this.btnTablaSimbolos.Size = new System.Drawing.Size(141, 23);
            this.btnTablaSimbolos.TabIndex = 1;
            this.btnTablaSimbolos.Text = "Tabla Simbolos";
            this.btnTablaSimbolos.UseVisualStyleBackColor = true;
            this.btnTablaSimbolos.Click += new System.EventHandler(this.btnTablaSimbolos_Click);
            // 
            // btnAnalizar
            // 
            this.btnAnalizar.Location = new System.Drawing.Point(138, 14);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(140, 21);
            this.btnAnalizar.TabIndex = 2;
            this.btnAnalizar.Text = "Analizar Simbolos";
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
            this.dtgvSimbolos.Location = new System.Drawing.Point(37, 44);
            this.dtgvSimbolos.Name = "dtgvSimbolos";
            this.dtgvSimbolos.Size = new System.Drawing.Size(423, 287);
            this.dtgvSimbolos.TabIndex = 3;
            this.dtgvSimbolos.Text = "dataGridView1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(550, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingresar Texto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvSimbolos);
            this.groupBox1.Controls.Add(this.btnAnalizar);
            this.groupBox1.Location = new System.Drawing.Point(12, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 357);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Analisis Tabla Simbolos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnExcepciones
            // 
            this.btnExcepciones.Location = new System.Drawing.Point(352, 36);
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
            this.label2.Location = new System.Drawing.Point(337, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Excepciones de identificadores";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tabla Tokens";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAnalizarTokens
            // 
            this.btnAnalizarTokens.Location = new System.Drawing.Point(119, 12);
            this.btnAnalizarTokens.Name = "btnAnalizarTokens";
            this.btnAnalizarTokens.Size = new System.Drawing.Size(124, 23);
            this.btnAnalizarTokens.TabIndex = 8;
            this.btnAnalizarTokens.Text = "Analizar Tokens";
            this.btnAnalizarTokens.UseVisualStyleBackColor = true;
            this.btnAnalizarTokens.Click += new System.EventHandler(this.btnAnalizarTokens_Click);
            // 
            // Token
            // 
            this.Token.HeaderText = "Token";
            this.Token.Name = "Token";
            // 
            // TokenId
            // 
            this.TokenId.HeaderText = "TokenId";
            this.TokenId.Name = "TokenId";
            // 
            // Lexema
            // 
            this.Lexema.HeaderText = "Lexema";
            this.Lexema.Name = "Lexema";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvTokens);
            this.groupBox2.Controls.Add(this.btnAnalizarTokens);
            this.groupBox2.Location = new System.Drawing.Point(500, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 356);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Analisis Tabla Tokens";
            // 
            // dtgvTokens
            // 
            this.dtgvTokens.AllowUserToAddRows = false;
            this.dtgvTokens.AllowUserToDeleteRows = false;
            this.dtgvTokens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTokens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Token,
            this.TokenId,
            this.Lexema});
            this.dtgvTokens.Location = new System.Drawing.Point(15, 43);
            this.dtgvTokens.Name = "dtgvTokens";
            this.dtgvTokens.Size = new System.Drawing.Size(341, 287);
            this.dtgvTokens.TabIndex = 9;
            this.dtgvTokens.Text = "dataGridView1";
            // 
            // btnAritmetica
            // 
            this.btnAritmetica.Location = new System.Drawing.Point(709, 36);
            this.btnAritmetica.Name = "btnAritmetica";
            this.btnAritmetica.Size = new System.Drawing.Size(127, 23);
            this.btnAritmetica.TabIndex = 11;
            this.btnAritmetica.Text = "Aritmetica";
            this.btnAritmetica.UseVisualStyleBackColor = true;
            this.btnAritmetica.Click += new System.EventHandler(this.btnAritmetica_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(686, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Analizar Propiedades Aritmeticas";
            // 
            // btnPrueba
            // 
            this.btnPrueba.Location = new System.Drawing.Point(804, 67);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(75, 23);
            this.btnPrueba.TabIndex = 13;
            this.btnPrueba.Text = "Prueba";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 480);
            this.Controls.Add(this.btnPrueba);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAritmetica);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExcepciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTablaSimbolos);
            this.Controls.Add(this.btnIngresarTexto);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Ingresar Texto";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSimbolos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTokens)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAnalizarTokens;
        private System.Windows.Forms.DataGridViewTextBoxColumn Token;
        private System.Windows.Forms.DataGridViewTextBoxColumn TokenId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lexema;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvTokens;
        private System.Windows.Forms.Button btnAritmetica;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrueba;
    }
}

