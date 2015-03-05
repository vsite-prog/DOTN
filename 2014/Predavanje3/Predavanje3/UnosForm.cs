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
    public partial class UnosForm : Form
    {
        private List<string> lista;
        public UnosForm(List<string> pTextovi)
        {
            InitializeComponent();
            //Poveži referencom listu na textove iz forme 1
            lista = pTextovi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Dodaj u listu
            lista.Add(tb_unos.Text); //pročitaj mu text 
        }
    }
}
