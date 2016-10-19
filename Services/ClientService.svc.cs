using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Business;
using Encryption;
using Domain;
using System.Web.Configuration;

namespace Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ClientService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ClientService.svc or ClientService.svc.cs at the Solution Explorer and start debugging.
    public class ClientService : IClientService
    {
        public string deleteClient(string idClient, string key)
        {
            EncryptionMethods em = new EncryptionMethods();
            string conn = WebConfigurationManager.ConnectionStrings["KeggPhonesConnectionString"].ToString();
            ClientBusiness cb = new ClientBusiness(conn);
            int t = Int32.Parse(em.decrypting(idClient + "", key));
            int r = cb.deleteClient(t);
            string response = em.encrypt(r + "", key);
            return response;
        }

        public string insertClient(string idUser, string name, string lastName_1, string lastName_2, string nameUser, string passwordUser, string email, string numberCard, string addressDirection, string postalCode, string svcCard, string key)
        {
            string conn = WebConfigurationManager.ConnectionStrings["KeggPhonesConnectionString"].ToString();
            ClientBusiness cb = new ClientBusiness(conn);
            EncryptionMethods em = new EncryptionMethods();
            Client client = new Client(Int32.Parse(em.decrypting(idUser,key)), em.decrypting(name,key), em.decrypting(lastName_1,key),em.decrypting(lastName_2,key), em.decrypting(nameUser,key)
                ,em.decrypting(passwordUser,key), em.decrypting(email,key), em.decrypting(numberCard,key),em.decrypting(addressDirection,key),em.decrypting(postalCode,key), em.decrypting(svcCard,key));
            int r =  cb.insertClient(client);
            string response = em.encrypt(r + "", key);
            return response;
        }

        public string updateClient(string idUser, string name, string lastName_1, string lastName_2, string nameUser, string passwordUser, string email, string numberCard, string addressDirection, string postalCode, string svcCard, string key)
        {
            string conn = WebConfigurationManager.ConnectionStrings["KeggPhonesConnectionString"].ToString();
            ClientBusiness cb = new ClientBusiness(conn);
            EncryptionMethods em = new EncryptionMethods();
            Client client = new Client(Int32.Parse(em.decrypting(idUser, key)), em.decrypting(name, key), em.decrypting(lastName_1, key), em.decrypting(lastName_2, key), em.decrypting(nameUser, key)
                , em.decrypting(passwordUser, key), em.decrypting(email, key), em.decrypting(numberCard, key), em.decrypting(addressDirection, key), em.decrypting(postalCode, key), em.decrypting(svcCard, key));
            int r = cb.updateClient(client);
            string response = em.encrypt(r + "", key);
            return response;
        }

        public string verifyExistsClient(string nameUser, string passwordUser, string key)
        {
            string conn = WebConfigurationManager.ConnectionStrings["KeggPhonesConnectionString"].ToString();
            ClientBusiness cb = new ClientBusiness(conn);
            EncryptionMethods em = new EncryptionMethods();
            int r =  cb.verifyExistsClient(em.decrypting(nameUser,key),em.decrypting( passwordUser,key));
            string response = em.encrypt(r + "", key);
            return response;
        }

        public string getClient(string nameUser, string key)
        {
            string conn = WebConfigurationManager.ConnectionStrings["KeggPhonesConnectionString"].ToString();
            ClientBusiness cb = new ClientBusiness(conn);
            EncryptionMethods em = new EncryptionMethods();
            Client client = cb.getClientByUserName(em.decrypting(nameUser,key));
            string response = client.IdUser + ";" + client.Name + ";" + client.LastName_1 + ";" + client.LastName_2 + ";" + client.PasswordUser + ";" + client.Email + ";" + client.NumberCard + ";" +
                client.AddressDirection + ";" + client.PostalCode + ";" + client.SvcCard;
            return em.encrypt(response,key);
        }
    }
}
