using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje_5
{
    //Tip delegata
    public delegate void IspisDelegate(string txt);
    public class Avion
    {
        //Tip funkcije koja reagira događaj
        public delegate void EventDelegate(double v);
        //Ovo je event emitter definiraj događaj
        public event EventDelegate crash;

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
                    onCrash(value); //ovo je funkcija koja će okinuti događaj
                } else {
                    _v = value;
                }
            }
        }

        //ja okidam događaj
        void onCrash (double v)
        {
            //Provjeri da li je itko se pretplatio na događaj
            if (crash != null){
                crash(v);
            }
        }

        //Definirati funkciju koja ispisuje a nema pojma kako
        public void Ispisi (IspisDelegate f)
        {
            string txt = "Avion: " + Naziv + " brzina: " + Brzina.ToString();
            f(txt);
        }
    }
}
