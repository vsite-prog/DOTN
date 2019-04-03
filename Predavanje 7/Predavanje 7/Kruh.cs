﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje_7
{
    class Kruh : IArtikl
    {

        decimal _cijena;
        // Ovo je defaultni način prikaza u našoj klasi
        public string Naziv { get ; set; }

        public decimal Cijena => _cijena;

        // Ovo je tražio nekakav interface
        public void PostaviCijenu(decimal c)
        {
            if (c < 0 && c > 1000000)
            {
                throw new ArgumentOutOfRangeException(); // Cijena nije OK, pukni
            }
            else
            {
                _cijena = c;
            }
        }
        
        // Ovo nam je dao VS
        public int CompareTo(IArtikl other)
        {
            // Svi brojevni tipovi imaju ovu metodu
            return this.Cijena.CompareTo(other.Cijena);
        }

        // Ovo su dijelovi koji nemaju puno veze s Interface-om
        public double Tezina;
    }
}
