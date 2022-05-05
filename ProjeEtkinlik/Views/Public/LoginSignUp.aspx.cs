using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace ProjeEtkinlik.Views
{
    public partial class LoginSignUp : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public class Login
        {
            public string email { get; set; }
            public string sifre { get; set; }
        }
        protected void girisyap_Click(object sender, EventArgs e)
        {
            var login = new Login
            {
                email = email.Value,
                sifre = sifre.Value,
            };
            ApiHttpRequests httpRequest = new ApiHttpRequests();
            var rp = httpRequest.HttpPostRequest("user/login", login);

            if (rp != null)
            {
                Session["User"] = JsonConvert.DeserializeObject<Proje.Etkinlik.Data.Uye>(rp.Result.ToString());
                Response.Redirect("AnaSayfa");
            }

        }



        protected void uyeOl_Click(object sender, EventArgs e)
        {
            Proje.Etkinlik.Repository.User login = new Proje.Etkinlik.Repository.User();
            Proje.Etkinlik.Data.Uye uyeEntity = new Proje.Etkinlik.Data.Uye();
            uyeEntity.AdSoyad = uyeol_adsoyad.Value;
            uyeEntity.Email = uyeol_email.Value;
            uyeEntity.Sifre = uyeol_sifre.Value;

            ApiHttpRequests httpRequest = new ApiHttpRequests();
            var rp = httpRequest.HttpPostRequest("user/register", uyeEntity);

            if (rp != null)
            {
                 var x = JsonConvert.DeserializeObject<int>(rp.Result.ToString());
                Response.Redirect("AnaSayfa");
            }
        }


    }
}