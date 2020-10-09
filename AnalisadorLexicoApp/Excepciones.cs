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
    public partial class Excepciones : Form
    {
        public Excepciones()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtExcepcion.Text == "") 
            {
                MessageBox.Show("Error, el dato no puede ir vacio");
                return;
            }
            if (txtExcepcion.Text.Length > 1) 
            {
                MessageBox.Show("Solo se puede ingresar un caracter");
                return;
            }
            if (TablaSimbolosC.agregarExcepcion(txtExcepcion.Text[0]) == false)
            {
                MessageBox.Show("Caracter ya existe");
                return;
            }
            int n = dtgvExcepciones.Rows.Add();
            txtExcepcion.Text = "";
            dtgvExcepciones.Rows[n].Cells[0].Value = TablaSimbolosC.excepcionesInicioIdentificadores[n];
            dtgvExcepciones.Rows[n].Cells[1].Value = "Eliminar";
        }

        private void Excepciones_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < TablaSimbolosC.excepcionesInicioIdentificadores.Count; i++) 
            {
                int n = dtgvExcepciones.Rows.Add();
                dtgvExcepciones.Rows[n].Cells[0].Value = TablaSimbolosC.excepcionesInicioIdentificadores[n];
                dtgvExcepciones.Rows[n].Cells[1].Value = "eliminar";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            agregar('=');
            agregar('1');
            agregar('2');
            agregar('3');
            agregar('4');
            agregar('5');
            agregar('6');
            agregar('7');
            agregar('8');
            agregar('9');
            agregar('0');
            agregar('{');
            agregar('}');
            agregar('(');
            agregar(')');
        }
        public void agregar(char caracter)
        {
 
            if (TablaSimbolosC.agregarExcepcion(caracter) == true)
            {
               int n=dtgvExcepciones.Rows.Add();
                dtgvExcepciones.Rows[n].Cells[0].Value = TablaSimbolosC.excepcionesInicioIdentificadores[n];
                dtgvExcepciones.Rows[n].Cells[1].Value = "Eliminar";
            }
        }

        private void dtgvExcepciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 1) return;
            if (e.ColumnIndex == 1)
            {
                TablaSimbolosC.eliminarExcepcion(e.RowIndex);
                dtgvExcepciones.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
