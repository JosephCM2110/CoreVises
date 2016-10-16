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
    public class BrandData
    {
        private string connectionString;

        public BrandData(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public int insertBrand(Brand brand)
        {
            SqlConnection connection = new SqlConnection(this.connectionString);

            string sqlStoredProcedure = "PAInsert_Brand";
            SqlCommand cmdInsert = new SqlCommand(sqlStoredProcedure, connection);

            cmdInsert.CommandType = CommandType.StoredProcedure;


            cmdInsert.Parameters.Add(new SqlParameter("@name", brand.Name));
            SqlParameter parameterCode = new SqlParameter("@idBrand", SqlDbType.Int);
            parameterCode.Direction = ParameterDirection.Output;
            cmdInsert.Parameters.Add(parameterCode);

            cmdInsert.Connection.Open();
            cmdInsert.ExecuteNonQuery();


            int answer = Int32.Parse(cmdInsert.Parameters["@idBrand"].Value.ToString());

            cmdInsert.Connection.Close();

            return answer;
        }

        public int updateBrand(Brand brand)
        {
            SqlConnection connection = new SqlConnection(this.connectionString);

            string sqlStoredProcedure = "PAUpdate_Brand";
            SqlCommand cmdInsert = new SqlCommand(sqlStoredProcedure, connection);

            cmdInsert.CommandType = CommandType.StoredProcedure;


            cmdInsert.Parameters.Add(new SqlParameter("@name", brand.Name));
            cmdInsert.Parameters.Add(new SqlParameter("@idBrand", brand.IdBrand));
            SqlParameter parameterCode = new SqlParameter("@state", SqlDbType.Int);
            parameterCode.Direction = ParameterDirection.Output;
            cmdInsert.Parameters.Add(parameterCode);

            cmdInsert.Connection.Open();
            cmdInsert.ExecuteNonQuery();


            int answer = Int32.Parse(cmdInsert.Parameters["@state"].Value.ToString());

            cmdInsert.Connection.Close();

            return answer;
        }

        public int deleteBrand(int idBrand)
        {
            SqlConnection connection = new SqlConnection(this.connectionString);

            string sqlStoredProcedure = "PADelete_Brand";
            SqlCommand cmdInsert = new SqlCommand(sqlStoredProcedure, connection);

            cmdInsert.CommandType = CommandType.StoredProcedure;

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

        public DataSet getAllBrands()
        {

            SqlConnection sqlConn = new SqlConnection(this.connectionString);

            string query = "select * from TBrand order by(name) ASC ";

            SqlDataAdapter sqlAdpaterBank = new SqlDataAdapter();
            sqlAdpaterBank.SelectCommand = new SqlCommand();
            sqlAdpaterBank.SelectCommand.CommandText = query;
            sqlAdpaterBank.SelectCommand.Connection = sqlConn;

            DataSet dsBrand = new DataSet();

            sqlAdpaterBank.Fill(dsBrand, "TBrand");

            sqlAdpaterBank.SelectCommand.Connection.Close();

            return dsBrand;
        }

        public Brand getBrandById(int idBrand)
        {
            SqlConnection sqlConn = new SqlConnection(this.connectionString);

            string query = "select * from TBrand where idBrand = " + idBrand;

            SqlDataAdapter sqlAdpaterBank = new SqlDataAdapter();
            sqlAdpaterBank.SelectCommand = new SqlCommand();
            sqlAdpaterBank.SelectCommand.CommandText = query;
            sqlAdpaterBank.SelectCommand.Connection = sqlConn;

            DataSet dsBrand = new DataSet();

            sqlAdpaterBank.Fill(dsBrand, "TBrand");

            sqlAdpaterBank.SelectCommand.Connection.Close();

            DataRowCollection dataRowCollection = dsBrand.Tables["TBrand"].Rows;
            Brand brand = new Brand(); ;
            foreach (DataRow currentRow in dataRowCollection)
            {
                brand.IdBrand = Int32.Parse(currentRow["idBrand"].ToString());
                brand.Name = currentRow["name"].ToString();
            }

            return brand;
        }

    }
}
