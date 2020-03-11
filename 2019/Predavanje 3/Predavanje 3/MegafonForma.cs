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
    public partial class MegafonForma : Form
    {
        // Lokalna lista u ovoj klasi 
        List<string> lista;
        public MegafonForma(List<string> pLista)
        {
            InitializeComponent();
            // Lista u obe dvije forme je ista
            lista = pLista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lista.Add(tb_ponovi.Text);
            // Ovo će i zatvoriti formu, vraća isti kod kao i MBox
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Ovo će i zatvoriti formu
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
