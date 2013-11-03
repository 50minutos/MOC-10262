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
using System.Windows.Threading;

namespace _001_Dispatcher
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
            var dt = new DispatcherTimer();

            dt.Interval = TimeSpan.FromSeconds(1);
            dt.Tick += dt_Tick;

            dt.Start();
        }

        void dt_Tick(object sender, EventArgs e)
        {
            DataHora.Content = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
