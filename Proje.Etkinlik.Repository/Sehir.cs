using Proje.Etkinlik.Data;
using System.Collections.Generic;
using System.Linq;

namespace Proje.Etkinlik.Repository
{
    public class Sehir
    {
        Proje_EtkinlikEntities entities = new Proje_EtkinlikEntities();

        public int Ekle(Data.Sehir obj)
        {
            entities.Sehir.Add(obj);
            int returnValue = entities.SaveChanges();
            return returnValue;
        }

        public void Duzenle(Data.Sehir obj)
        {
            var ent = entities.Sehir.Where(p => p.id ==  obj.id).FirstOrDefault();
            ent = obj;
            var sonuc = entities.SaveChanges();

        }
        public void Sil(int id)
        {
            var silincekData = entities.Sehir.Where(p => p.id == id).FirstOrDefault();
            entities.Sehir.Remove(silincekData);
            var sonuc = entities.SaveChanges();
        }
    }
}
