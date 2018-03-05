using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje3
{
    public partial class DrugaForma : Form
    {
        List<string> sviStudenti;
        public DrugaForma(List<string> pLista)
        {
            InitializeComponent();
            //Zapamti referencu na listu studenata
            sviStudenti = pLista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Neka korisnik potvrdi cancel
            DialogResult dr = MessageBox.Show("Da li odustajete?", "Izlaz", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sviStudenti.Add(tb_student.Text);
            this.DialogResult = DialogResult.OK;
        }
    }
}
