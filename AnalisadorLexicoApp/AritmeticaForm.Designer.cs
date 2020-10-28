namespace AnalizadorLexicoApp
{
    partial class AritmeticaForm
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
            this.Cadena1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Analizar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // Cadena1
            // 
            this.Cadena1.HeaderText = "Cadena";
            this.Cadena1.Name = "Cadena1";
            this.Cadena1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cadena1.Width = 400;
            // 
            // Ubicacion1
            // 
            this.Ubicacion1.HeaderText = "Ubicacion";
            this.Ubicacion1.Name = "Ubicacion1";
            this.Ubicacion1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Analizar
            // 
            this.Analizar.HeaderText = "Analizar";
            this.Analizar.Name = "Analizar";
            this.Analizar.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cadena1,
            this.Ubicacion1,
            this.Analizar});
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(642, 379);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.Text = "dataGridView2";
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick_1);
            // 
            // AritmeticaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.dataGridView2);
            this.Name = "AritmeticaForm";
            this.Text = "AritmeticaForm";
            this.Load += new System.EventHandler(this.AritmeticaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Cadena1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewButtonColumn Analizar;
    }
}