using Proje.Etkinlik.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Proje.Etkinlik.API.Controllers
{
    public class UserController : ApiController
    {
        Proje_EtkinlikEntities entities = new Proje_EtkinlikEntities();
        public Uye GetUser(string email)
        {
            var uyeBilgileri = entities.Uye.Where(p => p.Email == email).FirstOrDefault();
            return uyeBilgileri;
        }
    }
}
