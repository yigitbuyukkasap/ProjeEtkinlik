using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace ProjeEtkinlik
{
    public class Global : System.Web.HttpApplication
    {
        void RegisterCustomRoutes(RouteCollection routes)
        {
            routes.MapPageRoute(
                "AnaSayfa",
                "AnaSayfa",
                "~/Default.aspx"
            );
        }
        protected void Application_Start(object sender, EventArgs e)
        {
            // Add Routes.
            RegisterCustomRoutes(RouteTable.Routes);
        }
    }
}