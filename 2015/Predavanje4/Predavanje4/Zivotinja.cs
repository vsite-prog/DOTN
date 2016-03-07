using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje4
{
    //Lista predefiniranih vrijednosti
    public enum ZOO 
    {
        Berlin= 10,
        Zagreb = 20,
        London = 30
    }

    public enum Vrsta
    {
       Sisavac,
       Ptica,
       Riba
    }
    public abstract class Zivotinja
    {
        private string _ime;
        public string Ime
        {
            get { return _ime; }
            set { _ime = value; }
        }

        public ZOO Zoo { get; set; }

        public Vrsta Vrsta { get; set; }
    }
}
