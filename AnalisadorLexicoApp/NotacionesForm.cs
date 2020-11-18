using AnalizadorLexico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AnalizadorLexicoApp
{
    public partial class NotacionesForm : Form
    {
        public NotacionesForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NotacionesForm_Load(object sender, EventArgs e)
        {
            Analizador.analizarSentenciasAritmeticasCorrectas();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < Analizador.sentenciasAritmeticasCorrectas.Count; i++)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = Analizador.sentenciasAritmeticasCorrectas[n];;
                dataGridView1.Rows[n].Cells[1].Value = "Preorden";
                dataGridView1.Rows[n].Cells[2].Value = "Postorden";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                return;
            }
            if (e.ColumnIndex == 1)
            {
                Notaciones.Principal(Analizador.sentenciasAritmeticasCorrectas[e.RowIndex], true);
            } else if (e.ColumnIndex == 2) 
            {
                Notaciones.Principal(Analizador.sentenciasAritmeticasCorrectas[e.RowIndex], false);
            }
        }
    }
}
