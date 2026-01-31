using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G_Shop
{
    public partial class uCategory : UserControl
    {
        private DataAccess Da { get; set; }
        public uCategory()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtCategoryName.Text) || 
                string.IsNullOrEmpty(this.txtCatgDesc.Text))
                return false;
            else
                return true;
        }

        public void PopulateGridView(string sql = "select * from CategoriesInfoDB;")
        {
            try
            {
                var ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    this.dgvCategoryList.AutoGenerateColumns = false;
                    this.dgvCategoryList.DataSource = ds.Tables[0];
                }
                else
                {
                    this.dgvCategoryList.DataSource = null;
                    MessageBox.Show($"Category  is not found.",
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void ClearAll()
        {
            this.txtCategoryID.Clear();
            this.txtCategoryName.Text = "";
            this.txtCatgDesc.Text = "";
            this.dgvCategoryList.ClearSelection();
        }

        //Showing all Categories
        private void btnShowAllCatg_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.txtSearch.Clear();
        }

        private void dgvCategoryList_DoubleClick(object sender, EventArgs e)
        {
            this.txtCategoryID.Text = this.dgvCategoryList.CurrentRow.Cells[0].Value.ToString();
            this.txtCategoryName.Text = this.dgvCategoryList.CurrentRow.Cells[1].Value.ToString();
            this.txtCatgDesc.Text = this.dgvCategoryList.CurrentRow.Cells[2].Value.ToString();
            
        }

        //Search code for Category by name
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {

                var sql = "select * from CategoriesInfoDB where CategoryName like '" + this.txtSearch.Text + "%';";
                this.PopulateGridView(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An ERROR has Occurred. Please Try it Again!" + exc.Message);
            }

        }

        //Insertion code for Category
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }
                string Insert_query = "insert into CategoriesInfoDB values ('" + txtCategoryName.Text + "','" + txtCatgDesc.Text +"')";
                var count = this.Da.ExecuteDMLQuery(Insert_query);
                if (count == 1)
                {
                    MessageBox.Show("New Category is added Succesfully !", "Category Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Insertion is Unsuccessfull !", "Category is not Inserted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An ERROR has Occured.Please Try it Again!" + exc.Message);
            }
        }

        //Update code for Category Info
        private void btnUpdateCatgInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                var query = "select * from CategoriesInfoDB where CategoryID ='" + this.txtCategoryID.Text + "';";
                var dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {
                    string Update_query = "update CategoriesInfoDB set CategoryName = '" + this.txtCategoryName.Text + @"',
                                Description = '" + this.txtCatgDesc.Text + @"'
                                where CategoryID ='" + txtCategoryID.Text + "';";
                    var count = this.Da.ExecuteDMLQuery(Update_query);

                    if (count == 1)
                        MessageBox.Show("Data has been updated", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //Deletion Code for Category info
        private void btnDeleteCatgInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                var categoryID = this.dgvCategoryList.CurrentRow.Cells[0].Value.ToString();
                var categoryName = this.dgvCategoryList.CurrentRow.Cells[1].Value.ToString();

                DialogResult res = MessageBox.Show("Are you sure to remove " + categoryName + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                    return;
                string Delete_query = "delete from CategoriesInfoDB where CategoryID ='" + categoryID + "'";
                var count = this.Da.ExecuteDMLQuery(Delete_query);
                if (count == 1)
                    MessageBox.Show(categoryName.ToUpper() + " has been removed from the list");
                else
                    MessageBox.Show("Data hasn't been deleted");

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An ERROR has Occured.Please Try it Again!" + exc.Message);
            }

        }

        private void txtCategoryName_TextChanged(object sender, EventArgs e)
        {
            if (txtCategoryName.Text.All(char.IsDigit))
            {
                MessageBox.Show("Category name must contain letters");
                txtCategoryName.Text = "";
            }

        }
    }
}
