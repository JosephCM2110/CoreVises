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

        public List<Phone> getPhones()
        {
            PhoneBusiness pb = new PhoneBusiness("Data Source = 163.178.107.130; Initial Catalog = KeggPhones; User Id = sqlserver; Password = saucr.12");
            BrandBusiness bb = new BrandBusiness("Data Source = 163.178.107.130; Initial Catalog = KeggPhones; User Id = sqlserver; Password = saucr.12");
            EncryptionMethods em = new EncryptionMethods();
            DataSet dsPhone = pb.getPhones();
            DataRowCollection dataRowCollection = dsPhone.Tables["TPhone"].Rows;
            List<Phone> phones = new List<Phone>();
            int flash;
            foreach (DataRow currentRow in dataRowCollection)
            {
                Brand brandTemp = bb.getBrandById(Int32.Parse(currentRow["idBrand"].ToString()));
                if (currentRow["flash"].ToString() == "True")
                    flash = 1;
                else
                    flash = 0;
                int idPhone = Int32.Parse(currentRow["idPhone"].ToString());
                string model = currentRow["model"].ToString();
                string os = currentRow["OS"].ToString();
                string nm = currentRow["networkMode"].ToString();
                string im = currentRow["internalMemory"].ToString();
                string exm = currentRow["externalMemory"].ToString();
                int pixels = Int32.Parse(currentRow["pixels"].ToString());
                string resol = currentRow["resolution"].ToString();
                int price = (int) Double.Parse(currentRow["price"].ToString());
                int quantity = Int32.Parse(currentRow["quantity"].ToString());
                string imgP = currentRow["imagePhone"].ToString();
                Phone phoneTemp = new Phone(idPhone, brandTemp, model, os, nm, im, exm, pixels, flash, resol, price, quantity, imgP);
                phones.Add(phoneTemp);
            }

            return phones;
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

    }
}
