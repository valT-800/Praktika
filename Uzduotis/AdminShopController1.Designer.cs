
namespace Uzduotis
{
	partial class AdminShopController
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
			this.buttonAddCategory = new System.Windows.Forms.Button();
			this.buttonAddProduct = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonAddCategory
			// 
			this.buttonAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
			this.buttonAddCategory.FlatAppearance.BorderSize = 0;
			this.buttonAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAddCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAddCategory.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonAddCategory.Location = new System.Drawing.Point(170, 9);
			this.buttonAddCategory.Margin = new System.Windows.Forms.Padding(4);
			this.buttonAddCategory.Name = "buttonAddCategory";
			this.buttonAddCategory.Size = new System.Drawing.Size(110, 27);
			this.buttonAddCategory.TabIndex = 15;
			this.buttonAddCategory.Text = "Add Category";
			this.buttonAddCategory.UseVisualStyleBackColor = false;
			this.buttonAddCategory.Click += new System.EventHandler(this.ButtonAddCategory_Click);
			// 
			// buttonAddProduct
			// 
			this.buttonAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
			this.buttonAddProduct.FlatAppearance.BorderSize = 0;
			this.buttonAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAddProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAddProduct.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonAddProduct.Location = new System.Drawing.Point(288, 9);
			this.buttonAddProduct.Margin = new System.Windows.Forms.Padding(4);
			this.buttonAddProduct.Name = "buttonAddProduct";
			this.buttonAddProduct.Size = new System.Drawing.Size(109, 27);
			this.buttonAddProduct.TabIndex = 14;
			this.buttonAddProduct.Text = "Add Product";
			this.buttonAddProduct.UseVisualStyleBackColor = false;
			this.buttonAddProduct.Click += new System.EventHandler(this.ButtonAddProduct_Click);
			// 
			// AdminShopController1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.buttonAddCategory);
			this.Controls.Add(this.buttonAddProduct);
			this.Name = "AdminShopController1";
			this.Size = new System.Drawing.Size(595, 421);
			this.Controls.SetChildIndex(this.buttonAddProduct, 0);
			this.Controls.SetChildIndex(this.buttonAddCategory, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonAddCategory;
		private System.Windows.Forms.Button buttonAddProduct;
	}
}
