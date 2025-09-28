namespace Library
{
	partial class frmChangePassword
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
			this.chkIsActive = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblUserID = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.lblUsername = new System.Windows.Forms.Label();
			this.gbUserInfo = new System.Windows.Forms.GroupBox();
			this.txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
			this.lblConfirmPassword = new System.Windows.Forms.Label();
			this.txtCurrentPassword = new Guna.UI2.WinForms.Guna2TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.txtNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pbConfirmPassword = new System.Windows.Forms.PictureBox();
			this.pbPassword = new System.Windows.Forms.PictureBox();
			this.gbUserInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbConfirmPassword)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
			this.SuspendLayout();
			// 
			// chkIsActive
			// 
			this.chkIsActive.AutoSize = true;
			this.chkIsActive.Checked = true;
			this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkIsActive.Enabled = false;
			this.chkIsActive.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkIsActive.Location = new System.Drawing.Point(639, 37);
			this.chkIsActive.Name = "chkIsActive";
			this.chkIsActive.Size = new System.Drawing.Size(165, 43);
			this.chkIsActive.TabIndex = 107;
			this.chkIsActive.Text = "Is Active";
			this.chkIsActive.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(277, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(162, 39);
			this.label1.TabIndex = 142;
			this.label1.Text = "Username:";
			// 
			// lblUserID
			// 
			this.lblUserID.AutoSize = true;
			this.lblUserID.BackColor = System.Drawing.SystemColors.Control;
			this.lblUserID.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUserID.ForeColor = System.Drawing.Color.MediumVioletRed;
			this.lblUserID.Location = new System.Drawing.Point(155, 40);
			this.lblUserID.Name = "lblUserID";
			this.lblUserID.Size = new System.Drawing.Size(49, 39);
			this.lblUserID.TabIndex = 141;
			this.lblUserID.Text = "??";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.SystemColors.Control;
			this.label10.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(12, 38);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(140, 39);
			this.label10.TabIndex = 140;
			this.label10.Text = "User ID:";
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.BackColor = System.Drawing.SystemColors.Control;
			this.lblUsername.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsername.ForeColor = System.Drawing.Color.MediumVioletRed;
			this.lblUsername.Location = new System.Drawing.Point(445, 40);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(49, 39);
			this.lblUsername.TabIndex = 143;
			this.lblUsername.Text = "??";
			// 
			// gbUserInfo
			// 
			this.gbUserInfo.Controls.Add(this.lblUsername);
			this.gbUserInfo.Controls.Add(this.label1);
			this.gbUserInfo.Controls.Add(this.lblUserID);
			this.gbUserInfo.Controls.Add(this.label10);
			this.gbUserInfo.Controls.Add(this.chkIsActive);
			this.gbUserInfo.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbUserInfo.Location = new System.Drawing.Point(6, 47);
			this.gbUserInfo.Name = "gbUserInfo";
			this.gbUserInfo.Size = new System.Drawing.Size(824, 119);
			this.gbUserInfo.TabIndex = 144;
			this.gbUserInfo.TabStop = false;
			this.gbUserInfo.Text = "UserInfo";
			// 
			// txtConfirmPassword
			// 
			this.txtConfirmPassword.AutoRoundedCorners = true;
			this.txtConfirmPassword.BorderRadius = 17;
			this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtConfirmPassword.DefaultText = "";
			this.txtConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtConfirmPassword.Location = new System.Drawing.Point(332, 357);
			this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtConfirmPassword.Name = "txtConfirmPassword";
			this.txtConfirmPassword.PasswordChar = '*';
			this.txtConfirmPassword.PlaceholderText = "";
			this.txtConfirmPassword.SelectedText = "";
			this.txtConfirmPassword.Size = new System.Drawing.Size(177, 37);
			this.txtConfirmPassword.TabIndex = 3;
			// 
			// lblConfirmPassword
			// 
			this.lblConfirmPassword.AutoSize = true;
			this.lblConfirmPassword.BackColor = System.Drawing.SystemColors.Control;
			this.lblConfirmPassword.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConfirmPassword.ForeColor = System.Drawing.Color.Black;
			this.lblConfirmPassword.Location = new System.Drawing.Point(12, 355);
			this.lblConfirmPassword.Name = "lblConfirmPassword";
			this.lblConfirmPassword.Size = new System.Drawing.Size(267, 39);
			this.lblConfirmPassword.TabIndex = 149;
			this.lblConfirmPassword.Text = "Confirm Password:";
			// 
			// txtCurrentPassword
			// 
			this.txtCurrentPassword.AutoRoundedCorners = true;
			this.txtCurrentPassword.BorderRadius = 17;
			this.txtCurrentPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtCurrentPassword.DefaultText = "";
			this.txtCurrentPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtCurrentPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtCurrentPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtCurrentPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtCurrentPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtCurrentPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtCurrentPassword.Location = new System.Drawing.Point(332, 209);
			this.txtCurrentPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtCurrentPassword.Name = "txtCurrentPassword";
			this.txtCurrentPassword.PasswordChar = '*';
			this.txtCurrentPassword.PlaceholderText = "";
			this.txtCurrentPassword.SelectedText = "";
			this.txtCurrentPassword.Size = new System.Drawing.Size(177, 37);
			this.txtCurrentPassword.TabIndex = 1;
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.BackColor = System.Drawing.SystemColors.Control;
			this.lblPassword.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPassword.ForeColor = System.Drawing.Color.Black;
			this.lblPassword.Location = new System.Drawing.Point(14, 209);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(265, 39);
			this.lblPassword.TabIndex = 147;
			this.lblPassword.Text = "Current Password:";
			// 
			// txtNewPassword
			// 
			this.txtNewPassword.AutoRoundedCorners = true;
			this.txtNewPassword.BorderRadius = 17;
			this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtNewPassword.DefaultText = "";
			this.txtNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtNewPassword.Location = new System.Drawing.Point(330, 283);
			this.txtNewPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtNewPassword.Name = "txtNewPassword";
			this.txtNewPassword.PasswordChar = '*';
			this.txtNewPassword.PlaceholderText = "";
			this.txtNewPassword.SelectedText = "";
			this.txtNewPassword.Size = new System.Drawing.Size(177, 37);
			this.txtNewPassword.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.Control;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(56, 281);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(221, 39);
			this.label2.TabIndex = 152;
			this.label2.Text = "New Password:";
			// 
			// btnClose
			// 
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = global::Library.Properties.Resources.Closebtn;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(667, 349);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(143, 47);
			this.btnClose.TabIndex = 5;
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
			this.btnSave.Location = new System.Drawing.Point(667, 288);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(143, 47);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "Save";
			this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Library.Properties.Resources._new;
			this.pictureBox1.Location = new System.Drawing.Point(283, 288);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(26, 26);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 153;
			this.pictureBox1.TabStop = false;
			// 
			// pbConfirmPassword
			// 
			this.pbConfirmPassword.Image = global::Library.Properties.Resources.Confirm;
			this.pbConfirmPassword.Location = new System.Drawing.Point(285, 361);
			this.pbConfirmPassword.Name = "pbConfirmPassword";
			this.pbConfirmPassword.Size = new System.Drawing.Size(26, 26);
			this.pbConfirmPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbConfirmPassword.TabIndex = 150;
			this.pbConfirmPassword.TabStop = false;
			// 
			// pbPassword
			// 
			this.pbPassword.Image = global::Library.Properties.Resources.password;
			this.pbPassword.Location = new System.Drawing.Point(285, 215);
			this.pbPassword.Name = "pbPassword";
			this.pbPassword.Size = new System.Drawing.Size(26, 26);
			this.pbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbPassword.TabIndex = 148;
			this.pbPassword.TabStop = false;
			// 
			// frmChangePassword
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(836, 418);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtNewPassword);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtConfirmPassword);
			this.Controls.Add(this.pbConfirmPassword);
			this.Controls.Add(this.lblConfirmPassword);
			this.Controls.Add(this.txtCurrentPassword);
			this.Controls.Add(this.pbPassword);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.gbUserInfo);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmChangePassword";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmChangePassword";
			this.Load += new System.EventHandler(this.frmChangePassword_Load);
			this.gbUserInfo.ResumeLayout(false);
			this.gbUserInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbConfirmPassword)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox chkIsActive;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblUserID;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.GroupBox gbUserInfo;
		private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
		private System.Windows.Forms.PictureBox pbConfirmPassword;
		private System.Windows.Forms.Label lblConfirmPassword;
		private Guna.UI2.WinForms.Guna2TextBox txtCurrentPassword;
		private System.Windows.Forms.PictureBox pbPassword;
		private System.Windows.Forms.Label lblPassword;
		private Guna.UI2.WinForms.Guna2TextBox txtNewPassword;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnSave;
	}
}