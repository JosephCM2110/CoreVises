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
    public partial class InsertBrand : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookieLogin = Request.Cookies["user"];
            if (cookieLogin == null)
            {
                Response.Redirect("../index.aspx");
            }
            HttpCookie cookie = Request.Cookies["message"];
            if (cookie != null)
            {
                lblMessage.Text = Request.Cookies["message"].Value;
            }
        }

        protected void btnAccept_Click(object sender, EventArgs e)
        {
            Brand brand = new Brand();
            brand.Name = txtName.Text;
            string conn = WebConfigurationManager.ConnectionStrings["KeggPhonesConnectionString"].ToString();
            BrandBusiness brandB = new BrandBusiness(conn);
            int exists = brandB.insertBrand(brand);
            if (exists == -1)
            {
                Response.Cookies["message"].Value = "Somenthing is wrong, sorry.";
                Response.Cookies["message"].Expires = DateTime.Now.AddSeconds(5);
                Response.Redirect("./InsertBrand.aspx");
            }
            else
            {
                Response.Cookies["message"].Value = "The brand was correctly added.";
                Response.Cookies["message"].Expires = DateTime.Now.AddSeconds(5);
                Response.Redirect("./InsertBrand.aspx");
            }
        }
    }
}