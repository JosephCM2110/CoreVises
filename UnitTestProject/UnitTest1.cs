using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;
using System.Data;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            AdministratorData ad = new AdministratorData("Data Source = 163.178.107.130; Initial Catalog = KeggPhones; User Id = sqlserver; Password = saucr.12");
            DataSet dsAdm = ad.getAdministrators();
            DataRowCollection dataRowCollection = dsAdm.Tables["TAdministrator"].Rows;
            foreach (DataRow currentRow in dataRowCollection)
            {
                string a = currentRow["name"].ToString();
            }
        }
    }
}
