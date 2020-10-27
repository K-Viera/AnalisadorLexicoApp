using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AnalizadorLexicoApp
{
    class AnalizarExpresiones
    {
        public string cadena;
        public int posicion;
        public void Principal(string cadena) 
        {
            this.cadena = cadena;
        }
        public char PrimerToken() 
        {
            posicion = 0;
            return (cadena[posicion]);
        }
        public char SiguienteToken()
        {
            posicion++;
            return (cadena[posicion]);
        }


        public void digito()
        {

        }
        public Boolean Es_digito()
        {
            return true;
        }

        public void numero()
        {
            digito();
            numero_prima();
        
        }
        public void numero_prima()
        {
            if (Es_digito())
            {
                digito();
                numero_prima();
            }
        }
    }
}
