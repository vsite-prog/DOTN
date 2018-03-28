using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje_6
{
    class Avion
    {

        double _brzina; //Ovdje jepravi podatak
        //Idemo definiratinaš događaj
        public event EventHandler Paaadam;
        public string Naziv { get; set; }
        public double Brzina {
            get => _brzina; //Defaultni get
            set
            {
                if(value > 1000 || value < 0) //Brzina nije OK
                {
                    //Pukni događaj
                    onPaaadam();
                    //Kraći način
                    Paaadam?.Invoke(this, EventArgs.Empty);
                }else
                {
                    _brzina = value;
                }
            }
        }

        //Nije pametne puknuti događaj direktno
        protected virtual void onPaaadam()
        {
            Paaadam(this, EventArgs.Empty); //nema nikakvih podataka
        }

        //Evo ovako se gazi virtualna metoda
        public override string ToString()
        {
            return Naziv;
        }
    }
}
