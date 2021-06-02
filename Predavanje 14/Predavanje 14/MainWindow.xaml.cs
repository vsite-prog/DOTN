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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string txt = box1.Text;
            MessageBox.Show(txt);
        }
        private void Drugi_Click(object sender, RoutedEventArgs e)
        {
            Prozor2 prozor = new Prozor2();
            bool? odgovor = prozor.ShowDialog();
        }

        private void Zalijepi_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = box1.Text != "";
        }

        private void Zalijepi_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Zalijepi_Labela.Content = Clipboard.GetText();
            Zalijepi_Labela.Content += box1.Text;
        }
    }
}
