using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Predavanje_7
{
    class Pas:IZoo
    {
        public Pas()
        {
            Sorta = "Retriver";
            Boja = Color.Yellow;
        }
        decimal _cijena;
        public string Naziv { get; set; }
        //Čitaj cijenu
        public decimal Cijena { get
            {
                return _cijena;
            }
        }

        //Ovo nije dio interface-a
        public string Sorta { get; set; }
        public Color Boja;

        //Ovo je dio interfejsa i nema bez ovoga
        public void PostaviCijenu(decimal cijena)
        {
            if(cijena > 0 && cijena < 100000)
            {
                _cijena = cijena;
            } else //cijena nije dobra, ispali grešku
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
