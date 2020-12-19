namespace Uzduotis.Frontend.Controllers.AdminControllers
{
    partial class AdminAddSubjectController
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
            this.subjectTitleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grupesComboBox = new System.Windows.Forms.ComboBox();
            this.AddSubjectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // subjectTitleTextBox
            // 
            this.subjectTitleTextBox.Location = new System.Drawing.Point(123, 13);
            this.subjectTitleTextBox.Name = "subjectTitleTextBox";
            this.subjectTitleTextBox.Size = new System.Drawing.Size(211, 20);
            this.subjectTitleTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Grupe:";
            // 
            // grupesComboBox
            // 
            this.grupesComboBox.FormattingEnabled = true;
            this.grupesComboBox.Location = new System.Drawing.Point(123, 42);
            this.grupesComboBox.Name = "grupesComboBox";
            this.grupesComboBox.Size = new System.Drawing.Size(211, 21);
            this.grupesComboBox.TabIndex = 4;
            // 
            // AddSubjectButton
            // 
            this.AddSubjectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddSubjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSubjectButton.Location = new System.Drawing.Point(175, 69);
            this.AddSubjectButton.Name = "AddSubjectButton";
            this.AddSubjectButton.Size = new System.Drawing.Size(74, 26);
            this.AddSubjectButton.TabIndex = 41;
            this.AddSubjectButton.Text = "Add";
            this.AddSubjectButton.UseVisualStyleBackColor = false;
            this.AddSubjectButton.Click += new System.EventHandler(this.AddSubjectButton_Click);
            // 
            // AdminAddSubjectController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.AddSubjectButton);
            this.Controls.Add(this.grupesComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.subjectTitleTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AdminAddSubjectController";
            this.Size = new System.Drawing.Size(423, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox subjectTitleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox grupesComboBox;
        private System.Windows.Forms.Button AddSubjectButton;
    }
}
