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
    public partial class AddAccount : Form
    {
        public AddAccount()
        {
            InitializeComponent();
        }
        private void _ClearInputs()
        {
            tbAccountNumber.Clear();
            tbAccountNumber.BorderColor = Color.FromArgb(213, 218, 223);

            tbPassword.Clear();
            tbPassword.BorderColor = Color.FromArgb(213, 218, 223);

            tbClientID.Clear();
            tbClientID.BorderColor = Color.FromArgb(213, 218, 223);

            tbAccountBalance.Clear();
            tbAccountBalance.BorderColor = Color.FromArgb(213, 218, 223);

        }
        private bool _InputsEmpty()
        {
            bool Empty = true;

            if (tbAccountNumber.Text == "")
            {
                tbAccountNumber.BorderColor = Color.Red;
                Empty = false;
            }

            if (tbPassword.Text == "")
            {
                tbPassword.BorderColor = Color.Red;
                Empty = false;
            }

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
        private void _AddNewAccount()
        {
            if (!_InputsEmpty())
                return;

            int.TryParse(tbClientID.Text, out int ClientID);
            clsAccountsBusiness Account1 = new clsAccountsBusiness();

            if (clsAccountsBusiness.IsAccountNumberExist(tbAccountNumber.Text))
            {
                MessageBox.Show("The Account Number already exists, write another...",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (clsAccountsBusiness.IsPasswordExist(tbPassword.Text))
            {
                MessageBox.Show("The Password already exists, write another...",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!ClsClients_Business.IsClientExist(ClientID))
            {
                MessageBox.Show("The ClientID does not exist, Check the Client...",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("Do you want to add this Account ?", "Sure ?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                    return;
                Account1.AccountNumber = tbAccountNumber.Text;
                Account1.Password = tbPassword.Text;
                Account1.ClientID = ClientID;
                Account1.AccountBalance = Convert.ToDecimal(tbAccountBalance.Text);

                if (Account1.Save())
                {
                    MessageBox.Show("The Account has been added successfully...", "Success !",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            _AddNewAccount();
        }
    }
}
