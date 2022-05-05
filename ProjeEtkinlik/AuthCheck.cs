using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjeEtkinlik
{
    public class AuthCheck : System.Web.UI.Page
    {
        public string _pageRole { get; set; }
        protected override void OnLoad(EventArgs e)
        {
            _pageRole = "User";
            string uyeRole = "Public";
            Proje.Etkinlik.Data.Uye uye = (Proje.Etkinlik.Data.Uye)System.Web.HttpContext.Current.Session["User"];
            if (uye != null)
                uyeRole = uye.Yetki;
            if (_pageRole != uyeRole)
                HttpContext.Current.Response.Redirect("AnaSayfa");

            base.OnLoad(e);
        }
    }
}