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
using System.Diagnostics;

namespace _003_Buttons
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();

            layoutRoot.Background = new SolidColorBrush(Color.FromArgb(255, (byte)r.Next(0, 256), (byte)r.Next(0, 256), (byte)r.Next(0, 256)));
        }

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            #region nullable types
            //int? y;
            Nullable<int> y;
            y = null;

            //int x;
            Int32 x;
            //x = null;
            x = y.HasValue
                ? y.Value
                : 0;
            #endregion

            layoutRoot.Background = new SolidColorBrush(
                (bool)toggleButton.IsChecked 
                ? Colors.LightBlue 
                : Colors.White
                );
        }

        private void PopUp_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            PopUp.IsOpen = false;
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            PopUp.IsOpen = true;
        }

        private void hyperlink1_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(((Hyperlink)sender).NavigateUri.ToString());
        }
    }
}
