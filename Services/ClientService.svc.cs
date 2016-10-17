using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Business;
using Encryption;
using Domain;

namespace Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ClientService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ClientService.svc or ClientService.svc.cs at the Solution Explorer and start debugging.
    public class ClientService : IClientService
    {
        public int deleteClient(int idClient)
        {
            ClientBusiness cb = new ClientBusiness("Data Source = 163.178.107.130; Initial Catalog = KeggPhones; User Id = sqlserver; Password = saucr.12");
            EncryptionMethods em = new EncryptionMethods();
            int response = cb.deleteClient(idClient);
            return response;
        }

        public int insertClient(int idUser, string name, string lastName_1, string lastName_2, string nameUser, string passwordUser, string email, string numberCard, string addressDirection, string postalCode, string svcCard)
        {
            ClientBusiness cb = new ClientBusiness("Data Source = 163.178.107.130; Initial Catalog = KeggPhones; User Id = sqlserver; Password = saucr.12");
            EncryptionMethods em = new EncryptionMethods();
            Client client = new Client(idUser, name, lastName_1, lastName_2, nameUser, passwordUser, email, numberCard,
                addressDirection, postalCode, svcCard);
            int response =  cb.insertClient(client);
            return response;
        }

        public int updateClient(int idUser, string name, string lastName_1, string lastName_2, string nameUser, string passwordUser, string email, string numberCard, string addressDirection, string postalCode, string svcCard)
        {
            ClientBusiness cb = new ClientBusiness("Data Source = 163.178.107.130; Initial Catalog = KeggPhones; User Id = sqlserver; Password = saucr.12");
            EncryptionMethods em = new EncryptionMethods();
            Client client = new Client(idUser, name, lastName_1, lastName_2, nameUser, passwordUser, email, numberCard,
                addressDirection, postalCode, svcCard);
            int response = cb.updateClient(client);
            return response;
        }

        public int verifyExistsClient(string nameUser, string passwordUser)
        {
            ClientBusiness cb = new ClientBusiness("Data Source = 163.178.107.130; Initial Catalog = KeggPhones; User Id = sqlserver; Password = saucr.12");
            EncryptionMethods em = new EncryptionMethods();
            int response =  cb.verifyExistsClient(nameUser, passwordUser);
            return response;
        }

        Client getClient(string nameUser)
        {
            ClientBusiness cb = new ClientBusiness("Data Source = 163.178.107.130; Initial Catalog = KeggPhones; User Id = sqlserver; Password = saucr.12");
            EncryptionMethods em = new EncryptionMethods();
            return cb.getClientByUserName(nameUser);
        }
    }
}
