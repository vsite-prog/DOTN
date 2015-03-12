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
    public partial class FormaUnos : Form
    {
        List<string> gradovi;
        public FormaUnos(List<string> pLista)
        {
            InitializeComponent();
            gradovi = pLista;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Dodati element u listu
            gradovi.Add(tb_grad.Text);
            DialogResult = DialogResult.OK;
        }
    }
}
