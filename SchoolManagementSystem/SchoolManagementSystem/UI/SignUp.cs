using SchoolManagementSystem.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchoolManagementSystem
{
    public partial class SignUp : UserControl
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string name = txtFullName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string role = "Admin";
            DateTime dt = DateTime.Now;
            User user = new User(name,email,password,role,dt,dt,true);
        }
    }
}
