using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManagement
{
    public partial class SignUp : Form
    {
        public static bool emailValid;
        public static bool nameValid;
        public static bool passwordMatched;
        public static bool passwordLength;


        public SignUp()
        {
            InitializeComponent();
        }
        public bool isValid()
        {
            if (emailValid && nameValid && passwordLength && passwordMatched)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            var regex = Regex.Match(txtEmail.Text, pattern);
            bool isMatched = regex.Success;
            if (isMatched)
            {
                //btnSubmit.Enabled = true;
                emailValid = true;
                lblEmailTooltip.Text = "";
                lblEmailTooltip.Visible = false;
            }
            else
            {
                //btnSubmit.Enabled = false;
                emailValid = false;

                lblEmailTooltip.Text = "E-mail format is not correct!";
                lblEmailTooltip.Visible = true;
            }
            if(isValid())
            {
                btnSubmit.Enabled = true;
            }
            else
            {
                btnSubmit.Enabled = false;
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text.Length >= 3)
            {
                nameValid = true;
            }
            else
            {
                nameValid = false;
            }
            if (isValid())
            {
                btnSubmit.Enabled = true;
            }
            else
            {
                btnSubmit.Enabled = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length >= 8)
            {
                passwordLength = true;
            }
            else
            {
                passwordLength = false;
            }
            if (isValid())
            {
                btnSubmit.Enabled = true;
            }
            else
            {
                btnSubmit.Enabled = false;
            }
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                passwordMatched = true;
            }
            else
            {
                passwordMatched = false;
            }
            if (isValid())
            {
                btnSubmit.Enabled = true;
            }
            else
            {
                btnSubmit.Enabled = false;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Data is pushed");
            //Create an object from this form data

            //check if no record exist with the same email
            //if not, Add a record in the database

            UserDataClass udc = new UserDataClass();
            udc.username = txtUserName.Text;
            udc.password = txtPassword.Text;
            udc.email = txtEmail.Text;

            //Connect two apps, c# with sql 
            //1 Connection string (data source, database, security)
            //SqlConnection

            string connectionString = "Data source = DESKTOP-U8EFEP7\\SQLEXPRESS; initial catalog = employeesManagementSystem; integrated security = true;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "select count(*) from tblUsers where emailAddress = '"+ udc.email + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            int returnResult = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            //Check if list is not empty
            if (returnResult > 0)
            {
                //Check if this email is already registered
                //if yes? prompt user
                MessageBox.Show("This email already registed!");
                //else
            }
            else
            {
                //UsersData.users.Add(udc);
                //SignIn signIn = new SignIn();
                //this.Hide();
                //signIn.Show();
                conn.Open();
                query = "insert into tblUsers (userName, password,emailAddress) values ('"+txtUserName.Text+"','"+txtPassword.Text+"','"+txtEmail.Text+"')";
                cmd = new SqlCommand(query, conn);
                returnResult = Convert.ToInt32(cmd.ExecuteNonQuery());
                conn.Close();
                SignIn signIn = new SignIn();
                this.Hide();
                signIn.Show();
            }
            ////registering the first user
            //else
            //{
            //    UsersData.users.Add(udc);
            //    SignIn signIn = new SignIn();
            //    this.Hide();
            //    signIn.Show();
            //}



        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            this.Hide();
            signIn.Show();
        }
    }
}
