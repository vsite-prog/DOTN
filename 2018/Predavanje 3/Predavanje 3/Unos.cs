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
    public partial class Unos : Form
    {
        List<string> _studenti;
        public Unos(List<string> studenti)
        {
            InitializeComponent();
            _studenti = studenti;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _studenti.Add(tb_student.Text);
            //Zatvori formu i idi vani
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Zatvori formu i idi vani
            this.DialogResult = DialogResult.Cancel;
        }

        private void Unos_Load(object sender, EventArgs e)
        {

            //Idi na enter vani s OK
            this.AcceptButton = button1;
            //ili sa ESC
            this.CancelButton = button2;
        }
    }
}
