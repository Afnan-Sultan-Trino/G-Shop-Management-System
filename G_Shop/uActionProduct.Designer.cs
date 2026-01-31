namespace G_Shop
{
    partial class uActionProduct
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
            this.pnlAddProductContent = new System.Windows.Forms.Panel();
            this.pnlBack = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlAddPrdInfo = new System.Windows.Forms.Panel();
            this.lblAutoGen = new System.Windows.Forms.Label();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.ProductList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeletePrdInfo = new System.Windows.Forms.Button();
            this.btnUpdatePrdInfo = new System.Windows.Forms.Button();
            this.btnResetAddPrd = new System.Windows.Forms.Button();
            this.btnAddPrdSave = new System.Windows.Forms.Button();
            this.txtPrdPrice = new System.Windows.Forms.TextBox();
            this.lblPrdPrice = new System.Windows.Forms.Label();
            this.txtPrdQuantity = new System.Windows.Forms.TextBox();
            this.lblPrdQuantity = new System.Windows.Forms.Label();
            this.txtPrdID = new System.Windows.Forms.TextBox();
            this.lblPrdID = new System.Windows.Forms.Label();
            this.cmbPrdCategory = new System.Windows.Forms.ComboBox();
            this.lblPrdCategory = new System.Windows.Forms.Label();
            this.txtPrdName = new System.Windows.Forms.TextBox();
            this.lblNewPrdName = new System.Windows.Forms.Label();
            this.lblBasicAddPrdInfo = new System.Windows.Forms.Label();
            this.lblActionProduct = new System.Windows.Forms.Label();
            this.pnlAddProductContent.SuspendLayout();
            this.pnlAddPrdInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAddProductContent
            // 
            this.pnlAddProductContent.AutoScroll = true;
            this.pnlAddProductContent.AutoScrollMinSize = new System.Drawing.Size(0, 1300);
            this.pnlAddProductContent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAddProductContent.Controls.Add(this.pnlBack);
            this.pnlAddProductContent.Controls.Add(this.btnBack);
            this.pnlAddProductContent.Controls.Add(this.pnlAddPrdInfo);
            this.pnlAddProductContent.Controls.Add(this.lblActionProduct);
            this.pnlAddProductContent.Location = new System.Drawing.Point(23, 34);
            this.pnlAddProductContent.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAddProductContent.Name = "pnlAddProductContent";
            this.pnlAddProductContent.Size = new System.Drawing.Size(1392, 802);
            this.pnlAddProductContent.TabIndex = 11;
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
            // pnlAddPrdInfo
            // 
            this.pnlAddPrdInfo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlAddPrdInfo.Controls.Add(this.lblAutoGen);
            this.pnlAddPrdInfo.Controls.Add(this.dgvProductList);
            this.pnlAddPrdInfo.Controls.Add(this.btnDeletePrdInfo);
            this.pnlAddPrdInfo.Controls.Add(this.btnUpdatePrdInfo);
            this.pnlAddPrdInfo.Controls.Add(this.btnResetAddPrd);
            this.pnlAddPrdInfo.Controls.Add(this.btnAddPrdSave);
            this.pnlAddPrdInfo.Controls.Add(this.txtPrdPrice);
            this.pnlAddPrdInfo.Controls.Add(this.lblPrdPrice);
            this.pnlAddPrdInfo.Controls.Add(this.txtPrdQuantity);
            this.pnlAddPrdInfo.Controls.Add(this.lblPrdQuantity);
            this.pnlAddPrdInfo.Controls.Add(this.txtPrdID);
            this.pnlAddPrdInfo.Controls.Add(this.lblPrdID);
            this.pnlAddPrdInfo.Controls.Add(this.cmbPrdCategory);
            this.pnlAddPrdInfo.Controls.Add(this.lblPrdCategory);
            this.pnlAddPrdInfo.Controls.Add(this.txtPrdName);
            this.pnlAddPrdInfo.Controls.Add(this.lblNewPrdName);
            this.pnlAddPrdInfo.Controls.Add(this.lblBasicAddPrdInfo);
            this.pnlAddPrdInfo.Location = new System.Drawing.Point(12, 66);
            this.pnlAddPrdInfo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAddPrdInfo.Name = "pnlAddPrdInfo";
            this.pnlAddPrdInfo.Size = new System.Drawing.Size(1344, 1013);
            this.pnlAddPrdInfo.TabIndex = 19;
            // 
            // lblAutoGen
            // 
            this.lblAutoGen.AutoSize = true;
            this.lblAutoGen.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoGen.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAutoGen.Location = new System.Drawing.Point(209, 171);
            this.lblAutoGen.Name = "lblAutoGen";
            this.lblAutoGen.Size = new System.Drawing.Size(237, 21);
            this.lblAutoGen.TabIndex = 37;
            this.lblAutoGen.Text = "( ID is Auto Generated )";
            // 
            // dgvProductList
            // 
            this.dgvProductList.AllowUserToAddRows = false;
            this.dgvProductList.AllowUserToDeleteRows = false;
            this.dgvProductList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductList,
            this.ProductID,
            this.ProductCategory,
            this.ProductPrice,
            this.ProductStock});
            this.dgvProductList.Location = new System.Drawing.Point(12, 480);
            this.dgvProductList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.RowHeadersWidth = 51;
            this.dgvProductList.Size = new System.Drawing.Size(1272, 394);
            this.dgvProductList.TabIndex = 36;
            this.dgvProductList.DoubleClick += new System.EventHandler(this.dgvProductList_DoubleClick);
            // 
            // ProductList
            // 
            this.ProductList.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductList.DataPropertyName = "Product Name";
            this.ProductList.HeaderText = "Product Name";
            this.ProductList.MinimumWidth = 6;
            this.ProductList.Name = "ProductList";
            this.ProductList.ReadOnly = true;
            // 
            // ProductID
            // 
            this.ProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductID.DataPropertyName = "Product ID";
            this.ProductID.HeaderText = "ID";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // ProductCategory
            // 
            this.ProductCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductCategory.DataPropertyName = "Category";
            this.ProductCategory.HeaderText = "Category";
            this.ProductCategory.MinimumWidth = 6;
            this.ProductCategory.Name = "ProductCategory";
            this.ProductCategory.ReadOnly = true;
            // 
            // ProductPrice
            // 
            this.ProductPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductPrice.DataPropertyName = "Price";
            this.ProductPrice.HeaderText = "Price (BDT)";
            this.ProductPrice.MinimumWidth = 6;
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.ReadOnly = true;
            // 
            // ProductStock
            // 
            this.ProductStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductStock.DataPropertyName = "Quantity";
            this.ProductStock.HeaderText = "In Stock";
            this.ProductStock.MinimumWidth = 6;
            this.ProductStock.Name = "ProductStock";
            this.ProductStock.ReadOnly = true;
            // 
            // btnDeletePrdInfo
            // 
            this.btnDeletePrdInfo.BackColor = System.Drawing.Color.Black;
            this.btnDeletePrdInfo.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePrdInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeletePrdInfo.Location = new System.Drawing.Point(402, 402);
            this.btnDeletePrdInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeletePrdInfo.Name = "btnDeletePrdInfo";
            this.btnDeletePrdInfo.Size = new System.Drawing.Size(244, 70);
            this.btnDeletePrdInfo.TabIndex = 35;
            this.btnDeletePrdInfo.Text = "Delete Product";
            this.btnDeletePrdInfo.UseVisualStyleBackColor = false;
            this.btnDeletePrdInfo.Click += new System.EventHandler(this.btnDeletePrdInfo_Click);
            // 
            // btnUpdatePrdInfo
            // 
            this.btnUpdatePrdInfo.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdatePrdInfo.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePrdInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdatePrdInfo.Location = new System.Drawing.Point(654, 402);
            this.btnUpdatePrdInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdatePrdInfo.Name = "btnUpdatePrdInfo";
            this.btnUpdatePrdInfo.Size = new System.Drawing.Size(272, 70);
            this.btnUpdatePrdInfo.TabIndex = 34;
            this.btnUpdatePrdInfo.Text = "Update Product";
            this.btnUpdatePrdInfo.UseVisualStyleBackColor = false;
            this.btnUpdatePrdInfo.Click += new System.EventHandler(this.btnUpdatePrdInfo_Click);
            // 
            // btnResetAddPrd
            // 
            this.btnResetAddPrd.BackColor = System.Drawing.Color.Red;
            this.btnResetAddPrd.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetAddPrd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnResetAddPrd.Location = new System.Drawing.Point(1161, 402);
            this.btnResetAddPrd.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetAddPrd.Name = "btnResetAddPrd";
            this.btnResetAddPrd.Size = new System.Drawing.Size(179, 70);
            this.btnResetAddPrd.TabIndex = 33;
            this.btnResetAddPrd.Text = "Reset";
            this.btnResetAddPrd.UseVisualStyleBackColor = false;
            this.btnResetAddPrd.Click += new System.EventHandler(this.btnResetAddPrd_Click);
            // 
            // btnAddPrdSave
            // 
            this.btnAddPrdSave.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAddPrdSave.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPrdSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddPrdSave.Location = new System.Drawing.Point(934, 402);
            this.btnAddPrdSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPrdSave.Name = "btnAddPrdSave";
            this.btnAddPrdSave.Size = new System.Drawing.Size(219, 70);
            this.btnAddPrdSave.TabIndex = 32;
            this.btnAddPrdSave.Text = "Add Product";
            this.btnAddPrdSave.UseVisualStyleBackColor = false;
            this.btnAddPrdSave.Click += new System.EventHandler(this.btnAddPrdSave_Click);
            // 
            // txtPrdPrice
            // 
            this.txtPrdPrice.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrdPrice.Location = new System.Drawing.Point(12, 309);
            this.txtPrdPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrdPrice.Multiline = true;
            this.txtPrdPrice.Name = "txtPrdPrice";
            this.txtPrdPrice.Size = new System.Drawing.Size(549, 43);
            this.txtPrdPrice.TabIndex = 29;
            this.txtPrdPrice.TextChanged += new System.EventHandler(this.txtPrdPrice_TextChanged);
            // 
            // lblPrdPrice
            // 
            this.lblPrdPrice.AutoSize = true;
            this.lblPrdPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrdPrice.Font = new System.Drawing.Font("Lucida Fax", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrdPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPrdPrice.Location = new System.Drawing.Point(4, 266);
            this.lblPrdPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrdPrice.Name = "lblPrdPrice";
            this.lblPrdPrice.Size = new System.Drawing.Size(214, 32);
            this.lblPrdPrice.TabIndex = 28;
            this.lblPrdPrice.Text = "Product Price";
            // 
            // txtPrdQuantity
            // 
            this.txtPrdQuantity.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrdQuantity.Location = new System.Drawing.Point(660, 249);
            this.txtPrdQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrdQuantity.Multiline = true;
            this.txtPrdQuantity.Name = "txtPrdQuantity";
            this.txtPrdQuantity.Size = new System.Drawing.Size(369, 43);
            this.txtPrdQuantity.TabIndex = 27;
            this.txtPrdQuantity.TextChanged += new System.EventHandler(this.txtPrdQuantity_TextChanged);
            // 
            // lblPrdQuantity
            // 
            this.lblPrdQuantity.AutoSize = true;
            this.lblPrdQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblPrdQuantity.Font = new System.Drawing.Font("Lucida Fax", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrdQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPrdQuantity.Location = new System.Drawing.Point(652, 192);
            this.lblPrdQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrdQuantity.Name = "lblPrdQuantity";
            this.lblPrdQuantity.Size = new System.Drawing.Size(268, 32);
            this.lblPrdQuantity.TabIndex = 26;
            this.lblPrdQuantity.Text = "Product Quantity";
            // 
            // txtPrdID
            // 
            this.txtPrdID.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrdID.ForeColor = System.Drawing.Color.Gray;
            this.txtPrdID.Location = new System.Drawing.Point(12, 206);
            this.txtPrdID.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrdID.Multiline = true;
            this.txtPrdID.Name = "txtPrdID";
            this.txtPrdID.ReadOnly = true;
            this.txtPrdID.Size = new System.Drawing.Size(549, 43);
            this.txtPrdID.TabIndex = 25;
            // 
            // lblPrdID
            // 
            this.lblPrdID.AutoSize = true;
            this.lblPrdID.BackColor = System.Drawing.Color.Transparent;
            this.lblPrdID.Font = new System.Drawing.Font("Lucida Fax", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrdID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPrdID.Location = new System.Drawing.Point(4, 162);
            this.lblPrdID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrdID.Name = "lblPrdID";
            this.lblPrdID.Size = new System.Drawing.Size(172, 32);
            this.lblPrdID.TabIndex = 24;
            this.lblPrdID.Text = "Product ID";
            // 
            // cmbPrdCategory
            // 
            this.cmbPrdCategory.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrdCategory.FormattingEnabled = true;
            this.cmbPrdCategory.Items.AddRange(new object[] {
            "Smart Phone",
            "IPhone",
            "Laptop",
            "Mouse",
            "Ear Bud",
            "Key Board"});
            this.cmbPrdCategory.Location = new System.Drawing.Point(660, 127);
            this.cmbPrdCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPrdCategory.Name = "cmbPrdCategory";
            this.cmbPrdCategory.Size = new System.Drawing.Size(389, 34);
            this.cmbPrdCategory.TabIndex = 23;
            // 
            // lblPrdCategory
            // 
            this.lblPrdCategory.AutoSize = true;
            this.lblPrdCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblPrdCategory.Font = new System.Drawing.Font("Lucida Fax", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrdCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPrdCategory.Location = new System.Drawing.Point(652, 84);
            this.lblPrdCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrdCategory.Name = "lblPrdCategory";
            this.lblPrdCategory.Size = new System.Drawing.Size(147, 32);
            this.lblPrdCategory.TabIndex = 22;
            this.lblPrdCategory.Text = "Category";
            // 
            // txtPrdName
            // 
            this.txtPrdName.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrdName.Location = new System.Drawing.Point(12, 101);
            this.txtPrdName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrdName.Multiline = true;
            this.txtPrdName.Name = "txtPrdName";
            this.txtPrdName.Size = new System.Drawing.Size(549, 43);
            this.txtPrdName.TabIndex = 21;
            // 
            // lblNewPrdName
            // 
            this.lblNewPrdName.AutoSize = true;
            this.lblNewPrdName.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPrdName.Font = new System.Drawing.Font("Lucida Fax", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPrdName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNewPrdName.Location = new System.Drawing.Point(4, 58);
            this.lblNewPrdName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewPrdName.Name = "lblNewPrdName";
            this.lblNewPrdName.Size = new System.Drawing.Size(223, 32);
            this.lblNewPrdName.TabIndex = 20;
            this.lblNewPrdName.Text = "Product Name";
            // 
            // lblBasicAddPrdInfo
            // 
            this.lblBasicAddPrdInfo.AutoSize = true;
            this.lblBasicAddPrdInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblBasicAddPrdInfo.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasicAddPrdInfo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblBasicAddPrdInfo.Location = new System.Drawing.Point(4, 0);
            this.lblBasicAddPrdInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBasicAddPrdInfo.Name = "lblBasicAddPrdInfo";
            this.lblBasicAddPrdInfo.Size = new System.Drawing.Size(320, 36);
            this.lblBasicAddPrdInfo.TabIndex = 19;
            this.lblBasicAddPrdInfo.Text = "Basic Information :";
            // 
            // lblActionProduct
            // 
            this.lblActionProduct.AutoSize = true;
            this.lblActionProduct.Font = new System.Drawing.Font("Lucida Fax", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActionProduct.Location = new System.Drawing.Point(6, 15);
            this.lblActionProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActionProduct.Name = "lblActionProduct";
            this.lblActionProduct.Size = new System.Drawing.Size(244, 32);
            this.lblActionProduct.TabIndex = 18;
            this.lblActionProduct.Text = "Action Product ";
            // 
            // uActionProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlAddProductContent);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "uActionProduct";
            this.Size = new System.Drawing.Size(1439, 871);
            this.Load += new System.EventHandler(this.uActionProduct_Load);
            this.pnlAddProductContent.ResumeLayout(false);
            this.pnlAddProductContent.PerformLayout();
            this.pnlAddPrdInfo.ResumeLayout(false);
            this.pnlAddPrdInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddProductContent;
        private System.Windows.Forms.Panel pnlAddPrdInfo;
        private System.Windows.Forms.Label lblNewPrdName;
        private System.Windows.Forms.Label lblBasicAddPrdInfo;
        private System.Windows.Forms.Label lblActionProduct;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtPrdName;
        private System.Windows.Forms.ComboBox cmbPrdCategory;
        private System.Windows.Forms.Label lblPrdCategory;
        private System.Windows.Forms.TextBox txtPrdQuantity;
        private System.Windows.Forms.Label lblPrdQuantity;
        private System.Windows.Forms.TextBox txtPrdID;
        private System.Windows.Forms.Label lblPrdID;
        private System.Windows.Forms.Panel pnlBack;
        private System.Windows.Forms.Button btnResetAddPrd;
        private System.Windows.Forms.Button btnAddPrdSave;
        private System.Windows.Forms.TextBox txtPrdPrice;
        private System.Windows.Forms.Label lblPrdPrice;
        private System.Windows.Forms.Button btnUpdatePrdInfo;
        private System.Windows.Forms.Button btnDeletePrdInfo;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductStock;
        private System.Windows.Forms.Label lblAutoGen;
    }
}
