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

        private void Dugme_Kliknuto(object sender, RoutedEventArgs e)
        {
            string poruka = tb_unos.Text;
            MessageBox.Show(poruka);
        }

        private void Idi(object sender, RoutedEventArgs e)
        {
            DrugiProzor prozor = new DrugiProzor();
            bool? potvrda = prozor.ShowDialog();
            string poruka = potvrda == true ? "potvrdio" : "odbacio";
            MessageBox.Show($"KOrisnik je {poruka}");
        }

        private void Izlaz(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
