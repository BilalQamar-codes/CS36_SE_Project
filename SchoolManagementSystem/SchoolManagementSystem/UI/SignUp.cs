using SchoolManagementSystem.BL;
using SchoolManagementSystem.DL;
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
            try
            {
                string name = txtFullName.Text;
                string email = txtEmail.Text;
                string password = txtPassword.Text;
                string role = "Admin";
                if (name == "" || password == "" || email == "")
                {
                    MessageBox.Show("Kindly Fill All the Fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DateTime dt = DateTime.Now;
                User user = new User(name, email, password, role, dt, dt, true);
                UserDL.addUserIntoDatabase(user);
                MessageBox.Show("Successfully Created Account", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearControls();
                
            }
            catch (Exception ex) 
            {
                LogsDL.LogException(ex);
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void clearControls()
        {
            txtFullName.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
        }
    }
}
