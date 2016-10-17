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
        int insertClient(int idUser, string name, string lastName_1, string lastName_2, string nameUser, string passwordUser,
            string email, string numberCard, string addressDirection, string postalCode, string svcCard);

        [OperationContract]
        int updateClient(int idUser, string name, string lastName_1, string lastName_2, string nameUser, string passwordUser,
            string email, string numberCard, string addressDirection, string postalCode, string svcCard);

        [OperationContract]
        int deleteClient(int idClient);

        [OperationContract]
        int verifyExistsClient(string nameUser, string passwordUser);

        [OperationContract]
        Client getClient(string nameUser);
    }
}
