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

namespace _004_Ellipses
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool arrastando = false;
        private Point deslocamentoMouse;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void parentCanvas_Click(object sender, MouseButtonEventArgs e)
        {
            if (!arrastando)
            {
                var ellipse = new Ellipse();

                ellipse.Fill = new SolidColorBrush(Colors.Black);
                
                ellipse.Width = 50;
                ellipse.Height = 50;

                var point = e.GetPosition(this);
                
                ellipse.SetValue(Canvas.TopProperty, point.Y - ellipse.Height / 2);
                ellipse.SetValue(Canvas.LeftProperty, point.X - ellipse.Width / 2);

                ellipse.MouseLeftButtonDown += ellipse_MouseDown;

                parentCanvas.Children.Add(ellipse);
            }
        }

        private void ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            arrastando = true;

            var ellipse = sender as Ellipse;

            deslocamentoMouse = e.GetPosition(ellipse);

            ellipse.Fill = new SolidColorBrush(Colors.Green);

            ellipse.MouseMove += ellipse_MouseMove;

            ellipse.MouseLeftButtonUp += ellipse_MouseUp;

            ellipse.CaptureMouse();
        }

        private void ellipse_MouseMove(object sender, MouseEventArgs e)
        {
            if (arrastando)
            {
                var ellipse = sender as Ellipse;

                var point = e.GetPosition(parentCanvas);

                ellipse.SetValue(Canvas.TopProperty, point.Y - deslocamentoMouse.Y);
                ellipse.SetValue(Canvas.LeftProperty, point.X - deslocamentoMouse.X);
            }
        }

        private void ellipse_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (arrastando)
            {
                var ellipse = sender as Ellipse;

                ellipse.Fill = new SolidColorBrush(Color.FromArgb(255, 189, 26, 32));

                ellipse.MouseMove -= ellipse_MouseMove;
                
                ellipse.MouseLeftButtonUp -= ellipse_MouseUp;
                
                ellipse.ReleaseMouseCapture();

                arrastando = false;
            }
        }
    }
}
