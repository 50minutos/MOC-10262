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

namespace _001_Resource
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
            //B3.Foreground = (SolidColorBrush)this.FindResource("grayBrush");
            //B3.Foreground = (SolidColorBrush)this.FindResource("graaaayBrush");
            //B3.Foreground = (SolidColorBrush)this.TryFindResource("graaaayBrush");
            var brush = (SolidColorBrush)this.TryFindResource("graaaayBrush");

            if (brush != null)
                B3.Foreground = brush;

            B4.SetResourceReference(Button.BackgroundProperty, "blueBrush");
            B4.SetResourceReference(Button.ForegroundProperty, "grayBrush");

            //brush = (SolidColorBrush)Resources["blueBrush"];
            brush = (SolidColorBrush)Resources["bluuuuuueBrush"];

            if (brush != null)
                B5.Foreground = brush;
        }
    }
}
