using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;

namespace _001_Culture
{
    class Program
    {
        static void Main(string[] args)
        {
            var dt = DateTime.Now;
            var d = 1000.32;

            Console.WriteLine(Thread.CurrentThread.CurrentCulture);
            Console.WriteLine(Thread.CurrentThread.CurrentUICulture);

            Console.WriteLine();

            Console.WriteLine(String.Format("{0:n}", d));
            Console.WriteLine(String.Format("{0:c}", d));
            Console.WriteLine(dt);

            Console.WriteLine();

            Thread.CurrentThread.CurrentCulture = 
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("pt-BR");

            Console.WriteLine(Thread.CurrentThread.CurrentCulture);
            Console.WriteLine(Thread.CurrentThread.CurrentUICulture);

            Console.WriteLine();
            
            Console.WriteLine(String.Format("{0:n}", d));
            Console.WriteLine(String.Format("{0:c}", d));
            Console.WriteLine(dt);

            Console.ReadKey();
        }
    }
}
