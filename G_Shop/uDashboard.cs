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
    public partial class uDashboard : UserControl
    {
        public uDashboard()
        {
            InitializeComponent();
        }
        private void uDashboard_Load(object sender, EventArgs e)
        {
            SetupSalesChart();
            SetupCategoryChart();

        }
        private void SetupSalesChart()
        {
            chart1.Series["Sales(By Time)"].Points.AddXY("9 AM", 1200);
            chart1.Series["Sales(By Time)"].Points.AddXY("10 AM", 1800);
            chart1.Series["Sales(By Time)"].Points.AddXY("11 AM", 1500);
            chart1.Series["Sales(By Time)"].Points.AddXY("12 PM", 2200);
            chart1.Series["Sales(By Time)"].Points.AddXY("1 PM", 5000);
            chart1.Series["Sales(By Time)"].Points.AddXY("2 PM", 890);
            chart1.Series["Sales(By Time)"].Points.AddXY("3 PM", 3000);
        }
        private void SetupCategoryChart()
        {
            chart2.Series["Sales(By Categories)"].Points.AddXY("Smartphones", 4500);
            chart2.Series["Sales(By Categories)"].Points.AddXY("Laptop", 56000);
            chart2.Series["Sales(By Categories)"].Points.AddXY("Smart-Watch", 2500);
            chart2.Series["Sales(By Categories)"].Points.AddXY("Tablet", 18500);
            chart2.Series["Sales(By Categories)"].Points.AddXY("Mouse", 3400);
            chart2.Series["Sales(By Categories)"].Points.AddXY("Others", 500);
        }
    }
}
