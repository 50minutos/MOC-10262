using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using System.Threading;
using System.Globalization;

namespace _002_Resx
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            //_002_Resx.Properties.Resources.Culture = new CultureInfo("en-US");
            //_002_Resx.Properties.Resources.Culture = new CultureInfo("pt-BR");
            _002_Resx.Properties.Resources.Culture = new CultureInfo("ja-JP");
        }
    }
}
