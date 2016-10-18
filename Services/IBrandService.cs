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
        int insertBrand(int idBrand, string name);

        [OperationContract]
        int updateBrand(int idBrand, string name);

        [OperationContract]
        int deleteBrand(int idBrand);

        [OperationContract]
        List<Brand> getAllBrands();

    }
}
