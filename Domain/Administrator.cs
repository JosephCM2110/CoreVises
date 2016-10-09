using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Runtime.Serialization;

namespace Domain
{
    public class Administrator
    {
        private int idUser;
        private string name;
        private string lastName_1;
        private string lastName_2;
        private string nameUser;
        private string passwordUser;
        private string email;

        public Administrator()
        {
            this.idUser = -1;
            this.name = "";
            this.lastName_1 = "";
            this.lastName_2 = "";
            this.nameUser = "";
            this.passwordUser = "";
            this.email = "";
        }

        public Administrator(int idUser, string name, string lastName_1, string lastName_2, string nameUser, string passwordUser,
            string email)
        {
            this.idUser = idUser;
            this.name = name;
            this.lastName_1 = lastName_1;
            this.lastName_2 = lastName_2;
            this.nameUser = nameUser;
            this.passwordUser = passwordUser;
            this.email = email;
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
    }

}
