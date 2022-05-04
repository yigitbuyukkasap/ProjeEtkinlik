using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjeEtkinlik.Views.Public
{
    public partial class ForgetPassw : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Degistir_Click(object sender, EventArgs e)
        {
            Proje.Etkinlik.Repository.User forgetPsw = new Proje.Etkinlik.Repository.User();
            Proje.Etkinlik.Data.Uye uyeEntity = new Proje.Etkinlik.Data.Uye();
            uyeEntity.Email = email.Text;
            uyeEntity.Sifre = sifre.Text;
            forgetPsw.UyeDuzenle(uyeEntity);
            
        }
        }
}