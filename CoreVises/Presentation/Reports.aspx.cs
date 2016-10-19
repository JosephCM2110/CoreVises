using Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CoreVises.Presentation
{
    public partial class Reports : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["__EVENTTARGET"] == "btnClients")
            {
                //llamamos el metodo que queremos ejecutar, en este caso el evento onclick del boton Button2
                btnClients_Click(this, new EventArgs());
            }
            else
            {
                if (Request.Form["__EVENTTARGET"] == "btnPhones")
                {
                    //llamamos el metodo que queremos ejecutar, en este caso el evento onclick del boton Button2
                    btnClients_Click(this, new EventArgs());
                }
            }
        }

        protected void btnClients_Click(object sender, EventArgs e)
        {
            ReportsMethods rp = new ReportsMethods();
            rp.generateClientReport();
        }

        protected void btnPhones_Click(object sender, EventArgs e)
        {
            ReportsMethods rp = new ReportsMethods();
            rp.generatePhoneSaleReport();
        }
    }
}