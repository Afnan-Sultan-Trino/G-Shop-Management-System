using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace G_Shop
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();

        }
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            SetupSalesChart();
            SetupCategoryChart();
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(lblAdmin, "Click to view admin information");
            pnlMyProfileInfo.Cursor = Cursors.Hand;
            lblAdmin.Cursor = Cursors.Hand;



        }
        private void SetupSalesChart()
        {
            
        }
        private void SetupCategoryChart()
        {
           
        }

        private void lblDashBoard_MouseEnter(object sender, EventArgs e)
        {
            lblDashBoard.BackColor = Color.Red;
            lblDashBoard.Cursor = Cursors.Hand;
        }

        private void lblDashBoard_MouseLeave(object sender, EventArgs e)
        {
            lblDashBoard.BackColor = Color.Transparent;

        }

        private void lblProduct_MouseEnter(object sender, EventArgs e)
        {
            lblProduct.BackColor = Color.Red;
            lblProduct.Cursor = Cursors.Hand;
        }

        private void lblProduct_MouseLeave(object sender, EventArgs e)
        {
            lblProduct.BackColor = Color.Transparent;
        }

        private void lblCatagory_MouseEnter(object sender, EventArgs e)
        {
            lblCatagory.BackColor = Color.Red;
            lblCatagory.Cursor = Cursors.Hand;
        }

        private void lblCatagory_MouseLeave(object sender, EventArgs e)
        {
            lblCatagory.BackColor = Color.Transparent;
        }

        private void lblSalesReport_MouseEnter(object sender, EventArgs e)
        {
            lblSalesReport.BackColor = Color.Red;
            lblSalesReport.Cursor = Cursors.Hand;
        }

        private void lblSalesReport_MouseLeave(object sender, EventArgs e)
        {
            lblSalesReport.BackColor = Color.Transparent;
        }

        private void lblUser_MouseEnter(object sender, EventArgs e)
        {
            lblUser.BackColor = Color.Red;
            lblUser.Cursor = Cursors.Hand;
        }

        private void lblUser_MouseLeave(object sender, EventArgs e)
        {
            lblUser.BackColor = Color.Transparent;
        }

        private void lblSetting_MouseEnter(object sender, EventArgs e)
        {
            lblSetting.BackColor = Color.Red;
            lblSetting.Cursor = Cursors.Hand;
        }

        private void lblSetting_MouseLeave(object sender, EventArgs e)
        {
            lblSetting.BackColor = Color.Transparent;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }
        private void lblProduct_Click(object sender, EventArgs e)
        {
            pnlMainContent.Controls.Clear();

            var productBoard = new uProduct();
            productBoard.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(productBoard);

        }
        private void lblDashBoard_Click(object sender, EventArgs e)
        {
            pnlMainContent.Controls.Clear();

            var dashboard = new uDashboard();
            dashboard.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(dashboard);
        }
        private void lblCatagory_Click(object sender, EventArgs e)
        {
            pnlMainContent.Controls.Clear();

            var categoryBoard = new uCategory();
            categoryBoard.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(categoryBoard);
        }
        private void lblSalesReport_Click(object sender, EventArgs e)
        {
            pnlMainContent.Controls.Clear();

            var salesReportBoard = new uSalesReport();
            salesReportBoard.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(salesReportBoard);
        }
        private void lblUser_Click(object sender, EventArgs e)
        {
            pnlMainContent.Controls.Clear();

            var userBoard = new uUser();
            userBoard.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(userBoard);

        }

        private void lblAdmin_Click(object sender, EventArgs e)
        {
            pnlMainContent.Controls.Clear();

            var adminProfileBoard = new uAdminProfile();
            adminProfileBoard.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(adminProfileBoard);
        }

        private void lblSetting_Click(object sender, EventArgs e)
        {
            pnlMainContent.Controls.Clear();

            var settingBoard = new uSetting();
            settingBoard.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(settingBoard);

        }
        private void lblLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dir = MessageBox.Show("Are you Sure you want to log out ?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dir == DialogResult.Yes)
            {
                FormLogin loginPage = new FormLogin();
                loginPage.Show();
                this.Hide();
            }
        }
        private void lblLogOut_MouseEnter(object sender, EventArgs e)
        {
            lblLogOut.BackColor = Color.Red;

        }
        private void lblLogOut_MouseLeave(object sender, EventArgs e)
        {
            lblLogOut.BackColor = Color.Transparent;
        }

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
