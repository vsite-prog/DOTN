using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje_5
{
    class Toalet
    {
        // Želimo novi događaj i treba nam za početak delegat
        public delegate void NestaloDelegat(string s);

        // Neka to bude događaj Nestalo i Zamalo Nestalo
        public event NestaloDelegat Nestalo;
        public event NestaloDelegat ZamaloNestalo;

        public string Naziv { get; set; }

        double _kolicina;
        // Kod postaljanja količine pazi da li je stanje palo ispod nivoa
        public double Kolicina
        {
            get
            {
                return _kolicina;
            }

            set
            {
                if(value < 30)
                {
                    // Okini događaj Zamalo nestalo
                    _kolicina = value;
                    ZamaloNestalo(_kolicina.ToString());
                } 
                else if(value < 0)
                {
                    Nestalo("0");
                    _kolicina = 0;
                }
                else
                {
                    _kolicina = value;
                }

            }
        }

        // Metoda ispisa, ona će dati tekst za ispis ali pozivatelj bira kako će se to desiti
        public void Ispis(Form1.IspisDelegat del)
        {
            string zaIspis = $"Naziv: {Naziv}, Količina na lageru: {Kolicina}";
            // Pozovi injektiranu funkciju
            del(zaIspis);
        }

    }
}
