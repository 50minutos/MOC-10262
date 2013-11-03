using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _002_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "50minutos";

            //sem LINQ

            foreach (var item in s)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            //com LINQ - comando

            var letras = from item in s 
                         select item;

            Console.WriteLine(letras);
            Console.WriteLine(letras.Count());

            foreach (var item in letras)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            //com LINQ - métodos de extensão + método

            var maisLetras = s
                .Select(Get);

            foreach (var item in maisLetras)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            //com LINQ - métodos de extensão + lambda expression

            var outrasLetras = s
                .Select(item => item);

            foreach (var item in outrasLetras)
            {
                Console.Write("{0} ", item);
            }

            Console.ReadKey();
        }

        static char Get(char c) { return c; }
    }
}
