using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Encryption;
using Domain;
using Data;
using System.Data;
using System.Linq;
using Business;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {


            ClientBusiness cb = new ClientBusiness("Data Source = 163.178.107.130; Initial Catalog = KeggPhones; User Id = sqlserver; Password = saucr.12");
           

            Client c = cb.getClientByUserName("yarr");
            c.Name = "Brayan";
            cb.updateClient(c);
            Console.Write(c.LastName_1);

            //SaleServiceReference.SaleServiceClient c = new SaleServiceReference.SaleServiceClient();

            //c.registerSale(11, "18.1,19.2", 10000);



            //PhoneData cd = new PhoneData("Data Source = 163.178.107.130; Initial Catalog = KeggPhones; User Id = sqlserver; Password = saucr.12");
            //Phone c = cd.getPhoneById(18);
            //Console.WriteLine(c.Model);
            //Console.ReadLine();

            //string texto = "23452.we,l,tr,r";
            //Console.WriteLine(texto);
            //Console.WriteLine("------------------------------------------------------------------");
            //string key = "me";
            //EncryptionMethods e = new EncryptionMethods();
            //string textoe = e.encrypt(texto, key);
            //Console.WriteLine(textoe);
            //Console.WriteLine("------------------------------------------------------------------");
            //string textodes = e.decrypting(textoe, key);
            //Console.WriteLine(textodes);


            //PhoneServiceReference.PhoneServiceClient c = new PhoneServiceReference.PhoneServiceClient();

            //int r = c.getPhones().Count();

            //Console.WriteLine(r);

            //Console.ReadLine();
        }
    }
}
