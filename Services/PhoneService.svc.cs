using Business;
using Domain;
using Encryption;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Configuration;

namespace Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PhoneService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PhoneService.svc or PhoneService.svc.cs at the Solution Explorer and start debugging.
    public class PhoneService : IPhoneService
    {

        public string getPhones(string key)
        {
            string response = "";
            string conn = WebConfigurationManager.ConnectionStrings["KeggPhonesConnectionString"].ToString();
            PhoneBusiness pb = new PhoneBusiness(conn);
            EncryptionMethods em = new EncryptionMethods();
            DataSet dsPhone = pb.getPhones();
            DataRowCollection dataRowCollection = dsPhone.Tables["TPhone"].Rows;
            BrandBusiness bb = new BrandBusiness(conn);
            string path = "";
            foreach (DataRow currentRow in dataRowCollection)
            {
                Brand brand = bb.getBrandById(Int32.Parse(currentRow["idBrand"].ToString()));
                path = currentRow["imagePhone"].ToString();
                response +=currentRow["idPhone"].ToString() + ";" +currentRow["model"].ToString() + ";" + brand.Name+ ";" + currentRow["OS"].ToString()
                    + ";" + currentRow["networkMode"].ToString() + ";" + currentRow["internalMemory"].ToString() + ";" + currentRow["externalMemory"].ToString() + ";" + currentRow["pixels"].ToString() + ";" +
                    currentRow["flash"].ToString() + ";" + currentRow["resolution"].ToString() + ";" + currentRow["price"].ToString() + ";" + currentRow["quantity"].ToString() + ";" + "http://25.45.62.52/CoreVises" + path.Substring(2,path.Length-2) + "#";
                
            }

            return em.encrypt(response,key);
        }

        public string getPhoneById(string idPhone, string key)
        {
            EncryptionMethods em = new EncryptionMethods();
            string conn = WebConfigurationManager.ConnectionStrings["KeggPhonesConnectionString"].ToString();
            int t = Int32.Parse(em.decrypting(idPhone, key));
            PhoneBusiness pb = new PhoneBusiness(conn);
            BrandBusiness bb = new BrandBusiness(conn);
            Phone phone = pb.getPhoneById(t);
            Brand brand = bb.getBrandById(phone.Brand.IdBrand);
            string path = phone.Image;
            string response = phone.IdPhone + ";" + phone.Model + ";" + brand.Name + ";" + phone.OS + ";" + phone.NetworkMode + ";" + phone.InternalMemory + ";" + phone.ExternalMemory + ";" +
                phone.Pixels + ";" +phone.Flash + ";" + phone.Resolution + ";" + phone.Price + ";" + phone.Quantity + ";" + "http://25.45.62.52/CoreVises" + path.Substring(2, path.Length - 2);

            return em.encrypt(response, key);
        }

    }
}
