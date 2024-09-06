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
    public partial class TransferLog : Form
    {
        public TransferLog()
        {
            InitializeComponent();
        }
        private void _RefreshTransferLog()
        {
            TransferLogGrid.DataSource = clsTransactionBusiness.GetTransferLog();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TransferLog_Load(object sender, EventArgs e)
        {
            _RefreshTransferLog();
        }
    }
}
