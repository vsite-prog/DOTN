using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje_7
{
    class Macka:ILjubimac
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

        public System.Drawing.Color BojaDlake { get; set; }  //Ovo nije u interface-u 

        public decimal DajCijenu()
        {
            return _cijena;
        }

        public void PostaviCijenu(decimal c)
        {
            if (_cijena >= 0)
            {
                _cijena = c;
            }
            else
            { //Neki kod bi morao sada ovo uhvatiti
                throw new ArgumentOutOfRangeException();
            }
        }

        public int CompareTo(ILjubimac other)
        {
            return _cijena.CompareTo(other.DajCijenu());
        }
    }
}

