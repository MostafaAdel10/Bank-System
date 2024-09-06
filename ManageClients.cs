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
    public partial class ManageClients : Form
    {
        public ManageClients()
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
        private void btnListClient_Click(object sender, EventArgs e)
        {
            LoadForm(new ClientsList());
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            LoadForm(new AddClient());
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            LoadForm(new FindClient());
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            LoadForm(new UpdateClient());
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            LoadForm(new DeleteClient());
        }
        private void CheckPermissions()
        {
            if ((2 & clsGlobal.CurrentUser.Permissions) != 2)
                btnListClient.Enabled = false;

            if ((4 & clsGlobal.CurrentUser.Permissions) != 4)
                btnAddClient.Enabled = false;

            if ((8 & clsGlobal.CurrentUser.Permissions) != 8)
                btnDeleteClient.Enabled = false;

            if ((16 & clsGlobal.CurrentUser.Permissions) != 16)
                btnFindClient.Enabled = false;

            if ((32 & clsGlobal.CurrentUser.Permissions) != 32)
                btnUpdateClient.Enabled = false;
        }

        private void ClientsSection_Load(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser.Permissions != -1)
                CheckPermissions();
        }
    }
}
