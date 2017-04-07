using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje_7
{
    interface IZoo
    {
        //Ovo je našinterface i reći će što je zajedničko svima
        // a neće ništa implementirati
        string Naziv { get; set; }
        decimal Cijena { get; }

        void PostaviCijenu(decimal cijena);
    }
}
