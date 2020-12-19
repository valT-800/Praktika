namespace Uzduotis.Frontend.Controllers.AdminControllers
{
    partial class AdminChangeGradeController
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
            this.newValueTextBox = new System.Windows.Forms.TextBox();
            this.ChangeGradeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "New value:";
            // 
            // newValueTextBox
            // 
            this.newValueTextBox.Location = new System.Drawing.Point(243, 23);
            this.newValueTextBox.Name = "newValueTextBox";
            this.newValueTextBox.Size = new System.Drawing.Size(84, 20);
            this.newValueTextBox.TabIndex = 2;
            // 
            // ChangeGradeButton
            // 
            this.ChangeGradeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ChangeGradeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeGradeButton.Location = new System.Drawing.Point(210, 60);
            this.ChangeGradeButton.Name = "ChangeGradeButton";
            this.ChangeGradeButton.Size = new System.Drawing.Size(74, 26);
            this.ChangeGradeButton.TabIndex = 24;
            this.ChangeGradeButton.Text = "Change";
            this.ChangeGradeButton.UseVisualStyleBackColor = false;
            this.ChangeGradeButton.Click += new System.EventHandler(this.ChangeGradeButton_Click);
            // 
            // AdminChangeGradeController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.ChangeGradeButton);
            this.Controls.Add(this.newValueTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AdminChangeGradeController";
            this.Size = new System.Drawing.Size(568, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newValueTextBox;
        protected System.Windows.Forms.Button ChangeGradeButton;
    }
}
