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

namespace Abstract_Factory
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SelectionTheme.ItemsSource = ListTheme;


            IWidgetFactory Theme = new ARKTheme();

            BuResultat.Background = new BrushConverter().ConvertFromString(Theme.ChargerTheme()) as SolidColorBrush;

        }

        public List<string> ListTheme = new List<string> { "Dofus", "ARK"};


}
}
