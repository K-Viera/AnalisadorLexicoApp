using AnalizadorLexico;
using AnalizadorLexicoApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalisadorLexicoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1 = new OpenFileDialog();
        }

        private OpenFileDialog openFileDialog1;

        private void btnTablaSimbolos_Click(object sender, EventArgs e)
        {
            TablaSimbolos Simbolos = new TablaSimbolos();
            Simbolos.ShowDialog();
        }

        private void btnIngresarTexto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    TextReader sr = new StreamReader(openFileDialog1.FileName);
                    IngresarTexto.LeerTexto(sr);
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            if (IngresarTexto.arregloTexto == null) 
            {
                MessageBox.Show("Error 404, Archivo de texto no encontrado");
                return;
            }
            Analizador.AnalizarCompleto();
            dtgvSimbolos.Rows.Clear();
            for (int i = 0; i < Analizador.simbolos.Count; i++) 
            {
                int n = dtgvSimbolos.Rows.Add();

                
                if (Analizador.simbolos[n].Length == 1)
                {
                    dtgvSimbolos.Rows[n].Cells[0].Value = (int)Analizador.simbolos[n][0];
                }
                else
                {
                    dtgvSimbolos.Rows[n].Cells[0].Value = Analizador.simbolos[n];
                }
                dtgvSimbolos.Rows[n].Cells[1].Value = Analizador.ubicaciones[n];

                string simbolo = Analizador.tipos[n][0];
                for (int j = 1; j < Analizador.tipos[n].Count;j++) 
                {
                    simbolo=simbolo+" ; "+ Analizador.tipos[n][j];
                }
                dtgvSimbolos.Rows[n].Cells[2].Value = simbolo;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnExcepciones_Click(object sender, EventArgs e)
        {
            Excepciones ex = new Excepciones();
            ex.ShowDialog();
        }
    }
}
