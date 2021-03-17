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
        // Lokalna varijabla svih studenata
        List<string> lista;
        public DrugaForma(List<string> pLista)
        {
            InitializeComponent();
            lista = pLista;
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            // Dodaj novog studenta u listu
            lista.Add(tb_student.Text);
            // Ovo će zatvoriti formu kao Close
            DialogResult = DialogResult.OK;
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
