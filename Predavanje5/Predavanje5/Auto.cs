using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje5
{
    public class Auto:Prometalo
    {
        //Dodaj tip delegata
        public delegate void BoomEventHandler(object sender, EventArgs args);
        //Evo i događaj
        public event BoomEventHandler Boom;

        private double _brzina;
        public string Registracija {get;set;}
        public double Brzina {
            get { return _brzina; }
            set {
                if (value > 0 && value < 300)
                    _brzina = value;
                else
                    //Kada je brzina veća od 300 explodiraj
                    onBoom();
            }
        }
        //Procedura koja okida događaj
        public virtual void onBoom()
        {   
            //okini događaj samo ako ima registriranih delegata
            if (Boom != null)
                Boom(this, EventArgs.Empty);
        }
        //promijeni kod za neku vrijednost
        public void Ubrzaj(double delta)
        {
            Brzina += delta;
        }

    }
}
