using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje_9
{
    public partial class BrowserForm : Form
    {
        public BrowserForm()
        {
            InitializeComponent();
            webBrowser1.DocumentCompleted += (o, a) =>
            {
                status_label.Text = "Uspješno otvorena stranica " + a.Url.ToString();
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Uri uri;
            // Provjeri da li je adresa ispravna
            if (!Uri.TryCreate(tb_adresa.Text, UriKind.Absolute, out uri))
            {
                uri = new Uri("https://google.hr/?q=" + tb_adresa.Text); // Neka bolje ide na Google
               // status_label.Text = "Greška u adresi!!!";
            }
            webBrowser1.Navigate(uri);
        }
    }
}
