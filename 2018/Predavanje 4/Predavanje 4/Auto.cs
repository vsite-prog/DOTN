using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje_4
{
    public class Auto : Vozilo
    {
        int _godiste;
        public int Godiste
        {
            get {
                return _godiste;
            }
            set
            {
                int year = DateTime.Now.Year; //trenutna godina
                if (value < year - 20 || value > year)
                    throw new Exception("Kriva godina");
                else
                    _godiste = value;
            }
        }

        public string Opis { get; set; }

        public override string ToString()
        {
            return String.Format("Tip: {0}, Opis: {1}", Tip, Opis); //Trebalo bi još 
        }

    }
}
