using System;

namespace Extension_de_int
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            //Extendemos el int añadiendo el método Between
            a.Between(5, 15);
        }
    }


}