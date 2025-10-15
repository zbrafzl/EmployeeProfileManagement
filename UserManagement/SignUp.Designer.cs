namespace UserManagement
{
    partial class SignUp
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblEmailTooltip = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(376, 53);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(91, 25);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Sign UP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(280, 117);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(402, 22);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(280, 182);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(402, 22);
            this.txtUserName.TabIndex = 4;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(280, 241);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(402, 22);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(280, 302);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(402, 22);
            this.txtConfirmPassword.TabIndex = 8;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirm Password";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Location = new System.Drawing.Point(381, 362);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 33);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Sign Up";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblEmailTooltip
            // 
            this.lblEmailTooltip.AutoSize = true;
            this.lblEmailTooltip.ForeColor = System.Drawing.Color.Red;
            this.lblEmailTooltip.Location = new System.Drawing.Point(280, 146);
            this.lblEmailTooltip.Name = "lblEmailTooltip";
            this.lblEmailTooltip.Size = new System.Drawing.Size(0, 16);
            this.lblEmailTooltip.TabIndex = 10;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(693, 22);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(75, 33);
            this.btnSignIn.TabIndex = 11;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.lblEmailTooltip);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMessage);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblEmailTooltip;
        private System.Windows.Forms.Button btnSignIn;
    }
}