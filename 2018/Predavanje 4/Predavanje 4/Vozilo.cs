using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje_4
{
    public class Vozilo
    {
        //Ovo je stvarni podatak svojstva, private po default
        string _reg;

        //Sada svi ovo vide, idemo napraviti svojstvo
        public string Registracija
        {
            get
            {
                return _reg;
            }
            set
            {
                if (value.Length < 4 || value.Length> 15)
                { //Ovo je validacija
                    throw new Exception("Kriva regstr!");
                }else
                {
                    _reg = value;
                }
            }
        }

        public TipVozila Tip { get; set; } //Ovo je skraćeni način pisanja svojstava
    }

    //Idemo napraviti novi tip podataka, tzv.enumeraciju, možemo i bez brojeva
    public enum TipVozila
    {
        Automobil = 10,
        Kamion = 20,
        Avion = 30
    }
}
