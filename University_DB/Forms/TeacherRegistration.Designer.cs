namespace University_DB.Forms
{
    partial class TeacherRegistration
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
            Registration_Button = new MaterialSkin.Controls.MaterialButton();
            StudentRegistrationPassword = new MaterialSkin.Controls.MaterialTextBox();
            StudentRegistrationEmail = new MaterialSkin.Controls.MaterialTextBox();
            StudentRegistrationSurname = new MaterialSkin.Controls.MaterialTextBox();
            StudentRegistrationName = new MaterialSkin.Controls.MaterialTextBox();
            SuspendLayout();
            // 
            // Registration_Button
            // 
            Registration_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Registration_Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Registration_Button.Depth = 0;
            Registration_Button.HighEmphasis = true;
            Registration_Button.Icon = null;
            Registration_Button.Location = new Point(482, 378);
            Registration_Button.Margin = new Padding(5, 7, 5, 7);
            Registration_Button.MouseState = MaterialSkin.MouseState.HOVER;
            Registration_Button.Name = "Registration_Button";
            Registration_Button.NoAccentTextColor = Color.Empty;
            Registration_Button.Size = new Size(89, 36);
            Registration_Button.TabIndex = 19;
            Registration_Button.Text = "Register";
            Registration_Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Registration_Button.UseAccentColor = false;
            Registration_Button.UseVisualStyleBackColor = true;
            // 
            // StudentRegistrationPassword
            // 
            StudentRegistrationPassword.AnimateReadOnly = false;
            StudentRegistrationPassword.BackColor = SystemColors.Window;
            StudentRegistrationPassword.BorderStyle = BorderStyle.None;
            StudentRegistrationPassword.Depth = 0;
            StudentRegistrationPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            StudentRegistrationPassword.Hint = "Password";
            StudentRegistrationPassword.LeadingIcon = null;
            StudentRegistrationPassword.Location = new Point(312, 318);
            StudentRegistrationPassword.Margin = new Padding(4, 3, 4, 3);
            StudentRegistrationPassword.MaxLength = 50;
            StudentRegistrationPassword.MouseState = MaterialSkin.MouseState.OUT;
            StudentRegistrationPassword.Multiline = false;
            StudentRegistrationPassword.Name = "StudentRegistrationPassword";
            StudentRegistrationPassword.Password = true;
            StudentRegistrationPassword.Size = new Size(424, 50);
            StudentRegistrationPassword.TabIndex = 18;
            StudentRegistrationPassword.Text = "";
            StudentRegistrationPassword.TrailingIcon = null;
            // 
            // StudentRegistrationEmail
            // 
            StudentRegistrationEmail.AnimateReadOnly = false;
            StudentRegistrationEmail.BorderStyle = BorderStyle.None;
            StudentRegistrationEmail.Depth = 0;
            StudentRegistrationEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            StudentRegistrationEmail.Hint = "Email";
            StudentRegistrationEmail.LeadingIcon = null;
            StudentRegistrationEmail.Location = new Point(312, 254);
            StudentRegistrationEmail.Margin = new Padding(4, 3, 4, 3);
            StudentRegistrationEmail.MaxLength = 50;
            StudentRegistrationEmail.MouseState = MaterialSkin.MouseState.OUT;
            StudentRegistrationEmail.Multiline = false;
            StudentRegistrationEmail.Name = "StudentRegistrationEmail";
            StudentRegistrationEmail.Size = new Size(424, 50);
            StudentRegistrationEmail.TabIndex = 17;
            StudentRegistrationEmail.Text = "";
            StudentRegistrationEmail.TrailingIcon = null;
            // 
            // StudentRegistrationSurname
            // 
            StudentRegistrationSurname.AnimateReadOnly = false;
            StudentRegistrationSurname.BorderStyle = BorderStyle.None;
            StudentRegistrationSurname.Depth = 0;
            StudentRegistrationSurname.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            StudentRegistrationSurname.Hint = "Surname";
            StudentRegistrationSurname.LeadingIcon = null;
            StudentRegistrationSurname.Location = new Point(312, 189);
            StudentRegistrationSurname.Margin = new Padding(4, 3, 4, 3);
            StudentRegistrationSurname.MaxLength = 50;
            StudentRegistrationSurname.MouseState = MaterialSkin.MouseState.OUT;
            StudentRegistrationSurname.Multiline = false;
            StudentRegistrationSurname.Name = "StudentRegistrationSurname";
            StudentRegistrationSurname.Size = new Size(424, 50);
            StudentRegistrationSurname.TabIndex = 16;
            StudentRegistrationSurname.Text = "";
            StudentRegistrationSurname.TrailingIcon = null;
            // 
            // StudentRegistrationName
            // 
            StudentRegistrationName.AnimateReadOnly = false;
            StudentRegistrationName.BorderStyle = BorderStyle.None;
            StudentRegistrationName.Depth = 0;
            StudentRegistrationName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            StudentRegistrationName.Hint = "Name";
            StudentRegistrationName.LeadingIcon = null;
            StudentRegistrationName.Location = new Point(312, 125);
            StudentRegistrationName.Margin = new Padding(4, 3, 4, 3);
            StudentRegistrationName.MaxLength = 50;
            StudentRegistrationName.MouseState = MaterialSkin.MouseState.OUT;
            StudentRegistrationName.Multiline = false;
            StudentRegistrationName.Name = "StudentRegistrationName";
            StudentRegistrationName.Size = new Size(424, 50);
            StudentRegistrationName.TabIndex = 15;
            StudentRegistrationName.Text = "";
            StudentRegistrationName.TrailingIcon = null;
            // 
            // TeacherRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            ClientSize = new Size(1049, 539);
            Controls.Add(Registration_Button);
            Controls.Add(StudentRegistrationPassword);
            Controls.Add(StudentRegistrationEmail);
            Controls.Add(StudentRegistrationSurname);
            Controls.Add(StudentRegistrationName);
            Name = "TeacherRegistration";
            Text = "Teacher Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton Registration_Button;
        private MaterialSkin.Controls.MaterialTextBox StudentRegistrationPassword;
        private MaterialSkin.Controls.MaterialTextBox StudentRegistrationEmail;
        private MaterialSkin.Controls.MaterialTextBox StudentRegistrationSurname;
        private MaterialSkin.Controls.MaterialTextBox StudentRegistrationName;
    }
}