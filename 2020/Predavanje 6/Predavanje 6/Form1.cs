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
        // Kreiraj novu generičku listu
        List<Raketa> sveRakete = new List<Raketa>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bt_kreiraj.Click += (o, args) =>
            {
                Raketa r = new Raketa();
                r.Naziv = tb_naziv.Text;

                r.Boooom += (obj, a) =>
                {
                    Raketa raketa = (Raketa)obj;
                    // obj je nekakva referenca na raketu koja je okinila događaj
                    MessageBox.Show(raketa.Naziv, "Izgorila raketa event", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                };

                sveRakete.Add(r);

                cb_rakete.DataSource = null; // Ovo služi za refresh
                cb_rakete.DataSource = sveRakete;
                // Prikaži Naziv rakete
                cb_rakete.DisplayMember = "Naziv";
                // Zovemo tri puta generičku funkciju sa različitim elementima
                Poruka<string>("Kreirana nova raketa i dodana u listu");
                Poruka<int>(sveRakete.Count);
                Poruka<Raketa>(r);
            };

            bt_plus.Click += (o, args) =>
            {
                // Pročitaj iz Comba

                Raketa r = (Raketa)cb_rakete.SelectedItem;
                // SAmo povećaj za 100 brzinu
                r.Brzina += 100;
            };
        }

        // Generička metoda
        void Poruka<T>( T element)
        {
            string prikaz = element.ToString();
            MessageBox.Show(prikaz,"Poruka", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
    }
}
