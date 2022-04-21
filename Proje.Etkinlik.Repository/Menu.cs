using Proje.Etkinlik.Data;
using System.Collections.Generic;
using System.Linq;

namespace Proje.Etkinlik.Repository
{
    public class Menu
    {
        Proje_EtkinlikEntities entities = new Proje_EtkinlikEntities();

        public IList<Menu> GetByRole(string role)
        {
            return (IList<Menu>)entities.Menu.Where(m => m.Yetki == role);
        }

        public int Ekle(Data.Menu obj)
        {
            entities.Menu.Add(obj);
            int returnValue = entities.SaveChanges();
            return returnValue;
        }

        public void Duzenle(Data.Menu obj)
        {
            var ent = entities.Menu.Where(p => p.id ==  obj.id).FirstOrDefault();
            ent = obj;
            var sonuc = entities.SaveChanges();

        }
        public void Sil(int id)
        {
            var silincekData = entities.Menu.Where(p => p.id == id).FirstOrDefault();
            entities.Menu.Remove(silincekData);
            var sonuc = entities.SaveChanges();
        }
    }
}
