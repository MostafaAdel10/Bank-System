using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Bank_DataAccessLayer;
using System.Security;

namespace Bank_BusinessLayer
{
    public class clsUsersBusiness
    {
     
        public enum enMode { AddNew = 0, Update = 1 }
        enMode Mode = enMode.AddNew;

        public int Permissions { get; set; }
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreateDate { get; set; }

        public clsUsersBusiness()

        {
            this.Permissions = 0;
            this.ID = -1;
            this.UserName = "";
            this.Password = "";
            this.FirstName = "";
            this.LastName = "";
            this.Email = "";
            this.Phone = "";
            this.CreateDate = DateTime.Now;
            Mode = enMode.AddNew;
        }
        private clsUsersBusiness(int Permissions ,int ID, string UserName, string Password, string FirstName,
            string LastName, string Email,string Phone,DateTime CreateDate)
        {
            this.Permissions = Permissions;
            this.ID = ID;
            this.UserName = UserName;
            this.Password = Password;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.CreateDate = CreateDate;
            Mode = enMode.Update;
        }
        public static bool IsUsersExist(String UserName, string Password)
        {
            return clsUsersData.IsUserExist(UserName, Password);
        }
        public static bool IsUserNameExist(String UserName)
        {
            return clsUsersData.IsUserNameExist(UserName);
        }
        public static bool IsUserPasswordExist(String UserName)
        {
            return clsUsersData.IsUserPasswordExist(UserName);
        }
        public static bool IsUserIDExist(int UserID)
        {
            return clsUsersData.IsUserIDExist(UserID);
        }
        public static DataTable GetAllUsers()
        {
            return clsUsersData.GetAllUsers();
        }
        private bool _AddNewUser()
        {
            //Call Database layer
            return clsUsersData.AddNewUser(this.Permissions ,this.ID, this.UserName,
                this.Password, this.FirstName, this.LastName, this.Email, this.Phone);
        }
        public static clsUsersBusiness FindUser(string Username, string Password)
        {
            int Permissions = 0;
            int UserID = -1;
            string FirstName = "", LastName = "", Email = "", Phone = "";
            DateTime CreateDate = DateTime.Now;

            if (clsUsersData.GetUserInfoByUserNameAndPassword(ref Permissions,ref UserID, Username, Password, ref FirstName,
                ref LastName, ref Email,ref Phone,ref CreateDate))
            {
                return new clsUsersBusiness(Permissions,UserID, Username, Password, FirstName, LastName, Email, Phone, CreateDate);
            }
            else
            {
                return null;
            }
        }
        private bool _UpdateUser()
        {
            return clsUsersData.UpdateUser(this.Permissions,this.UserName, this.Password,
                this.ID, this.FirstName, this.LastName,this.Email,this.Phone,this.CreateDate);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateUser();
            }
            return false;
        }
        public static bool DeleteUser(string Username, string Password)
        {
            return clsUsersData.DeleteUser(Username, Password);
        }

        

    }
}
