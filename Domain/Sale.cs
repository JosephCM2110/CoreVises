using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Sale
    {
        private int idSale;
        private Client client;
        private int total;
        private string dateSale;

        public Sale()
        {
            this.IdSale = -1;
            this.Client = new Client();
            this.Total = -1;
            this.DateSale = "";
        }

        public Sale(int idSale, Client client, int total, string dateSale)
        {
            this.IdSale = idSale;
            this.Client = client;
            this.Total = total;
            this.DateSale = dateSale;
        }

        public int IdSale
        {
            get
            {
                return idSale;
            }

            set
            {
                idSale = value;
            }
        }

        public Client Client
        {
            get
            {
                return client;
            }

            set
            {
                client = value;
            }
        }

        public int Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }

        public string DateSale
        {
            get
            {
                return dateSale;
            }

            set
            {
                dateSale = value;
            }
        }
    }
}
