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

        private void Zatvori_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Druga_Click(object sender, RoutedEventArgs e)
        {
            DrugiWindow w = new DrugiWindow();
            w.ShowDialog();
        }

        private void Klik_Click(object sender, RoutedEventArgs e)
        {
            tblock1.Text += tbox1.Text + "\n";
        }

        private void Cut_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            //Ovaj dio kaža da li se komanda može izvršiti
            e.CanExecute = tbox1.Text != ""; //vraća bool koji kaže je li išta uneseno u tb
        }

        private void Cut_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //Kopiraj u clipboard sadržaj tb
            Clipboard.SetText(tbox1.Text);
            tbox1.Text = "";
        }
        private void Paste_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            //Ovaj dio kaža da li se komanda može izvršiti
            e.CanExecute = Clipboard.ContainsText();
        }

        private void Paste_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //Kopiraj u clipboard sadržaj tb
            tblock1.Text = Clipboard.GetText();
            Clipboard.Clear();
        }
    }
}
