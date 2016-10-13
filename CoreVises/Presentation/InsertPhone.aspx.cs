using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace CoreVises.Presentation
{
    public partial class InsertPhone : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                fillDDL();
               
            }
            this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            System.Console.WriteLine("What is your name: ");
        }

        public void fillDDL()
        {
            string conn = "Data Source=163.178.107.130;Initial Catalog=KeggPhones;User ID=sqlserver;Password=saucr.12";
            BrandBusiness brand = new BrandBusiness(conn);
            DataSet dsResult = brand.getAllBrands();
            ddlBrand.DataSource = dsResult;
            ddlBrand.DataTextField = "name";
            ddlBrand.DataValueField = "idBrand";
            ddlBrand.DataBind();
        }

        protected void btnAccept_Click(object sender, EventArgs e)
        {
            Phone phone = new Phone();
            Brand brand = new Brand();
            brand.IdBrand = Int32.Parse(ddlBrand.SelectedValue);
            brand.Name = ddlBrand.Text;
            phone.Brand = brand ;
            phone.Model = txtModel.Text;
            phone.InternalMemory = txtInternalMemory.Text;
            phone.ExternalMemory = txtExternalMemory.Text;
            phone.Pixels = Int32.Parse(txtPixels.Text);
            phone.Resolution = txtResolution.Text;
            phone.Flash = Int32.Parse(ddlFlash.SelectedValue);
            phone.Price = Int32.Parse(txtPrice.Text);
            phone.Quantity = Int32.Parse(txtQuantity.Text);
            phone.Image = "../Images/Phones/" + fileImage.FileName;
            try
            {
                fileImage.SaveAs(Server.MapPath("~/Images/Phones/") + fileImage.FileName);
            }
            catch
            {
                
            }

            string conn = "Data Source=163.178.107.130;Initial Catalog=KeggPhones;User ID=sqlserver;Password=saucr.12";
            PhoneBusiness phoneB = new PhoneBusiness(conn);
            phoneB.insertPhone(phone);
        }
    }
}