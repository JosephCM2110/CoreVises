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

        public Object[] getTop5PhoneSaleWeek()
        {
            SqlConnection sqlConn = new SqlConnection(this.connectionString);

            //string sql
            string sqlSelect = "select top 5 TPhoneSale.idPhone, sum(TPhoneSale.quantity) as 'quantity' from TPhoneSale inner join TSale on "
                + "TPhoneSale.idSale = TSale.idSale where DATEDIFF(d, TSale.dateSale, GETDATE()) <= 8 group by idPhone order by quantity desc; ";

            //establecer la conexion con el adaptador
            SqlDataAdapter sqlDataAdapterProperty = new SqlDataAdapter();

            //configurar el adaptador
            sqlDataAdapterProperty.SelectCommand = new SqlCommand();
            sqlDataAdapterProperty.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterProperty.SelectCommand.Connection = sqlConn;

            //definir el data set
            DataSet datasetPhones = new DataSet();

            //dataset para guardar los resultados de la consulta
            sqlDataAdapterProperty.Fill(datasetPhones);

            //cerrar la conexion con el adaptador
            sqlDataAdapterProperty.SelectCommand.Connection.Close();

            DataRowCollection dataRowCollection = datasetPhones.Tables[0].Rows;
            List<Phone> phones = new List<Phone>();
            List<int> quantities = new List<int>();
            foreach (DataRow currentRow in dataRowCollection)
            {
                PhoneData pd = new PhoneData(this.connectionString);
                Phone phoneTemp = pd.getPhoneById(Int32.Parse(currentRow[0].ToString()));
                phones.Add(phoneTemp);
                quantities.Add(Int32.Parse(currentRow[1].ToString()));
            }

            Object[] returnValues = new Object[2];
            returnValues[0] = phones;
            returnValues[1] = quantities;

            return returnValues;
        }

    }
}
