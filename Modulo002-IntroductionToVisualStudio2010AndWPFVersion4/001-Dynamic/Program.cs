using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _001_Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiplicar(3, 3));
            Console.WriteLine(Multiplicar(3));

            Console.WriteLine(Multiplicar(y: 3, x: 10));

            Console.WriteLine();

            //clr
            int x = 10;
            //x = "batatinha";

            var y = 10; //variável tipada implicitamente -> int y = 10;

            //dlr
            dynamic z = 10;
            Console.WriteLine("{0} -> {1}", z.GetType().Name, z);

            z = "batatinha";
            Console.WriteLine("{0} -> {1}", z.GetType().Name, z);

            z = DateTime.Now;
            Console.WriteLine("{0} -> {1}", z.GetType().Name, z);

            Console.ReadKey();
        }

        static int Multiplicar(int x, int y = 2) { return x * y; }
    }
}
