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

namespace Testprogramm_Datenbankzugriff
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DatenbankZugriff Datenbank = new DatenbankZugriff();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void DatenAuslesenBtn_Click(object sender, RoutedEventArgs e)
        {
            List<string> daten = Datenbank.GetData;

            DatenListbox.ItemsSource = daten;
            DatenListbox.Items.Refresh();
        }
    }
}
