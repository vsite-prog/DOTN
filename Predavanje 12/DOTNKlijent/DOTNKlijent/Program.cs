using System;
using PokerServis;

namespace DOTNKlijent
{
    class Program
    {
        static void Main(string[] args)
        {
            PokerClient client = new PokerClient();
            Karta karta = new Karta();
            karta.Boja = "Pik";
            karta.Broj = 1;
            bool odgovor = client.BaciKartuAsync(karta).Result;
            Console.WriteLine("Karta je prihvaćena? " + odgovor);

            for (int i=0; i< 10; i++)
            {
                karta = client.PrimiKartuAsync().Result;
                Console.WriteLine("Karta {0} {1}", karta.Broj, karta.Boja);
            }
        }
    }
}
