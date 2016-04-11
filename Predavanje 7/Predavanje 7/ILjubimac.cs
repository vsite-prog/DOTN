using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje_7
{
    interface ILjubimac
    {
        //Kaži što ima svaki član petshopa
        string Naziv { get; set; }
        string Opis { get; set; }

        decimal DajCijenu();

        void PostaviCijenu(Decimal c);


    }
}
