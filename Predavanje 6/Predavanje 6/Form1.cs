using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje_6
{
    public partial class Form1 : Form
    {
        //Global avion
        // Avion a; Nećemo samo jedan

            //Lista aviona
        List<Avion> avioni = new List<Avion>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Demonstriramo generike
            Mbox<int>(23);

            //Idemo ovdje definirati klik na button, pomoću lambde
            bt_spremi.Click += (obj, args) =>
            {
                //obj je buttun i mogli bi ga castati, vidi dole
                Avion a = new Avion(tb_naziv.Text, 0);
                a.Crash += (o, ar) =>
                {
                    Mbox<Avion>(a);
                };
                avioni.Add(a);
                cb_avioni.DataSource = null; //pokušaj refresh-a
                cb_avioni.DataSource = avioni;
                cb_avioni.DisplayMember = "Naziv";
            };

            bt_brzina.Click += (obj, args) =>
            {
                //Sad mi treba refernca na avion, idemo u combo box
                Avion a = (Avion)cb_avioni.SelectedItem;
                if(a != null)
                {
                    a.Brzina += Double.Parse(tb_brzina.Text);
                }

            };
        }

        private void bt_brzina_Click(object sender, EventArgs e)
        {
            //Ova procedura će se isto pozvati ali ne radi ništa
        }

        /* Ovo ide kroz kod
        private void button1_Click(object sender, EventArgs e)
        {
            Button butt = (Button)sender;
        }
        */

        //Idemo napisati generičku metodu Mbox, nije baš pametna
        void Mbox<T>( T obj)
        {
            MessageBox.Show(obj.ToString(), "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
