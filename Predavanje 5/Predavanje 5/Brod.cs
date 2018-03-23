using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje_5
{
    //Ovo je delegat koji definira tip funkcije koja se zove kad se desi događaj
    public delegate void PotopDelegat(string txt);
    class Brod
    {
       double _ukrcano;
       //Ovdje smo definirali naš događaj 
       public event PotopDelegat Potop;
       public string Naziv { get; set; }
       public double Nosivost {
            get;set;
        } //Max težina tereta
       public double Ukrcano
        {
            get
            {
                return _ukrcano;
            }
            set
            {
                //Vidi da li je prekoračeno
                if (value <= Nosivost)
                    _ukrcano = value;
                else //Ovo nije idealno zbog exception-a, objašnjenje ...
                    Potop(Naziv + ": potoopljen prekoračena nosivost: " + value.ToString());
            }
        }//Ukrcana težina tereta

        public Brod(string pNaziv, double pNosivost)
        {
            Naziv = pNaziv;
            Nosivost = pNosivost;
        }

    }
}
