﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Encryption;
using Domain;
using Data;
using System.Data;
using System.Linq;
using Business;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Reports.ReportsMethods r = new Reports.ReportsMethods();

            r.generatePhoneSaleReport();

            //SaleData pd = new SaleData("Data Source = 163.178.107.130; Initial Catalog = KeggPhones; User Id = sqlserver; Password = saucr.12");


            //Object[] a = pd.getBestClients();

            //List<Client> c = (List<Client>) a[0];
            //List<int> i = (List<int>)a[1];

            //int x = 0;

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
