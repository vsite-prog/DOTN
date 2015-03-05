using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje4
{
    public class Auto:Prometalo
    {
        private double _brzina;
        public string Registracija {get;set;}
        public double Brzina {
            get { return _brzina; }
            set {
                if (value > 0 && value < 300)
                    _brzina = value;
                else
                    //Malo ružno ljepše bi bio exception...
                    MessageBox.Show("Brzina nije u intervalu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //promijeni kod za neku vrijednost
        public void Ubrzaj(double delta)
        {
            Brzina += delta;
        }

    }
}
