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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnEyeIcon_Click(object sender, EventArgs e)
        {
            if (tbPassWord.PasswordChar == '*')
            {
                tbPassWord.PasswordChar = '\0';
                btnEyeIcon.Image = Image.FromFile(@"D:\Programing\Images Projects\BankProject\EyeCrossedIcon.png");
            }
            else
            {
                tbPassWord.PasswordChar = '*';
                btnEyeIcon.Image = Image.FromFile(@"D:\Programing\Images Projects\BankProject\EyeIcon.png");
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if(clsUsersBusiness.IsUsersExist(tbUserName.Text, tbPassWord.Text))
            {
                clsUsersBusiness FindUser = clsUsersBusiness.FindUser(tbUserName.Text, tbPassWord.Text);
                clsLoginRegistersBusiness AddLoginRegisters1 = new clsLoginRegistersBusiness();

                clsGlobal.CurrentUser.UserID = FindUser.ID;
                clsGlobal.CurrentUser.UserName = FindUser.UserName;
                clsGlobal.CurrentUser.Password = FindUser.Password;
                clsGlobal.CurrentUser.Permissions = FindUser.Permissions;

                AddLoginRegisters1.UserID = FindUser.ID;
                AddLoginRegisters1.UserName = FindUser.UserName;
                AddLoginRegisters1.Password = FindUser.Password;
                AddLoginRegisters1.Permissions = FindUser.Permissions;
                AddLoginRegisters1.Save();

                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();

            }
            else
            {
                txtWrong.Visible = true;
            }
            
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile(@"D:\Programing\Images Projects\BankProject\MainLogin3.png");
        }
    }
}
