using Proje.Etkinlik.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Proje.Etkinlik.API.Controllers
{
    public class SahneController : ApiController
    {
        Proje_EtkinlikEntities entities = new Proje_EtkinlikEntities();

        [Route("sahne/add")]
        [HttpPost]
        public int Ekle(Data.Sahne obj)
        {
            entities.Sahne.Add(obj);
            int returnValue = entities.SaveChanges();
            return returnValue;
        }

        [Route("sahne/edit")]
        [HttpPut]
        public bool Duzenle(Data.Sahne obj)
        {
            var ent = entities.Sahne.Where(p => p.id == obj.id).FirstOrDefault();
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

        [Route("sahne/delete/{id}")]
        [HttpDelete]
        public string Sil(int id)
        {
            var silincekData = entities.Sahne.Where(p => p.id == id).FirstOrDefault();
            entities.Sahne.Remove(silincekData);
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
