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
    public partial class AritmeticaForm : Form
    {
        public AritmeticaForm()
        {
            InitializeComponent();
        }

        private void AritmeticaForm_Load(object sender, EventArgs e)
        {
            Analizador.encontrarSentenciasAritmericas();
            dataGridView2.Rows.Clear();
            for (int i = 0; i < Analizador.sentenciasAritmeticas.Count; i++)
            {
                int n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = Analizador.sentenciasAritmeticas[n];
                string fila = Analizador.ubicacionesSentencias[n][0].ToString();
                string inicio = Analizador.ubicacionesSentencias[n][1].ToString();
                string fin = Analizador.ubicacionesSentencias[n][2].ToString();
                dataGridView2.Rows[n].Cells[1].Value = (fila + "," + inicio + " - " + fila + "," + fin);
            }
        }
    }
}
