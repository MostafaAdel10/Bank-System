namespace BankProject
{
    partial class FindClient
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
            this.lblFindClient = new System.Windows.Forms.Label();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.tbCity = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbDateOfBirth = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbClientID = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbCountry = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbCreateDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // lblFindClient
            // 
            this.lblFindClient.AutoSize = true;
            this.lblFindClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFindClient.ForeColor = System.Drawing.Color.Black;
            this.lblFindClient.Location = new System.Drawing.Point(12, 9);
            this.lblFindClient.Name = "lblFindClient";
            this.lblFindClient.Size = new System.Drawing.Size(166, 33);
            this.lblFindClient.TabIndex = 3;
            this.lblFindClient.Text = "Find Client";
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
            this.btnClear.Location = new System.Drawing.Point(631, 291);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.Parent = this.btnClear;
            this.btnClear.Size = new System.Drawing.Size(140, 39);
            this.btnClear.TabIndex = 74;
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
            this.btnSearch.Location = new System.Drawing.Point(779, 291);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(140, 39);
            this.btnSearch.TabIndex = 73;
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
            this.btnBack.Location = new System.Drawing.Point(-9, 291);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(140, 39);
            this.btnBack.TabIndex = 72;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tbCity
            // 
            this.tbCity.Animated = true;
            this.tbCity.BorderRadius = 5;
            this.tbCity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCity.DefaultText = "";
            this.tbCity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCity.DisabledState.Parent = this.tbCity;
            this.tbCity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCity.Enabled = false;
            this.tbCity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCity.FocusedState.Parent = this.tbCity;
            this.tbCity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCity.HoverState.Parent = this.tbCity;
            this.tbCity.Location = new System.Drawing.Point(18, 188);
            this.tbCity.Margin = new System.Windows.Forms.Padding(5);
            this.tbCity.Name = "tbCity";
            this.tbCity.PasswordChar = '\0';
            this.tbCity.PlaceholderText = "City";
            this.tbCity.SelectedText = "";
            this.tbCity.ShadowDecoration.Parent = this.tbCity;
            this.tbCity.Size = new System.Drawing.Size(446, 47);
            this.tbCity.TabIndex = 71;
            // 
            // tbDateOfBirth
            // 
            this.tbDateOfBirth.Animated = true;
            this.tbDateOfBirth.BorderRadius = 5;
            this.tbDateOfBirth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDateOfBirth.DefaultText = "";
            this.tbDateOfBirth.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbDateOfBirth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbDateOfBirth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDateOfBirth.DisabledState.Parent = this.tbDateOfBirth;
            this.tbDateOfBirth.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDateOfBirth.Enabled = false;
            this.tbDateOfBirth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDateOfBirth.FocusedState.Parent = this.tbDateOfBirth;
            this.tbDateOfBirth.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDateOfBirth.HoverState.Parent = this.tbDateOfBirth;
            this.tbDateOfBirth.Location = new System.Drawing.Point(18, 235);
            this.tbDateOfBirth.Margin = new System.Windows.Forms.Padding(5);
            this.tbDateOfBirth.Name = "tbDateOfBirth";
            this.tbDateOfBirth.PasswordChar = '\0';
            this.tbDateOfBirth.PlaceholderText = "Date Of Birth";
            this.tbDateOfBirth.SelectedText = "";
            this.tbDateOfBirth.ShadowDecoration.Parent = this.tbDateOfBirth;
            this.tbDateOfBirth.Size = new System.Drawing.Size(446, 47);
            this.tbDateOfBirth.TabIndex = 70;
            // 
            // tbEmail
            // 
            this.tbEmail.Animated = true;
            this.tbEmail.BorderRadius = 5;
            this.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.DefaultText = "";
            this.tbEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmail.DisabledState.Parent = this.tbEmail;
            this.tbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmail.Enabled = false;
            this.tbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmail.FocusedState.Parent = this.tbEmail;
            this.tbEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmail.HoverState.Parent = this.tbEmail;
            this.tbEmail.Location = new System.Drawing.Point(500, 141);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(5);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PasswordChar = '\0';
            this.tbEmail.PlaceholderText = "Email";
            this.tbEmail.SelectedText = "";
            this.tbEmail.ShadowDecoration.Parent = this.tbEmail;
            this.tbEmail.Size = new System.Drawing.Size(446, 47);
            this.tbEmail.TabIndex = 69;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Animated = true;
            this.tbPhoneNumber.BorderRadius = 5;
            this.tbPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhoneNumber.DefaultText = "";
            this.tbPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPhoneNumber.DisabledState.Parent = this.tbPhoneNumber;
            this.tbPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPhoneNumber.Enabled = false;
            this.tbPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPhoneNumber.FocusedState.Parent = this.tbPhoneNumber;
            this.tbPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPhoneNumber.HoverState.Parent = this.tbPhoneNumber;
            this.tbPhoneNumber.Location = new System.Drawing.Point(18, 141);
            this.tbPhoneNumber.Margin = new System.Windows.Forms.Padding(5);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.PasswordChar = '\0';
            this.tbPhoneNumber.PlaceholderText = "Phone Number";
            this.tbPhoneNumber.SelectedText = "";
            this.tbPhoneNumber.ShadowDecoration.Parent = this.tbPhoneNumber;
            this.tbPhoneNumber.Size = new System.Drawing.Size(446, 47);
            this.tbPhoneNumber.TabIndex = 68;
            // 
            // tbLastName
            // 
            this.tbLastName.Animated = true;
            this.tbLastName.BorderRadius = 5;
            this.tbLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLastName.DefaultText = "";
            this.tbLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLastName.DisabledState.Parent = this.tbLastName;
            this.tbLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLastName.Enabled = false;
            this.tbLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLastName.FocusedState.Parent = this.tbLastName;
            this.tbLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLastName.HoverState.Parent = this.tbLastName;
            this.tbLastName.Location = new System.Drawing.Point(500, 94);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(5);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.PasswordChar = '\0';
            this.tbLastName.PlaceholderText = "Last Name";
            this.tbLastName.SelectedText = "";
            this.tbLastName.ShadowDecoration.Parent = this.tbLastName;
            this.tbLastName.Size = new System.Drawing.Size(446, 47);
            this.tbLastName.TabIndex = 67;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Animated = true;
            this.tbFirstName.BorderRadius = 5;
            this.tbFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFirstName.DefaultText = "";
            this.tbFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFirstName.DisabledState.Parent = this.tbFirstName;
            this.tbFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFirstName.Enabled = false;
            this.tbFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFirstName.FocusedState.Parent = this.tbFirstName;
            this.tbFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFirstName.HoverState.Parent = this.tbFirstName;
            this.tbFirstName.Location = new System.Drawing.Point(18, 94);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(5);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.PasswordChar = '\0';
            this.tbFirstName.PlaceholderText = "First Name";
            this.tbFirstName.SelectedText = "";
            this.tbFirstName.ShadowDecoration.Parent = this.tbFirstName;
            this.tbFirstName.Size = new System.Drawing.Size(446, 47);
            this.tbFirstName.TabIndex = 66;
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
            this.tbClientID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbClientID.FocusedState.Parent = this.tbClientID;
            this.tbClientID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbClientID.HoverState.Parent = this.tbClientID;
            this.tbClientID.Location = new System.Drawing.Point(18, 47);
            this.tbClientID.Margin = new System.Windows.Forms.Padding(5);
            this.tbClientID.Name = "tbClientID";
            this.tbClientID.PasswordChar = '\0';
            this.tbClientID.PlaceholderText = "Enter The ClientID To Find A Client";
            this.tbClientID.SelectedText = "";
            this.tbClientID.ShadowDecoration.Parent = this.tbClientID;
            this.tbClientID.Size = new System.Drawing.Size(928, 47);
            this.tbClientID.TabIndex = 65;
            this.tbClientID.TextChanged += new System.EventHandler(this.tbClientID_TextChanged);
            // 
            // tbCountry
            // 
            this.tbCountry.Animated = true;
            this.tbCountry.BorderRadius = 5;
            this.tbCountry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCountry.DefaultText = "";
            this.tbCountry.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCountry.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCountry.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCountry.DisabledState.Parent = this.tbCountry;
            this.tbCountry.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCountry.Enabled = false;
            this.tbCountry.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCountry.FocusedState.Parent = this.tbCountry;
            this.tbCountry.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCountry.HoverState.Parent = this.tbCountry;
            this.tbCountry.Location = new System.Drawing.Point(500, 188);
            this.tbCountry.Margin = new System.Windows.Forms.Padding(5);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.PasswordChar = '\0';
            this.tbCountry.PlaceholderText = "Country";
            this.tbCountry.SelectedText = "";
            this.tbCountry.ShadowDecoration.Parent = this.tbCountry;
            this.tbCountry.Size = new System.Drawing.Size(446, 47);
            this.tbCountry.TabIndex = 75;
            // 
            // tbCreateDate
            // 
            this.tbCreateDate.Animated = true;
            this.tbCreateDate.BorderRadius = 5;
            this.tbCreateDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCreateDate.DefaultText = "";
            this.tbCreateDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCreateDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCreateDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCreateDate.DisabledState.Parent = this.tbCreateDate;
            this.tbCreateDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCreateDate.Enabled = false;
            this.tbCreateDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCreateDate.FocusedState.Parent = this.tbCreateDate;
            this.tbCreateDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCreateDate.HoverState.Parent = this.tbCreateDate;
            this.tbCreateDate.Location = new System.Drawing.Point(500, 235);
            this.tbCreateDate.Margin = new System.Windows.Forms.Padding(5);
            this.tbCreateDate.Name = "tbCreateDate";
            this.tbCreateDate.PasswordChar = '\0';
            this.tbCreateDate.PlaceholderText = "Create Date";
            this.tbCreateDate.SelectedText = "";
            this.tbCreateDate.ShadowDecoration.Parent = this.tbCreateDate;
            this.tbCreateDate.Size = new System.Drawing.Size(446, 47);
            this.tbCreateDate.TabIndex = 76;
            // 
            // FindClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 622);
            this.Controls.Add(this.tbCreateDate);
            this.Controls.Add(this.tbCountry);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbDateOfBirth);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbClientID);
            this.Controls.Add(this.lblFindClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FindClient";
            this.Text = "FindClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFindClient;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2TextBox tbCity;
        private Guna.UI2.WinForms.Guna2TextBox tbDateOfBirth;
        private Guna.UI2.WinForms.Guna2TextBox tbEmail;
        private Guna.UI2.WinForms.Guna2TextBox tbPhoneNumber;
        private Guna.UI2.WinForms.Guna2TextBox tbLastName;
        private Guna.UI2.WinForms.Guna2TextBox tbFirstName;
        private Guna.UI2.WinForms.Guna2TextBox tbClientID;
        private Guna.UI2.WinForms.Guna2TextBox tbCountry;
        private Guna.UI2.WinForms.Guna2TextBox tbCreateDate;
    }
}