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

namespace WPFAplikacija
{
    /// <summary>
    /// Interaction logic for DrugiProzor.xaml
    /// </summary>
    public partial class DrugiProzor : Window
    {
        public DrugiProzor()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Ovdje vraća samo true/false a ne kao u forms
            this.DialogResult = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
