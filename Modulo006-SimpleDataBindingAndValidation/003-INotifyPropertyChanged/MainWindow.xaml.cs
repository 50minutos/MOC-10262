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
using System.ComponentModel;

namespace _003_INotificationPropertyChanged
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
            Pessoa p = new Pessoa { Codigo = 1, Nome = "ADÃO" };

            p.PropertyChanged += p_PropertyChanged;

            p.Codigo = 2;
            p.Nome = "Adão";
        }

        void p_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var t = sender.GetType();

            var p = t.GetProperty(e.PropertyName);

            Notificacoes.Items.Add(String.Format("{0} -> {1}", e.PropertyName, p.GetValue(sender, null))); 
        }
    } 
}
