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
using System.Windows.Forms.DataVisualization.Charting;

namespace G_Shop
{
    public partial class uActionProduct : UserControl

    {
        private DataAccess Da { get; set; }
        private uProduct UProduct { get; set; }
        public uActionProduct()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.UProduct = new uProduct();
            this.PopulateGridView();
            
        }
        

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlAddProductContent.Controls.Clear();

            var productBoard = new uProduct();
            productBoard.Dock = DockStyle.Fill;
            pnlAddProductContent.Controls.Add(productBoard);
        }

        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtPrdName.Text) || string.IsNullOrEmpty(this.cmbPrdCategory.Text) ||
                 string.IsNullOrEmpty(this.txtPrdQuantity.Text) ||
                string.IsNullOrEmpty(this.txtPrdPrice.Text))
                return false;
            else
                return true;
        }
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
                    MessageBox.Show($"Product  is not found.",
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

        //Code for Insertion Product
        private void btnAddPrdSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }
                string Insert_query = "insert into ProductInfoDB values('" + txtPrdName.Text + "','" + cmbPrdCategory.Text + "','" + txtPrdQuantity.Text + "','" + txtPrdPrice.Text + "')";
                var count = this.Da.ExecuteDMLQuery(Insert_query);
                if (count == 1)
                {
                    MessageBox.Show("Product is added Succesfully !", "Product Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Insertion is Unsuccessfull !", "Product is not Inserted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An ERROR has Occured.Please Try it Again!" + exc.Message);
            }

        }

        //Reset code 
        private void btnResetAddPrd_Click(object sender, EventArgs e)
        {
           ClearAll();
        }
        private void ClearAll()
        {
            this.txtPrdID.Clear();
            this.txtPrdName.Text = "";
            this.cmbPrdCategory.Text = "";
            this.txtPrdID.Text = "";
            this.txtPrdQuantity.Text = "";
            this.txtPrdPrice.Text = "";
            this.dgvProductList.ClearSelection();
        }

        //Code for Update Product
        private void btnUpdatePrdInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                var query = "select * from ProductInfoDB where [Product Id] ='" + this.txtPrdID.Text + "';";
                var dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {
                    string Update_query = "update ProductInfoDB set [Product Name] = '" + this.txtPrdName.Text + @"',
                                Price = " + this.txtPrdPrice.Text + @",
                                Quantity = " + this.txtPrdQuantity.Text + @",
                                Category = '" + this.cmbPrdCategory.Text + @"'
                                where [Product ID]='" + txtPrdID.Text + "';";
                    var count = this.Da.ExecuteDMLQuery(Update_query);

                    if (count == 1)
                        MessageBox.Show("Data has been updated", "Update Complete",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Data hasn't been updated", "Update Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An ERROR has Occured.Please Try it Again!" + exc.Message);
            }
        }

        //Code for delete Product
        private void btnDeletePrdInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                var prdName = this.dgvProductList.CurrentRow.Cells[0].Value.ToString();
                var prdID = this.dgvProductList.CurrentRow.Cells[1].Value.ToString();

                DialogResult res = MessageBox.Show("Are you sure to remove " + prdName + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                    return;
                string Delete_query = "delete from ProductInfoDB where [Product ID] ='" + prdID + "'";
                var count = this.Da.ExecuteDMLQuery(Delete_query);
                if (count == 1)
                    MessageBox.Show(prdName.ToUpper() + " has been removed from the list");
                else
                    MessageBox.Show("Data hasn't been deleted");

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An ERROR has Occured.Please Try it Again!"+exc.Message);
            }

        }
        private void uActionProduct_Load(object sender, EventArgs e)
        {
            this.PopulateGridView();
            this.dgvProductList.ClearSelection();

        }

        private void dgvProductList_DoubleClick(object sender, EventArgs e)
        {
            this.txtPrdName.Text= this.dgvProductList.CurrentRow.Cells[0].Value.ToString();
            this.txtPrdID.Text= this.dgvProductList.CurrentRow.Cells[1].Value.ToString();
            this.cmbPrdCategory.Text= this.dgvProductList.CurrentRow.Cells[2].Value.ToString();
            this.txtPrdPrice.Text= this.dgvProductList.CurrentRow.Cells[3].Value.ToString();
            this.txtPrdQuantity.Text= this.dgvProductList.CurrentRow.Cells[4].Value.ToString();
        }
        private void uActionProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?",
                                                 "Exit Application",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void txtPrdQuantity_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPrdQuantity.Text, out int quantity))
            {
                MessageBox.Show("Please enter numbers only");
                txtPrdQuantity.Clear();
                return;
            }

            if (quantity < 0)
            {
                MessageBox.Show("Quantity must be positive");
                txtPrdQuantity.Clear();
            }
        }

        private void txtPrdPrice_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtPrdPrice.Text, out decimal price))
            {
                MessageBox.Show("Please enter a valid price");
                txtPrdPrice.Clear();
                txtPrdPrice.Focus();
                return;
            }


            if (price <= 0)
            {
                MessageBox.Show("Price must be greater than zero");
                txtPrdPrice.Clear();
                txtPrdPrice.Focus();
            }
        }
    }
}
