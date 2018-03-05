using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServis
{
    // Ovaj kod treba stvarno odraditi posao našeg servisa
    public class KarteServis : IKarte
    {
        List<Karta> stol = new List<Karta>();

        //Primam od klijenta kartu i spremam je u memoriju u listu
        public bool BacamKartu(Karta k)
        {
            try
            {
                stol.Add(k);
                return true;
            } catch(Exception ex)
            {
                return false;
            }

        }

        public Karta DajKartu()
        {
            //Idemo kreirati slučajnu boju i broj
            Random random = new Random();
            int broj = random.Next(1, 13);
            int brojZnak = random.Next(1, 4);
            string znak = "";
            //Prebazimo znak u string
            switch(brojZnak){
                case 1:
                    znak = "Hertz";
                    break;
                case 2:
                    znak = "Karo";
                    break;
                case 3:
                    znak = "Tref";
                    break;
                default:
                    znak = "Pik";
                    break;
            }

            Karta karta = new Karta();
            karta.Broj = broj;
            karta.Znak = znak;

            return karta;
        }
    }
}
