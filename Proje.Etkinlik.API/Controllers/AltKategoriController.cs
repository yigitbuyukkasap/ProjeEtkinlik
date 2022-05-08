using Proje.Etkinlik.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Proje.Etkinlik.API.Controllers
{
    public class AltKategoriController : ApiController
    {
        Proje_EtkinlikEntities entities = new Proje_EtkinlikEntities();

        [Route("altkategori/add")]
        [HttpPost]
        public int Ekle(Data.AltKategori obj)
        {
            entities.AltKategori.Add(obj);
            int returnValue = entities.SaveChanges();
            return returnValue;
        }

        [Route("altkategori/edit")]
        [HttpPut]
        public bool Duzenle(Data.AltKategori obj)
        {
            var ent = entities.AltKategori.Where(p => p.id == obj.id).FirstOrDefault();
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

        [Route("altkategori/delete/{id}")]
        [HttpDelete]
        public string Sil(int id)
        {
            var silincekData = entities.AltKategori.Where(p => p.id == id).FirstOrDefault();
            entities.AltKategori.Remove(silincekData);
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
