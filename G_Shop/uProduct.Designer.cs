namespace G_Shop
{
    partial class uProduct
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
            this.pnlProductContent = new System.Windows.Forms.Panel();
            this.lblSearchPrdName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLowStock = new System.Windows.Forms.Button();
            this.pnlTablePic = new System.Windows.Forms.Panel();
            this.pnlRefresh = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnShowAllPrd = new System.Windows.Forms.Button();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.btnActionProduct = new System.Windows.Forms.Button();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblProductListDescription = new System.Windows.Forms.Label();
            this.lblProductList = new System.Windows.Forms.Label();
            this.ProductList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlProductContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProductContent
            // 
            this.pnlProductContent.AutoScroll = true;
            this.pnlProductContent.AutoScrollMinSize = new System.Drawing.Size(0, 1300);
            this.pnlProductContent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlProductContent.Controls.Add(this.lblSearchPrdName);
            this.pnlProductContent.Controls.Add(this.panel1);
            this.pnlProductContent.Controls.Add(this.btnLowStock);
            this.pnlProductContent.Controls.Add(this.pnlTablePic);
            this.pnlProductContent.Controls.Add(this.pnlRefresh);
            this.pnlProductContent.Controls.Add(this.btnRefresh);
            this.pnlProductContent.Controls.Add(this.btnShowAllPrd);
            this.pnlProductContent.Controls.Add(this.dgvProductList);
            this.pnlProductContent.Controls.Add(this.btnActionProduct);
            this.pnlProductContent.Controls.Add(this.btnSearchProduct);
            this.pnlProductContent.Controls.Add(this.txtSearch);
            this.pnlProductContent.Controls.Add(this.lblProductListDescription);
            this.pnlProductContent.Controls.Add(this.lblProductList);
            this.pnlProductContent.Location = new System.Drawing.Point(4, 4);
            this.pnlProductContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlProductContent.Name = "pnlProductContent";
            this.pnlProductContent.Size = new System.Drawing.Size(1392, 802);
            this.pnlProductContent.TabIndex = 10;
            // 
            // lblSearchPrdName
            // 
            this.lblSearchPrdName.AutoSize = true;
            this.lblSearchPrdName.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchPrdName.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblSearchPrdName.Location = new System.Drawing.Point(20, 233);
            this.lblSearchPrdName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchPrdName.Name = "lblSearchPrdName";
            this.lblSearchPrdName.Size = new System.Drawing.Size(269, 21);
            this.lblSearchPrdName.TabIndex = 29;
            this.lblSearchPrdName.Text = "[ Search By Product Name ]";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.BackgroundImage = global::G_Shop.Properties.Resources.warning_sign;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(760, 268);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(47, 42);
            this.panel1.TabIndex = 28;
            // 
            // btnLowStock
            // 
            this.btnLowStock.BackColor = System.Drawing.Color.Orange;
            this.btnLowStock.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLowStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLowStock.Location = new System.Drawing.Point(752, 261);
            this.btnLowStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLowStock.Name = "btnLowStock";
            this.btnLowStock.Size = new System.Drawing.Size(260, 55);
            this.btnLowStock.TabIndex = 27;
            this.btnLowStock.Text = "Low Stock";
            this.btnLowStock.UseVisualStyleBackColor = false;
            this.btnLowStock.Click += new System.EventHandler(this.btnLowStock_Click);
            // 
            // pnlTablePic
            // 
            this.pnlTablePic.BackColor = System.Drawing.Color.YellowGreen;
            this.pnlTablePic.BackgroundImage = global::G_Shop.Properties.Resources.table;
            this.pnlTablePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTablePic.Location = new System.Drawing.Point(1048, 266);
            this.pnlTablePic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTablePic.Name = "pnlTablePic";
            this.pnlTablePic.Size = new System.Drawing.Size(48, 46);
            this.pnlTablePic.TabIndex = 26;
            // 
            // pnlRefresh
            // 
            this.pnlRefresh.BackColor = System.Drawing.Color.Crimson;
            this.pnlRefresh.BackgroundImage = global::G_Shop.Properties.Resources.refresh_page_option;
            this.pnlRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRefresh.Location = new System.Drawing.Point(512, 270);
            this.pnlRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlRefresh.Name = "pnlRefresh";
            this.pnlRefresh.Size = new System.Drawing.Size(47, 42);
            this.pnlRefresh.TabIndex = 25;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Crimson;
            this.btnRefresh.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefresh.Location = new System.Drawing.Point(508, 266);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(217, 50);
            this.btnRefresh.TabIndex = 24;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnShowAllPrd
            // 
            this.btnShowAllPrd.BackColor = System.Drawing.Color.YellowGreen;
            this.btnShowAllPrd.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllPrd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowAllPrd.Location = new System.Drawing.Point(1039, 261);
            this.btnShowAllPrd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowAllPrd.Name = "btnShowAllPrd";
            this.btnShowAllPrd.Size = new System.Drawing.Size(245, 55);
            this.btnShowAllPrd.TabIndex = 23;
            this.btnShowAllPrd.Text = "Show All";
            this.btnShowAllPrd.UseVisualStyleBackColor = false;
            this.btnShowAllPrd.Click += new System.EventHandler(this.btnShowAllPrd_Click);
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
            this.dgvProductList.Location = new System.Drawing.Point(12, 337);
            this.dgvProductList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.RowHeadersWidth = 51;
            this.dgvProductList.Size = new System.Drawing.Size(1272, 394);
            this.dgvProductList.TabIndex = 22;
            // 
            // btnActionProduct
            // 
            this.btnActionProduct.BackColor = System.Drawing.Color.Black;
            this.btnActionProduct.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActionProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActionProduct.Location = new System.Drawing.Point(1013, 145);
            this.btnActionProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActionProduct.Name = "btnActionProduct";
            this.btnActionProduct.Size = new System.Drawing.Size(271, 64);
            this.btnActionProduct.TabIndex = 21;
            this.btnActionProduct.Text = "Action Product";
            this.btnActionProduct.UseVisualStyleBackColor = false;
            this.btnActionProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSearchProduct.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchProduct.Location = new System.Drawing.Point(12, 267);
            this.btnSearchProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(135, 52);
            this.btnSearchProduct.TabIndex = 20;
            this.btnSearchProduct.Text = "Search";
            this.btnSearchProduct.UseVisualStyleBackColor = false;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(145, 270);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(353, 46);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.Text = "Search here....";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblProductListDescription
            // 
            this.lblProductListDescription.AutoSize = true;
            this.lblProductListDescription.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductListDescription.ForeColor = System.Drawing.Color.DimGray;
            this.lblProductListDescription.Location = new System.Drawing.Point(7, 69);
            this.lblProductListDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductListDescription.Name = "lblProductListDescription";
            this.lblProductListDescription.Size = new System.Drawing.Size(836, 46);
            this.lblProductListDescription.TabIndex = 18;
            this.lblProductListDescription.Text = "The product list effectively dictates product presentation and \nprovides space to" +
    " list your products and offering in the most appealing way.\r\n";
            // 
            // lblProductList
            // 
            this.lblProductList.AutoSize = true;
            this.lblProductList.Font = new System.Drawing.Font("Lucida Fax", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductList.Location = new System.Drawing.Point(4, 30);
            this.lblProductList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductList.Name = "lblProductList";
            this.lblProductList.Size = new System.Drawing.Size(194, 32);
            this.lblProductList.TabIndex = 17;
            this.lblProductList.Text = "Product List";
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
            // uProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.pnlProductContent);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "uProduct";
            this.Size = new System.Drawing.Size(1439, 871);
            this.pnlProductContent.ResumeLayout(false);
            this.pnlProductContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProductContent;
        private System.Windows.Forms.Label lblProductList;
        private System.Windows.Forms.Label lblProductListDescription;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.Button btnActionProduct;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.Button btnShowAllPrd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlRefresh;
        private System.Windows.Forms.Panel pnlTablePic;
        private System.Windows.Forms.Button btnLowStock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSearchPrdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductStock;
    }
}
