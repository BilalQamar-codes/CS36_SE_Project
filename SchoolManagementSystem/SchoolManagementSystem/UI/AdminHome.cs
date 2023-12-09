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
    }
}
