namespace Uzduotis.Frontend.Controllers.StudentControllers
{
    partial class StudentGradesController
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
            this.gradesListView.TabIndex = 19;
            this.gradesListView.UseCompatibleStateImageBehavior = false;
            this.gradesListView.View = System.Windows.Forms.View.Details;
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
            // StudentGradesController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.gradesListView);
            this.Name = "StudentGradesController";
            this.Size = new System.Drawing.Size(574, 429);
            this.Load += new System.EventHandler(this.StudentGradesController_Load);
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.ColumnHeader workTitle;
        protected System.Windows.Forms.ColumnHeader gradeValue;
        protected System.Windows.Forms.ListView gradesListView;
    }
}
