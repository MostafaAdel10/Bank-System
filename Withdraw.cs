﻿using Bank_BusinessLayer;
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
    public partial class Withdraw : Form
    {
        clsAccountsBusiness FindAccountAndClient;
        public Withdraw()
        {
            InitializeComponent();
        }
        private void _ClearInputs()
        {
            btnSearch.Visible = true;
            btnWithdraw.Visible = false;
            tbWithdrawAmount.Enabled = false;

            tbWithdrawAmount.Clear();
            tbWithdrawAmount.BorderColor = Color.FromArgb(213, 218, 223);

            tbAccountNumber.Clear();
            tbAccountNumber.BorderColor = Color.FromArgb(213, 218, 223);

            tbPassword.Clear();
            tbPassword.BorderColor = Color.FromArgb(213, 218, 223);

            tbBalance.Clear();
            tbBalance.BorderColor = Color.FromArgb(213, 218, 223);

            tbFirstName.Clear();
            tbFirstName.BorderColor = Color.FromArgb(213, 218, 223);

            tbLastName.Clear();
            tbLastName.BorderColor = Color.FromArgb(213, 218, 223);

            tbPhoneNum.Clear();
            tbPhoneNum.BorderColor = Color.FromArgb(213, 218, 223);

            tbEmail.Clear();
            tbEmail.BorderColor = Color.FromArgb(213, 218, 223);

            tbCity.Clear();
            tbCity.BorderColor = Color.FromArgb(213, 218, 223);

            tbCountry.Clear();
            tbCountry.BorderColor = Color.FromArgb(213, 218, 223);

            tbClientID.Clear();
            tbClientID.BorderColor = Color.FromArgb(213, 218, 223);

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

            FindAccountAndClient = clsAccountsBusiness.FindAccount(tbAccountNumber.Text, tbPassword.Text);

            if (FindAccountAndClient != null)
            {
                tbBalance.Text = Convert.ToString(FindAccountAndClient.AccountBalance);
                tbClientID.Text = Convert.ToString(FindAccountAndClient.ClientID);
                return true;
            }
            else
            {
                MessageBox.Show($"Error In AccountNumber/Password," +
                    $" write another...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool _FindClient()
        {

            ClsClients_Business FindClientA = ClsClients_Business.FindClient(FindAccountAndClient.ClientID);

            if (FindClientA != null)
            {
                tbFirstName.Text = FindClientA.FirstName;
                tbLastName.Text = FindClientA.LastName;
                tbEmail.Text = FindClientA.Email;
                tbPhoneNum.Text = FindClientA.Phone;
                tbCity.Text = FindClientA.City;
                tbCountry.Text = FindClientA.Country;
                return true;
            }
            return false;
        }
        private bool _WithdrawBalance()
        {
            if (tbWithdrawAmount.Text == "")
            {
                tbWithdrawAmount.BorderColor = Color.Red;
                return false;
            }
            if (Convert.ToDecimal(tbWithdrawAmount.Text) > FindAccountAndClient.AccountBalance)
            {
                MessageBox.Show("The Amount is out of your range !", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbWithdrawAmount.BorderColor = Color.Red;
                return false;
            }

            if (MessageBox.Show("Do you want to Preform this transaction ?", "Sure ?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return false;

            FindAccountAndClient.AccountBalance -= Convert.ToDecimal(tbWithdrawAmount.Text);
            if (FindAccountAndClient.Save())
            {

                    MessageBox.Show("Balance Withdraw successfully...", "Success !",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
            }
            else
            {
                MessageBox.Show("Transaction Failed!", "Error !",
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
            if (_FindAccount())
            {
                tbWithdrawAmount.Enabled = true;
                _FindClient();
                btnSearch.Visible = false;
                btnWithdraw.Visible = true;
                btnClear.Visible = true;
            }
        }
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (_WithdrawBalance())
            {
                btnSearch.Visible = false;
                btnWithdraw.Visible = true;
                _ClearInputs();
            }
        }
        private void btnWithdraw_TextChanged(object sender, EventArgs e)
        {
            if (tbWithdrawAmount.Text == "")
                tbWithdrawAmount.BorderColor = Color.Red;
            else
                tbWithdrawAmount.BorderColor = Color.FromArgb(213, 218, 223);
        }


    }
}
