//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EventsMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TIN_Opinia
    {
        public decimal TIN_Opinia_ID { get; set; }
        public string Tresc { get; set; }
        public decimal TIN_Wydarzenie_TIN_Wydarzenie_ID { get; set; }
    
        public virtual TIN_Wydarzenie TIN_Wydarzenie { get; set; }
    }
}
