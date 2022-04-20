using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjeEtkinlik.Views.User
{
    public partial class snvDeneme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Proje.Etkinlik.Repository.User uyeEntity = new Proje.Etkinlik.Repository.User();
            gridView.DataSource = uyeEntity.Listele();
        }
    }
}