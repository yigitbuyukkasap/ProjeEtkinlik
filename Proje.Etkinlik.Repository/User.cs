using Proje.Etkinlik.Data;
using System.Collections.Generic;
using System.Linq;

namespace Proje.Etkinlik.Repository
{
    public class User 
    {
        Proje_EtkinlikEntities entities = new Proje_EtkinlikEntities();

        public Uye UyeBilgileri(string Email)
        {
            var uyeBilgileri = entities.Uye.Where(p => p.Email == Email).FirstOrDefault();
            return uyeBilgileri;
        }
        
        public List<Uye> Listele()
        {
            return entities.Uye.ToList();
        }
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

        public void UyeDuzenle(Data.Uye uye)
        {
            var user = entities.Uye.Where(p => p.Email == uye.Email).FirstOrDefault();
            user = uye;
            var sonuc = entities.SaveChanges();
            if (sonuc == 1)
            {
                //
            }
            else
            {

            }
        }

        public int UyeOl(Data.Uye yeniUye)
        {
            entities.Uye.Add(yeniUye);
            int returnValue = entities.SaveChanges();
            return returnValue;
        }

        public int GirisYap(Data.Uye yeniUye)
        {
            var anyCount = entities.Uye.Where(p => p.Email == yeniUye.Email && p.Sifre == yeniUye.Sifre).FirstOrDefault();
            if (anyCount != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

    }
}
