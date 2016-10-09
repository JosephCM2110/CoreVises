using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CoreVises.Presentation
{
    public partial class InsertAdministrator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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

            string conn = "Data Source=163.178.107.130;Initial Catalog=KeggPhones;User ID=sqlserver;Password=saucr.12";
            AdministratorBusiness adminB = new AdministratorBusiness(conn);
            adminB.insertAdministrator(admin);

        }
    }
}