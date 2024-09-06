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
    public partial class UpdateAccount : Form
    {
        clsAccountsBusiness FindAccount;
        public UpdateAccount()
        {
            InitializeComponent();
        }
        private void _EnabledDesabledInputs(bool Value)
        {
            tbAccountBalance.Enabled = Value;
            tbClientID.Enabled = Value;
            tbCreateAccountDate.Enabled = Value;
            
        }
        private void _ClearInputs()
        {
            _EnabledDesabledInputs(false);
            btnSearch.Visible = true;
            btnClear.Visible = false;
            btnUpdateAccount.Visible = false;

            tbAccountNumber.Clear();
            tbAccountNumber.BorderColor = Color.FromArgb(213, 218, 223);

            tbPassword.Clear();
            tbPassword.BorderColor = Color.FromArgb(213, 218, 223);

            tbAccountBalance.Clear();
            tbAccountBalance.BorderColor = Color.FromArgb(213, 218, 223);

            tbClientID.Clear();
            tbClientID.BorderColor = Color.FromArgb(213, 218, 223);

            tbCreateAccountDate.Clear();
            tbCreateAccountDate.BorderColor = Color.FromArgb(213, 218, 223);

        }
        private bool _InputsEmpty()
        {
            bool Empty = true;

            if (tbClientID.Text == "")
            {
                tbClientID.BorderColor = Color.Red;
                Empty = false;
            }

            if (tbAccountBalance.Text == "")
            {
                tbAccountBalance.BorderColor = Color.Red;
                Empty = false;
            }

            return Empty;
        }
        private bool _FindAccount()
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
            FindAccount = clsAccountsBusiness.FindAccount(tbAccountNumber.Text, tbPassword.Text);

            if (FindAccount != null)
            {
                _EnabledDesabledInputs(true);
                

                tbClientID.Text = Convert.ToString(FindAccount.ClientID);
                tbAccountBalance.Text = Convert.ToString(FindAccount.AccountBalance);
                tbCreateAccountDate.Text = Convert.ToString(FindAccount.OpeningDate);
                return true;
            }
            else
            {
                MessageBox.Show($"Error In AccountNumber/Password," +
                    $" write another...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool _UpdateAccount()
        {
            if (!_InputsEmpty())
                return false;

            if (MessageBox.Show("Do you want to update this Account ?", "Sure ?",
                  MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return false;

            FindAccount.ClientID = Convert.ToInt32(tbClientID.Text);
            FindAccount.AccountBalance = Convert.ToDecimal(tbAccountBalance.Text);

            if (FindAccount.Save())
            {
                MessageBox.Show("Account updated successfully...", "Success !",
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
            if(_FindAccount())
            {
                btnSearch.Visible = false;
                btnClear.Visible = true;
                btnUpdateAccount.Visible = true;
            }
        }
        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
           if(_UpdateAccount())
            {
                _EnabledDesabledInputs(false);
                _ClearInputs();
            }
        }
    }
}
