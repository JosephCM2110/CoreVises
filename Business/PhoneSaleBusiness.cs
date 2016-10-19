using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Domain;

namespace Business
{
    public class PhoneSaleBusiness
    {
        private string connectionString;
        private PhoneSaleData phoneSaleData;

        public PhoneSaleBusiness(string conn)
        {
            this.ConnectionString = conn;
            this.PhoneSaleData = new PhoneSaleData(this.ConnectionString);
        }

        public int insertPhoneSale(PhoneSale phoneSale)
        {
            return PhoneSaleData.insertPhoneSale(phoneSale);
        }

        public int DeletePhoneSale(int idPhoneSale)
        {
            return PhoneSaleData.DeletePhoneSale(idPhoneSale);
        }

        public Object[] getTop5PhoneSaleWeek()
        {
            return this.phoneSaleData.getTop5PhoneSaleWeek();
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

        public PhoneSaleData PhoneSaleData
        {
            get
            {
                return phoneSaleData;
            }

            set
            {
                phoneSaleData = value;
            }
        }
    }
}
