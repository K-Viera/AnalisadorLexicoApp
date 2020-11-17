namespace AnalisadorLexicoApp
{
    partial class TablaSimbolos
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtSimbolo = new System.Windows.Forms.TextBox();
            this.txtTipoInicial = new System.Windows.Forms.TextBox();
            this.lblSimbolo = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Simbolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dtgvConfiguracionSimbolos = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvConfiguracionSimbolos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(313, 34);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtSimbolo
            // 
            this.txtSimbolo.Location = new System.Drawing.Point(79, 45);
            this.txtSimbolo.Name = "txtSimbolo";
            this.txtSimbolo.Size = new System.Drawing.Size(100, 23);
            this.txtSimbolo.TabIndex = 2;
            // 
            // txtTipoInicial
            // 
            this.txtTipoInicial.Location = new System.Drawing.Point(207, 45);
            this.txtTipoInicial.Name = "txtTipoInicial";
            this.txtTipoInicial.Size = new System.Drawing.Size(100, 23);
            this.txtTipoInicial.TabIndex = 3;
            // 
            // lblSimbolo
            // 
            this.lblSimbolo.AutoSize = true;
            this.lblSimbolo.Location = new System.Drawing.Point(79, 19);
            this.lblSimbolo.Name = "lblSimbolo";
            this.lblSimbolo.Size = new System.Drawing.Size(51, 15);
            this.lblSimbolo.TabIndex = 4;
            this.lblSimbolo.Text = "Simbolo";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(207, 19);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(64, 15);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "Tipo Inicial";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSimbolo);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.lblTipo);
            this.groupBox1.Controls.Add(this.txtTipoInicial);
            this.groupBox1.Controls.Add(this.lblSimbolo);
            this.groupBox1.Location = new System.Drawing.Point(30, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 74);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Simbolo";
            // 
            // Simbolo
            // 
            this.Simbolo.HeaderText = "Simbolo";
            this.Simbolo.Name = "Simbolo";
            this.Simbolo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Tipos
            // 
            this.Tipos.HeaderText = "Tipos";
            this.Tipos.Name = "Tipos";
            this.Tipos.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Tipos.Width = 200;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Name = "Editar";
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.Text = "Editar";
            // 
            // dtgvConfiguracionSimbolos
            // 
            this.dtgvConfiguracionSimbolos.AllowUserToAddRows = false;
            this.dtgvConfiguracionSimbolos.AllowUserToDeleteRows = false;
            this.dtgvConfiguracionSimbolos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvConfiguracionSimbolos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Simbolo,
            this.Tipos,
            this.Editar});
            this.dtgvConfiguracionSimbolos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtgvConfiguracionSimbolos.Location = new System.Drawing.Point(52, 95);
            this.dtgvConfiguracionSimbolos.Name = "dtgvConfiguracionSimbolos";
            this.dtgvConfiguracionSimbolos.Size = new System.Drawing.Size(446, 269);
            this.dtgvConfiguracionSimbolos.TabIndex = 0;
            this.dtgvConfiguracionSimbolos.Text = "dataGridView1";
            this.dtgvConfiguracionSimbolos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvConfiguracionSimbolos_CellClick);
            this.dtgvConfiguracionSimbolos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvConfiguracionSimbolos_CellContentClick);
            // 
            // TablaSimbolos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 404);
            this.Controls.Add(this.dtgvConfiguracionSimbolos);
            this.Controls.Add(this.groupBox1);
            this.Name = "TablaSimbolos";
            this.Text = "TablaSimbolos";
            this.Load += new System.EventHandler(this.TablaSimbolos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvConfiguracionSimbolos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgvConfiguracionSimbolos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtSimbolo;
        private System.Windows.Forms.TextBox txtTipoInicial;
        private System.Windows.Forms.Label lblSimbolo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEjemplos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Simbolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipos;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
    }
}