using AnalizadorLexico;
using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace AnalizadorLexicoApp
{
    class TablaTokens
    {
        public static List<string> tokens = new List<string>();
        public static List<long> tokensIds = new List<long>();
        public static List<string> lexemas = new List<string>();
        public static long id;

        public static void moduloPorDefecto() 
        {
            id = 1;
            AgregarToken("inicioTexto", "\f", "separador");
            AgregarToken("finDeLinea", "\n", "separador");
            TablaSimbolosC.AgregarTipoASimbolo("\n", "finoperacion");
            AgregarToken("espacio", " ", "separador");

        }

        #region tokens
        public static Boolean AgregarToken(string token, string lexema)
        {
            if (!tokens.Contains(token) && !lexemas.Contains(lexema))
            {
                tokens.Add(token);
                tokensIds.Add(id);
                lexemas.Add(lexema);
                TablaSimbolosC.AgregarSimbolo(lexema);
                id++;
                return true;
            }
            return false;
        }
        public static Boolean AgregarToken(string token, string lexema,string tipoInicial)
        {
            if (!tokens.Contains(token) && !lexemas.Contains(lexema))
            {
                tokens.Add(token);
                tokensIds.Add(id);
                lexemas.Add(lexema);
                TablaSimbolosC.AgregarSimbolo(lexema,tipoInicial);
                id++;
                return true;
            }
            return false;
        }

        public static void EliminarToken(int posicion)
        {
            tokens.RemoveAt(posicion);
            tokensIds.RemoveAt(posicion);
            lexemas.RemoveAt(posicion);
        }

        public static void EliminarToken(string token) 
        {
            int index = tokens.IndexOf(token);
            EliminarToken(index);
        }
        #endregion

        public static void CargarEjemplos()
        {
            AgregarToken("If", "if");
            AgregarToken("parentesisIzq", "(","operador");
            AgregarToken("parentesisDer", ")","operador");
            AgregarToken("opSuma", "+","operador");
            AgregarToken("menor", "<");
            AgregarToken("menorIgual", "<=");
            AgregarToken("igual", "=", "iniciooperacion");
            TablaSimbolosC.AgregarTipoASimbolo("=", "separador");
            AgregarToken("finSentencia", ";", "finoperacion");
            TablaSimbolosC.AgregarTipoASimbolo(";", "separador");
        }
    }
}
