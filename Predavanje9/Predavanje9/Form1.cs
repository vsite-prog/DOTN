using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Predavanje9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Trenutna nit koja se izvodi je glavna
            Thread.CurrentThread.Name = "Glavna";
            //idemo je izvesti  asinhrono
            Thread novaNit = new Thread(new ThreadStart(nista_pametno));
            novaNit.Name = "Nova";
            nista_pametno();

            //novaNit.Name = "Nova2"; ime se postavljasamo na početku
            //sad zbilja pokreni izvođenje
            novaNit.Start();
            //sinhrono
            nista_pametno();
            //MessageBox.Show(Thread.CurrentThread.Name);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Uri.IsWellFormedUriString(tb_adresa.Text, UriKind.Absolute))
                webBrowser1.Navigate(tb_adresa.Text);
            else
                MessageBox.Show("Kakva je to adresa???","Gr4eska");
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            label2.Text = "Ima li mreže? skidam stranicu...";
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            label2.Text = "Gotovo";
        }
        private void nista_pametno()
        {
            Thread.Sleep(2000);
            // MessageBox.Show(Thread.CurrentThread.Name);
            label2.Text = Thread.CurrentThread.Name;
        }
    }
}
