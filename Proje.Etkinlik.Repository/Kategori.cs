using Proje.Etkinlik.Data;
using System.Linq;

namespace Proje.Etkinlik.Repository
{
    public class Kategori
    {
        Proje_EtkinlikEntities entities = new Proje_EtkinlikEntities();

        public int Ekle(Data.Kategori obj)
        {
            entities.Kategori.Add(obj);
            int returnValue = entities.SaveChanges();
            return returnValue;
        }

        public void Duzenle(Data.Kategori obj)
        {
            var ent = entities.Kategori.Where(p => p.id ==  obj.id).FirstOrDefault();
            ent = obj;
            var sonuc = entities.SaveChanges();

        }
        public void Sil(int id)
        {
            var silincekData = entities.Kategori.Where(p => p.id == id).FirstOrDefault();
            entities.Kategori.Remove(silincekData);
            var sonuc = entities.SaveChanges();
        }
    }
}
