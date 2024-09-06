using Bank_BusinessLayer;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankProject
{
    public partial class AddUser : Form
    {
        clsUsersBusiness User1;
        public AddUser()
        {
            InitializeComponent();
        }
        private void _ClearInputs()
        {
            tbID.Clear();
            tbID.BorderColor = Color.FromArgb(213, 218, 223);

            tbFirstName.Clear();
            tbFirstName.BorderColor = Color.FromArgb(213, 218, 223);

            tbLastName.Clear();
            tbLastName.BorderColor = Color.FromArgb(213, 218, 223);

            tbPhoneNumber.Clear();
            tbPhoneNumber.BorderColor = Color.FromArgb(213, 218, 223);

            tbEmail.Clear();
            tbEmail.BorderColor = Color.FromArgb(213, 218, 223);

            tbUserName.Clear();
            tbUserName.BorderColor = Color.FromArgb(213, 218, 223);

            tbPassword.Clear();
            tbPassword.BorderColor = Color.FromArgb(213, 218, 223);
        }
        private bool _InputsEmpty()
        {
            bool Empty = true;

            if (tbID.Text == "")
            {
                tbID.BorderColor = Color.Red;
                Empty = false;
            }

            if (tbFirstName.Text == "")
            {
                tbFirstName.BorderColor = Color.Red;
                Empty = false;
            }

            if (tbLastName.Text == "")
            {
                tbLastName.BorderColor = Color.Red;
                Empty = false;
            }

            if (tbPhoneNumber.Text == "")
            {
                tbPhoneNumber.BorderColor = Color.Red;
                Empty = false;
            }

            if (tbEmail.Text == "")
            {
                tbEmail.BorderColor = Color.Red;
                Empty = false;
            }

            if (tbUserName.Text == "")
            {
                tbUserName.BorderColor = Color.Red;
                Empty = false;
            }

            if (tbPassword.Text == "")
            {
                tbPassword.BorderColor = Color.Red;
                Empty = false;
            }

            return Empty;
        }
        private void _AddNewUser()
        {
            if (!_InputsEmpty())
                return;

            int.TryParse(tbID.Text, out int id);
            User1 = new clsUsersBusiness();

            if (clsUsersBusiness.IsUserIDExist(id))
            {
                MessageBox.Show("The ID already exists, write another...",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (clsUsersBusiness.IsUserNameExist(tbUserName.Text))
            {
                MessageBox.Show("The Username already exists, write another...",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (clsUsersBusiness.IsUserPasswordExist(tbPassword.Text))
            {
                MessageBox.Show("The Password already exists, write another...",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("Do you want to add this User ?", "Sure ?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                    return;

                User1.ID = id;
                User1.UserName = tbUserName.Text;
                User1.Password = tbPassword.Text;
                User1.FirstName = tbFirstName.Text;
                User1.LastName = tbLastName.Text;
                User1.Email = tbEmail.Text;
                User1.Phone = tbPhoneNumber.Text;
                User1.Permissions = SetPermitions.GetPermitions();

                
                if (User1.Save())
                {
                    MessageBox.Show("The User has been added successfully...", "Success !",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetPermitions.Permitions = null;
                    _ClearInputs();
                }
                else
                {
                    MessageBox.Show(" Incorrect Information", "Error !",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            _ClearInputs();
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            _AddNewUser();
        }

        private void btnPermitions_Click(object sender, EventArgs e)
        {
            SetPermitions permitions = new SetPermitions();
            permitions.ShowDialog();
        }
    }
}
