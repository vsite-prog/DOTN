using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje_7
{
    public partial class Form1 : Form
    {
        // Kreiraj listu elemenata koji imaju sučelje IVirus
        List<IVirus> sviVirusi = new List<IVirus>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_virus.DataSource = new List<string>() { "Corona", "SARS", "HIV" };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Spremili bi novi virus u listu
            IVirus virus; // Varijabla tipa objekta , klasa mu mor aimati sučelje
            switch (cb_virus.SelectedItem.ToString())
            {
                case "Corona":
                    Corona corona = new Corona();
                    corona.Drzava = tb_drzava.Text;
                    corona.PostaviBrojZarazenih(Int64.Parse(tb_broj.Text));  // Ljepše sa try parse
                    // Ovo nema u sučelju
                    corona.PocetakKarantena = monthCalendar1.SelectionStart;
                    // Da bi išao u listu moramo ga staviti kao IVirus
                    virus = corona; // No problem jer corona ima sučelje
                    break;
                case "SARS":
                    virus = new Sars();
                    virus.Drzava = tb_drzava.Text;
                    virus.PostaviBrojZarazenih(Int64.Parse(tb_broj.Text));  
                    break;
                default:
                    virus = new HIV();
                    virus.Drzava = tb_drzava.Text;
                    virus.PostaviBrojZarazenih(Int64.Parse(tb_broj.Text));
                    break;
            }

            // Idemo ga dodati u listu
            sviVirusi.Add(virus);

            // Poredaj ih po broju zaraženih
            sviVirusi.Sort(); // samo ovo
            prikaziListuVirusa();
        }

        void prikaziListuVirusa()
        {
            lb_lista.Text = "Lista virusa po zemljama:\n";
            foreach(IVirus virus in sviVirusi)
            {
                lb_lista.Text += $"{virus.Naziv} broj zaraženih: {virus.BrojZarazenih}  država: {virus.Drzava}";
                Corona corona = virus as Corona; // as je kao cast
                if(corona != null) // Ako nije corona onda je varijabla nepostaljena
                {
                    lb_lista.Text += "Karantena od: " + corona.PocetakKarantena.ToLongDateString();
                }
                lb_lista.Text += "\n";
            }
        }

        private void cb_virus_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Sakrij kalendar ako nije u combu Corona
            monthCalendar1.Visible = cb_virus.SelectedItem.ToString() == "Corona";
        }
    }
}
