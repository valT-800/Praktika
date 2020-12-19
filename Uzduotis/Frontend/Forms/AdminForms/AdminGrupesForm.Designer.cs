namespace Uzduotis.Frontend.Forms.SystemForms
{
    partial class AdminGrupesForm
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
            this.adminHeaderLabel = new System.Windows.Forms.Label();
            this.ViewStudentGradesButton = new System.Windows.Forms.Button();
            this.studentsListView = new System.Windows.Forms.ListView();
            this.ch_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_birthdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grupesPanel = new System.Windows.Forms.Panel();
            this.ViewStudentsButton = new System.Windows.Forms.Button();
            this.grupesComboBox = new System.Windows.Forms.ComboBox();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.DeleteStudentButton = new System.Windows.Forms.Button();
            this.AddGrupeButton = new System.Windows.Forms.Button();
            this.DeleteGrupeButton = new System.Windows.Forms.Button();
            this.addGrupePanel = new System.Windows.Forms.Panel();
            this.grupesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminHeaderLabel
            // 
            this.adminHeaderLabel.AutoSize = true;
            this.adminHeaderLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminHeaderLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.adminHeaderLabel.Location = new System.Drawing.Point(330, 5);
            this.adminHeaderLabel.Name = "adminHeaderLabel";
            this.adminHeaderLabel.Size = new System.Drawing.Size(143, 40);
            this.adminHeaderLabel.TabIndex = 10;
            this.adminHeaderLabel.Text = "Grupes";
            // 
            // ViewStudentGradesButton
            // 
            this.ViewStudentGradesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ViewStudentGradesButton.Enabled = false;
            this.ViewStudentGradesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewStudentGradesButton.Location = new System.Drawing.Point(460, 430);
            this.ViewStudentGradesButton.Name = "ViewStudentGradesButton";
            this.ViewStudentGradesButton.Size = new System.Drawing.Size(108, 29);
            this.ViewStudentGradesButton.TabIndex = 12;
            this.ViewStudentGradesButton.Text = "View grades";
            this.ViewStudentGradesButton.UseVisualStyleBackColor = false;
            this.ViewStudentGradesButton.Click += new System.EventHandler(this.ViewGradesButton_Click);
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
            this.studentsListView.Location = new System.Drawing.Point(230, 68);
            this.studentsListView.Margin = new System.Windows.Forms.Padding(4);
            this.studentsListView.MultiSelect = false;
            this.studentsListView.Name = "studentsListView";
            this.studentsListView.Size = new System.Drawing.Size(566, 344);
            this.studentsListView.TabIndex = 11;
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
            // grupesPanel
            // 
            this.grupesPanel.Controls.Add(this.addGrupePanel);
            this.grupesPanel.Controls.Add(this.ViewStudentsButton);
            this.grupesPanel.Controls.Add(this.AddGrupeButton);
            this.grupesPanel.Controls.Add(this.DeleteGrupeButton);
            this.grupesPanel.Controls.Add(this.grupesComboBox);
            this.grupesPanel.Location = new System.Drawing.Point(6, 68);
            this.grupesPanel.Name = "grupesPanel";
            this.grupesPanel.Size = new System.Drawing.Size(217, 344);
            this.grupesPanel.TabIndex = 8;
            // 
            // ViewStudentsButton
            // 
            this.ViewStudentsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ViewStudentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewStudentsButton.Location = new System.Drawing.Point(52, 57);
            this.ViewStudentsButton.Name = "ViewStudentsButton";
            this.ViewStudentsButton.Size = new System.Drawing.Size(111, 28);
            this.ViewStudentsButton.TabIndex = 17;
            this.ViewStudentsButton.Text = "View students";
            this.ViewStudentsButton.UseVisualStyleBackColor = false;
            this.ViewStudentsButton.Click += new System.EventHandler(this.ViewStudentsButton_Click);
            // 
            // grupesComboBox
            // 
            this.grupesComboBox.FormattingEnabled = true;
            this.grupesComboBox.Location = new System.Drawing.Point(3, 16);
            this.grupesComboBox.Name = "grupesComboBox";
            this.grupesComboBox.Size = new System.Drawing.Size(207, 21);
            this.grupesComboBox.TabIndex = 18;
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudentButton.Location = new System.Drawing.Point(337, 430);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(108, 29);
            this.AddStudentButton.TabIndex = 13;
            this.AddStudentButton.Text = "Add student";
            this.AddStudentButton.UseVisualStyleBackColor = false;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // DeleteStudentButton
            // 
            this.DeleteStudentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DeleteStudentButton.Enabled = false;
            this.DeleteStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteStudentButton.Location = new System.Drawing.Point(586, 430);
            this.DeleteStudentButton.Name = "DeleteStudentButton";
            this.DeleteStudentButton.Size = new System.Drawing.Size(108, 29);
            this.DeleteStudentButton.TabIndex = 14;
            this.DeleteStudentButton.Text = "Delete";
            this.DeleteStudentButton.UseVisualStyleBackColor = false;
            this.DeleteStudentButton.Click += new System.EventHandler(this.DeleteStudentButton_Click);
            // 
            // AddGrupeButton
            // 
            this.AddGrupeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddGrupeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddGrupeButton.Location = new System.Drawing.Point(52, 153);
            this.AddGrupeButton.Name = "AddGrupeButton";
            this.AddGrupeButton.Size = new System.Drawing.Size(108, 29);
            this.AddGrupeButton.TabIndex = 15;
            this.AddGrupeButton.Text = "Add grupe";
            this.AddGrupeButton.UseVisualStyleBackColor = false;
            this.AddGrupeButton.Click += new System.EventHandler(this.AddGrupeButton_Click);
            // 
            // DeleteGrupeButton
            // 
            this.DeleteGrupeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DeleteGrupeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteGrupeButton.Location = new System.Drawing.Point(52, 103);
            this.DeleteGrupeButton.Name = "DeleteGrupeButton";
            this.DeleteGrupeButton.Size = new System.Drawing.Size(108, 29);
            this.DeleteGrupeButton.TabIndex = 16;
            this.DeleteGrupeButton.Text = "Delete grupe";
            this.DeleteGrupeButton.UseVisualStyleBackColor = false;
            this.DeleteGrupeButton.Click += new System.EventHandler(this.DeleteGrupeButton_Click);
            // 
            // addGrupePanel
            // 
            this.addGrupePanel.Location = new System.Drawing.Point(0, 200);
            this.addGrupePanel.Name = "addGrupePanel";
            this.addGrupePanel.Size = new System.Drawing.Size(217, 75);
            this.addGrupePanel.TabIndex = 9;
            // 
            // AdminGrupesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(809, 468);
            this.Controls.Add(this.DeleteStudentButton);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(this.ViewStudentGradesButton);
            this.Controls.Add(this.adminHeaderLabel);
            this.Controls.Add(this.studentsListView);
            this.Controls.Add(this.grupesPanel);
            this.Name = "AdminGrupesForm";
            this.Text = "AdminGrupesForm";
            this.grupesPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label adminHeaderLabel;
        protected System.Windows.Forms.Panel grupesPanel;
        private System.Windows.Forms.Button ViewStudentGradesButton;
        private System.Windows.Forms.ListView studentsListView;
        private System.Windows.Forms.ColumnHeader ch_name;
        private System.Windows.Forms.ColumnHeader ch_surname;
        private System.Windows.Forms.ColumnHeader ch_username;
        private System.Windows.Forms.ColumnHeader ch_birthdate;
        private System.Windows.Forms.ColumnHeader ch_id;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Button DeleteStudentButton;
        private System.Windows.Forms.Button AddGrupeButton;
        private System.Windows.Forms.Button DeleteGrupeButton;
        protected System.Windows.Forms.Panel addGrupePanel;
        private System.Windows.Forms.Button ViewStudentsButton;
        private System.Windows.Forms.ComboBox grupesComboBox;
    }
}