namespace BankProject
{
    partial class ManageUsere
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
            this.lblManageUsers = new System.Windows.Forms.Label();
            this.PanelUsers = new System.Windows.Forms.Panel();
            this.btnFindUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnLUsersList = new Guna.UI2.WinForms.Guna2Button();
            this.PanelUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblManageUsers
            // 
            this.lblManageUsers.AutoSize = true;
            this.lblManageUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageUsers.ForeColor = System.Drawing.Color.Black;
            this.lblManageUsers.Location = new System.Drawing.Point(12, 9);
            this.lblManageUsers.Name = "lblManageUsers";
            this.lblManageUsers.Size = new System.Drawing.Size(216, 33);
            this.lblManageUsers.TabIndex = 1;
            this.lblManageUsers.Text = "Manage Users";
            // 
            // PanelUsers
            // 
            this.PanelUsers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelUsers.Controls.Add(this.btnFindUser);
            this.PanelUsers.Controls.Add(this.btnDeleteUser);
            this.PanelUsers.Controls.Add(this.btnAddUser);
            this.PanelUsers.Controls.Add(this.btnUpdateUser);
            this.PanelUsers.Controls.Add(this.btnLUsersList);
            this.PanelUsers.Location = new System.Drawing.Point(18, 45);
            this.PanelUsers.Name = "PanelUsers";
            this.PanelUsers.Size = new System.Drawing.Size(949, 549);
            this.PanelUsers.TabIndex = 21;
            // 
            // btnFindUser
            // 
            this.btnFindUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFindUser.BorderRadius = 30;
            this.btnFindUser.CheckedState.Parent = this.btnFindUser;
            this.btnFindUser.CustomImages.Parent = this.btnFindUser;
            this.btnFindUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFindUser.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnFindUser.ForeColor = System.Drawing.Color.Black;
            this.btnFindUser.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnFindUser.HoverState.Parent = this.btnFindUser;
            this.btnFindUser.Image = global::BankProject.Properties.Resources.FindClientIcon;
            this.btnFindUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFindUser.ImageSize = new System.Drawing.Size(30, 30);
            this.btnFindUser.Location = new System.Drawing.Point(674, 80);
            this.btnFindUser.Name = "btnFindUser";
            this.btnFindUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFindUser.ShadowDecoration.Parent = this.btnFindUser;
            this.btnFindUser.Size = new System.Drawing.Size(249, 158);
            this.btnFindUser.TabIndex = 24;
            this.btnFindUser.Text = "Find User";
            this.btnFindUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFindUser.Click += new System.EventHandler(this.btnFindUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteUser.BorderRadius = 30;
            this.btnDeleteUser.CheckedState.Parent = this.btnDeleteUser;
            this.btnDeleteUser.CustomImages.Parent = this.btnDeleteUser;
            this.btnDeleteUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDeleteUser.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnDeleteUser.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteUser.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnDeleteUser.HoverState.Parent = this.btnDeleteUser;
            this.btnDeleteUser.Image = global::BankProject.Properties.Resources.DeleteClientIcon;
            this.btnDeleteUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteUser.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteUser.Location = new System.Drawing.Point(522, 276);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDeleteUser.ShadowDecoration.Parent = this.btnDeleteUser;
            this.btnDeleteUser.Size = new System.Drawing.Size(249, 158);
            this.btnDeleteUser.TabIndex = 23;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddUser.BorderRadius = 30;
            this.btnAddUser.CheckedState.Parent = this.btnAddUser;
            this.btnAddUser.CustomImages.Parent = this.btnAddUser;
            this.btnAddUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnAddUser.ForeColor = System.Drawing.Color.Black;
            this.btnAddUser.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnAddUser.HoverState.Parent = this.btnAddUser;
            this.btnAddUser.Image = global::BankProject.Properties.Resources.AddClientIcon;
            this.btnAddUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddUser.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddUser.Location = new System.Drawing.Point(350, 80);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddUser.ShadowDecoration.Parent = this.btnAddUser;
            this.btnAddUser.Size = new System.Drawing.Size(249, 158);
            this.btnAddUser.TabIndex = 22;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateUser.BorderRadius = 30;
            this.btnUpdateUser.CheckedState.Parent = this.btnUpdateUser;
            this.btnUpdateUser.CustomImages.Parent = this.btnUpdateUser;
            this.btnUpdateUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdateUser.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnUpdateUser.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateUser.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnUpdateUser.HoverState.Parent = this.btnUpdateUser;
            this.btnUpdateUser.Image = global::BankProject.Properties.Resources.UpdateClientIcon;
            this.btnUpdateUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateUser.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdateUser.Location = new System.Drawing.Point(194, 276);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpdateUser.ShadowDecoration.Parent = this.btnUpdateUser;
            this.btnUpdateUser.Size = new System.Drawing.Size(249, 158);
            this.btnUpdateUser.TabIndex = 25;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnLUsersList
            // 
            this.btnLUsersList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLUsersList.BorderRadius = 30;
            this.btnLUsersList.CheckedState.Parent = this.btnLUsersList;
            this.btnLUsersList.CustomImages.Parent = this.btnLUsersList;
            this.btnLUsersList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLUsersList.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnLUsersList.ForeColor = System.Drawing.Color.Black;
            this.btnLUsersList.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnLUsersList.HoverState.Parent = this.btnLUsersList;
            this.btnLUsersList.Image = global::BankProject.Properties.Resources.ClientsListIcon;
            this.btnLUsersList.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLUsersList.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLUsersList.Location = new System.Drawing.Point(41, 80);
            this.btnLUsersList.Name = "btnLUsersList";
            this.btnLUsersList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLUsersList.ShadowDecoration.Parent = this.btnLUsersList;
            this.btnLUsersList.Size = new System.Drawing.Size(249, 158);
            this.btnLUsersList.TabIndex = 21;
            this.btnLUsersList.Text = "Users List";
            this.btnLUsersList.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLUsersList.Click += new System.EventHandler(this.btnLUsersList_Click);
            // 
            // ManageUsere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(972, 606);
            this.Controls.Add(this.PanelUsers);
            this.Controls.Add(this.lblManageUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageUsere";
            this.Text = "ManageUsere";
            this.Load += new System.EventHandler(this.ManageUsere_Load);
            this.PanelUsers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManageUsers;
        private System.Windows.Forms.Panel PanelUsers;
        private Guna.UI2.WinForms.Guna2Button btnFindUser;
        private Guna.UI2.WinForms.Guna2Button btnDeleteUser;
        private Guna.UI2.WinForms.Guna2Button btnAddUser;
        private Guna.UI2.WinForms.Guna2Button btnUpdateUser;
        private Guna.UI2.WinForms.Guna2Button btnLUsersList;
    }
}