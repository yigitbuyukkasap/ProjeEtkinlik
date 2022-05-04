using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjeEtkinlik
{
    public class AuthCheck : Attribute
    {
        public AuthCheck(string pageRole)
        {
            string uyeRole = "Public";
            var uye = (Proje.Etkinlik.Data.Uye)System.Web.HttpContext.Current.Session["User"];
            if (uye.Yetki != null)
                uyeRole = uye.Yetki;
            if (pageRole != uyeRole)
                HttpContext.Current.Response.Redirect("AnaSayfa");
        }
    }
}