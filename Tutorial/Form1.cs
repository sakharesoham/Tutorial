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
    public partial class frmDisplay : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;integrated security=true;database=Tutorial");
        SqlDataReader dr;

        public frmDisplay()
        {
            InitializeComponent();
            con.Open();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUsername.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Username", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsername.Focus();
                }
                else
                {
                    txtPassword.Focus();
                }
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPassword.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Password", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Focus();
                }
                else
                {
                    btnLogin.Focus();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            frmRegistration obj = new frmRegistration();
            obj.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("select * from Registration where Username='" + txtUsername.Text + "' and Passwords='" + txtPassword.Text + "'", con);

            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtUsername.Text = dr[0].ToString();
                txtPassword.Text = dr[1].ToString();
            }
            dr.Close();
            frmMain obj = new frmMain();
            obj.Show();
        }
    }
}
