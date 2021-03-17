using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje_3
{
    public partial class DrugaForma : Form
    {
        List<string> spremnikPoruka;
        public DrugaForma(List<string> poruke)
        {
            InitializeComponent();
            spremnikPoruka = poruke;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            spremnikPoruka.Add(tb_poruka.Text);
            // >Forma se ponaša kao message box
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Ne treba form close, forma će se zatvoriti
            DialogResult = DialogResult.Cancel;
        }
    }
}
