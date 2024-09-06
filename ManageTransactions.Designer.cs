namespace BankProject
{
    partial class ManageTransactions
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
            this.lblManageTransactions = new System.Windows.Forms.Label();
            this.PanelTransactions = new System.Windows.Forms.Panel();
            this.btnTotalBalances = new Guna.UI2.WinForms.Guna2Button();
            this.btnTransfer = new Guna.UI2.WinForms.Guna2Button();
            this.btnWithdraw = new Guna.UI2.WinForms.Guna2Button();
            this.btnTransferLog = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeposit = new Guna.UI2.WinForms.Guna2Button();
            this.PanelTransactions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblManageTransactions
            // 
            this.lblManageTransactions.AutoSize = true;
            this.lblManageTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageTransactions.ForeColor = System.Drawing.Color.Black;
            this.lblManageTransactions.Location = new System.Drawing.Point(12, 9);
            this.lblManageTransactions.Name = "lblManageTransactions";
            this.lblManageTransactions.Size = new System.Drawing.Size(314, 33);
            this.lblManageTransactions.TabIndex = 2;
            this.lblManageTransactions.Text = "Manage Transactions";
            // 
            // PanelTransactions
            // 
            this.PanelTransactions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelTransactions.Controls.Add(this.btnTotalBalances);
            this.PanelTransactions.Controls.Add(this.btnTransfer);
            this.PanelTransactions.Controls.Add(this.btnWithdraw);
            this.PanelTransactions.Controls.Add(this.btnTransferLog);
            this.PanelTransactions.Controls.Add(this.btnDeposit);
            this.PanelTransactions.Location = new System.Drawing.Point(18, 45);
            this.PanelTransactions.Name = "PanelTransactions";
            this.PanelTransactions.Size = new System.Drawing.Size(942, 549);
            this.PanelTransactions.TabIndex = 26;
            // 
            // btnTotalBalances
            // 
            this.btnTotalBalances.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTotalBalances.BorderRadius = 30;
            this.btnTotalBalances.CheckedState.Parent = this.btnTotalBalances;
            this.btnTotalBalances.CustomImages.Parent = this.btnTotalBalances;
            this.btnTotalBalances.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTotalBalances.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnTotalBalances.ForeColor = System.Drawing.Color.Black;
            this.btnTotalBalances.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnTotalBalances.HoverState.Parent = this.btnTotalBalances;
            this.btnTotalBalances.Image = global::BankProject.Properties.Resources.TotalBalancesIcon;
            this.btnTotalBalances.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTotalBalances.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTotalBalances.Location = new System.Drawing.Point(530, 281);
            this.btnTotalBalances.Name = "btnTotalBalances";
            this.btnTotalBalances.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTotalBalances.ShadowDecoration.Parent = this.btnTotalBalances;
            this.btnTotalBalances.Size = new System.Drawing.Size(249, 158);
            this.btnTotalBalances.TabIndex = 29;
            this.btnTotalBalances.Text = "Total Balances";
            this.btnTotalBalances.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTotalBalances.Click += new System.EventHandler(this.btnTotalBalances_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTransfer.BorderRadius = 30;
            this.btnTransfer.CheckedState.Parent = this.btnTransfer;
            this.btnTransfer.CustomImages.Parent = this.btnTransfer;
            this.btnTransfer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTransfer.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnTransfer.ForeColor = System.Drawing.Color.Black;
            this.btnTransfer.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnTransfer.HoverState.Parent = this.btnTransfer;
            this.btnTransfer.Image = global::BankProject.Properties.Resources.TransferIcon;
            this.btnTransfer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTransfer.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTransfer.Location = new System.Drawing.Point(664, 84);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTransfer.ShadowDecoration.Parent = this.btnTransfer;
            this.btnTransfer.Size = new System.Drawing.Size(249, 158);
            this.btnTransfer.TabIndex = 28;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnWithdraw.BorderRadius = 30;
            this.btnWithdraw.CheckedState.Parent = this.btnWithdraw;
            this.btnWithdraw.CustomImages.Parent = this.btnWithdraw;
            this.btnWithdraw.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnWithdraw.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnWithdraw.ForeColor = System.Drawing.Color.Black;
            this.btnWithdraw.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnWithdraw.HoverState.Parent = this.btnWithdraw;
            this.btnWithdraw.Image = global::BankProject.Properties.Resources.WithdrawIcon;
            this.btnWithdraw.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnWithdraw.ImageSize = new System.Drawing.Size(30, 30);
            this.btnWithdraw.Location = new System.Drawing.Point(345, 84);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnWithdraw.ShadowDecoration.Parent = this.btnWithdraw;
            this.btnWithdraw.Size = new System.Drawing.Size(249, 158);
            this.btnWithdraw.TabIndex = 27;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnTransferLog
            // 
            this.btnTransferLog.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTransferLog.BorderRadius = 30;
            this.btnTransferLog.CheckedState.Parent = this.btnTransferLog;
            this.btnTransferLog.CustomImages.Parent = this.btnTransferLog;
            this.btnTransferLog.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTransferLog.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnTransferLog.ForeColor = System.Drawing.Color.Black;
            this.btnTransferLog.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnTransferLog.HoverState.Parent = this.btnTransferLog;
            this.btnTransferLog.Image = global::BankProject.Properties.Resources.History1;
            this.btnTransferLog.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTransferLog.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTransferLog.Location = new System.Drawing.Point(193, 281);
            this.btnTransferLog.Name = "btnTransferLog";
            this.btnTransferLog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTransferLog.ShadowDecoration.Parent = this.btnTransferLog;
            this.btnTransferLog.Size = new System.Drawing.Size(249, 158);
            this.btnTransferLog.TabIndex = 30;
            this.btnTransferLog.Text = "Transfer Log";
            this.btnTransferLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTransferLog.Click += new System.EventHandler(this.btnTransactionsLog_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeposit.BorderRadius = 30;
            this.btnDeposit.CheckedState.Parent = this.btnDeposit;
            this.btnDeposit.CustomImages.Parent = this.btnDeposit;
            this.btnDeposit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDeposit.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnDeposit.ForeColor = System.Drawing.Color.Black;
            this.btnDeposit.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnDeposit.HoverState.Parent = this.btnDeposit;
            this.btnDeposit.Image = global::BankProject.Properties.Resources.DepositIcon;
            this.btnDeposit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeposit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeposit.Location = new System.Drawing.Point(36, 84);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDeposit.ShadowDecoration.Parent = this.btnDeposit;
            this.btnDeposit.Size = new System.Drawing.Size(249, 158);
            this.btnDeposit.TabIndex = 26;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // ManageTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(972, 606);
            this.Controls.Add(this.PanelTransactions);
            this.Controls.Add(this.lblManageTransactions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageTransactions";
            this.Text = "ManageTransactions";
            this.PanelTransactions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManageTransactions;
        private System.Windows.Forms.Panel PanelTransactions;
        private Guna.UI2.WinForms.Guna2Button btnTotalBalances;
        private Guna.UI2.WinForms.Guna2Button btnTransfer;
        private Guna.UI2.WinForms.Guna2Button btnWithdraw;
        private Guna.UI2.WinForms.Guna2Button btnTransferLog;
        private Guna.UI2.WinForms.Guna2Button btnDeposit;
    }
}