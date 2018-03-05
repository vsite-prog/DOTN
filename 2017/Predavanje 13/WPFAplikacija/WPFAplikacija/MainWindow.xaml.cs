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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //Isto kao u formi
            string text = tb_text.Text;

            MessageBox.Show(text, "Unos", MessageBoxButton.OK, MessageBoxImage.Hand);

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void pozovi(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ručno kreirano", "Ništa", MessageBoxButton.OK, MessageBoxImage.Hand);
            //Ovo je malo različito nego u formi
            this.Background = Brushes.BlueViolet;
        }
    }
}
