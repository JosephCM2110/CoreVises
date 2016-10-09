using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Domain;

namespace Business
{
    class PhoneBusiness
    {
        private string connectionString;
        private PhoneData phoneData;

        public PhoneBusiness(string conn)
        {
            this.ConnectionString = conn;
            this.PhoneData = new PhoneData(this.ConnectionString);
        }

        public int insertPhone(Phone phone)
        {
            return PhoneData.insertPhone(phone);
        }

        public int updatePhone(Phone phone)
        {
            return PhoneData.updatePhone(phone);
        }

        public int deletePhone(int idPhone)
        {
            return PhoneData.deletePhone(idPhone);
        }

        public int verifyExistsPhone(string idBrand, string model)
        {
            return PhoneData.verifyExistsPhone(idBrand, model);
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

        public PhoneData PhoneData
        {
            get
            {
                return phoneData;
            }

            set
            {
                phoneData = value;
            }
        }
    }
}
