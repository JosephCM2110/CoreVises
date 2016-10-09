using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class PhoneSale
    {
        private int idPhoneSale;
        private Phone phone;
        private Sale sale;
        private int quantity;

        public PhoneSale()
        {
            this.IdPhoneSale = -1;
            this.Phone = new Phone();
            this.Sale = new Sale();
            this.Quantity = -1;
        }

        public PhoneSale(int idPhoneSale, Phone phone, Sale sale, int quantity)
        {
            this.IdPhoneSale = idPhoneSale;
            this.Phone = phone;
            this.Sale = sale;
            this.Quantity = quantity;
        }

        public int IdPhoneSale
        {
            get
            {
                return idPhoneSale;
            }

            set
            {
                idPhoneSale = value;
            }
        }

        public Phone Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        public Sale Sale
        {
            get
            {
                return sale;
            }

            set
            {
                sale = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }
    }
}
