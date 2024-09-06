namespace BankProject
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAccounts = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnLoginRegister = new Guna.UI2.WinForms.Guna2Button();
            this.btnTransactions = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnClients = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.txtClock = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnAccounts);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnLoginRegister);
            this.panel1.Controls.Add(this.btnTransactions);
            this.panel1.Controls.Add(this.btnUsers);
            this.panel1.Controls.Add(this.btnClients);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 652);
            this.panel1.TabIndex = 0;
            // 
            // btnAccounts
            // 
            this.btnAccounts.BorderRadius = 5;
            this.btnAccounts.CheckedState.Parent = this.btnAccounts;
            this.btnAccounts.CustomImages.Parent = this.btnAccounts;
            this.btnAccounts.FillColor = System.Drawing.Color.Transparent;
            this.btnAccounts.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnAccounts.ForeColor = System.Drawing.Color.Black;
            this.btnAccounts.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnAccounts.HoverState.Parent = this.btnAccounts;
            this.btnAccounts.Image = global::BankProject.Properties.Resources.Accounts;
            this.btnAccounts.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAccounts.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAccounts.Location = new System.Drawing.Point(9, 283);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAccounts.ShadowDecoration.Parent = this.btnAccounts;
            this.btnAccounts.Size = new System.Drawing.Size(240, 45);
            this.btnAccounts.TabIndex = 6;
            this.btnAccounts.Tag = "Accounts";
            this.btnAccounts.Text = "Accounts";
            this.btnAccounts.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BorderRadius = 5;
            this.btnLogout.CheckedState.Parent = this.btnLogout;
            this.btnLogout.CustomImages.Parent = this.btnLogout;
            this.btnLogout.FillColor = System.Drawing.Color.Transparent;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnLogout.HoverState.Parent = this.btnLogout;
            this.btnLogout.Image = global::BankProject.Properties.Resources.Exit;
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLogout.Location = new System.Drawing.Point(9, 595);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLogout.ShadowDecoration.Parent = this.btnLogout;
            this.btnLogout.Size = new System.Drawing.Size(240, 45);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Tag = "Logout";
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnLoginRegister
            // 
            this.btnLoginRegister.BorderRadius = 5;
            this.btnLoginRegister.CheckedState.Parent = this.btnLoginRegister;
            this.btnLoginRegister.CustomImages.Parent = this.btnLoginRegister;
            this.btnLoginRegister.FillColor = System.Drawing.Color.Transparent;
            this.btnLoginRegister.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnLoginRegister.ForeColor = System.Drawing.Color.Black;
            this.btnLoginRegister.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnLoginRegister.HoverState.Parent = this.btnLoginRegister;
            this.btnLoginRegister.Image = global::BankProject.Properties.Resources.History;
            this.btnLoginRegister.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLoginRegister.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLoginRegister.Location = new System.Drawing.Point(9, 469);
            this.btnLoginRegister.Name = "btnLoginRegister";
            this.btnLoginRegister.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLoginRegister.ShadowDecoration.Parent = this.btnLoginRegister;
            this.btnLoginRegister.Size = new System.Drawing.Size(240, 45);
            this.btnLoginRegister.TabIndex = 4;
            this.btnLoginRegister.Tag = "LoginRegister";
            this.btnLoginRegister.Text = "LoginRegister";
            this.btnLoginRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLoginRegister.Click += new System.EventHandler(this.btnLoginRegister_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.BorderRadius = 5;
            this.btnTransactions.CheckedState.Parent = this.btnTransactions;
            this.btnTransactions.CustomImages.Parent = this.btnTransactions;
            this.btnTransactions.FillColor = System.Drawing.Color.Transparent;
            this.btnTransactions.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnTransactions.ForeColor = System.Drawing.Color.Black;
            this.btnTransactions.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnTransactions.HoverState.Parent = this.btnTransactions;
            this.btnTransactions.Image = global::BankProject.Properties.Resources.Transactions;
            this.btnTransactions.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTransactions.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTransactions.Location = new System.Drawing.Point(9, 407);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTransactions.ShadowDecoration.Parent = this.btnTransactions;
            this.btnTransactions.Size = new System.Drawing.Size(240, 45);
            this.btnTransactions.TabIndex = 3;
            this.btnTransactions.Tag = "Transactions";
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BorderRadius = 5;
            this.btnUsers.CheckedState.Parent = this.btnUsers;
            this.btnUsers.CustomImages.Parent = this.btnUsers;
            this.btnUsers.FillColor = System.Drawing.Color.Transparent;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnUsers.ForeColor = System.Drawing.Color.Black;
            this.btnUsers.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnUsers.HoverState.Parent = this.btnUsers;
            this.btnUsers.Image = global::BankProject.Properties.Resources.Users;
            this.btnUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsers.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUsers.Location = new System.Drawing.Point(9, 345);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUsers.ShadowDecoration.Parent = this.btnUsers;
            this.btnUsers.Size = new System.Drawing.Size(240, 45);
            this.btnUsers.TabIndex = 2;
            this.btnUsers.Tag = "Users";
            this.btnUsers.Text = "Users";
            this.btnUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnClients
            // 
            this.btnClients.BorderRadius = 5;
            this.btnClients.CheckedState.Parent = this.btnClients;
            this.btnClients.CustomImages.Parent = this.btnClients;
            this.btnClients.FillColor = System.Drawing.Color.Gray;
            this.btnClients.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnClients.ForeColor = System.Drawing.Color.Black;
            this.btnClients.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnClients.HoverState.Parent = this.btnClients;
            this.btnClients.Image = global::BankProject.Properties.Resources.Clients;
            this.btnClients.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClients.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClients.Location = new System.Drawing.Point(9, 221);
            this.btnClients.Name = "btnClients";
            this.btnClients.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClients.ShadowDecoration.Parent = this.btnClients;
            this.btnClients.Size = new System.Drawing.Size(240, 45);
            this.btnClients.TabIndex = 1;
            this.btnClients.Tag = "Clients";
            this.btnClients.Text = "Clients";
            this.btnClients.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(51, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bank System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BankProject.Properties.Resources.Bank;
            this.pictureBox1.Location = new System.Drawing.Point(37, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Location = new System.Drawing.Point(268, 34);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1032, 615);
            this.MainPanel.TabIndex = 1;
            // 
            // txtClock
            // 
            this.txtClock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtClock.BackColor = System.Drawing.Color.Transparent;
            this.txtClock.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtClock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.txtClock.Location = new System.Drawing.Point(1200, 6);
            this.txtClock.Margin = new System.Windows.Forms.Padding(4);
            this.txtClock.Name = "txtClock";
            this.txtClock.Size = new System.Drawing.Size(73, 25);
            this.txtClock.TabIndex = 26;
            this.txtClock.Text = "00:00:00";
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.Transparent;
            this.txtTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.txtTime.Location = new System.Drawing.Point(1064, 6);
            this.txtTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(130, 25);
            this.txtTime.TabIndex = 25;
            this.txtTime.Text = "24, April 2024 -";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1303, 652);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtClock);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel MainPanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Timer timer1;
        public Guna.UI2.WinForms.Guna2Button btnClients;
        public Guna.UI2.WinForms.Guna2Button btnTransactions;
        public Guna.UI2.WinForms.Guna2Button btnUsers;
        public Guna.UI2.WinForms.Guna2Button btnLogout;
        public Guna.UI2.WinForms.Guna2Button btnLoginRegister;
        public Guna.UI2.WinForms.Guna2Button btnAccounts;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtClock;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtTime;
    }
}