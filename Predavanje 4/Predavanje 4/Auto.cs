using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje_4
{
    public class Auto:Vozilo
    {
        decimal _cijena;
        public decimal Cijena
        {
            get
            {
                return _cijena;
            }
            set
            {
                if (value <= 0) throw new Exception("Cijena mora biti veća od 0");
                _cijena = value;
            }
        }

        //skraćeni način pisanja svojstva
        public int Godiste { get; set; }

        public override string ToString()
        {
            return "Naziv: " + Naziv + " tip: " + Enum.GetName(Tip.GetType(), Tip) + " cijena:  " + Cijena.ToString() + " godište: " + Godiste.ToString();
        }
    }
}
