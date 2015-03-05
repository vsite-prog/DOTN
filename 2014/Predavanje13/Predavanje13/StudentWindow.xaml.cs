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
    /// Interaction logic for StudentWindow.xaml
    /// </summary>
    public partial class StudentWindow : Window
    {
        List<Student> lista;
        public StudentWindow(List<Student> pLista)
        {
            lista = pLista;
            InitializeComponent();
        }

        private void Cancel_click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private void ok_click(object sender, RoutedEventArgs e)
        {
            Student s = new Student();
            s.Ime = tb_ime.Text;
            s.Prezime = tb_prezime.Text;
            lista.Add(s);

            this.DialogResult = true;
            this.Close();


        }
    }
}
