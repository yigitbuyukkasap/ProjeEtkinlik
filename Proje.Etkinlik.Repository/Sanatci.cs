using Proje.Etkinlik.Data;
using System.Collections.Generic;
using System.Linq;

namespace Proje.Etkinlik.Repository
{
    public class Sanatci
    {
        Proje_EtkinlikEntities entities = new Proje_EtkinlikEntities();

        public int Ekle(Data.Sanatci obj)
        {
            entities.Sanatci.Add(obj);
            int returnValue = entities.SaveChanges();
            return returnValue;
        }

        public void Duzenle(Data.Sanatci obj)
        {
            var ent = entities.Sanatci.Where(p => p.id ==  obj.id).FirstOrDefault();
            ent = obj;
            var sonuc = entities.SaveChanges();

        }
        public void Sil(int id)
        {
            var silincekData = entities.Sanatci.Where(p => p.id == id).FirstOrDefault();
            entities.Sanatci.Remove(silincekData);
            var sonuc = entities.SaveChanges();
        }
    }
}
