using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Objekt konteksta baze
            StudentiEntities db = new StudentiEntities();
            //Novi student
            student s = new student();
            //Pročitaj vrijednoti iz tbox-ova
            s.ime = tb_ime.Text;
            s.oib = tb_oib.Text;
            s.studij_id = Int32.Parse(cb_studij.SelectedItem.ToString());
            //Dodaj studenta u listu studenata
            db.student.Add(s);
            //spremi u bazu
            db.SaveChanges();
            prikazi_studente();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            prikazi_studente();
        }
        private void prikazi_studente()
        {
            StudentiEntities db = new StudentiEntities();
            //LINQ upit daj sve
            var sviStudenti = from s in db.student
                              select s;

            lb_svi.Text = "Lista studeanata: ";
            //upiši u labelu
            foreach (student s in sviStudenti)
            {
                lb_svi.Text += "\n" + s.ime + " " + s.oib;
            }

        }
    }
}
