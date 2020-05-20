using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KazinoKlijent2.KazinoServis;

namespace KazinoKlijent2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pozdrav iz konzole!");
            // Idemo se spojiti na servis, imamo generirani proxi0 , Broj {1}
            KazinoClient klijent = new KazinoClient();
            for (int i = 0; i < 10; i++)
            {
                Karta k = klijent.DijeliKartu(); // POvezujemo se na SOAP servis
                Console.WriteLine("Boja {0}, Broj {1}", k.Boja, k.Broj);

                bool odgovor = klijent.BacamKartu(k);
                Console.WriteLine("Da li je uspjelo bacanje karte: {0}", odgovor);
            }

            // Idemo vidjeti sve bačene karte i to radimo asinhrono
            Karta[] baceneKarte = klijent.SveBaceneKarteAsync().Result;
            foreach (Karta k in baceneKarte)
            {
                Console.WriteLine("Bačena karta: Boja {0}, Broj {1}", k.Boja, k.Broj);
            }
        }
    }
}
