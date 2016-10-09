using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Domain;

namespace Business
{
    public class AdministratorBusiness
    {

        private string connectionString;
        private AdministratorData administatorData;

        public AdministratorBusiness(string conn)
        {
            this.ConnectionString = conn;
            this.AdministatorData = new AdministratorData(this.connectionString);
        }

        public int insertAdministrator(Administrator administrator)
        {
            return this.administatorData.insertAdministrator(administrator);
        }

        public int updateAdministrator(Administrator administrator)
        {
            return this.administatorData.updateAdministrator(administrator);
        }

        public int deleteAdministrator(int idAdministrator)
        {
            return this.administatorData.deleteAdministrator(idAdministrator);
        }

        public int verifyExistsAdministrator(string nameUser, string passwordUser)
        {
            return this.administatorData.verifyExistsAdministrator(nameUser, passwordUser);
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

        public AdministratorData AdministatorData
        {
            get
            {
                return administatorData;
            }

            set
            {
                administatorData = value;
            }
        }


    }
}
