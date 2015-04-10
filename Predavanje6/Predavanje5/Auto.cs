using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje5
{
    class Auto
    {
        public delegate void Explodiraj(double v);
        //Prebrzo sve eksplodiralo
        public event Explodiraj boom;

        public event EventHandler pozor; 
        //svojstvo brzine
        private double _brzina;
        public double Brzina { 
            get {return _brzina;}
            set {
                if (value < 0)
                {
                    _brzina = 0;
                }
                else if (value < 200)
                {
                    _brzina = value;
                }
                else if (value < 240)
                {
                    _brzina = value;
                    onPozor();
                }
                else
                {
                    onBoom(value);
                }
            
            }
        }

        //Okini događaj
        protected virtual void onBoom(double brzina)
        {
            if (boom != null) //Provjeri je li ima preplaćenih objekata
                boom(brzina);

        }

        //Okini događaj
        protected virtual void onPozor()
        {
            if (pozor != null) //Provjeri je li ima preplaćenih objekata
                pozor(this, EventArgs.Empty);

        }
    }
}
