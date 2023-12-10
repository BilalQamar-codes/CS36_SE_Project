/*
    AddNewStudent UI form allows the addition of new student records.
    It captures student details such as name, date of birth, gender, contact information, and address.
    Handles user input validation and database interactions for adding new students.
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
    public partial class AddNewStudent : MaterialForm
    {
        public AddNewStudent()
        {
            InitializeComponent();
        }

        private void AddNewStudent_Load(object sender, EventArgs e)
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

                if (string.IsNullOrEmpty(fName) || string.IsNullOrEmpty(address) ||
                    string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Kindly Fill All the Fields ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Student newStudent = new Student(fName, lName, dob, gender, address, phoneNumber, email, DateTime.Now, DateTime.Now, true);
                if (StudentDL.AddStudentIntoDatabase(newStudent))
                {                   
                    // Display success message
                    MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error adding Student. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogsDL.LogException(ex);
            }
        }
    }
}
