using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistration obj = new frmRegistration();
            obj.Show();
        }

        private void accountDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccountDetails obj = new frmAccountDetails();
            obj.Show();
        }
    }
}
