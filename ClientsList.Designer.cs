namespace BankProject
{
    partial class ClientsList
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
            this.lblClientsList = new System.Windows.Forms.Label();
            this.ClientsListGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClientsList
            // 
            this.lblClientsList.AutoSize = true;
            this.lblClientsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientsList.ForeColor = System.Drawing.Color.Black;
            this.lblClientsList.Location = new System.Drawing.Point(12, 9);
            this.lblClientsList.Name = "lblClientsList";
            this.lblClientsList.Size = new System.Drawing.Size(171, 33);
            this.lblClientsList.TabIndex = 1;
            this.lblClientsList.Text = "Clients List";
            // 
            // ClientsListGrid
            // 
            this.ClientsListGrid.AllowUserToAddRows = false;
            this.ClientsListGrid.AllowUserToDeleteRows = false;
            this.ClientsListGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
            this.ClientsListGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.ClientsListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClientsListGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ClientsListGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientsListGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ClientsListGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientsListGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ClientsListGrid.ColumnHeadersHeight = 30;
            this.ClientsListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClientsListGrid.DefaultCellStyle = dataGridViewCellStyle9;
            this.ClientsListGrid.EnableHeadersVisualStyles = false;
            this.ClientsListGrid.GridColor = System.Drawing.Color.Silver;
            this.ClientsListGrid.Location = new System.Drawing.Point(1, 46);
            this.ClientsListGrid.Margin = new System.Windows.Forms.Padding(4);
            this.ClientsListGrid.Name = "ClientsListGrid";
            this.ClientsListGrid.ReadOnly = true;
            this.ClientsListGrid.RowHeadersVisible = false;
            this.ClientsListGrid.RowHeadersWidth = 51;
            this.ClientsListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientsListGrid.ShowEditingIcon = false;
            this.ClientsListGrid.Size = new System.Drawing.Size(1037, 516);
            this.ClientsListGrid.TabIndex = 24;
            this.ClientsListGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.ClientsListGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Silver;
            this.ClientsListGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ClientsListGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ClientsListGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ClientsListGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ClientsListGrid.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.ClientsListGrid.ThemeStyle.GridColor = System.Drawing.Color.Silver;
            this.ClientsListGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.ClientsListGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ClientsListGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ClientsListGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ClientsListGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ClientsListGrid.ThemeStyle.HeaderStyle.Height = 30;
            this.ClientsListGrid.ThemeStyle.ReadOnly = true;
            this.ClientsListGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Silver;
            this.ClientsListGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ClientsListGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.ClientsListGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.ClientsListGrid.ThemeStyle.RowsStyle.Height = 22;
            this.ClientsListGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.ClientsListGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
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
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ClientsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1037, 622);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.ClientsListGrid);
            this.Controls.Add(this.lblClientsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientsList";
            this.Text = "ClientsList";
            this.Load += new System.EventHandler(this.ClientsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientsListGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClientsList;
        private Guna.UI2.WinForms.Guna2DataGridView ClientsListGrid;
        private Guna.UI2.WinForms.Guna2Button btnBack;
    }
}