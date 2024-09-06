namespace BankProject
{
    partial class ManageAccounts
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
            this.PanelAccounts = new System.Windows.Forms.Panel();
            this.btnDeleteAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnAccountsList = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnFindAccount = new Guna.UI2.WinForms.Guna2Button();
            this.lblManageAccounts = new System.Windows.Forms.Label();
            this.PanelAccounts.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelAccounts
            // 
            this.PanelAccounts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelAccounts.Controls.Add(this.btnDeleteAccount);
            this.PanelAccounts.Controls.Add(this.btnAccountsList);
            this.PanelAccounts.Controls.Add(this.btnUpdateAccount);
            this.PanelAccounts.Controls.Add(this.btnAddAccount);
            this.PanelAccounts.Controls.Add(this.btnFindAccount);
            this.PanelAccounts.Location = new System.Drawing.Point(6, 45);
            this.PanelAccounts.Name = "PanelAccounts";
            this.PanelAccounts.Size = new System.Drawing.Size(960, 539);
            this.PanelAccounts.TabIndex = 17;
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteAccount.BorderRadius = 30;
            this.btnDeleteAccount.CheckedState.Parent = this.btnDeleteAccount;
            this.btnDeleteAccount.CustomImages.Parent = this.btnDeleteAccount;
            this.btnDeleteAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDeleteAccount.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteAccount.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnDeleteAccount.HoverState.Parent = this.btnDeleteAccount;
            this.btnDeleteAccount.Image = global::BankProject.Properties.Resources.DeleteClientIcon;
            this.btnDeleteAccount.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteAccount.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteAccount.Location = new System.Drawing.Point(505, 268);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDeleteAccount.ShadowDecoration.Parent = this.btnDeleteAccount;
            this.btnDeleteAccount.Size = new System.Drawing.Size(249, 158);
            this.btnDeleteAccount.TabIndex = 24;
            this.btnDeleteAccount.Text = "Delete Account";
            this.btnDeleteAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnAccountsList
            // 
            this.btnAccountsList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAccountsList.BorderRadius = 30;
            this.btnAccountsList.CheckedState.Parent = this.btnAccountsList;
            this.btnAccountsList.CustomImages.Parent = this.btnAccountsList;
            this.btnAccountsList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAccountsList.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnAccountsList.ForeColor = System.Drawing.Color.Black;
            this.btnAccountsList.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnAccountsList.HoverState.Parent = this.btnAccountsList;
            this.btnAccountsList.Image = global::BankProject.Properties.Resources.ClientsListIcon;
            this.btnAccountsList.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAccountsList.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAccountsList.Location = new System.Drawing.Point(41, 71);
            this.btnAccountsList.Name = "btnAccountsList";
            this.btnAccountsList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAccountsList.ShadowDecoration.Parent = this.btnAccountsList;
            this.btnAccountsList.Size = new System.Drawing.Size(249, 158);
            this.btnAccountsList.TabIndex = 23;
            this.btnAccountsList.Text = "Accounts List";
            this.btnAccountsList.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAccountsList.Click += new System.EventHandler(this.btnAccountsList_Click);
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateAccount.BorderRadius = 30;
            this.btnUpdateAccount.CheckedState.Parent = this.btnUpdateAccount;
            this.btnUpdateAccount.CustomImages.Parent = this.btnUpdateAccount;
            this.btnUpdateAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdateAccount.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnUpdateAccount.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateAccount.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnUpdateAccount.HoverState.Parent = this.btnUpdateAccount;
            this.btnUpdateAccount.Image = global::BankProject.Properties.Resources.UpdateClientIcon;
            this.btnUpdateAccount.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateAccount.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdateAccount.Location = new System.Drawing.Point(165, 268);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpdateAccount.ShadowDecoration.Parent = this.btnUpdateAccount;
            this.btnUpdateAccount.Size = new System.Drawing.Size(249, 158);
            this.btnUpdateAccount.TabIndex = 22;
            this.btnUpdateAccount.Text = "Update Account";
            this.btnUpdateAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddAccount.BorderRadius = 30;
            this.btnAddAccount.CheckedState.Parent = this.btnAddAccount;
            this.btnAddAccount.CustomImages.Parent = this.btnAddAccount;
            this.btnAddAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddAccount.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnAddAccount.ForeColor = System.Drawing.Color.Black;
            this.btnAddAccount.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnAddAccount.HoverState.Parent = this.btnAddAccount;
            this.btnAddAccount.Image = global::BankProject.Properties.Resources.AddClientIcon;
            this.btnAddAccount.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddAccount.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddAccount.Location = new System.Drawing.Point(345, 71);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddAccount.ShadowDecoration.Parent = this.btnAddAccount;
            this.btnAddAccount.Size = new System.Drawing.Size(249, 158);
            this.btnAddAccount.TabIndex = 21;
            this.btnAddAccount.Text = "Add Account";
            this.btnAddAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // btnFindAccount
            // 
            this.btnFindAccount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFindAccount.BorderRadius = 30;
            this.btnFindAccount.CheckedState.Parent = this.btnFindAccount;
            this.btnFindAccount.CustomImages.Parent = this.btnFindAccount;
            this.btnFindAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFindAccount.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnFindAccount.ForeColor = System.Drawing.Color.Black;
            this.btnFindAccount.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnFindAccount.HoverState.Parent = this.btnFindAccount;
            this.btnFindAccount.Image = global::BankProject.Properties.Resources.FindClientIcon;
            this.btnFindAccount.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFindAccount.ImageSize = new System.Drawing.Size(30, 30);
            this.btnFindAccount.Location = new System.Drawing.Point(650, 71);
            this.btnFindAccount.Name = "btnFindAccount";
            this.btnFindAccount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFindAccount.ShadowDecoration.Parent = this.btnFindAccount;
            this.btnFindAccount.Size = new System.Drawing.Size(249, 158);
            this.btnFindAccount.TabIndex = 19;
            this.btnFindAccount.Text = "Find Account";
            this.btnFindAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFindAccount.Click += new System.EventHandler(this.btnFindAccount_Click);
            // 
            // lblManageAccounts
            // 
            this.lblManageAccounts.AutoSize = true;
            this.lblManageAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageAccounts.ForeColor = System.Drawing.Color.Black;
            this.lblManageAccounts.Location = new System.Drawing.Point(12, 9);
            this.lblManageAccounts.Name = "lblManageAccounts";
            this.lblManageAccounts.Size = new System.Drawing.Size(262, 33);
            this.lblManageAccounts.TabIndex = 18;
            this.lblManageAccounts.Text = "Manage Accounts";
            // 
            // ManageAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(972, 606);
            this.Controls.Add(this.lblManageAccounts);
            this.Controls.Add(this.PanelAccounts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageAccounts";
            this.Text = "ManageAccounts";
            this.PanelAccounts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelAccounts;
        private Guna.UI2.WinForms.Guna2Button btnAccountsList;
        private Guna.UI2.WinForms.Guna2Button btnUpdateAccount;
        private Guna.UI2.WinForms.Guna2Button btnAddAccount;
        private Guna.UI2.WinForms.Guna2Button btnFindAccount;
        private Guna.UI2.WinForms.Guna2Button btnDeleteAccount;
        private System.Windows.Forms.Label lblManageAccounts;
    }
}