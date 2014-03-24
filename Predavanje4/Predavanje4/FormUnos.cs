﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje4
{
    public partial class FormUnos : Form
    {
        public FormUnos()
        {
            InitializeComponent();
            cb_vlasnik.DataSource = Enum.GetValues(typeof(Vlasnistvo));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vlasnistvo vlasnik;
            //Dohvati iz Combo-a tip odabranog vlasnika
            Enum.TryParse<Vlasnistvo>(cb_vlasnik.SelectedValue.ToString(), out vlasnik);
            Auto a = new Auto();
            a.boja = Color.Red;
            a.vlasnik = vlasnik;
            a.Registracija = tb_reg.Text;
            a.Brzina = Double.Parse(tb_brzina.Text);
            int i = 1;


        }
    }
}