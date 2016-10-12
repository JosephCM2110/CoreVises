using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Client
    {
        protected int idUser;
        protected string name;
        protected string lastName_1;
        protected string lastName_2;
        protected string nameUser;
        protected string passwordUser;
        protected string email;
        private string numberCard;
        private string addressDirection;
        private string postalCode;
        private string svcCard;

        public Client()
        {
            this.idUser = -1;
            this.name = "";
            this.lastName_1 = "";
            this.lastName_2 = "";
            this.nameUser = "";
            this.passwordUser = "";
            this.email = "";
            this.NumberCard = "";
            this.AddressDirection = "";
            this.PostalCode = "";
            this.SvcCard = "";
        }

        public Client(int idUser, string name, string lastName_1, string lastName_2, string nameUser, string passwordUser,
            string email, string numberCard, string addressDirection, string postalCode, string svcCard)
        {
            this.idUser = idUser;
            this.name = name;
            this.lastName_1 = lastName_1;
            this.lastName_2 = lastName_2;
            this.nameUser = nameUser;
            this.passwordUser = passwordUser;
            this.email = email;
            this.NumberCard = numberCard;
            this.AddressDirection = addressDirection;
            this.PostalCode = postalCode;
            this.SvcCard = svcCard;
        }


        public int IdUser
        {
            get
            {
                return idUser;
            }

            set
            {
                idUser = value;
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

        public string LastName_1
        {
            get
            {
                return lastName_1;
            }

            set
            {
                lastName_1 = value;
            }
        }

        public string LastName_2
        {
            get
            {
                return lastName_2;
            }

            set
            {
                lastName_2 = value;
            }
        }

        public string NameUser
        {
            get
            {
                return nameUser;
            }

            set
            {
                nameUser = value;
            }
        }

        public string PasswordUser
        {
            get
            {
                return passwordUser;
            }

            set
            {
                passwordUser = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string NumberCard
        {
            get
            {
                return numberCard;
            }

            set
            {
                numberCard = value;
            }
        }

        public string AddressDirection
        {
            get
            {
                return addressDirection;
            }

            set
            {
                addressDirection = value;
            }
        }

        public string PostalCode
        {
            get
            {
                return postalCode;
            }

            set
            {
                postalCode = value;
            }
        }

        public string SvcCard
        {
            get
            {
                return svcCard;
            }

            set
            {
                svcCard = value;
            }
        }


    }
}
