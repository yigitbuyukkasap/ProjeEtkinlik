using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeEtkinlik.Models
{
    public class AltKategori
    {
        public int Id { get; set; }
        public Kategori KategoriId{ get; set; }
        public string AltKategoriAd { get; set; }

    }
}
