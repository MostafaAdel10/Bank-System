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
    public partial class ManageAccounts : Form
    {
        public ManageAccounts()
        {
            InitializeComponent();
        }
        public void LoadForm(object form)
        {
            Form frm = form as Form;

            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.Controls.Add(frm);
            this.Tag = frm;
            frm.Show();
            frm.BringToFront();
        }
        private void btnAccountsList_Click(object sender, EventArgs e)
        {
            LoadForm(new AccountsList());
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            LoadForm(new AddAccount());
        }

        private void btnFindAccount_Click(object sender, EventArgs e)
        {
            LoadForm(new FindAccount());
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            LoadForm(new UpdateAccount());
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            LoadForm(new DeleteAccount());
        }
        private void CheckPermissions()
        {
            if ((1048576 & clsGlobal.CurrentUser.Permissions) != 1048576)
                btnAccountsList.Enabled = false;

            if ((2097152 & clsGlobal.CurrentUser.Permissions) != 2097152)
                btnAddAccount.Enabled = false;

            if ((4194304 & clsGlobal.CurrentUser.Permissions) != 4194304)
                btnDeleteAccount.Enabled = false;

            if ((8388608 & clsGlobal.CurrentUser.Permissions) != 8388608)
                btnFindAccount.Enabled = false;

            if ((16777216 & clsGlobal.CurrentUser.Permissions) != 16777216)
                btnUpdateAccount.Enabled = false;
        }

        private void TransactionsSection_Load(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser.Permissions != -1)
                CheckPermissions();
        }
    }
}
