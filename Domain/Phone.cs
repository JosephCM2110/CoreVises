using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Phone
    {

        private int idPhone;
        private Brand brand;
        private string model;
        private string os;
        private string networkMode;
        private string internalMemory;
        private string externalMemory;
        private int pixels;
        private int flash;
        private string resolution;
        private int price;
        private int quantity;
        private string image;     

        public Phone()
        {
            this.IdPhone = -1;
            this.Brand = new Brand();
            this.Model = "";
            this.OS = "";
            this.NetworkMode = "";
            this.InternalMemory = "";
            this.ExternalMemory = "";
            this.Pixels = -1;
            this.Flash = -1;
            this.Resolution = "";
            this.Price = -1;
            this.Quantity = -1;
            this.Image = "";
        }

        public Phone(int idPhone, Brand brand, string model, string os, string networkmode, string internalMemory,
            string externalMemory, int pixels, int flash, string resolution,
            int price, int quantity,string image)
        {
            this.IdPhone = idPhone;
            this.Brand = brand;
            this.Model = model;
            this.OS = os;
            this.NetworkMode = networkMode;
            this.InternalMemory = internalMemory;
            this.ExternalMemory = externalMemory;
            this.Pixels = pixels;
            this.Flash = flash;
            this.Resolution = resolution;
            this.Price = price;
            this.Quantity = quantity;
            this.Image = image;
        }

        public int IdPhone
        {
            get
            {
                return idPhone;
            }

            set
            {
                idPhone = value;
            }
        }

        public Brand Brand
        {
            get
            {
                return brand;
            }

            set
            {
                brand = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }

        public string InternalMemory
        {
            get
            {
                return internalMemory;
            }

            set
            {
                internalMemory = value;
            }
        }

        public string ExternalMemory
        {
            get
            {
                return externalMemory;
            }

            set
            {
                externalMemory = value;
            }
        }

        public int Pixels
        {
            get
            {
                return pixels;
            }

            set
            {
                pixels = value;
            }
        }

        public int Flash
        {
            get
            {
                return flash;
            }

            set
            {
                flash = value;
            }
        }

        public string Resolution
        {
            get
            {
                return resolution;
            }

            set
            {
                resolution = value;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
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

        public string Image
        {
            get
            {
                return image;
            }

            set
            {
                image = value;
            }
        }

        public string OS
        {
            get
            {
                return os;
            }

            set
            {
                os = value;
            }
        }

        public string NetworkMode
        {
            get
            {
                return networkMode;
            }

            set
            {
                networkMode = value;
            }
        }
    }
}
