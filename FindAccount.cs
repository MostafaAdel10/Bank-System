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
    public partial class FindAccount : Form
    {
        public FindAccount()
        {
            InitializeComponent();
        }
        private void _ClearInputs()
        {
            tbAccountNumber.Clear();
            tbAccountNumber.BorderColor = Color.FromArgb(213, 218, 223);

            tbPassword.Clear();
            tbPassword.BorderColor = Color.FromArgb(213, 218, 223);
            tbCreatAccountDate.Clear();
            tbClientID.Clear();
            tbAccountBalance.Clear();
            btnSearch.Enabled = true;
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

            clsAccountsBusiness FindAccount = clsAccountsBusiness.FindAccount(tbAccountNumber.Text, tbPassword.Text);

            if (FindAccount != null)
            {
                tbClientID.Text = Convert.ToString(FindAccount.ClientID);
                tbAccountBalance.Text = Convert.ToString(FindAccount.AccountBalance);
                tbCreatAccountDate.Text = Convert.ToString(FindAccount.OpeningDate);
                return true;
            }
            else
            {
                MessageBox.Show($"Error In AccountNumber/Password," +
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
            if(_FindAccount())
            {
                btnSearch.Enabled = false;
            }
        }
    }
}
