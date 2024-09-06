using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Bank_DataAccessLayer;
using System.ComponentModel;

namespace Bank_BusinessLayer
{
    public class ClsClients_Business
    {
        public enum enMode { AddNew = 0, Update = 1 }
        enMode Mode = enMode.AddNew;


        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime CreateDate { get; set; }
        public string Country { get; set; }

        public ClsClients_Business()

        {
            this.ID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.Email = "";
            this.Phone = "";
            this.City = "";
            this.DateOfBirth = DateTime.Now;
            this.Country = "";

            //this.CreateDate = DateTime.Now;
            Mode = enMode.AddNew;
        }
        private ClsClients_Business(int ID, string FirstName, string LastName, string Email,
            string Phone, string City, DateTime DateOfBirth,
            string Country,DateTime CreateDate)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.City = City;
            this.DateOfBirth = DateOfBirth;
            this.Country = Country;
            this.CreateDate = CreateDate;

            Mode = enMode.Update;
        }

        public static DataTable GetAllClients()
        {
            return clsClients_DataAccess.GetAllClients();
        }
        public static bool IsClientExist(int ClientID)
        {
            return clsClients_DataAccess.IsClientExist(ClientID);
        }
        private bool _AddNewClient()
        {
            //Call Database layer
            return clsClients_DataAccess.AddNewClient(this.ID ,this.FirstName,
                this.LastName, this.Email, this.Phone,
                this.City, this.DateOfBirth, this.Country);   
        }
        public static ClsClients_Business FindClient(int ClientID)
        {
            string FirstName = "", LastName = "", Email = "", Phone = "", City = "", Country = "";
            DateTime DateOfBirth = DateTime.Now;
            DateTime CreateDate = DateTime.Now;

            if (clsClients_DataAccess.GetClientInfoByID(ClientID, ref FirstName,
                ref LastName, ref Email,ref Phone, ref City, ref DateOfBirth, ref Country,
                ref CreateDate))
            {
                return new ClsClients_Business(ClientID, FirstName, LastName, Email, Phone, City, DateOfBirth, Country, CreateDate);
            }
            else
            {
                return null;
            }
        }
        private bool _UpdateClient()
        {
            return clsClients_DataAccess.UpdateClient(this.ID, this.FirstName, 
                this.LastName, this.Email, this.Phone,this.City, this.DateOfBirth, this.Country);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewClient())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateClient();
            }
            return false;
        }
        public static bool DeleteClient(int ID)
        {
            return clsClients_DataAccess.DeleteClient(ID);
        }

    }
}
