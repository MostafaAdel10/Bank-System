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
    public partial class LoginRegister : Form
    {
        public LoginRegister()
        {
            InitializeComponent();
        }
        private void _RefreshLoginRegisters()
        {
            LoginRegistersGrid.DataSource = clsLoginRegistersBusiness.GetAllLoginRegisters();
        }

        private void LoginRegister_Load(object sender, EventArgs e)
        {
            _RefreshLoginRegisters();
        }

    }
}
