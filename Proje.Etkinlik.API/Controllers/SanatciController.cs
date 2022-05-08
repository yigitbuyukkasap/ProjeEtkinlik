using Proje.Etkinlik.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Proje.Etkinlik.API.Controllers
{
    public class SanatciController : ApiController
    {
        Proje_EtkinlikEntities entities = new Proje_EtkinlikEntities();

        [Route("sanatci/add")]
        [HttpPost]
        public int Ekle(Data.Sanatci obj)
        {
            entities.Sanatci.Add(obj);
            int returnValue = entities.SaveChanges();
            return returnValue;
        }

        [Route("sanatci/edit")]
        [HttpPut]
        public bool Duzenle(Data.Sanatci obj)
        {
            var ent = entities.Sanatci.Where(p => p.id == obj.id).FirstOrDefault();
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

        [Route("sanatci/delete/{id}")]
        [HttpDelete]
        public string Sil(int id)
        {
            var silincekData = entities.Sanatci.Where(p => p.id == id).FirstOrDefault();
            entities.Sanatci.Remove(silincekData);
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
