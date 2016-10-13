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
    public class PhoneData
    {

        private string connectionString;

        public PhoneData(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public int insertPhone(Phone phone)
        {
            SqlConnection connection = new SqlConnection(this.connectionString);

            string sqlStoredProcedure = "PAInsert_Phones";
            SqlCommand cmdInsert = new SqlCommand(sqlStoredProcedure, connection);

            cmdInsert.CommandType = CommandType.StoredProcedure;


            cmdInsert.Parameters.Add(new SqlParameter("@idBrand", phone.Brand.IdBrand));
            cmdInsert.Parameters.Add(new SqlParameter("@model", phone.Model));
            cmdInsert.Parameters.Add(new SqlParameter("@internalMemory", phone.InternalMemory));
            cmdInsert.Parameters.Add(new SqlParameter("@externalMemory", phone.ExternalMemory));
            cmdInsert.Parameters.Add(new SqlParameter("@pixels", phone.Pixels));
            cmdInsert.Parameters.Add(new SqlParameter("@flash", phone.Flash));
            cmdInsert.Parameters.Add(new SqlParameter("@resolution", phone.Resolution));
            cmdInsert.Parameters.Add(new SqlParameter("@price", phone.Price));
            cmdInsert.Parameters.Add(new SqlParameter("@quantity", phone.Quantity));
            cmdInsert.Parameters.Add(new SqlParameter("@imagePhone", phone.Image));
            SqlParameter parameterCode = new SqlParameter("@idPhone", SqlDbType.Int);
            parameterCode.Direction = ParameterDirection.Output;
            cmdInsert.Parameters.Add(parameterCode);

            cmdInsert.Connection.Open();
            cmdInsert.ExecuteNonQuery();


            int answer = Int32.Parse(cmdInsert.Parameters["@idPhone"].Value.ToString());

            cmdInsert.Connection.Close();

            return answer;
        }

        public int updatePhone(Phone phone)
        {
            SqlConnection connection = new SqlConnection(this.connectionString);

            string sqlStoredProcedure = "PAUpdate_Phoness";
            SqlCommand cmdInsert = new SqlCommand(sqlStoredProcedure, connection);

            cmdInsert.CommandType = CommandType.StoredProcedure;


            cmdInsert.Parameters.Add(new SqlParameter("@idBrand", phone.Brand.IdBrand));
            cmdInsert.Parameters.Add(new SqlParameter("@model", phone.Model));
            cmdInsert.Parameters.Add(new SqlParameter("@internalMemory", phone.InternalMemory));
            cmdInsert.Parameters.Add(new SqlParameter("@externalMemory", phone.ExternalMemory));
            cmdInsert.Parameters.Add(new SqlParameter("@pixels", phone.Pixels));
            cmdInsert.Parameters.Add(new SqlParameter("@flash", phone.Flash));
            cmdInsert.Parameters.Add(new SqlParameter("@resolution", phone.Resolution));
            cmdInsert.Parameters.Add(new SqlParameter("@price", phone.Price));
            cmdInsert.Parameters.Add(new SqlParameter("@quantity", phone.Quantity));
            cmdInsert.Parameters.Add(new SqlParameter("@idPhone", phone.Quantity));
            cmdInsert.Parameters.Add(new SqlParameter("@imagePhone", phone.Image));
            SqlParameter parameterCode = new SqlParameter("@state", SqlDbType.Int);
            parameterCode.Direction = ParameterDirection.Output;
            cmdInsert.Parameters.Add(parameterCode);

            cmdInsert.Connection.Open();
            cmdInsert.ExecuteNonQuery();


            int answer = Int32.Parse(cmdInsert.Parameters["@state"].Value.ToString());

            cmdInsert.Connection.Close();

            return answer;
        }

        public int deletePhone(int idPhone)
        {
            SqlConnection connection = new SqlConnection(this.connectionString);

            string sqlStoredProcedure = "PADelete_Phones";
            SqlCommand cmdInsert = new SqlCommand(sqlStoredProcedure, connection);

            cmdInsert.CommandType = CommandType.StoredProcedure;


            cmdInsert.Parameters.Add(new SqlParameter("@idPhone", idPhone));
            SqlParameter parameterCode = new SqlParameter("@state", SqlDbType.Int);
            parameterCode.Direction = ParameterDirection.Output;
            cmdInsert.Parameters.Add(parameterCode);

            cmdInsert.Connection.Open();
            cmdInsert.ExecuteNonQuery();


            int answer = Int32.Parse(cmdInsert.Parameters["@state"].Value.ToString());

            cmdInsert.Connection.Close();

            return answer;
        }

        public int verifyExistsPhone(string idBrand, string model)
        {
            SqlConnection connection = new SqlConnection(this.connectionString);

            string sqlStoredProcedure = "PAExist_Phone";
            SqlCommand cmdInsert = new SqlCommand(sqlStoredProcedure, connection);

            cmdInsert.CommandType = CommandType.StoredProcedure;


            cmdInsert.Parameters.Add(new SqlParameter("@model", model));
            cmdInsert.Parameters.Add(new SqlParameter("@idBrand", idBrand));
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
