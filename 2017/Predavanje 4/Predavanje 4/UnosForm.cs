using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje_4
{
    public partial class UnosForm : Form
    {
        List<Auto> sviAuti;
        public UnosForm(List<Auto> pAuti)
        {
            sviAuti = pAuti;
            InitializeComponent();
        }

        private void UnosForm_Load(object sender, EventArgs e)
        {
            //Enumeracija kao izbor u Combu
            cb_tip.DataSource = Enum.GetNames(typeof(TipVozila));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //KOrisnik kaže spremi, čitaj što je unio
            try
            {
                Auto a = new Auto();
                a.Naziv = tb_naziv.Text;
                a.Cijena = Decimal.Parse(tb_cijena.Text);
                a.Godiste = Int32.Parse(tb_godiste.Text);
                //Sada treba pročitati combo i vidjeti koja je to šifra u enumeraciji
                a.Tip = (TipVozila)Enum.Parse(typeof(TipVozila), cb_tip.SelectedItem.ToString());
                //Dodaj u listu
                sviAuti.Add(a);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

    }
}
