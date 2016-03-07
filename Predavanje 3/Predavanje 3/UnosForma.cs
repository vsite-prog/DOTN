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
    public partial class UnosForma : Form
    {
        List<string> pojmovi;
        public UnosForma(List<string> pPojmovi)
        {
            pojmovi = pPojmovi; //Dodaj listu koju si dobio u ulaznu varijablu
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pojmovi.Add(textBox1.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        
    }
    }
}
