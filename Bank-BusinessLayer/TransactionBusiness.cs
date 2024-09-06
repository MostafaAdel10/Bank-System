using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_DataAccessLayer;

namespace Bank_BusinessLayer
{
    public class clsTransactionBusiness
    {
        public enum enMode { AddNew = 0, Update = 1 }
        enMode Mode = enMode.AddNew;

        public string TransferFrom { get; set; }
        public string TransferTo { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }
        public char TransactionType { get; set; }
        public int UserID { get; set; }
        public clsTransactionBusiness()

        {
            this.TransferFrom = "";
            this.TransferTo = "";
            this.TransactionDate = DateTime.Now;
            this.Amount = -1;
            this.TransactionType = 'T';
            this.UserID = -1;
            Mode = enMode.AddNew;

        }
        private clsTransactionBusiness(string TransferFrom, string TransferTo,
            DateTime TransactionDate, decimal Amount, char TransactionType, int UserID)
        {
            this.TransferFrom = TransferFrom;
            this.TransferTo = TransferTo;
            this.TransactionDate = TransactionDate;
            this.Amount = Amount;
            this.TransactionType = TransactionType;
            this.UserID = UserID;
            Mode = enMode.Update;
        }
        public static DataTable GetTransferLog()
        {
            return clsTransactionData.GetTransferLog();
        }
        private bool _AddNewTransaction()
        {
            //Call Database layer
            return clsTransactionData.AddNewTransaction(this.TransferFrom, this.TransferTo, this.Amount,
                this.TransactionType, this.UserID);
        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTransaction())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
            }
            return false;
        }
    }
}
