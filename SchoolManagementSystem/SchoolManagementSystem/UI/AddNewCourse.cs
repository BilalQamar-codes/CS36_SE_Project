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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string CourseName = txtCourseName.Text;
                string CourseDescription = txtCourseDescription.Text;
                MessageBox.Show(cmbTeacher.SelectedValue.ToString());
                int TeacherId = (int)cmbTeacher.SelectedValue;
                if (string.IsNullOrEmpty(CourseName) || string.IsNullOrEmpty(CourseDescription) ||
                    TeacherId == 0)
                {
                    MessageBox.Show("Kindly Fill All the Fields ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Course newCourse = new Course(CourseName, CourseDescription,TeacherId, DateTime.Now, DateTime.Now,true);

                if(CoursesDL.AddCourseIntoDatabase(newCourse))
                {
                    MessageBox.Show("Course added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
            catch(Exception ex) 
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogsDL.LogException(ex);
            }
        }
    }
}
