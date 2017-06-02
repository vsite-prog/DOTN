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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            DrugiWindow window = new DrugiWindow();
            window.ShowDialog();
        }

        private void Zatvori_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Cut_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Clipboard.SetText(tb_unos.Text);
            tb_unos.Text = "";
        }

        private void Paste_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            tbl_paste.Text = Clipboard.GetText();
            Clipboard.Clear();
        }

        private void Cut_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if(tb_unos != null)
            {
                e.CanExecute = (tb_unos.Text != "");
            } else
            {
                e.CanExecute = false;
            }
            
        }
        private void Paste_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = Clipboard.ContainsText();
        }
    }
}
