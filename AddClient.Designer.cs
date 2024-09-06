namespace BankProject
{
    partial class AddClient
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
            this.lblAddClient = new System.Windows.Forms.Label();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddClient = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.tbID = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbCountry = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbCity = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbDateOfBirth = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // lblAddClient
            // 
            this.lblAddClient.AutoSize = true;
            this.lblAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddClient.ForeColor = System.Drawing.Color.Black;
            this.lblAddClient.Location = new System.Drawing.Point(12, 9);
            this.lblAddClient.Name = "lblAddClient";
            this.lblAddClient.Size = new System.Drawing.Size(159, 33);
            this.lblAddClient.TabIndex = 1;
            this.lblAddClient.Text = "Add Client";
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
            this.btnClear.Location = new System.Drawing.Point(628, 295);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.Parent = this.btnClear;
            this.btnClear.Size = new System.Drawing.Size(140, 39);
            this.btnClear.TabIndex = 38;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddClient.Animated = true;
            this.btnAddClient.BorderRadius = 2;
            this.btnAddClient.CheckedState.Parent = this.btnAddClient;
            this.btnAddClient.CustomImages.Parent = this.btnAddClient;
            this.btnAddClient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnAddClient.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddClient.ForeColor = System.Drawing.Color.White;
            this.btnAddClient.HoverState.Parent = this.btnAddClient;
            this.btnAddClient.Location = new System.Drawing.Point(776, 295);
            this.btnAddClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.ShadowDecoration.Parent = this.btnAddClient;
            this.btnAddClient.Size = new System.Drawing.Size(140, 39);
            this.btnAddClient.TabIndex = 37;
            this.btnAddClient.Text = "Add";
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
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
            this.btnBack.Location = new System.Drawing.Point(-12, 295);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(140, 39);
            this.btnBack.TabIndex = 36;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tbID
            // 
            this.tbID.Animated = true;
            this.tbID.BorderRadius = 5;
            this.tbID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbID.DefaultText = "";
            this.tbID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbID.DisabledState.Parent = this.tbID;
            this.tbID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbID.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbID.FocusedState.Parent = this.tbID;
            this.tbID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbID.HoverState.Parent = this.tbID;
            this.tbID.Location = new System.Drawing.Point(13, 49);
            this.tbID.Margin = new System.Windows.Forms.Padding(5);
            this.tbID.Name = "tbID";
            this.tbID.PasswordChar = '\0';
            this.tbID.PlaceholderText = "ID";
            this.tbID.SelectedText = "";
            this.tbID.ShadowDecoration.Parent = this.tbID;
            this.tbID.Size = new System.Drawing.Size(928, 47);
            this.tbID.TabIndex = 35;
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
            this.tbCountry.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbCountry.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCountry.FocusedState.Parent = this.tbCountry;
            this.tbCountry.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCountry.HoverState.Parent = this.tbCountry;
            this.tbCountry.Location = new System.Drawing.Point(495, 191);
            this.tbCountry.Margin = new System.Windows.Forms.Padding(5);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.PasswordChar = '\0';
            this.tbCountry.PlaceholderText = "Country";
            this.tbCountry.SelectedText = "";
            this.tbCountry.ShadowDecoration.Parent = this.tbCountry;
            this.tbCountry.Size = new System.Drawing.Size(446, 47);
            this.tbCountry.TabIndex = 34;
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
            this.tbEmail.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmail.FocusedState.Parent = this.tbEmail;
            this.tbEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmail.HoverState.Parent = this.tbEmail;
            this.tbEmail.Location = new System.Drawing.Point(13, 143);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(5);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PasswordChar = '\0';
            this.tbEmail.PlaceholderText = "Email";
            this.tbEmail.SelectedText = "";
            this.tbEmail.ShadowDecoration.Parent = this.tbEmail;
            this.tbEmail.Size = new System.Drawing.Size(446, 47);
            this.tbEmail.TabIndex = 33;
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
            this.tbPhoneNumber.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPhoneNumber.FocusedState.Parent = this.tbPhoneNumber;
            this.tbPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPhoneNumber.HoverState.Parent = this.tbPhoneNumber;
            this.tbPhoneNumber.Location = new System.Drawing.Point(495, 143);
            this.tbPhoneNumber.Margin = new System.Windows.Forms.Padding(5);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.PasswordChar = '\0';
            this.tbPhoneNumber.PlaceholderText = "Phone Number";
            this.tbPhoneNumber.SelectedText = "";
            this.tbPhoneNumber.ShadowDecoration.Parent = this.tbPhoneNumber;
            this.tbPhoneNumber.Size = new System.Drawing.Size(446, 47);
            this.tbPhoneNumber.TabIndex = 32;
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
            this.tbLastName.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLastName.FocusedState.Parent = this.tbLastName;
            this.tbLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLastName.HoverState.Parent = this.tbLastName;
            this.tbLastName.Location = new System.Drawing.Point(495, 96);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(5);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.PasswordChar = '\0';
            this.tbLastName.PlaceholderText = "Last Name";
            this.tbLastName.SelectedText = "";
            this.tbLastName.ShadowDecoration.Parent = this.tbLastName;
            this.tbLastName.Size = new System.Drawing.Size(446, 47);
            this.tbLastName.TabIndex = 31;
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
            this.tbFirstName.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFirstName.FocusedState.Parent = this.tbFirstName;
            this.tbFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFirstName.HoverState.Parent = this.tbFirstName;
            this.tbFirstName.Location = new System.Drawing.Point(13, 96);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(5);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.PasswordChar = '\0';
            this.tbFirstName.PlaceholderText = "First Name";
            this.tbFirstName.SelectedText = "";
            this.tbFirstName.ShadowDecoration.Parent = this.tbFirstName;
            this.tbFirstName.Size = new System.Drawing.Size(446, 47);
            this.tbFirstName.TabIndex = 30;
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
            this.tbCity.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbCity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCity.FocusedState.Parent = this.tbCity;
            this.tbCity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCity.HoverState.Parent = this.tbCity;
            this.tbCity.Location = new System.Drawing.Point(13, 191);
            this.tbCity.Margin = new System.Windows.Forms.Padding(5);
            this.tbCity.Name = "tbCity";
            this.tbCity.PasswordChar = '\0';
            this.tbCity.PlaceholderText = "City";
            this.tbCity.SelectedText = "";
            this.tbCity.ShadowDecoration.Parent = this.tbCity;
            this.tbCity.Size = new System.Drawing.Size(446, 47);
            this.tbCity.TabIndex = 29;
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
            this.tbDateOfBirth.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbDateOfBirth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDateOfBirth.FocusedState.Parent = this.tbDateOfBirth;
            this.tbDateOfBirth.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDateOfBirth.HoverState.Parent = this.tbDateOfBirth;
            this.tbDateOfBirth.Location = new System.Drawing.Point(13, 239);
            this.tbDateOfBirth.Margin = new System.Windows.Forms.Padding(5);
            this.tbDateOfBirth.Name = "tbDateOfBirth";
            this.tbDateOfBirth.PasswordChar = '\0';
            this.tbDateOfBirth.PlaceholderText = "Date Of Birth";
            this.tbDateOfBirth.SelectedText = "";
            this.tbDateOfBirth.ShadowDecoration.Parent = this.tbDateOfBirth;
            this.tbDateOfBirth.Size = new System.Drawing.Size(928, 47);
            this.tbDateOfBirth.TabIndex = 39;
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 622);
            this.Controls.Add(this.tbDateOfBirth);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.tbCountry);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.lblAddClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddClient";
            this.Text = "AddClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddClient;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnAddClient;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2TextBox tbID;
        private Guna.UI2.WinForms.Guna2TextBox tbCountry;
        private Guna.UI2.WinForms.Guna2TextBox tbEmail;
        private Guna.UI2.WinForms.Guna2TextBox tbPhoneNumber;
        private Guna.UI2.WinForms.Guna2TextBox tbLastName;
        private Guna.UI2.WinForms.Guna2TextBox tbFirstName;
        private Guna.UI2.WinForms.Guna2TextBox tbCity;
        private Guna.UI2.WinForms.Guna2TextBox tbDateOfBirth;
    }
}