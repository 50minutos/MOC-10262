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
using System.Windows.Media.Animation;

namespace _004_Animation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Storyboard es = new Storyboard();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var ellipse = new EllipseGeometry();
        
            ellipse.Center = new Point(100, 100);
            ellipse.RadiusX = 
                ellipse.RadiusY = 10;

            var path = new Path();

            path.Fill = Brushes.Red;
            path.Data = ellipse;

            canvas.Children.Add(path);

            var pa = new PointAnimation();

            pa.Duration = TimeSpan.FromSeconds(1);
            pa.RepeatBehavior = RepeatBehavior.Forever;
            pa.AutoReverse = true;
            pa.From = new Point(100, 100);
            pa.To = new Point(this.Width - 100, 100);

            RegisterName("ellipse", ellipse);

            Storyboard.SetTargetName(pa, "ellipse");
            Storyboard.SetTargetProperty(pa, new PropertyPath(EllipseGeometry.CenterProperty));

            es.Children.Add(pa);

            path.Loaded += new RoutedEventHandler(path_Loaded);
        }

        void path_Loaded(object sender, RoutedEventArgs e)
        {
            es.Begin(this);
        }
    }
}
