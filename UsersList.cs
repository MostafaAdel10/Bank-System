using Bank_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_BusinessLayer;

namespace BankProject
{
    public partial class UsersList : Form
    {
        public UsersList()
        {
            InitializeComponent();
        }
        private void _RefreshUsersList()
        {
            UsersListGrid.DataSource = clsUsersBusiness.GetAllUsers();
        }

        private void UsersList_Load(object sender, EventArgs e)
        {
            _RefreshUsersList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
