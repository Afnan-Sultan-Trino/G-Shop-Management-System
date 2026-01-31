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
    public partial class uActionUsers : UserControl
    {
        private DataAccess Da { get; set; }
        private uUser UUser { get; set; }
        public uActionUsers()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.UUser = new uUser();
            this.PopulateGridView();
            this.ClearAll();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlAddUsersContent.Controls.Clear();

            var UserBoard = new uUser();
            UserBoard.Dock = DockStyle.Fill;
            pnlAddUsersContent.Controls.Add(UserBoard);
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

        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtUserName.Text) || string.IsNullOrEmpty(this.cmbUserRoles.Text) ||
                 string.IsNullOrEmpty(this.txtUserContact.Text) || string.IsNullOrEmpty(this.txtUserPass.Text) || string.IsNullOrEmpty(this.dtp.Text) ||
                string.IsNullOrEmpty(this.txtUserEmail.Text))
            {
                return false;
            }
            if (!rdbUserMale.Checked && !rdbUserFemale.Checked)
            {
                return false;
            }

            return true;
        }

        //Insertion code of New Users
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }
                string gender = "";
                if (rdbUserMale.Checked)
                {
                    gender = "Male";
                }
                else if (rdbUserFemale.Checked)
                {
                    gender = "Female";
                }

                string formattedDate = dtp.Value.ToShortDateString();


                string Insert_query = @"insert into UserInfoDB 
                                (FullName, Role, Phone, Password, CreatedDate, Email, Gender) 
                                values('" + txtUserName.Text + "','" +
                               cmbUserRoles.Text + "','" +
                               txtUserContact.Text + "','" +
                               txtUserPass.Text + "','" +
                               formattedDate + "','" +
                               txtUserEmail.Text + "','" +
                               gender + "')";
                var count = this.Da.ExecuteDMLQuery(Insert_query);
                if (count == 1)
                {
                    MessageBox.Show("User is added Succesfully !", "User Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Insertion is Unsuccessfull !", "User is not Inserted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void ClearAll()
        {
            this.txtUserName.Clear();
            this.txtUserContact.Text = "";
            this.cmbUserRoles.Text = "";
            this.txtUserID.Text = "";
            this.txtUserEmail.Text = "";
            this.txtUserPass.Text = "";
            this.dtp.Text = "";
            this.rdbUserMale.Checked = false;
            this.rdbUserFemale.Checked = false;
            this.dgvUserList.ClearSelection();
        }

        private void dgvUserList_DoubleClick(object sender, EventArgs e)
        {
            this.txtUserID.Text = this.dgvUserList.CurrentRow.Cells["UserID"].Value.ToString();
            this.txtUserName.Text = this.dgvUserList.CurrentRow.Cells["FullName"].Value.ToString();
            this.txtUserEmail.Text = this.dgvUserList.CurrentRow.Cells["Email"].Value.ToString();
            this.txtUserPass.Text = this.dgvUserList.CurrentRow.Cells["Password"].Value.ToString();
            this.cmbUserRoles.Text = this.dgvUserList.CurrentRow.Cells["Role"].Value.ToString();
            this.txtUserContact.Text = this.dgvUserList.CurrentRow.Cells["Phone"].Value.ToString();
            this.dtp.Text= this.dgvUserList.CurrentRow.Cells["CreatedDate"].Value.ToString();
            string gender = this.dgvUserList.CurrentRow.Cells["Gender"].Value.ToString();

            if (gender == "Male")
            {
                this.rdbUserMale.Checked = true;
                // this.rdbUserFemale.Checked = false; 
            }
            else
            {
                // this.rdbUserMale.Checked = false; 
                this.rdbUserFemale.Checked = true;
            }

        }

        //Update code for Users
        private void btnUpdateUserInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }
                if (string.IsNullOrEmpty(this.txtUserID.Text))
                {
                    MessageBox.Show("Please select a user to update", "Update Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                var query = "select * from UserInfoDB where UserID ='" + this.txtUserID.Text + "';";
                var dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {
                    string gender = "";
                    if (rdbUserMale.Checked)
                    {
                        gender = "Male";
                    }
                    else if (rdbUserFemale.Checked)
                    {
                        gender = "Female";
                    }

                    string formattedDate = dtp.Value.ToShortDateString();
                    string Update_query = @"update UserInfoDB set 
                                    FullName = '" + this.txtUserName.Text + @"',
                                    Role = '" + this.cmbUserRoles.Text + @"',
                                    Phone = '" + this.txtUserContact.Text + @"',
                                    Password = '" + this.txtUserPass.Text + @"',
                                    CreatedDate = '" + formattedDate + @"',
                                    Email = '" + this.txtUserEmail.Text + @"',
                                    Gender = '" + gender + @"'
                                    where UserID = '" + txtUserID.Text + "';";

                    var count = this.Da.ExecuteDMLQuery(Update_query);
                    if (count == 1)
                        MessageBox.Show("User data has been updated", "Update Complete",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("User data hasn't been updated", "Update Incomplete",
                                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("User not found with ID: " + txtUserID.Text,
                                  "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                
                MessageBox.Show("An ERROR has Occurred. Please Try it Again!" + exc.Message);
            }
        }

        //Deletion code for User
        private void btnDeleteUserInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }
                var userName = this.dgvUserList.CurrentRow.Cells["FullName"].Value.ToString();
                var userID = this.dgvUserList.CurrentRow.Cells["UserID"].Value.ToString();

              
                string checkQuery = $"SELECT Role FROM UserInfoDB WHERE UserID = {userID}";
                DataTable dt = Da.ExecuteQueryTable(checkQuery);

                if (dt.Rows.Count > 0 && dt.Rows[0]["Role"].ToString() == "Admin")
                {
                    
                    MessageBox.Show("Cannot delete admin account!", "Restricted",
                                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

               
                DialogResult res = MessageBox.Show("Are you sure to remove " + userName + "?",
                                                 "Warning",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                    return;

                string Delete_query = "delete from UserInfoDB where UserID ='" + userID + "'";
                var count = this.Da.ExecuteDMLQuery(Delete_query);


                if (count == 1)
                    MessageBox.Show(userName.ToUpper() + " has been removed from the list",
                                  "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("User hasn't been deleted",
                                  "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An ERROR has Occurred. Please Try it Again!" + exc.Message);
            }
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

        private void txtUserEmail_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserEmail.Text) && !txtUserEmail.Text.Contains("@"))
            {
                MessageBox.Show("Email must contain @ symbol");
                txtUserEmail.Clear();
            }

        }

        private void txtUserContact_TextChanged(object sender, EventArgs e)
        {
           

            // Max 11 digits
            if (txtUserContact.Text.Length > 11)
            {
                txtUserContact.Text = txtUserContact.Text.Substring(0, 11);
                MessageBox.Show("Maximum 11 digits");
            }

        }
    }
}
