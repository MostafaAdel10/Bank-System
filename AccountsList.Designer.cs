namespace BankProject
{
    partial class AccountsList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblAccountsList = new System.Windows.Forms.Label();
            this.AccountsListGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAccountsList
            // 
            this.lblAccountsList.AutoSize = true;
            this.lblAccountsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountsList.ForeColor = System.Drawing.Color.Black;
            this.lblAccountsList.Location = new System.Drawing.Point(12, 9);
            this.lblAccountsList.Name = "lblAccountsList";
            this.lblAccountsList.Size = new System.Drawing.Size(202, 33);
            this.lblAccountsList.TabIndex = 2;
            this.lblAccountsList.Text = "Accounts List";
            // 
            // AccountsListGrid
            // 
            this.AccountsListGrid.AllowUserToAddRows = false;
            this.AccountsListGrid.AllowUserToDeleteRows = false;
            this.AccountsListGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            this.AccountsListGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.AccountsListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AccountsListGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.AccountsListGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AccountsListGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AccountsListGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AccountsListGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.AccountsListGrid.ColumnHeadersHeight = 30;
            this.AccountsListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AccountsListGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.AccountsListGrid.EnableHeadersVisualStyles = false;
            this.AccountsListGrid.GridColor = System.Drawing.Color.Silver;
            this.AccountsListGrid.Location = new System.Drawing.Point(0, 53);
            this.AccountsListGrid.Margin = new System.Windows.Forms.Padding(4);
            this.AccountsListGrid.Name = "AccountsListGrid";
            this.AccountsListGrid.ReadOnly = true;
            this.AccountsListGrid.RowHeadersVisible = false;
            this.AccountsListGrid.RowHeadersWidth = 51;
            this.AccountsListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AccountsListGrid.ShowEditingIcon = false;
            this.AccountsListGrid.Size = new System.Drawing.Size(1037, 509);
            this.AccountsListGrid.TabIndex = 25;
            this.AccountsListGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.AccountsListGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Silver;
            this.AccountsListGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.AccountsListGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.AccountsListGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.AccountsListGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.AccountsListGrid.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.AccountsListGrid.ThemeStyle.GridColor = System.Drawing.Color.Silver;
            this.AccountsListGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.AccountsListGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AccountsListGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.AccountsListGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AccountsListGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.AccountsListGrid.ThemeStyle.HeaderStyle.Height = 30;
            this.AccountsListGrid.ThemeStyle.ReadOnly = true;
            this.AccountsListGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Silver;
            this.AccountsListGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AccountsListGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.AccountsListGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.AccountsListGrid.ThemeStyle.RowsStyle.Height = 22;
            this.AccountsListGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.AccountsListGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
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
            this.btnBack.Location = new System.Drawing.Point(13, 570);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(140, 39);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AccountsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1037, 622);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.AccountsListGrid);
            this.Controls.Add(this.lblAccountsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountsList";
            this.Text = "AccountsList";
            this.Load += new System.EventHandler(this.AccountsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AccountsListGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccountsList;
        private Guna.UI2.WinForms.Guna2DataGridView AccountsListGrid;
        private Guna.UI2.WinForms.Guna2Button btnBack;
    }
}