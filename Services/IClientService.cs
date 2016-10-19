using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IClientService" in both code and config file together.
    [ServiceContract]
    public interface IClientService
    {
        [OperationContract]
        string insertClient(string client,string key);

        [OperationContract]
        string updateClient(string client, string key);

        [OperationContract]
        string deleteClient(string idClient, string key);

        [OperationContract]
        string verifyExistsClient(string client, string key);

        [OperationContract]
        string getClient(string nameUser, string key);
    }
}
