using System;
using System.Collections.Generic;
using System.Text;

namespace Extension_de_int
{
    static public class ExtensionInt
    {
        //Tiene que ser un método "public static" y recibir el parámetro "this"
        //el cual hace referencia al "objeto" o "dato" desde el cual se invoca al método Between
        public static bool Between(this int valor, int minValor, int maxValor)
        {
            return valor >= minValor && valor <= maxValor;
        }
    }
}
