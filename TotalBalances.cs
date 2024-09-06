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
    public partial class TotalBalances : Form
    {
        public TotalBalances()
        {
            InitializeComponent();
        }
        private void _RefreshTotalBalances()
        {
            TotalBalancesGrid.DataSource = clsAccountsBusiness.GetTotalBalances();
        }


        private void TotalBalances_Load(object sender, EventArgs e)
        {
            _RefreshTotalBalances();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
