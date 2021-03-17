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
            MessageBox.Show("Kliknuli ste, bla, bla", "Poruka", MessageBoxButton.OKCancel, MessageBoxImage.Information);
        }

        private void Drugi_Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(tb_unos.Text, "TextBox", MessageBoxButton.OKCancel, MessageBoxImage.Information);
        }

        private void Click_Drugi_Prozor(object sender, RoutedEventArgs e)
        {
            DrugiProzor prozor = new DrugiProzor();
            bool? rezultat = prozor.ShowDialog();
            string poruka = rezultat == true ? "Vratili smo se sa OK!" : "Vratili smo se sa Cancel ili ničim!";
            MessageBox.Show(poruka, "Druga forma", MessageBoxButton.OKCancel, MessageBoxImage.Information);
        }

        private void Click_Kraj(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


    }
    }
