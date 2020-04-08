using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje_7
{
    interface IVirus:IComparable<IVirus> // Moguće je da jedan interface, implementira drugi
    {
        // Idemo kazati stvari koje mora imati svaki Virus
        string Naziv { get; }
        long BrojZarazenih { get; }

        // nema implementacije metode
        void PostaviBrojZarazenih(long broj);

        string Drzava { get; set; }

    }
}
