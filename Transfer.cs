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
    public partial class Transfer : Form
    {
        ClsClients_Business FirstClientFound;
        ClsClients_Business SecondClientFound;

        clsAccountsBusiness FirstAccountFound;
        clsAccountsBusiness SecondAccountFound;
        public Transfer()
        {
            InitializeComponent();
        }
        private bool _CheckInputs()
        {
            bool Empty = false;

            if (tbAccountNumberFrom.Text == "")
            {
                tbAccountNumberFrom.BorderColor = Color.Red;

                if (!Empty)
                    Empty = true;

            }
            if (tbPasswordFrom.Text == "")
            {
                tbPasswordFrom.BorderColor = Color.Red;

                if (!Empty)
                    Empty = true;

            }

            if (tbAccountNumberTo.Text == "")
            {
                tbAccountNumberTo.BorderColor = Color.Red;
                if (!Empty)
                    Empty = true;
            }
            if (tbPasswordTo.Text == "")
            {
                tbPasswordTo.BorderColor = Color.Red;
                if (!Empty)
                    Empty = true;
            }

            return Empty;
        }
        private void _ClearInputs()
        {
            btnSearch.Visible = true;
            btnTransfer.Visible = false;
            btnClear.Visible = false;

            tbTransferAmount.Enabled = false;
            tbTransferAmount.Clear();

            tbAccountNumberTo.Clear();
            tbAccountNumberTo.BorderColor = Color.FromArgb(213, 218, 223);

            tbPasswordTo.Clear();
            tbPasswordTo.BorderColor = Color.FromArgb(213, 218, 223);

            tbAccountNumberFrom.Clear();
            tbAccountNumberFrom.BorderColor = Color.FromArgb(213, 218, 223);

            tbPasswordFrom.Clear();
            tbPasswordFrom.BorderColor = Color.FromArgb(213, 218, 223);

            tbFirstName.Clear();
            tbFirstNameTo.Clear();

            tbLastName.Clear();
            tbLastNameTo.Clear();

            tbPhoneNumber.Clear();
            tbPhoneNumberTo.Clear();

            tbEmail.Clear();
            tbEmailTo.Clear();

            tbCity.Clear();
            tbCityTo.Clear();

            tbCountry.Clear();
            tbCountryTo.Clear();

            tbBalance.Clear();
            tbBalanceTo.Clear();

            tbClientID.Clear();
            tbClientIDTo.Clear();

            tbAccountNumberFrom.Focus();
        }



        private bool _FindFirstAccount()
        {
            if (tbAccountNumberFrom.Text == "")
            {
                tbAccountNumberFrom.BorderColor = Color.Red;
                return false;
            }
            else
            {
                tbAccountNumberFrom.BorderColor = Color.FromArgb(213, 218, 223);
            }
            if (tbPasswordFrom.Text == "")
            {
                tbPasswordFrom.BorderColor = Color.Red;
                return false;
            }
            else
            {
                tbPasswordFrom.BorderColor = Color.FromArgb(213, 218, 223);
            }

            FirstAccountFound = clsAccountsBusiness.FindAccount(tbAccountNumberFrom.Text, tbPasswordFrom.Text);

            if (FirstAccountFound != null)
            {
                tbClientID.Text = Convert.ToString(FirstAccountFound.ClientID);
                tbBalance.Text = Convert.ToString(FirstAccountFound.AccountBalance);
                return true;
            }
            else
            {
                MessageBox.Show($"Error In AccountNumber/Password," +
                    $" write another...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool _FindSecondAccount()
        {
            if (tbAccountNumberTo.Text == "")
            {
                tbAccountNumberTo.BorderColor = Color.Red;
                return false;
            }
            else
            {
                tbAccountNumberTo.BorderColor = Color.FromArgb(213, 218, 223);
            }
            if (tbPasswordTo.Text == "")
            {
                tbPasswordTo.BorderColor = Color.Red;
                return false;
            }
            else
            {
                tbPasswordTo.BorderColor = Color.FromArgb(213, 218, 223);
            }

            SecondAccountFound = clsAccountsBusiness.FindAccount(tbAccountNumberTo.Text, tbPasswordTo.Text);

            if (SecondAccountFound != null)
            {
                tbClientIDTo.Text = Convert.ToString(SecondAccountFound.ClientID);
                tbBalanceTo.Text = Convert.ToString(SecondAccountFound.AccountBalance);
                return true;
            }
            else
            {
                MessageBox.Show($"Error In AccountNumber/Password," +
                    $" write another...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool _FindFirstClient()
        {
            if (tbClientID.Text == "")
            {
                tbClientID.BorderColor = Color.Red;
                return false;
            }
            else
            {
                tbClientID.BorderColor = Color.FromArgb(213, 218, 223);
            }
            FirstClientFound = ClsClients_Business.FindClient(FirstAccountFound.ClientID);

            if (FirstClientFound != null)
            {
                tbFirstName.Text = FirstClientFound.FirstName;
                tbLastName.Text = FirstClientFound.LastName;
                tbEmail.Text = FirstClientFound.Email;
                tbPhoneNumber.Text = FirstClientFound.Phone;
                tbCity.Text = FirstClientFound.City;
                tbCountry.Text = FirstClientFound.Country;
                return true;
            }
            else
            {
                MessageBox.Show($"This ClientID \"{tbClientID.Text}\" was not found," +
                    $" write another...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool _FindSecondClient()
        {
            if (tbClientIDTo.Text == "")
            {
                tbClientIDTo.BorderColor = Color.Red;
                return false;
            }
            else
            {
                tbClientIDTo.BorderColor = Color.FromArgb(213, 218, 223);
            }
            int.TryParse(tbClientIDTo.Text, out int ClientID);
            SecondClientFound = ClsClients_Business.FindClient(SecondAccountFound.ClientID);

            if (FirstClientFound != null)
            {
                tbFirstNameTo.Text = SecondClientFound.FirstName;
                tbLastNameTo.Text = SecondClientFound.LastName;
                tbEmailTo.Text = SecondClientFound.Email;
                tbPhoneNumberTo.Text = SecondClientFound.Phone;
                tbCityTo.Text = SecondClientFound.City;
                tbCountryTo.Text = SecondClientFound.Country;
                return true;
            }
            else
            {
                MessageBox.Show($"This ClientID \"{tbClientIDTo.Text}\" was not found," +
                    $" write another...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool _TransferBalance()
        {
            if (tbTransferAmount.Text == "")
            {
                tbTransferAmount.BorderColor = Color.Red;
                return false;
            }

            if (Convert.ToDecimal(tbTransferAmount.Text) > FirstAccountFound.AccountBalance)
            {
                MessageBox.Show("The Amount Is Out Of Your Range !", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbTransferAmount.BorderColor = Color.Red;
                return false;
            }

            if (MessageBox.Show("Do you want to Preform this transaction ?", "Sure ?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return false;

            if(FirstAccountFound.AccountNumber == SecondAccountFound.AccountNumber)
            {
                MessageBox.Show("You cannot make a Transfer Balance to the same Account Number ", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                FirstAccountFound.AccountBalance -= Convert.ToDecimal(tbTransferAmount.Text);
                SecondAccountFound.AccountBalance += Convert.ToDecimal(tbTransferAmount.Text);
                if(FirstAccountFound.Save() && SecondAccountFound.Save())
                {
                    MessageBox.Show("Amount Transfer successfully...", "Success !", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    return true;
                }
                else
                    return false;
            }

        }
        private void _TransferLog()
        {
            clsTransactionBusiness TransferLog1 = new clsTransactionBusiness();
            TransferLog1.TransferFrom = FirstAccountFound.AccountNumber;
            TransferLog1.TransferTo = SecondAccountFound.AccountNumber;
            TransferLog1.TransactionType = 'T';
            TransferLog1.Amount = Convert.ToDecimal(tbTransferAmount.Text);
            TransferLog1.UserID = 1;
            if(TransferLog1.Save())
            {
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
            if (_CheckInputs())
                return;

            if (_FindFirstAccount() && _FindSecondAccount())
            {
                _FindFirstClient();
                _FindSecondClient();

                tbTransferAmount.Enabled = true;

                btnSearch.Visible = false;
                btnTransfer.Visible = true;
                btnClear.Visible = true;
            }
        }
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if(_TransferBalance())
            {
                _TransferLog();
                btnSearch.Visible = true;
                btnTransfer.Visible = false;
                btnClear.Visible = false;
                _ClearInputs();
            }
        }

    }
}
