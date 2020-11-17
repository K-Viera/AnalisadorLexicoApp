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
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization.Json;

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
                string ubicacion;
                if (Analizador.ubicaciones[n].Count == 2)
                {
                    string inicio = Analizador.ubicaciones[n][0].ToString();
                    string fin = Analizador.ubicaciones[n][1].ToString();
                    ubicacion = (inicio + "," + fin);
                }
                else 
                {
                    string fila = Analizador.ubicaciones[n][0].ToString();
                    string inicio= Analizador.ubicaciones[n][1].ToString();
                    string fin = Analizador.ubicaciones[n][2].ToString();
                    ubicacion = (fila + "," + inicio+" - "+fila+","+fin);
                }
                dtgvSimbolos.Rows[n].Cells[1].Value = ubicacion;

                string simbolo = "";
                if (Analizador.tipos[n].Count != 0)
                {
                    simbolo = Analizador.tipos[n][0];
                    for (int j = 1; j < Analizador.tipos[n].Count; j++)
                    {
                        simbolo = simbolo + " ; " + Analizador.tipos[n][j];
                    }
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

        private void button1_Click(object sender, EventArgs e)
        {
            TablaTokensForm Tokens = new TablaTokensForm();
            Tokens.ShowDialog();
        }

        private void btnAnalizarTokens_Click(object sender, EventArgs e)
        {
            if (IngresarTexto.arregloTexto == null)
            {
                MessageBox.Show("Error 404, Archivo de texto no encontrado");
                return;
            }
            Analizador.AnalizarCompleto();
            dtgvTokens.Rows.Clear();
            for (int i = 0; i < Analizador.tokens.Count; i++) 
            {
                int n = dtgvTokens.Rows.Add();
                dtgvTokens.Rows[n].Cells[0].Value = Analizador.tokens[n];
                dtgvTokens.Rows[n].Cells[1].Value = Analizador.tokensIds[n];
                dtgvTokens.Rows[n].Cells[2].Value = Analizador.lexemas[n];
            }
        }

        private void btnAritmetica_Click(object sender, EventArgs e)
        {
            if (IngresarTexto.arregloTexto == null)
            {
                MessageBox.Show("Error 404, Archivo de texto no encontrado");
                return;
            }
            AritmeticaForm ventana = new AritmeticaForm();
            ventana.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            TablaViewModel Tabla = new TablaViewModel(TablaSimbolosC.simbolos, TablaSimbolosC.tipos);
            string cadenaJson = JsonSerializer.Serialize(Tabla);
            File.WriteAllText("guardar.txt", cadenaJson);
        }
    }
    public class TablaViewModel
    {
        public List<string> simbolos { get; set; }
        public List<List<string>> tipos { get; set; }

        public TablaViewModel(List<string> simbolos, List<List<string>> tipos) 
        {
            this.simbolos = simbolos;
            this.tipos = tipos;
        }

    }
}
