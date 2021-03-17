using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje4
{
    public partial class Form1 : Form
    {
        List<Covid> covidi = new List<Covid>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            Covid c = new Covid();
            c.Godina = 2023; //ovo je poziv procedure!!!
            c.Zemlja = Zemlja.Iran;
            */
            cb_zemlja.DataSource = Enum.GetNames(typeof(Zemlja)); //  Daj mi listu naziva šifri iz enumeracije
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Kreirati novi element tipa virusa i dodati ga u listu
                Covid covid = new Covid();
                covid.Zemlja = (Zemlja) Enum.Parse(typeof(Zemlja),  cb_zemlja.SelectedItem.ToString()); // Prebaci tip u odgovarajuću zemlju, ako ne ide parsirati iz stringa (ne ide)
                covid.Godina = Int32.Parse(tb_godina.Text); // Bolje bi bilo sa TryParse, jer će ispasti greška ako nismo unijeli broj
                covid.Napomena = tb_napomena.Text;
                // Dodaj ga u listu i prikaži sve spremljene
                covidi.Add(covid);
                prikazi_listu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Iznimka: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void prikazi_listu()
        {
            lb_lista.Text = "Virusi: \n";
            foreach (Covid covid in covidi)
            {
                lb_lista.Text += covid.ToString() + "\n";
            }
        }
    }
}
