using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace _004_UpdateSourceTrigger
{
    class Pessoa : INotifyPropertyChanged
    {
        public int Codigo { get; set; }

        private String nome;
        public String Nome
        {
            get { return nome; }
            set 
            {
                if (nome == null || !nome.Equals(value))
                {
                    nome = value;
                    OnPropertyChanged("Nome");
                }
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(String name)
        {
            var handler = PropertyChanged;

            if (handler != null)
                handler(this, new PropertyChangedEventArgs(name));
        }
    }
}
