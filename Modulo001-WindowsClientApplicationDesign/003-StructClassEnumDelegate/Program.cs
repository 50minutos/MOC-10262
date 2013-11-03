using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _003_StructClassEnumDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro("VW", "Fusca", "ABC1234");

            //RESHARPER

            var f = new Fracao(1, 2);
            Console.WriteLine(f);

            var p = new Pessoa(1, "adão", Sexo.Masculino);
            Console.WriteLine(p);

            var d1 = new DImprimir(Imprimir);
            d1("qualquer coisa");

            var d2 = new DImprimir(ImprimirMaiusculas);
            d2.Invoke("outra coisa qualquer");

            var d3 = new DImprimir(Imprimir);
            d3();

            Imprimir();

            Console.ReadKey();
        }

        static void Imprimir(String txt = "opa...")
        {
            Console.WriteLine(txt);
        }

        static void ImprimirMaiusculas(String txt)
        {
            Console.WriteLine(txt.ToUpper());
        }
    }

    delegate void DImprimir(String txt = "iêpa!!!");

    enum Sexo
    { 
        Masculino, Feminino
    }

    class Pessoa
    {
        public int Codigo { get; set; }
        public String Nome { get; set; }
        public Sexo Sexo { get; set; }

        public Pessoa(int c, String n, Sexo s)
        {
            Codigo = c;
            Nome = n;
            Sexo = s;
        }

        public override string ToString()
        {
            return String.Format("{0} -> {1} ({2})", Codigo, Nome, Sexo);
        }
    }
    
    struct Fracao
    {
        private int numerador;
        public int Numerador
        {
            get { return numerador; }
            set { numerador = value; }
        }

        private int denominador;
        public int Denominador
        {
            get { return denominador; }
            set { denominador = value; }
        }

        public Fracao(int n, int d)
        {
            numerador = n;
            denominador = d;
        }

        public override string ToString()
        {
            return String.Format("{0}/{1}", Numerador, Denominador);
        }
    }

    class Carro
    {
        private string marca;
        private string modelo;
        private string placa;

        public Carro(string marca, string modelo, string placa)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.placa = placa;
        }
    }
}
