//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proje.Etkinlik.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mekan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mekan()
        {
            this.Etkinlik = new HashSet<Etkinlik>();
            this.Sahne = new HashSet<Sahne>();
        }
    
        public int id { get; set; }
        public string MekanAd { get; set; }
        public string MekanKonum { get; set; }
        public string MekanFoto { get; set; }
        public Nullable<int> MekanSehir { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Etkinlik> Etkinlik { get; set; }
        public virtual Sehir Sehir { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sahne> Sahne { get; set; }
    }
}
