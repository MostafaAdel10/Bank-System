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

namespace BankProject
{
    public partial class ClientsList : Form
    {
        public ClientsList()
        {
            InitializeComponent();
        }
        private void _RefreshClientsList()
        {
            ClientsListGrid.DataSource = ClsClients_Business.GetAllClients();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ClientsList_Load(object sender, EventArgs e)
        {
            _RefreshClientsList();
        }
    }
}
