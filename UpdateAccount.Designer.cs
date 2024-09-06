namespace BankProject
{
    partial class UpdateAccount
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
            this.btnUpdateAccount = new Guna.UI2.WinForms.Guna2Button();
            this.tbAccountNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.tbClientID = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbAccountBalance = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblUpdateAccount = new System.Windows.Forms.Label();
            this.tbCreateAccountDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateAccount.Animated = true;
            this.btnUpdateAccount.BorderRadius = 2;
            this.btnUpdateAccount.CheckedState.Parent = this.btnUpdateAccount;
            this.btnUpdateAccount.CustomImages.Parent = this.btnUpdateAccount;
            this.btnUpdateAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnUpdateAccount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdateAccount.ForeColor = System.Drawing.Color.White;
            this.btnUpdateAccount.HoverState.Parent = this.btnUpdateAccount;
            this.btnUpdateAccount.Location = new System.Drawing.Point(778, 292);
            this.btnUpdateAccount.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.ShadowDecoration.Parent = this.btnUpdateAccount;
            this.btnUpdateAccount.Size = new System.Drawing.Size(140, 39);
            this.btnUpdateAccount.TabIndex = 102;
            this.btnUpdateAccount.Text = "UpdateAccount";
            this.btnUpdateAccount.Visible = false;
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
            // 
            // tbAccountNumber
            // 
            this.tbAccountNumber.Animated = true;
            this.tbAccountNumber.BorderRadius = 5;
            this.tbAccountNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAccountNumber.DefaultText = "";
            this.tbAccountNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbAccountNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbAccountNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAccountNumber.DisabledState.Parent = this.tbAccountNumber;
            this.tbAccountNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAccountNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAccountNumber.FocusedState.Parent = this.tbAccountNumber;
            this.tbAccountNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAccountNumber.HoverState.Parent = this.tbAccountNumber;
            this.tbAccountNumber.Location = new System.Drawing.Point(18, 47);
            this.tbAccountNumber.Margin = new System.Windows.Forms.Padding(5);
            this.tbAccountNumber.Name = "tbAccountNumber";
            this.tbAccountNumber.PasswordChar = '\0';
            this.tbAccountNumber.PlaceholderText = "Enter the Account Number To Update An Account";
            this.tbAccountNumber.SelectedText = "";
            this.tbAccountNumber.ShadowDecoration.Parent = this.tbAccountNumber;
            this.tbAccountNumber.Size = new System.Drawing.Size(928, 47);
            this.tbAccountNumber.TabIndex = 101;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.Animated = true;
            this.btnClear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnClear.BorderRadius = 2;
            this.btnClear.BorderThickness = 1;
            this.btnClear.CheckedState.Parent = this.btnClear;
            this.btnClear.CustomImages.Parent = this.btnClear;
            this.btnClear.FillColor = System.Drawing.SystemColors.Control;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnClear.HoverState.Parent = this.btnClear;
            this.btnClear.Location = new System.Drawing.Point(630, 292);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.Parent = this.btnClear;
            this.btnClear.Size = new System.Drawing.Size(140, 39);
            this.btnClear.TabIndex = 99;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.Animated = true;
            this.btnSearch.BorderRadius = 2;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Location = new System.Drawing.Point(778, 292);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(140, 39);
            this.btnSearch.TabIndex = 98;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.Animated = true;
            this.btnBack.BorderRadius = 2;
            this.btnBack.CheckedState.Parent = this.btnBack;
            this.btnBack.CustomImages.Parent = this.btnBack;
            this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.HoverState.Parent = this.btnBack;
            this.btnBack.Location = new System.Drawing.Point(-10, 292);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(140, 39);
            this.btnBack.TabIndex = 97;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tbClientID
            // 
            this.tbClientID.Animated = true;
            this.tbClientID.BorderRadius = 5;
            this.tbClientID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbClientID.DefaultText = "";
            this.tbClientID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbClientID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbClientID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbClientID.DisabledState.Parent = this.tbClientID;
            this.tbClientID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbClientID.Enabled = false;
            this.tbClientID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbClientID.FocusedState.Parent = this.tbClientID;
            this.tbClientID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbClientID.HoverState.Parent = this.tbClientID;
            this.tbClientID.Location = new System.Drawing.Point(18, 188);
            this.tbClientID.Margin = new System.Windows.Forms.Padding(5);
            this.tbClientID.Name = "tbClientID";
            this.tbClientID.PasswordChar = '\0';
            this.tbClientID.PlaceholderText = "ClientID";
            this.tbClientID.ReadOnly = true;
            this.tbClientID.SelectedText = "";
            this.tbClientID.ShadowDecoration.Parent = this.tbClientID;
            this.tbClientID.Size = new System.Drawing.Size(928, 47);
            this.tbClientID.TabIndex = 96;
            // 
            // tbAccountBalance
            // 
            this.tbAccountBalance.Animated = true;
            this.tbAccountBalance.BorderRadius = 5;
            this.tbAccountBalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAccountBalance.DefaultText = "";
            this.tbAccountBalance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbAccountBalance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbAccountBalance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAccountBalance.DisabledState.Parent = this.tbAccountBalance;
            this.tbAccountBalance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAccountBalance.Enabled = false;
            this.tbAccountBalance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAccountBalance.FocusedState.Parent = this.tbAccountBalance;
            this.tbAccountBalance.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAccountBalance.HoverState.Parent = this.tbAccountBalance;
            this.tbAccountBalance.Location = new System.Drawing.Point(18, 141);
            this.tbAccountBalance.Margin = new System.Windows.Forms.Padding(5);
            this.tbAccountBalance.Name = "tbAccountBalance";
            this.tbAccountBalance.PasswordChar = '\0';
            this.tbAccountBalance.PlaceholderText = "Account Balance";
            this.tbAccountBalance.SelectedText = "";
            this.tbAccountBalance.ShadowDecoration.Parent = this.tbAccountBalance;
            this.tbAccountBalance.Size = new System.Drawing.Size(928, 47);
            this.tbAccountBalance.TabIndex = 95;
            // 
            // lblUpdateAccount
            // 
            this.lblUpdateAccount.AutoSize = true;
            this.lblUpdateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateAccount.ForeColor = System.Drawing.Color.Black;
            this.lblUpdateAccount.Location = new System.Drawing.Point(12, 9);
            this.lblUpdateAccount.Name = "lblUpdateAccount";
            this.lblUpdateAccount.Size = new System.Drawing.Size(235, 33);
            this.lblUpdateAccount.TabIndex = 94;
            this.lblUpdateAccount.Text = "Update Account";
            // 
            // tbCreateAccountDate
            // 
            this.tbCreateAccountDate.Animated = true;
            this.tbCreateAccountDate.BorderRadius = 5;
            this.tbCreateAccountDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCreateAccountDate.DefaultText = "";
            this.tbCreateAccountDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCreateAccountDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCreateAccountDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCreateAccountDate.DisabledState.Parent = this.tbCreateAccountDate;
            this.tbCreateAccountDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCreateAccountDate.Enabled = false;
            this.tbCreateAccountDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCreateAccountDate.FocusedState.Parent = this.tbCreateAccountDate;
            this.tbCreateAccountDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCreateAccountDate.HoverState.Parent = this.tbCreateAccountDate;
            this.tbCreateAccountDate.Location = new System.Drawing.Point(18, 235);
            this.tbCreateAccountDate.Margin = new System.Windows.Forms.Padding(5);
            this.tbCreateAccountDate.Name = "tbCreateAccountDate";
            this.tbCreateAccountDate.PasswordChar = '\0';
            this.tbCreateAccountDate.PlaceholderText = "Create Account Date";
            this.tbCreateAccountDate.ReadOnly = true;
            this.tbCreateAccountDate.SelectedText = "";
            this.tbCreateAccountDate.ShadowDecoration.Parent = this.tbCreateAccountDate;
            this.tbCreateAccountDate.Size = new System.Drawing.Size(928, 47);
            this.tbCreateAccountDate.TabIndex = 103;
            // 
            // tbPassword
            // 
            this.tbPassword.Animated = true;
            this.tbPassword.BorderRadius = 5;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.DefaultText = "";
            this.tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.DisabledState.Parent = this.tbPassword;
            this.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.FocusedState.Parent = this.tbPassword;
            this.tbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.HoverState.Parent = this.tbPassword;
            this.tbPassword.Location = new System.Drawing.Point(18, 94);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(5);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '\0';
            this.tbPassword.PlaceholderText = "Password";
            this.tbPassword.SelectedText = "";
            this.tbPassword.ShadowDecoration.Parent = this.tbPassword;
            this.tbPassword.Size = new System.Drawing.Size(928, 47);
            this.tbPassword.TabIndex = 104;
            // 
            // UpdateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 622);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbCreateAccountDate);
            this.Controls.Add(this.btnUpdateAccount);
            this.Controls.Add(this.tbAccountNumber);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbClientID);
            this.Controls.Add(this.tbAccountBalance);
            this.Controls.Add(this.lblUpdateAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateAccount";
            this.Text = "UpdateAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnUpdateAccount;
        public Guna.UI2.WinForms.Guna2TextBox tbAccountNumber;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2TextBox tbClientID;
        private Guna.UI2.WinForms.Guna2TextBox tbAccountBalance;
        private System.Windows.Forms.Label lblUpdateAccount;
        private Guna.UI2.WinForms.Guna2TextBox tbCreateAccountDate;
        public Guna.UI2.WinForms.Guna2TextBox tbPassword;
    }
}