using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _002_Calculadora
{
    public class Calculadora
    {
        public static double Somar(double x, double y) { return x + y; }
        public static double Subtrair(double x, double y) { return x - y; }
        public static double Multiplicar(double x, double y) { return x * y; }
        public static double Dividir(double x, double y) { return x / y; }
        public static double ExtrairRaiz(double x, double y = 2) { return Math.Pow(x, 1.0 / y); }
    }
}
