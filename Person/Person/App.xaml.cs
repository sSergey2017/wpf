using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Persons.View;
using Persons.ViewModel;

namespace Persons
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var mw = new MainWindowView
            {
                DataContext = new MainWindowViewModel()
            };
            mw.Show();
        }
    }
}
