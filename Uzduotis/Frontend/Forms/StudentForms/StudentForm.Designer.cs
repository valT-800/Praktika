namespace Uzduotis
{
    partial class StudentForm
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
            this.studentHeaderLabel = new System.Windows.Forms.Label();
            this.studentPanel = new System.Windows.Forms.Panel();
            this.studentButtonsPanel = new System.Windows.Forms.Panel();
            this.SubjectsButton = new System.Windows.Forms.Button();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.studentButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentHeaderLabel
            // 
            this.studentHeaderLabel.AutoSize = true;
            this.studentHeaderLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentHeaderLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.studentHeaderLabel.Location = new System.Drawing.Point(332, 9);
            this.studentHeaderLabel.Name = "studentHeaderLabel";
            this.studentHeaderLabel.Size = new System.Drawing.Size(192, 40);
            this.studentHeaderLabel.TabIndex = 2;
            this.studentHeaderLabel.Text = "Main page";
            // 
            // studentPanel
            // 
            this.studentPanel.Location = new System.Drawing.Point(244, 52);
            this.studentPanel.Name = "studentPanel";
            this.studentPanel.Size = new System.Drawing.Size(587, 495);
            this.studentPanel.TabIndex = 11;
            // 
            // studentButtonsPanel
            // 
            this.studentButtonsPanel.Controls.Add(this.SubjectsButton);
            this.studentButtonsPanel.Controls.Add(this.studentNameLabel);
            this.studentButtonsPanel.Controls.Add(this.LogOutButton);
            this.studentButtonsPanel.Controls.Add(this.ProfileButton);
            this.studentButtonsPanel.Location = new System.Drawing.Point(3, 52);
            this.studentButtonsPanel.Name = "studentButtonsPanel";
            this.studentButtonsPanel.Size = new System.Drawing.Size(235, 495);
            this.studentButtonsPanel.TabIndex = 10;
            // 
            // SubjectsButton
            // 
            this.SubjectsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectsButton.Location = new System.Drawing.Point(21, 192);
            this.SubjectsButton.Name = "SubjectsButton";
            this.SubjectsButton.Size = new System.Drawing.Size(197, 39);
            this.SubjectsButton.TabIndex = 10;
            this.SubjectsButton.Text = "Subjects";
            this.SubjectsButton.UseVisualStyleBackColor = true;
            this.SubjectsButton.Click += new System.EventHandler(this.SubjectsButton_Click);
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.studentNameLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameLabel.Location = new System.Drawing.Point(21, 15);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(197, 96);
            this.studentNameLabel.TabIndex = 7;
            this.studentNameLabel.Text = "Student";
            this.studentNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogOutButton
            // 
            this.LogOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.Location = new System.Drawing.Point(21, 251);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(197, 39);
            this.LogOutButton.TabIndex = 7;
            this.LogOutButton.Text = "Log out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
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
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(837, 551);
            this.Controls.Add(this.studentPanel);
            this.Controls.Add(this.studentButtonsPanel);
            this.Controls.Add(this.studentHeaderLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentForm";
            this.ShowIcon = false;
            this.studentButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentHeaderLabel;
        private System.Windows.Forms.Panel studentPanel;
        private System.Windows.Forms.Panel studentButtonsPanel;
        private System.Windows.Forms.Button SubjectsButton;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button ProfileButton;
    }
}