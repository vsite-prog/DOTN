using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje_7
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<IVirus> virusi = new List<IVirus>();
            cb_tip.DataSource = new List<string>(){ "Corona", "Gripa"};

            bt_spremi.Click += (o, a) =>
            {
                IVirus virus = null;

                switch (cb_tip.SelectedItem.ToString())
                {
                    case "Corona":
                        Corona corona = new Corona(); // IVurus as Corona
                        corona.Mutacija = "Britanski soj";
                        virus = corona;
                        break;
                    case "Gripa":
                        virus = new Gripa();
                        break;
                    //...
                }
                virus.EvidentirajZarazene(Int64.Parse(tb_broj.Text), calendar.SelectionStart.Date);
                virusi.Add(virus);
                virusi.Sort();
                lb_svi_virus.Text = "Evidencija:";
                foreach (IVirus v in virusi)
                {
                    lb_svi_virus.Text += "\n" + v;
                }
                
            };
        }

  
    }
}
