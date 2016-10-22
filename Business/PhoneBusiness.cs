using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Domain;
using System.Data;

namespace Business
{
    public class PhoneBusiness
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
            return this.PhoneData.insertPhone(phone);
        }

        public int updatePhone(Phone phone)
        {
            return this.PhoneData.updatePhone(phone);
        }

        public int deletePhone(int idPhone)
        {
            return this.PhoneData.deletePhone(idPhone);
        }

        public int verifyExistsPhone(string idBrand, string model)
        {
            return this.PhoneData.verifyExistsPhone(idBrand, model);
        }

        public DataSet getPhones()
        {
            return phoneData.getPhones();
        }
        public DataSet getPhonesLike(string word)
        {
            return phoneData.getPhonesLike(word);
        }

        public Phone getPhoneById(int idPhone)
        {
            return this.phoneData.getPhoneById(idPhone);
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
