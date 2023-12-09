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
            string fName = txtFName.Text;
            string LName = txtLName.Text;
            DateTime dob = dtDOB.Value.Date;
            string address = txtAddress.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string Gender = cmbGender.Text;
            string email = txtEmail.Text;
            string qualification = txtQualification.Text;
            string password = txtPassword.Text;

            if (fName == "" || address == "" || phoneNumber == "" || email == "" || qualification == "" || password == "")
            {
                MessageBox.Show("Kindly Fill All the Fields ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Create a new Client object.
            

            // Add the Client object to the list of clients.
            if (ClientDL.addClientToList(client) && AccountDL.addAccountToList(new Account(client.UniqueId, client.Name, type)))
            {

                MessageBox.Show("Client Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else
            {
                MessageBox.Show("Client Not Added!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
