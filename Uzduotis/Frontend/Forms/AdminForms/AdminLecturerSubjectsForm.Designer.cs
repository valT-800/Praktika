namespace Uzduotis.Frontend.Forms.AdminForms
{
    partial class AdminLecturerSubjectsForm
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
            this.subjectsPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // subjectsPanel
            // 
            this.subjectsPanel.Location = new System.Drawing.Point(2, 3);
            this.subjectsPanel.Name = "subjectsPanel";
            this.subjectsPanel.Size = new System.Drawing.Size(446, 441);
            this.subjectsPanel.TabIndex = 0;
            // 
            // AdminLecturerSubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(449, 450);
            this.Controls.Add(this.subjectsPanel);
            this.Name = "AdminLecturerSubjectsForm";
            this.Text = "AdminLecturerSubjectsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel subjectsPanel;
    }
}