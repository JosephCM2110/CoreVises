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
    public class PhoneSaleData
    {
        private string connectionString;

        public PhoneSaleData(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public int insertPhoneSale(PhoneSale phoneSale)
        {
            SqlConnection connection = new SqlConnection(this.connectionString);

            string sqlStoredProcedure = "PAInsert_SaleXPhones";
            SqlCommand cmdInsert = new SqlCommand(sqlStoredProcedure, connection);

            cmdInsert.CommandType = CommandType.StoredProcedure;


            cmdInsert.Parameters.Add(new SqlParameter("@idsale", phoneSale.Sale.IdSale));
            cmdInsert.Parameters.Add(new SqlParameter("@idPhone", phoneSale.Phone.IdPhone));
            cmdInsert.Parameters.Add(new SqlParameter("@quantity", phoneSale.Quantity));
            SqlParameter parameterCode = new SqlParameter("@idPhoneSale", SqlDbType.Int);
            parameterCode.Direction = ParameterDirection.Output;
            cmdInsert.Parameters.Add(parameterCode);

            cmdInsert.Connection.Open();
            cmdInsert.ExecuteNonQuery();


            int answer = Int32.Parse(cmdInsert.Parameters["@idPhoneSale"].Value.ToString());

            cmdInsert.Connection.Close();

            return answer;
        }

        public int DeletePhoneSale(int idPhoneSale)
        {
            SqlConnection connection = new SqlConnection(this.connectionString);

            string sqlStoredProcedure = "PADelete_SaleXPhones";
            SqlCommand cmdInsert = new SqlCommand(sqlStoredProcedure, connection);

            cmdInsert.CommandType = CommandType.StoredProcedure;


            cmdInsert.Parameters.Add(new SqlParameter("@idPhoneSale", idPhoneSale));
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
