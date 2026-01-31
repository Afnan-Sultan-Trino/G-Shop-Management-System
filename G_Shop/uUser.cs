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
    public partial class uUser : UserControl
    {
        private DataAccess Da { get; set; }
        public uUser()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            pnlUserContent.Controls.Clear();

            var actionUserBoard = new uActionUsers();
            actionUserBoard.Dock = DockStyle.Fill;
            pnlUserContent.Controls.Add(actionUserBoard);
        }
        public void PopulateGridView(string sql = "select * from UserInfoDB;")
        {
            try
            {
                var ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    this.dgvUserList.AutoGenerateColumns = false;
                    this.dgvUserList.DataSource = ds.Tables[0];
                }
                else
                {
                    this.dgvUserList.DataSource = null;
                    MessageBox.Show($"User '{txtSearch.Text}' is not found.",
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

        private void btnShowAllUsers_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.txtSearch.Clear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {

                var sql = "select * from UserInfoDB where FullName like '" + this.txtSearch.Text + "%';";
                this.PopulateGridView(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An ERROR has Occurred. Please Try it Again!" + exc.Message);
            }
        }
    }
}
