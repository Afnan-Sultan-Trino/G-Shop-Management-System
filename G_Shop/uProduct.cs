using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G_Shop
{
    public partial class uProduct : UserControl
    {
        private DataAccess Da {  get; set; }
        public uProduct()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            pnlProductContent.Controls.Clear();

            var actionProductBoard = new uActionProduct();
            actionProductBoard.Dock = DockStyle.Fill;
            pnlProductContent.Controls.Add(actionProductBoard);
        }

        //Code for Showing ALL Product
        public void PopulateGridView(string sql = "select * from ProductInfoDB;")
        {
            try
            {
                var ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    this.dgvProductList.AutoGenerateColumns = false;
                    this.dgvProductList.DataSource = ds.Tables[0];
                }
                else
                {
                    this.dgvProductList.DataSource = null;
                    MessageBox.Show($"Product '{txtSearch.Text}' is not found.",
                               "Search Result",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An ERROR has Occured.Please Try it Again!" + exc.Message);
            }
        }

        private void btnShowAllPrd_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        //code for Search Product
        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    MessageBox.Show("Please enter a Product Name to search.",
                                   "Search Error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Warning);
                    return;
                }

                string searchProduct_query = "SELECT * FROM ProductInfoDB where [Product name]='" + txtSearch.Text + "'";
                this.PopulateGridView(searchProduct_query);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An ERROR has Occured.Please Try it Again!" + exc.Message);
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.txtSearch.Clear();
        }

        //Code for Low Stock
        private void btnLowStock_Click(object sender, EventArgs e)
        {
            try
            {
                string lowStock_query = "Select* from ProductInfoDB where Quantity<15;";
                this.PopulateGridView(lowStock_query);
                if (this.dgvProductList.Rows.Count > 0)
                {
                    HighlightLowStock();
                }
                else
                {
                    MessageBox.Show("No Products are in Low Stock!", "Good News!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An ERROR has Occured.Please Try it Again!" + exc.Message);
            }
        }
        private void HighlightLowStock()
        {
            foreach (DataGridViewRow row in this.dgvProductList.Rows)
            {
                
                if (Convert.ToInt32(row.Cells["ProductStock"].Value) < 15)
                {
                    row.DefaultCellStyle.BackColor = Color.DarkRed;
                    row.DefaultCellStyle.ForeColor = Color.White;
                    row.DefaultCellStyle.Font = new Font(dgvProductList.Font, FontStyle.Bold);

                }
            }
        }

        //Searching Product by their name
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var sql = "select * from ProductInfoDB where [Product Name] like '" + this.txtSearch.Text + "%';";
                this.PopulateGridView(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An ERROR has Occured.Please Try it Again!" + exc.Message);

            }
        }
    }
}
