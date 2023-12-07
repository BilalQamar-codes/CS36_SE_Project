namespace SchoolManagementSystem
{
    partial class SignUp
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFullName = new MaterialSkin.Controls.MaterialTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.btnSignUp = new MaterialSkin.Controls.MaterialButton();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSignUp);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtFullName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(473, 318);
            this.panel2.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(110, 137);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(235, 50);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Text = "Email";
            this.txtEmail.TrailingIcon = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(114, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Create Account";
            // 
            // txtFullName
            // 
            this.txtFullName.AnimateReadOnly = false;
            this.txtFullName.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFullName.Depth = 0;
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFullName.LeadingIcon = null;
            this.txtFullName.Location = new System.Drawing.Point(110, 71);
            this.txtFullName.MaxLength = 50;
            this.txtFullName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFullName.Multiline = false;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(235, 50);
            this.txtFullName.TabIndex = 0;
            this.txtFullName.Text = "Full Name";
            this.txtFullName.TrailingIcon = null;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(479, 324);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.AnimateReadOnly = false;
            this.txtPassword.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.LeadingIcon = null;
            this.txtPassword.Location = new System.Drawing.Point(110, 204);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(235, 50);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "Password";
            this.txtPassword.TrailingIcon = null;
            // 
            // btnSignUp
            // 
            this.btnSignUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSignUp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSignUp.Depth = 0;
            this.btnSignUp.HighEmphasis = true;
            this.btnSignUp.Icon = null;
            this.btnSignUp.Location = new System.Drawing.Point(185, 276);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSignUp.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSignUp.Size = new System.Drawing.Size(77, 36);
            this.btnSignUp.TabIndex = 5;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSignUp.UseAccentColor = false;
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SignUp";
            this.Size = new System.Drawing.Size(479, 324);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialTextBox txtFullName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialTextBox txtPassword;
        private MaterialSkin.Controls.MaterialButton btnSignUp;
    }
}
