using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CoreVises.Presentation
{
    public partial class UpdatePhone : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Delete_Image(object sender, GridViewDeleteEventArgs e)
        {
            File.Delete(sdsPhones.UpdateParameters["i"].DefaultValue);
            
        }

        protected void Update_Image(object sender, GridViewUpdateEventArgs e)
        {
            
        }
    }
}