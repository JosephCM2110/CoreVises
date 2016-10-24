using Business;
using Domain;
using Encryption;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using System.Web.Configuration;

namespace Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PhonesLikeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PhonesLikeService.svc or PhonesLikeService.svc.cs at the Solution Explorer and start debugging.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class PhonesLikeService : IPhonesLikeService
    {
        public string getPhonesLike(string word, string key)
        {
            string response = "";
            string conn = WebConfigurationManager.ConnectionStrings["KeggPhonesConnectionString"].ToString();
            PhoneBusiness pb = new PhoneBusiness(conn);
            EncryptionMethods em = new EncryptionMethods();
            DataSet dsPhone = pb.getPhonesLike(em.decrypting(word,key));
            DataRowCollection dataRowCollection = dsPhone.Tables["TPhone"].Rows;
            BrandBusiness bb = new BrandBusiness(conn);
            string path = "";
            foreach (DataRow currentRow in dataRowCollection)
            {
                path = currentRow["imagePhone"].ToString();
                Brand brand = bb.getBrandById(Int32.Parse(currentRow["idBrand"].ToString()));
                response += currentRow["idPhone"].ToString() + ";" + currentRow["model"].ToString() + ";" + brand.Name + ";" + currentRow["OS"].ToString()
                    + ";" + currentRow["networkMode"].ToString() + ";" + currentRow["internalMemory"].ToString() + ";" + currentRow["externalMemory"].ToString() + ";" + currentRow["pixels"].ToString() + ";" +
                    currentRow["flash"].ToString() + ";" + currentRow["resolution"].ToString() + ";" + currentRow["price"].ToString() + ";" + currentRow["quantity"].ToString() + ";" + "http://25.45.62.52/CoreVises" +path.Substring(2, path.Length - 2) + "#";

            }

            return em.encrypt(response, key);
        }
    }
}
