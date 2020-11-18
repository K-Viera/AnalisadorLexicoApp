using AnalizadorLexicoApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AnalizadorLexico
{
    class Analizador
    {
        public static List<string> simbolos;
        public static List<List<int>> ubicaciones;
        public static List<List<string>> tipos;

        public static List<string> tokens;
        public static List<long> tokensIds;
        public static List<string> lexemas;

        public static List<string> sentenciasAritmeticas;
        public static List<List<int>> ubicacionesSentencias;

        public static List<string> sentenciasAritmeticasCorrectas;

        public static Boolean AnalizarCompleto()
        {
            long id = TablaTokens.id;
            Queue<char[]> temp = new Queue<char[]>(IngresarTexto.arregloTexto);
            simbolos = new List<string>();
            ubicaciones = new List<List<int>>();
            tipos = new List<List<string>>();

            tokens = new List<string>();
            tokensIds = new List<long>();
            lexemas = new List<string>();

            int indiceFilaActual = 0;
            Boolean primerSeparador = false;
            Boolean segundoSeparador = false;
            List<int> lista;
            int posicionSeparadorInicial = 0;
            int posicionSeparadorFinal = 0;
            int operadorFinalTamaño = 0;

            //Primer while, que recorre linea por linea.
            while (IngresarTexto.arregloTexto.Count != 0)
            {
                char[] filaActual = IngresarTexto.arregloTexto.Dequeue();
                int posicionCaracterFilaActual = 0;

                //segundo While,Que recorre caracter por caracter de cada fila, analiza los grupos dentro de separadores
                while (posicionCaracterFilaActual < filaActual.Length || segundoSeparador == true)
                {
                    //condicion que se cumple para la primera linea de cada texto
                    if (primerSeparador == false)
                    {
                        posicionSeparadorInicial = posicionCaracterFilaActual;
                        primerSeparador = true;
                    }
                    else
                    {
                        //si no exite el segundo separador, el mismo se busca dentro de esta condicion.
                        if (segundoSeparador == false)
                        {
                            posicionCaracterFilaActual = posicionSeparadorInicial + 1;
                            //while que busca el siguiete separador,caracter por caracter
                            while (segundoSeparador == false)
                            {
                                List<int> indexSimbolosCoincidencias = encontrarCoincidencias(filaActual[posicionCaracterFilaActual]);
                                if (indexSimbolosCoincidencias.Count == 1)
                                {
                                    //condicion 1
                                    if (TablaSimbolosC.simbolos[indexSimbolosCoincidencias[0]].Length == 1)
                                    {
                                        if (!tokens.Contains(TablaTokens.tokens[indexSimbolosCoincidencias[0]]))
                                        {
                                            tokens.Add(TablaTokens.tokens[indexSimbolosCoincidencias[0]]);
                                            tokensIds.Add(TablaTokens.tokensIds[indexSimbolosCoincidencias[0]]);
                                            lexemas.Add(TablaTokens.lexemas[indexSimbolosCoincidencias[0]]);
                                        }


                                        simbolos.Add(TablaSimbolosC.simbolos[indexSimbolosCoincidencias[0]]);
                                        operadorFinalTamaño = TablaSimbolosC.simbolos[indexSimbolosCoincidencias[0]].Length;
                                        lista = new List<int>();
                                        lista.Add(indiceFilaActual);
                                        lista.Add(posicionCaracterFilaActual);
                                        lista.Add(posicionCaracterFilaActual);
                                        ubicaciones.Add(lista);
                                        tipos.Add(TablaSimbolosC.tipos[indexSimbolosCoincidencias[0]]);
                                        posicionSeparadorFinal = posicionCaracterFilaActual;
                                        segundoSeparador = true;
                                    }
                                    else
                                    {
                                        //condicion 2
                                        int contador = 1;
                                        int posicionFinal = posicionCaracterFilaActual + 1;
                                        Boolean simboloCompleto = true;
                                        char[] arregloSimbolo = TablaSimbolosC.simbolos[indexSimbolosCoincidencias[0]].ToCharArray();
                                        while (contador < arregloSimbolo.Length && simboloCompleto == true)
                                        {
                                            if (filaActual[posicionFinal] != arregloSimbolo[contador])
                                            {
                                                simboloCompleto = false;
                                            }
                                            else
                                            {
                                                contador++;
                                                posicionFinal++;
                                            }
                                        }
                                        if (simboloCompleto == true)
                                        {
                                            if (!tokens.Contains(TablaTokens.tokens[indexSimbolosCoincidencias[0]]))
                                            {
                                                tokens.Add(TablaTokens.tokens[indexSimbolosCoincidencias[0]]);
                                                tokensIds.Add(TablaTokens.tokensIds[indexSimbolosCoincidencias[0]]);
                                                lexemas.Add(TablaTokens.lexemas[indexSimbolosCoincidencias[0]]);

                                            }


                                            simbolos.Add(TablaSimbolosC.simbolos[indexSimbolosCoincidencias[0]]);
                                            operadorFinalTamaño = TablaSimbolosC.simbolos[indexSimbolosCoincidencias[0]].Length;
                                            lista = new List<int>();
                                            lista.Add(indiceFilaActual);
                                            lista.Add(posicionCaracterFilaActual);
                                            lista.Add(posicionFinal);
                                            ubicaciones.Add(lista);
                                            tipos.Add(TablaSimbolosC.tipos[indexSimbolosCoincidencias[0]]);
                                            posicionSeparadorFinal = posicionCaracterFilaActual;
                                            segundoSeparador = true;
                                        }
                                    }
                                }
                                else if (indexSimbolosCoincidencias.Count > 1)
                                {
                                    //condicion 3
                                    int contador = 0;
                                    int numero = indexSimbolosCoincidencias.Count;
                                    string palabra = "";
                                    int? coincidencia = null;
                                    while (numero != 0)
                                    {
                                        char caracter = filaActual[posicionCaracterFilaActual + contador];
                                        palabra = palabra + caracter;
                                        List<int> tempIndexSimbolosCoincidencias = new List<int>();
                                        for (int i = 0; i < indexSimbolosCoincidencias.Count; i++)
                                        {
                                            if (contador < TablaSimbolosC.simbolos[indexSimbolosCoincidencias[i]].Length)
                                            {
                                                if (caracter == TablaSimbolosC.simbolos[indexSimbolosCoincidencias[i]][contador])
                                                {
                                                    if (palabra.Length == TablaSimbolosC.simbolos[indexSimbolosCoincidencias[i]].Length)
                                                    {
                                                        coincidencia = indexSimbolosCoincidencias[i];
                                                    }
                                                    tempIndexSimbolosCoincidencias.Add(indexSimbolosCoincidencias[i]);
                                                }
                                            }
                                        }
                                        indexSimbolosCoincidencias = tempIndexSimbolosCoincidencias;
                                        numero = indexSimbolosCoincidencias.Count;
                                        contador++;
                                    }

                                    if (coincidencia != null)
                                    {
                                        if (!tokens.Contains(TablaTokens.tokens[(int)coincidencia]))
                                        {
                                            tokens.Add(TablaTokens.tokens[(int)coincidencia]);
                                            tokensIds.Add(TablaTokens.tokensIds[(int)coincidencia]);
                                            lexemas.Add(TablaTokens.lexemas[(int)coincidencia]);
                                        }


                                        simbolos.Add(TablaSimbolosC.simbolos[(int)coincidencia]);
                                        operadorFinalTamaño = TablaSimbolosC.simbolos[(int)coincidencia].Length;
                                        lista = new List<int>();
                                        lista.Add(indiceFilaActual);
                                        lista.Add(posicionCaracterFilaActual);
                                        lista.Add((posicionCaracterFilaActual
                                            + TablaSimbolosC.simbolos[(int)coincidencia].Length - 1));
                                        ubicaciones.Add(lista);
                                        tipos.Add(TablaSimbolosC.tipos[(int)coincidencia]);
                                        posicionSeparadorFinal = posicionCaracterFilaActual;
                                        segundoSeparador = true;
                                    }
                                }
                                posicionCaracterFilaActual++;
                            }

                        }


                        //Si ya existe el segundo comparador, esta parte analiza el contenido en la sentencia
                        else
                        {
                            segundoSeparador = false;
                            if ((posicionSeparadorFinal - posicionSeparadorInicial) > 1)
                            {
                                Boolean sePuede = true;
                                //condicion 4

                                Boolean esSimbolo = false;
                                foreach (string simbolo in TablaSimbolosC.simbolos)
                                {
                                    if (simbolo.Length == posicionSeparadorFinal - posicionSeparadorInicial - 1)
                                    {
                                        Boolean coincidenTodosLosCaracteres = true;
                                        for (int x = 0; x < simbolo.Length; x++)
                                        {
                                            if (filaActual[posicionSeparadorInicial + 1 + x] != simbolo[x]) coincidenTodosLosCaracteres = false;
                                        }
                                        if (coincidenTodosLosCaracteres == true)
                                        {
                                            esSimbolo = true;
                                            simbolos.Add(simbolo);
                                            lista = new List<int>();
                                            lista.Add(indiceFilaActual);
                                            lista.Add(posicionSeparadorInicial + 1);
                                            lista.Add(posicionSeparadorFinal - 1);
                                            tipos.Add(TablaSimbolosC.tipos[TablaSimbolosC.simbolos.IndexOf(simbolo)]);

                                            ubicaciones.Add(lista);

                                            if (!tokens.Contains(TablaTokens.tokens[TablaSimbolosC.simbolos.IndexOf(simbolo)]))
                                            {
                                                tokens.Add(TablaTokens.tokens[TablaSimbolosC.simbolos.IndexOf(simbolo)]);
                                                tokensIds.Add(TablaTokens.tokensIds[TablaSimbolosC.simbolos.IndexOf(simbolo)]);
                                                lexemas.Add(TablaTokens.lexemas[TablaSimbolosC.simbolos.IndexOf(simbolo)]);
                                            }

                                            break;
                                        }
                                    }
                                }
                                if (esSimbolo == false)
                                {


                                    string simbolo = "";
                                    for (int i = posicionSeparadorInicial + 1; i < posicionSeparadorFinal; i++)
                                    {
                                        simbolo = simbolo + filaActual[i];
                                    }
                                    simbolos.Add(simbolo);
                                    lista = new List<int>();
                                    lista.Add(indiceFilaActual);
                                    lista.Add(posicionSeparadorInicial + 1);
                                    lista.Add(posicionSeparadorFinal - 1);
                                    ubicaciones.Add(lista);
                                    List<string> tipo = new List<string>();
                                    tipo.Add("identificador");
                                    tipos.Add(tipo);

                                    if (!lexemas.Contains(simbolo))
                                    {
                                        tokens.Add("Identificador");
                                        tokensIds.Add(id);
                                        lexemas.Add(simbolo);
                                    }


                                }


                            }
                            if (posicionSeparadorFinal == filaActual.Length - 1)
                            {
                                posicionSeparadorInicial = -1;
                            }
                            else
                            {
                                posicionSeparadorInicial = posicionSeparadorFinal - 1 + operadorFinalTamaño;
                            }

                        }
                    }
                }
                indiceFilaActual++;
            }
            IngresarTexto.arregloTexto = new Queue<char[]>(temp);
            return true;
        }

        public static void encontrarSentenciasAritmericas()
        {
            AnalizarCompleto();
            sentenciasAritmeticas = new List<string>();
            ubicacionesSentencias = new List<List<int>>();

            List<char[]> listaTexto = IngresarTexto.arregloTexto.ToList();
            List<int> indicesInicioOperacion = new List<int>();
            List<int> lista;
            List<int> indiceFinOperacion = new List<int>();
            string linea;
            for (int i = 0; i < simbolos.Count(); i++)
            {
                foreach (string tipo in tipos[i])
                {
                    if (tipo == "iniciooperacion") indicesInicioOperacion.Add(i);
                    if (tipo == "finoperacion") indiceFinOperacion.Add(i);
                }
                
            }
            foreach (int posicionInicio in indicesInicioOperacion)
            {
                linea = "";
                int indiceFinalDeLaLinea = 0;
                foreach (int posicionFinal in indiceFinOperacion)
                {
                    if (ubicaciones[posicionInicio][0] == ubicaciones[posicionFinal][0])
                    {
                        indiceFinalDeLaLinea = ubicaciones[posicionFinal][1];
                        indiceFinOperacion.Remove(posicionFinal);
                        break;
                    }
                }
                for (int i = ubicaciones[posicionInicio][2]+1; i < indiceFinalDeLaLinea; i++)
                {
                    linea += listaTexto[ubicaciones[posicionInicio][0]][i];
                }
                sentenciasAritmeticas.Add(linea);
                lista = new List<int>();
                lista.Add(ubicaciones[posicionInicio][0]);
                lista.Add(posicionInicio+1);
                lista.Add(indiceFinalDeLaLinea-1);
                ubicacionesSentencias.Add(lista);
            }

        }
        public static void analizarSentenciasAritmeticasCorrectas() 
        {
            sentenciasAritmeticasCorrectas = new List<string>();
            for (int i = 0; i < sentenciasAritmeticas.Count; i++) 
            {
                Boolean esCorrecta = AnalizarExpresionesSinMensajes.Principal(sentenciasAritmeticas[i]);
                if (esCorrecta == true) { sentenciasAritmeticasCorrectas.Add(sentenciasAritmeticas[i]); }
            }
        }
        public static List<int> encontrarCoincidencias(char caracterActual)
        {
            List<int> indexSimbolosCoincidencias = new List<int>();
            int simboloActual = 0;
            //while que compara el caracter actual con todos los simbolos y si son identificadores
            //para ver si coinciden
            while (simboloActual < TablaSimbolosC.simbolos.Count)
            {
                if (caracterActual == TablaSimbolosC.simbolos[simboloActual][0])
                {
                    foreach (string tipo in TablaSimbolosC.tipos[simboloActual])
                    {
                        if (tipo == "separador")
                        {
                            indexSimbolosCoincidencias.Add(simboloActual);
                        }
                    }
                }
                simboloActual++;
            }
            return indexSimbolosCoincidencias;
        }

        public static void imprimirTabla()
        {
            for (int i = 0; i < simbolos.Count; i++)
            {
                if (simbolos[i].Length == 1)
                {
                    Console.Write((int)simbolos[i][0]);
                }
                else
                {
                    Console.Write(simbolos[i]);
                }
                Console.Write("|" + ubicaciones[i]);
                foreach (string tipo in tipos[i])
                {
                    Console.Write("|" + tipo);
                }
                Console.WriteLine();
            }
        }
    }
}


