using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _006_DataTemplateResource
{
    public class Pessoa
    {
        public int Codigo { get; set; }
        public String Nome { get; set; }

        public Pessoa(int codigo, String nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        public override string ToString()
        {
            return String.Format("{0} -> {1}", Codigo, Nome);
        }
    }
}
