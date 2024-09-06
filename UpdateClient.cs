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
    public partial class UpdateClient : Form
    {
        ClsClients_Business FindClient;
        public UpdateClient()
        {
            InitializeComponent();
        }
        
        private void _EnabledDesabledInputs(bool Value)
        {
            tbFirstName.Enabled = Value;
            tbLastName.Enabled = Value;
            tbPhoneNumber.Enabled = Value;
            tbEmail.Enabled = Value;
            tbCity.Enabled = Value;
            tbCountry.Enabled = Value;
            tbDateOfBirth.Enabled = Value;
            tbCreateDate.Enabled = Value;
        }
        private void _ClearInputs()
        {
            _EnabledDesabledInputs(false);
            btnSearch.Visible = true;
            btnClear.Visible = false;
            btnUpdateClient.Visible = false;

            tbClientID.Clear();
            tbClientID.BorderColor = Color.FromArgb(213, 218, 223);

            tbFirstName.Clear();
            tbFirstName.BorderColor = Color.FromArgb(213, 218, 223);

            tbLastName.Clear();
            tbLastName.BorderColor = Color.FromArgb(213, 218, 223);

            tbPhoneNumber.Clear();
            tbPhoneNumber.BorderColor = Color.FromArgb(213, 218, 223);

            tbEmail.Clear();
            tbEmail.BorderColor = Color.FromArgb(213, 218, 223);

            tbCity.Clear();
            tbCity.BorderColor = Color.FromArgb(213, 218, 223);

            tbCountry.Clear();
            tbCountry.BorderColor = Color.FromArgb(213, 218, 223);

            tbDateOfBirth.Clear();
            tbDateOfBirth.BorderColor = Color.FromArgb(213, 218, 223);

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

            if (tbPhoneNumber.Text == "")
            {
                tbPhoneNumber.BorderColor = Color.Red;
                Empty = false;
            }

            if (tbEmail.Text == "")
            {
                tbEmail.BorderColor = Color.Red;
                Empty = false;
            }

            if (tbCity.Text == "")
            {
                tbCity.BorderColor = Color.Red;
                Empty = false;
            }

            if (tbCountry.Text == "")
            {
                tbCountry.BorderColor = Color.Red;
                Empty = false;
            }

            if (tbDateOfBirth.Text == "")
            {
                tbDateOfBirth.BorderColor = Color.Red;
                Empty = false;
            }
            return Empty;
        }
        private bool _FindClient()
        {
            if (tbClientID.Text == "")
            {
                tbFirstName.BorderColor = Color.Red;
                return false;
            }
            else
            {
                tbClientID.BorderColor = Color.FromArgb(213, 218, 223);
            }

            int.TryParse(tbClientID.Text, out int ClientID);

            FindClient = ClsClients_Business.FindClient(ClientID);

            if (FindClient != null)
            {
                _EnabledDesabledInputs(true);
                

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
        private bool _UpdateClient()
        {
            if (!_InputsEmpty())
                return false;

            if (MessageBox.Show("Do you want to update this client ?", "Sure ?",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return false;

            FindClient.FirstName = tbFirstName.Text;
            FindClient.LastName = tbLastName.Text;
            FindClient.Email = tbEmail.Text;
            FindClient.Phone = tbPhoneNumber.Text;
            FindClient.City = tbCity.Text;
            FindClient.Country = tbCountry.Text;
            FindClient.DateOfBirth = Convert.ToDateTime(tbDateOfBirth.Text);

            if (FindClient.Save())
            {
                MessageBox.Show("Client updated successfully...", "Success !",
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
            if(_FindClient())
            {
                btnSearch.Visible = false;
                btnClear.Visible = true;
                btnUpdateClient.Visible = true;
            }
        }
        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            if(_UpdateClient())
            {
                _EnabledDesabledInputs(false);
                _ClearInputs();
            }
        }


    }
}
