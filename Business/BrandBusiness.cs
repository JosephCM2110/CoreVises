using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Domain;

namespace Business
{
    public class BrandBusiness
    {

        private string connectionString;
        private BrandData brandData;

        public BrandBusiness(string conn)
        {
            this.ConnectionString = conn;
            this.BrandData = new BrandData(this.connectionString);
        }

        public int insertBrand(Brand brand)
        {
            return this.brandData.insertBrand(brand);
        }

        public int updateBrand(Brand brand)
        {
            return this.brandData.updateBrand(brand);
        }

        public int deleteBrand(int idBrand)
        {
            return this.deleteBrand(idBrand);
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

        public BrandData BrandData
        {
            get
            {
                return brandData;
            }

            set
            {
                brandData = value;
            }
        }
    }
}
