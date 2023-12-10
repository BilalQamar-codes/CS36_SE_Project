using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagementSystem.BL;
using SchoolManagementSystem.DL;

namespace SchoolManagementSystem.UI
{
    public partial class AddNewClass : MaterialForm
    {
        public AddNewClass()
        {
            InitializeComponent();
        }

        private void AddNewClass_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string ClassName = txtClassName.Text;
                string ClassLevel = txtClassLevel.Text;
               
                if (string.IsNullOrEmpty(ClassName) || string.IsNullOrEmpty(ClassLevel) )
                {
                    MessageBox.Show("Kindly Fill All the Fields ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Class newClass = new Class(ClassName, ClassLevel, DateTime.Now, DateTime.Now, true);

                if (ClassDL.AddClassIntoDatabase(newClass))
                {
                    MessageBox.Show("Class added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
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
