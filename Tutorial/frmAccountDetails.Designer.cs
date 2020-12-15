namespace Tutorial
{
    partial class frmAccountDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBankAccountNumber = new System.Windows.Forms.TextBox();
            this.txtBankCity = new System.Windows.Forms.TextBox();
            this.txtIFSC = new System.Windows.Forms.TextBox();
            this.txtBankAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBranchName = new System.Windows.Forms.ComboBox();
            this.btnTransact = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bank A/C Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Branch City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "IFSC Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bank Address";
            // 
            // txtBankAccountNumber
            // 
            this.txtBankAccountNumber.Location = new System.Drawing.Point(278, 80);
            this.txtBankAccountNumber.Name = "txtBankAccountNumber";
            this.txtBankAccountNumber.Size = new System.Drawing.Size(121, 26);
            this.txtBankAccountNumber.TabIndex = 6;
            this.txtBankAccountNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBankAccountNumber_KeyDown);
            // 
            // txtBankCity
            // 
            this.txtBankCity.Location = new System.Drawing.Point(278, 152);
            this.txtBankCity.Name = "txtBankCity";
            this.txtBankCity.Size = new System.Drawing.Size(121, 26);
            this.txtBankCity.TabIndex = 7;
            this.txtBankCity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBankCity_KeyDown);
            // 
            // txtIFSC
            // 
            this.txtIFSC.Location = new System.Drawing.Point(278, 299);
            this.txtIFSC.Name = "txtIFSC";
            this.txtIFSC.Size = new System.Drawing.Size(121, 26);
            this.txtIFSC.TabIndex = 8;
            // 
            // txtBankAddress
            // 
            this.txtBankAddress.Location = new System.Drawing.Point(278, 369);
            this.txtBankAddress.Name = "txtBankAddress";
            this.txtBankAddress.Size = new System.Drawing.Size(121, 26);
            this.txtBankAddress.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Branch Name";
            // 
            // cmbBranchName
            // 
            this.cmbBranchName.FormattingEnabled = true;
            this.cmbBranchName.Location = new System.Drawing.Point(278, 221);
            this.cmbBranchName.Name = "cmbBranchName";
            this.cmbBranchName.Size = new System.Drawing.Size(121, 27);
            this.cmbBranchName.TabIndex = 11;
            this.cmbBranchName.SelectedIndexChanged += new System.EventHandler(this.cmbBranchName_SelectedIndexChanged);
            // 
            // btnTransact
            // 
            this.btnTransact.FlatAppearance.BorderSize = 0;
            this.btnTransact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransact.Location = new System.Drawing.Point(135, 471);
            this.btnTransact.Name = "btnTransact";
            this.btnTransact.Size = new System.Drawing.Size(75, 23);
            this.btnTransact.TabIndex = 12;
            this.btnTransact.Text = "Transact";
            this.btnTransact.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTransact.UseVisualStyleBackColor = true;
            this.btnTransact.Click += new System.EventHandler(this.btnTransact_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(278, 471);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmAccountDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTransact);
            this.Controls.Add(this.cmbBranchName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBankAddress);
            this.Controls.Add(this.txtIFSC);
            this.Controls.Add(this.txtBankCity);
            this.Controls.Add(this.txtBankAccountNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAccountDetails";
            this.Text = "frmAccountDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBankAccountNumber;
        private System.Windows.Forms.TextBox txtBankCity;
        private System.Windows.Forms.TextBox txtIFSC;
        private System.Windows.Forms.TextBox txtBankAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBranchName;
        private System.Windows.Forms.Button btnTransact;
        private System.Windows.Forms.Button btnExit;
    }
}