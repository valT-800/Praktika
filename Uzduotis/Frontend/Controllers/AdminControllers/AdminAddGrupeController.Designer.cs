namespace Uzduotis.Frontend.Controllers.AdminControllers
{
    partial class AdminAddGrupeController
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
            this.grupeTitleTextBox = new System.Windows.Forms.TextBox();
            this.AddGrupeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grupe Title:";
            // 
            // grupeTitleTextBox
            // 
            this.grupeTitleTextBox.Location = new System.Drawing.Point(86, 7);
            this.grupeTitleTextBox.Name = "grupeTitleTextBox";
            this.grupeTitleTextBox.Size = new System.Drawing.Size(122, 20);
            this.grupeTitleTextBox.TabIndex = 1;
            // 
            // AddGrupeButton
            // 
            this.AddGrupeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddGrupeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddGrupeButton.Location = new System.Drawing.Point(57, 43);
            this.AddGrupeButton.Name = "AddGrupeButton";
            this.AddGrupeButton.Size = new System.Drawing.Size(92, 29);
            this.AddGrupeButton.TabIndex = 16;
            this.AddGrupeButton.Text = "Add";
            this.AddGrupeButton.UseVisualStyleBackColor = false;
            this.AddGrupeButton.Click += new System.EventHandler(this.AddGrupeButton_Click);
            // 
            // AdminAddGrupeController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.AddGrupeButton);
            this.Controls.Add(this.grupeTitleTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AdminAddGrupeController";
            this.Size = new System.Drawing.Size(211, 75);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox grupeTitleTextBox;
        private System.Windows.Forms.Button AddGrupeButton;
    }
}
