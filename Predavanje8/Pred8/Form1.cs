using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pred8
{
    public partial class Form1 : Form
    {
        KladjenjeEntities db = new KladjenjeEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Poveži kombo s tablicom kladionica iz baze
            cb_kladionica.ValueMember = "id";
            cb_kladionica.DisplayMember = "naziv";
            cb_kladionica.DataSource = db.Kladionica.ToList<Kladionica>();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Kreiran jw novi objekt tipa KLadionica (iz EF-a)
            Par par = new Par();
            par.naziv = tb_naziv.Text;
            par.koeficijent = Double.Parse(tb_koeficijent.Text);
            par.Kladionica = (Kladionica)cb_kladionica.SelectedItem;

            //Dodaj par u kolekciju parova, još nije spremljeno
            db.Par.Add(par);

            //Sinhroniziraj
            db.SaveChanges();

        }

        private void cb_kladionica_SelectedIndexChanged(object sender, EventArgs e)
        {
            int kladionica = (int)cb_kladionica.SelectedValue;
            // dataGridView1.DataSource = db.Par.Where(p => p.kladId == kladionica);
            dataGridView1.DataSource = (
                                            from par in db.Par
                                            where par.kladId == kladionica
                                            select new { Naziv = par.naziv, Koeficijent = par.koeficijent }
                                        ).ToList();
        }
    }
    
}
