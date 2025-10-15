using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement
{
    public class UserDataClass
    {
        public string email;
        public string password;
        public string username;
        public int userId;
    }

    public class EmployeeInfo
    { 
        public int EmployeeInfoId { get; set; }
        public int EmployeeId { get; set; }
        public string FatherName { get; set; }
        public DateTime DoB { get; set; }
        public bool Gender { get; set; }
        public double Salary { get; set; }
        public string EmployeeStatus { get; set; }
        public string Department { get; set; }
    }
    public static class UsersData
    {
        public static List<UserDataClass> users = new List<UserDataClass>();
        public static UserDataClass currentUser = new UserDataClass();

    }
}
