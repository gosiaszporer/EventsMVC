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
    
    public partial class TIN_Wydarzenie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIN_Wydarzenie()
        {
            this.TIN_Opinia = new HashSet<TIN_Opinia>();
            this.TIN_Tagi = new HashSet<TIN_Tagi>();
        }
    
        public string Nazwa { get; set; }
        public int WiekOd { get; set; }
        public Nullable<int> WiekDo { get; set; }
        public decimal Cena { get; set; }
        public System.DateTime DataOd { get; set; }
        public Nullable<System.DateTime> DataDo { get; set; }
        public string Adres { get; set; }
        public string Organizator { get; set; }
        public decimal TIN_Wydarzenie_ID { get; set; }
        public decimal TIN_Kategoria_TIN_Kategoria_ID { get; set; }
    
        public virtual TIN_Kategoria TIN_Kategoria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TIN_Opinia> TIN_Opinia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TIN_Tagi> TIN_Tagi { get; set; }
    }
}
