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
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            AddNewTeacher ant = new AddNewTeacher();
            ant.ShowDialog();
        }
    }
}
