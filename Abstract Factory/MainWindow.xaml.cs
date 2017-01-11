using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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




        }

        public ObservableCollection<IWidgetFactory> ListTheme = new ObservableCollection<IWidgetFactory> { new ARKTheme(), new DofusTheme()};

        private void SelectionTheme_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            IWidgetFactory Theme = (IWidgetFactory) SelectionTheme.SelectedItem;
            BuResultat.Background = new BrushConverter().ConvertFromString(Theme.ChargerTheme()) as SolidColorBrush;
        }
    }
}
