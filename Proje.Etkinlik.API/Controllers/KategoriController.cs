using Proje.Etkinlik.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Proje.Etkinlik.API.Controllers
{
    public class KategoriController : ApiController
    {
        Proje_EtkinlikEntities entities = new Proje_EtkinlikEntities();

        [Route("kategori/add")]
        [HttpPost]
        public int Ekle(Data.Kategori obj)
        {
            entities.Kategori.Add(obj);
            int returnValue = entities.SaveChanges();
            return returnValue;
        }

        [Route("kategori/edit")]
        [HttpPut]
        public bool Duzenle(Data.Kategori obj)
        {
            var ent = entities.Kategori.Where(p => p.id == obj.id).FirstOrDefault();
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

        [Route("kategori/delete/{id}")]
        [HttpDelete]
        public string Sil(int id)
        {
            var silincekData = entities.Kategori.Where(p => p.id == id).FirstOrDefault();
            entities.Kategori.Remove(silincekData);
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
