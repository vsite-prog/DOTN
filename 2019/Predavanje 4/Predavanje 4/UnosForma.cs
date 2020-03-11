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
    public partial class UnosForma : Form
    {
        List<Plovilo> plovila;
        public UnosForma(List<Plovilo> pPlovila)
        {
            InitializeComponent();
            plovila = pPlovila;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Idemo kreirati novu Jedrilicu
            Jedrilica j = new Jedrilica();
            j.Naziv = tb_naziv.Text;
            j.Tip = (TipPlovila)Enum.Parse(typeof(TipPlovila), cb_tip.SelectedItem.ToString());
            j.Registracija = tb_reg.Text;
            j.Godiste = Int32.Parse(tb_godiste.Text); // Parsiraj u int
            // Dodaj u listu
            plovila.Add(j);
            DialogResult = DialogResult.OK;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UnosForma_Load(object sender, EventArgs e)
        {
            // Idemo napuniti Combo, statičkom metodom
            cb_tip.DataSource = Enum.GetValues(typeof(TipPlovila));
        }
    }
}
