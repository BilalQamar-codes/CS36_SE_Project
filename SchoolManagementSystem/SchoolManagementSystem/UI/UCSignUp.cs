using SchoolManagementSystem.BL;
using SchoolManagementSystem.DL;
using SchoolManagementSystem.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class UCSignUp : UserControl
    {
        public UCSignUp()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                
                string email = txtEmail.Text;
                string password = txtPassword.Text;
                
                if (password == "" || email == "")
                {
                    MessageBox.Show("Kindly Fill All the Fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else 
                {
                    User loggedInUser = UserDL.LoginUser(email, password);
                    if(loggedInUser != null)
                    {
                        MessageBox.Show("Login Successfull as " + loggedInUser.Role, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if(loggedInUser.Role == "Admin")
                        {
                            AdminHome admin = new AdminHome();
                            admin.ShowDialog();
                        }
                        else if(loggedInUser.Role == "Teacher")
                        {
                            TeacherHome teacher = new TeacherHome();
                            teacher.ShowDialog();
                        }
                    }
                    
                    
                }
            }
            catch (Exception ex) 
            {
                LogsDL.LogException(ex);
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
