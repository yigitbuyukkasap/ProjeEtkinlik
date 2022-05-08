using Proje.Etkinlik.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Proje.Etkinlik.API.Controllers
{
    public class MenuController : ApiController
    {
        Proje_EtkinlikEntities entities = new Proje_EtkinlikEntities();

        [Route("menu/add")]
        [HttpPost]
        public int Ekle(Data.Menu obj)
        {
            entities.Menu.Add(obj);
            int returnValue = entities.SaveChanges();
            return returnValue;
        }

        [Route("menu/edit")]
        [HttpPut]
        public bool Duzenle(Data.Menu obj)
        {
            var ent = entities.Menu.Where(p => p.id == obj.id).FirstOrDefault();
            ent = obj;
            var sonuc = entities.SaveChanges();
            if (sonuc == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [Route("menu/delete/{id}")]
        [HttpDelete]
        public string Sil(int id)
        {
            var silincekData = entities.Menu.Where(p => p.id == id).FirstOrDefault();
            entities.Menu.Remove(silincekData);
            var sonuc = entities.SaveChanges();
            if (sonuc == 1)
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }

    }
}
