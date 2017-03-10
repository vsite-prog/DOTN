using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFClient.Diler;

namespace WCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kreiraj proxi objekt koji predstavlja udaljeni servis i radi s njim
            using (DilerClient client = new DilerClient())
            {
                // import namespace prije
                Karta k = new Karta();
                k.Broj = 10;
                k.Tip = "pik";

                Console.WriteLine(client.PrimiKartu(k));
                //Sad pokupi kartu
                Karta karta = client.DijeliKartu();
                Console.WriteLine("Karta " + karta.Broj + " " + karta.Tip);

            }
               
        }
    }
}
