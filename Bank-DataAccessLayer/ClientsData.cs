using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Bank_DataAccessLayer
{
    public class clsClients_DataAccess
    {
        public static DataTable GetAllClients()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Clients";

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
        public static bool AddNewClient(int ClientID, string FirstName, string LastName, string Email,
             string Phone, string City, DateTime DateOfBirth,string Country)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Clients (ClientID,FirstName, LastName, Email, Phone,
                           City,DateOfBirth, Country)
                             VALUES (@ClientID,@FirstName, @LastName, @Email, @Phone, @City,@DateOfBirth,
                                     @Country);";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@City", City);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Country", Country);
            //command.Parameters.AddWithValue("@CreatDate", CountryID);


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
        public static bool IsClientExist(int ClientID)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select Found = 1 from Clients where ClientID = @ClientID ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);

            try
            {
                connection.Open();
                //SqlDataReader reader = command.ExecuteReader();
                //isExist = reader.HasRows;
                //reader.Close();

                object Result = command.ExecuteScalar();
                if (Result != null)
                {
                    isExist = true;
                }
                else
                {
                    isExist = false;
                }
            }
            catch (Exception ex)
            {
                isExist = false;
            }
            finally
            {
                connection.Close();
            }
            return isExist;
        }
        public static bool UpdateClient(int ClientID, string FirstName, string LastName, string Email,
             string Phone, string City, DateTime DateOfBirth, string Country)
        {
            int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update Clients 
                            set FirstName = @FirstName,
                                LastName =@LastName, 
                                Email =@Email, 
                                Phone=@Phone, 
                                City=@City,
                                DateOfBirth=@DateOfBirth,
                                Country =@Country
                                where ClientID = @ClientID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@City", City);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Country", Country);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return RowsAffected > 0;
        }

        public static bool GetClientInfoByID(int ClientID, ref string FirstName, 
            ref string LastName, ref string Email,
            ref string Phone, ref string City, ref DateTime DateOfBirth, 
            ref string Country, ref DateTime CreateDate)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Clients WHERE ClientID = @ClientID";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    //The record is found
                    isFound = true;

                    FirstName = (string)Reader["FirstName"];
                    LastName = (string)Reader["LastName"];
                    Email = (string)Reader["Email"];
                    Phone = (string)Reader["Phone"];
                    City = (string)Reader["City"];
                    DateOfBirth = (DateTime)Reader["DateOfBirth"];
                    CreateDate = (DateTime)Reader["CreateDate"];
                    Country = (string)Reader["Country"];
                }
                else
                {
                    isFound = false;
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                Connection.Close();
            }
            return isFound;
        }
        public static bool DeleteClient(int ClientID)
        {
            int RowAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Delete Clients where ClientID = @ClientID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);

            try
            {
                connection.Open();
                RowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return RowAffected > 0;
        }
    }
}
