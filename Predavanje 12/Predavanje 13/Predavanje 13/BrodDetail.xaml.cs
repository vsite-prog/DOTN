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

namespace Predavanje_13
{
    /// <summary>
    /// Interaction logic for BrodDetail.xaml
    /// </summary>
    public partial class BrodDetail : Window
    {
        List<Brod> lista;
        public BrodDetail(List<Brod> brodovi)
        {
            InitializeComponent();
            lista = brodovi; //refernca na ukupnu listu brodova
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (tb_drzava.Text == "" || tb_luka.Text == "" || tb_naziv.Text == "")
            {
                textBlock.Text = "Morate unijeti sve podatke.\n POkušajte ponovo...";
                textBlock.Foreground = Brushes.Red;
                return;
            }

            Brod b = new Brod();
            b.Luka = tb_luka.Text;
            b.Naziv = tb_naziv.Text;
            b.Drzava = tb_drzava.Text;
            lista.Add(b);
            this.DialogResult = true;
            this.Close();

        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
