using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Bank_DataAccessLayer
{
    public class clsLoginRegistersData
    {
        public static DataTable GetAllLoginRegisters()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM LoginRegisters";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static bool AddNewLoginRegisters(int UserID, string UserName,string Passwored,int Permissions)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO LoginRegisters (UserID,UserName, Passwored,Permissions)
                             VALUES (@UserID,@UserName, @Passwored,@Permissions);";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Passwored", Passwored);
            command.Parameters.AddWithValue("@Permissions", Permissions);

            try
            {
                Connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                Connection.Close();
            }
            return RowsAffected > 0;
        }


    }
}
