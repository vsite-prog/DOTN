using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje_6
{
    class Avion
    {

        public Avion(string n, double v)
        {
            Naziv = n;
            Brzina = v;
        }
        public event EventHandler Boooooom;

        public string Naziv { get; set; }

        double _brzina; // skribvena varijabla svojstva
        public double Brzina
        {
            get => _brzina; // Sintaksa slična labmdi za svojstva i metode
            set
            {
                // E sad ću da eksplodiram ako brzina nije u redu
                if( value > 1200 || value < 0)
                {
                    // Okinuti događaj
                    // Boooooom(this, EventArgs.Empty); ali ne ovako direktno
                    onBoooom(); // napisati ćemo sve isto ali sada jednostavnije 
                    Boooooom?.Invoke(this, EventArgs.Empty); // Drugi i bolji način dizanja događaja
                } else
                {
                    _brzina = value;
                }
            }
        }

        protected virtual void onBoooom()
        {
            if (Boooooom != null) // provjerava da li se iko prijavio ne njega
            {
                Boooooom(this, EventArgs.Empty);
            }
        }

        public override string ToString() // sa override K.riječi nema problema
        {
            return String.Format("Avion: {0}, brzina: {1}", this.Naziv, Brzina);
        }
    }
}
