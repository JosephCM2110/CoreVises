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

        protected void Delete(Object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = gvPhone.Rows[e.RowIndex];
            string conn = WebConfigurationManager.ConnectionStrings["KeggPhonesConnectionString"].ToString();
            int idPhone = Int32.Parse(gvPhone.Rows[row.DataItemIndex].Cells[1].Text);
            PhoneBusiness phoneB = new PhoneBusiness(conn);
            fillGrid();
            
        }

        protected void Update(object sender, GridViewUpdateEventArgs e)
        {
            
        }

        public void fillGrid()
        {
            string conn = WebConfigurationManager.ConnectionStrings["KeggPhonesConnectionString"].ToString();
            PhoneBusiness phoneB = new PhoneBusiness(conn);
            DataSet dataSet;
            //gvPhone.DataSource = dataSet;
            gvPhone.DataBind();

        }
    }
}