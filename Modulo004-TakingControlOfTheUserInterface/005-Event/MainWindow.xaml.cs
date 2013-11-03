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

namespace _005_Event
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

        private void Botao_Click(Object o, RoutedEventArgs e)
        {
            MessageBox.Show("Clicou no Botão");
            e.Handled = true;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Carregou");
        }

        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(String.Format("Clicou no Botão (Grid)\n{0}\n{1}", ((Button)e.Source).Content.ToString(), ((Button)e.Source).Name));
        }
    }
}
