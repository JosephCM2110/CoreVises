using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Business;

namespace Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service2" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service2.svc or Service2.svc.cs at the Solution Explorer and start debugging.
    public class Service2 : IService2
    {
        public DataSet getAdmUsingMethod()
        {
            AdministratorBusiness ab = new AdministratorBusiness("Data Source = 163.178.107.130; Initial Catalog = KeggPhones; User Id = sqlserver; Password = saucr.12");
            return ab.getAdministrators();
        }

        public DataSet getAdmUsingURI()
        {
            AdministratorBusiness ab = new AdministratorBusiness("Data Source = 163.178.107.130; Initial Catalog = KeggPhones; User Id = sqlserver; Password = saucr.12");
            return ab.getAdministrators();
        }
    }
}
