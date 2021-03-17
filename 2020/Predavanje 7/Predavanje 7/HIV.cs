using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje_7
{
    class HIV : IVirus
    {
        public HIV()
        {
            _naziv = "HIV Virus";
        }
        string _naziv;
        public string Naziv => _naziv;

        long _brojZarazenih;
        public long BrojZarazenih {
            get {
                return _brojZarazenih;
            }
        }

        public string Drzava { get; set; }

        public void PostaviBrojZarazenih(long broj)
        {
            if (broj < 0 || broj > 10000000)
            {
                throw new ArgumentOutOfRangeException();
            }
            _brojZarazenih = broj;
        }
        public int CompareTo(IVirus other)
        {
            return this._brojZarazenih.CompareTo(other.BrojZarazenih);  // Sve u jednoj liniji sa ugrađenom metodom
        }
    }
}
