using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManagement
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string email;
            string password;

            email = txtEmail.Text;
            password = txtPassword.Text;

            string connectionString = "Data source = DESKTOP-U8EFEP7\\SQLEXPRESS; initial catalog = employeesManagementSystem; integrated security = true;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "select * from tblUsers where emailAddress = '" + txtEmail.Text + "' and password = '"+txtPassword.Text+"'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Sign in Successfully");
                UsersData.currentUser.userId = Convert.ToInt32(dt.Rows[0]["userId"]);
                UsersData.currentUser.username = dt.Rows[0]["userName"].ToString();
                UsersData.currentUser.email = dt.Rows[0]["emailAddress"].ToString(); ;
                UsersData.currentUser.password = dt.Rows[0]["password"].ToString();

                UserHome uh = new UserHome();
                this.Hide();
                uh.Show();
            }


            //foreach(var item in UsersData.users)
            //{
            //    if(item.email == email && item.password == password)
            //    {
            //        MessageBox.Show("Sing In Successful");
            //        UserHome uh = new UserHome();

            //        UsersData.currentUser.username = item.username;
            //        UsersData.currentUser.email = item.email;
            //        UsersData.currentUser.password = item.password;

            //        this.Hide();
            //        uh.Show();
            //    }
            //}

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            this.Hide();
            signUp.Show();
        }
    }
}
