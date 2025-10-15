using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManagement
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void lblHomeMessage_Click(object sender, EventArgs e)
        {
            lblHomeMessage.Text = "Going To Sign Up";
            Thread.Sleep(500);
            SignUp signUp = new SignUp();
            this.Hide();
            signUp.Show();
        }
    }
}
