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
    public class AdministratorData
    {
        private string connectionString;

        public AdministratorData(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public int insertAdministrator(Administrator administrator)
        {
            SqlConnection connection = new SqlConnection(this.connectionString);

            string sqlStoredProcedure = "PAInsert_Administrator";
            SqlCommand cmdInsert = new SqlCommand(sqlStoredProcedure, connection);

            cmdInsert.CommandType = CommandType.StoredProcedure;


            cmdInsert.Parameters.Add(new SqlParameter("@name", administrator.Name));
            cmdInsert.Parameters.Add(new SqlParameter("@lastName1", administrator.LastName_1));
            cmdInsert.Parameters.Add(new SqlParameter("@lastName2", administrator.LastName_2));
            cmdInsert.Parameters.Add(new SqlParameter("@nameUser", administrator.NameUser));
            cmdInsert.Parameters.Add(new SqlParameter("@passwordUser", administrator.PasswordUser));
            cmdInsert.Parameters.Add(new SqlParameter("@email", administrator.Email));
            SqlParameter parameterCode = new SqlParameter("@idAdministrator", SqlDbType.Int);
            parameterCode.Direction = ParameterDirection.Output;
            cmdInsert.Parameters.Add(parameterCode);

            cmdInsert.Connection.Open();
            cmdInsert.ExecuteNonQuery();


            int answer = Int32.Parse(cmdInsert.Parameters["@idAdministrator"].Value.ToString());

            cmdInsert.Connection.Close();

            return answer;
        }

        public int updateAdministrator(Administrator administrator)
        {
            SqlConnection connection = new SqlConnection(this.connectionString);

            string sqlStoredProcedure = "PAUpdate_Administrator";
            SqlCommand cmdInsert = new SqlCommand(sqlStoredProcedure, connection);

            cmdInsert.CommandType = CommandType.StoredProcedure;


            cmdInsert.Parameters.Add(new SqlParameter("@name", administrator.Name));
            cmdInsert.Parameters.Add(new SqlParameter("@lastName1", administrator.LastName_1));
            cmdInsert.Parameters.Add(new SqlParameter("@lastName2", administrator.LastName_2));
            cmdInsert.Parameters.Add(new SqlParameter("@nameUser", administrator.NameUser));
            cmdInsert.Parameters.Add(new SqlParameter("@passwordUser", administrator.PasswordUser));
            cmdInsert.Parameters.Add(new SqlParameter("@email", administrator.Email));
            cmdInsert.Parameters.Add(new SqlParameter("@idAdministrator", administrator.IdUser));
            SqlParameter parameterCode = new SqlParameter("@state", SqlDbType.Int);
            parameterCode.Direction = ParameterDirection.Output;
            cmdInsert.Parameters.Add(parameterCode);

            cmdInsert.Connection.Open();
            cmdInsert.ExecuteNonQuery();


            int answer = Int32.Parse(cmdInsert.Parameters["@state"].Value.ToString());

            cmdInsert.Connection.Close();

            return answer;
        }

        public int deleteAdministrator(int idAdministrator)
        {
            SqlConnection connection = new SqlConnection(this.connectionString);

            string sqlStoredProcedure = "PADelete_Administrator";
            SqlCommand cmdInsert = new SqlCommand(sqlStoredProcedure, connection);

            cmdInsert.CommandType = CommandType.StoredProcedure;

            cmdInsert.Parameters.Add(new SqlParameter("@idAdministrator", idAdministrator));
            SqlParameter parameterCode = new SqlParameter("@state", SqlDbType.Int);
            parameterCode.Direction = ParameterDirection.Output;
            cmdInsert.Parameters.Add(parameterCode);

            cmdInsert.Connection.Open();
            cmdInsert.ExecuteNonQuery();


            int answer = Int32.Parse(cmdInsert.Parameters["@state"].Value.ToString());

            cmdInsert.Connection.Close();

            return answer;
        }

        public int verifyExistsAdministrator(string nameUser, string passwordUser)
        {
            SqlConnection connection = new SqlConnection(this.connectionString);

            string sqlStoredProcedure = "PAExist_Administrator";
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

<<<<<<< HEAD
        public DataSet getAdministrators()
        {
            //conexion con la bd
            SqlConnection sqlConn = new SqlConnection(this.connectionString);

            //string sql
            string sqlSelect = "Select * from TAdministrator;";

            //establecer la conexion con el adaptador
            SqlDataAdapter sqlDataAdapterProperty = new SqlDataAdapter();

            //configurar el adaptador
            sqlDataAdapterProperty.SelectCommand = new SqlCommand();
            sqlDataAdapterProperty.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterProperty.SelectCommand.Connection = sqlConn;

            //definir el data set
            DataSet datasetProperties = new DataSet();

            //dataset para guardar los resultados de la consulta
            sqlDataAdapterProperty.Fill(datasetProperties, "TAdministrator");

            //cerrar la conexion con el adaptador
            sqlDataAdapterProperty.SelectCommand.Connection.Close();

            return datasetProperties;
        }
=======

>>>>>>> origin/master

    }
}
