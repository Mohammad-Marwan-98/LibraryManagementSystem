﻿namespace Library
{
	partial class frmShowBookDetails
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
			this.btnClose = new System.Windows.Forms.Button();
			this.ctrlBookDetails1 = new Library.ctrlBookDetails();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = global::Library.Properties.Resources.Closebtn;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(928, 714);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(143, 47);
			this.btnClose.TabIndex = 11;
			this.btnClose.Text = "Close";
			this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// ctrlBookDetails1
			// 
			this.ctrlBookDetails1.Location = new System.Drawing.Point(12, 9);
			this.ctrlBookDetails1.Name = "ctrlBookDetails1";
			this.ctrlBookDetails1.Size = new System.Drawing.Size(1113, 686);
			this.ctrlBookDetails1.TabIndex = 0;
			// 
			// frmShowBookDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1134, 786);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.ctrlBookDetails1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmShowBookDetails";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmShowBookDetails";
			this.Load += new System.EventHandler(this.frmShowBookDetails_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private ctrlBookDetails ctrlBookDetails1;
		private System.Windows.Forms.Button btnClose;
	}
}