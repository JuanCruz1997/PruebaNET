using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public static class dbHelper
    {
        public static SqlDataReader GetReader(string query)
        {
            SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.AppSettings["CONEXION"]);
            try
            {

                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.CommandType = CommandType.Text;
                return sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                throw new Exception("Error en la consulta");
            }
            finally
            {
                sqlConnection.Close();
            }


        }

        public static int Execute(string query)
        {
            SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.AppSettings["CONEXION"]);
            int result = 0;
            try
            {


                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.CommandType = CommandType.Text;
                result = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                throw new Exception("Error en la consulta");
            }
            finally
            {
                sqlConnection.Close();
            }

            return result;
        }
    }

}

