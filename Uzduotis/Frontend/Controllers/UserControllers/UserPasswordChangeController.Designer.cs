namespace Uzduotis
{
	partial class UserPasswordChangeController
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
            this.labelOldPassword = new System.Windows.Forms.Label();
            this.textBoxPasswordMatch = new System.Windows.Forms.TextBox();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelOldPassword
            // 
            this.labelOldPassword.AutoSize = true;
            this.labelOldPassword.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOldPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelOldPassword.Location = new System.Drawing.Point(30, 7);
            this.labelOldPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelOldPassword.Name = "labelOldPassword";
            this.labelOldPassword.Size = new System.Drawing.Size(87, 15);
            this.labelOldPassword.TabIndex = 41;
            this.labelOldPassword.Text = "Old password:";
            // 
            // textBoxPasswordMatch
            // 
            this.textBoxPasswordMatch.BackColor = System.Drawing.Color.White;
            this.textBoxPasswordMatch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPasswordMatch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordMatch.ForeColor = System.Drawing.Color.Black;
            this.textBoxPasswordMatch.Location = new System.Drawing.Point(36, 40);
            this.textBoxPasswordMatch.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxPasswordMatch.Name = "textBoxPasswordMatch";
            this.textBoxPasswordMatch.Size = new System.Drawing.Size(431, 19);
            this.textBoxPasswordMatch.TabIndex = 40;
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonChangePassword.FlatAppearance.BorderSize = 0;
            this.buttonChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangePassword.ForeColor = System.Drawing.Color.Black;
            this.buttonChangePassword.Location = new System.Drawing.Point(203, 147);
            this.buttonChangePassword.Margin = new System.Windows.Forms.Padding(6);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(97, 32);
            this.buttonChangePassword.TabIndex = 48;
            this.buttonChangePassword.Text = "Confirm";
            this.buttonChangePassword.UseVisualStyleBackColor = false;
            this.buttonChangePassword.Click += new System.EventHandler(this.ButtonChangePassword_Click);
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelNewPassword.Location = new System.Drawing.Point(32, 74);
            this.labelNewPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(90, 15);
            this.labelNewPassword.TabIndex = 51;
            this.labelNewPassword.Text = "New password:";
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.BackColor = System.Drawing.Color.White;
            this.textBoxNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNewPassword.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewPassword.ForeColor = System.Drawing.Color.Black;
            this.textBoxNewPassword.Location = new System.Drawing.Point(36, 106);
            this.textBoxNewPassword.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(431, 19);
            this.textBoxNewPassword.TabIndex = 50;
            // 
            // UserPasswordChangeController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.buttonChangePassword);
            this.Controls.Add(this.labelNewPassword);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.labelOldPassword);
            this.Controls.Add(this.textBoxPasswordMatch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserPasswordChangeController";
            this.Size = new System.Drawing.Size(500, 200);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label labelOldPassword;
		public System.Windows.Forms.TextBox textBoxPasswordMatch;
		private System.Windows.Forms.Button buttonChangePassword;
		private System.Windows.Forms.Label labelNewPassword;
		public System.Windows.Forms.TextBox textBoxNewPassword;
    }
}
