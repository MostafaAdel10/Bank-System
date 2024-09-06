using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Bank_DataAccessLayer
{
    public class clsTransactionData
    {
        public static DataTable GetTransferLog()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT TransferFrom,TransferTo,Amount,TransactionType,UserID FROM Transactions";

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
        public static bool AddNewTransaction(string TransferFrom, string TransferTo,
            decimal Amount, char TransactionType, int UserID)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Transactions (TransferFrom,TransferTo ,Amount, TransactionType,UserID)
                             VALUES (@TransferFrom,@TransferTo,@Amount, @TransactionType,@UserID);";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@TransferFrom", TransferFrom);
            command.Parameters.AddWithValue("@TransferTo", TransferTo);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@TransactionType", TransactionType);
            command.Parameters.AddWithValue("@UserID", UserID);

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
