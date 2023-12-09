using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MaterialSkin;
using MaterialSkin.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagementSystem.DL;
using System.Data.SqlClient;

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
            bindData();
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
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            AddNewTeacher ant = new AddNewTeacher();
            ant.ShowDialog();
            bindData();

        }
        public void bindData()
        {
            TeachersGV.DataSource = TeacherDL.getAllTeachers();
            TeachersGV.Columns["user_id"].Visible = false;
            TeachersGV.Columns["teacher_id"].Visible = false;
            TeachersGV.Columns["first_name"].HeaderText = "First Name";
            TeachersGV.Columns["last_name"].HeaderText = "Last Name";


            UsersGV.DataSource = UserDL.getAllUserss();
            UsersGV.Columns["user_id"].Visible = false;
            
            

        }
    }
}
