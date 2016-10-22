using System;
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

            //PhoneData data = new PhoneData("Data Source = 163.178.107.130; Initial Catalog = KeggPhones; User Id = sqlserver; Password = saucr.12");
            //DataSet dsPhones = data.getPhonesLike("8");

            //DataRowCollection dataRowCollection = dsPhones.Tables["TPhone"].Rows;

            //foreach (DataRow currentRow in dataRowCollection)
            //{
            //    Console.WriteLine(currentRow["model"]);

            //}
            //Reports.ReportsMethods r = new Reports.ReportsMethods();

            //r.generatePhoneSaleReport();

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
            string key = "yarr";
            EncryptionMethods e = new EncryptionMethods();
            //string textoe = e.encrypt(texto, key);
            //Console.WriteLine(textoe);
            Console.WriteLine("------------------------------------------------------------------");
            string textodes = e.decrypting("{,c4d/us%/s63s713/?yj2}y1/$y1/%}ju0:4/%}$2}c]3¿}f, }f,}c{/z.%q,bk@w62s-8%fvf%c6%hh,.zu1uhd75kj5s6f,k@a.t:;s630yu-qy08018@wy:?l0u5v9$79_0%u[0$5#,mmuy2s4u;7ssnkg32e.yt3]c/9cz!b/w8/s63s713/¿yj2}y1/]y1/%}jgs4_fc%fy%}j2!?f,} f,}}j3cz%u8,i@dw:d0-/uwvmut6]:y,%b.12:u7.@15zhw,rrr.1obs:e{y2s8y-j{1/r;y!x302g:9ai]_-u.[-y?#__4u6d042p#sz%2g0dv.6[", key);
            Console.WriteLine(textodes);





            //PhoneServiceReference.PhoneServiceClient c = new PhoneServiceReference.PhoneServiceClient();

            //int r = c.getPhones().Count();

            //Console.WriteLine(r);

            //Console.ReadLine();
        }
    }
}
