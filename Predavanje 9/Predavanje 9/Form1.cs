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

namespace Predavanje_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Thread.CurrentThread.Name = "Glavna";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lb_status.ForeColor = Color.Black; //resetiraj boju
            if (Uri.IsWellFormedUriString(tb_adresa.Text,UriKind.Absolute)) //provjeri je li URL ispravan
            {
                Uri uri = new Uri(tb_adresa.Text);
                webBrowser1.Navigate(uri);
            } else
            {
                lb_status.ForeColor = Color.Red;
                lb_status.Text = "Krivi URL!!!";
            }
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            lb_status.Text = "Učitavanje stranice gotovo!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop(); //Prekini odmahh
        }

        private void Threadaj(object sender, EventArgs e)
        {
            
            ThreadStart del = nesto; //Delegat kojeg očekuje klasa Thread
            Thread nit = new Thread(del);
            nit.Name = "Nit2";
            nit.Start();
            Thread.Sleep(500);
            nesto(); //nalazimo se u glavnoj niti
        }

        void nesto()
        {
            //Ovo nije Thread Safe!!!
            for(int i=0; i < 10; i++)
            {
                Thread.Sleep(100); //desetina sekunde
                lb_status.Text += Thread.CurrentThread.Name + ":" + i.ToString() + ";";
            }
        }
    }
}
