namespace G_Shop
{
    partial class uActionUsers
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
            this.pnlAddUsersContent = new System.Windows.Forms.Panel();
            this.pnlBack = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlAddUsersInfo = new System.Windows.Forms.Panel();
            this.lblSearchUser = new System.Windows.Forms.Label();
            this.pnlGender = new System.Windows.Forms.Panel();
            this.rdbUserMale = new System.Windows.Forms.RadioButton();
            this.rdbUserFemale = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvUserList = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.cmbUserRoles = new System.Windows.Forms.ComboBox();
            this.lblUserGender = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.lblUserCreateDate = new System.Windows.Forms.Label();
            this.txtUserEmail = new System.Windows.Forms.TextBox();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.lblAutoGen = new System.Windows.Forms.Label();
            this.btnDeleteUserInfo = new System.Windows.Forms.Button();
            this.btnUpdateUserInfo = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtUserContact = new System.Windows.Forms.TextBox();
            this.lblUserContact = new System.Windows.Forms.Label();
            this.txtUserPass = new System.Windows.Forms.TextBox();
            this.lblUserPass = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblNewUserName = new System.Windows.Forms.Label();
            this.lblBasicAddUserInfo = new System.Windows.Forms.Label();
            this.lblActionUsers = new System.Windows.Forms.Label();
            this.pnlAddUsersContent.SuspendLayout();
            this.pnlAddUsersInfo.SuspendLayout();
            this.pnlGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAddUsersContent
            // 
            this.pnlAddUsersContent.AutoScroll = true;
            this.pnlAddUsersContent.AutoScrollMinSize = new System.Drawing.Size(0, 1300);
            this.pnlAddUsersContent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAddUsersContent.Controls.Add(this.pnlBack);
            this.pnlAddUsersContent.Controls.Add(this.btnBack);
            this.pnlAddUsersContent.Controls.Add(this.pnlAddUsersInfo);
            this.pnlAddUsersContent.Controls.Add(this.lblActionUsers);
            this.pnlAddUsersContent.Location = new System.Drawing.Point(23, 34);
            this.pnlAddUsersContent.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAddUsersContent.Name = "pnlAddUsersContent";
            this.pnlAddUsersContent.Size = new System.Drawing.Size(1392, 832);
            this.pnlAddUsersContent.TabIndex = 12;
            // 
            // pnlBack
            // 
            this.pnlBack.BackColor = System.Drawing.Color.Black;
            this.pnlBack.BackgroundImage = global::G_Shop.Properties.Resources.left_arrow;
            this.pnlBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBack.Location = new System.Drawing.Point(1147, 15);
            this.pnlBack.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(48, 39);
            this.pnlBack.TabIndex = 21;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(1139, 4);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(213, 55);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlAddUsersInfo
            // 
            this.pnlAddUsersInfo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlAddUsersInfo.Controls.Add(this.lblSearchUser);
            this.pnlAddUsersInfo.Controls.Add(this.pnlGender);
            this.pnlAddUsersInfo.Controls.Add(this.txtSearch);
            this.pnlAddUsersInfo.Controls.Add(this.dgvUserList);
            this.pnlAddUsersInfo.Controls.Add(this.lblUserRole);
            this.pnlAddUsersInfo.Controls.Add(this.cmbUserRoles);
            this.pnlAddUsersInfo.Controls.Add(this.lblUserGender);
            this.pnlAddUsersInfo.Controls.Add(this.dtp);
            this.pnlAddUsersInfo.Controls.Add(this.lblUserCreateDate);
            this.pnlAddUsersInfo.Controls.Add(this.txtUserEmail);
            this.pnlAddUsersInfo.Controls.Add(this.lblUserEmail);
            this.pnlAddUsersInfo.Controls.Add(this.lblAutoGen);
            this.pnlAddUsersInfo.Controls.Add(this.btnDeleteUserInfo);
            this.pnlAddUsersInfo.Controls.Add(this.btnUpdateUserInfo);
            this.pnlAddUsersInfo.Controls.Add(this.btnReset);
            this.pnlAddUsersInfo.Controls.Add(this.btnAddUser);
            this.pnlAddUsersInfo.Controls.Add(this.txtUserContact);
            this.pnlAddUsersInfo.Controls.Add(this.lblUserContact);
            this.pnlAddUsersInfo.Controls.Add(this.txtUserPass);
            this.pnlAddUsersInfo.Controls.Add(this.lblUserPass);
            this.pnlAddUsersInfo.Controls.Add(this.txtUserID);
            this.pnlAddUsersInfo.Controls.Add(this.lblUserID);
            this.pnlAddUsersInfo.Controls.Add(this.txtUserName);
            this.pnlAddUsersInfo.Controls.Add(this.lblNewUserName);
            this.pnlAddUsersInfo.Controls.Add(this.lblBasicAddUserInfo);
            this.pnlAddUsersInfo.Location = new System.Drawing.Point(12, 66);
            this.pnlAddUsersInfo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAddUsersInfo.Name = "pnlAddUsersInfo";
            this.pnlAddUsersInfo.Size = new System.Drawing.Size(1344, 1268);
            this.pnlAddUsersInfo.TabIndex = 19;
            // 
            // lblSearchUser
            // 
            this.lblSearchUser.AutoSize = true;
            this.lblSearchUser.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchUser.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSearchUser.Location = new System.Drawing.Point(28, 516);
            this.lblSearchUser.Name = "lblSearchUser";
            this.lblSearchUser.Size = new System.Drawing.Size(213, 21);
            this.lblSearchUser.TabIndex = 50;
            this.lblSearchUser.Text = "Search by User Name";
            // 
            // pnlGender
            // 
            this.pnlGender.Controls.Add(this.rdbUserMale);
            this.pnlGender.Controls.Add(this.rdbUserFemale);
            this.pnlGender.Location = new System.Drawing.Point(22, 412);
            this.pnlGender.Name = "pnlGender";
            this.pnlGender.Size = new System.Drawing.Size(367, 73);
            this.pnlGender.TabIndex = 49;
            // 
            // rdbUserMale
            // 
            this.rdbUserMale.AutoSize = true;
            this.rdbUserMale.Font = new System.Drawing.Font("Lucida Fax", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbUserMale.Location = new System.Drawing.Point(10, 21);
            this.rdbUserMale.Margin = new System.Windows.Forms.Padding(4);
            this.rdbUserMale.Name = "rdbUserMale";
            this.rdbUserMale.Size = new System.Drawing.Size(87, 29);
            this.rdbUserMale.TabIndex = 43;
            this.rdbUserMale.TabStop = true;
            this.rdbUserMale.Text = "Male";
            this.rdbUserMale.UseVisualStyleBackColor = true;
            // 
            // rdbUserFemale
            // 
            this.rdbUserFemale.AutoSize = true;
            this.rdbUserFemale.Font = new System.Drawing.Font("Lucida Fax", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbUserFemale.Location = new System.Drawing.Point(213, 21);
            this.rdbUserFemale.Margin = new System.Windows.Forms.Padding(4);
            this.rdbUserFemale.Name = "rdbUserFemale";
            this.rdbUserFemale.Size = new System.Drawing.Size(115, 29);
            this.rdbUserFemale.TabIndex = 44;
            this.rdbUserFemale.TabStop = true;
            this.rdbUserFemale.Text = "Female";
            this.rdbUserFemale.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(24, 541);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(357, 46);
            this.txtSearch.TabIndex = 48;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvUserList
            // 
            this.dgvUserList.AllowUserToAddRows = false;
            this.dgvUserList.AllowUserToDeleteRows = false;
            this.dgvUserList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.Email,
            this.Password,
            this.Phone,
            this.FullName,
            this.CreatedDate,
            this.Role,
            this.Gender});
            this.dgvUserList.Location = new System.Drawing.Point(24, 607);
            this.dgvUserList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUserList.Name = "dgvUserList";
            this.dgvUserList.ReadOnly = true;
            this.dgvUserList.RowHeadersWidth = 51;
            this.dgvUserList.Size = new System.Drawing.Size(1272, 394);
            this.dgvUserList.TabIndex = 47;
            this.dgvUserList.DoubleClick += new System.EventHandler(this.dgvUserList_DoubleClick);
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
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 125;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Full Name";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 125;
            // 
            // CreatedDate
            // 
            this.CreatedDate.DataPropertyName = "CreatedDate";
            this.CreatedDate.HeaderText = "Created Date";
            this.CreatedDate.MinimumWidth = 6;
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.ReadOnly = true;
            this.CreatedDate.Width = 125;
            // 
            // Role
            // 
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "Role";
            this.Role.MinimumWidth = 6;
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            this.Role.Width = 150;
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.BackColor = System.Drawing.Color.Transparent;
            this.lblUserRole.Font = new System.Drawing.Font("Lucida Fax", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUserRole.Location = new System.Drawing.Point(659, 385);
            this.lblUserRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(79, 32);
            this.lblUserRole.TabIndex = 46;
            this.lblUserRole.Text = "Role";
            // 
            // cmbUserRoles
            // 
            this.cmbUserRoles.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUserRoles.FormattingEnabled = true;
            this.cmbUserRoles.Items.AddRange(new object[] {
            "Salesman"});
            this.cmbUserRoles.Location = new System.Drawing.Point(653, 428);
            this.cmbUserRoles.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUserRoles.Name = "cmbUserRoles";
            this.cmbUserRoles.Size = new System.Drawing.Size(389, 34);
            this.cmbUserRoles.TabIndex = 45;
            // 
            // lblUserGender
            // 
            this.lblUserGender.AutoSize = true;
            this.lblUserGender.BackColor = System.Drawing.Color.Transparent;
            this.lblUserGender.Font = new System.Drawing.Font("Lucida Fax", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUserGender.Location = new System.Drawing.Point(16, 377);
            this.lblUserGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserGender.Name = "lblUserGender";
            this.lblUserGender.Size = new System.Drawing.Size(121, 32);
            this.lblUserGender.TabIndex = 42;
            this.lblUserGender.Text = "Gender";
            // 
            // dtp
            // 
            this.dtp.CalendarFont = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(653, 309);
            this.dtp.Margin = new System.Windows.Forms.Padding(4);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(408, 31);
            this.dtp.TabIndex = 41;
            // 
            // lblUserCreateDate
            // 
            this.lblUserCreateDate.AutoSize = true;
            this.lblUserCreateDate.BackColor = System.Drawing.Color.Transparent;
            this.lblUserCreateDate.Font = new System.Drawing.Font("Lucida Fax", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserCreateDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUserCreateDate.Location = new System.Drawing.Point(645, 266);
            this.lblUserCreateDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserCreateDate.Name = "lblUserCreateDate";
            this.lblUserCreateDate.Size = new System.Drawing.Size(208, 32);
            this.lblUserCreateDate.TabIndex = 40;
            this.lblUserCreateDate.Text = "Created Date";
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserEmail.Location = new System.Drawing.Point(653, 101);
            this.txtUserEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserEmail.Multiline = true;
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Size = new System.Drawing.Size(497, 43);
            this.txtUserEmail.TabIndex = 39;
            this.txtUserEmail.TextChanged += new System.EventHandler(this.txtUserEmail_TextChanged);
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblUserEmail.Font = new System.Drawing.Font("Lucida Fax", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUserEmail.Location = new System.Drawing.Point(645, 58);
            this.lblUserEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(173, 32);
            this.lblUserEmail.TabIndex = 38;
            this.lblUserEmail.Text = "User Email";
            // 
            // lblAutoGen
            // 
            this.lblAutoGen.AutoSize = true;
            this.lblAutoGen.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoGen.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAutoGen.Location = new System.Drawing.Point(176, 174);
            this.lblAutoGen.Name = "lblAutoGen";
            this.lblAutoGen.Size = new System.Drawing.Size(237, 21);
            this.lblAutoGen.TabIndex = 37;
            this.lblAutoGen.Text = "( ID is Auto Generated )";
            // 
            // btnDeleteUserInfo
            // 
            this.btnDeleteUserInfo.BackColor = System.Drawing.Color.Black;
            this.btnDeleteUserInfo.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUserInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteUserInfo.Location = new System.Drawing.Point(431, 517);
            this.btnDeleteUserInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteUserInfo.Name = "btnDeleteUserInfo";
            this.btnDeleteUserInfo.Size = new System.Drawing.Size(214, 70);
            this.btnDeleteUserInfo.TabIndex = 35;
            this.btnDeleteUserInfo.Text = "Delete User";
            this.btnDeleteUserInfo.UseVisualStyleBackColor = false;
            this.btnDeleteUserInfo.Click += new System.EventHandler(this.btnDeleteUserInfo_Click);
            // 
            // btnUpdateUserInfo
            // 
            this.btnUpdateUserInfo.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdateUserInfo.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUserInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateUserInfo.Location = new System.Drawing.Point(665, 517);
            this.btnUpdateUserInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateUserInfo.Name = "btnUpdateUserInfo";
            this.btnUpdateUserInfo.Size = new System.Drawing.Size(235, 70);
            this.btnUpdateUserInfo.TabIndex = 34;
            this.btnUpdateUserInfo.Text = "Update User";
            this.btnUpdateUserInfo.UseVisualStyleBackColor = false;
            this.btnUpdateUserInfo.Click += new System.EventHandler(this.btnUpdateUserInfo_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(1117, 517);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(179, 70);
            this.btnReset.TabIndex = 33;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAddUser.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddUser.Location = new System.Drawing.Point(908, 517);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(197, 70);
            this.btnAddUser.TabIndex = 32;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtUserContact
            // 
            this.txtUserContact.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserContact.Location = new System.Drawing.Point(12, 310);
            this.txtUserContact.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserContact.Multiline = true;
            this.txtUserContact.Name = "txtUserContact";
            this.txtUserContact.Size = new System.Drawing.Size(549, 43);
            this.txtUserContact.TabIndex = 29;
            this.txtUserContact.TextChanged += new System.EventHandler(this.txtUserContact_TextChanged);
            // 
            // lblUserContact
            // 
            this.lblUserContact.AutoSize = true;
            this.lblUserContact.BackColor = System.Drawing.Color.Transparent;
            this.lblUserContact.Font = new System.Drawing.Font("Lucida Fax", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUserContact.Location = new System.Drawing.Point(4, 266);
            this.lblUserContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserContact.Name = "lblUserContact";
            this.lblUserContact.Size = new System.Drawing.Size(205, 32);
            this.lblUserContact.TabIndex = 28;
            this.lblUserContact.Text = "User Contact";
            // 
            // txtUserPass
            // 
            this.txtUserPass.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPass.Location = new System.Drawing.Point(653, 206);
            this.txtUserPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserPass.Multiline = true;
            this.txtUserPass.Name = "txtUserPass";
            this.txtUserPass.Size = new System.Drawing.Size(439, 43);
            this.txtUserPass.TabIndex = 27;
            // 
            // lblUserPass
            // 
            this.lblUserPass.AutoSize = true;
            this.lblUserPass.BackColor = System.Drawing.Color.Transparent;
            this.lblUserPass.Font = new System.Drawing.Font("Lucida Fax", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUserPass.Location = new System.Drawing.Point(645, 162);
            this.lblUserPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserPass.Name = "lblUserPass";
            this.lblUserPass.Size = new System.Drawing.Size(233, 32);
            this.lblUserPass.TabIndex = 26;
            this.lblUserPass.Text = "User Password";
            // 
            // txtUserID
            // 
            this.txtUserID.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtUserID.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.ForeColor = System.Drawing.Color.Black;
            this.txtUserID.Location = new System.Drawing.Point(12, 206);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserID.Multiline = true;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(549, 43);
            this.txtUserID.TabIndex = 25;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.BackColor = System.Drawing.Color.Transparent;
            this.lblUserID.Font = new System.Drawing.Font("Lucida Fax", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUserID.Location = new System.Drawing.Point(4, 162);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(124, 32);
            this.lblUserID.TabIndex = 24;
            this.lblUserID.Text = "User ID";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(12, 101);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(549, 43);
            this.txtUserName.TabIndex = 21;
            // 
            // lblNewUserName
            // 
            this.lblNewUserName.AutoSize = true;
            this.lblNewUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblNewUserName.Font = new System.Drawing.Font("Lucida Fax", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNewUserName.Location = new System.Drawing.Point(4, 58);
            this.lblNewUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewUserName.Name = "lblNewUserName";
            this.lblNewUserName.Size = new System.Drawing.Size(175, 32);
            this.lblNewUserName.TabIndex = 20;
            this.lblNewUserName.Text = "User Name";
            // 
            // lblBasicAddUserInfo
            // 
            this.lblBasicAddUserInfo.AutoSize = true;
            this.lblBasicAddUserInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblBasicAddUserInfo.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasicAddUserInfo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblBasicAddUserInfo.Location = new System.Drawing.Point(4, 0);
            this.lblBasicAddUserInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBasicAddUserInfo.Name = "lblBasicAddUserInfo";
            this.lblBasicAddUserInfo.Size = new System.Drawing.Size(320, 36);
            this.lblBasicAddUserInfo.TabIndex = 19;
            this.lblBasicAddUserInfo.Text = "Basic Information :";
            // 
            // lblActionUsers
            // 
            this.lblActionUsers.AutoSize = true;
            this.lblActionUsers.Font = new System.Drawing.Font("Lucida Fax", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActionUsers.Location = new System.Drawing.Point(5, 15);
            this.lblActionUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActionUsers.Name = "lblActionUsers";
            this.lblActionUsers.Size = new System.Drawing.Size(203, 32);
            this.lblActionUsers.TabIndex = 18;
            this.lblActionUsers.Text = "Action Users";
            // 
            // uActionUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlAddUsersContent);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "uActionUsers";
            this.Size = new System.Drawing.Size(1439, 871);
            this.pnlAddUsersContent.ResumeLayout(false);
            this.pnlAddUsersContent.PerformLayout();
            this.pnlAddUsersInfo.ResumeLayout(false);
            this.pnlAddUsersInfo.PerformLayout();
            this.pnlGender.ResumeLayout(false);
            this.pnlGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddUsersContent;
        private System.Windows.Forms.Panel pnlBack;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlAddUsersInfo;
        private System.Windows.Forms.Label lblAutoGen;
        private System.Windows.Forms.Button btnDeleteUserInfo;
        private System.Windows.Forms.Button btnUpdateUserInfo;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox txtUserContact;
        private System.Windows.Forms.Label lblUserContact;
        private System.Windows.Forms.TextBox txtUserPass;
        private System.Windows.Forms.Label lblUserPass;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblNewUserName;
        private System.Windows.Forms.Label lblBasicAddUserInfo;
        private System.Windows.Forms.Label lblActionUsers;
        private System.Windows.Forms.Label lblUserEmail;
        private System.Windows.Forms.TextBox txtUserEmail;
        private System.Windows.Forms.Label lblUserCreateDate;
        private System.Windows.Forms.RadioButton rdbUserMale;
        private System.Windows.Forms.Label lblUserGender;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.RadioButton rdbUserFemale;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.ComboBox cmbUserRoles;
        private System.Windows.Forms.DataGridView dgvUserList;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.Panel pnlGender;
        private System.Windows.Forms.Label lblSearchUser;
    }
}
