using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_DataAccessLayer;
using static Bank_BusinessLayer.clsUsersBusiness;

namespace Bank_BusinessLayer
{
    public class clsLoginRegistersBusiness
    {
        public enum enMode { AddNew = 0, Update = 1 }
        enMode Mode = enMode.AddNew;

        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime DateLogin { get; set; }
        public int Permissions { get; set; }
        public clsLoginRegistersBusiness()

        {
            this.UserID = -1;
            this.UserName = "";
            this.Password = "";
            this.DateLogin = DateTime.Now;
            this.Permissions = 0;

            Mode = enMode.AddNew;
        }
        private clsLoginRegistersBusiness(int UserID, string UserName, string Password, DateTime DateLogin, int Permissions )
        {
            this.UserID = UserID;
            this.UserName = UserName;
            this.Password = Password;
            this.DateLogin = DateLogin;
            this.Permissions = Permissions;

            Mode = enMode.Update;
        }
        public static DataTable GetAllLoginRegisters()
        {
            return clsLoginRegistersData.GetAllLoginRegisters();
        }
        private bool _AddNewLoginRegisters()
        {
            //Call Database layer
            return clsLoginRegistersData.AddNewLoginRegisters(this.UserID, this.UserName,this.Password,this.Permissions);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLoginRegisters())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                //case enMode.Update:
                    //return _UpdateAccount();
            }
            return false;
        }
    }
}
