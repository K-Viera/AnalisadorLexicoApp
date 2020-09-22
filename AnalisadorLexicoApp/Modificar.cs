using AnalizadorLexico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AnalisadorLexicoApp
{
    public partial class Modificar : Form
    {
        public int posicion;
        public Modificar(int posicion)
        {
            this.posicion = posicion;
            InitializeComponent();
        }

        private void txtAñadirTipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Modificar_Load(object sender, EventArgs e)
        {
            txtGuardarSimbolo.Text = TablaSimbolosC.simbolos[posicion];
            for (int i = 0; i < TablaSimbolosC.tipos[posicion].Count; i++)
            {
                int n = dtgvTipos.Rows.Add();
                dtgvTipos.Rows[n].Cells[0].Value = TablaSimbolosC.tipos[posicion][n];
                dtgvTipos.Rows[n].Cells[1].Value = "Guardar";
                dtgvTipos.Rows[n].Cells[2].Value = "Eliminar";
            }
        }

        private void dtgvTipos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 1) return;
            if (e.ColumnIndex == 1)
            {
                TablaSimbolosC.tipos[posicion][e.RowIndex] = dtgvTipos.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            else if (e.ColumnIndex == 2) 
            {
                dtgvTipos.Rows.RemoveAt(e.RowIndex);
                TablaSimbolosC.EliminarTipoASimbolo(posicion,e.RowIndex);
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (txtAñadirTipo.Text == "") 
            {
                MessageBox.Show("Error, el dato no puede ir vacio");
                return;
            }
            int n = dtgvTipos.Rows.Add();
            TablaSimbolosC.AgregarTipoASimbolo(posicion, txtAñadirTipo.Text);
            txtAñadirTipo.Text = "";
            dtgvTipos.Rows[n].Cells[0].Value = TablaSimbolosC.tipos[posicion][n];
            dtgvTipos.Rows[n].Cells[1].Value = "Guardar";
            dtgvTipos.Rows[n].Cells[2].Value = "Eliminar";
        }

        private void btnGuardarSimbolo_Click(object sender, EventArgs e)
        {
            if (txtGuardarSimbolo.Text == "")
            {
                MessageBox.Show("Error, el dato no puede ir vacio");
                return;
            }
            TablaSimbolosC.simbolos[posicion] = txtGuardarSimbolo.Text;
        }
    }
}
