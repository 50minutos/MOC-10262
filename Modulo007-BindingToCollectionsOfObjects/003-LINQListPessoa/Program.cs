using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _003_LINQListPessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoas = new List<Pessoa>
            {
                new Pessoa(1, "ADAO", 'M'), 
                new Pessoa(2, "EVA", 'F'), 
                new Pessoa(3, "CAIM", 'M'), 
                new Pessoa(4, "ABEL", 'M')
            };

            var mulheres = from p in pessoas
                           where p.Sexo == 'F'
                           select p;

            var homens = pessoas
                .Where(p => p.Sexo == 'M');

            Console.WriteLine(mulheres);
            Console.WriteLine(mulheres.Count());

            Console.WriteLine(homens);
            Console.WriteLine(homens.Count());

            var pessoa = pessoas
                .FirstOrDefault(p => p.Codigo == 3);

            Console.WriteLine(pessoa);

            pessoas.Remove(pessoas
                .FirstOrDefault(p => p.Codigo == 4));

            Console.WriteLine(pessoas.Count());

            Console.ReadKey();
        }
    }

    class Pessoa
    {
        public int Codigo { get; set; }
        public String Nome { get; set; }
        public char Sexo { get; set; }

        public Pessoa(int c, String n, char s)
        {
            Codigo = c;
            Nome = n;
            Sexo = s;
        }

        public override string ToString()
        {
            return String.Format("{0} -> {1} - {2}", Codigo, Nome, Sexo);
        }
    }
}
