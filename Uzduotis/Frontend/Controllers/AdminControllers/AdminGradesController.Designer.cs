namespace Uzduotis.Frontend.Controllers.AdminControllers
{
    partial class AdminGradesController
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
            this.gradesListView = new System.Windows.Forms.ListView();
            this.workTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gradeValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.newGradePanel = new System.Windows.Forms.Panel();
            this.DeleteGradeButton = new System.Windows.Forms.Button();
            this.ChangeGradeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gradesListView
            // 
            this.gradesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.workTitle,
            this.gradeValue});
            this.gradesListView.HideSelection = false;
            this.gradesListView.Location = new System.Drawing.Point(3, 3);
            this.gradesListView.Name = "gradesListView";
            this.gradesListView.Size = new System.Drawing.Size(568, 253);
            this.gradesListView.TabIndex = 30;
            this.gradesListView.UseCompatibleStateImageBehavior = false;
            this.gradesListView.View = System.Windows.Forms.View.Details;
            this.gradesListView.SelectedIndexChanged += new System.EventHandler(this.gradesListView_SelectedIndexChanged);
            // 
            // workTitle
            // 
            this.workTitle.Text = "Work";
            this.workTitle.Width = 400;
            // 
            // gradeValue
            // 
            this.gradeValue.Text = "Grade";
            this.gradeValue.Width = 100;
            // 
            // newGradePanel
            // 
            this.newGradePanel.Location = new System.Drawing.Point(3, 294);
            this.newGradePanel.Name = "newGradePanel";
            this.newGradePanel.Size = new System.Drawing.Size(568, 100);
            this.newGradePanel.TabIndex = 29;
            // 
            // DeleteGradeButton
            // 
            this.DeleteGradeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DeleteGradeButton.Enabled = false;
            this.DeleteGradeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteGradeButton.Location = new System.Drawing.Point(497, 262);
            this.DeleteGradeButton.Name = "DeleteGradeButton";
            this.DeleteGradeButton.Size = new System.Drawing.Size(74, 26);
            this.DeleteGradeButton.TabIndex = 28;
            this.DeleteGradeButton.Text = "Delete";
            this.DeleteGradeButton.UseVisualStyleBackColor = false;
            this.DeleteGradeButton.Click += new System.EventHandler(this.DeleteGradeButton_Click);
            // 
            // ChangeGradeButton
            // 
            this.ChangeGradeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ChangeGradeButton.Enabled = false;
            this.ChangeGradeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeGradeButton.Location = new System.Drawing.Point(242, 262);
            this.ChangeGradeButton.Name = "ChangeGradeButton";
            this.ChangeGradeButton.Size = new System.Drawing.Size(74, 26);
            this.ChangeGradeButton.TabIndex = 27;
            this.ChangeGradeButton.Text = "Change";
            this.ChangeGradeButton.UseVisualStyleBackColor = false;
            this.ChangeGradeButton.Click += new System.EventHandler(this.ChangeGradeButton_Click);
            // 
            // AdminGradesController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.gradesListView);
            this.Controls.Add(this.newGradePanel);
            this.Controls.Add(this.DeleteGradeButton);
            this.Controls.Add(this.ChangeGradeButton);
            this.Name = "AdminGradesController";
            this.Size = new System.Drawing.Size(575, 402);
            this.Load += new System.EventHandler(this.AdminGradesController_Load);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.ListView gradesListView;
        protected System.Windows.Forms.ColumnHeader workTitle;
        protected System.Windows.Forms.ColumnHeader gradeValue;
        protected System.Windows.Forms.Panel newGradePanel;
        protected System.Windows.Forms.Button DeleteGradeButton;
        protected System.Windows.Forms.Button ChangeGradeButton;
    }
}
