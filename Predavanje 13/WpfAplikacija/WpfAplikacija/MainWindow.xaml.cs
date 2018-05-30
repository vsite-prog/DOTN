﻿using System;
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

namespace WpfAplikacija
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
            string pojam = tb_pojam.Text; //Isto kao i u formsima
            MessageBox.Show($"UNIJELI STE: {pojam} ", "Naslov", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }


        private void zatvori_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void otvori_click(object sender, RoutedEventArgs e)
        {
            bool? dr = (new SecondWindow()).ShowDialog();
        }
    }
}
