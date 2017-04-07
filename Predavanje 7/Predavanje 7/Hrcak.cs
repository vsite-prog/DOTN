using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje_7
{
    class Hrcak : IZoo
    {
        decimal _cijena;
        public decimal Cijena
        {
            get
            {
                return _cijena;
            }
        }

        public string Naziv
        {
            get; set;
        }


        public void PostaviCijenu(decimal cijena)
        {
            if (cijena > 0 && cijena < 500000)
            {
                _cijena = cijena;
            }
            else //cijena nije dobra, ispali grešku
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}

