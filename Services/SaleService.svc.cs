using Business;
using Domain;
using Encryption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Configuration;

namespace Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SaleService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SaleService.svc or SaleService.svc.cs at the Solution Explorer and start debugging.
    public class SaleService : ISaleService
    {
        public string registerSale(string idClient, string phonesQuantities, string total,string key)
        {
            EncryptionMethods em = new EncryptionMethods();
            string conn = WebConfigurationManager.ConnectionStrings["KeggPhonesConnectionString"].ToString();
            ClientBusiness cb = new ClientBusiness(conn);
            SaleBusiness sb = new SaleBusiness(conn);
            PhoneSaleBusiness psb = new PhoneSaleBusiness(conn);
            PhoneBusiness pb = new PhoneBusiness(conn);
            Client client = cb.getClientById(Int32.Parse(em.decrypting(idClient,key)));
            Sale sale = new Sale(0, client, Int32.Parse(em.decrypting(total, key)), DateTime.Today.ToString());
            int r = sb.insertSale(sale);
            sale.IdSale = r;
            string phonesQ = em.decrypting(phonesQuantities, key);
            string[] phones = phonesQ.Split('#');
            for (int i=0; i<phones.Length; i++)
            {
                string[] data = phones[i].Split(';');
                Phone phone = pb.getPhoneById(Int32.Parse(data[0]));
                PhoneSale ps = new PhoneSale(0, phone, sale, Int32.Parse(data[1]));
                psb.insertPhoneSale(ps);
            }

            return em.encrypt(1+"",key);
        }
    }
}
