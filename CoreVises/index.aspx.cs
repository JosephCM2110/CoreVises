using System;
using Business;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CoreVises
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["message"];
            if (cookie != null)
            {
                lblMessage.Text = Request.Cookies["message"].Value;
            }
            HttpCookie cookieLogin = Request.Cookies["user"];
            if (cookieLogin != null)
            {
                Response.Cookies["user"].Value = null;
                Response.Cookies["user"].Expires = DateTime.Now.AddSeconds(-1);
            }
        }

        protected void btnAccept_Click(object sender, EventArgs e)
        {
            string conn = "Data Source=163.178.107.130;Initial Catalog=KeggPhones;User ID=sqlserver;Password=saucr.12";
            AdministratorBusiness adminB = new AdministratorBusiness(conn);
            int exists = adminB.verifyExistsAdministrator(txtUser.Text,txtPassword.Text);
            if(exists == 0)
            {
                Response.Cookies["message"].Value = "Your user name or password are wrong. Try again.";
                Response.Cookies["message"].Expires = DateTime.Now.AddSeconds(5);
                Response.Redirect("./index.aspx");
            }
            else
            {
                Response.Cookies["user"].Value = txtUser.Text;
                Response.Cookies["user"].Expires = DateTime.Now.AddSeconds(1200);
                Response.Redirect("./Presentation/Principal.aspx");
            }
            
        }
    }
}