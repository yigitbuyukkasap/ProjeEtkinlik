using ProjeEtkinlik.Views.partials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjeEtkinlik.Views
{
    public partial class LoginSignUp : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void girisyap_Click(object sender, EventArgs e)
        {

            Proje.Etkinlik.Repository.User login = new Proje.Etkinlik.Repository.User();
            Proje.Etkinlik.Data.Uye uyeEntity= new Proje.Etkinlik.Data.Uye();
            uyeEntity.Email = email.Value;
            uyeEntity.Sifre = sifre.Value;
            var kontrol = login.GirisYap(uyeEntity);
            if (kontrol != null)
            {
                Session["User"] = kontrol;
                Response.Redirect("AnaSayfa");
            }
            else
            {

            }
        }

        protected void uyeOl_Click(object sender, EventArgs e)
        {
            Proje.Etkinlik.Repository.User login = new Proje.Etkinlik.Repository.User();
            Proje.Etkinlik.Data.Uye uyeEntity = new Proje.Etkinlik.Data.Uye();
            uyeEntity.AdSoyad = uyeol_adsoyad.Value;
            uyeEntity.Email = uyeol_email.Value;
            uyeEntity.Sifre = uyeol_sifre.Value;
            login.UyeOl(uyeEntity);
        }
    }
}