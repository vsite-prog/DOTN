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
            //Kaži kad je gotovo
            webBrowser1.DocumentCompleted += (o, a) =>
            {
                lb_status.Text = "Gotovi smo!";
                lb_status.ForeColor = Color.Black;
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Uri url = new Uri(tb_url.Text, UriKind.Absolute);
                //Idi na stranicu
                webBrowser1.Navigate(url);
            } catch (UriFormatException ex)
            {
                lb_status.Text = "Krivi URL!";
                lb_status.ForeColor = Color.Red;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
            //Zaustavi se
            lb_status.Text = "Prekid!";
            lb_status.ForeColor = Color.Black;

        }


    }
}
