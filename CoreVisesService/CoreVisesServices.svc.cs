using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Domain;
using Business;
using System.Data;

namespace CoreVisesService
{
    public class CoreVisesServices : ICoreVisesServices
    {
        public DataSet getAdministrators()
        {
            AdministratorBusiness ab = new AdministratorBusiness("Data Source = 163.178.107.130; Initial Catalog = KeggPhones; User Id = sqlserver; Password = saucr.12");
            return ab.getAdministrators();
        }
    }
}
