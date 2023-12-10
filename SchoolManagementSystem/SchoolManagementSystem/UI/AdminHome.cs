/*
    AdminHome UI form manages the administrative dashboard and displays various data grids.
    It handles the display and management of teachers, students, classes, courses, and users.
    Implements data binding for grids and styling configurations for visual elements.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using MaterialSkin;
using MaterialSkin.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagementSystem.DL;
using System.Data.SqlClient;
using System.Data.Common;

namespace SchoolManagementSystem.UI
{
    public partial class AdminHome : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager = null;
        public AdminHome()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
          
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            stylingDatagridviews();
            bindTeachersData();
            bindStudentsData();
            bindUsersData();
            bindCoursesData();
            bindClassesData();
            loadDashboardValues();
        }
        public void stylingDatagridviews()
        {
            TeachersGV.BorderStyle = BorderStyle.None;
            TeachersGV.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            TeachersGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            TeachersGV.DefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 150, 243);
            TeachersGV.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            TeachersGV.BackgroundColor = Color.White;

            TeachersGV.EnableHeadersVisualStyles = false;
            TeachersGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            TeachersGV.ColumnHeadersDefaultCellStyle.BackColor = Color.DeepSkyBlue;
            TeachersGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;



            UsersGV.BorderStyle = BorderStyle.None;
            UsersGV.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            UsersGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            UsersGV.DefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 150, 243);
            UsersGV.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            UsersGV.BackgroundColor = Color.White;

            UsersGV.EnableHeadersVisualStyles = false;
            UsersGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            UsersGV.ColumnHeadersDefaultCellStyle.BackColor = Color.DeepSkyBlue;
            UsersGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;




            StudentsGV.BorderStyle = BorderStyle.None;
            StudentsGV.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            StudentsGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            StudentsGV.DefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 150, 243);
            StudentsGV.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            StudentsGV.BackgroundColor = Color.White;

            StudentsGV.EnableHeadersVisualStyles = false;
            StudentsGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            StudentsGV.ColumnHeadersDefaultCellStyle.BackColor = Color.DeepSkyBlue;
            StudentsGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            CoursesGV.BorderStyle = BorderStyle.None;
            CoursesGV.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            CoursesGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            CoursesGV.DefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 150, 243);
            CoursesGV.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            CoursesGV.BackgroundColor = Color.White;

            CoursesGV.EnableHeadersVisualStyles = false;
            CoursesGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            CoursesGV.ColumnHeadersDefaultCellStyle.BackColor = Color.DeepSkyBlue;
            StudentsGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            ClassesGV.BorderStyle = BorderStyle.None;
            ClassesGV.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            ClassesGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ClassesGV.DefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 150, 243);
            ClassesGV.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            ClassesGV.BackgroundColor = Color.White;

            ClassesGV.EnableHeadersVisualStyles = false;
            ClassesGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ClassesGV.ColumnHeadersDefaultCellStyle.BackColor = Color.DeepSkyBlue;
            ClassesGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            AddNewTeacher ant = new AddNewTeacher();
            ant.ShowDialog();
            bindTeachersData();

        }
        public void bindStudentsData()
        {          
            StudentsGV.DataSource = StudentDL.getAllStudents();
            StudentsGV.Columns["student_id"].Visible = false;

        }
        public void bindClassesData()
        {
            ClassesGV.DataSource = ClassDL.getAllClasses();
            ClassesGV.Columns["class_id"].Visible = false;

        }
        public void bindTeachersData()
        {
            TeachersGV.DataSource = TeacherDL.getAllTeachers();
            TeachersGV.Columns["user_id"].Visible = false;
            TeachersGV.Columns["teacher_id"].Visible = false;
            TeachersGV.Columns["first_name"].HeaderText = "First Name";
            TeachersGV.Columns["last_name"].HeaderText = "Last Name";
           
        }
        public void bindCoursesData()
        {
            CoursesGV.DataSource = CoursesDL.getAllCourses();
            //CoursesGV.Columns["course_id"].Visible = false;
            
            
        }
        public void bindUsersData()
        {          
            UsersGV.DataSource = UserDL.getAllUserss();
            UsersGV.Columns["user_id"].Visible = false;
           
        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            AddNewStudent ans = new AddNewStudent();
            ans.ShowDialog();
            bindStudentsData();
         
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            AddNewCourse anc = new AddNewCourse();
            anc.ShowDialog();
            bindCoursesData();
        }

        private void materialTabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            loadDashboardValues();
        }
        public void loadDashboardValues()
        {
            lblTeachers.Text = TeacherDL.getTotalTeachers().ToString();
            lblStudents.Text = StudentDL.getTotalStudents().ToString();
            lblClasses.Text = CoursesDL.getTotalCourses().ToString();
        }

        private void btnAddNewClass_Click(object sender, EventArgs e)
        {
            AddNewClass anc = new AddNewClass();
            anc.ShowDialog();
            bindClassesData();

        }
    }
}
