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

        public string insertClient(string client, string key)
        {
            string conn = WebConfigurationManager.ConnectionStrings["KeggPhonesConnectionString"].ToString();
            ClientBusiness cb = new ClientBusiness(conn);
            EncryptionMethods em = new EncryptionMethods();
            string text = em.decrypting(client, key);
            string[] fields = text.Split(';');
            Client clientO = new Client(Int32.Parse(fields[0]), fields[1], fields[2], fields[3], fields[4], fields[5], fields[6], fields[7], fields[8], fields[9], fields[10]);
            int r =  cb.insertClient(clientO);
            string response = em.encrypt(r + "", key);
            return response;
        }

        public string updateClient(string client, string key)
        {
            string conn = WebConfigurationManager.ConnectionStrings["KeggPhonesConnectionString"].ToString();
            ClientBusiness cb = new ClientBusiness(conn);
            EncryptionMethods em = new EncryptionMethods();
            string text = em.decrypting(client, key);
            string[] fields = text.Split(';');
            Client clientO = new Client(Int32.Parse(fields[0]),fields[1], fields[2], fields[3], fields[4], fields[5], fields[6], fields[7], fields[8], fields[9], fields[10]);
            int r = cb.updateClient(clientO);
            string response = em.encrypt(r + "", key);
            return response;
        }

        public string verifyExistsClient(string client, string key)
        {
            string conn = WebConfigurationManager.ConnectionStrings["KeggPhonesConnectionString"].ToString();
            ClientBusiness cb = new ClientBusiness(conn);
            EncryptionMethods em = new EncryptionMethods();
            string text = em.decrypting(client, key);
            string[] fields = text.Split(';');
            int r =  cb.verifyExistsClient(fields[0],fields[1]);
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
