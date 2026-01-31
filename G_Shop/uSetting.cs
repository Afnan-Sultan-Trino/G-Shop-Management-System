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
    public partial class uSetting : UserControl
    {
        private DataAccess Da { get; set; }
        public uSetting()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.LoadAdminData();
        }

        //Reset code 
        private void btnResetEdit_Click(object sender, EventArgs e)
        {
            this.ClearAll();
            this.LoadAdminData();
        }

        //Load all the info of admin
        private void LoadAdminData()
        {
            try
            {
                string query = "SELECT * FROM UserInfoDB WHERE UserID = 1";
                var dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count > 0)
                {
                    var row = dt.Rows[0];

                    
                    this.txtSettingFullName.Text = row["FullName"].ToString();
                    this.txtSettingEmailName.Text = row["Email"].ToString();
                    this.txtSettingPhn.Text = row["Phone"].ToString();

                   
                    string gender = row["Gender"].ToString();
                    if (gender == "Male")
                        this.rdbMale.Checked = true;
                    else if (gender == "Female")
                        this.rdbFemale.Checked = true;

                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
        private void ClearAll()
        {
            this.txtSettingFullName.Text = "";
            this.txtSettingEmailName.Text = "";
            this.txtSettingPhn.Text = "";
            this.rdbFemale.Checked = false;
            this.rdbMale.Checked = false;
            this.txtSettingNewPass.Text = "";
        }

        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtSettingFullName.Text) || string.IsNullOrEmpty(this.txtSettingEmailName.Text) ||
                 string.IsNullOrEmpty(this.txtSettingPhn.Text) || string.IsNullOrEmpty(this.txtSettingNewPass.Text))
               
            {
                return false;
            }
            if (!rdbMale.Checked && !rdbFemale.Checked)
            {
                return false;
            }

            return true;
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }
                

                string gender = "";
                if (rdbMale.Checked)
                {
                    gender = "Male";
                }
                else if (rdbFemale.Checked)
                {
                    gender = "Female";
                }
                else
                {
                    MessageBox.Show("Please select gender");
                    return;
                }
                string query = @"UPDATE UserInfoDB SET 
                    FullName = '" + this.txtSettingFullName.Text + @"',
                    Email = '" + this.txtSettingEmailName.Text + @"',
                    Password = '" + this.txtSettingNewPass.Text + @"',
                    Phone = '" + this.txtSettingPhn.Text + @"',
                    Gender = '" + gender + @"'
                WHERE UserID = 1 AND Role = 'Admin';";
                
                int result = this.Da.ExecuteDMLQuery(query);
                if (result == 1)
                {
                    MessageBox.Show("Profile Updated Successfully!");
                }
                else
                {
                    MessageBox.Show("Update Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }
    }
}
