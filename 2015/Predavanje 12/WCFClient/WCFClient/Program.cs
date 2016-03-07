using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFClient.DijeliServis;

namespace WCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            DijeliClient klijent = new DijeliClient();
            Karta karta = klijent.DajKartu();
            Console.WriteLine(karta.Tip + " " + karta.Broj.ToString());

            Karta k = new Karta();
            k.Broj = 10;
            k.Tip = "tref";
            klijent.PrimiKartu(k);


            klijent.Close();
        }
    }
}
