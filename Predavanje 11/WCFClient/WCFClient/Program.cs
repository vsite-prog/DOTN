using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFClient.WcfNasPrimjer;

namespace WCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //Spoji se na servis
            RibarnicaClient client = new RibarnicaClient();

            //Kreiraj podatak tipa riba
            Riba r = new Riba();
            r.Naziv = "Brancin";
            r.Kolicina = 100.34;
            //spremi 
            client.DodajRibu(r);

            //Kreiraj podatak tipa riba
            r = new Riba();
            r.Naziv = "Tuna";
            r.Kolicina = 10.34;
            //spremi 
            client.DodajRibu(r);

            Riba[] sve = client.DajSveRibe();
            foreach (Riba rib in sve)
                Console.WriteLine(rib.Naziv + ": " + rib.Kolicina.ToString());

            //zatvori klijent
            client.Close();

        }
    }
}
