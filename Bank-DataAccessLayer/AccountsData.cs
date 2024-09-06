using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Bank_DataAccessLayer
{
    public class clsAccountsData
    {
        public static DataTable GetTotalBalances()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select ClientID , AccountNumber,AccountBalance from Accounts";

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
        public static DataTable GetAllAccounts()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Accounts";

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
        public static bool IsAccountNumberExist(string AccountNumber)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select Found = 1 from Accounts where AccountNumber = @AccountNumber ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

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
        public static bool IsPasswordExist(string Password)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select Found = 1 from Accounts where Password = @Password ";

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
        public static bool AddNewAccounts(string AccountNumber, string Password,
                                     int ClientID, decimal AccountBalance)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Accounts (AccountNumber,Password, ClientID, AccountBalance)
                             VALUES (@AccountNumber,@Password, @ClientID, @AccountBalance);";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@AccountBalance", AccountBalance);

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
        public static bool GetAccountInfoByAccountNumberAndPassword(ref int AccountID,string AccountNumber,
            string Password, ref int ClientID,ref decimal AccountBalance, ref DateTime OpeningDate)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Accounts WHERE AccountNumber = @AccountNumber and Password = @Password";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@Password", Password);


            try
            {
                Connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    //The record is found
                    isFound = true;

                    ClientID = (int)Reader["ClientID"];
                    AccountBalance = (decimal)Reader["AccountBalance"];
                    OpeningDate = (DateTime)Reader["OpeningDate"];
                    AccountID = (int)Reader["AccountID"];

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

        public static bool UpdateAccount(string AccountNumber, string Password, int ClientID, decimal AccountBalance,
              DateTime OpeningDate)
        {
            int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update Accounts 
                            set ClientID = @ClientID,
                                AccountBalance =@AccountBalance, 
                                OpeningDate =@OpeningDate
                                where AccountNumber = @AccountNumber and Password = @Password ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@AccountBalance", AccountBalance);
            command.Parameters.AddWithValue("@OpeningDate", OpeningDate);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
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
        public static bool _IsClientExistInTableAccount(int ClientID)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select Found = 1 from Accounts where ClientID = @ClientID ";

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
        public static bool DeleteAccount(string AccountNumber, string Password)
        {
            int RowAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Delete Accounts where AccountNumber = @AccountNumber and Password = @Password";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
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
