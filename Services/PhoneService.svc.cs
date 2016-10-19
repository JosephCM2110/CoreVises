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

namespace Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PhoneService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PhoneService.svc or PhoneService.svc.cs at the Solution Explorer and start debugging.
    public class PhoneService : IPhoneService
    {

        public string getPhones()
        {
            string response = "";
            PhoneBusiness pb = new PhoneBusiness("Data Source = 163.178.107.130; Initial Catalog = KeggPhones; User Id = sqlserver; Password = saucr.12");
            EncryptionMethods em = new EncryptionMethods();
            DataSet dsPhone = pb.getPhones();
            DataRowCollection dataRowCollection = dsPhone.Tables["TPhone"].Rows;
            BrandBusiness bb = new BrandBusiness("Data Source = 163.178.107.130; Initial Catalog = KeggPhones; User Id = sqlserver; Password = saucr.12");
            
            foreach (DataRow currentRow in dataRowCollection)
            {
                Brand brand = bb.getBrandById(Int32.Parse(currentRow["idBrand"].ToString()));
                response +=currentRow["idPhone"].ToString() + ";" +currentRow["model"].ToString() + ";" + brand.Name+ ";" + currentRow["OS"].ToString()
                    + ";" + currentRow["networkMode"].ToString() + ";" + currentRow["internalMemory"].ToString() + ";" + currentRow["externalMemory"].ToString() + ";" + currentRow["pixels"].ToString() + ";" +
                    currentRow["flash"].ToString() + ";" + currentRow["resolution"].ToString() + ";" + currentRow["price"].ToString() + ";" + currentRow["quantity"].ToString() + ";" + currentRow["imagePhone"].ToString() + "#";
                
            }

            return response;
        }

        public int insertPhone(int idPhone, int idBrand, string model, string os, string networkmode, string internalMemory,
            string externalMemory, int pixels, int flash, string resolution, int price, int quantity, string image)
        {
            PhoneBusiness pb = new PhoneBusiness("Data Source = 163.178.107.130; Initial Catalog = KeggPhones; User Id = sqlserver; Password = saucr.12");
            EncryptionMethods em = new EncryptionMethods();
            BrandBusiness bb = new BrandBusiness("Data Source = 163.178.107.130; Initial Catalog = KeggPhones; User Id = sqlserver; Password = saucr.12");
            Brand brand = bb.getBrandById(idBrand);
            Phone phone = new Phone(idPhone, brand, model, os, networkmode, internalMemory, externalMemory, pixels,
                flash, resolution, price, quantity, image);
            int response = pb.insertPhone(phone);
            return response;
        }

        public Phone getPhoneById(int idPhone)
        {
            EncryptionMethods em = new EncryptionMethods();
            PhoneBusiness pb = new PhoneBusiness("Data Source = 163.178.107.130; Initial Catalog = KeggPhones; User Id = sqlserver; Password = saucr.12");
            return pb.getPhoneById(idPhone);
        }

    }
}
