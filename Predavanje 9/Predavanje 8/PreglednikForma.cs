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
    public partial class PreglednikForma : Form
    {
        public PreglednikForma()
        {
            InitializeComponent();

            // Event handler za kontrolu preglednika i hvata događaj kad je sve uspjelo
            webBrowser1.DocumentCompleted += (o, e) =>
            {
                lb_statusa.Text = "Stranica prikazana!";
                lb_statusa.ForeColor = Color.Black;
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Pročitaj adresu
            Uri adresa;
            
            if (Uri.TryCreate(tb_adresa.Text, UriKind.Absolute, out adresa))
            {
                // Ajde sada učitaj i prikaži 
                webBrowser1.Navigate(adresa);
            } else
            {
                lb_statusa.Text = "Krivo upisan URL!";
                lb_statusa.ForeColor = Color.Red;
            }
        }
    }
}
