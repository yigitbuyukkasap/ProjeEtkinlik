using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjeEtkinlik.Views.partials
{
    public partial class Menu : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            var yetki = (Proje.Etkinlik.Data.Uye)System.Web.HttpContext.Current.Session["User"];
        }
    }
}