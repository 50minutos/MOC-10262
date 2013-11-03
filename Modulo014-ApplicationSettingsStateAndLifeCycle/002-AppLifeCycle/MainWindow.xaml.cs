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

namespace _002_AppLifeCycle
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

        private void Window_Activated(object sender, EventArgs e)
        {
            Eventos.Items.Add("Window_Activated");
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(MessageBox.Show("Quer fechar a bagaça???", "Responda", MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes)
                e.Cancel = true;
        }

        private void Window_Deactivated(object sender, EventArgs e)
        {
            Eventos.Items.Add("Window_Deactivated");
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            Eventos.Items.Add("Window_Initialized");
        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            Eventos.Items.Add("Window_IsVisibleChanged");
        }
    }
}
