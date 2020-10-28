using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace AnalizadorLexicoApp
{
    class AnalizarExpresiones
    {
        public static string cadena;
        public static int posicion;
        public static char? tokenActual;
        public static List<int> contadorErrores;
        public static void Principal(string cadenaIngresa)
        {
            cadena = cadenaIngresa;
            contadorErrores = new List<int>();
            tokenActual = PrimerToken();
            expresion();
            while (tokenActual != null) 
            {
                contadorErrores.Add(posicion);
                tokenActual = SiguienteToken();
                expresion();
            }
            if (contadorErrores.Count == 0)
            {
                MessageBox.Show("Cadena Correcta");
            }
            else 
            {
                string mensaje = ("Error en las posiciones: ");
                foreach (int posicion in contadorErrores)
                {
                    mensaje = mensaje +""+(posicion+1)+",";
                }
                mensaje = mensaje + " de la cadena";
                MessageBox.Show(mensaje);
            }

        }
        public static char? PrimerToken()
        {
            posicion = 0;
            return (cadena[posicion]);
        }
        public static char? SiguienteToken()
        {
            posicion++;
            if (posicion < cadena.Length) 
            {
                return (cadena[posicion]);
            }
            return null;
        }

        public static void HacerMatch(char? t)
        {

                if (t == tokenActual)
                {
                    tokenActual = SiguienteToken();
                }
                else
                {
                contadorErrores.Add(posicion);
                MessageBox.Show("Error de match");
                }

        }

        public static Boolean Es_digito(char? caracter)
        {
            if (caracter == '0' || caracter == '1' || caracter == '2' || caracter == '3' || caracter == '4' ||
                caracter == '5' || caracter == '6' || caracter == '7' || caracter == '8' || caracter == '9')
            {
                return true;
            }
            return false;
        }
        public static void digito()
        {
            if (tokenActual != null) 
            {
                if (Es_digito(tokenActual))
                {
                    HacerMatch(tokenActual);
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
        }

        public static void numero()
        {
            digito();
            numero_prima();

        }
        public static void numero_prima()
        {
            if (tokenActual != null) 
            {
                if (Es_digito(tokenActual))
                {
                    digito();
                    numero_prima();
                }
                else return;
            } 
        }

        public static void factor()
        {
            if (tokenActual != null)
            {
                if (Es_digito(tokenActual))
                {
                    numero();
                }
                else if (tokenActual == '(')
                {
                    HacerMatch('(');
                    expresion();
                    HacerMatch(')');
                }
            }
        }

        public static void termino()
        {
            factor();
            termino_prima();
        }
        public static void termino_prima()
        {
            if (tokenActual != null) 
            {
                if (tokenActual == '*')
                {
                    HacerMatch('*');
                    factor();
                    termino_prima();
                }
                else if (tokenActual == '/')
                {
                    HacerMatch('/');
                    factor();
                    termino_prima();
                }
                else return;
            }
        }
            

        public static void expresion()
        {
            termino();
            expresion_prima();
        }
        public static void expresion_prima()
        {
            if (tokenActual != null) 
            {
                if (tokenActual == '+')
                {
                    HacerMatch('+');
                    termino();
                    expresion_prima();
                }
                else if (tokenActual == '-')
                {
                    HacerMatch('-');
                    termino();
                    expresion_prima();
                }
                else return;
            }
        }
    }
}
