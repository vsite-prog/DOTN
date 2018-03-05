using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje_8
{
    public partial class BrowserForm : Form
    {
        public BrowserForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Klik na traži, update-aj stranicu u browseru
            //Idemo vidjeti je li URL OK
            Uri adresa;
            if(Uri.TryCreate(tb_uri.Text,UriKind.Absolute, out adresa))
            {
                //Kad je URL dobar idi
                webBrowser1.Navigate(adresa);
            } else //uri nije dobar
            {
                lb_status.Text = "Greška: Krivi URL!";
                lb_status.ForeColor = Color.Red;

            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //Događaj koji se okida kad je sve uspješno prikazano
            lb_status.ForeColor = Color.Black;
            lb_status.Text = "Stranica uspješno prikazana!";
        }
    }
}
