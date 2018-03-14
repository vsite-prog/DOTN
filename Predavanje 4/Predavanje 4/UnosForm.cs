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
        List<Auto> auti;
        public UnosForm(List<Auto> pAuti)
        {
            auti = pAuti; //Spremi vezu na listu u lokalnu varijablu
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Spremi novi auto
                Auto auto = new Auto();
                auto.Registracija = tb_reg.Text;
                //Parsij pa prepakiraj!
                auto.Tip = (TipVozila)Enum.Parse(typeof(TipVozila), cb_tip.SelectedItem.ToString());
                auto.Godiste = Int32.Parse(tb_god.Text);
                auto.Opis = tb_opis.Text;
                auti.Add(auto);
                DialogResult = DialogResult.OK;
            } catch (Exception ex)
            {
                //Ovo bi bilo ljepsše staviti u labelu
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void UnosForm_Load(object sender, EventArgs e)
        {
            //Pročitaj što ima u enumeraciji, koristi typeof
            cb_tip.DataSource = Enum.GetValues(typeof(TipVozila));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
