using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje_5
{
    class Auto : Vozilo
    {
        private double _brzina;
        private double _maxBrzina;
        public string Naziv { get; set; }

   
        //Okini događaj
        public event EventHandler boom;

        //Metoda okida događaj
        public virtual void onBoom()
        {
            if(boom != null) //
            {
                boom(this, EventArgs.Empty);
            }
        }

        public Auto()
        {
            _maxBrzina = 300;
        }

        public Auto(double v)
        {
            _maxBrzina = v;
        }

        public override string ToString()
        {
            return "Auto: " + this.Naziv + " " + this.Tip.ToString() + " brzina: " + this.Brzina.ToString();
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
                    onBoom(); //pozovi proceduru za okidanje

            }

        }
    }
}
