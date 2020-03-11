using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje_7
{
    interface IArtikl: IComparable<IArtikl>
    {
        // Obično svojstvo
        string Naziv { get; set; }
        // Read only 
        decimal Cijena { get; }
        // Obično su bitnije metode
        void PostaviCijenu(decimal c);
    }
}
