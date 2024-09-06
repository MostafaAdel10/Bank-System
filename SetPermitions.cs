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
    public partial class SetPermitions : Form
    {
        public static SetPermitions Permitions;
        public SetPermitions()
        {
            Permitions = this;
            InitializeComponent();
        }

        public static int GetPermitions()
        {
            int Per = 0;
            bool ClientsSec = false, UsersSec = false, TransactionsSec = false,AccountsSec = false;

            try
            {
                if (SetPermitions.Permitions.tgFullAccess.Checked)
                {
                    Per = -1;
                    return Per;
                }
            }
            catch (Exception e)
            {
                Per = -1;
                return Per;
            }


            if (SetPermitions.Permitions.tgClientsList.Checked)
            {
                Per += 2;
                if (!ClientsSec)
                    ClientsSec = true;
            }

            if (SetPermitions.Permitions.tgAddNewClient.Checked)
            {
                Per += 4;
                if (!ClientsSec)
                    ClientsSec = true;
            }

            if (SetPermitions.Permitions.tgDeleteClient.Checked)
            {
                Per += 8;
                if (!ClientsSec)
                    ClientsSec = true;
            }

            if (SetPermitions.Permitions.tgFindClient.Checked)
            {
                Per += 16;
                if (!ClientsSec)
                    ClientsSec = true;
            }

            if (SetPermitions.Permitions.tgUpdateClient.Checked)
            {
                Per += 32;
                if (!ClientsSec)
                    ClientsSec = true;
            }

            if (ClientsSec)
                Per += 1;

            if (SetPermitions.Permitions.tgUsersList.Checked)
            {
                Per += 128;
                if (!UsersSec)
                    UsersSec = true;
            }

            if (SetPermitions.Permitions.tgAddNewUser.Checked)
            {
                Per += 256;
                if (!UsersSec)
                    UsersSec = true;
            }

            if (SetPermitions.Permitions.tgDeleteUser.Checked)
            {
                Per += 512;
                if (!UsersSec)
                    UsersSec = true;
            }

            if (SetPermitions.Permitions.tgFindUser.Checked)
            {
                Per += 1024;
                if (!UsersSec)
                    UsersSec = true;
            }

            if (SetPermitions.Permitions.tgUpdateUser.Checked)
            {
                Per += 2048;
                if (!UsersSec)
                    UsersSec = true;
            }

            if (UsersSec)
                Per += 64;

            if (SetPermitions.Permitions.tgDeposit.Checked)
            {
                Per += 8192;
                if (!TransactionsSec)
                    TransactionsSec = true;
            }

            if (SetPermitions.Permitions.tgWithdraw.Checked)
            {
                Per += 16384;
                if (!TransactionsSec)
                    TransactionsSec = true;
            }

            if (SetPermitions.Permitions.tgTotalBalances.Checked)
            {
                Per += 32768;
                if (!TransactionsSec)
                    TransactionsSec = true;
            }

            if (SetPermitions.Permitions.tgTransfer.Checked)
            {
                Per += 65536;
                if (!TransactionsSec)
                    TransactionsSec = true;
            }

            if (SetPermitions.Permitions.tgTransferLog.Checked)
            {
                Per += 131072;
                if (!TransactionsSec)
                    TransactionsSec = true;
            }

            if (TransactionsSec)
                Per += 4096;

            if (SetPermitions.Permitions.tgLoginRegister.Checked)
                Per += 262144;


            if (SetPermitions.Permitions.tgAccountsList.Checked)
            {
                Per += 1048576;
                if (!TransactionsSec)
                    TransactionsSec = true;
            }
            if (SetPermitions.Permitions.tgAddNewAccount.Checked)
            {
                Per += 2097152;
                if (!TransactionsSec)
                    TransactionsSec = true;
            }
            if (SetPermitions.Permitions.tgDeleteAccount.Checked)
            {
                Per += 4194304;
                if (!TransactionsSec)
                    TransactionsSec = true;
            }
            if (SetPermitions.Permitions.tgFindAccount.Checked)
            {
                Per += 8388608;
                if (!TransactionsSec)
                    TransactionsSec = true;
            }
            if (SetPermitions.Permitions.tgUpdateAccount.Checked)
            {
                Per += 16777216;
                if (!TransactionsSec)
                    TransactionsSec = true;
            }
            if (AccountsSec)
                Per += 524288;

            return Per;
        }




        private void ChangeSectionsPer(bool Value)
        {
            tgClientSection.Checked = Value;
            tgUsersSection.Checked = Value;
            tgTransactionsSection.Checked = Value;
            tgLoginRegister.Checked = Value;
            tgAccountsSection.Checked = Value;
        }
        private void tgFullAccess_CheckedChanged(object sender, EventArgs e)
        {
            if (tgFullAccess.Checked)
            {
                gbPermitions.Enabled = false;
                ChangeSectionsPer(true);
            }
            else
            {
                gbPermitions.Enabled = true;
                ChangeSectionsPer(false);
            }
        }



        private void ChangeClientsPer(bool Value)
        {
            tgClientsList.Checked = Value;
            tgAddNewClient.Checked = Value;
            tgDeleteClient.Checked = Value;
            tgFindClient.Checked = Value;
            tgUpdateClient.Checked = Value;
        }
        private void ChangeAccountsPer(bool Value)
        {
            tgAccountsList.Checked = Value;
            tgAddNewAccount.Checked = Value;
            tgUpdateAccount.Checked = Value;
            tgDeleteAccount.Checked = Value;
            tgFindAccount.Checked = Value;
        }
        private void ChangeUsersPer(bool Value)
        {
            tgUsersList.Checked = Value;
            tgAddNewUser.Checked = Value;
            tgDeleteUser.Checked = Value;
            tgFindUser.Checked = Value;
            tgUpdateUser.Checked = Value;
        }
        private void ChangeTransactionsPer(bool Value)
        {
            tgDeposit.Checked = Value;
            tgWithdraw.Checked = Value;
            tgTotalBalances.Checked = Value;
            tgTransfer.Checked = Value;
            tgTransferLog.Checked = Value;
        }

    
        private void tgClientSection_CheckedChanged(object sender, EventArgs e)
        {
            if (tgClientSection.Checked)
            {
                ChangeClientsPer(true);
                ClientsPer.Enabled = false;
            }
            else
            {
                ChangeClientsPer(false);
                ClientsPer.Enabled = true;
            }
        }
        private void tgUsersSection_CheckedChanged(object sender, EventArgs e)
        {
            if (tgUsersSection.Checked)
            {
                ChangeUsersPer(true);
                UsersPer.Enabled = false;
            }
            else
            {
                ChangeUsersPer(false);
                UsersPer.Enabled = true;
            }
        }
        private void tgTransactionsSection_CheckedChanged(object sender, EventArgs e)
        {
            if (tgTransactionsSection.Checked)
            {
                ChangeTransactionsPer(true);
                TransactionsPer.Enabled = false;
            }
            else
            {
                ChangeTransactionsPer(false);
                TransactionsPer.Enabled = true;
            }
        }
        private void tgAccountsSection_CheckedChanged(object sender, EventArgs e)
        {
            if (tgAccountsSection.Checked)
            {
                ChangeAccountsPer(true);
                AccountsPer.Enabled = false;
            }
            else
            {
                ChangeAccountsPer(false);
                AccountsPer.Enabled = true;
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want To Save This Data ?", "Sure ?", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                this.Close();
        }

    }
}
