using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PokerServis
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class PokerServis : IPoker
    {
        static List<Karta> stol = new List<Karta>(); // Static nije najbolji način ali za test jer inače svaki zahtjev je ponovo prazan
        static List<Karta> spil = new List<Karta>(); // spil iz kog dijelimo karte
        string[] boje = { "Srce", "Karo", "Tref", "Pik" };
        public bool BaciKartu(Karta karta)
        {
            if (karta == null || karta.Broj < 1 || karta.Broj > 13 || !boje.Contains(karta.Boja) )
            {
                // throw new ArgumentException("Kriva karta");
                // Nećemo bacati exception jer to traži neko drugi nego ćemo vratiti grešku
                // Mogli bi logirati
                return false;
            }
            
            stol.Add(karta);

            return true;
        }

        public List<Karta> dajSveNaStolu()
        {
            return stol;
        }

        public Karta UzmiKartu()
        {
            // Bilo bi bolje vući iz špila
            Karta karta = new Karta();
            // Generiraj slučajni broj za kartu
            // Random generator
            Random generator = new Random(DateTime.Now.Millisecond);
            int broj = generator.Next(1, 14);
            generator = new Random(DateTime.Now.Millisecond); // Idemo ponovo iznova
            int bojaBroj = generator.Next(1, 5);
            karta.Broj = broj;
            karta.Boja = boje[--bojaBroj]; // Neka bude 0-3
            spil.Add(karta);
            return karta;
        }
    }
}
