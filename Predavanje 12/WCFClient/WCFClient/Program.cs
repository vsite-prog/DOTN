using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFClient.KarteReference;

namespace WCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WCF klijent te pozdravlja");
            //Kreirati ćemo novi klijent i spojiti se na servis
            using(KarteClient klijent = new KarteClient())
            {
                for(int i = 0; i < 5; i++)
                {
                    //Ovo bi ljepše asinhrono
                    Karta k = klijent.DajKartu();
                    Console.WriteLine("Karta je {0} {1}", k.Broj, k.Znak);
                }

                Karta karta = new Karta();
                karta.Broj = 9;
                karta.Znak = "Pik";

                //sad baci na stol, ide XML prema servisu
                bool odgovor = klijent.BacamKartu(karta);
                Console.WriteLine("Odgovor je {0}", odgovor);
            }
        }
    }
}
