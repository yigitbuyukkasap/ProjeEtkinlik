using Proje.Etkinlik.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Proje.Etkinlik.API.Controllers
{
    public class UserController : ApiController
    {
        Proje_EtkinlikEntities entities = new Proje_EtkinlikEntities();

        [Route("user/getuser/{email}")]
        [HttpGet]
        public Uye GetUser(string email)
        {
            var uyeBilgileri = entities.Uye.Where(p => p.Email == email).FirstOrDefault();
            return uyeBilgileri;
        }

        [Route("user/getuserlist")]
        [HttpGet]
        public List<Uye> Listele()
        {
            return entities.Uye.ToList();
        }

        [Route("user/userdelete/{email}")]
        [HttpDelete]
        public string UyeSil(string silincekMail)
        {
            var silincekKisi = entities.Uye.Where(p => p.Email.Equals(silincekMail)).FirstOrDefault();
            entities.Uye.Remove(silincekKisi);
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
        [Route("user/edituser")]
        [HttpPut]
        public bool UyeDuzenle(Data.Uye uye)
        {
            var user = entities.Uye.Where(p => p.Email == uye.Email).FirstOrDefault();
            user = uye;
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

        [Route("user/register")]
        [HttpPost]
        public int UyeOl([FromBody]Data.Uye yeniUye)
        {
            entities.Uye.Add(yeniUye);
            int returnValue = entities.SaveChanges();
            return returnValue;
        }
        [Route("user/login")]
        [HttpPost]
        public Uye GirisYap([FromBody] Login login )
        {
            var obj = entities.Uye.Where(p => p.Email == login.email&& p.Sifre == login.sifre).FirstOrDefault();
            return obj;
        }

        public class Login 
        {
            public string email{ get; set; }
            public string sifre{ get; set; }
        }

    }
}
