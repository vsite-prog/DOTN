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

namespace Predavanje_14
{
    /// <summary>
    /// Interaction logic for DrugiWindow.xaml
    /// </summary>
    public partial class DrugiWindow : Window
    {
        public DrugiWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            tb_ptica.Text += " poleti!";
        }
    }
}
