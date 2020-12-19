namespace Uzduotis.Frontend.Forms.SystemForms
{
    partial class LecturerSubjectsForm
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
            this.subjectsPanel = new System.Windows.Forms.Panel();
            this.studentsListView = new System.Windows.Forms.ListView();
            this.ch_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_birthdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ViewStudentGradesButton = new System.Windows.Forms.Button();
            this.ViewStudentsButton = new System.Windows.Forms.Button();
            this.subjectsComboBox = new System.Windows.Forms.ComboBox();
            this.subjectsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentHeaderLabel
            // 
            this.studentHeaderLabel.AutoSize = true;
            this.studentHeaderLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentHeaderLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.studentHeaderLabel.Location = new System.Drawing.Point(328, 4);
            this.studentHeaderLabel.Name = "studentHeaderLabel";
            this.studentHeaderLabel.Size = new System.Drawing.Size(165, 40);
            this.studentHeaderLabel.TabIndex = 7;
            this.studentHeaderLabel.Text = "Subjects";
            // 
            // subjectsPanel
            // 
            this.subjectsPanel.Controls.Add(this.ViewStudentsButton);
            this.subjectsPanel.Controls.Add(this.subjectsComboBox);
            this.subjectsPanel.Location = new System.Drawing.Point(4, 67);
            this.subjectsPanel.Name = "subjectsPanel";
            this.subjectsPanel.Size = new System.Drawing.Size(217, 429);
            this.subjectsPanel.TabIndex = 5;
            // 
            // studentsListView
            // 
            this.studentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_name,
            this.ch_surname,
            this.ch_username,
            this.ch_birthdate,
            this.ch_id});
            this.studentsListView.FullRowSelect = true;
            this.studentsListView.HideSelection = false;
            this.studentsListView.Location = new System.Drawing.Point(228, 67);
            this.studentsListView.Margin = new System.Windows.Forms.Padding(4);
            this.studentsListView.MultiSelect = false;
            this.studentsListView.Name = "studentsListView";
            this.studentsListView.Size = new System.Drawing.Size(566, 344);
            this.studentsListView.TabIndex = 12;
            this.studentsListView.UseCompatibleStateImageBehavior = false;
            this.studentsListView.View = System.Windows.Forms.View.Details;
            this.studentsListView.SelectedIndexChanged += new System.EventHandler(this.studentsListView_SelectedIndexChanged);
            // 
            // ch_name
            // 
            this.ch_name.DisplayIndex = 1;
            this.ch_name.Text = "Name";
            this.ch_name.Width = 150;
            // 
            // ch_surname
            // 
            this.ch_surname.DisplayIndex = 2;
            this.ch_surname.Text = "Surname";
            this.ch_surname.Width = 150;
            // 
            // ch_username
            // 
            this.ch_username.DisplayIndex = 3;
            this.ch_username.Text = "Username";
            this.ch_username.Width = 130;
            // 
            // ch_birthdate
            // 
            this.ch_birthdate.DisplayIndex = 4;
            this.ch_birthdate.Text = "Birthdate";
            this.ch_birthdate.Width = 100;
            // 
            // ch_id
            // 
            this.ch_id.DisplayIndex = 0;
            this.ch_id.Text = "ID";
            this.ch_id.Width = 40;
            // 
            // ViewStudentGradesButton
            // 
            this.ViewStudentGradesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ViewStudentGradesButton.Enabled = false;
            this.ViewStudentGradesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewStudentGradesButton.Location = new System.Drawing.Point(457, 428);
            this.ViewStudentGradesButton.Name = "ViewStudentGradesButton";
            this.ViewStudentGradesButton.Size = new System.Drawing.Size(108, 29);
            this.ViewStudentGradesButton.TabIndex = 13;
            this.ViewStudentGradesButton.Text = "View grades";
            this.ViewStudentGradesButton.UseVisualStyleBackColor = false;
            this.ViewStudentGradesButton.Click += new System.EventHandler(this.ViewGradesButton_Click);
            // 
            // ViewStudentsButton
            // 
            this.ViewStudentsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ViewStudentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewStudentsButton.Location = new System.Drawing.Point(52, 53);
            this.ViewStudentsButton.Name = "ViewStudentsButton";
            this.ViewStudentsButton.Size = new System.Drawing.Size(111, 28);
            this.ViewStudentsButton.TabIndex = 14;
            this.ViewStudentsButton.Text = "View students";
            this.ViewStudentsButton.UseVisualStyleBackColor = false;
            this.ViewStudentsButton.Click += new System.EventHandler(this.ViewStudentsButton_Click);
            // 
            // subjectsComboBox
            // 
            this.subjectsComboBox.FormattingEnabled = true;
            this.subjectsComboBox.Location = new System.Drawing.Point(3, 12);
            this.subjectsComboBox.Name = "subjectsComboBox";
            this.subjectsComboBox.Size = new System.Drawing.Size(207, 21);
            this.subjectsComboBox.TabIndex = 15;
            // 
            // LecturerSubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(806, 503);
            this.Controls.Add(this.ViewStudentGradesButton);
            this.Controls.Add(this.studentsListView);
            this.Controls.Add(this.studentHeaderLabel);
            this.Controls.Add(this.subjectsPanel);
            this.Name = "LecturerSubjectsForm";
            this.Text = "LecturerSubjectsForm";
            this.subjectsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label studentHeaderLabel;
        private System.Windows.Forms.ListView studentsListView;
        private System.Windows.Forms.ColumnHeader ch_name;
        private System.Windows.Forms.ColumnHeader ch_surname;
        private System.Windows.Forms.ColumnHeader ch_username;
        private System.Windows.Forms.ColumnHeader ch_birthdate;
        private System.Windows.Forms.ColumnHeader ch_id;
        private System.Windows.Forms.Panel subjectsPanel;
        private System.Windows.Forms.Button ViewStudentGradesButton;
        private System.Windows.Forms.Button ViewStudentsButton;
        private System.Windows.Forms.ComboBox subjectsComboBox;
    }
}