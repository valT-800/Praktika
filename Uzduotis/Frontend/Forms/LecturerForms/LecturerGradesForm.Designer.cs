namespace Uzduotis.Frontend.Forms.SystemForms
{
    partial class LecturerGradesForm
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
            this.gradesPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // gradesPanel
            // 
            this.gradesPanel.Location = new System.Drawing.Point(113, 62);
            this.gradesPanel.Name = "gradesPanel";
            this.gradesPanel.Size = new System.Drawing.Size(575, 402);
            this.gradesPanel.TabIndex = 0;
            // 
            // LecturerGradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(806, 503);
            this.Controls.Add(this.gradesPanel);
            this.Name = "LecturerGradesForm";
            this.Text = "LecturerGradesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gradesPanel;
    }
}