using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje_5
{
    // Kada eksplodira onda se izvrši ovakva nekakva funkcija
    public delegate void CrushDelegate(double v);
    class Raketa
    {
        double _brzina;
        public string Tip { get; set; }
        public double Brzina {
            get
            {
                return _brzina;
            }
            set
            {
                if (value > MaxBrzina)
                {
                    // Crash event
                    if (Crash != null) {
                        Crash(value);
                    } 
                } else
                {
                    _brzina = value;
                }
            }
                
        }
        // Najviša dozvoljena
        public double MaxBrzina { get; set; }

        // Događaj kreša
        public event CrushDelegate Crash;
    }
}
