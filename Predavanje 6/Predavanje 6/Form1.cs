using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje_6
{
    public partial class Form1 : Form
    {
        List<Raketa> rakete = new List<Raketa>();
        public Form1()
        {

            InitializeComponent();
            Load += Form1_Load;
            DajAlert<string>("Dobro došli na predavanje 6");
            DajAlert<DateTime>(DateTime.Now);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Sender je sama forma
            Form1 forma = (Form1)sender; // Castaj u Form tip
            // MessageBox.Show("Hello " +  forma.Text);

            bt_unesi.Click += (o, a) =>  // može biti samo +=
            {
                // Lambda ima kontekst objekta u kojem se nalazi, this je forma
                Raketa raketa = new Raketa();
                raketa.Ime = tb_ime.Text;
                raketa.Brzina = Double.Parse(tb_brzina.Text); // Try bi bio bolji
                // Prati kada raketa eksplodira
                raketa.Boom += (obj, args) =>
                {
                    Raketa r = obj as Raketa; // as je kao cast ali vrati null ako ne uspije
                    MessageBox.Show(r.ToString(), "Eksplodirala", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                };
                rakete.Add(raketa);

                DajAlert<Raketa>(raketa);

                // Dodaj u comboBox
                cb_rakete.DataSource = null; // Refresh
                cb_rakete.DataSource = rakete;
                cb_rakete.DisplayMember = "Ime";
            

            };

            bt_500.Click += (o, a) =>
            {
                // Dohvati raketu koja se ubrzaje i ubrzaj
                Raketa raketa = cb_rakete.SelectedItem as Raketa;
                raketa.Brzina += 500;
            };
                
        }

        // Generička funkcija 
        void DajAlert<T>(T element)
        {
            MessageBox.Show(element.ToString(), "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

    }
}
