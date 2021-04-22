using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje_7
{
    interface IVirus:IComparable<IVirus>
    {
        string Naziv { get;  }

        long NovoZarazeni { get; }

        long UkupnoZarazeni { get; }

        DateTime Datum { get; }

        void EvidentirajZarazene(long novi, DateTime ?datum);
    }
}
