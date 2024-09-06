using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_DataAccessLayer;


namespace Bank_BusinessLayer
{
    public class clsAccountsBusiness
    {
        public enum enMode { AddNew = 0, Update = 1 }
        enMode Mode = enMode.AddNew;
        public int AccountID { get; set; }
        public string AccountNumber { get; set; }
        public string Password { get; set; }
        public int ClientID { get; set; }
        public decimal AccountBalance { get; set; }
        public DateTime OpeningDate { get; set; }

        public clsAccountsBusiness()

        {
            this.AccountID = -1;
            this.AccountNumber = "";
            this.Password = "";
            this.ClientID = -1;
            this.AccountBalance = -1;
            this.OpeningDate = DateTime.Now;

            Mode = enMode.AddNew;
        }
        private clsAccountsBusiness(int AccountID, string AccountNumber, string Password, 
            int ClientID,decimal AccountBalance, DateTime OpeningDate)
        {
            this.AccountID = AccountID;
            this.AccountNumber = AccountNumber;
            this.Password = Password;
            this.ClientID = ClientID;
            this.AccountBalance = AccountBalance;
            this.OpeningDate = OpeningDate;
            Mode = enMode.Update;
        }
        public static DataTable GetTotalBalances()
        {
            return clsAccountsData.GetTotalBalances();
        }
        public static DataTable GetAllAccounts()
        {
            return clsAccountsData.GetAllAccounts();
        }
        public static bool IsAccountNumberExist(string AccountNumber)
        {
            return clsAccountsData.IsAccountNumberExist(AccountNumber);
        }
        public static bool IsPasswordExist(string Password)
        {
            return clsAccountsData.IsPasswordExist(Password);
        }
        private bool _AddNewAccounts()
        {
            //Call Database layer
            return clsAccountsData.AddNewAccounts(this.AccountNumber, this.Password,
                this.ClientID, this.AccountBalance);
        }
        public static clsAccountsBusiness FindAccount(string AccountNumber,string Password)
        {
            int AccountID = -1;
            int ClientID = -1;
            decimal AccountBalance = -1;
            DateTime OpeningDate = DateTime.Now;

            if (clsAccountsData.GetAccountInfoByAccountNumberAndPassword(ref AccountID, AccountNumber, 
                Password, ref ClientID, ref AccountBalance, ref OpeningDate))
            {
                return new clsAccountsBusiness(AccountID, AccountNumber, Password,ClientID, AccountBalance, OpeningDate);
            }
            else
            {
                return null;
            }
        }
        private bool _UpdateAccount()
        {
            return clsAccountsData.UpdateAccount(this.AccountNumber, this.Password,
                this.ClientID, this.AccountBalance, this.OpeningDate);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewAccounts())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateAccount();
            }
            return false;
        }
        public static bool _IsClientExistInTableAccount(int ClientID)
        {
           return clsAccountsData._IsClientExistInTableAccount(ClientID);
        }
        public static bool DeleteAccount(string AccountNumber, string Password)
        {
            return clsAccountsData.DeleteAccount(AccountNumber, Password);
        }
    }
}
