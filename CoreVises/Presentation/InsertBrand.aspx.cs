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
    public partial class InsertBrand : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAccept_Click(object sender, EventArgs e)
        {
            Brand brand = new Brand();
            brand.Name = txtName.Text;
            string conn = "Data Source=163.178.107.130;Initial Catalog=KeggPhones;User ID=sqlserver;Password=saucr.12";
            BrandBusiness brandB = new BrandBusiness(conn);
            brandB.insertBrand(brand);
        }
    }
}