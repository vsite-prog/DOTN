using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Predavanje4
{
    public enum Vlasnistvo
    {
        Privatno,
        Tvrtka,
        Drzava
    }
    public abstract class Prometalo
    {
        public Color boja;
        public Vlasnistvo vlasnik;
        public string Sifra { get; set; }
    }
}
