using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace Predavanje_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //provjeri je li URL dobar 
            if (!Uri.IsWellFormedUriString(tb_adresa.Text, UriKind.Absolute))
            {
                lb_poruka.Text = "Kriva adresa";
                lb_poruka.ForeColor = Color.Red;
                //Što ovo radi ovdje
                lb_poruka.Text = Thread.CurrentThread.Name;
                return;
            }

            lb_poruka.Text = "";
            lb_poruka.ForeColor = Color.Black;

            Uri url = new Uri(tb_adresa.Text);
            //Otvori stranicu
            webBrowser1.Navigate(url);
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            //Krenulo je otvaranje
            lb_poruka.Text = "Otvaram našu stranicu...";
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            //Gotovo
            lb_poruka.Text = "Stranica je otvorena...";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread t = Thread.CurrentThread;
            t.Name = "Glavna";

            //Idemo s UI threadom u funkciju
            pisiULabelu();

            //t sad gleda na novi thrEAD A ne više na glavni
            t = new Thread(new ThreadStart(pisiULabelu));
            //Daj ime
            t.Name = "Pomoćni";
            //Juriš
            t.Start();

            //Idemo s UI threadom u funkciju
            pisiULabelu();
        }

        private void pisiULabelu()
        {
            Thread t = Thread.CurrentThread;
            //Stani malo
            Thread.Sleep(3000);

            //Ovo nikako ne raditi, m+nije thread safe i izazvati će probleme
            label1.Text += "\n" + t.Name + DateTime.Now.ToLongTimeString();
        }
    }
}
