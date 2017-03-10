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

        //Definiraj procedure koje će odgovarati na boom događaj
        public delegate void BoomDelegat(double brzina);
        //Okini događaj
        public event BoomDelegat boom;

        //Metoda okida događaj
        public virtual void onBoom(double b)
        {
            if(boom != null)
            {
                boom(b);
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
                    onBoom(value); //pozovi proceduru za okidanje

            }

        }
    }
}
