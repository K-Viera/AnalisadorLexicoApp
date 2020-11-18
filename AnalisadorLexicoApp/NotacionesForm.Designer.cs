namespace AnalizadorLexicoApp
{
    partial class NotacionesForm
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
            this.Cadena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preorden = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Postorden = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cadena
            // 
            this.Cadena.HeaderText = "Cadena";
            this.Cadena.Name = "Cadena";
            this.Cadena.ReadOnly = true;
            this.Cadena.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cadena.Width = 300;
            // 
            // Preorden
            // 
            this.Preorden.HeaderText = "Preorden";
            this.Preorden.Name = "Preorden";
            this.Preorden.ReadOnly = true;
            this.Preorden.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Postorden
            // 
            this.Postorden.HeaderText = "Postorden";
            this.Postorden.Name = "Postorden";
            this.Postorden.ReadOnly = true;
            this.Postorden.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cadena,
            this.Preorden,
            this.Postorden});
            this.dataGridView1.Location = new System.Drawing.Point(38, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 258);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Text = "dataGridView1";
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NotacionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 307);
            this.Controls.Add(this.dataGridView1);
            this.Name = "NotacionesForm";
            this.Text = "NotacionesForm";
            this.Load += new System.EventHandler(this.NotacionesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Cadena;
        private System.Windows.Forms.DataGridViewButtonColumn Preorden;
        private System.Windows.Forms.DataGridViewButtonColumn Postorden;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}