using Bank_BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    public class clsGlobal
    {
        public struct stLoginData
        {
            public int UserID;
            public string UserName;
            public string Password;
            public int Permissions;
        }

        public static stLoginData CurrentUser = new stLoginData();
    }
}
