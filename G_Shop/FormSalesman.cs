using System;
using System.Data;
using System.Windows.Forms;

namespace G_Shop
{
    public partial class FormSalesman : Form
    {
        private DataAccess Da { get; set; }

        public FormSalesman()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            // Set session info
            lblName.Text = Session.FullName;
            lblEmail.Text = Session.Email;
            lblRole.Text = Session.Role;
            this.LoadSalesmanProfile();
            this.pnlSalesmanProfileSettings.Visible = false;
        }

        private void lblCart_Click(object sender, EventArgs e)
        {
            FormCart cartForm = new FormCart();
            cartForm.SalesmanName = Session.FullName; // Use salesman's name
            cartForm.Show();
            this.Hide();
        }

        private void lblLogout_Click_1(object sender, EventArgs e)
        {
            DialogResult dir = MessageBox.Show("Are you Sure you want to log out?",
                 "Confirm Logout",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);

            if (dir == DialogResult.Yes)
            {
                Session.UserId = 0;
                Session.FullName = null;
                Session.Email = null;
                Session.Role = null;
                Session.SalesmanName = null; // Add this if you have it

                new FormLogin().Show();
                this.Hide();
            }
        }

        private void lblSettings_Click(object sender, EventArgs e)
        {
            LoadSalesmanProfile(); // Load current info
            this.pnlSalesmanProfileContent.Visible = false;
            this.pnlSalesmanProfileSettings.Visible = true;
        }

        // Load current salesman's profile info
        private void LoadSalesmanProfile()
        {
            try
            {
                string query = $"SELECT FullName, Email, Password, Phone FROM UserInfoDB WHERE UserID = {Session.UserId}";
                DataTable dt = Da.ExecuteQueryTable(query);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txtSalSettingFullName.Text = row["FullName"].ToString();
                    txtSalSettingEmailName.Text = row["Email"].ToString();
                    txtSalSettingNewPass.Text = row["Password"].ToString();
                    txtSalSettingPhn.Text = row["Phone"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message);
            }
        }

        private bool IsValidToSave()
        {
            return !(string.IsNullOrEmpty(txtSalSettingEmailName.Text) ||
                    string.IsNullOrEmpty(txtSalSettingFullName.Text) ||
                    string.IsNullOrEmpty(txtSalSettingNewPass.Text) ||
                    string.IsNullOrEmpty(txtSalSettingPhn.Text));
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.pnlSalesmanProfileSettings.Visible = false;
            this.pnlSalesmanProfileContent.Visible = true;
        }

        private void btnResetEdit_Click(object sender, EventArgs e)
        {
            LoadSalesmanProfile();
            this.ClearAll();

        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidToSave())
                {
                    MessageBox.Show("Please fill all fields");
                    return;
                }

                string query = $@"
                    UPDATE UserInfoDB 
                    SET FullName = '{txtSalSettingFullName.Text.Replace("'", "''")}',
                        Email = '{txtSalSettingEmailName.Text.Replace("'", "''")}',
                        Password = '{txtSalSettingNewPass.Text.Replace("'", "''")}',
                        Phone = '{txtSalSettingPhn.Text.Replace("'", "''")}'
                    WHERE UserID = {Session.UserId}";

                int result = Da.ExecuteDMLQuery(query);

                if (result > 0)
                {
                    MessageBox.Show("Profile Updated!");

                    // Update session info
                    Session.FullName = txtSalSettingFullName.Text;
                    Session.Email = txtSalSettingEmailName.Text;

                    // Update displayed info
                    lblName.Text = Session.FullName;
                    lblEmail.Text = Session.Email;
                }
                else
                {
                    MessageBox.Show("Update Failed");
                }
                this.ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void pnlCart_Paint(object sender, PaintEventArgs e)
        {
            // Empty method - just to satisfy the designer
        }

        private void FormSalesman_Load(object sender, EventArgs e)
        {
            // Empty method - just to satisfy the designer
        }
        private void ClearAll()
        {
            this.txtSalSettingEmailName.Text="";
            this.txtSalSettingFullName.Text = "";
            this.txtSalSettingNewPass.Text = "";
            this.txtSalSettingPhn.Text = "";

        }

        private void FormSalesman_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}