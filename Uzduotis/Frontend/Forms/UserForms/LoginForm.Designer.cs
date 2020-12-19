namespace Uzduotis
{
	partial class LoginForm
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
            this.loginPanel = new System.Windows.Forms.Panel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.labelPasswordLogin = new System.Windows.Forms.Label();
            this.labelUsernameLogin = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.TextBox();
            this.headerNameLabel = new System.Windows.Forms.Label();
            this.studentRadioButton = new System.Windows.Forms.RadioButton();
            this.lecturerRadioButton = new System.Windows.Forms.RadioButton();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.lecturerRadioButton);
            this.loginPanel.Controls.Add(this.studentRadioButton);
            this.loginPanel.Controls.Add(this.LoginButton);
            this.loginPanel.Controls.Add(this.labelPasswordLogin);
            this.loginPanel.Controls.Add(this.labelUsernameLogin);
            this.loginPanel.Controls.Add(this.passwordLabel);
            this.loginPanel.Controls.Add(this.usernameLabel);
            this.loginPanel.Location = new System.Drawing.Point(11, 70);
            this.loginPanel.Margin = new System.Windows.Forms.Padding(2);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(753, 431);
            this.loginPanel.TabIndex = 30;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.Black;
            this.LoginButton.Location = new System.Drawing.Point(301, 278);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(5);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(117, 37);
            this.LoginButton.TabIndex = 20;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // labelPasswordLogin
            // 
            this.labelPasswordLogin.AutoSize = true;
            this.labelPasswordLogin.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelPasswordLogin.Location = new System.Drawing.Point(184, 143);
            this.labelPasswordLogin.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPasswordLogin.Name = "labelPasswordLogin";
            this.labelPasswordLogin.Size = new System.Drawing.Size(64, 15);
            this.labelPasswordLogin.TabIndex = 19;
            this.labelPasswordLogin.Text = "Password:";
            // 
            // labelUsernameLogin
            // 
            this.labelUsernameLogin.AutoSize = true;
            this.labelUsernameLogin.BackColor = System.Drawing.Color.Silver;
            this.labelUsernameLogin.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsernameLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelUsernameLogin.Location = new System.Drawing.Point(184, 77);
            this.labelUsernameLogin.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelUsernameLogin.Name = "labelUsernameLogin";
            this.labelUsernameLogin.Size = new System.Drawing.Size(65, 15);
            this.labelUsernameLogin.TabIndex = 18;
            this.labelUsernameLogin.Text = "Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.BackColor = System.Drawing.Color.White;
            this.passwordLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.Black;
            this.passwordLabel.Location = new System.Drawing.Point(187, 163);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(5);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.PasswordChar = '*';
            this.passwordLabel.Size = new System.Drawing.Size(383, 19);
            this.passwordLabel.TabIndex = 17;
            // 
            // usernameLabel
            // 
            this.usernameLabel.BackColor = System.Drawing.Color.White;
            this.usernameLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.Black;
            this.usernameLabel.Location = new System.Drawing.Point(187, 97);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(5);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(383, 19);
            this.usernameLabel.TabIndex = 16;
            // 
            // headerNameLabel
            // 
            this.headerNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.headerNameLabel.AutoSize = true;
            this.headerNameLabel.BackColor = System.Drawing.Color.Silver;
            this.headerNameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerNameLabel.ForeColor = System.Drawing.Color.White;
            this.headerNameLabel.Location = new System.Drawing.Point(338, 9);
            this.headerNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.headerNameLabel.Name = "headerNameLabel";
            this.headerNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.headerNameLabel.Size = new System.Drawing.Size(91, 41);
            this.headerNameLabel.TabIndex = 11;
            this.headerNameLabel.Text = "Login";
            this.headerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.headerNameLabel.UseCompatibleTextRendering = true;
            // 
            // studentRadioButton
            // 
            this.studentRadioButton.AutoSize = true;
            this.studentRadioButton.Location = new System.Drawing.Point(278, 207);
            this.studentRadioButton.Name = "studentRadioButton";
            this.studentRadioButton.Size = new System.Drawing.Size(62, 17);
            this.studentRadioButton.TabIndex = 21;
            this.studentRadioButton.TabStop = true;
            this.studentRadioButton.Text = "Student";
            this.studentRadioButton.UseVisualStyleBackColor = true;
            // 
            // lecturerRadioButton
            // 
            this.lecturerRadioButton.AutoSize = true;
            this.lecturerRadioButton.Location = new System.Drawing.Point(397, 207);
            this.lecturerRadioButton.Name = "lecturerRadioButton";
            this.lecturerRadioButton.Size = new System.Drawing.Size(64, 17);
            this.lecturerRadioButton.TabIndex = 22;
            this.lecturerRadioButton.TabStop = true;
            this.lecturerRadioButton.Text = "Lecturer";
            this.lecturerRadioButton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(770, 512);
            this.Controls.Add(this.headerNameLabel);
            this.Controls.Add(this.loginPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Panel loginPanel;
        public System.Windows.Forms.Label headerNameLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label labelPasswordLogin;
        private System.Windows.Forms.Label labelUsernameLogin;
        private System.Windows.Forms.TextBox passwordLabel;
        public System.Windows.Forms.TextBox usernameLabel;
        private System.Windows.Forms.RadioButton lecturerRadioButton;
        private System.Windows.Forms.RadioButton studentRadioButton;
    }
}

