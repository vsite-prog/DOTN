//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Predavanje7
{
    using System;
    using System.Collections.Generic;
    
    public partial class studij
    {
        public studij()
        {
            this.student = new HashSet<student>();
        }
    
        public int id { get; set; }
        public string sifra { get; set; }
        public string opis { get; set; }
    
        public virtual ICollection<student> student { get; set; }
    }
}
