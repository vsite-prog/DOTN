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

        private void Cut_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if(tb_brod.Text == "")
                e.CanExecute = false;
            else
                e.CanExecute = true;


        }


        private void Cut_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            tb_brod.Cut(); //Spremi u clipboard
        }


        private void Paste_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = Clipboard.ContainsText();
        }


        private void Paste_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            textBlock.Text = Clipboard.GetText();
        }

    }
}
