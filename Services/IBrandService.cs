using Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Services
{
    
    [ServiceContract]
    public interface IBrandService
    {
        [OperationContract]
        string insertBrand(string idBrand, string name, string key);

        [OperationContract]
        string updateBrand(string idBrand, string name, string key);

        [OperationContract]
        string deleteBrand(string idBrand, string key);

        [OperationContract]
        string getAllBrands(string key);

        [OperationContract]
        string getBrandById(string idBrand, string key);


    }
}
