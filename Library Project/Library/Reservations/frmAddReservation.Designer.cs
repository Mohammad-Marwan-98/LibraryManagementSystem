namespace Library
{
	partial class frmAddReservation
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
			this.components = new System.ComponentModel.Container();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cbBooks = new Guna.UI2.WinForms.Guna2ComboBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.txtNotes = new Guna.UI2.WinForms.Guna2TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.chkIsActive = new System.Windows.Forms.CheckBox();
			this.lblReaderID = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtLibraryCardNumber = new Guna.UI2.WinForms.Guna2TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.lblReservationID = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.ctrlPersonDetails1 = new Library.ctrlPersonDetails();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = global::Library.Properties.Resources.Closebtn;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(1084, 644);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(143, 47);
			this.btnClose.TabIndex = 143;
			this.btnClose.Text = "Close";
			this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnSave
			// 
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Image = global::Library.Properties.Resources.Savebtn;
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new System.Drawing.Point(1263, 644);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(143, 47);
			this.btnSave.TabIndex = 136;
			this.btnSave.Text = "Save";
			this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cbBooks);
			this.groupBox2.Controls.Add(this.pictureBox3);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(32, 595);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1001, 141);
			this.groupBox2.TabIndex = 142;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Reservation Info";
			// 
			// cbBooks
			// 
			this.cbBooks.BackColor = System.Drawing.Color.Transparent;
			this.cbBooks.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbBooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbBooks.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbBooks.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbBooks.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbBooks.ItemHeight = 30;
			this.cbBooks.Location = new System.Drawing.Point(200, 42);
			this.cbBooks.Name = "cbBooks";
			this.cbBooks.Size = new System.Drawing.Size(364, 36);
			this.cbBooks.TabIndex = 133;
			this.cbBooks.Validating += new System.ComponentModel.CancelEventHandler(this.cbBooks_Validating);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::Library.Properties.Resources.Books;
			this.pictureBox3.Location = new System.Drawing.Point(136, 49);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(26, 26);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 132;
			this.pictureBox3.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.Control;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(27, 39);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 39);
			this.label3.TabIndex = 131;
			this.label3.Text = "Book:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.pictureBox2);
			this.groupBox1.Controls.Add(this.txtNotes);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.chkIsActive);
			this.groupBox1.Controls.Add(this.lblReaderID);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(27, 452);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1384, 131);
			this.groupBox1.TabIndex = 141;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Reader Info";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::Library.Properties.Resources.Notes;
			this.pictureBox2.Location = new System.Drawing.Point(744, 52);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(26, 26);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 132;
			this.pictureBox2.TabStop = false;
			// 
			// txtNotes
			// 
			this.txtNotes.AutoRoundedCorners = true;
			this.txtNotes.BorderRadius = 35;
			this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtNotes.DefaultText = "";
			this.txtNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtNotes.Location = new System.Drawing.Point(797, 44);
			this.txtNotes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtNotes.Multiline = true;
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.PasswordChar = '\0';
			this.txtNotes.PlaceholderText = "";
			this.txtNotes.ReadOnly = true;
			this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtNotes.SelectedText = "";
			this.txtNotes.Size = new System.Drawing.Size(473, 73);
			this.txtNotes.TabIndex = 130;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.Control;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(628, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 39);
			this.label2.TabIndex = 131;
			this.label2.Text = "Notes:";
			// 
			// chkIsActive
			// 
			this.chkIsActive.AutoSize = true;
			this.chkIsActive.Checked = true;
			this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkIsActive.Enabled = false;
			this.chkIsActive.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkIsActive.Location = new System.Drawing.Point(381, 43);
			this.chkIsActive.Name = "chkIsActive";
			this.chkIsActive.Size = new System.Drawing.Size(153, 43);
			this.chkIsActive.TabIndex = 129;
			this.chkIsActive.Text = "IsActive";
			this.chkIsActive.UseVisualStyleBackColor = true;
			// 
			// lblReaderID
			// 
			this.lblReaderID.AutoSize = true;
			this.lblReaderID.BackColor = System.Drawing.SystemColors.Control;
			this.lblReaderID.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblReaderID.ForeColor = System.Drawing.Color.MediumVioletRed;
			this.lblReaderID.Location = new System.Drawing.Point(249, 39);
			this.lblReaderID.Name = "lblReaderID";
			this.lblReaderID.Size = new System.Drawing.Size(49, 39);
			this.lblReaderID.TabIndex = 128;
			this.lblReaderID.Text = "??";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.SystemColors.Control;
			this.label6.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(72, 39);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(171, 39);
			this.label6.TabIndex = 127;
			this.label6.Text = "Reader ID:";
			// 
			// btnSearch
			// 
			this.btnSearch.Image = global::Library.Properties.Resources.Search32;
			this.btnSearch.Location = new System.Drawing.Point(461, 13);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(46, 44);
			this.btnSearch.TabIndex = 139;
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtLibraryCardNumber
			// 
			this.txtLibraryCardNumber.AutoRoundedCorners = true;
			this.txtLibraryCardNumber.BorderRadius = 18;
			this.txtLibraryCardNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtLibraryCardNumber.DefaultText = "";
			this.txtLibraryCardNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtLibraryCardNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtLibraryCardNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtLibraryCardNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtLibraryCardNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtLibraryCardNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtLibraryCardNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtLibraryCardNumber.Location = new System.Drawing.Point(254, 15);
			this.txtLibraryCardNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtLibraryCardNumber.Name = "txtLibraryCardNumber";
			this.txtLibraryCardNumber.PasswordChar = '\0';
			this.txtLibraryCardNumber.PlaceholderText = "";
			this.txtLibraryCardNumber.SelectedText = "";
			this.txtLibraryCardNumber.Size = new System.Drawing.Size(190, 38);
			this.txtLibraryCardNumber.TabIndex = 138;
			this.txtLibraryCardNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtLibraryCardNumber_Validating);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.SystemColors.Control;
			this.label10.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(52, 12);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(200, 39);
			this.label10.TabIndex = 137;
			this.label10.Text = "Library Card:";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// lblReservationID
			// 
			this.lblReservationID.AutoSize = true;
			this.lblReservationID.BackColor = System.Drawing.SystemColors.Control;
			this.lblReservationID.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblReservationID.ForeColor = System.Drawing.Color.MediumVioletRed;
			this.lblReservationID.Location = new System.Drawing.Point(947, 18);
			this.lblReservationID.Name = "lblReservationID";
			this.lblReservationID.Size = new System.Drawing.Size(49, 39);
			this.lblReservationID.TabIndex = 134;
			this.lblReservationID.Text = "??";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.SystemColors.Control;
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(707, 18);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(234, 39);
			this.label4.TabIndex = 133;
			this.label4.Text = "Reservation ID:";
			// 
			// ctrlPersonDetails1
			// 
			this.ctrlPersonDetails1.Location = new System.Drawing.Point(23, 75);
			this.ctrlPersonDetails1.Name = "ctrlPersonDetails1";
			this.ctrlPersonDetails1.Size = new System.Drawing.Size(1390, 371);
			this.ctrlPersonDetails1.TabIndex = 140;
			// 
			// frmAddReservation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1425, 916);
			this.Controls.Add(this.lblReservationID);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.ctrlPersonDetails1);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtLibraryCardNumber);
			this.Controls.Add(this.label10);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmAddReservation";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmAddReservation";
			this.Load += new System.EventHandler(this.frmAddReservation_Load);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.GroupBox groupBox2;
		private Guna.UI2.WinForms.Guna2ComboBox cbBooks;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private Guna.UI2.WinForms.Guna2TextBox txtNotes;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox chkIsActive;
		private System.Windows.Forms.Label lblReaderID;
		private System.Windows.Forms.Label label6;
		private ctrlPersonDetails ctrlPersonDetails1;
		private System.Windows.Forms.Button btnSearch;
		private Guna.UI2.WinForms.Guna2TextBox txtLibraryCardNumber;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Label lblReservationID;
		private System.Windows.Forms.Label label4;
	}
}