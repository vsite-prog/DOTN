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
    
    public partial class Riba
    {
        public int ribaId { get; set; }
        public string naziv { get; set; }
        public Nullable<int> vrstaId { get; set; }
    
        public virtual Vrsta Vrsta { get; set; }
    }
}
