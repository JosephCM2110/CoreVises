using Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CoreVises.Presentation
{
    public partial class UpdatePhone : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void delete(Object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = gvPhone.Rows[e.RowIndex];

            Image image = (Image)row.FindControl("imagePhone");
            string path = @"C:\Users\Brayan\Source\Repos\CoreVises\CoreVises";
            string imagePath = image.ImageUrl;
            string newimagePath = imagePath.Remove(0, 2);
            string filePath = path + imagePath;
            File.Delete(filePath);



        }

        protected void update(object sender, GridViewUpdateEventArgs e)
        {


            GridViewRow row = gvPhone.Rows[e.RowIndex];
            FileUpload fl1 = (FileUpload)row.FindControl("fileImage");
            if (fl1.FileName != "")
            {
                Image image = (Image)row.FindControl("imagePhoneO");
                string path = @"C:\Users\Brayan\Source\Repos\CoreVises\CoreVises";
                string imagePath = image.ImageUrl;
                string newimagePath = imagePath.Remove(0, 2);
                string filePath = path + imagePath;
                File.Delete(filePath);
                e.NewValues["imagePhone"] = "../Images/Phones/" + fl1.FileName;
                fl1.SaveAs(Server.MapPath("~/Images/Phones/") + fl1.FileName);
            }

        }


    }
}