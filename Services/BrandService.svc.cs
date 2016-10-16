using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Encryption;

namespace Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BrandService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BrandService.svc or BrandService.svc.cs at the Solution Explorer and start debugging.
    public class BrandService : IBrandService
    {
        public int deleteBrand(int idBrand)
        {
            BrandBusiness b = new BrandBusiness("Data Source = 163.178.107.130; Initial Catalog = KeggPhones; User Id = sqlserver; Password = saucr.12");
            EncryptionMethods em = new EncryptionMethods();
            int r = b.deleteBrand(idBrand);
            return r;
        }

        public List<Brand> getAllBrands()
        {
            BrandBusiness b = new BrandBusiness("Data Source = 163.178.107.130; Initial Catalog = KeggPhones; User Id = sqlserver; Password = saucr.12");
            EncryptionMethods em = new EncryptionMethods();
            DataSet dsBrand = b.getAllBrands();
            DataRowCollection dataRowCollection = dsBrand.Tables["TBrand"].Rows;
            List<Brand> brands = new List<Brand>();
            foreach (DataRow currentRow in dataRowCollection)
            {
                Brand brandTemp = new Brand(Int32.Parse(currentRow["idBrand"].ToString()), currentRow["name"].ToString());
                brands.Add(brandTemp);
            }

            return brands;
        }

        public int insertBrand(int idBrand, string name)
        {
            Brand br = new Brand(idBrand, name);
            BrandBusiness b = new BrandBusiness("Data Source = 163.178.107.130; Initial Catalog = KeggPhones; User Id = sqlserver; Password = saucr.12");
            EncryptionMethods em = new EncryptionMethods();
            int r = b.insertBrand(br);
            return r;
        }

        public int updateBrand(int idBrand, string name)
        {
            Brand br = new Brand(idBrand, name);
            BrandBusiness b = new BrandBusiness("Data Source = 163.178.107.130; Initial Catalog = KeggPhones; User Id = sqlserver; Password = saucr.12");
            EncryptionMethods em = new EncryptionMethods();
            int r = b.updateBrand(br);
            return r;
        }
    }
}