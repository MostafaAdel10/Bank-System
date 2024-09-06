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
using static System.Net.Mime.MediaTypeNames;

namespace BankProject
{
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void _ClearInputs()
        {
            tbID.Clear();
            tbID.BorderColor = Color.FromArgb(213, 218, 223);

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

            if (tbID.Text == "")
            {
                tbID.BorderColor = Color.Red;
                Empty = false;
            }

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
        private void _AddNewClient()
        {
            if (!_InputsEmpty())
                return;

            int.TryParse(tbID.Text, out int id);

            ClsClients_Business Client1 = new ClsClients_Business();

            if (ClsClients_Business.IsClientExist(id))
            {
                MessageBox.Show("The ClientID already exists, write another...",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("Do you want to add this client ?", "Sure ?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                    return;

                Client1.ID = id;
                Client1.FirstName = tbFirstName.Text;
                Client1.LastName = tbLastName.Text;
                Client1.Email = tbEmail.Text;
                Client1.Phone = tbPhoneNumber.Text;
                Client1.City = tbCity.Text;
                Client1.Country = tbCountry.Text;
                Client1.DateOfBirth = Convert.ToDateTime(tbDateOfBirth.Text);
                if (Client1.Save())
                {
                    MessageBox.Show("The client has been added successfully...", "Success !",
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
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            _AddNewClient();
        }

    }
}
