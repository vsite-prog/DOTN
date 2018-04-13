using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje_7
{
    interface ILjubimac :IComparable<ILjubimac> //Naslijeđujem drugi interface
    {
        //Svi moraju imati ovaj prop.
        decimal Cijena { get; }
        //i ovu metodu
        void PostaviCijenu(decimal pCijena);

        //I ovo
        string Ime { get; set; }

        //Za ispis
        string Ispisi();
    }
}
