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
    public partial class DeleteClient : Form
    {
        ClsClients_Business FindClientToDelete;
        public DeleteClient()
        {
            InitializeComponent();
        }
        private void _ClearInputs()
        {
            btnSearch.Visible = true;
            btnClear.Visible = false;
            btnDeleteClient.Visible = false;

            tbClientID.Clear();
            tbClientID.BorderColor = Color.FromArgb(213, 218, 223);

            tbFirstName.Clear();
            tbLastName.Clear();
            tbPhoneNumber.Clear();
            tbEmail.Clear();
            tbCity.Clear();
            tbCountry.Clear();
            tbDateOfBirth.Clear();
            tbCreateDate.Clear();
        }      
        private bool _FindClientToDelete()
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
            FindClientToDelete = ClsClients_Business.FindClient(ClientID);

            if (FindClientToDelete != null)
            {
                tbFirstName.Text = FindClientToDelete.FirstName;
                tbLastName.Text = FindClientToDelete.LastName;
                tbEmail.Text = FindClientToDelete.Email;
                tbPhoneNumber.Text = FindClientToDelete.Phone;
                tbCity.Text = FindClientToDelete.City;
                tbCountry.Text = FindClientToDelete.Country;
                tbDateOfBirth.Text = Convert.ToString(FindClientToDelete.DateOfBirth);
                tbCreateDate.Text = Convert.ToString(FindClientToDelete.CreateDate);
                return true;
            }
            else
            {
                MessageBox.Show($"This ClientID \"{tbClientID.Text}\" was not found," +
                    $" write another...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void _DeleteClient()
        {

            if (!clsAccountsBusiness._IsClientExistInTableAccount(FindClientToDelete.ID))
            {
                if (MessageBox.Show("Do you want to delete this client ?", "Sure ?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                    return;

                ClsClients_Business.DeleteClient(FindClientToDelete.ID);

                MessageBox.Show("Client deleted successfully...", "Success !", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(" You can not delete this client because he has an Account! ", "Error !",
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
            if (_FindClientToDelete())
            {
                btnSearch.Visible = false;
                btnClear.Visible = true;
                btnDeleteClient.Visible = true;
            }
        }
        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            _DeleteClient();
            _ClearInputs();
        }
    }
}
