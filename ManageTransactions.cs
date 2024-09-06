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
    public partial class ManageTransactions : Form
    {
        public ManageTransactions()
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
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            LoadForm(new Deposit());
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            LoadForm(new Withdraw());
        }

        private void btnTotalBalances_Click(object sender, EventArgs e)
        {
            LoadForm(new TotalBalances());
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            LoadForm(new Transfer());
        }

        private void btnTransactionsLog_Click(object sender, EventArgs e)
        {
            LoadForm(new TransferLog());
        }
        private void CheckPermissions()
        {
            if ((8192 & clsGlobal.CurrentUser.Permissions) != 8192)
                btnDeposit.Enabled = false;

            if ((16384 & clsGlobal.CurrentUser.Permissions) != 16384)
                btnWithdraw.Enabled = false;

            if ((32768 & clsGlobal.CurrentUser.Permissions) != 32768)
                btnTotalBalances.Enabled = false;

            if ((65536 & clsGlobal.CurrentUser.Permissions) != 65536)
                btnTransfer.Enabled = false;

            if ((131072 & clsGlobal.CurrentUser.Permissions) != 131072)
                btnTransferLog.Enabled = false;
        }

        private void TransactionsSection_Load(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser.Permissions != -1)
                CheckPermissions();
        }
    }
}
