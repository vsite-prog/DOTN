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

namespace Predavanje_13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Brod> brodovi = new List<Brod>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            bool novi = (bool) new BrodDetail(brodovi).ShowDialog();
            if (novi) //novi brod u listi, daj ga prikaži
            {
                grid_brodovi.ItemsSource = null; //promijenio ti se izvor podataka
               grid_brodovi.ItemsSource = brodovi;
            }
        }
    }
}
