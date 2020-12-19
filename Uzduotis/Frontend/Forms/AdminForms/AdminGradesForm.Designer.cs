namespace Uzduotis.Frontend.Forms.SystemForms
{
    partial class AdminGradesForm
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
            this.subjectsPanel = new System.Windows.Forms.Panel();
            this.ChangeGradeButton = new System.Windows.Forms.Button();
            this.adminHeaderLabel = new System.Windows.Forms.Label();
            this.gradesPanel = new System.Windows.Forms.Panel();
            this.ViewGradesButton = new System.Windows.Forms.Button();
            this.subjectsComboBox = new System.Windows.Forms.ComboBox();
            this.subjectsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // subjectsPanel
            // 
            this.subjectsPanel.Controls.Add(this.ViewGradesButton);
            this.subjectsPanel.Controls.Add(this.subjectsComboBox);
            this.subjectsPanel.Location = new System.Drawing.Point(12, 52);
            this.subjectsPanel.Name = "subjectsPanel";
            this.subjectsPanel.Size = new System.Drawing.Size(205, 402);
            this.subjectsPanel.TabIndex = 13;
            // 
            // ChangeGradeButton
            // 
            this.ChangeGradeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ChangeGradeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeGradeButton.Location = new System.Drawing.Point(467, 406);
            this.ChangeGradeButton.Name = "ChangeGradeButton";
            this.ChangeGradeButton.Size = new System.Drawing.Size(87, 26);
            this.ChangeGradeButton.TabIndex = 15;
            this.ChangeGradeButton.Text = "Change";
            this.ChangeGradeButton.UseVisualStyleBackColor = false;
            // 
            // adminHeaderLabel
            // 
            this.adminHeaderLabel.AutoSize = true;
            this.adminHeaderLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminHeaderLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.adminHeaderLabel.Location = new System.Drawing.Point(328, 9);
            this.adminHeaderLabel.Name = "adminHeaderLabel";
            this.adminHeaderLabel.Size = new System.Drawing.Size(143, 40);
            this.adminHeaderLabel.TabIndex = 19;
            this.adminHeaderLabel.Text = "Grades";
            // 
            // gradesPanel
            // 
            this.gradesPanel.Location = new System.Drawing.Point(223, 52);
            this.gradesPanel.Name = "gradesPanel";
            this.gradesPanel.Size = new System.Drawing.Size(575, 402);
            this.gradesPanel.TabIndex = 14;
            // 
            // ViewGradesButton
            // 
            this.ViewGradesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ViewGradesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewGradesButton.Location = new System.Drawing.Point(55, 53);
            this.ViewGradesButton.Name = "ViewGradesButton";
            this.ViewGradesButton.Size = new System.Drawing.Size(111, 28);
            this.ViewGradesButton.TabIndex = 20;
            this.ViewGradesButton.Text = "View grades";
            this.ViewGradesButton.UseVisualStyleBackColor = false;
            this.ViewGradesButton.Click += new System.EventHandler(this.ViewGradesButton_Click);
            // 
            // subjectsComboBox
            // 
            this.subjectsComboBox.FormattingEnabled = true;
            this.subjectsComboBox.Location = new System.Drawing.Point(6, 12);
            this.subjectsComboBox.Name = "subjectsComboBox";
            this.subjectsComboBox.Size = new System.Drawing.Size(196, 21);
            this.subjectsComboBox.TabIndex = 21;
            // 
            // AdminGradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(803, 457);
            this.Controls.Add(this.gradesPanel);
            this.Controls.Add(this.adminHeaderLabel);
            this.Controls.Add(this.subjectsPanel);
            this.Controls.Add(this.ChangeGradeButton);
            this.Name = "AdminGradesForm";
            this.Text = "AdminGradesForm";
            this.subjectsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel subjectsPanel;
        protected System.Windows.Forms.Button ChangeGradeButton;
        private System.Windows.Forms.Label adminHeaderLabel;
        private System.Windows.Forms.Panel gradesPanel;
        private System.Windows.Forms.Button ViewGradesButton;
        private System.Windows.Forms.ComboBox subjectsComboBox;
    }
}