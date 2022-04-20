using Proje.Etkinlik.Data;
using System.Collections.Generic;
using System.Linq;

namespace Proje.Etkinlik.Repository
{
    public class AltKategori
    {
        Proje_EtkinlikEntities entities = new Proje_EtkinlikEntities();

        public int Ekle(Data.AltKategori obj)
        {
            entities.AltKategori.Add(obj);
            int returnValue = entities.SaveChanges();
            return returnValue;
        }

        public void Duzenle(Data.AltKategori obj)
        {
            var ent = entities.AltKategori.Where(p => p.id ==  obj.id).FirstOrDefault();
            ent = obj;
            var sonuc = entities.SaveChanges();

        }
        public void Sil(int id)
        {
            var silincekData = entities.AltKategori.Where(p => p.id == id).FirstOrDefault();
            entities.AltKategori.Remove(silincekData);
            var sonuc = entities.SaveChanges();
        }
    }
}
