using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Domain;

namespace Business
{
    class ClientBusiness
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
            return ClientData.insertClient(client);
        }

        public int updateClient(Client client)
        {
            return ClientData.updateClient(client);
        }

        public int deleteClient(int idClient)
        {
            return clientData.deleteClient(idClient);
        }

        public int verifyExistsClient(string nameUser, string passwordUser)
        {
            return clientData.verifyExistsClient(nameUser, passwordUser);
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
