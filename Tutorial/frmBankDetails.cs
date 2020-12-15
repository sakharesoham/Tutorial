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
    public partial class frmBankDetails : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;integrated security=true;database=Tutorial");

        void clear()
        {
            txtBranch.Text = "";
            txtIFSC.Text = "";
            txtAddress.Text = "";
        }


        public frmBankDetails()
        {
            InitializeComponent();
            con.Open();
        }

        private void txtBranch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBranch.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Company Name!", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBranch.Focus();
                }
                else
                {
                    txtIFSC.Focus();
                }
            }
        }

        private void txtIFSC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtIFSC.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Company Name!", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIFSC.Focus();
                }
                else
                {
                    txtAddress.Focus();
                }
            }
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtAddress.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Company Name!", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAddress.Focus();
                }
                else
                {
                    btnBranchSave.Focus();
                }
            }
        }

        private void btnBranchSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Pro_BranchInsert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;

                p1 = new SqlParameter("@BranchName", SqlDbType.VarChar);
                p1.Value = txtBranch.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@BranchIFSC", SqlDbType.VarChar);
                p1.Value = txtIFSC.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@BranchAddress", SqlDbType.VarChar);
                p1.Value = txtAddress.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@BranchTransactionId", SqlDbType.BigInt);
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
                   clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Branch Save Button!!" + ex, "System Says", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBranchExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
