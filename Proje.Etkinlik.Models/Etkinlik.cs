using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeEtkinlik.Models
{
    public class Etkinlik
    {
        public int Id { get; set; }
        public Mekan MekanId{ get; set; }
        public AltKategori AltKategori{ get; set; }
        public string Tarih{ get; set; }
        public string Aciklama{ get; set; }
        public Sanatci SanatciId{ get; set; }

    }
}
