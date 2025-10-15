namespace UserManagement
{
    partial class HomeScreen
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
            this.lblHomeMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHomeMessage
            // 
            this.lblHomeMessage.AutoSize = true;
            this.lblHomeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeMessage.Location = new System.Drawing.Point(259, 176);
            this.lblHomeMessage.Name = "lblHomeMessage";
            this.lblHomeMessage.Size = new System.Drawing.Size(316, 25);
            this.lblHomeMessage.TabIndex = 0;
            this.lblHomeMessage.Text = "Welcome To User Management";
            this.lblHomeMessage.Click += new System.EventHandler(this.lblHomeMessage_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHomeMessage);
            this.Name = "HomeScreen";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHomeMessage;
    }
}

