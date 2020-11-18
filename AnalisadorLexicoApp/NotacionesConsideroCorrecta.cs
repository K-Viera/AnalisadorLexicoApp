using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AnalizadorLexicoApp
{
    class NotacionesConsideroCorrecta
    {
        public static string cadena;
        public static int posicion;
        public static char? tokenActual;
        public static List<int> contadorErrores;
        public static Boolean Prefijo;
        public static string mensaje;
        public static Boolean Principal(string cadenaIngresa, Boolean orden)
        {
            mensaje = "";
            //se indica si se desea imprimir en preorden o no
            Prefijo = orden;
            //se ingresa la cadena
            cadena = cadenaIngresa;
            //se incializa los errores en 0
            contadorErrores = new List<int>();
            //Se asigna el primer token
            tokenActual = PrimerToken();
            //se genera el arbol de la gramatica libre de contexto
            expresion();

            // si se detiene en una posicion que no sea el fin de la cadena, sigue recorrindola desde 0
            while (tokenActual != null)
            {
                contadorErrores.Add(posicion);
                tokenActual = SiguienteToken();
                expresion();
            }
            MessageBox.Show(mensaje);
            //si no teine errores se indica que la cadena es correcta
            if (contadorErrores.Count == 0)
            {
                return true;
            }
            //si tiene errores se indica en que posicion ocurren los errores
            else
            {
                return false;
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
                    mensaje += tokenActual;
                    HacerMatch(tokenActual);
                }
                else
                {
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
                    mensaje += "(";
                    HacerMatch('(');                 
                    expresion();
                    mensaje += ")";
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
                    mensaje += "*";
                    HacerMatch('*');
                    factor();
                    termino_prima();
                }
                else if (tokenActual == '/')
                {
                    mensaje += "/";
                    HacerMatch('/');
                    factor();
                    termino_prima();
                }
                else return;
            }
        }
        public static void expresion()
        {
            if(Prefijo==true)
            mensaje += "expresion";
            termino();
            expresion_prima();
        }
        public static void expresion_prima()
        {
            if (tokenActual != null)
            {
                if (tokenActual == '+')
                {
                    mensaje += "+";
                    HacerMatch('+');
                    termino();
                    expresion_prima();
                }
                else if (tokenActual == '-')
                {
                    mensaje += "-";
                    HacerMatch('-');
                    termino();
                    expresion_prima();
                }
                else return;
            }
        }
    }
}
