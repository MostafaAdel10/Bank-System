using Guna.UI2.WinForms;
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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        public void LoadForm(object form)
        {
            if (this.MainPanel.Controls.Count > 0)
                this.MainPanel.Controls.RemoveAt(0);

            Form frm = form as Form;

            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(frm);
            this.MainPanel.Tag = frm;
            frm.Show();
        }
        private void CheckPermissions()
        {
            if ((1 & clsGlobal.CurrentUser.Permissions) != 1)
                btnClients.Enabled = false;

            if ((64 & clsGlobal.CurrentUser.Permissions) != 64)
                btnUsers.Enabled = false;

            if ((4096 & clsGlobal.CurrentUser.Permissions) != 4096)
                btnTransactions.Enabled = false;

            if ((262144 & clsGlobal.CurrentUser.Permissions) != 262144)
                btnLoginRegister.Enabled = false;

            if ((524288 & clsGlobal.CurrentUser.Permissions) != 524288)
                btnAccounts.Enabled = false;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser.Permissions != -1)
                CheckPermissions();

            LoadForm(new ManageClients());

            txtTime.Text = DateTime.Now.ToString("dd, MMM yyyy") + " -";

        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            btnClients.FillColor = Color.Silver;
            btnUsers.FillColor = Control.DefaultBackColor;
            btnTransactions.FillColor = Control.DefaultBackColor;
            btnLoginRegister.FillColor = Control.DefaultBackColor;
            btnLogout.FillColor = Control.DefaultBackColor;
            btnAccounts.FillColor = Control.DefaultBackColor;
            LoadForm(new ManageClients());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            btnClients.FillColor = Control.DefaultBackColor;
            btnUsers.FillColor = Color.Silver;
            btnTransactions.FillColor = Control.DefaultBackColor;
            btnLoginRegister.FillColor = Control.DefaultBackColor;
            btnLogout.FillColor = Control.DefaultBackColor;
            btnAccounts.FillColor = Control.DefaultBackColor;
            LoadForm(new ManageUsere());
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            btnClients.FillColor = Control.DefaultBackColor;
            btnUsers.FillColor = Control.DefaultBackColor;
            btnTransactions.FillColor = Color.Silver;
            btnLoginRegister.FillColor = Control.DefaultBackColor;
            btnLogout.FillColor = Control.DefaultBackColor;
            btnAccounts.FillColor = Control.DefaultBackColor;
            LoadForm(new ManageTransactions());
        }

        private void btnLoginRegister_Click(object sender, EventArgs e)
        {
            btnClients.FillColor = Control.DefaultBackColor;
            btnUsers.FillColor = Control.DefaultBackColor;
            btnTransactions.FillColor = Control.DefaultBackColor;
            btnLoginRegister.FillColor = Color.Silver;
            btnLogout.FillColor = Control.DefaultBackColor;
            btnAccounts.FillColor = Control.DefaultBackColor;
            LoadForm(new LoginRegister());
        }
        private void btnAccounts_Click(object sender, EventArgs e)
        {
            btnClients.FillColor = Control.DefaultBackColor;
            btnUsers.FillColor = Control.DefaultBackColor;
            btnTransactions.FillColor = Control.DefaultBackColor;
            btnLoginRegister.FillColor = Control.DefaultBackColor;
            btnLogout.FillColor = Control.DefaultBackColor;
            btnAccounts.FillColor = Color.Silver;
            LoadForm(new ManageAccounts());
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoadForm(new LogIn());
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtClock.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
