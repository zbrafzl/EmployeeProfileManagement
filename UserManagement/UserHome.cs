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
    public partial class UserHome : Form
    {
        public UserHome()
        {
            InitializeComponent();
        }

        private void UserHome_Load(object sender, EventArgs e)
        {

            lblUserHomeMessage.Text = "Welcome! " + UsersData.currentUser.username + " To the System!";
        }

        private void btnSubmitInfo_Click(object sender, EventArgs e)
        {
            EmployeeInfo obj = new EmployeeInfo();
            obj.FatherName = txtFatherName.Text;
            if(rdbFemale.Checked == true)
            {
                obj.Gender = false;
            }
            else
            {
                obj.Gender = true;
            }
            obj.Salary = Convert.ToDouble(txtSalary.Text);
            obj.DoB = dtpDoB.Value;
            obj.Department = cmbDepartment.SelectedItem.ToString();
            obj.EmployeeStatus = "";
            if(cbPermanent.Checked == true)
            {
                obj.EmployeeStatus += cbPermanent.Text;
                obj.EmployeeStatus += ",";
            }
            if (cbContractual.Checked == true)
            {
                obj.EmployeeStatus += cbContractual.Text;
                obj.EmployeeStatus += ",";
            }
            if (cbVisiting.Checked == true)
            {
                obj.EmployeeStatus += cbVisiting.Text;
                obj.EmployeeStatus += ",";
            }
            if (cbDailyWager.Checked == true)
            {
                obj.EmployeeStatus += cbDailyWager.Text;
                obj.EmployeeStatus += ",";
            }

            string connectionString = "Data source = DESKTOP-U8EFEP7\\SQLEXPRESS; initial catalog = employeesManagementSystem; integrated security = true;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "insert into tblEmployeeInfo (employeeId,fatherName,dob,department,gender,salary,employeeStatus) ";
            query += " values (" + UsersData.currentUser.userId + ",'" + obj.FatherName + "', ";
            query += " '" + obj.DoB + "','" + obj.Department + "', " + Convert.ToInt32(obj.Gender) + ", " + obj.Salary + ", '"+obj.EmployeeStatus+"'";
            query += ")";

            SqlCommand cmd = new SqlCommand(query, conn);
            int noOfRecordsUpdated = cmd.ExecuteNonQuery();
            conn.Close();
            if (noOfRecordsUpdated > 0)
            {
                MessageBox.Show("Info Saved Successfully");

                Jobs uh = new Jobs();
                this.Hide();
                uh.Show();
            }
        }
    }
}
