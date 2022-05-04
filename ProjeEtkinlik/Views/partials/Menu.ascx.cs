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
            string usedRole = WebConst.PublicRole;
            var role = (Proje.Etkinlik.Data.Uye)System.Web.HttpContext.Current.Session["User"];
            if (role != null)
                usedRole = role.Yetki;

            var menu = new Proje.Etkinlik.Repository
                        .Menu()
                        .GetByRole(usedRole).ToList();
            if (menu != null)
            {
                ListingMenu(menu);
            }
        }

        private void ListingMenu(List<Proje.Etkinlik.Data.Menu> menu)
        {
            string str = "";

            for (int i = 0; i < menu.Count; i++)
            {
                str += "<li class='nav-item'>";
                str += "<a class='nav-link' href='" + menu[i].MenuAdres + "'> " + menu[i].MenuAd + " </a>";
                str += "</li>";
            }
            lt_menu.Text += str;
        }
    }
}