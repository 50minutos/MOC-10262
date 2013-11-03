using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace _006_DataTemplateResource
{
    class ListPessoa : ObservableCollection<Pessoa>
    {
        public ListPessoa()
            : base()
        {
            Add(new Pessoa(1, "ADÃO"));
            Add(new Pessoa(2, "EVA"));
            Add(new Pessoa(3, "CAIM"));
            Add(new Pessoa(4, "ABEL"));
        }
    }
}
