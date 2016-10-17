using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SaleService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SaleService.svc or SaleService.svc.cs at the Solution Explorer and start debugging.
    public class SaleService : ISaleService
    {
        public int registerSale(int idClient, string phonesQuantities, int total)
        {
            ClientBusiness cb = new ClientBusiness("Data Source = 163.178.107.130; Initial Catalog = KeggPhones; User Id = sqlserver; Password = saucr.12");
            SaleBusiness sb = new SaleBusiness("Data Source = 163.178.107.130; Initial Catalog = KeggPhones; User Id = sqlserver; Password = saucr.12");
            PhoneSaleBusiness psb = new PhoneSaleBusiness("Data Source = 163.178.107.130; Initial Catalog = KeggPhones; User Id = sqlserver; Password = saucr.12");
            PhoneBusiness pb = new PhoneBusiness("Data Source = 163.178.107.130; Initial Catalog = KeggPhones; User Id = sqlserver; Password = saucr.12");
            Client client = cb.getClientById(idClient);
            Sale sale = new Sale(0, client, total, DateTime.Today.ToString());
            int r = sb.insertSale(sale);
            sale.IdSale = r;
            string[] phones = phonesQuantities.Split(',');
            for (int i=0; i<phones.Length; i++)
            {
                string[] data = phones[i].Split('.');
                Phone phone = pb.getPhoneById(Int32.Parse(data[0]));
                PhoneSale ps = new PhoneSale(0, phone, sale, Int32.Parse(data[1]));
                psb.insertPhoneSale(ps);
            }

            return 1;
        }
    }
}
