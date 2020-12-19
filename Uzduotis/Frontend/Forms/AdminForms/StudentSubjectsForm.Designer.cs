namespace Uzduotis.Frontend.Forms.SystemForms
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
            this.studentGradesPanel = new System.Windows.Forms.Panel();
            this.subjectsPanel = new System.Windows.Forms.Panel();
            this.studentHeaderLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // studentGradesPanel
            // 
            this.studentGradesPanel.Location = new System.Drawing.Point(235, 72);
            this.studentGradesPanel.Name = "studentGradesPanel";
            this.studentGradesPanel.Size = new System.Drawing.Size(574, 429);
            this.studentGradesPanel.TabIndex = 3;
            // 
            // subjectsPanel
            // 
            this.subjectsPanel.Location = new System.Drawing.Point(12, 72);
            this.subjectsPanel.Name = "subjectsPanel";
            this.subjectsPanel.Size = new System.Drawing.Size(217, 429);
            this.subjectsPanel.TabIndex = 2;
            // 
            // studentHeaderLabel
            // 
            this.studentHeaderLabel.AutoSize = true;
            this.studentHeaderLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentHeaderLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.studentHeaderLabel.Location = new System.Drawing.Point(336, 9);
            this.studentHeaderLabel.Name = "studentHeaderLabel";
            this.studentHeaderLabel.Size = new System.Drawing.Size(165, 40);
            this.studentHeaderLabel.TabIndex = 4;
            this.studentHeaderLabel.Text = "Subjects";
            // 
            // StudentSubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(821, 512);
            this.Controls.Add(this.studentHeaderLabel);
            this.Controls.Add(this.studentGradesPanel);
            this.Controls.Add(this.subjectsPanel);
            this.Name = "StudentSubjectsForm";
            this.Text = "StudentSubjectsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Panel studentGradesPanel;
        protected System.Windows.Forms.Panel subjectsPanel;
        protected System.Windows.Forms.Label studentHeaderLabel;
    }
}