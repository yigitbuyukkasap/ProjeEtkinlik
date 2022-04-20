using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjeEtkinlik.Views.partials
{
    public partial class Bildirim : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        public void Yazdir()
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(),"toastr_message", "toastr.error('There was an error', 'Error')", true);
        }
    }

}