/*
    AddNewTeacher UI form facilitates the addition of new teachers.
    It captures teacher details such as name, date of birth, gender, contact information, and qualifications.
    Handles user input validation and database interactions for adding new teachers and users.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using SchoolManagementSystem.BL;
using SchoolManagementSystem.DL;

namespace SchoolManagementSystem.UI
{
    public partial class AddNewTeacher : MaterialForm
    {
        public AddNewTeacher()
        {
            InitializeComponent();
        }

        private void AddNewTeacher_Load(object sender, EventArgs e)
        {
            cmbGender.SelectedIndex = 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {


                string fName = txtFName.Text;
                string lName = txtLName.Text;
                DateTime dob = dtDOB.Value.Date;
                string address = txtAddress.Text;
                string phoneNumber = txtPhoneNumber.Text;
                string gender = cmbGender.Text;
                string email = txtEmail.Text;
                string qualification = txtQualification.Text;
                string password = txtPassword.Text;

                if (string.IsNullOrEmpty(fName) || string.IsNullOrEmpty(address) ||
                    string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(email) ||
                    string.IsNullOrEmpty(qualification) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Kindly Fill All the Fields ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create a new User object
                User user = new User(fName + " "+ lName, email, password, "Teacher", DateTime.Now, DateTime.Now, true);

                // Add the user to the database
                int userId = UserDL.addUserIntoDatabase(user);
                
            // Check if adding the user was successful
                if (userId > 0)
                {
                    // Create a new Teacher object with the user ID
                    Teacher teacher = new Teacher(userId, fName, lName, dob, gender, address, phoneNumber, email, qualification, DateTime.Now, DateTime.Now, true);

                    // Add the teacher to the database
                    TeacherDL.addTeacherIntoDatabase(teacher);

                    // Display success message
                    MessageBox.Show("Teacher added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error adding user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
