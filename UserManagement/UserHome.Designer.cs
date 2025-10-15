namespace UserManagement
{
    partial class UserHome
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
            this.lblUserHomeMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDoB = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbPermanent = new System.Windows.Forms.CheckBox();
            this.cbContractual = new System.Windows.Forms.CheckBox();
            this.cbVisiting = new System.Windows.Forms.CheckBox();
            this.cbDailyWager = new System.Windows.Forms.CheckBox();
            this.btnSubmitInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUserHomeMessage
            // 
            this.lblUserHomeMessage.AutoSize = true;
            this.lblUserHomeMessage.Cursor = System.Windows.Forms.Cursors.No;
            this.lblUserHomeMessage.Location = new System.Drawing.Point(389, 27);
            this.lblUserHomeMessage.Name = "lblUserHomeMessage";
            this.lblUserHomeMessage.Size = new System.Drawing.Size(0, 16);
            this.lblUserHomeMessage.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Father Name";
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(203, 112);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(166, 22);
            this.txtFatherName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date of Birth";
            // 
            // dtpDoB
            // 
            this.dtpDoB.Location = new System.Drawing.Point(202, 221);
            this.dtpDoB.MaxDate = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.dtpDoB.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtpDoB.Name = "dtpDoB";
            this.dtpDoB.Size = new System.Drawing.Size(200, 22);
            this.dtpDoB.TabIndex = 4;
            this.dtpDoB.Value = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gender";
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Checked = true;
            this.rdbMale.Location = new System.Drawing.Point(515, 112);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(58, 20);
            this.rdbMale.TabIndex = 6;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(599, 112);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(74, 20);
            this.rdbFemale.TabIndex = 7;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(558, 168);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(166, 22);
            this.txtSalary.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Department";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Items.AddRange(new object[] {
            "Computer Science",
            "Information Technology",
            "Software Engineering",
            "Artificial Intelligence",
            "Management Sciences",
            "Social Sciences"});
            this.cmbDepartment.Location = new System.Drawing.Point(558, 219);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(166, 24);
            this.cmbDepartment.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Status";
            // 
            // cbPermanent
            // 
            this.cbPermanent.AutoSize = true;
            this.cbPermanent.Location = new System.Drawing.Point(203, 304);
            this.cbPermanent.Name = "cbPermanent";
            this.cbPermanent.Size = new System.Drawing.Size(94, 20);
            this.cbPermanent.TabIndex = 13;
            this.cbPermanent.Text = "Permanent";
            this.cbPermanent.UseVisualStyleBackColor = true;
            // 
            // cbContractual
            // 
            this.cbContractual.AutoSize = true;
            this.cbContractual.Location = new System.Drawing.Point(333, 304);
            this.cbContractual.Name = "cbContractual";
            this.cbContractual.Size = new System.Drawing.Size(96, 20);
            this.cbContractual.TabIndex = 14;
            this.cbContractual.Text = "Contractual";
            this.cbContractual.UseVisualStyleBackColor = true;
            // 
            // cbVisiting
            // 
            this.cbVisiting.AutoSize = true;
            this.cbVisiting.Location = new System.Drawing.Point(461, 304);
            this.cbVisiting.Name = "cbVisiting";
            this.cbVisiting.Size = new System.Drawing.Size(72, 20);
            this.cbVisiting.TabIndex = 15;
            this.cbVisiting.Text = "Visiting";
            this.cbVisiting.UseVisualStyleBackColor = true;
            // 
            // cbDailyWager
            // 
            this.cbDailyWager.AutoSize = true;
            this.cbDailyWager.Location = new System.Drawing.Point(558, 304);
            this.cbDailyWager.Name = "cbDailyWager";
            this.cbDailyWager.Size = new System.Drawing.Size(104, 20);
            this.cbDailyWager.TabIndex = 16;
            this.cbDailyWager.Text = "Daily Wager";
            this.cbDailyWager.UseVisualStyleBackColor = true;
            // 
            // btnSubmitInfo
            // 
            this.btnSubmitInfo.Location = new System.Drawing.Point(333, 374);
            this.btnSubmitInfo.Name = "btnSubmitInfo";
            this.btnSubmitInfo.Size = new System.Drawing.Size(96, 36);
            this.btnSubmitInfo.TabIndex = 17;
            this.btnSubmitInfo.Text = "Save";
            this.btnSubmitInfo.UseVisualStyleBackColor = true;
            this.btnSubmitInfo.Click += new System.EventHandler(this.btnSubmitInfo_Click);
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmitInfo);
            this.Controls.Add(this.cbDailyWager);
            this.Controls.Add(this.cbVisiting);
            this.Controls.Add(this.cbContractual);
            this.Controls.Add(this.cbPermanent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdbFemale);
            this.Controls.Add(this.rdbMale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDoB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUserHomeMessage);
            this.Name = "UserHome";
            this.Text = "UserHome";
            this.Load += new System.EventHandler(this.UserHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserHomeMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDoB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbPermanent;
        private System.Windows.Forms.CheckBox cbContractual;
        private System.Windows.Forms.CheckBox cbVisiting;
        private System.Windows.Forms.CheckBox cbDailyWager;
        private System.Windows.Forms.Button btnSubmitInfo;
    }
}