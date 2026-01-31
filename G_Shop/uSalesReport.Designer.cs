namespace G_Shop
{
    partial class uSalesReport
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
            this.pnlSalesReportContent = new System.Windows.Forms.Panel();
            this.dgvSalesReportList = new System.Windows.Forms.DataGridView();
            this.lblDetailSale = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.lblOverView = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.lblSalesRepDescription = new System.Windows.Forms.Label();
            this.lblSalesReport = new System.Windows.Forms.Label();
            this.btnTotalRevenue = new System.Windows.Forms.Button();
            this.btnProductPerformance = new System.Windows.Forms.Button();
            this.btnSalesmanPerformance = new System.Windows.Forms.Button();
            this.SaleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesmanName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlSalesReportContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReportList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSalesReportContent
            // 
            this.pnlSalesReportContent.AutoScroll = true;
            this.pnlSalesReportContent.AutoScrollMinSize = new System.Drawing.Size(0, 1300);
            this.pnlSalesReportContent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSalesReportContent.Controls.Add(this.btnRefresh);
            this.pnlSalesReportContent.Controls.Add(this.btnSalesmanPerformance);
            this.pnlSalesReportContent.Controls.Add(this.btnProductPerformance);
            this.pnlSalesReportContent.Controls.Add(this.btnTotalRevenue);
            this.pnlSalesReportContent.Controls.Add(this.dgvSalesReportList);
            this.pnlSalesReportContent.Controls.Add(this.lblDetailSale);
            this.pnlSalesReportContent.Controls.Add(this.lblOverView);
            this.pnlSalesReportContent.Controls.Add(this.dtp);
            this.pnlSalesReportContent.Controls.Add(this.panel16);
            this.pnlSalesReportContent.Controls.Add(this.lblSalesRepDescription);
            this.pnlSalesReportContent.Controls.Add(this.lblSalesReport);
            this.pnlSalesReportContent.Location = new System.Drawing.Point(23, 34);
            this.pnlSalesReportContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSalesReportContent.Name = "pnlSalesReportContent";
            this.pnlSalesReportContent.Size = new System.Drawing.Size(1392, 802);
            this.pnlSalesReportContent.TabIndex = 13;
            // 
            // dgvSalesReportList
            // 
            this.dgvSalesReportList.AllowUserToAddRows = false;
            this.dgvSalesReportList.AllowUserToDeleteRows = false;
            this.dgvSalesReportList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSalesReportList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesReportList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaleID,
            this.ProductName,
            this.Price,
            this.Quantity,
            this.Total,
            this.SaleDate,
            this.SalesmanName});
            this.dgvSalesReportList.Location = new System.Drawing.Point(11, 355);
            this.dgvSalesReportList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSalesReportList.Name = "dgvSalesReportList";
            this.dgvSalesReportList.ReadOnly = true;
            this.dgvSalesReportList.RowHeadersWidth = 51;
            this.dgvSalesReportList.Size = new System.Drawing.Size(1248, 359);
            this.dgvSalesReportList.TabIndex = 29;
            // 
            // lblDetailSale
            // 
            this.lblDetailSale.AutoSize = true;
            this.lblDetailSale.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailSale.Location = new System.Drawing.Point(16, 321);
            this.lblDetailSale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetailSale.Name = "lblDetailSale";
            this.lblDetailSale.Size = new System.Drawing.Size(182, 26);
            this.lblDetailSale.TabIndex = 28;
            this.lblDetailSale.Text = "Detailed Sales";
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.Transparent;
            this.panel16.BackgroundImage = global::G_Shop.Properties.Resources.sales1;
            this.panel16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel16.Location = new System.Drawing.Point(239, 15);
            this.panel16.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(97, 65);
            this.panel16.TabIndex = 11;
            // 
            // lblOverView
            // 
            this.lblOverView.AutoSize = true;
            this.lblOverView.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverView.Location = new System.Drawing.Point(5, 154);
            this.lblOverView.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOverView.Name = "lblOverView";
            this.lblOverView.Size = new System.Drawing.Size(135, 26);
            this.lblOverView.TabIndex = 24;
            this.lblOverView.Text = "Over View";
            // 
            // dtp
            // 
            this.dtp.CalendarFont = new System.Drawing.Font("Book Antiqua", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Location = new System.Drawing.Point(844, 84);
            this.dtp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(384, 31);
            this.dtp.TabIndex = 23;
            // 
            // lblSalesRepDescription
            // 
            this.lblSalesRepDescription.AutoSize = true;
            this.lblSalesRepDescription.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesRepDescription.ForeColor = System.Drawing.Color.DimGray;
            this.lblSalesRepDescription.Location = new System.Drawing.Point(4, 111);
            this.lblSalesRepDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalesRepDescription.Name = "lblSalesRepDescription";
            this.lblSalesRepDescription.Size = new System.Drawing.Size(421, 23);
            this.lblSalesRepDescription.TabIndex = 18;
            this.lblSalesRepDescription.Text = "Executive Sales Performance Summary";
            // 
            // lblSalesReport
            // 
            this.lblSalesReport.AutoSize = true;
            this.lblSalesReport.Font = new System.Drawing.Font("Lucida Fax", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesReport.Location = new System.Drawing.Point(4, 48);
            this.lblSalesReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalesReport.Name = "lblSalesReport";
            this.lblSalesReport.Size = new System.Drawing.Size(199, 32);
            this.lblSalesReport.TabIndex = 17;
            this.lblSalesReport.Text = "Sales Report";
            // 
            // btnTotalRevenue
            // 
            this.btnTotalRevenue.BackColor = System.Drawing.Color.DarkOrange;
            this.btnTotalRevenue.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalRevenue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTotalRevenue.Location = new System.Drawing.Point(474, 295);
            this.btnTotalRevenue.Margin = new System.Windows.Forms.Padding(4);
            this.btnTotalRevenue.Name = "btnTotalRevenue";
            this.btnTotalRevenue.Size = new System.Drawing.Size(205, 52);
            this.btnTotalRevenue.TabIndex = 30;
            this.btnTotalRevenue.Text = "Total Revenue";
            this.btnTotalRevenue.UseVisualStyleBackColor = false;
            this.btnTotalRevenue.Click += new System.EventHandler(this.btnTotalRevenue_Click);
            // 
            // btnProductPerformance
            // 
            this.btnProductPerformance.BackColor = System.Drawing.Color.YellowGreen;
            this.btnProductPerformance.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductPerformance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProductPerformance.Location = new System.Drawing.Point(687, 295);
            this.btnProductPerformance.Margin = new System.Windows.Forms.Padding(4);
            this.btnProductPerformance.Name = "btnProductPerformance";
            this.btnProductPerformance.Size = new System.Drawing.Size(273, 52);
            this.btnProductPerformance.TabIndex = 31;
            this.btnProductPerformance.Text = "Product Performance";
            this.btnProductPerformance.UseVisualStyleBackColor = false;
            this.btnProductPerformance.Click += new System.EventHandler(this.btnProductPerformance_Click);
            // 
            // btnSalesmanPerformance
            // 
            this.btnSalesmanPerformance.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSalesmanPerformance.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesmanPerformance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalesmanPerformance.Location = new System.Drawing.Point(968, 295);
            this.btnSalesmanPerformance.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalesmanPerformance.Name = "btnSalesmanPerformance";
            this.btnSalesmanPerformance.Size = new System.Drawing.Size(291, 52);
            this.btnSalesmanPerformance.TabIndex = 32;
            this.btnSalesmanPerformance.Text = "Salesman Performance";
            this.btnSalesmanPerformance.UseVisualStyleBackColor = false;
            this.btnSalesmanPerformance.Click += new System.EventHandler(this.btnSalesmanPerformance_Click);
            // 
            // SaleID
            // 
            this.SaleID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SaleID.DataPropertyName = "SaleID";
            this.SaleID.HeaderText = "SalesID";
            this.SaleID.MinimumWidth = 6;
            this.SaleID.Name = "SaleID";
            this.SaleID.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Total Quantity Sold";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total Amount";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // SaleDate
            // 
            this.SaleDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SaleDate.DataPropertyName = "SaleDate";
            this.SaleDate.HeaderText = "Sales Date and Time";
            this.SaleDate.MinimumWidth = 6;
            this.SaleDate.Name = "SaleDate";
            this.SaleDate.ReadOnly = true;
            // 
            // SalesmanName
            // 
            this.SalesmanName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SalesmanName.DataPropertyName = "SalesmanName";
            this.SalesmanName.HeaderText = "Salesman Name";
            this.SalesmanName.MinimumWidth = 6;
            this.SalesmanName.Name = "SalesmanName";
            this.SalesmanName.ReadOnly = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Black;
            this.btnRefresh.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefresh.Location = new System.Drawing.Point(287, 295);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(179, 52);
            this.btnRefresh.TabIndex = 33;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // uSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlSalesReportContent);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "uSalesReport";
            this.Size = new System.Drawing.Size(1439, 871);
            this.pnlSalesReportContent.ResumeLayout(false);
            this.pnlSalesReportContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReportList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSalesReportContent;
        private System.Windows.Forms.Label lblSalesRepDescription;
        private System.Windows.Forms.Label lblSalesReport;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label lblOverView;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.DataGridView dgvSalesReportList;
        private System.Windows.Forms.Label lblDetailSale;
        private System.Windows.Forms.Button btnTotalRevenue;
        private System.Windows.Forms.Button btnSalesmanPerformance;
        private System.Windows.Forms.Button btnProductPerformance;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesmanName;
        private System.Windows.Forms.Button btnRefresh;
    }
}
