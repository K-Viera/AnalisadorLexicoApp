using AnalizadorLexico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Windows.Forms;

namespace AnalizadorLexicoApp
{
    public partial class TablaTokensForm : Form
    {
        public TablaTokensForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TablaTokensForm_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        public void Refrescar()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < TablaTokens.tokens.Count; i++) 
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = TablaTokens.tokens[i];
                dataGridView1.Rows[n].Cells[1].Value = TablaTokens.tokensIds[i];
                dataGridView1.Rows[n].Cells[2].Value = TablaTokens.lexemas[i];
                dataGridView1.Rows[n].Cells[3].Value = "Eliminar";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtLexema.Text == "" || txtToken.Text == "") 
            {
                MessageBox.Show("Error,ningun dato puede quedar vacio");
                return;
            }
            Boolean seCreo = TablaTokens.AgregarToken(txtToken.Text, txtLexema.Text);
            if (seCreo == false) 
            {
                MessageBox.Show("Simbolo Repetido");
                return;
            }
            txtLexema.Text = "";
            txtToken.Text = "";
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = TablaTokens.tokens[n];
            dataGridView1.Rows[n].Cells[1].Value = TablaTokens.tokensIds[n];
            dataGridView1.Rows[n].Cells[2].Value = TablaTokens.lexemas[n];
            dataGridView1.Rows[n].Cells[3].Value = "Eliminar";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex <= 2) return;
            if (e.ColumnIndex == 3) 
            {
                TablaTokens.EliminarToken(e.RowIndex);
                TablaSimbolosC.EliminarSimbolo(e.RowIndex);
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnCargarEjemplos_Click(object sender, EventArgs e)
        {
            TablaTokens.CargarEjemplos();
            Refrescar();
        }
    }
}
