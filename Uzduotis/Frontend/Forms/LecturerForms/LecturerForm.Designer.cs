namespace Uzduotis
{
    partial class LecturerForm
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
            this.lecturerButtonsPanel = new System.Windows.Forms.Panel();
            this.lecturerUsernameLabel = new System.Windows.Forms.Label();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.SubjectsButton = new System.Windows.Forms.Button();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.lecturerHeaderLabel = new System.Windows.Forms.Label();
            this.lecturerPanel = new System.Windows.Forms.Panel();
            this.lecturerButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lecturerButtonsPanel
            // 
            this.lecturerButtonsPanel.Controls.Add(this.lecturerUsernameLabel);
            this.lecturerButtonsPanel.Controls.Add(this.LogOutButton);
            this.lecturerButtonsPanel.Controls.Add(this.SubjectsButton);
            this.lecturerButtonsPanel.Controls.Add(this.ProfileButton);
            this.lecturerButtonsPanel.Location = new System.Drawing.Point(4, 54);
            this.lecturerButtonsPanel.Name = "lecturerButtonsPanel";
            this.lecturerButtonsPanel.Size = new System.Drawing.Size(235, 495);
            this.lecturerButtonsPanel.TabIndex = 9;
            // 
            // lecturerUsernameLabel
            // 
            this.lecturerUsernameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lecturerUsernameLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturerUsernameLabel.Location = new System.Drawing.Point(21, 15);
            this.lecturerUsernameLabel.Name = "lecturerUsernameLabel";
            this.lecturerUsernameLabel.Size = new System.Drawing.Size(197, 96);
            this.lecturerUsernameLabel.TabIndex = 7;
            this.lecturerUsernameLabel.Text = "Lecturer";
            this.lecturerUsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogOutButton
            // 
            this.LogOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.Location = new System.Drawing.Point(21, 241);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(197, 39);
            this.LogOutButton.TabIndex = 7;
            this.LogOutButton.Text = "Log out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // SubjectsButton
            // 
            this.SubjectsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectsButton.Location = new System.Drawing.Point(21, 184);
            this.SubjectsButton.Name = "SubjectsButton";
            this.SubjectsButton.Size = new System.Drawing.Size(197, 39);
            this.SubjectsButton.TabIndex = 7;
            this.SubjectsButton.Text = "My subjects";
            this.SubjectsButton.UseVisualStyleBackColor = true;
            this.SubjectsButton.Click += new System.EventHandler(this.SubjectsButton_Click);
            // 
            // ProfileButton
            // 
            this.ProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileButton.Location = new System.Drawing.Point(21, 130);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(197, 39);
            this.ProfileButton.TabIndex = 7;
            this.ProfileButton.Text = "Profile";
            this.ProfileButton.UseVisualStyleBackColor = true;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // lecturerHeaderLabel
            // 
            this.lecturerHeaderLabel.AutoSize = true;
            this.lecturerHeaderLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturerHeaderLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lecturerHeaderLabel.Location = new System.Drawing.Point(324, 9);
            this.lecturerHeaderLabel.Name = "lecturerHeaderLabel";
            this.lecturerHeaderLabel.Size = new System.Drawing.Size(192, 40);
            this.lecturerHeaderLabel.TabIndex = 8;
            this.lecturerHeaderLabel.Text = "Main page";
            // 
            // lecturerPanel
            // 
            this.lecturerPanel.Location = new System.Drawing.Point(245, 54);
            this.lecturerPanel.Name = "lecturerPanel";
            this.lecturerPanel.Size = new System.Drawing.Size(581, 495);
            this.lecturerPanel.TabIndex = 11;
            // 
            // LecturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(837, 551);
            this.Controls.Add(this.lecturerPanel);
            this.Controls.Add(this.lecturerButtonsPanel);
            this.Controls.Add(this.lecturerHeaderLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LecturerForm";
            this.Text = "LecturerForm";
            this.lecturerButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel lecturerButtonsPanel;
        private System.Windows.Forms.Label lecturerUsernameLabel;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button SubjectsButton;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Label lecturerHeaderLabel;
        private System.Windows.Forms.Panel lecturerPanel;
    }
}