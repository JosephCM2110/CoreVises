using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Domain;

namespace Data
{
    public class ClientData
    {

        private string connectionString;

        public ClientData(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public int insertClient(Client client)
        {
            SqlConnection connection = new SqlConnection(this.connectionString);

            string sqlStoredProcedure = "PAInsert_Client";
            SqlCommand cmdInsert = new SqlCommand(sqlStoredProcedure, connection);

            cmdInsert.CommandType = CommandType.StoredProcedure;


            cmdInsert.Parameters.Add(new SqlParameter("@name", client.Name));
            cmdInsert.Parameters.Add(new SqlParameter("@lastName1", client.LastName_1));
            cmdInsert.Parameters.Add(new SqlParameter("@lastName2", client.LastName_2));
            cmdInsert.Parameters.Add(new SqlParameter("@nameUser", client.NameUser));
            cmdInsert.Parameters.Add(new SqlParameter("@passwordUser", client.PasswordUser));
            cmdInsert.Parameters.Add(new SqlParameter("@email", client.Email));
            cmdInsert.Parameters.Add(new SqlParameter("@numberCard", client.NumberCard));
            cmdInsert.Parameters.Add(new SqlParameter("@address", client.AddressDirection));
            cmdInsert.Parameters.Add(new SqlParameter("@postal", client.PostalCode));
            cmdInsert.Parameters.Add(new SqlParameter("@svc", client.SvcCard));
            SqlParameter parameterCode = new SqlParameter("@idClient", SqlDbType.Int);
            parameterCode.Direction = ParameterDirection.Output;
            cmdInsert.Parameters.Add(parameterCode);

            cmdInsert.Connection.Open();
            cmdInsert.ExecuteNonQuery();


            int answer = Int32.Parse(cmdInsert.Parameters["@idClient"].Value.ToString());

            cmdInsert.Connection.Close();

            return answer;
        }

        public int updateClient(Client client)
        {
            SqlConnection connection = new SqlConnection(this.connectionString);

            string sqlStoredProcedure = "PAUpdate_Client";
            SqlCommand cmdInsert = new SqlCommand(sqlStoredProcedure, connection);

            cmdInsert.CommandType = CommandType.StoredProcedure;


            cmdInsert.Parameters.Add(new SqlParameter("@name", client.Name));
            cmdInsert.Parameters.Add(new SqlParameter("@lastName1", client.LastName_1));
            cmdInsert.Parameters.Add(new SqlParameter("@lastName2", client.LastName_2));
            cmdInsert.Parameters.Add(new SqlParameter("@nameUser", client.NameUser));
            cmdInsert.Parameters.Add(new SqlParameter("@passwordUser", client.PasswordUser));
            cmdInsert.Parameters.Add(new SqlParameter("@email", client.Email));
            cmdInsert.Parameters.Add(new SqlParameter("@numberCard", client.NumberCard));
            cmdInsert.Parameters.Add(new SqlParameter("@address", client.AddressDirection));
            cmdInsert.Parameters.Add(new SqlParameter("@postal", client.PostalCode));
            cmdInsert.Parameters.Add(new SqlParameter("@svc", client.SvcCard));
            cmdInsert.Parameters.Add(new SqlParameter("@idClient", client.IdUser));
            SqlParameter parameterCode = new SqlParameter("@state", SqlDbType.Int);
            parameterCode.Direction = ParameterDirection.Output;
            cmdInsert.Parameters.Add(parameterCode);

            cmdInsert.Connection.Open();
            cmdInsert.ExecuteNonQuery();


            int answer = Int32.Parse(cmdInsert.Parameters["@state"].Value.ToString());

            cmdInsert.Connection.Close();

            return answer;
        }

        public int deleteClient(int idClient)
        {
            SqlConnection connection = new SqlConnection(this.connectionString);

            string sqlStoredProcedure = "PADelete_Client";
            SqlCommand cmdInsert = new SqlCommand(sqlStoredProcedure, connection);

            cmdInsert.CommandType = CommandType.StoredProcedure;

            cmdInsert.Parameters.Add(new SqlParameter("@idClient", idClient));
            SqlParameter parameterCode = new SqlParameter("@state", SqlDbType.Int);
            parameterCode.Direction = ParameterDirection.Output;
            cmdInsert.Parameters.Add(parameterCode);

            cmdInsert.Connection.Open();
            cmdInsert.ExecuteNonQuery();


            int answer = Int32.Parse(cmdInsert.Parameters["@state"].Value.ToString());

            cmdInsert.Connection.Close();

            return answer;
        }

        public int verifyExistsClient(string nameUser, string passwordUser)
        {
            SqlConnection connection = new SqlConnection(this.connectionString);

            string sqlStoredProcedure = "PAExist_Client";
            SqlCommand cmdInsert = new SqlCommand(sqlStoredProcedure, connection);

            cmdInsert.CommandType = CommandType.StoredProcedure;


            cmdInsert.Parameters.Add(new SqlParameter("@nameUser", nameUser));
            cmdInsert.Parameters.Add(new SqlParameter("@passwordUser", passwordUser));
            SqlParameter parameterCode = new SqlParameter("@state", SqlDbType.Int);
            parameterCode.Direction = ParameterDirection.Output;
            cmdInsert.Parameters.Add(parameterCode);

            cmdInsert.Connection.Open();
            cmdInsert.ExecuteNonQuery();


            int answer = Int32.Parse(cmdInsert.Parameters["@state"].Value.ToString());

            cmdInsert.Connection.Close();

            return answer;
        }

    }
}