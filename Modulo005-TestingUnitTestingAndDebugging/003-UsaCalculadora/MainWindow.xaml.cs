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
using _002_Calculadora;

namespace _003_UsaCalculadora
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Somar.Content = Calculadora.Somar(10, 3);
            Subtrair.Content = Calculadora.Subtrair(10, 3);
            Multiplicar.Content = Calculadora.Multiplicar(10, 3);
            Dividir.Content = Calculadora.Dividir(10, 3);
        }
    }
}
