using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Encryption;
using Domain;
using Data;
using System.Data;
using System.Linq;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
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


            PhoneServiceReference.PhoneServiceClient c = new PhoneServiceReference.PhoneServiceClient();

            int r = c.getPhones().Count();

            Console.WriteLine(r);

            Console.ReadLine();
        }
    }
}
