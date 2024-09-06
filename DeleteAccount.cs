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
    public partial class DeleteAccount : Form
    {
        clsAccountsBusiness FindAccountToDelete;
        public DeleteAccount()
        {
            InitializeComponent();
        }
        private void _ClearInputs()
        {
            btnSearch.Visible = true;
            btnClear.Visible = false;
            btnDeleteAccount.Visible = false;

            tbAccountNumber.Clear();
            tbAccountNumber.BorderColor = Color.FromArgb(213, 218, 223);

            tbPassword.Clear();
            tbPassword.BorderColor = Color.FromArgb(213, 218, 223);

            tbClientID.Clear();
            tbCreatAccountDate.Clear();
            tbAccountBalance.Clear();

        }
        private bool _FindAccountToDelete()
        {
            if (tbAccountNumber.Text == "")
            {
                tbAccountNumber.BorderColor = Color.Red;
                return false;
            }
            else
            {
                tbAccountNumber.BorderColor = Color.FromArgb(213, 218, 223);
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

            FindAccountToDelete = clsAccountsBusiness.FindAccount(tbAccountNumber.Text, tbPassword.Text);

            if (FindAccountToDelete != null)
            {
                tbClientID.Text = Convert.ToString(FindAccountToDelete.ClientID);
                tbAccountBalance.Text = Convert.ToString(FindAccountToDelete.AccountBalance);
                tbCreatAccountDate.Text = Convert.ToString(FindAccountToDelete.OpeningDate);
                return true;
            }
            else
            {
                MessageBox.Show($"Error In AccountNumber/Password," +
                    $" write another...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void _DeleteAccount()
        {
            if (clsAccountsBusiness.DeleteAccount(FindAccountToDelete.AccountNumber, FindAccountToDelete.Password))
            {
                if (MessageBox.Show("Do you want to delete this Account ?", "Sure ?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                    return;

                MessageBox.Show("Account deleted successfully...", "Success !",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(" Error In AccountNumber/Password! ", "Error !",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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
            if (_FindAccountToDelete())
            {
                btnSearch.Visible = false;
                btnClear.Visible = true;
                btnDeleteAccount.Visible = true;
            }
        }
        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            _DeleteAccount();
            _ClearInputs();
        }


    }
}
