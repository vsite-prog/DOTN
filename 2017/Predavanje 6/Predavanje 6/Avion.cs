using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje_6
{
    //Tip delegata, nećemo ga koristiti
    //public delegate void IspisDelegate(string txt);
    public class Avion
    {
        //Tip funkcije koja reagira događaj
        //public delegate void EventDelegate(double v); ne treba
        //Ovo je event emitter definiraj događaj
        public event EventHandler Crash;

        public Avion(string naziv, double brzina)
        {
            Naziv = naziv;
            this.Brzina = brzina;
        }
        double _v;
        public string Naziv
        {
            get;
            set;
        }
        public double Brzina
        {
            get { return _v; }

            set
            {
                if (value < 0 || value > 1200){
                    //okini događaj
                    onCrash(); //ovo je funkcija koja će okinuti događaj
                } else {
                    _v = value;
                }
            }
        }

        //ja okidam događaj, virtual metoda da se slučajno ne bi pregazila
        protected virtual void onCrash ()
        {
            //Provjeri da li je itko se pretplatio na događaj
            if (Crash != null){
                Crash(this, EventArgs.Empty);
            }
        }

        //Pregazimo standardnu metodu to string
        public override string ToString()
        {
            return "Avion: " + Naziv;
        }

    }
}
