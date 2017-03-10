using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje_7
{
    class Pas : ILjubimac, IComparable<Pas>
    {
        decimal _cijena;
        public string Naziv
        {
            get;
            set;
        }

        public string Opis
        {
            get;
            set;
        }

        public int CompareTo(Pas other)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(ILjubimac other)
        {
            return _cijena.CompareTo(other.DajCijenu());
        }

        public decimal DajCijenu()
        {
            return _cijena;
        }

        public void PostaviCijenu(decimal c)
        {
            if (_cijena >= 0)
            {
                _cijena = c;
            } else
            { //Neki kod bi morao sada ovo uhvatiti
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
