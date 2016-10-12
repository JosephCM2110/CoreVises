using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Brand
    {

        private int idBrand;
        private string name;

        public Brand()
        {
            this.IdBrand = 1;
            this.Name = "";
        }

        public Brand(int idBrand, string name)
        {
            this.IdBrand = idBrand;
            this.Name = name;
        }

        public int IdBrand
        {
            get
            {
                return idBrand;
            }

            set
            {
                idBrand = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
    }
}
