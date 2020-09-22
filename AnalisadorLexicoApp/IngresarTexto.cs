using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace AnalizadorLexico
{
    static class IngresarTexto
    {
        public static Queue<char[]> arregloTexto;


        public static void LeerTexto(TextReader leer) 
        {
            Queue<char[]> lista= new Queue<char[]>();
            string linea = leer.ReadLine();
            //se añade el caracter Form Feed que indica el inicio del texto
            linea = "\f" + linea + "\n";
            lista.Enqueue(linea.ToCharArray());
            while ((linea = leer.ReadLine()) != null) 
            {
                //se añade el caracter de salto de linea al final de cada linea de texto
                linea = linea + "\n";
                lista.Enqueue(linea.ToCharArray());
            }
            leer.Close();
            arregloTexto = lista;
        }

        public static Queue<char[]> getArreglo() 
        {
            return arregloTexto;
        }
        public static void setArreglo(Queue<char[]> arreglo)
        {
            arregloTexto = arreglo;
        }


        //imprime caracter por caracter todo el contenido del texto ingresado en formato ASCII
        public static void imprimirCaracteres()
        {
            List<char[]> temp = arregloTexto.ToList();
            int contador = 1;
            foreach (char[] linea in temp) 
            {
                foreach (char caracter in linea) 
                {
                    Console.WriteLine(contador + ": " + (int)caracter);
                    contador++;
                }
            }
        }
    }
}
