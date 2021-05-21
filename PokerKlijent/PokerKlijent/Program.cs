using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokerKlijent.PokerServis;

namespace PokerKlijent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dobar dan!");
            Karta karta = new Karta();
            karta.Boja = "Pik";
            karta.Broj = 12;
            // Baci kartu na stol u našem servisu
            PokerClient klijent = new PokerClient();
            bool result = klijent.BaciKartu(karta);
            string poruka = result ? $" Karta bačena {karta.Boja} {karta.Broj}" : "Došlo je do greške";
            Console.WriteLine(poruka);
            karta = klijent.UzmiKartuAsync().Result; // Izvršavamo asinkrono da ne blokiramo bezveze
            Console.WriteLine($" Karta primljena {karta.Boja} {karta.Broj}");
            klijent.BaciKartu(karta); // Baci primljenu kartu
            // Daj mi sve karte na stolu
            Karta[] bacene = klijent.dajSveNaStoluAsync().Result;
            for (int i=0; i < bacene.Length; i++)
            {
                Console.WriteLine($" Karta na stolu {bacene[i].Boja} {bacene[i].Broj}");
            }
        }
    }
}
