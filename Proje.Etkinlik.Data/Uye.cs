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
    
    public partial class Uye
    {
        public int id { get; set; }
        public string AdSoyad { get; set; }
        public Nullable<int> SehirId { get; set; }
        public string Telefon { get; set; }
        public Nullable<int> Yas { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
        public string Yetki { get; set; }
    
        public virtual Sehir Sehir { get; set; }
    }
}
