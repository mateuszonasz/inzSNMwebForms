//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace inzSNMWebForms.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kategoria
    {
        public Kategoria()
        {
            this.Dzieło = new HashSet<Dzieło>();
        }
    
        public int Id_Kat { get; set; }
        public string Kategoria1 { get; set; }
    
        public virtual ICollection<Dzieło> Dzieło { get; set; }
    }
}
