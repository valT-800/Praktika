namespace Uzduotis.Frontend.Controllers.LecturerControllers
{
    partial class LecturerAddGradeController
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.workTitleTextBox = new System.Windows.Forms.TextBox();
            this.gradeValueTextBox = new System.Windows.Forms.TextBox();
            this.AddGradeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Work Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grade:";
            // 
            // workTitleTextBox
            // 
            this.workTitleTextBox.Location = new System.Drawing.Point(195, 12);
            this.workTitleTextBox.Name = "workTitleTextBox";
            this.workTitleTextBox.Size = new System.Drawing.Size(199, 20);
            this.workTitleTextBox.TabIndex = 2;
            // 
            // gradeValueTextBox
            // 
            this.gradeValueTextBox.Location = new System.Drawing.Point(195, 43);
            this.gradeValueTextBox.Name = "gradeValueTextBox";
            this.gradeValueTextBox.Size = new System.Drawing.Size(199, 20);
            this.gradeValueTextBox.TabIndex = 3;
            // 
            // AddGradeButton
            // 
            this.AddGradeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddGradeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddGradeButton.Location = new System.Drawing.Point(246, 69);
            this.AddGradeButton.Name = "AddGradeButton";
            this.AddGradeButton.Size = new System.Drawing.Size(74, 26);
            this.AddGradeButton.TabIndex = 36;
            this.AddGradeButton.Text = "Add";
            this.AddGradeButton.UseVisualStyleBackColor = false;
            this.AddGradeButton.Click += new System.EventHandler(this.AddGradeButton_Click);
            // 
            // LecturerAddGradeController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.AddGradeButton);
            this.Controls.Add(this.gradeValueTextBox);
            this.Controls.Add(this.workTitleTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LecturerAddGradeController";
            this.Size = new System.Drawing.Size(568, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox workTitleTextBox;
        private System.Windows.Forms.TextBox gradeValueTextBox;
        private System.Windows.Forms.Button AddGradeButton;
    }
}
