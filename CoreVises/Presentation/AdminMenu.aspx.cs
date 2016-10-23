using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CoreVises.Presentation
{
    public partial class AdminMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookieLogin = Request.Cookies["user"];
            if (cookieLogin == null)
            {
                Response.Redirect("../index.aspx");
            }
        }
    }
}