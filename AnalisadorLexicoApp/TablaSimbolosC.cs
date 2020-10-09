using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;

namespace AnalizadorLexico
{
    static class TablaSimbolosC
    {
        public static List<string> simbolos=new List<string>();
        public static List<List<string>> tipos = new List<List<string>>();


        public static List<char> excepcionesInicioIdentificadores = new List<char>();

        public static void CarcarModuloPorDefecto() 
        {
            AgregarSimbolo("\f", "separador");
            AgregarSimbolo("\n", "separador");
            AgregarSimbolo(" ", "separador");
        }
        public static Boolean agregarExcepcion(char caracter)
        {
            if (excepcionesInicioIdentificadores.Contains(caracter) == false) 
            {
                excepcionesInicioIdentificadores.Add(caracter);
                return true;
            }
            return false;
        }
        public static void eliminarExcepcion(int posicion)
        {
            excepcionesInicioIdentificadores.RemoveAt(posicion);
        }

        #region Simbolos
        public static void AgregarSimbolo(string simbolo)
        {
            if (!simbolos.Contains(simbolo)) 
            {
                simbolos.Add(simbolo);
                List<string> tipoTemporal = new List<string>();
                tipos.Add(tipoTemporal);
            }
        }
        public static Boolean AgregarSimbolo(string simbolo,string tipo)
        {
            if (!simbolos.Contains(simbolo))
            {
                simbolos.Add(simbolo);
                List<string> tipoTemporal = new List<string>();
                tipoTemporal.Add(tipo);
                tipos.Add(tipoTemporal);
                return true;
            }
            return false;
        }

        public static void AgregarTipoASimbolo(string simbolo, string tipo)
        {
            int index = simbolos.IndexOf(simbolo);
            if (!tipos[index].Contains(tipo))
            {
                tipos[index].Add(tipo);
            }
        }
        public static void AgregarTipoASimbolo(int simbolo, string tipo)
        {
                tipos[simbolo].Add(tipo);
        }
        public static void EliminarTipoASimbolo(int posicionSimbolo, int posicionTipo) 
        {
            tipos[posicionSimbolo].RemoveAt(posicionTipo);
        }

        public static void EliminarSimbolo(string simbolo)
        {
            int index = simbolos.IndexOf(simbolo);
            simbolos.RemoveAt(index);
            tipos.RemoveAt(index);
        }
        public static void EliminarSimbolo(int posicion)
        {
            simbolos.RemoveAt(posicion);
            tipos.RemoveAt(posicion);
        }
        #endregion 
    }
}
