namespace Uzduotis
{
    partial class AdminForm
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
            this.adminPanel = new System.Windows.Forms.Panel();
            this.adminButtonsPanel = new System.Windows.Forms.Panel();
            this.adminUsernameLabel = new System.Windows.Forms.Label();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.StudentGrupesButton = new System.Windows.Forms.Button();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.adminHeaderLabel = new System.Windows.Forms.Label();
            this.LecturersButton = new System.Windows.Forms.Button();
            this.adminButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminPanel
            // 
            this.adminPanel.Location = new System.Drawing.Point(245, 53);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(587, 494);
            this.adminPanel.TabIndex = 10;
            // 
            // adminButtonsPanel
            // 
            this.adminButtonsPanel.Controls.Add(this.LecturersButton);
            this.adminButtonsPanel.Controls.Add(this.adminUsernameLabel);
            this.adminButtonsPanel.Controls.Add(this.LogOutButton);
            this.adminButtonsPanel.Controls.Add(this.StudentGrupesButton);
            this.adminButtonsPanel.Controls.Add(this.ProfileButton);
            this.adminButtonsPanel.Location = new System.Drawing.Point(4, 53);
            this.adminButtonsPanel.Name = "adminButtonsPanel";
            this.adminButtonsPanel.Size = new System.Drawing.Size(235, 494);
            this.adminButtonsPanel.TabIndex = 9;
            // 
            // adminUsernameLabel
            // 
            this.adminUsernameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.adminUsernameLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminUsernameLabel.Location = new System.Drawing.Point(21, 15);
            this.adminUsernameLabel.Name = "adminUsernameLabel";
            this.adminUsernameLabel.Size = new System.Drawing.Size(197, 96);
            this.adminUsernameLabel.TabIndex = 7;
            this.adminUsernameLabel.Text = "Admin";
            this.adminUsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogOutButton
            // 
            this.LogOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.Location = new System.Drawing.Point(25, 265);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(197, 39);
            this.LogOutButton.TabIndex = 7;
            this.LogOutButton.Text = "Log out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // StudentGrupesButton
            // 
            this.StudentGrupesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentGrupesButton.Location = new System.Drawing.Point(25, 175);
            this.StudentGrupesButton.Name = "StudentGrupesButton";
            this.StudentGrupesButton.Size = new System.Drawing.Size(197, 39);
            this.StudentGrupesButton.TabIndex = 7;
            this.StudentGrupesButton.Text = "Student grupes";
            this.StudentGrupesButton.UseVisualStyleBackColor = true;
            this.StudentGrupesButton.Click += new System.EventHandler(this.StudentGrupesButton_Click);
            // 
            // ProfileButton
            // 
            this.ProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileButton.Location = new System.Drawing.Point(25, 130);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(197, 39);
            this.ProfileButton.TabIndex = 7;
            this.ProfileButton.Text = "Profile";
            this.ProfileButton.UseVisualStyleBackColor = true;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // adminHeaderLabel
            // 
            this.adminHeaderLabel.AutoSize = true;
            this.adminHeaderLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminHeaderLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.adminHeaderLabel.Location = new System.Drawing.Point(303, 11);
            this.adminHeaderLabel.Name = "adminHeaderLabel";
            this.adminHeaderLabel.Size = new System.Drawing.Size(192, 40);
            this.adminHeaderLabel.TabIndex = 8;
            this.adminHeaderLabel.Text = "Main page";
            // 
            // LecturersButton
            // 
            this.LecturersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LecturersButton.Location = new System.Drawing.Point(25, 220);
            this.LecturersButton.Name = "LecturersButton";
            this.LecturersButton.Size = new System.Drawing.Size(197, 39);
            this.LecturersButton.TabIndex = 8;
            this.LecturersButton.Text = "Lecturers";
            this.LecturersButton.UseVisualStyleBackColor = true;
            this.LecturersButton.Click += new System.EventHandler(this.LecturersButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(837, 551);
            this.Controls.Add(this.adminPanel);
            this.Controls.Add(this.adminButtonsPanel);
            this.Controls.Add(this.adminHeaderLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.adminButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.Panel adminButtonsPanel;
        private System.Windows.Forms.Label adminUsernameLabel;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button StudentGrupesButton;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Label adminHeaderLabel;
        private System.Windows.Forms.Button LecturersButton;
    }
}