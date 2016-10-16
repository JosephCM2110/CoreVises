using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CoreVises.Presentation
{
    public partial class InsertAdministrator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["message"];
            if (cookie != null)
            {
                lblMessage.Text = Request.Cookies["message"].Value;
            }
        }

        protected void btnAccept_Click(object sender, EventArgs e)
        {
            Administrator admin = new Administrator();
            admin.Name = txtName.Text;
            admin.LastName_1 = txtLastName_1.Text;
            admin.LastName_2 = txtLastName_2.Text;
            admin.NameUser = txtUserName.Text;
            admin.PasswordUser = txtPassword.Text;
            admin.Email = txtEmail.Text;

            string conn = WebConfigurationManager.ConnectionStrings["KeggPhonesConnectionString"].ToString();
            AdministratorBusiness adminB = new AdministratorBusiness(conn);
            int exists = adminB.insertAdministrator(admin);
            if (exists == -1)
            {
                Response.Cookies["message"].Value = "Somenthing is wrong, sorry.";
                Response.Cookies["message"].Expires = DateTime.Now.AddSeconds(5);
                Response.Redirect("./InsertAdministrator.aspx");
            }
            else
            {
                Response.Cookies["message"].Value = "The administrator was correctly added.";
                Response.Cookies["message"].Expires = DateTime.Now.AddSeconds(5);
                Response.Redirect("./InsertAdministrator.aspx");
            }

        }
    }
}