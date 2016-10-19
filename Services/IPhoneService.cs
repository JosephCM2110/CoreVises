using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPhoneService" in both code and config file together.
    [System.Web.Script.Services.ScriptService]
    [ServiceContract]
    public interface IPhoneService
    {
        [OperationContract]
        int insertPhone(int idPhone, int idBrand, string model, string os, string networkmode, string internalMemory,
            string externalMemory, int pixels, int flash, string resolution,
            int price, int quantity, string image);

        [OperationContract]
        string getPhones();

        [OperationContract]
        Phone getPhoneById(int idPhone);
    }
}

