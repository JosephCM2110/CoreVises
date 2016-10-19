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
using System.Web.Configuration;

namespace Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BrandService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BrandService.svc or BrandService.svc.cs at the Solution Explorer and start debugging.
    public class BrandService : IBrandService
    {
        public string deleteBrand(string idBrand, string key)
        {
            string conn = WebConfigurationManager.ConnectionStrings["KeggPhonesConnectionString"].ToString();
            BrandBusiness b = new BrandBusiness(conn);
            EncryptionMethods em = new EncryptionMethods();
            int t = Int32.Parse(em.decrypting(idBrand + "", key));
            int r = b.deleteBrand(t);
            string response = em.encrypt(r+"",key);
            return response;
        }

        public string getAllBrands(string key)
        {
            string response = "";
            string conn = WebConfigurationManager.ConnectionStrings["KeggPhonesConnectionString"].ToString();
            BrandBusiness b = new BrandBusiness(conn);
            EncryptionMethods em = new EncryptionMethods();
            DataSet dsBrand = b.getAllBrands();
            DataRowCollection dataRowCollection = dsBrand.Tables["TBrand"].Rows;
            foreach (DataRow currentRow in dataRowCollection)
            {
               response += currentRow["idBrand"].ToString()+ ";" + currentRow["name"].ToString()+"#";
            }

            return em.encrypt(response,key);
        }

        public string insertBrand(string idBrand, string name, string key)
        {
            EncryptionMethods em = new EncryptionMethods();
            int t = Int32.Parse(em.decrypting(idBrand + "", key));
            Brand br = new Brand(t, em.decrypting(name,key));
            string conn = WebConfigurationManager.ConnectionStrings["KeggPhonesConnectionString"].ToString();
            BrandBusiness b = new BrandBusiness(conn);
            int r = b.insertBrand(br);
            string response = em.encrypt(r + "", key);
            return response;
        }

        public string updateBrand(string idBrand, string name,string key)
        {
            EncryptionMethods em = new EncryptionMethods();
            int t = Int32.Parse(em.decrypting(idBrand + "", key));
            Brand br = new Brand(t, em.decrypting(name, key));
            string conn = WebConfigurationManager.ConnectionStrings["KeggPhonesConnectionString"].ToString();
            BrandBusiness b = new BrandBusiness(conn);
            int r = b.updateBrand(br);
            string response = em.encrypt(r + "", key);
            return response;
        }

        public string getBrandById(string idBrand,string key)
        {
            EncryptionMethods em = new EncryptionMethods();
            string conn = WebConfigurationManager.ConnectionStrings["KeggPhonesConnectionString"].ToString();
            BrandBusiness b = new BrandBusiness(conn);
            int t = Int32.Parse(em.decrypting(idBrand + "", key));
            Brand brand = b.getBrandById(t);
            string response = brand.IdBrand + ";" + brand.Name;
            return em.encrypt(response,key);
        }
    }
}