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
    public partial class FindClient : Form
    {
        public FindClient()
        {
            InitializeComponent();
        }
        private void _ClearInputs()
        {
            tbClientID.Clear();
            tbClientID.BorderColor = Color.FromArgb(213, 218, 223);
            tbFirstName.Clear();
            tbLastName.Clear();
            tbEmail.Clear();
            tbPhoneNumber.Clear();
            tbCity.Clear();
            tbCountry.Clear();
            tbCreateDate.Clear();
            tbDateOfBirth.Clear();
            btnSearch.Enabled = true;
        }
        private bool _FindClient()
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
            int.TryParse(tbClientID.Text, out int ClientID);
            ClsClients_Business FindClient = ClsClients_Business.FindClient(ClientID);

            if (FindClient != null)
            {
                tbFirstName.Text = FindClient.FirstName;
                tbLastName.Text = FindClient.LastName;
                tbEmail.Text = FindClient.Email;
                tbPhoneNumber.Text = FindClient.Phone;
                tbCity.Text = FindClient.City;
                tbCountry.Text = FindClient.Country;
                tbDateOfBirth.Text = Convert.ToString(FindClient.DateOfBirth);
                tbCreateDate.Text = Convert.ToString(FindClient.CreateDate);
                return true;
            }
            else
            {
                MessageBox.Show($"This ClientID \"{tbClientID.Text}\" was not found," +
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
            if(_FindClient())
            {
                btnSearch.Enabled = false;
            }

        }
        private void tbClientID_TextChanged(object sender, EventArgs e)
        {
            if (tbClientID.Text == "")
                tbClientID.BorderColor = Color.Red;
            else
                tbClientID.BorderColor = Color.FromArgb(213, 218, 223);
        }
    }
}
