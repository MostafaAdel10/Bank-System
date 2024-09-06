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

namespace BankProject
{
    public partial class DeleteUser : Form
    {
        clsUsersBusiness FindUserToDelete;
        public DeleteUser()
        {
            InitializeComponent();
        }
        private void _ClearInputs()
        {
            btnSearch.Visible = true;
            btnClear.Visible = false;
            btnDeleteUser.Visible = false;

            tbUsername.Clear();
            tbUsername.BorderColor = Color.FromArgb(213, 218, 223);

            tbPassword.Clear();
            tbPassword.BorderColor = Color.FromArgb(213, 218, 223);

            tbFirstName.Clear();
            tbLastName.Clear();
            tbEmail.Clear();
            tbPhone.Clear();
            tbUserID.Clear();
            tbCreatUserDate.Clear();
            tbPermissions.Clear();

        }
        private bool _FindUserToDelete()
        {
            if (tbUsername.Text == "")
            {
                tbUsername.BorderColor = Color.Red;
                return false;
            }
            else
            {
                tbUsername.BorderColor = Color.FromArgb(213, 218, 223);
            }
            if (tbPassword.Text == "")
            {
                tbPassword.BorderColor = Color.Red;
                return false;
            }
            else
            {
                tbPassword.BorderColor = Color.FromArgb(213, 218, 223);
            }
            FindUserToDelete = clsUsersBusiness.FindUser(tbUsername.Text, tbPassword.Text);

            if (FindUserToDelete != null)
            {
                tbFirstName.Text = FindUserToDelete.FirstName;
                tbLastName.Text = FindUserToDelete.LastName;
                tbEmail.Text = FindUserToDelete.Email;
                tbPhone.Text = FindUserToDelete.Phone;
                tbUserID.Text = Convert.ToString(FindUserToDelete.ID);
                tbCreatUserDate.Text = Convert.ToString(FindUserToDelete.CreateDate);
                tbPermissions.Text = Convert.ToString(FindUserToDelete.Permissions);
                return true;
            }
            else
            {
                MessageBox.Show($"Error In UserName/Password," +
                    $" write another...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void _DeleteAccount()
        {
            

            if (clsUsersBusiness.DeleteUser(FindUserToDelete.UserName, FindUserToDelete.Password))
            {
                if (MessageBox.Show("Do you want to delete this User ?", "Sure ?",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                    return;

                MessageBox.Show("User deleted successfully...", "Success !",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(" Error In Username/Password! ", "Error !",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            _ClearInputs();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (_FindUserToDelete())
            {
                btnSearch.Visible = false;
                btnClear.Visible = true;
                btnDeleteUser.Visible = true;
            }
        }
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            _DeleteAccount();
            _ClearInputs();
        }


    }
}
