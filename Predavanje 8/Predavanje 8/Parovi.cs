//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Predavanje_8
{
    using System;
    using System.Collections.Generic;
    
    public partial class Parovi
    {
        public int id { get; set; }
        public string naziv { get; set; }
        public double koeficijent { get; set; }
        public Nullable<int> klad_id { get; set; }
    
        public virtual Kladionica Kladionica { get; set; }
    }
}
