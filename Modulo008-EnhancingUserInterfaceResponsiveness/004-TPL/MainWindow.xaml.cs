using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading.Tasks;

namespace _004_TPL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            foreach (var item in "abc")
            {
                Lista.Items.Add(item);
            }

            Lista.Items.Add("1--------------");

            Parallel.ForEach("abc", item => Dispatcher.BeginInvoke(new Action<char>(Add), item));

            Lista.Items.Add("2--------------");

            Parallel.Invoke(() => Adicionar(), () => AdicionarOutraCoisa());

            Lista.Items.Add("3--------------");
        }

        private void Add<T>(T item) { Lista.Items.Add(item); }
        
        private void Adicionar()
        {
            Dispatcher.BeginInvoke(new Action<String>(Add), "qualquer coisa");
        }

        private void AdicionarOutraCoisa()
        {
             Dispatcher.BeginInvoke(new Action<String>(Add), "outra coisa");
       }
    }
}
