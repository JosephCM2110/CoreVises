using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Encryption;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string texto = "23452.we,l,tr,r";
            Console.WriteLine(texto);
            Console.WriteLine("------------------------------------------------------------------");
            string key = "me";
            EncryptionMethods e = new EncryptionMethods();
            string textoe = e.encrypt(texto, key);
            Console.WriteLine(textoe);
            Console.WriteLine("------------------------------------------------------------------");
            string textodes = e.decrypting(textoe, key);
            Console.WriteLine(textodes);
        }
    }
}
