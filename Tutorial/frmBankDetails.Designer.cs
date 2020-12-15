namespace Tutorial
{
    partial class frmBankDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBranch = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtIFSC = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtBranch = new System.Windows.Forms.TextBox();
            this.btnBranchSave = new System.Windows.Forms.Button();
            this.btnBranchExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Location = new System.Drawing.Point(250, 141);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(57, 19);
            this.lblBranch.TabIndex = 0;
            this.lblBranch.Text = "Branch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "IFSC ";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(250, 339);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(64, 19);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address";
            // 
            // txtIFSC
            // 
            this.txtIFSC.Location = new System.Drawing.Point(441, 249);
            this.txtIFSC.Name = "txtIFSC";
            this.txtIFSC.Size = new System.Drawing.Size(100, 26);
            this.txtIFSC.TabIndex = 4;
            this.txtIFSC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIFSC_KeyDown);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(441, 332);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 26);
            this.txtAddress.TabIndex = 5;
            this.txtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddress_KeyDown);
            // 
            // txtBranch
            // 
            this.txtBranch.Location = new System.Drawing.Point(441, 134);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Size = new System.Drawing.Size(100, 26);
            this.txtBranch.TabIndex = 6;
            this.txtBranch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBranch_KeyDown);
            // 
            // btnBranchSave
            // 
            this.btnBranchSave.Location = new System.Drawing.Point(254, 436);
            this.btnBranchSave.Name = "btnBranchSave";
            this.btnBranchSave.Size = new System.Drawing.Size(75, 23);
            this.btnBranchSave.TabIndex = 7;
            this.btnBranchSave.Text = "Save";
            this.btnBranchSave.UseVisualStyleBackColor = true;
            this.btnBranchSave.Click += new System.EventHandler(this.btnBranchSave_Click);
            // 
            // btnBranchExit
            // 
            this.btnBranchExit.Location = new System.Drawing.Point(466, 436);
            this.btnBranchExit.Name = "btnBranchExit";
            this.btnBranchExit.Size = new System.Drawing.Size(75, 23);
            this.btnBranchExit.TabIndex = 8;
            this.btnBranchExit.Text = "Exit";
            this.btnBranchExit.UseVisualStyleBackColor = true;
            this.btnBranchExit.Click += new System.EventHandler(this.btnBranchExit_Click);
            // 
            // frmBankDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnBranchExit);
            this.Controls.Add(this.btnBranchSave);
            this.Controls.Add(this.txtBranch);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtIFSC);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBranch);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBankDetails";
            this.Text = "frmBankDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtIFSC;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtBranch;
        private System.Windows.Forms.Button btnBranchSave;
        private System.Windows.Forms.Button btnBranchExit;
    }
}