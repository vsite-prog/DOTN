using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfClient.WcfPokerReference;

namespace WcfClient
{
    class Program
    {
        static void Main(string[] args)
        {
            PokerClient client = new PokerClient();
            for (int i = 0; i < 10; i++)
            {
                Karta karta = client.Uzimamkartu();
                Console.WriteLine("Primljena karta {0} {1}", karta.Boja, karta.Broj);
            }

            //Baci novu kartu na stol
            Karta k = new Karta();
            k.Boja = "Pik";
            k.Broj = 13;
            bool odgovor = client.BacamKartu(k); //U pozadini ide XML preko HTTP-a po SOAP standardu
            Console.WriteLine("Karta bačena? " + odgovor);
        }
    }
}
