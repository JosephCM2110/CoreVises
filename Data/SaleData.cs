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
    public class SaleData
    {
        private string connectionString;

        public SaleData(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public int insertSale(Sale sale)
        {
            SqlConnection connection = new SqlConnection(this.connectionString);

            string sqlStoredProcedure = "PAInsert_Sale";
            SqlCommand cmdInsert = new SqlCommand(sqlStoredProcedure, connection);

            cmdInsert.CommandType = CommandType.StoredProcedure;


            cmdInsert.Parameters.Add(new SqlParameter("@idClient", sale.Client.IdUser));
            cmdInsert.Parameters.Add(new SqlParameter("@total", sale.Total));
            SqlParameter parameterCode = new SqlParameter("@idSale", SqlDbType.Int);
            parameterCode.Direction = ParameterDirection.Output;
            cmdInsert.Parameters.Add(parameterCode);

            cmdInsert.Connection.Open();
            cmdInsert.ExecuteNonQuery();


            int answer = Int32.Parse(cmdInsert.Parameters["@idSale"].Value.ToString());

            cmdInsert.Connection.Close();

            return answer;
        }

        public int deleteSale(int idSale)
        {
            SqlConnection connection = new SqlConnection(this.connectionString);

            string sqlStoredProcedure = "PAInsert_Sale";
            SqlCommand cmdInsert = new SqlCommand(sqlStoredProcedure, connection);

            cmdInsert.CommandType = CommandType.StoredProcedure;


            cmdInsert.Parameters.Add(new SqlParameter("@idSale", idSale));
            SqlParameter parameterCode = new SqlParameter("@state", SqlDbType.Int);
            parameterCode.Direction = ParameterDirection.Output;
            cmdInsert.Parameters.Add(parameterCode);

            cmdInsert.Connection.Open();
            cmdInsert.ExecuteNonQuery();


            int answer = Int32.Parse(cmdInsert.Parameters["@state"].Value.ToString());

            cmdInsert.Connection.Close();

            return answer;
        }

        public Object[] getBestClients()
        {
            SqlConnection sqlConn = new SqlConnection(this.connectionString);

            //string sql
            string sqlSelect = "select top 10 TSale.idClient, SUM(TSale.total) as 'total' from TSale where DATEDIFF(M, TSale.dateSale, " +
                "GETDATE()) <= 1 group by idClient order by total DESC";

            //establecer la conexion con el adaptador
            SqlDataAdapter sqlDataAdapterProperty = new SqlDataAdapter();

            //configurar el adaptador
            sqlDataAdapterProperty.SelectCommand = new SqlCommand();
            sqlDataAdapterProperty.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterProperty.SelectCommand.Connection = sqlConn;

            //definir el data set
            DataSet datasetClients = new DataSet();

            //dataset para guardar los resultados de la consulta
            sqlDataAdapterProperty.Fill(datasetClients);

            //cerrar la conexion con el adaptador
            sqlDataAdapterProperty.SelectCommand.Connection.Close();

            DataRowCollection dataRowCollection = datasetClients.Tables[0].Rows;
            List<Client> clients = new List<Client>();
            List<int> quantities = new List<int>();
            foreach (DataRow currentRow in dataRowCollection)
            {
                ClientData cd = new ClientData(this.connectionString);
                Client clientTemp = cd.getClientById(Int32.Parse(currentRow[0].ToString()));
                clients.Add(clientTemp);
                quantities.Add((int) float.Parse(currentRow[1].ToString()));
            }

            Object[] returnValues = new Object[2];
            returnValues[0] = clients;
            returnValues[1] = quantities;

            return returnValues;
        }

    }
}
