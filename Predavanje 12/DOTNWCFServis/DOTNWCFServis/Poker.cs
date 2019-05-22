using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DOTNWCFServis
{
    // Ovo je u biti poker stol koji dijeli karte  i na koji bacamo karta
    public class Poker : IPoker
    {
        List<Karta> karteNaStolu = new List<Karta>();

        // Primi kartu na stol
        public bool BaciKartu(Karta karta)
        {
            // Malo validacije, nije kompletna
            if(karta.Broj < 1 || karta.Broj > 13 || karta.Boja == null)
            {
                // Trebalo bi ovdje logirati grešku
                return false;
            }
            karteNaStolu.Add(karta);
            return true;
        }

       
        // Vraćamo kartu korisniku
        public Karta PrimiKartu()
        {
            // Kreirajmo slučajnu kartu kao da je vučemo iz špila
            Random generator = new Random();
            int broj = generator.Next(1, 14); // Ovo će biti broj, 1 do 13
            // Novi generator bi trebao dati novi broj za boju (1-4)
            generator = new Random(DateTime.Now.Millisecond); //  Dajem mu početnu vrijednost da mi generira svaki put drugi broj
            int brojBoje = generator.Next(1, 5);
            string boja;
            switch (brojBoje)
            {
                case 1:
                    boja = "Pik";
                    break;
                case 2:
                    boja = "Karo";
                    break;
                case 3:
                    boja = "Tref";
                    break;
                default:
                    boja = "Srce";
                    break;
            }


            // Slučajna karta
            Karta karta = new Karta();
            karta.Broj = broj;
            karta.Boja = boja;

            return karta;

        }
    }
}
