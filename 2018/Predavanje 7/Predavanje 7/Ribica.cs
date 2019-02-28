using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje_7
{
    class Ribica : ILjubimac
    {
        decimal _cijena;
        //Get property napisan pomoću lambde kao i kod Psa (nije baš prava lambda)
        public decimal Cijena => _cijena;

        public string Ime { get; set; }

        public void PostaviCijenu(decimal pCijena)
        {
            //Idemo implementirati metodu
            if (_cijena < 0 || _cijena > 10000)
                throw new ArgumentOutOfRangeException(); //Cijena nije u redu
            else
                _cijena = pCijena;
        }
        
        public string Ispisi()
        {
            return "Ribica: " + Ime;
        }

        public int CompareTo(ILjubimac other)
        {
            //Usporedi ga s drugim ljubimcem
            return _cijena.CompareTo(other.Cijena);
        }
    }
}
