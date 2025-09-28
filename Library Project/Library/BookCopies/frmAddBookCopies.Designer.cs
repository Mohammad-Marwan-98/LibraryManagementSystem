namespace Library
{
	partial class frmAddBookCopies
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
			this.label1 = new System.Windows.Forms.Label();
			this.nudCopies = new Guna.UI2.WinForms.Guna2NumericUpDown();
			this.btnSave = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.ctrlFindBook1 = new Library.Books.ctrlFindBook();
			((System.ComponentModel.ISupportInitialize)(this.nudCopies)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(97, 713);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(224, 39);
			this.label1.TabIndex = 54;
			this.label1.Text = "Copies To Add:";
			// 
			// nudCopies
			// 
			this.nudCopies.AutoRoundedCorners = true;
			this.nudCopies.BackColor = System.Drawing.Color.Transparent;
			this.nudCopies.BorderRadius = 17;
			this.nudCopies.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.nudCopies.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.nudCopies.Location = new System.Drawing.Point(386, 715);
			this.nudCopies.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.nudCopies.Name = "nudCopies";
			this.nudCopies.Size = new System.Drawing.Size(115, 37);
			this.nudCopies.TabIndex = 57;
			this.nudCopies.UpDownButtonFillColor = System.Drawing.Color.Teal;
			// 
			// btnSave
			// 
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Image = global::Library.Properties.Resources.Savebtn;
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new System.Drawing.Point(932, 717);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(143, 47);
			this.btnSave.TabIndex = 56;
			this.btnSave.Text = "Save";
			this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Library.Properties.Resources.copies32;
			this.pictureBox1.Location = new System.Drawing.Point(336, 724);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(26, 26);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 55;
			this.pictureBox1.TabStop = false;
			// 
			// btnClose
			// 
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = global::Library.Properties.Resources.Closebtn;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(759, 717);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(143, 47);
			this.btnClose.TabIndex = 58;
			this.btnClose.Text = "Close";
			this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// ctrlFindBook1
			// 
			this.ctrlFindBook1.Location = new System.Drawing.Point(12, 12);
			this.ctrlFindBook1.Name = "ctrlFindBook1";
			this.ctrlFindBook1.Size = new System.Drawing.Size(1173, 696);
			this.ctrlFindBook1.TabIndex = 0;
			// 
			// frmAddBookCopies
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1236, 819);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.nudCopies);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ctrlFindBook1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmAddBookCopies";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmAddBookCopies";
			this.Load += new System.EventHandler(this.frmAddBookCopies_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudCopies)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Books.ctrlFindBook ctrlFindBook1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSave;
		private Guna.UI2.WinForms.Guna2NumericUpDown nudCopies;
		private System.Windows.Forms.Button btnClose;
	}
}