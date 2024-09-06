﻿using System;
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
    public partial class AccountsList : Form
    {
        public AccountsList()
        {
            InitializeComponent();
        }
        private void _RefreshAccountsList()
        {
            AccountsListGrid.DataSource = clsAccountsBusiness.GetAllAccounts();
        }

        private void AccountsList_Load(object sender, EventArgs e)
        {
            _RefreshAccountsList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}