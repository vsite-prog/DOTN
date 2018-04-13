using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje_7
{
    class Pas : ILjubimac //ovo ćem,o staviti na interface, IComparable<ILjubimac> //dva interface-a
    {
        decimal _cijena;
        public decimal Cijena
        {
            get
            {
                return _cijena;
            }
        }



        public Pas() {
            Pasmina = "Mješanac";
        }

        public string Ime { get; set; }

        //Imamo i svojstvo koje nije u Interface-u 
        public string Pasmina { get; set; }

        //Implementiramo interface metodu
        //Ovaj kod se ponavlja, bilo bi bolje u klasu koja se naslijeđuje ali sad učimo sučelja
        public void PostaviCijenu(decimal pCijena)
        {
            //Idemo implementirati metodu
            if (pCijena < 0 || pCijena > 10000)
                throw new ArgumentOutOfRangeException(); //Cijena nije u redu
            else
                _cijena = pCijena;
        }

        public string Ispisi()
        {
            return "Pas: " + Ime;
        }

        public int CompareTo(ILjubimac other)
        {
            //Usporedi ga s drugim ljubimcem
            return _cijena.CompareTo(other.Cijena);
        }
    }
}
