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

namespace Predavanje_14
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

        private void Pritisni_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Pozdrav!");
        }

        private void Izlaz_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


        private void Otvori_Click(object sender, RoutedEventArgs e)
        {
            DrugiProzor prozor = new DrugiProzor();
            prozor.ShowDialog();
        }

        private void Paste_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            // Ako ovo postavlja true, komanda je omogućeno a false ako ne
            e.CanExecute = tb_unos != null && tb_unos.Text != "";
        }

        private void Paste_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // KOpiraj iz tboxa u label
            //tb_unos.Cut();
            // labela.Content = Clipboard.GetText(); // Kopiraj spremljeni tekst
            labela.Content = tb_unos.Text;
        }
    }
}
