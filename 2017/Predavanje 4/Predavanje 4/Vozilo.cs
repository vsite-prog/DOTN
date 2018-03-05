using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje_4
{
    public class Vozilo
    {
        //Nećemo ovo koristiti kao polje, idemo sa svojstvom
        string _naziv;
        public string Naziv
        {
            get
            {
                return _naziv;
            }

            set
            {
                if (value == null || value.Length == 0) throw new Exception("Naziv ne može biti prazan");

                _naziv = value;
            }
        }
        public TipVozila Tip;
    }

    public enum TipVozila
    {
        Osobno = 12,
        Gospodarsko = 13,
        Vojno = 14
    }
}
