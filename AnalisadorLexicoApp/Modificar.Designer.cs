namespace AnalisadorLexicoApp
{
    partial class Modificar
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
            this.btnGuardarSimbolo = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.txtAñadirTipo = new System.Windows.Forms.TextBox();
            this.txtGuardarSimbolo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guardar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dtgvTipos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTipos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarSimbolo
            // 
            this.btnGuardarSimbolo.Location = new System.Drawing.Point(12, 75);
            this.btnGuardarSimbolo.Name = "btnGuardarSimbolo";
            this.btnGuardarSimbolo.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarSimbolo.TabIndex = 0;
            this.btnGuardarSimbolo.Text = "Guardar";
            this.btnGuardarSimbolo.UseVisualStyleBackColor = true;
            this.btnGuardarSimbolo.Click += new System.EventHandler(this.btnGuardarSimbolo_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(159, 75);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(123, 23);
            this.btnAñadir.TabIndex = 1;
            this.btnAñadir.Text = "Añadir Tipo";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // txtAñadirTipo
            // 
            this.txtAñadirTipo.Location = new System.Drawing.Point(159, 46);
            this.txtAñadirTipo.Name = "txtAñadirTipo";
            this.txtAñadirTipo.Size = new System.Drawing.Size(100, 23);
            this.txtAñadirTipo.TabIndex = 2;
            this.txtAñadirTipo.TextChanged += new System.EventHandler(this.txtAñadirTipo_TextChanged);
            // 
            // txtGuardarSimbolo
            // 
            this.txtGuardarSimbolo.Location = new System.Drawing.Point(12, 46);
            this.txtGuardarSimbolo.Name = "txtGuardarSimbolo";
            this.txtGuardarSimbolo.Size = new System.Drawing.Size(100, 23);
            this.txtGuardarSimbolo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Simbolo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipo";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // Guardar
            // 
            this.Guardar.HeaderText = "Guardar";
            this.Guardar.Name = "Guardar";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            // 
            // dtgvTipos
            // 
            this.dtgvTipos.AllowUserToAddRows = false;
            this.dtgvTipos.AllowUserToDeleteRows = false;
            this.dtgvTipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.Guardar,
            this.Eliminar});
            this.dtgvTipos.Location = new System.Drawing.Point(119, 120);
            this.dtgvTipos.Name = "dtgvTipos";
            this.dtgvTipos.Size = new System.Drawing.Size(326, 150);
            this.dtgvTipos.TabIndex = 6;
            this.dtgvTipos.Text = "dataGridView1";
            this.dtgvTipos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTipos_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cambiar Simbolo";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(133, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar Tipo";
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 323);
            this.Controls.Add(this.dtgvTipos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGuardarSimbolo);
            this.Controls.Add(this.txtAñadirTipo);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.btnGuardarSimbolo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Modificar";
            this.Text = "Modificar";
            this.Load += new System.EventHandler(this.Modificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarSimbolo;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.TextBox txtAñadirTipo;
        private System.Windows.Forms.TextBox txtGuardarSimbolo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewButtonColumn Guardar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridView dtgvTipos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}