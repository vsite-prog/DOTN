using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje_5
{
    public partial class Form1 : Form
    {
        public delegate void IspisDelegat(string s);

        // Naš globalni objekt u klasi
        Toalet toaletPapir;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // IspisDelegat del = new IspisDelegat(mBox); immao i bolji (kraći) nači pisanja
            IspisDelegat del = mBox;
            // Dodaj metodu u listu izvođenja delegata
            del += pisiULabelu;
            // mBox(tb_tekst.Text); Direktno ali mi hoćemo preko varijable delegata
            del(tb_tekst.Text);

            // Skini metodu sa liste izvođenja
            del -= pisiULabelu;
            del("Novi tekst");
            // Nema veze sa tekstom, idemo ispisati naš toalet objekt
            toaletPapir.Ispis(mBox);


        }

        void mBox(string tekst)
        {
            // Pojednostavljeni Message Boc
            MessageBox.Show(tekst, "Poruka", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        void pisiULabelu(string tekst)
        {
            label1.Text = tekst;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toaletPapir = new Toalet();
            toaletPapir.Naziv = "Paloma XXL";
            toaletPapir.Kolicina = 200;
            // Sa bi se tebalo pretplatiti na nestalo događaje, sa -= se odjavljuje
            toaletPapir.ZamaloNestalo += mBox;
            toaletPapir.ZamaloNestalo += (txt) => MessageBox.Show("Zamalo nestalo događaj");
            toaletPapir.Nestalo += txt => MessageBox.Show("Nema dovoljno, količina 0", "Nestalo", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Idemo dodati novu funkciju sa lambdom
            IspisDelegat del = txt => MessageBox.Show(txt, "Lambda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            del(tb_tekst.Text);

            // Pozovi Toalet ispis
            toaletPapir.Ispis(t => MessageBox.Show(t));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Pročitak količinu i naruči sa skladišta
            double naruci;
            if (!Double.TryParse(tb_kolicina.Text, out naruci))
            {
                MessageBox.Show("Nije broj", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                toaletPapir.Kolicina -= naruci;
            }
        }
    }
}
