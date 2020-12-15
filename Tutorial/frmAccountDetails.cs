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
    public partial class frmAccountDetails : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;integrated security=true;database=Tutorial");
        SqlDataReader dr;

        void clear()
        {
            txtBankAccountNumber.Text = "";
            txtBankCity.Text = "";
        }

        public frmAccountDetails()
        {
            InitializeComponent();
            con.Open();
            fetchBranchDetails();
        }

        private void txtBankAccountNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBankAccountNumber.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Company Name!", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBankAccountNumber.Focus();
                }
                else
                {
                    txtBankCity.Focus();
                }
            }
        }

        private void txtBankCity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBankCity.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Company Name!", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBankCity.Focus();
                }
                else
                {
                    txtBankCity.Focus();
                }
            }
        }

     void fetchBranchDetails()
        {
        SqlCommand cmd = new SqlCommand("Pro_FetchBranchInfo", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbBranchName.Items.Add(dr[0]);

            }
            
            dr.Close();
        }

        string BranchID;

        private void cmbBranchName_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlCommand cmd1 = new SqlCommand("select BranchIFSC,BranchAddress from BranchDetails where BranchName='" + cmbBranchName.Text + "'", con);
            SqlDataReader dr1;
            dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                txtIFSC.Text = dr1[0].ToString();
                txtBankAddress.Text = dr1[1].ToString();
            }
            dr1.Close();

            
            SqlCommand cmd = new SqlCommand("Pro_BranchFetchID", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;

                p1 = new SqlParameter("@BranchName", SqlDbType.VarChar);
                p1.Value = cmbBranchName.Text;
                cmd.Parameters.Add(p1);

                SqlDataReader dr;

                dr = cmd.ExecuteReader();


                if (dr.Read())
                {
                    BranchID = dr[0].ToString();

                }
                dr.Close();
                
               

        }

        private void btnTransact_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulations", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
