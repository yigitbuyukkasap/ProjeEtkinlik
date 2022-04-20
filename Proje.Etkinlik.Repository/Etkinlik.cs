using Proje.Etkinlik.Data;
using System.Collections.Generic;
using System.Linq;

namespace Proje.Etkinlik.Repository
{
    public class Etkinlik
    {
        Proje_EtkinlikEntities entities = new Proje_EtkinlikEntities();

        public int Ekle(Data.Etkinlik obj)
        {
            entities.Etkinlik.Add(obj);
            int returnValue = entities.SaveChanges();
            return returnValue;
        }

        public void Duzenle(Data.Etkinlik obj)
        {
            var ent = entities.Etkinlik.Where(p => p.id ==  obj.id).FirstOrDefault();
            ent = obj;
            var sonuc = entities.SaveChanges();

        }
        public void Sil(int id)
        {
            var silincekData = entities.Etkinlik.Where(p => p.id == id).FirstOrDefault();
            entities.Etkinlik.Remove(silincekData);
            var sonuc = entities.SaveChanges();
        }
    }
}
