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

namespace Predavanje13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Ptica> svePticurine = new List<Ptica>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("nemojte klikat", "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            WindowDetail detail = new WindowDetail(svePticurine);
            //Provjeri je li unesena nova ptica i ažuriraj grid
            if ((bool)detail.ShowDialog())
            {
                ptice_grid.ItemsSource = null; //Refreshiraj, može i ovo na bolji način
                ptice_grid.ItemsSource = svePticurine;
                
            }
        }
    }
}
