namespace G_Shop
{
    partial class uCategory
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
            this.pnlCategoryContent = new System.Windows.Forms.Panel();
            this.pnlCategoryC = new System.Windows.Forms.Panel();
            this.lblSearchCatg = new System.Windows.Forms.Label();
            this.lblActionCatg = new System.Windows.Forms.Label();
            this.btnDeleteCatgInfo = new System.Windows.Forms.Button();
            this.btnUpdateCatgInfo = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.txtCatgDesc = new System.Windows.Forms.TextBox();
            this.lblCategoryDescrip = new System.Windows.Forms.Label();
            this.pnlRefresh = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblAutoGen = new System.Windows.Forms.Label();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.lblNewCategoryName = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvCategoryList = new System.Windows.Forms.DataGridView();
            this.ProductCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTablePic = new System.Windows.Forms.Panel();
            this.btnShowAllCatg = new System.Windows.Forms.Button();
            this.lblCategoryListDescription = new System.Windows.Forms.Label();
            this.lblCategoryList = new System.Windows.Forms.Label();
            this.pnlCategoryContent.SuspendLayout();
            this.pnlCategoryC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCategoryContent
            // 
            this.pnlCategoryContent.AutoScroll = true;
            this.pnlCategoryContent.AutoScrollMinSize = new System.Drawing.Size(0, 1300);
            this.pnlCategoryContent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCategoryContent.Controls.Add(this.pnlCategoryC);
            this.pnlCategoryContent.Controls.Add(this.lblCategoryListDescription);
            this.pnlCategoryContent.Controls.Add(this.lblCategoryList);
            this.pnlCategoryContent.Location = new System.Drawing.Point(4, 4);
            this.pnlCategoryContent.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCategoryContent.Name = "pnlCategoryContent";
            this.pnlCategoryContent.Size = new System.Drawing.Size(1392, 802);
            this.pnlCategoryContent.TabIndex = 11;
            // 
            // pnlCategoryC
            // 
            this.pnlCategoryC.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlCategoryC.Controls.Add(this.lblSearchCatg);
            this.pnlCategoryC.Controls.Add(this.lblActionCatg);
            this.pnlCategoryC.Controls.Add(this.btnDeleteCatgInfo);
            this.pnlCategoryC.Controls.Add(this.btnUpdateCatgInfo);
            this.pnlCategoryC.Controls.Add(this.btnReset);
            this.pnlCategoryC.Controls.Add(this.btnAddCategory);
            this.pnlCategoryC.Controls.Add(this.txtCatgDesc);
            this.pnlCategoryC.Controls.Add(this.lblCategoryDescrip);
            this.pnlCategoryC.Controls.Add(this.pnlRefresh);
            this.pnlCategoryC.Controls.Add(this.btnRefresh);
            this.pnlCategoryC.Controls.Add(this.lblAutoGen);
            this.pnlCategoryC.Controls.Add(this.txtCategoryID);
            this.pnlCategoryC.Controls.Add(this.lblCategoryID);
            this.pnlCategoryC.Controls.Add(this.txtCategoryName);
            this.pnlCategoryC.Controls.Add(this.lblNewCategoryName);
            this.pnlCategoryC.Controls.Add(this.txtSearch);
            this.pnlCategoryC.Controls.Add(this.dgvCategoryList);
            this.pnlCategoryC.Controls.Add(this.pnlTablePic);
            this.pnlCategoryC.Controls.Add(this.btnShowAllCatg);
            this.pnlCategoryC.Location = new System.Drawing.Point(16, 147);
            this.pnlCategoryC.Name = "pnlCategoryC";
            this.pnlCategoryC.Size = new System.Drawing.Size(1309, 652);
            this.pnlCategoryC.TabIndex = 29;
            // 
            // lblSearchCatg
            // 
            this.lblSearchCatg.AutoSize = true;
            this.lblSearchCatg.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchCatg.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSearchCatg.Location = new System.Drawing.Point(6, 284);
            this.lblSearchCatg.Name = "lblSearchCatg";
            this.lblSearchCatg.Size = new System.Drawing.Size(255, 21);
            this.lblSearchCatg.TabIndex = 51;
            this.lblSearchCatg.Text = "Search by Category Name";
            // 
            // lblActionCatg
            // 
            this.lblActionCatg.AutoSize = true;
            this.lblActionCatg.BackColor = System.Drawing.Color.Transparent;
            this.lblActionCatg.Font = new System.Drawing.Font("Lucida Fax", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActionCatg.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblActionCatg.Location = new System.Drawing.Point(957, 312);
            this.lblActionCatg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActionCatg.Name = "lblActionCatg";
            this.lblActionCatg.Size = new System.Drawing.Size(252, 32);
            this.lblActionCatg.TabIndex = 47;
            this.lblActionCatg.Text = "Action Category";
            // 
            // btnDeleteCatgInfo
            // 
            this.btnDeleteCatgInfo.BackColor = System.Drawing.Color.Black;
            this.btnDeleteCatgInfo.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCatgInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteCatgInfo.Location = new System.Drawing.Point(850, 411);
            this.btnDeleteCatgInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteCatgInfo.Name = "btnDeleteCatgInfo";
            this.btnDeleteCatgInfo.Size = new System.Drawing.Size(232, 70);
            this.btnDeleteCatgInfo.TabIndex = 46;
            this.btnDeleteCatgInfo.Text = "Delete Category";
            this.btnDeleteCatgInfo.UseVisualStyleBackColor = false;
            this.btnDeleteCatgInfo.Click += new System.EventHandler(this.btnDeleteCatgInfo_Click);
            // 
            // btnUpdateCatgInfo
            // 
            this.btnUpdateCatgInfo.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdateCatgInfo.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCatgInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateCatgInfo.Location = new System.Drawing.Point(850, 489);
            this.btnUpdateCatgInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateCatgInfo.Name = "btnUpdateCatgInfo";
            this.btnUpdateCatgInfo.Size = new System.Drawing.Size(235, 70);
            this.btnUpdateCatgInfo.TabIndex = 45;
            this.btnUpdateCatgInfo.Text = "Update Category";
            this.btnUpdateCatgInfo.UseVisualStyleBackColor = false;
            this.btnUpdateCatgInfo.Click += new System.EventHandler(this.btnUpdateCatgInfo_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(1093, 489);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(194, 70);
            this.btnReset.TabIndex = 44;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAddCategory.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddCategory.Location = new System.Drawing.Point(1090, 411);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(197, 70);
            this.btnAddCategory.TabIndex = 43;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // txtCatgDesc
            // 
            this.txtCatgDesc.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatgDesc.Location = new System.Drawing.Point(539, 76);
            this.txtCatgDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtCatgDesc.Multiline = true;
            this.txtCatgDesc.Name = "txtCatgDesc";
            this.txtCatgDesc.Size = new System.Drawing.Size(738, 117);
            this.txtCatgDesc.TabIndex = 42;
            // 
            // lblCategoryDescrip
            // 
            this.lblCategoryDescrip.AutoSize = true;
            this.lblCategoryDescrip.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoryDescrip.Font = new System.Drawing.Font("Lucida Fax", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryDescrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCategoryDescrip.Location = new System.Drawing.Point(533, 40);
            this.lblCategoryDescrip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryDescrip.Name = "lblCategoryDescrip";
            this.lblCategoryDescrip.Size = new System.Drawing.Size(330, 32);
            this.lblCategoryDescrip.TabIndex = 41;
            this.lblCategoryDescrip.Text = "Category Description";
            // 
            // pnlRefresh
            // 
            this.pnlRefresh.BackColor = System.Drawing.Color.Crimson;
            this.pnlRefresh.BackgroundImage = global::G_Shop.Properties.Resources.refresh_page_option;
            this.pnlRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRefresh.Location = new System.Drawing.Point(326, 318);
            this.pnlRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRefresh.Name = "pnlRefresh";
            this.pnlRefresh.Size = new System.Drawing.Size(47, 42);
            this.pnlRefresh.TabIndex = 40;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Crimson;
            this.btnRefresh.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefresh.Location = new System.Drawing.Point(320, 314);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(208, 50);
            this.btnRefresh.TabIndex = 39;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblAutoGen
            // 
            this.lblAutoGen.AutoSize = true;
            this.lblAutoGen.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoGen.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAutoGen.Location = new System.Drawing.Point(200, 164);
            this.lblAutoGen.Name = "lblAutoGen";
            this.lblAutoGen.Size = new System.Drawing.Size(237, 21);
            this.lblAutoGen.TabIndex = 38;
            this.lblAutoGen.Text = "( ID is Auto Generated )";
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtCategoryID.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryID.ForeColor = System.Drawing.Color.Black;
            this.txtCategoryID.Location = new System.Drawing.Point(4, 197);
            this.txtCategoryID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoryID.Multiline = true;
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.ReadOnly = true;
            this.txtCategoryID.Size = new System.Drawing.Size(424, 43);
            this.txtCategoryID.TabIndex = 32;
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoryID.Font = new System.Drawing.Font("Lucida Fax", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCategoryID.Location = new System.Drawing.Point(4, 161);
            this.lblCategoryID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(189, 32);
            this.lblCategoryID.TabIndex = 31;
            this.lblCategoryID.Text = "Category ID";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryName.Location = new System.Drawing.Point(4, 76);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoryName.Multiline = true;
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(387, 43);
            this.txtCategoryName.TabIndex = 30;
            this.txtCategoryName.TextChanged += new System.EventHandler(this.txtCategoryName_TextChanged);
            // 
            // lblNewCategoryName
            // 
            this.lblNewCategoryName.AutoSize = true;
            this.lblNewCategoryName.BackColor = System.Drawing.Color.Transparent;
            this.lblNewCategoryName.Font = new System.Drawing.Font("Lucida Fax", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewCategoryName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNewCategoryName.Location = new System.Drawing.Point(4, 40);
            this.lblNewCategoryName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewCategoryName.Name = "lblNewCategoryName";
            this.lblNewCategoryName.Size = new System.Drawing.Size(240, 32);
            this.lblNewCategoryName.TabIndex = 29;
            this.lblNewCategoryName.Text = "Category Name";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(4, 318);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(308, 46);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.Text = "Search here....";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvCategoryList
            // 
            this.dgvCategoryList.AllowUserToAddRows = false;
            this.dgvCategoryList.AllowUserToDeleteRows = false;
            this.dgvCategoryList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCategoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoryList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductCategory,
            this.CategoryName,
            this.CategoryDescription});
            this.dgvCategoryList.Location = new System.Drawing.Point(4, 371);
            this.dgvCategoryList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCategoryList.Name = "dgvCategoryList";
            this.dgvCategoryList.ReadOnly = true;
            this.dgvCategoryList.RowHeadersWidth = 51;
            this.dgvCategoryList.Size = new System.Drawing.Size(838, 263);
            this.dgvCategoryList.TabIndex = 22;
            this.dgvCategoryList.DoubleClick += new System.EventHandler(this.dgvCategoryList_DoubleClick);
            // 
            // ProductCategory
            // 
            this.ProductCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductCategory.DataPropertyName = "CategoryID";
            this.ProductCategory.HeaderText = "Category ID";
            this.ProductCategory.MinimumWidth = 6;
            this.ProductCategory.Name = "ProductCategory";
            this.ProductCategory.ReadOnly = true;
            // 
            // CategoryName
            // 
            this.CategoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.HeaderText = "Category Name";
            this.CategoryName.MinimumWidth = 6;
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            // 
            // CategoryDescription
            // 
            this.CategoryDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CategoryDescription.DataPropertyName = "Description";
            this.CategoryDescription.HeaderText = "Category Description";
            this.CategoryDescription.MinimumWidth = 6;
            this.CategoryDescription.Name = "CategoryDescription";
            this.CategoryDescription.ReadOnly = true;
            // 
            // pnlTablePic
            // 
            this.pnlTablePic.BackColor = System.Drawing.Color.YellowGreen;
            this.pnlTablePic.BackgroundImage = global::G_Shop.Properties.Resources.table;
            this.pnlTablePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTablePic.Location = new System.Drawing.Point(621, 312);
            this.pnlTablePic.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTablePic.Name = "pnlTablePic";
            this.pnlTablePic.Size = new System.Drawing.Size(48, 46);
            this.pnlTablePic.TabIndex = 28;
            // 
            // btnShowAllCatg
            // 
            this.btnShowAllCatg.BackColor = System.Drawing.Color.YellowGreen;
            this.btnShowAllCatg.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllCatg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowAllCatg.Location = new System.Drawing.Point(616, 308);
            this.btnShowAllCatg.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowAllCatg.Name = "btnShowAllCatg";
            this.btnShowAllCatg.Size = new System.Drawing.Size(226, 55);
            this.btnShowAllCatg.TabIndex = 24;
            this.btnShowAllCatg.Text = "Show All";
            this.btnShowAllCatg.UseVisualStyleBackColor = false;
            this.btnShowAllCatg.Click += new System.EventHandler(this.btnShowAllCatg_Click);
            // 
            // lblCategoryListDescription
            // 
            this.lblCategoryListDescription.AutoSize = true;
            this.lblCategoryListDescription.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryListDescription.ForeColor = System.Drawing.Color.DimGray;
            this.lblCategoryListDescription.Location = new System.Drawing.Point(7, 84);
            this.lblCategoryListDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryListDescription.Name = "lblCategoryListDescription";
            this.lblCategoryListDescription.Size = new System.Drawing.Size(884, 23);
            this.lblCategoryListDescription.TabIndex = 18;
            this.lblCategoryListDescription.Text = "Use category list as to describe your overall core business from the provided lis" +
    "t.\r\n";
            // 
            // lblCategoryList
            // 
            this.lblCategoryList.AutoSize = true;
            this.lblCategoryList.Font = new System.Drawing.Font("Lucida Fax", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryList.Location = new System.Drawing.Point(4, 30);
            this.lblCategoryList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryList.Name = "lblCategoryList";
            this.lblCategoryList.Size = new System.Drawing.Size(211, 32);
            this.lblCategoryList.TabIndex = 17;
            this.lblCategoryList.Text = "Category List";
            // 
            // uCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlCategoryContent);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "uCategory";
            this.Size = new System.Drawing.Size(1439, 871);
            this.pnlCategoryContent.ResumeLayout(false);
            this.pnlCategoryContent.PerformLayout();
            this.pnlCategoryC.ResumeLayout(false);
            this.pnlCategoryC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCategoryContent;
        private System.Windows.Forms.DataGridView dgvCategoryList;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblCategoryListDescription;
        private System.Windows.Forms.Label lblCategoryList;
        private System.Windows.Forms.Button btnShowAllCatg;
        private System.Windows.Forms.Panel pnlTablePic;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryDescription;
        private System.Windows.Forms.Panel pnlCategoryC;
        private System.Windows.Forms.Label lblNewCategoryName;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.Label lblAutoGen;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlRefresh;
        private System.Windows.Forms.TextBox txtCatgDesc;
        private System.Windows.Forms.Label lblCategoryDescrip;
        private System.Windows.Forms.Button btnDeleteCatgInfo;
        private System.Windows.Forms.Button btnUpdateCatgInfo;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Label lblActionCatg;
        private System.Windows.Forms.Label lblSearchCatg;
    }
}
