using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje6
{
    public class Auto:Prometalo
    {
        //Dodaj tip delegata
        public delegate void AutoEventHandler(object sender, EventArgs args);
        //Evo i događaj
        public event AutoEventHandler Boom;
        //Evo i lambda događaja
        public event AutoEventHandler Pozor;

        private double _brzina;
        public string Registracija {get;set;}
        public double Brzina {
            get { return _brzina; }
            set {
                if (value > 0 && value < 0.85 * 300)
                    _brzina = value;
                else if (value > 0.85 * 300 && value <  300)
                {
                    //postavi ga ali okini događaj
                    _brzina = value;
                    onPozor();
                }
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

        //Procedura koja okida događaj, pregrijavanje automobila
        public virtual void onPozor()
        {
            //okini događaj samo ako ima registriranih delegata
            if (Pozor != null)
                Pozor(this, EventArgs.Empty);
        }
        //promijeni kod za neku vrijednost
        public void Ubrzaj(double delta)
        {
            Brzina += delta;
        }

    }
}
