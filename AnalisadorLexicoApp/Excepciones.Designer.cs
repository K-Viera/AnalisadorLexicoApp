namespace AnalizadorLexicoApp
{
    partial class Excepciones
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
            this.txtExcepcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Caracter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dtgvExcepciones = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvExcepciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(185, 48);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar Excepcion";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtExcepcion
            // 
            this.txtExcepcion.Location = new System.Drawing.Point(54, 49);
            this.txtExcepcion.Name = "txtExcepcion";
            this.txtExcepcion.Size = new System.Drawing.Size(100, 23);
            this.txtExcepcion.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Excepciones de inicio de Identificador";
            // 
            // Caracter
            // 
            this.Caracter.HeaderText = "Caracter";
            this.Caracter.Name = "Caracter";
            this.Caracter.ReadOnly = true;
            this.Caracter.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dtgvExcepciones
            // 
            this.dtgvExcepciones.AllowUserToAddRows = false;
            this.dtgvExcepciones.AllowUserToDeleteRows = false;
            this.dtgvExcepciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvExcepciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Caracter,
            this.Eliminar});
            this.dtgvExcepciones.Location = new System.Drawing.Point(39, 78);
            this.dtgvExcepciones.Name = "dtgvExcepciones";
            this.dtgvExcepciones.ReadOnly = true;
            this.dtgvExcepciones.Size = new System.Drawing.Size(248, 296);
            this.dtgvExcepciones.TabIndex = 4;
            this.dtgvExcepciones.Text = "dataGridView1";
            this.dtgvExcepciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvExcepciones_CellClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(13, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Agregar Ejemplos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Excepciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 433);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgvExcepciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtExcepcion);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Excepciones";
            this.Text = "Excepciones";
            this.Load += new System.EventHandler(this.Excepciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvExcepciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtExcepcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caracter;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridView dtgvExcepciones;
        private System.Windows.Forms.Button button1;
    }
}