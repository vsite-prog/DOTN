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

namespace WPFAplikacija
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
            // Isto kao u formsima i funkcionira
            MessageBox.Show("Kliknuli ste na Dugme!", "Naslov", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
        }

        private void Meni_Drugi(object sender, RoutedEventArgs e)
        {
            DrugiProzor prozor = new DrugiProzor();
            bool? izlaz = prozor.ShowDialog();
            string poruka = izlaz ?? false ? "Kliknuli ste OK" : "Kliknuli ste Cancel"; // ?? znače kad je vrijednust null prebaci je u false
            MessageBox.Show(poruka, "Naslov", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
        }
        private void Meni_Izlaz(object sender, RoutedEventArgs e)
        {
            // Isto kao u formsima i funkcionira
            this.Close();
        }
    }
}
