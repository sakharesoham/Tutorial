using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Tutorial
{
    public partial class frmRegistration : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;integrated security=true;database=Tutorial");
        SqlDataReader dr;

        void enabletrue()
        {
                txtFirstName.Enabled = true;
                txtLastName.Enabled=true;
                txtAge.Enabled=true;
                txtChooseUserName.Enabled=true;
                txtChoosePassword.Enabled = true;
        }

        void enablefalse()
        {
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtAge.Enabled = false;
            txtChooseUserName.Enabled = false;
            txtChoosePassword.Enabled = false;
        }

        void clear()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAge.Text = "";
            txtChooseUserName.Text = "";
            txtChoosePassword.Text = "";
        }

        public frmRegistration()
        {
            InitializeComponent();
            con.Open();
            fillData();
            enablefalse();
        }

        private void txtFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtFirstName.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Username", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFirstName.Focus();
                }
                else
                {
                    txtLastName.Focus();
                }
            }
        }

        private void txtLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtLastName.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Username", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLastName.Focus();
                }
                else
                {
                    txtAge.Focus();
                }
            }
        }

        private void txtAge_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtAge.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Username", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAge.Focus();
                }
                else
                {
                    txtChooseUserName.Focus();
                }
            }
        }

        private void txtChooseUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtChooseUserName.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Username", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtChooseUserName.Focus();
                }
                else
                {
                    txtChoosePassword.Focus();
                }
            }
        }

        private void txtChoosePassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtChoosePassword.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Username", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtChoosePassword.Focus();
                }
                else
                {
                    btnLogin.Focus();
                }
            }
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
        
            frmDisplay obj = new frmDisplay();
            obj.Show();
        }

        int i;
        void fillData()
        {
            try
            {
                dgvDetails.Rows.Clear();
                SqlCommand cmd = new SqlCommand("select * from Registration", con);


                dr = cmd.ExecuteReader();
                i = 0;
                while (dr.Read())
                {
                    dgvDetails.Rows.Add();
                    dgvDetails.Rows[i].Cells[0].Value = dr[0];
                    dgvDetails.Rows[i].Cells[1].Value = dr[1];
                    dgvDetails.Rows[i].Cells[2].Value = dr[2];
                    dgvDetails.Rows[i].Cells[3].Value = dr[3];
                    dgvDetails.Rows[i].Cells[4].Value = dr[4];
                    dgvDetails.Rows[i].Cells[5].Value = dr[5];
                    dgvDetails.Rows[i].Cells[6].Value = dr[6];

                    i++;
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in filldata" + ex, "System Says", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string gender;
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbtnMale.Checked)
                    gender = "Male";
                else if (rbtnFemale.Checked)
                    gender = "Female";


                SqlCommand cmd = new SqlCommand("Pro_Registration", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;

                p1 = new SqlParameter("@FirstName", SqlDbType.VarChar);
                p1.Value = txtFirstName.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@LastName", SqlDbType.VarChar);
                p1.Value = txtLastName.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@Gender", SqlDbType.VarChar);
                p1.Value = gender;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@Age", SqlDbType.VarChar);
                p1.Value = txtAge.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@Username", SqlDbType.VarChar);
                p1.Value = txtChooseUserName.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@Passwords", SqlDbType.VarChar);
                p1.Value = txtChoosePassword.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@RegTransactionID", SqlDbType.Int);
                p1.Value = "1";
                cmd.Parameters.Add(p1);

                int n = cmd.ExecuteNonQuery();
                if (n < 0)
                {
                    MessageBox.Show("Data Not Saved!!", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data Saved!!", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillData();
                    clear();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Save Button" + ex, "System Says", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string GridID;
        private void dgvDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GridID = dgvDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtFirstName.Text = dgvDetails.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtLastName.Text = dgvDetails.Rows[e.RowIndex].Cells[2].Value.ToString();

            if (this.dgvDetails.Rows[e.RowIndex].Cells[3].Value.Equals("Male"))
                rbtnMale.Checked = true;
            else
                rbtnMale.Checked = false;

            if (this.dgvDetails.Rows[e.RowIndex].Cells[3].Value.Equals("Female"))
                rbtnFemale.Checked = true;
            else
                rbtnFemale.Checked = false;

            txtAge.Text = dgvDetails.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtChooseUserName.Text = dgvDetails.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtChoosePassword.Text = dgvDetails.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        bool valid()
        {

            if (txtFirstName.Text.Trim() == "")
            {
                MessageBox.Show("Enter your Firstname", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFirstName.Focus();
                return false;
            }
            else if (txtLastName.Text.Trim() == "")
            {
                MessageBox.Show("Enter your LastName", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLastName.Focus();
                return false;
            }
            else if (txtAge.Text.Trim() == "")
            {
                MessageBox.Show("Enter your Username", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAge.Focus();
            }
            else if (txtChooseUserName.Text.Trim() == "")
            {
                MessageBox.Show("Enter your Username", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtChooseUserName.Focus();
            }
            else if (txtChoosePassword.Text.Trim() == "")
            {
                MessageBox.Show("Enter your Username", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtChoosePassword.Focus();
            }
            {
                return true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbtnMale.Checked)
                    gender = "Male";
                else if (rbtnFemale.Checked)
                    gender = "Female";


                SqlCommand cmd = new SqlCommand("Pro_Registration", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;

                p1 = new SqlParameter("@FirstName", SqlDbType.VarChar);
                p1.Value = txtFirstName.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@LastName", SqlDbType.VarChar);
                p1.Value = txtLastName.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@Gender", SqlDbType.VarChar);
                p1.Value = gender;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@Age", SqlDbType.VarChar);
                p1.Value = txtAge.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@Username", SqlDbType.VarChar);
                p1.Value = txtChooseUserName.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@Passwords", SqlDbType.VarChar);
                p1.Value = txtChoosePassword.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@RegTransactionID", SqlDbType.Int);
                p1.Value = "2";
                cmd.Parameters.Add(p1);

                int n = cmd.ExecuteNonQuery();
                if (n < 0)
                {
                    MessageBox.Show("Data Not Saved!!", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data Saved!!", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillData();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Save Button" + ex, "System Says", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            enabletrue();
        }

        private void btnRegExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
