using Proje.Etkinlik.Data;
using System.Collections.Generic;
using System.Linq;

namespace Proje.Etkinlik.Repository
{
    public class Mekan
    {
        Proje_EtkinlikEntities entities = new Proje_EtkinlikEntities();

        public int Ekle(Data.Mekan obj)
        {
            entities.Mekan.Add(obj);
            int returnValue = entities.SaveChanges();
            return returnValue;
        }

        public void Duzenle(Data.Mekan obj)
        {
            var ent = entities.Mekan.Where(p => p.id ==  obj.id).FirstOrDefault();
            ent = obj;
            var sonuc = entities.SaveChanges();

        }
        public void Sil(int id)
        {
            var silincekData = entities.Mekan.Where(p => p.id == id).FirstOrDefault();
            entities.Mekan.Remove(silincekData);
            var sonuc = entities.SaveChanges();
        }
    }
}
