using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeEtkinlik.Models
{
    public class Mekan
    {
        public int Id { get; set; }
        public string MekanAd{ get; set; }
        public string MekanKonum{ get; set; }
        public string MekanFotoUrl{ get; set; }
        public string MekanSehir{ get; set; }

    }
}
