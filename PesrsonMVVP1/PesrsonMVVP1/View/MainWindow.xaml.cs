using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PesrsonMVVP1.ViewModel;

namespace PesrsonMVVP1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Private Variables
        private readonly PesronViewModel _personViewModel;
        #endregion

        #region Constructor
        public MainWindow()
        {
            InitializeComponent();
            _personViewModel = new PesronViewModel();
            DataContext = _personViewModel;
        }
        #endregion

    }
}
