using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje_4
{
    abstract class Cjepivo // Ne možemo kreirati objekt iz nje
    {
        // Konstruktor
        public Cjepivo(string naziv)
        {
            this._naziv = naziv;
        }
        

        // Kreirao sam svojstvo i to read only
        string _naziv;
        public string Naziv { 
            get
            {
                return _naziv;
            }
        }

        // Samo unaprijed zadani proizvođači
        public Proizvodaci Proizvodac { get; set; }
    }

    // Enumeracija, lista proizvođača, obratite pažnju da smo u fileu od klase

    enum Proizvodaci
    {
        Astra_Zeneca,
        Pfizer = 100,
        Moderna = 200
    }
}
