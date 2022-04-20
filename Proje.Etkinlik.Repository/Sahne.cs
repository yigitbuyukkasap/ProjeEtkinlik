using Proje.Etkinlik.Data;
using System.Collections.Generic;
using System.Linq;

namespace Proje.Etkinlik.Repository
{
    public class Sahne
    {
        Proje_EtkinlikEntities entities = new Proje_EtkinlikEntities();

        public int Ekle(Data.Sahne obj)
        {
            entities.Sahne.Add(obj);
            int returnValue = entities.SaveChanges();
            return returnValue;
        }

        public void Duzenle(Data.Sahne obj)
        {
            var ent = entities.Sahne.Where(p => p.id ==  obj.id).FirstOrDefault();
            ent = obj;
            var sonuc = entities.SaveChanges();

        }
        public void Sil(int id)
        {
            var silincekData = entities.Sahne.Where(p => p.id == id).FirstOrDefault();
            entities.Sahne.Remove(silincekData);
            var sonuc = entities.SaveChanges();
        }
    }
}
