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
    public partial class ManageUsere : Form
    {
        public ManageUsere()
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
        private void btnLUsersList_Click(object sender, EventArgs e)
        {
            LoadForm(new UsersList());
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            LoadForm(new AddUser());
        }

        private void btnFindUser_Click(object sender, EventArgs e)
        {
            LoadForm(new FindUser());
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            LoadForm(new UpdateUser());
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            LoadForm(new DeleteUser());
        }
        private void CheckPermissions()
        {
            if ((128 & clsGlobal.CurrentUser.Permissions) != 128)
                btnLUsersList.Enabled = false;

            if ((256 & clsGlobal.CurrentUser.Permissions) != 256)
                btnAddUser.Enabled = false;

            if ((512 & clsGlobal.CurrentUser.Permissions) != 512)
                btnDeleteUser.Enabled = false;

            if ((1024 & clsGlobal.CurrentUser.Permissions) != 1024)
                btnFindUser.Enabled = false;

            if ((2048 & clsGlobal.CurrentUser.Permissions) != 2048)
                btnUpdateUser.Enabled = false;
        }
        private void ManageUsere_Load(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser.Permissions != -1)
                CheckPermissions();
        }
    }
}
