/*
    AddNewCourse UI form facilitates the addition of new courses.
    It allows users to input course details and assigns teachers and classes to the courses.
    Handles database interactions for adding new courses and populating teacher and class dropdowns.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using SchoolManagementSystem.DL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Xml.Linq;
using SchoolManagementSystem.BL;

namespace SchoolManagementSystem.UI
{
    public partial class AddNewCourse : MaterialForm
    {
        public AddNewCourse()
        {
            InitializeComponent();
        }

        private void AddNewCourse_Load(object sender, EventArgs e)
        {
            loadTeachers();
            loadClasses();
        }
        public void loadTeachers()
        {
            string ConnectionStr = DBConnection.ConnectionStr;
            using (SqlConnection connection = new SqlConnection(ConnectionStr))
            {
                // Create the SQL command to select necessary data
                string sql = "SELECT teacher_id ,first_name + ' ' + last_name AS Name FROM teachers;";
                try
                {
                    
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbTeacher.DataSource = dt;
                    cmbTeacher.DisplayMember = "Name";
                    cmbTeacher.ValueMember = "teacher_id";

                }
                catch (Exception z)
                {
                    MessageBox.Show(z.Message);
                }
            }
            

        }
        public void loadClasses()
        {
            string ConnectionStr = DBConnection.ConnectionStr;
            using (SqlConnection connection = new SqlConnection(ConnectionStr))
            {
                // Create the SQL command to select necessary data
                string sql = "SELECT class_id , name AS Name FROM classes;";
                try
                {

                    SqlCommand cmd = new SqlCommand(sql, connection);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbClass.DataSource = dt;
                    cmbClass.DisplayMember = "Name";
                    cmbClass.ValueMember = "class_id";

                }
                catch (Exception z)
                {
                    MessageBox.Show(z.Message);
                }
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(cmbClass.SelectedIndex != -1)
                {
                    string CourseName = txtCourseName.Text;
                    string CourseDescription = txtCourseDescription.Text;                
                    int TeacherId = (int)cmbTeacher.SelectedValue;
                    int classId = (int)cmbClass.SelectedValue;
                    if (string.IsNullOrEmpty(CourseName) || string.IsNullOrEmpty(CourseDescription) ||
                        TeacherId == 0 || cmbClass.SelectedIndex == -1 || classId == 0)
                    {
                        MessageBox.Show("Kindly Fill All the Fields ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Course newCourse = new Course(CourseName, CourseDescription,TeacherId, classId,DateTime.Now, DateTime.Now,true);

                    if(CoursesDL.AddCourseIntoDatabase(newCourse))
                    {
                        MessageBox.Show("Course added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Kindly Add Classes Before! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch(Exception ex) 
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogsDL.LogException(ex);
            }
        }

        private void txtCourseName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCourseDescription_Click(object sender, EventArgs e)
        {

        }
    }
}
