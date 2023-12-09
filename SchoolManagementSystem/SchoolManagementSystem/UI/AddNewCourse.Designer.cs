namespace SchoolManagementSystem.UI
{
    partial class AddNewCourse
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
            this.cmbTeacher = new MaterialSkin.Controls.MaterialComboBox();
            this.txtCourseName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCourseDescription = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // cmbTeacher
            // 
            this.cmbTeacher.AutoResize = false;
            this.cmbTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbTeacher.Depth = 0;
            this.cmbTeacher.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbTeacher.DropDownHeight = 174;
            this.cmbTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeacher.DropDownWidth = 121;
            this.cmbTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbTeacher.FormattingEnabled = true;
            this.cmbTeacher.Hint = "Select Course Teacher";
            this.cmbTeacher.IntegralHeight = false;
            this.cmbTeacher.ItemHeight = 43;
            this.cmbTeacher.Location = new System.Drawing.Point(28, 287);
            this.cmbTeacher.MaxDropDownItems = 4;
            this.cmbTeacher.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbTeacher.Name = "cmbTeacher";
            this.cmbTeacher.Size = new System.Drawing.Size(297, 49);
            this.cmbTeacher.StartIndex = 0;
            this.cmbTeacher.TabIndex = 8;
            // 
            // txtCourseName
            // 
            this.txtCourseName.AnimateReadOnly = false;
            this.txtCourseName.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtCourseName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCourseName.Depth = 0;
            this.txtCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCourseName.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCourseName.Hint = "Enter Course Name";
            this.txtCourseName.LeadingIcon = null;
            this.txtCourseName.Location = new System.Drawing.Point(28, 101);
            this.txtCourseName.MaxLength = 50;
            this.txtCourseName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCourseName.Multiline = false;
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(297, 50);
            this.txtCourseName.TabIndex = 7;
            this.txtCourseName.Text = "";
            this.txtCourseName.TrailingIcon = null;
            // 
            // txtCourseDescription
            // 
            this.txtCourseDescription.AnimateReadOnly = false;
            this.txtCourseDescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCourseDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCourseDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCourseDescription.Depth = 0;
            this.txtCourseDescription.HideSelection = true;
            this.txtCourseDescription.Hint = "Enter Cousre Description";
            this.txtCourseDescription.Location = new System.Drawing.Point(28, 171);
            this.txtCourseDescription.MaxLength = 32767;
            this.txtCourseDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCourseDescription.Name = "txtCourseDescription";
            this.txtCourseDescription.PasswordChar = '\0';
            this.txtCourseDescription.ReadOnly = false;
            this.txtCourseDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCourseDescription.SelectedText = "";
            this.txtCourseDescription.SelectionLength = 0;
            this.txtCourseDescription.SelectionStart = 0;
            this.txtCourseDescription.ShortcutsEnabled = true;
            this.txtCourseDescription.Size = new System.Drawing.Size(297, 100);
            this.txtCourseDescription.TabIndex = 9;
            this.txtCourseDescription.TabStop = false;
            this.txtCourseDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCourseDescription.UseSystemPasswordChar = false;
            // 
            // btnSave
            // 
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(144, 359);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(64, 36);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddNewCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 423);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCourseDescription);
            this.Controls.Add(this.cmbTeacher);
            this.Controls.Add(this.txtCourseName);
            this.Name = "AddNewCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Course";
            this.Load += new System.EventHandler(this.AddNewCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MaterialSkin.Controls.MaterialComboBox cmbTeacher;
        private MaterialSkin.Controls.MaterialTextBox txtCourseName;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtCourseDescription;
        public MaterialSkin.Controls.MaterialButton btnSave;
    }
}