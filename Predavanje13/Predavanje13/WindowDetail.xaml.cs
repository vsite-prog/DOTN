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
using System.Windows.Shapes;

namespace Predavanje13
{
    /// <summary>
    /// Interaction logic for WindowDetail.xaml
    /// </summary>
    public partial class WindowDetail : Window
    {
        List<Ptica> listaPtica;
        public WindowDetail(List<Ptica> lista)
        {
            InitializeComponent();
            listaPtica = lista;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Ptica ptica = new Ptica();
            ptica.Naziv = tb_naziv.Text;
            ptica.Vrsta = tb_vrsta.Text;
           // MessageBox.Show(ptica.Naziv + " " + ptica.Vrsta);
            listaPtica.Add(ptica);

            this.DialogResult = true;
            this.Close();
        }
    }
}
