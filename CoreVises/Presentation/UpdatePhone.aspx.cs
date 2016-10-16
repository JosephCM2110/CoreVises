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
            Label4.Text = imagePath;
            int p = imagePath.Length;
            imagePath = imagePath.Substring(2, p);
            string filePath = path + imagePath;
            Label4.Text = filePath;
            //File.Delete(image.ImageUrl);



        }

        protected void Update(object sender, GridViewUpdateEventArgs e)
        {
            
        }


    }
}