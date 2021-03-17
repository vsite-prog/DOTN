using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje4
{
    class Virus
    {
        // Konstruktor
        public Virus(string name)
        {
            this.Name = name; // Može i bez this, to je default kontekst
        }
        public string Name
        {
            get;
            // set; sada sam indirekto pretvorio u read only varijablu
        }

        // Pratimo zemlju u kojoj je došlo do pojave virusa
        public Zemlja Zemlja;
    }

    // Drugi tip podataka, nabrajanje 
    enum Zemlja
    {
        Kina,
        Italija = 10, // Nije ni bitno koji je broj ali evo
        Iran = 20,
        Koreja = 30
    }
}
