namespace Uzduotis.Frontend.Controllers.AdminControllers
{
    partial class AdminLecturersController
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DeleteLecturerButton = new System.Windows.Forms.Button();
            this.AddLecturerButton = new System.Windows.Forms.Button();
            this.LecturerSubjectsButton = new System.Windows.Forms.Button();
            this.lecturersListView = new System.Windows.Forms.ListView();
            this.ch_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_birthdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // DeleteLecturerButton
            // 
            this.DeleteLecturerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DeleteLecturerButton.Enabled = false;
            this.DeleteLecturerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteLecturerButton.Location = new System.Drawing.Point(373, 366);
            this.DeleteLecturerButton.Name = "DeleteLecturerButton";
            this.DeleteLecturerButton.Size = new System.Drawing.Size(108, 29);
            this.DeleteLecturerButton.TabIndex = 18;
            this.DeleteLecturerButton.Text = "Delete";
            this.DeleteLecturerButton.UseVisualStyleBackColor = false;
            this.DeleteLecturerButton.Click += new System.EventHandler(this.DeleteLecturerButton_Click);
            // 
            // AddLecturerButton
            // 
            this.AddLecturerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddLecturerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLecturerButton.Location = new System.Drawing.Point(124, 366);
            this.AddLecturerButton.Name = "AddLecturerButton";
            this.AddLecturerButton.Size = new System.Drawing.Size(108, 29);
            this.AddLecturerButton.TabIndex = 17;
            this.AddLecturerButton.Text = "Add lecturer";
            this.AddLecturerButton.UseVisualStyleBackColor = false;
            this.AddLecturerButton.Click += new System.EventHandler(this.AddLecturerButton_Click);
            // 
            // LecturerSubjectsButton
            // 
            this.LecturerSubjectsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LecturerSubjectsButton.Enabled = false;
            this.LecturerSubjectsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LecturerSubjectsButton.Location = new System.Drawing.Point(247, 366);
            this.LecturerSubjectsButton.Name = "LecturerSubjectsButton";
            this.LecturerSubjectsButton.Size = new System.Drawing.Size(108, 29);
            this.LecturerSubjectsButton.TabIndex = 16;
            this.LecturerSubjectsButton.Text = "Subjects";
            this.LecturerSubjectsButton.UseVisualStyleBackColor = false;
            this.LecturerSubjectsButton.Click += new System.EventHandler(this.LecturerSubjectsButton_Click);
            // 
            // lecturersListView
            // 
            this.lecturersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_name,
            this.ch_surname,
            this.ch_username,
            this.ch_birthdate,
            this.ch_id});
            this.lecturersListView.FullRowSelect = true;
            this.lecturersListView.HideSelection = false;
            this.lecturersListView.Location = new System.Drawing.Point(17, 4);
            this.lecturersListView.Margin = new System.Windows.Forms.Padding(4);
            this.lecturersListView.MultiSelect = false;
            this.lecturersListView.Name = "lecturersListView";
            this.lecturersListView.Size = new System.Drawing.Size(566, 344);
            this.lecturersListView.TabIndex = 15;
            this.lecturersListView.UseCompatibleStateImageBehavior = false;
            this.lecturersListView.View = System.Windows.Forms.View.Details;
            this.lecturersListView.SelectedIndexChanged += new System.EventHandler(this.lecturersListView_SelectedIndexChanged);
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
            // AdminLecturersController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.DeleteLecturerButton);
            this.Controls.Add(this.AddLecturerButton);
            this.Controls.Add(this.LecturerSubjectsButton);
            this.Controls.Add(this.lecturersListView);
            this.Name = "AdminLecturersController";
            this.Size = new System.Drawing.Size(587, 494);
            this.Load += new System.EventHandler(this.AdminLecturersController_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DeleteLecturerButton;
        private System.Windows.Forms.Button AddLecturerButton;
        private System.Windows.Forms.Button LecturerSubjectsButton;
        private System.Windows.Forms.ListView lecturersListView;
        private System.Windows.Forms.ColumnHeader ch_name;
        private System.Windows.Forms.ColumnHeader ch_surname;
        private System.Windows.Forms.ColumnHeader ch_username;
        private System.Windows.Forms.ColumnHeader ch_birthdate;
        private System.Windows.Forms.ColumnHeader ch_id;
    }
}
