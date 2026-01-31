using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G_Shop
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            panel5.Cursor = Cursors.Hand;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtUserPassword.PasswordChar = '*';
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            if (txtUserPassword.PasswordChar == '*')
            {
                txtUserPassword.PasswordChar = '\0'; // Show password
            }
            else
            {
                txtUserPassword.PasswordChar = '*'; // Hide password
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUserEmail.Text = "";      // Clear email textbox

            txtUserPassword.Text = "";      // Clear password textbox

            txtUserEmail.Focus();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string email = txtUserEmail.Text;
            string password = txtUserPassword.Text;

            if (email == "" || password == "")
            {
                MessageBox.Show("Fill both fields");
                return;
            }

            // Using your DataAccess class
            DataAccess da = new DataAccess();

            // Get user info
            string query = $"SELECT * FROM UserInfoDB WHERE Email = '{email}' AND Password = '{password}'";
            var dt = da.ExecuteQueryTable(query);

            if (dt.Rows.Count > 0)
            {
                // Store in Session
                DataRow row = dt.Rows[0];
                Session.UserId = Convert.ToInt32(row["UserID"]);
                Session.FullName = row["FullName"].ToString();
                Session.Email = row["Email"].ToString();
                Session.Role = row["Role"].ToString().Trim();
                Session.SalesmanName = Session.FullName;

                MessageBox.Show("Login Successful");
                this.Hide();

                if (Session.Role.ToLower() == "admin")
                    new FormAdmin().Show();
                else if (Session.Role.ToLower() == "salesman")
                    new FormSalesman().Show();
            }
            else
            {
                MessageBox.Show("Invalid Email or Password");
            }
        }




        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.Red;
            btnClear.ForeColor = Color.White;
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.FromArgb(64, 64, 64);
            btnClear.ForeColor = Color.White;
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
