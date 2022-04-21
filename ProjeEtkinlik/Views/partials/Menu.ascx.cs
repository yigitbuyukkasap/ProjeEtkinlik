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

            var role = (Proje.Etkinlik.Data.Uye)System.Web.HttpContext.Current.Session["User"];
            var menu = new Proje.Etkinlik.Repository
                        .Menu()
                        .GetByRole(role.Yetki);

            if (menu != null)   ListingMenu(menu);
        }

        private void ListingMenu(IList<Proje.Etkinlik.Repository.Menu> menu)
        {
            string str = "";

            for (int i = 0; i < menu.Count; i++)
            {
                str += "<li class='nav-item'>";
                str += "<a class='nav-link' href='LoginSignUp.aspx'>Giriş Yap / Üye Ol</a>";
                str += "</li>";
            }
            lt_menu.Text += str;
        }
    }
}