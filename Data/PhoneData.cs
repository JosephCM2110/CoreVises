﻿using System;
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
            cmdInsert.Parameters.Add(new SqlParameter("@os", phone.OS));
            cmdInsert.Parameters.Add(new SqlParameter("@net", phone.NetworkMode));
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

            string sqlStoredProcedure = "PAUpdate_Phones";
            SqlCommand cmdInsert = new SqlCommand(sqlStoredProcedure, connection);

            cmdInsert.CommandType = CommandType.StoredProcedure;


            cmdInsert.Parameters.Add(new SqlParameter("@idBrand", phone.Brand.IdBrand));
            cmdInsert.Parameters.Add(new SqlParameter("@model", phone.Model));
            cmdInsert.Parameters.Add(new SqlParameter("@os", phone.OS));
            cmdInsert.Parameters.Add(new SqlParameter("@net", phone.NetworkMode));
            cmdInsert.Parameters.Add(new SqlParameter("@internalMemory", phone.InternalMemory));
            cmdInsert.Parameters.Add(new SqlParameter("@externalMemory", phone.ExternalMemory));
            cmdInsert.Parameters.Add(new SqlParameter("@pixels", phone.Pixels));
            cmdInsert.Parameters.Add(new SqlParameter("@flash", phone.Flash));
            cmdInsert.Parameters.Add(new SqlParameter("@resolution", phone.Resolution));
            cmdInsert.Parameters.Add(new SqlParameter("@price", phone.Price));
            cmdInsert.Parameters.Add(new SqlParameter("@quantity", phone.Quantity));
            cmdInsert.Parameters.Add(new SqlParameter("@idPhone", phone.IdPhone));
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

        public DataSet getPhones()
        {
            //conexion con la bd
            SqlConnection sqlConn = new SqlConnection(this.connectionString);

            //string sql
            string sqlSelect = "Select * from TPhone;";

            //establecer la conexion con el adaptador
            SqlDataAdapter sqlDataAdapterProperty = new SqlDataAdapter();

            //configurar el adaptador
            sqlDataAdapterProperty.SelectCommand = new SqlCommand();
            sqlDataAdapterProperty.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterProperty.SelectCommand.Connection = sqlConn;

            //definir el data set
            DataSet datasetPhones = new DataSet();

            //dataset para guardar los resultados de la consulta
            sqlDataAdapterProperty.Fill(datasetPhones, "TPhone");

            //cerrar la conexion con el adaptador
            sqlDataAdapterProperty.SelectCommand.Connection.Close();

            return datasetPhones;
        }

        public Phone getPhoneById(int idPhone)
        {
            //conexion con la bd
            SqlConnection sqlConn = new SqlConnection(this.connectionString);

            //string sql
            string sqlSelect = "Select * from TPhone where idPhone=" + idPhone;

            //establecer la conexion con el adaptador
            SqlDataAdapter sqlDataAdapterProperty = new SqlDataAdapter();

            //configurar el adaptador
            sqlDataAdapterProperty.SelectCommand = new SqlCommand();
            sqlDataAdapterProperty.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterProperty.SelectCommand.Connection = sqlConn;

            //definir el data set
            DataSet datasetPhones = new DataSet();

            //dataset para guardar los resultados de la consulta
            sqlDataAdapterProperty.Fill(datasetPhones, "TPhone");

            //cerrar la conexion con el adaptador
            sqlDataAdapterProperty.SelectCommand.Connection.Close();

            DataRowCollection dataRowCollection = datasetPhones.Tables["TPhone"].Rows;
            Phone phone = null;
            int flash;
            foreach (DataRow currentRow in dataRowCollection)
            {
                BrandData bd = new BrandData("Data Source = 163.178.107.130; Initial Catalog = KeggPhones; User Id = sqlserver; Password = saucr.12");
                Brand brandTemp = bd.getBrandById(Int32.Parse(currentRow["idBrand"].ToString()));
                if (currentRow["flash"].ToString() == "True")
                    flash = 1;
                else
                    flash = 0;
                string model = currentRow["model"].ToString();
                string os = currentRow["OS"].ToString();
                string nm = currentRow["networkMode"].ToString();
                string im = currentRow["internalMemory"].ToString();
                string exm = currentRow["externalMemory"].ToString();
                int pixels = Int32.Parse(currentRow["pixels"].ToString());
                string resol = currentRow["resolution"].ToString();
                int price = (int)Double.Parse(currentRow["price"].ToString());
                int quantity = Int32.Parse(currentRow["quantity"].ToString());
                string imgP = currentRow["imagePhone"].ToString();
                phone = new Phone(idPhone, brandTemp, model, os, nm, im, exm, pixels, flash, resol, price, quantity, imgP);
            }

            return phone;
        }

        public DataSet getPhonesLike(string word)
        {
            //conexion con la bd
            SqlConnection sqlConn = new SqlConnection(this.connectionString);
            //string sql
            string sqlSelect = "Select idPhone,TPhone.idBrand,model,OS,networkMode,internalMemory,externalMemory,pixels,flash,resolution,price,quantity,imagePhone "+
                "From TPhone INNER JOIN TBrand ON TPhone.idBrand = TBrand.idBrand Where model like '%" + word + "%'  OR name like '%" + word + "%';";

            //establecer la conexion con el adaptador
            SqlDataAdapter sqlDataAdapterProperty = new SqlDataAdapter();

            //configurar el adaptador
            sqlDataAdapterProperty.SelectCommand = new SqlCommand();
            sqlDataAdapterProperty.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterProperty.SelectCommand.Connection = sqlConn;

            //definir el data set
            DataSet datasetPhones = new DataSet();

            //dataset para guardar los resultados de la consulta
            sqlDataAdapterProperty.Fill(datasetPhones, "TPhone");

            //cerrar la conexion con el adaptador
            sqlDataAdapterProperty.SelectCommand.Connection.Close();

            return datasetPhones;
        }


    }
}
