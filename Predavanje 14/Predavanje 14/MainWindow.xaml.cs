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

        private void B_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Izlaz_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Drugi_Click(object sender, RoutedEventArgs e)
        {
            Drugi prozor = new Drugi();
            prozor.ShowDialog();
        }

        private void Paste_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            // Ne uzima clipboard, nego ćemo ga pregaziti
            e.CanExecute = tbox.Text != ""; // Ak ima nešto možeš paste-at ako ne disable
           
        }

        private void Paste_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // Umjesto standarda samo dodaj iz tboxa tekst
            tblock.Text += tbox.Text;
        }
    }
}
