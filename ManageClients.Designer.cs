namespace BankProject
{
    partial class ManageClients
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
            this.lblManageClients = new System.Windows.Forms.Label();
            this.PanelClients = new System.Windows.Forms.Panel();
            this.btnFindClient = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteClient = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddClient = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateClient = new Guna.UI2.WinForms.Guna2Button();
            this.btnListClient = new Guna.UI2.WinForms.Guna2Button();
            this.PanelClients.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblManageClients
            // 
            this.lblManageClients.AutoSize = true;
            this.lblManageClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageClients.ForeColor = System.Drawing.Color.Black;
            this.lblManageClients.Location = new System.Drawing.Point(12, 9);
            this.lblManageClients.Name = "lblManageClients";
            this.lblManageClients.Size = new System.Drawing.Size(231, 33);
            this.lblManageClients.TabIndex = 0;
            this.lblManageClients.Text = "Manage Clients";
            // 
            // PanelClients
            // 
            this.PanelClients.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelClients.Controls.Add(this.btnFindClient);
            this.PanelClients.Controls.Add(this.btnDeleteClient);
            this.PanelClients.Controls.Add(this.btnAddClient);
            this.PanelClients.Controls.Add(this.btnUpdateClient);
            this.PanelClients.Controls.Add(this.btnListClient);
            this.PanelClients.Location = new System.Drawing.Point(12, 45);
            this.PanelClients.Name = "PanelClients";
            this.PanelClients.Size = new System.Drawing.Size(960, 562);
            this.PanelClients.TabIndex = 16;
            // 
            // btnFindClient
            // 
            this.btnFindClient.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFindClient.BorderRadius = 30;
            this.btnFindClient.CheckedState.Parent = this.btnFindClient;
            this.btnFindClient.CustomImages.Parent = this.btnFindClient;
            this.btnFindClient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFindClient.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnFindClient.ForeColor = System.Drawing.Color.Black;
            this.btnFindClient.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnFindClient.HoverState.Parent = this.btnFindClient;
            this.btnFindClient.Image = global::BankProject.Properties.Resources.FindClientIcon;
            this.btnFindClient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFindClient.ImageSize = new System.Drawing.Size(30, 30);
            this.btnFindClient.Location = new System.Drawing.Point(643, 78);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFindClient.ShadowDecoration.Parent = this.btnFindClient;
            this.btnFindClient.Size = new System.Drawing.Size(249, 158);
            this.btnFindClient.TabIndex = 19;
            this.btnFindClient.Text = "Find Client";
            this.btnFindClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFindClient.Click += new System.EventHandler(this.btnFindClient_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteClient.BorderRadius = 30;
            this.btnDeleteClient.CheckedState.Parent = this.btnDeleteClient;
            this.btnDeleteClient.CustomImages.Parent = this.btnDeleteClient;
            this.btnDeleteClient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDeleteClient.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnDeleteClient.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteClient.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnDeleteClient.HoverState.Parent = this.btnDeleteClient;
            this.btnDeleteClient.Image = global::BankProject.Properties.Resources.DeleteClientIcon;
            this.btnDeleteClient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteClient.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteClient.Location = new System.Drawing.Point(517, 276);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDeleteClient.ShadowDecoration.Parent = this.btnDeleteClient;
            this.btnDeleteClient.Size = new System.Drawing.Size(249, 158);
            this.btnDeleteClient.TabIndex = 18;
            this.btnDeleteClient.Text = "Delete Client";
            this.btnDeleteClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddClient.BorderRadius = 30;
            this.btnAddClient.CheckedState.Parent = this.btnAddClient;
            this.btnAddClient.CustomImages.Parent = this.btnAddClient;
            this.btnAddClient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddClient.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnAddClient.ForeColor = System.Drawing.Color.Black;
            this.btnAddClient.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnAddClient.HoverState.Parent = this.btnAddClient;
            this.btnAddClient.Image = global::BankProject.Properties.Resources.AddClientIcon;
            this.btnAddClient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddClient.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddClient.Location = new System.Drawing.Point(343, 78);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddClient.ShadowDecoration.Parent = this.btnAddClient;
            this.btnAddClient.Size = new System.Drawing.Size(249, 158);
            this.btnAddClient.TabIndex = 17;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateClient.BorderRadius = 30;
            this.btnUpdateClient.CheckedState.Parent = this.btnUpdateClient;
            this.btnUpdateClient.CustomImages.Parent = this.btnUpdateClient;
            this.btnUpdateClient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdateClient.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnUpdateClient.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateClient.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnUpdateClient.HoverState.Parent = this.btnUpdateClient;
            this.btnUpdateClient.Image = global::BankProject.Properties.Resources.UpdateClientIcon;
            this.btnUpdateClient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateClient.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdateClient.Location = new System.Drawing.Point(186, 276);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpdateClient.ShadowDecoration.Parent = this.btnUpdateClient;
            this.btnUpdateClient.Size = new System.Drawing.Size(249, 158);
            this.btnUpdateClient.TabIndex = 20;
            this.btnUpdateClient.Text = "Update Client";
            this.btnUpdateClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // btnListClient
            // 
            this.btnListClient.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnListClient.BorderRadius = 30;
            this.btnListClient.CheckedState.Parent = this.btnListClient;
            this.btnListClient.CustomImages.Parent = this.btnListClient;
            this.btnListClient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnListClient.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnListClient.ForeColor = System.Drawing.Color.Black;
            this.btnListClient.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnListClient.HoverState.Parent = this.btnListClient;
            this.btnListClient.Image = global::BankProject.Properties.Resources.ClientsListIcon;
            this.btnListClient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnListClient.ImageSize = new System.Drawing.Size(30, 30);
            this.btnListClient.Location = new System.Drawing.Point(43, 78);
            this.btnListClient.Name = "btnListClient";
            this.btnListClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnListClient.ShadowDecoration.Parent = this.btnListClient;
            this.btnListClient.Size = new System.Drawing.Size(249, 158);
            this.btnListClient.TabIndex = 16;
            this.btnListClient.Text = "Clients List";
            this.btnListClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnListClient.Click += new System.EventHandler(this.btnListClient_Click);
            // 
            // ManageClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(972, 606);
            this.Controls.Add(this.PanelClients);
            this.Controls.Add(this.lblManageClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageClients";
            this.Text = "ManageClients";
            this.PanelClients.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManageClients;
        private System.Windows.Forms.Panel PanelClients;
        private Guna.UI2.WinForms.Guna2Button btnFindClient;
        private Guna.UI2.WinForms.Guna2Button btnDeleteClient;
        private Guna.UI2.WinForms.Guna2Button btnAddClient;
        private Guna.UI2.WinForms.Guna2Button btnUpdateClient;
        private Guna.UI2.WinForms.Guna2Button btnListClient;
    }
}