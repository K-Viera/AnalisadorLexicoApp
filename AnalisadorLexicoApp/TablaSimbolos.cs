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
    public partial class TablaSimbolos : Form
    {
        public TablaSimbolos()
        {
            InitializeComponent();
        }

        private void dtgvConfiguracionSimbolos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex <= 1) return;
            if (e.ColumnIndex == 2)
            {
                Modificar mod = new Modificar(e.RowIndex + 3);
                mod.ShowDialog();
                Refrescar();
            }
            else if (e.ColumnIndex == 3)
            {
                TablaSimbolosC.EliminarSimbolo(e.RowIndex + 3);
                dtgvConfiguracionSimbolos.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtSimbolo.Text == "" || txtTipoInicial.Text == "") 
            {
                MessageBox.Show("Error, ningun dato puede quedar vacio");
                return;
            }
            Boolean seCreo=TablaSimbolosC.AgregarSimbolo(txtSimbolo.Text, txtTipoInicial.Text);
            if (seCreo == false) 
            {
                MessageBox.Show("Simbolo Repetido");
                return;
            }
            txtSimbolo.Text = "";
            txtTipoInicial.Text = "";
            int n = dtgvConfiguracionSimbolos.Rows.Add();
            int nSimbolo = n + 3;

                dtgvConfiguracionSimbolos.Rows[n].Cells[0].Value = TablaSimbolosC.simbolos[nSimbolo];
            dtgvConfiguracionSimbolos.Rows[n].Cells[1].Value = TablaSimbolosC.tipos[nSimbolo][0];
            dtgvConfiguracionSimbolos.Rows[n].Cells[2].Value = "Editar";
            dtgvConfiguracionSimbolos.Rows[n].Cells[3].Value = "Eliminar";
        }

        private void TablaSimbolos_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        public void Refrescar() 
        {
            dtgvConfiguracionSimbolos.Rows.Clear();
            for (int i = 3; i < TablaSimbolosC.simbolos.Count; i++)
            {
                int n = dtgvConfiguracionSimbolos.Rows.Add();

                    dtgvConfiguracionSimbolos.Rows[n].Cells[0].Value = TablaSimbolosC.simbolos[i];

                string simbolo = TablaSimbolosC.tipos[i][0];
                for (int j = 1; j < TablaSimbolosC.tipos[i].Count; j++)
                {
                    simbolo = simbolo + " ; " + TablaSimbolosC.tipos[i][j];
                }
                dtgvConfiguracionSimbolos.Rows[n].Cells[1].Value = simbolo;
                dtgvConfiguracionSimbolos.Rows[n].Cells[2].Value = "Editar";
                dtgvConfiguracionSimbolos.Rows[n].Cells[3].Value = "Eliminar";
            }
        }

        private void btnEjemplos_Click(object sender, EventArgs e)
        {
            if (TablaSimbolosC.simbolos.Count > 3) 
            {
                MessageBox.Show("Ya existen tipos creados");
                return;
            }
            TablaSimbolosC.AgregarSimbolo("boolean", "Tipo de dato");
            TablaSimbolosC.AgregarSimbolo("=", "separador");
            TablaSimbolosC.AgregarSimbolo("(", "separador");
            TablaSimbolosC.AgregarSimbolo(")", "separador");
            TablaSimbolosC.AgregarSimbolo("{", "separador");
            TablaSimbolosC.AgregarSimbolo("}", "separador");
            TablaSimbolosC.AgregarSimbolo("==", "operador");
            TablaSimbolosC.AgregarTipoASimbolo("==", "separador");
            Refrescar();
        }
    }
}
