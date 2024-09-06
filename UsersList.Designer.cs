namespace BankProject
{
    partial class UsersList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblUsersList = new System.Windows.Forms.Label();
            this.UsersListGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsersListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsersList
            // 
            this.lblUsersList.AutoSize = true;
            this.lblUsersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsersList.ForeColor = System.Drawing.Color.Black;
            this.lblUsersList.Location = new System.Drawing.Point(12, 9);
            this.lblUsersList.Name = "lblUsersList";
            this.lblUsersList.Size = new System.Drawing.Size(156, 33);
            this.lblUsersList.TabIndex = 3;
            this.lblUsersList.Text = "Users List";
            // 
            // UsersListGrid
            // 
            this.UsersListGrid.AllowUserToAddRows = false;
            this.UsersListGrid.AllowUserToDeleteRows = false;
            this.UsersListGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
            this.UsersListGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.UsersListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersListGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.UsersListGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsersListGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UsersListGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersListGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.UsersListGrid.ColumnHeadersHeight = 30;
            this.UsersListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UsersListGrid.DefaultCellStyle = dataGridViewCellStyle9;
            this.UsersListGrid.EnableHeadersVisualStyles = false;
            this.UsersListGrid.GridColor = System.Drawing.Color.Silver;
            this.UsersListGrid.Location = new System.Drawing.Point(0, 57);
            this.UsersListGrid.Margin = new System.Windows.Forms.Padding(4);
            this.UsersListGrid.Name = "UsersListGrid";
            this.UsersListGrid.ReadOnly = true;
            this.UsersListGrid.RowHeadersVisible = false;
            this.UsersListGrid.RowHeadersWidth = 51;
            this.UsersListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersListGrid.ShowEditingIcon = false;
            this.UsersListGrid.Size = new System.Drawing.Size(1037, 509);
            this.UsersListGrid.TabIndex = 26;
            this.UsersListGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.UsersListGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Silver;
            this.UsersListGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.UsersListGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.UsersListGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.UsersListGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.UsersListGrid.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.UsersListGrid.ThemeStyle.GridColor = System.Drawing.Color.Silver;
            this.UsersListGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.UsersListGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.UsersListGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.UsersListGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.UsersListGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.UsersListGrid.ThemeStyle.HeaderStyle.Height = 30;
            this.UsersListGrid.ThemeStyle.ReadOnly = true;
            this.UsersListGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Silver;
            this.UsersListGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UsersListGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.UsersListGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.UsersListGrid.ThemeStyle.RowsStyle.Height = 22;
            this.UsersListGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.UsersListGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
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
            this.btnBack.Location = new System.Drawing.Point(18, 570);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(140, 39);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // UsersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 622);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.UsersListGrid);
            this.Controls.Add(this.lblUsersList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsersList";
            this.Text = "UsersList";
            this.Load += new System.EventHandler(this.UsersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsersListGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsersList;
        private Guna.UI2.WinForms.Guna2DataGridView UsersListGrid;
        private Guna.UI2.WinForms.Guna2Button btnBack;
    }
}