using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Domain;

namespace Business
{
    public class SaleBusiness
    {
        private string connectionString;
        private SaleData saleData;

        public SaleBusiness(string conn)
        {
            this.ConnectionString = conn;
            this.SaleData = new SaleData(this.ConnectionString);
        }

        public int insertSale(Sale sale)
        {
            return saleData.insertSale(sale);
        }

        public int deleteSale(int idSale)
        {
            return saleData.deleteSale(idSale);
        }

        public Object[] getBestClients()
        {
            return this.saleData.getBestClients();
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

        public SaleData SaleData
        {
            get
            {
                return saleData;
            }

            set
            {
                saleData = value;
            }
        }
    }
}
