using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje8
{
    public partial class Form1 : Form
    {
        //Neka bude global
        BazaEntities db;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            db = new BazaEntities();
            var klad = (from p in db.parovi
                         select p.klad_id)
                        .Distinct();
            cb_kladionica.DataSource = klad.ToList();
            /*
            var kladionice = from k in db.parovi
                             select new { Naziv = k.naziv, Koeficijent = k.koef };
            dataGridView1.DataSource = kladionice.ToList();
             * */
        }

        private void cb_kladionica_SelectedIndexChanged(object sender, EventArgs e)
        {
            int brojKladionice = (int)cb_kladionica.SelectedValue;
            /*var kladionice = from k in db.parovi
                             where k.klad_id == brojKladionice
                             select new { Naziv = k.naziv, Koeficijent = k.koef };
             * */
            var kladionice = db.parovi.Where(p => p.klad_id == brojKladionice);
            dataGridView1.DataSource = kladionice.ToList();
        }
    }
}
