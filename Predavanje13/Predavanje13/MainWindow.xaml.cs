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
        //Izvor za DataGrid
        List<Student> lista = new List<Student>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          // Izbrisano  MessageBox.Show(tb1.Text);
        }

        private void Nova_Click(object sender, RoutedEventArgs e)
        {
            StudentWindow w = new StudentWindow( lista);
            //Vraća true/false Dialog result
            bool res = (bool)w.ShowDialog();
            //kreiran novi student
            if (res)
            {
                dg_studenti.ItemsSource = null;
                dg_studenti.ItemsSource = lista;
            }
        }
    }
}
