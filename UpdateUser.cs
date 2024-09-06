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
    public partial class UpdateUser : Form
    {
        clsUsersBusiness FindUser;
        public UpdateUser()
        {
            InitializeComponent();
        }
        private void _EnabledDesabledInputs(bool Value)
        {
            tbFirstName.Enabled = Value;
            tbLastName.Enabled = Value;
            tbEmail.Enabled = Value;
            tbPhone.Enabled = Value;

            btnEditPer.Enabled = Value;
        }
        private void _ClearInputs()
        {
            _EnabledDesabledInputs(false);
            btnSearch.Visible = true;
            btnClear.Visible = false;
            btnUpdateUser.Visible = false;

            btnEditPer.Enabled = false;

            tbFirstName.Clear();
            tbFirstName.BorderColor = Color.FromArgb(213, 218, 223);

            tbLastName.Clear();
            tbLastName.BorderColor = Color.FromArgb(213, 218, 223);

            tbEmail.Clear();
            tbEmail.BorderColor = Color.FromArgb(213, 218, 223);

            tbPermissions.Clear();
            tbPermissions.BorderColor = Color.FromArgb(213, 218, 223);

            tbPhone.Clear();
            tbPhone.BorderColor = Color.FromArgb(213, 218, 223);

            tbUserID.Clear();
            tbUsername.Clear();
            tbPassword.Clear();
            tbCreatUserDate.Clear();

        }
        private bool _InputsEmpty()
        {
            bool Empty = true;
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
            if (tbEmail.Text == "")
            {
                tbEmail.BorderColor = Color.Red;
                Empty = false;
            }
            if (tbPhone.Text == "")
            {
                tbPhone.BorderColor = Color.Red;
                Empty = false;
            }
            return Empty;
        }
        private bool _FindUser()
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

            FindUser = clsUsersBusiness.FindUser(tbUsername.Text, tbPassword.Text);

            if (FindUser != null)
            {
                _EnabledDesabledInputs(true);
               

                tbFirstName.Text = FindUser.FirstName;
                tbLastName.Text = FindUser.LastName;
                tbEmail.Text = FindUser.Email;
                tbPhone.Text = FindUser.Phone;
                tbCreatUserDate.Text = Convert.ToString(FindUser.CreateDate);
                tbUserID.Text = Convert.ToString(FindUser.ID);
                tbPermissions.Text = Convert.ToString(FindUser.Permissions);

                return true;
            }
            else
            {
                MessageBox.Show($"Error In Username/Password," +
                    $" write another...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool _UpdateUser()
        {
            if (!_InputsEmpty())
                return false;

            if (MessageBox.Show("Do you want to update this User ?", "Sure ?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return false;

            FindUser.FirstName = Convert.ToString(tbFirstName.Text);
            FindUser.LastName = Convert.ToString(tbLastName.Text);
            FindUser.Email = Convert.ToString(tbEmail.Text);
            FindUser.Phone = Convert.ToString(tbPhone.Text);
            FindUser.Permissions = Convert.ToInt32(tbPermissions.Text);


            if (FindUser.Save())
            {
                MessageBox.Show("User updated successfully...", "Success !",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ClearInputs();
                return true;
            }
            else
            {
                MessageBox.Show(" Incorrect Information", "Error !",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(_FindUser())
            {
                btnSearch.Visible = false;
                btnClear.Visible = true;
                btnUpdateUser.Visible = true;
                btnEditPer.Enabled = true;
            }
        }
        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if(_UpdateUser())
            {
                _EnabledDesabledInputs(false);
                _ClearInputs();
            }
        }
        private void btnEditPer_Click(object sender, EventArgs e)
        {
            SetPermitions permitions = new SetPermitions();
            permitions.ShowDialog();
            tbPermissions.Text = SetPermitions.GetPermitions().ToString();
        }
    }
}
