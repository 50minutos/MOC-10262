using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Media;

namespace _004_Converter
{
    //existe o BrushConverter!!!
    class BrushStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var t = typeof(Colors);
            var p = t.GetProperty(value.ToString());
            var c = (Color)p.GetValue(null, null);

            return new SolidColorBrush(c);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return System.Convert.ChangeType(value, targetType);
        }
    }
}
