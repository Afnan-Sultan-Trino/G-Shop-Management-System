namespace G_Shop
{
    partial class uUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlUserContent = new System.Windows.Forms.Panel();
            this.pnlRefresh = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlTablePic = new System.Windows.Forms.Panel();
            this.btnShowAllUsers = new System.Windows.Forms.Button();
            this.dgvUserList = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActionUser = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblUserListDescription = new System.Windows.Forms.Label();
            this.lblUserList = new System.Windows.Forms.Label();
            this.lblSearchUser = new System.Windows.Forms.Label();
            this.pnlUserContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUserContent
            // 
            this.pnlUserContent.AutoScroll = true;
            this.pnlUserContent.AutoScrollMinSize = new System.Drawing.Size(0, 1300);
            this.pnlUserContent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlUserContent.Controls.Add(this.lblSearchUser);
            this.pnlUserContent.Controls.Add(this.pnlRefresh);
            this.pnlUserContent.Controls.Add(this.btnRefresh);
            this.pnlUserContent.Controls.Add(this.pnlTablePic);
            this.pnlUserContent.Controls.Add(this.btnShowAllUsers);
            this.pnlUserContent.Controls.Add(this.dgvUserList);
            this.pnlUserContent.Controls.Add(this.btnActionUser);
            this.pnlUserContent.Controls.Add(this.txtSearch);
            this.pnlUserContent.Controls.Add(this.lblUserListDescription);
            this.pnlUserContent.Controls.Add(this.lblUserList);
            this.pnlUserContent.Location = new System.Drawing.Point(23, 34);
            this.pnlUserContent.Margin = new System.Windows.Forms.Padding(4);
            this.pnlUserContent.Name = "pnlUserContent";
            this.pnlUserContent.Size = new System.Drawing.Size(1392, 802);
            this.pnlUserContent.TabIndex = 12;
            // 
            // pnlRefresh
            // 
            this.pnlRefresh.BackColor = System.Drawing.Color.Crimson;
            this.pnlRefresh.BackgroundImage = global::G_Shop.Properties.Resources.refresh_page_option;
            this.pnlRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRefresh.Location = new System.Drawing.Point(399, 274);
            this.pnlRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRefresh.Name = "pnlRefresh";
            this.pnlRefresh.Size = new System.Drawing.Size(47, 42);
            this.pnlRefresh.TabIndex = 29;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Crimson;
            this.btnRefresh.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefresh.Location = new System.Drawing.Point(393, 270);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(217, 50);
            this.btnRefresh.TabIndex = 28;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pnlTablePic
            // 
            this.pnlTablePic.BackColor = System.Drawing.Color.YellowGreen;
            this.pnlTablePic.BackgroundImage = global::G_Shop.Properties.Resources.table;
            this.pnlTablePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTablePic.Location = new System.Drawing.Point(1047, 267);
            this.pnlTablePic.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTablePic.Name = "pnlTablePic";
            this.pnlTablePic.Size = new System.Drawing.Size(48, 46);
            this.pnlTablePic.TabIndex = 27;
            // 
            // btnShowAllUsers
            // 
            this.btnShowAllUsers.BackColor = System.Drawing.Color.YellowGreen;
            this.btnShowAllUsers.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowAllUsers.Location = new System.Drawing.Point(1039, 261);
            this.btnShowAllUsers.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowAllUsers.Name = "btnShowAllUsers";
            this.btnShowAllUsers.Size = new System.Drawing.Size(245, 55);
            this.btnShowAllUsers.TabIndex = 24;
            this.btnShowAllUsers.Text = "Show All";
            this.btnShowAllUsers.UseVisualStyleBackColor = false;
            this.btnShowAllUsers.Click += new System.EventHandler(this.btnShowAllUsers_Click);
            // 
            // dgvUserList
            // 
            this.dgvUserList.AllowUserToAddRows = false;
            this.dgvUserList.AllowUserToDeleteRows = false;
            this.dgvUserList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.UserEmail,
            this.UserPassword,
            this.UserPhone,
            this.UserName,
            this.UserCreatedDate,
            this.UserRole,
            this.UserGender});
            this.dgvUserList.Location = new System.Drawing.Point(11, 328);
            this.dgvUserList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUserList.Name = "dgvUserList";
            this.dgvUserList.ReadOnly = true;
            this.dgvUserList.RowHeadersWidth = 51;
            this.dgvUserList.Size = new System.Drawing.Size(1272, 394);
            this.dgvUserList.TabIndex = 22;
            // 
            // UserID
            // 
            this.UserID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserID.DataPropertyName = "UserID";
            this.UserID.HeaderText = "User ID";
            this.UserID.MinimumWidth = 6;
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            // 
            // UserEmail
            // 
            this.UserEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserEmail.DataPropertyName = "Email";
            this.UserEmail.HeaderText = "Email";
            this.UserEmail.MinimumWidth = 6;
            this.UserEmail.Name = "UserEmail";
            this.UserEmail.ReadOnly = true;
            // 
            // UserPassword
            // 
            this.UserPassword.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserPassword.DataPropertyName = "Password";
            this.UserPassword.HeaderText = "Password";
            this.UserPassword.MinimumWidth = 6;
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.ReadOnly = true;
            // 
            // UserPhone
            // 
            this.UserPhone.DataPropertyName = "Phone";
            this.UserPhone.HeaderText = "Contact";
            this.UserPhone.MinimumWidth = 6;
            this.UserPhone.Name = "UserPhone";
            this.UserPhone.ReadOnly = true;
            this.UserPhone.Width = 125;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "FullName";
            this.UserName.HeaderText = "Full Name";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 125;
            // 
            // UserCreatedDate
            // 
            this.UserCreatedDate.DataPropertyName = "CreatedDate";
            this.UserCreatedDate.HeaderText = "Created Date";
            this.UserCreatedDate.MinimumWidth = 6;
            this.UserCreatedDate.Name = "UserCreatedDate";
            this.UserCreatedDate.ReadOnly = true;
            this.UserCreatedDate.Width = 125;
            // 
            // UserRole
            // 
            this.UserRole.DataPropertyName = "Role";
            this.UserRole.HeaderText = "Role";
            this.UserRole.MinimumWidth = 6;
            this.UserRole.Name = "UserRole";
            this.UserRole.ReadOnly = true;
            this.UserRole.Width = 150;
            // 
            // UserGender
            // 
            this.UserGender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserGender.DataPropertyName = "Gender";
            this.UserGender.HeaderText = "Gender";
            this.UserGender.MinimumWidth = 6;
            this.UserGender.Name = "UserGender";
            this.UserGender.ReadOnly = true;
            // 
            // btnActionUser
            // 
            this.btnActionUser.BackColor = System.Drawing.Color.Black;
            this.btnActionUser.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActionUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActionUser.Location = new System.Drawing.Point(1100, 126);
            this.btnActionUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnActionUser.Name = "btnActionUser";
            this.btnActionUser.Size = new System.Drawing.Size(271, 64);
            this.btnActionUser.TabIndex = 21;
            this.btnActionUser.Text = "Action User";
            this.btnActionUser.UseVisualStyleBackColor = false;
            this.btnActionUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(11, 274);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(364, 46);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.Text = "Search here....";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblUserListDescription
            // 
            this.lblUserListDescription.AutoSize = true;
            this.lblUserListDescription.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserListDescription.ForeColor = System.Drawing.Color.DimGray;
            this.lblUserListDescription.Location = new System.Drawing.Point(7, 84);
            this.lblUserListDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserListDescription.Name = "lblUserListDescription";
            this.lblUserListDescription.Size = new System.Drawing.Size(985, 46);
            this.lblUserListDescription.TabIndex = 18;
            this.lblUserListDescription.Text = "A dashboard provides you an overview of user list with access to the most importa" +
    "nt data,\r\nfunctions and controls.\r\n";
            // 
            // lblUserList
            // 
            this.lblUserList.AutoSize = true;
            this.lblUserList.Font = new System.Drawing.Font("Lucida Fax", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserList.Location = new System.Drawing.Point(4, 30);
            this.lblUserList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserList.Name = "lblUserList";
            this.lblUserList.Size = new System.Drawing.Size(146, 32);
            this.lblUserList.TabIndex = 17;
            this.lblUserList.Text = "User List";
            // 
            // lblSearchUser
            // 
            this.lblSearchUser.AutoSize = true;
            this.lblSearchUser.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchUser.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblSearchUser.Location = new System.Drawing.Point(16, 249);
            this.lblSearchUser.Name = "lblSearchUser";
            this.lblSearchUser.Size = new System.Drawing.Size(239, 21);
            this.lblSearchUser.TabIndex = 51;
            this.lblSearchUser.Text = "( Search by User Name )";
            // 
            // uUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlUserContent);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "uUser";
            this.Size = new System.Drawing.Size(1439, 871);
            this.pnlUserContent.ResumeLayout(false);
            this.pnlUserContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUserContent;
        private System.Windows.Forms.DataGridView dgvUserList;
        private System.Windows.Forms.Button btnActionUser;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblUserListDescription;
        private System.Windows.Forms.Label lblUserList;
        private System.Windows.Forms.Button btnShowAllUsers;
        private System.Windows.Forms.Panel pnlTablePic;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserCreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserGender;
        private System.Windows.Forms.Label lblSearchUser;
    }
}
