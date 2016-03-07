using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje4
{
    public class Lav :Zivotinja
    {
        public Lav()
        {
            this.Vrsta = Vrsta.Sisavac;
        }

        public double Tezina {get;set;}
        public double Brzina { get; set; }

        public override string ToString(){
            return "Lav:" + this.Ime + " težina: " + this.Tezina.ToString();
        }
    }
}
