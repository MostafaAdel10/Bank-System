using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Bank_DataAccessLayer
{
    public class clsUsersData
    {
        public static bool IsUserExist(String UserName, string Password)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select Found = 1 from Users where UserName = @UserName and Password = @Password ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);

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
        public static bool IsUserNameExist(String UserName)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select Found = 1 from Users where UserName = @UserName  ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);

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
        public static bool IsUserPasswordExist(String Password)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select Found = 1 from Users where Password = @Password ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Password", Password);

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
        public static bool IsUserIDExist(int UserID)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select Found = 1 from Users where UserID = @UserID ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

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
        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Users";

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
        public static bool AddNewUser(int Permissions,int UserID,string Username, string Password,
                                     string FirstName, string LastName,string Email,string Phone)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Users (Permissions,UserID,Username, Password, FirstName,LastName,
                                          Email, Phone)
                             VALUES (@Permissions,@UserID,@Username, @Password, @FirstName,@LastName,
                                             @Email,@Phone);";

            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@Permissions", Permissions);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);

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
        public static bool GetUserInfoByUserNameAndPassword(ref int Permissions,ref int UserID, string Username,
            string Password,ref string FirstName, ref string LastName,ref string Email,
            ref string Phone, ref DateTime CreateDate)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Users WHERE Username = @Username and Password = @Password";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                Connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    //The record is found
                    isFound = true;

                    Permissions = (int)Reader["Permissions"];
                    UserID = (int)Reader["UserID"];
                    FirstName = (string)Reader["FirstName"];
                    LastName = (string)Reader["LastName"];
                    Email = (string)Reader["Email"];
                    Phone = (string)Reader["Phone"];
                    CreateDate = (DateTime)Reader["CreateDate"];

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

        public static bool UpdateUser(int Permissions,string Username, string Password, int UserID, string FirstName,
             string LastName,string Email,string Phone, DateTime CreateDate)
        {
            int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update Users 
                            set Permissions = @Permissions,
                                UserID = @UserID,
                                FirstName =@FirstName, 
                                LastName =@LastName,
                                Email = @Email,
                                Phone = @Phone,
                                CreateDate = @CreateDate
                                where Username = @Username and Password = @Password ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Permissions", Permissions);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@CreateDate", CreateDate);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);

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
        public static bool DeleteUser(string Username, string Password)
        {
            int RowAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Delete Users where Username = @Username and Password = @Password";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);

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
