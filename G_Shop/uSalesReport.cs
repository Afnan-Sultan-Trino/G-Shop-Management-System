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
    public partial class uSalesReport : UserControl
    {
        private DataAccess Da { get; set; }
        public uSalesReport()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }
        private void uSalesReport_Load(object sender, EventArgs e)
        {
           
        }
        public void PopulateGridView(string sql = "select * from SalesInfoDB;")
        {
            try
            {
                var ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    this.dgvSalesReportList.AutoGenerateColumns = true;
                    this.dgvSalesReportList.DataSource = ds.Tables[0];
                }
                else
                {
                    this.dgvSalesReportList.DataSource = null;
                    MessageBox.Show($"Sales Report  is not found.",
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

        private void btnTotalRevenue_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT SUM(Total) as 'Total Revenue' FROM SalesInfoDB";



                DataSet ds = this.Da.ExecuteQuery(query);
                dgvSalesReportList.DataSource = ds.Tables[0];
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnProductPerformance_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT ProductName, SUM(Total) as Revenue, SUM(Quantity) as UnitsSold FROM SalesInfoDB GROUP BY ProductName ORDER BY Revenue DESC";

                DataSet ds = this.Da.ExecuteQuery(query);
                dgvSalesReportList.DataSource = ds.Tables[0];
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnSalesmanPerformance_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT SalesmanName, SUM(Total) as SalesAmount FROM SalesInfoDB GROUP BY SalesmanName ORDER BY SalesAmount DESC";
                DataSet ds = this.Da.ExecuteQuery(query);
                dgvSalesReportList.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }
    }
}
