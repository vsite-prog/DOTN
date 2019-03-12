using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje_4
{
    class Ribarica : Plovilo
    {
        public string Registracija { get; set; }
        public string Naziv { get; set; }
        public double MaksUlov { get; set; }

        public override string ToString()
        {
            return String.Format("Jedrilica {0}, Tip: {1}", this.Naziv, this.Tip.ToString());
        }
    }
}
