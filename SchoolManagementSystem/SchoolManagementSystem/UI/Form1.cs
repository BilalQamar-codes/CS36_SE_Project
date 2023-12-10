// SchoolManagementSystem - SignUpForm.cs
// This file contains the implementation of the SignUpForm class,
// which represents the user interface for signing up or logging into
// the school management system. It utilizes MaterialSkin for its UI elements.
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


namespace SchoolManagementSystem
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucSignUp1.BringToFront();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void changePage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(changePage.Text == "Sign-Up Here")
            {
                signUp1.BringToFront();
                changePage.Text = "Login-Here";
                label3.Text = "Aready Have an Account?";
                
            }
            else if(changePage.Text == "Login-Here")
            {
                ucSignUp1.BringToFront();
                changePage.Text = "Sign-Up Here";
                label3.Text = "Don't Have an Account?";
                
            }
        }
    }
}
