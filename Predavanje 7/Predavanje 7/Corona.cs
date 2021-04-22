﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje_7
{
    class Corona : IVirus
    {
        public Corona()
        {
            Naziv = "Corona";
        }
        public string Naziv { get; }

        public string Mutacija { get; set; }

        long _novoZarazeni;
        public long NovoZarazeni
        {
            get => _novoZarazeni;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Negativan broj");
                }
                else
                {
                    _novoZarazeni = value;
                }
            }

        }

   
        public long UkupnoZarazeni { get; set; }

        public DateTime Datum { get; set; }

        public void EvidentirajZarazene(long novi, DateTime ?datum)
        {
            NovoZarazeni = novi;
            UkupnoZarazeni += novi;
            Datum = datum ?? DateTime.Now.Date;
        }

        public override string ToString()
        {
            return $"{Naziv}-{Mutacija}, novo zaraženi: {NovoZarazeni}, ukupno zaraženi: {UkupnoZarazeni} {Datum.ToShortDateString()}";
        }

        public int CompareTo(IVirus other)
        {
            return Datum.CompareTo(other.Datum);
        }
    }
}
