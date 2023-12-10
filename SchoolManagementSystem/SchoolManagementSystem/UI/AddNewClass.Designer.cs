namespace SchoolManagementSystem.UI
{
    partial class AddNewClass
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
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.txtClassName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtClassLevel = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(134, 250);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(64, 36);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtClassName
            // 
            this.txtClassName.AnimateReadOnly = false;
            this.txtClassName.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtClassName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClassName.Depth = 0;
            this.txtClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtClassName.ForeColor = System.Drawing.SystemColors.Window;
            this.txtClassName.Hint = "Enter Class Name";
            this.txtClassName.LeadingIcon = null;
            this.txtClassName.Location = new System.Drawing.Point(28, 98);
            this.txtClassName.MaxLength = 50;
            this.txtClassName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtClassName.Multiline = false;
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(297, 50);
            this.txtClassName.TabIndex = 11;
            this.txtClassName.Text = "";
            this.txtClassName.TrailingIcon = null;
            // 
            // txtClassLevel
            // 
            this.txtClassLevel.AnimateReadOnly = false;
            this.txtClassLevel.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtClassLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClassLevel.Depth = 0;
            this.txtClassLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtClassLevel.ForeColor = System.Drawing.SystemColors.Window;
            this.txtClassLevel.Hint = "Enter Class Level";
            this.txtClassLevel.LeadingIcon = null;
            this.txtClassLevel.Location = new System.Drawing.Point(28, 171);
            this.txtClassLevel.MaxLength = 50;
            this.txtClassLevel.MouseState = MaterialSkin.MouseState.OUT;
            this.txtClassLevel.Multiline = false;
            this.txtClassLevel.Name = "txtClassLevel";
            this.txtClassLevel.Size = new System.Drawing.Size(297, 50);
            this.txtClassLevel.TabIndex = 14;
            this.txtClassLevel.Text = "";
            this.txtClassLevel.TrailingIcon = null;
            // 
            // AddNewClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 322);
            this.Controls.Add(this.txtClassLevel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtClassName);
            this.Name = "AddNewClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Class";
            this.Load += new System.EventHandler(this.AddNewClass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialTextBox txtClassName;
        private MaterialSkin.Controls.MaterialTextBox txtClassLevel;
    }
}