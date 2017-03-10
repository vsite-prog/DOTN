using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje_4
{
    class Auto:Vozilo
    {
        private double _brzina;
        private double _maxBrzina;
        public string Naziv { get; set; }

        public Auto()
        {
            _maxBrzina = 300;
        }

        public Auto(double v)
        {
            _maxBrzina = v;
        }


        public double Brzina
        {
            get
            {
                return _brzina;
            }

            set
            {
                if (value > 0 && value < _maxBrzina)
                    _brzina = value;
                else
                    MessageBox.Show("Kriva brzina...");

            }

        }
    }
}
