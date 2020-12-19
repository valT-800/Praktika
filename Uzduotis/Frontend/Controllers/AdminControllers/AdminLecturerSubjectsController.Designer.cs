namespace Uzduotis.Frontend.Controllers.AdminControllers
{
    partial class AdminLecturerSubjectsController
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
            this.AddSubjectButton = new System.Windows.Forms.Button();
            this.subjectsListView = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subjectTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grupeId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.newSubjectPanel = new System.Windows.Forms.Panel();
            this.DeleteSubjectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddSubjectButton
            // 
            this.AddSubjectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddSubjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSubjectButton.Location = new System.Drawing.Point(122, 262);
            this.AddSubjectButton.Name = "AddSubjectButton";
            this.AddSubjectButton.Size = new System.Drawing.Size(74, 26);
            this.AddSubjectButton.TabIndex = 44;
            this.AddSubjectButton.Text = "Add";
            this.AddSubjectButton.UseVisualStyleBackColor = false;
            this.AddSubjectButton.Click += new System.EventHandler(this.AddSubjectButton_Click);
            // 
            // subjectsListView
            // 
            this.subjectsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.subjectTitle,
            this.grupeId});
            this.subjectsListView.FullRowSelect = true;
            this.subjectsListView.HideSelection = false;
            this.subjectsListView.Location = new System.Drawing.Point(3, 3);
            this.subjectsListView.MultiSelect = false;
            this.subjectsListView.Name = "subjectsListView";
            this.subjectsListView.Size = new System.Drawing.Size(424, 253);
            this.subjectsListView.TabIndex = 43;
            this.subjectsListView.UseCompatibleStateImageBehavior = false;
            this.subjectsListView.View = System.Windows.Forms.View.Details;
            this.subjectsListView.SelectedIndexChanged += new System.EventHandler(this.subjectsListView_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // subjectTitle
            // 
            this.subjectTitle.Text = "Subject";
            this.subjectTitle.Width = 300;
            // 
            // grupeId
            // 
            this.grupeId.Text = "Grupe ID";
            // 
            // newSubjectPanel
            // 
            this.newSubjectPanel.Location = new System.Drawing.Point(4, 294);
            this.newSubjectPanel.Name = "newSubjectPanel";
            this.newSubjectPanel.Size = new System.Drawing.Size(423, 100);
            this.newSubjectPanel.TabIndex = 42;
            // 
            // DeleteSubjectButton
            // 
            this.DeleteSubjectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DeleteSubjectButton.Enabled = false;
            this.DeleteSubjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSubjectButton.Location = new System.Drawing.Point(213, 262);
            this.DeleteSubjectButton.Name = "DeleteSubjectButton";
            this.DeleteSubjectButton.Size = new System.Drawing.Size(74, 26);
            this.DeleteSubjectButton.TabIndex = 41;
            this.DeleteSubjectButton.Text = "Delete";
            this.DeleteSubjectButton.UseVisualStyleBackColor = false;
            this.DeleteSubjectButton.Click += new System.EventHandler(this.DeleteSubjectButton_Click);
            // 
            // AdminLecturerSubjectsController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.AddSubjectButton);
            this.Controls.Add(this.subjectsListView);
            this.Controls.Add(this.newSubjectPanel);
            this.Controls.Add(this.DeleteSubjectButton);
            this.Name = "AdminLecturerSubjectsController";
            this.Size = new System.Drawing.Size(430, 396);
            this.Load += new System.EventHandler(this.AdminLecturerSubjectsController_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddSubjectButton;
        protected System.Windows.Forms.ColumnHeader id;
        protected System.Windows.Forms.ColumnHeader subjectTitle;
        private System.Windows.Forms.ColumnHeader grupeId;
        protected System.Windows.Forms.Panel newSubjectPanel;
        protected System.Windows.Forms.Button DeleteSubjectButton;
        private System.Windows.Forms.ListView subjectsListView;
    }
}
