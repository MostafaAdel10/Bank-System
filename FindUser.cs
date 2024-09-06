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
    public partial class FindUser : Form
    {
        public FindUser()
        {
            InitializeComponent();
        }
        private void _ClearInputs()
        {
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
            tbUserPermission.Clear();
            btnSearch.Enabled = true;
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
            clsUsersBusiness FindUser = clsUsersBusiness.FindUser(tbUsername.Text, tbPassword.Text);

            if (FindUser != null)
            {
                tbFirstName.Text = FindUser.FirstName;
                tbLastName.Text = FindUser.LastName;
                tbEmail.Text = FindUser.Email;
                tbPhone.Text = FindUser.Phone;
                tbUserID.Text = Convert.ToString(FindUser.ID);
                tbCreatUserDate.Text = Convert.ToString(FindUser.CreateDate);
                tbUserPermission.Text = Convert.ToString(FindUser.Permissions);
                return true;
            }
            else
            {
                MessageBox.Show($"Error In UserName/Password," +
                    $" write another...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                btnSearch.Enabled = false;
            }
            
        }
    }
}
