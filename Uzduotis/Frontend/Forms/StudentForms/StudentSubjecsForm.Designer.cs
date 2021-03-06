﻿namespace Uzduotis.Frontend.Forms.SystemForms
{
    partial class StudentSubjectsForm
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
            this.studentGradesPanel = new System.Windows.Forms.Panel();
            this.subjectsPanel = new System.Windows.Forms.Panel();
            this.subjectsComboBox = new System.Windows.Forms.ComboBox();
            this.ViewGradesButton = new System.Windows.Forms.Button();
            this.subjectsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentHeaderLabel
            // 
            this.studentHeaderLabel.AutoSize = true;
            this.studentHeaderLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentHeaderLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.studentHeaderLabel.Location = new System.Drawing.Point(329, 5);
            this.studentHeaderLabel.Name = "studentHeaderLabel";
            this.studentHeaderLabel.Size = new System.Drawing.Size(165, 40);
            this.studentHeaderLabel.TabIndex = 10;
            this.studentHeaderLabel.Text = "Subjects";
            // 
            // studentGradesPanel
            // 
            this.studentGradesPanel.Location = new System.Drawing.Point(228, 68);
            this.studentGradesPanel.Name = "studentGradesPanel";
            this.studentGradesPanel.Size = new System.Drawing.Size(574, 429);
            this.studentGradesPanel.TabIndex = 9;
            // 
            // subjectsPanel
            // 
            this.subjectsPanel.Controls.Add(this.ViewGradesButton);
            this.subjectsPanel.Controls.Add(this.subjectsComboBox);
            this.subjectsPanel.Location = new System.Drawing.Point(5, 68);
            this.subjectsPanel.Name = "subjectsPanel";
            this.subjectsPanel.Size = new System.Drawing.Size(217, 429);
            this.subjectsPanel.TabIndex = 8;
            // 
            // subjectsComboBox
            // 
            this.subjectsComboBox.FormattingEnabled = true;
            this.subjectsComboBox.Location = new System.Drawing.Point(3, 14);
            this.subjectsComboBox.Name = "subjectsComboBox";
            this.subjectsComboBox.Size = new System.Drawing.Size(207, 21);
            this.subjectsComboBox.TabIndex = 0;
            // 
            // ViewGradesButton
            // 
            this.ViewGradesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ViewGradesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewGradesButton.Location = new System.Drawing.Point(52, 55);
            this.ViewGradesButton.Name = "ViewGradesButton";
            this.ViewGradesButton.Size = new System.Drawing.Size(111, 28);
            this.ViewGradesButton.TabIndex = 0;
            this.ViewGradesButton.Text = "View grades";
            this.ViewGradesButton.UseVisualStyleBackColor = false;
            this.ViewGradesButton.Click += new System.EventHandler(this.ViewGradesButton_Click);
            // 
            // StudentSubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(809, 503);
            this.Controls.Add(this.studentHeaderLabel);
            this.Controls.Add(this.studentGradesPanel);
            this.Controls.Add(this.subjectsPanel);
            this.Name = "StudentSubjectsForm";
            this.Text = "StudentSubjecsForm";
            this.subjectsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label studentHeaderLabel;
        protected System.Windows.Forms.Panel studentGradesPanel;
        private System.Windows.Forms.Panel subjectsPanel;
        private System.Windows.Forms.ComboBox subjectsComboBox;
        private System.Windows.Forms.Button ViewGradesButton;
    }
}