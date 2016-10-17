using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Domain;

namespace Business
{
    public class ClientBusiness
    {
        private string connectionString;
        private ClientData clientData;

        public ClientBusiness(string conn)
        {
            this.ConnectionString = conn;
            this.ClientData = new ClientData(this.ConnectionString);
        }

        public int insertClient(Client client)
        {
            return this.ClientData.insertClient(client);
        }

        public int updateClient(Client client)
        {
            return this.ClientData.updateClient(client);
        }

        public int deleteClient(int idClient)
        {
            return this.ClientData.deleteClient(idClient);
        }

        public int verifyExistsClient(string nameUser, string passwordUser)
        {
            return this.ClientData.verifyExistsClient(nameUser, passwordUser);
        }

        public Client getClientById(int idClient)
        {
            return this.clientData.getClientById(idClient);
        }

        public string ConnectionString
        {
            get
            {
                return connectionString;
            }

            set
            {
                connectionString = value;
            }
        }

        public ClientData ClientData
        {
            get
            {
                return clientData;
            }

            set
            {
                clientData = value;
            }
        }
    }
}
