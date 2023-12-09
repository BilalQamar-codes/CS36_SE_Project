namespace SchoolManagementSystem.UI
{
    partial class AddNewStudent
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dtDOB = new System.Windows.Forms.DateTimePicker();
            this.txtPhoneNumber = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbGender = new MaterialSkin.Controls.MaterialComboBox();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.txtLName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtFName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtAddress = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.ForeColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Hint = "Enter Email";
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(72, 247);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(297, 50);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.Text = "";
            this.txtEmail.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(69, 168);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(90, 19);
            this.materialLabel1.TabIndex = 36;
            this.materialLabel1.Text = "Date of Birth";
            // 
            // dtDOB
            // 
            this.dtDOB.Location = new System.Drawing.Point(72, 196);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(293, 20);
            this.dtDOB.TabIndex = 3;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.AnimateReadOnly = false;
            this.txtPhoneNumber.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhoneNumber.Depth = 0;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPhoneNumber.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPhoneNumber.Hint = "Enter Phone Number";
            this.txtPhoneNumber.LeadingIcon = null;
            this.txtPhoneNumber.Location = new System.Drawing.Point(436, 247);
            this.txtPhoneNumber.MaxLength = 50;
            this.txtPhoneNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPhoneNumber.Multiline = false;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(297, 50);
            this.txtPhoneNumber.TabIndex = 6;
            this.txtPhoneNumber.Text = "";
            this.txtPhoneNumber.TrailingIcon = null;
            // 
            // cmbGender
            // 
            this.cmbGender.AutoResize = false;
            this.cmbGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbGender.Depth = 0;
            this.cmbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbGender.DropDownHeight = 174;
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.DropDownWidth = 121;
            this.cmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Hint = "Select Gender";
            this.cmbGender.IntegralHeight = false;
            this.cmbGender.ItemHeight = 43;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(436, 170);
            this.cmbGender.MaxDropDownItems = 4;
            this.cmbGender.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(297, 49);
            this.cmbGender.StartIndex = 0;
            this.cmbGender.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(364, 417);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(64, 36);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtLName
            // 
            this.txtLName.AnimateReadOnly = false;
            this.txtLName.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtLName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLName.Depth = 0;
            this.txtLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLName.ForeColor = System.Drawing.SystemColors.Window;
            this.txtLName.Hint = "Enter Last Name Name";
            this.txtLName.LeadingIcon = null;
            this.txtLName.Location = new System.Drawing.Point(436, 92);
            this.txtLName.MaxLength = 50;
            this.txtLName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLName.Multiline = false;
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(297, 50);
            this.txtLName.TabIndex = 2;
            this.txtLName.Text = "";
            this.txtLName.TrailingIcon = null;
            // 
            // txtFName
            // 
            this.txtFName.AnimateReadOnly = false;
            this.txtFName.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtFName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFName.Depth = 0;
            this.txtFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFName.ForeColor = System.Drawing.SystemColors.Window;
            this.txtFName.Hint = "Enter First Name";
            this.txtFName.LeadingIcon = null;
            this.txtFName.Location = new System.Drawing.Point(68, 92);
            this.txtFName.MaxLength = 50;
            this.txtFName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFName.Multiline = false;
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(297, 50);
            this.txtFName.TabIndex = 1;
            this.txtFName.Text = "";
            this.txtFName.TrailingIcon = null;
            // 
            // txtAddress
            // 
            this.txtAddress.AnimateReadOnly = false;
            this.txtAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Depth = 0;
            this.txtAddress.HideSelection = true;
            this.txtAddress.Hint = "Enter Address";
            this.txtAddress.Location = new System.Drawing.Point(72, 322);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.ReadOnly = false;
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.Size = new System.Drawing.Size(661, 73);
            this.txtAddress.TabIndex = 7;
            this.txtAddress.TabStop = false;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddress.UseSystemPasswordChar = false;
            // 
            // AddNewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dtDOB);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Name = "AddNewStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Student";
            this.Load += new System.EventHandler(this.AddNewStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker dtDOB;
        private MaterialSkin.Controls.MaterialTextBox txtPhoneNumber;
        public MaterialSkin.Controls.MaterialComboBox cmbGender;
        public MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialTextBox txtLName;
        private MaterialSkin.Controls.MaterialTextBox txtFName;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtAddress;
    }
}