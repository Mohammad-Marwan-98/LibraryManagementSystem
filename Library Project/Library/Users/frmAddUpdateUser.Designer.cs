namespace Library
{
	partial class frmAddUpdateUser
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
			this.tabCompleteInfo = new System.Windows.Forms.TabControl();
			this.tbPersonalInfo = new System.Windows.Forms.TabPage();
			this.ctrlAddUpdatePersonInfo1 = new Library.ctrlAddUpdatePersonInfo();
			this.btnNext = new System.Windows.Forms.Button();
			this.tbReaderInfo = new System.Windows.Forms.TabPage();
			this.gbPermissions = new System.Windows.Forms.GroupBox();
			this.chkReservations = new System.Windows.Forms.CheckBox();
			this.chkFullAccess = new System.Windows.Forms.CheckBox();
			this.chkManageSettings = new System.Windows.Forms.CheckBox();
			this.chkManagePayments = new System.Windows.Forms.CheckBox();
			this.chkManageBorrows = new System.Windows.Forms.CheckBox();
			this.chkManageUsers = new System.Windows.Forms.CheckBox();
			this.chkManageReaders = new System.Windows.Forms.CheckBox();
			this.chkManageBooks = new System.Windows.Forms.CheckBox();
			this.chkIsActive = new System.Windows.Forms.CheckBox();
			this.txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
			this.pbConfirmPassword = new System.Windows.Forms.PictureBox();
			this.lblConfirmPassword = new System.Windows.Forms.Label();
			this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
			this.pbPassword = new System.Windows.Forms.PictureBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.lblUserID = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.pbMode = new Guna.UI2.WinForms.Guna2PictureBox();
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.tabCompleteInfo.SuspendLayout();
			this.tbPersonalInfo.SuspendLayout();
			this.tbReaderInfo.SuspendLayout();
			this.gbPermissions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbConfirmPassword)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbMode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// tabCompleteInfo
			// 
			this.tabCompleteInfo.Controls.Add(this.tbPersonalInfo);
			this.tabCompleteInfo.Controls.Add(this.tbReaderInfo);
			this.tabCompleteInfo.Location = new System.Drawing.Point(19, 12);
			this.tabCompleteInfo.Name = "tabCompleteInfo";
			this.tabCompleteInfo.SelectedIndex = 0;
			this.tabCompleteInfo.Size = new System.Drawing.Size(1055, 661);
			this.tabCompleteInfo.TabIndex = 1;
			// 
			// tbPersonalInfo
			// 
			this.tbPersonalInfo.BackColor = System.Drawing.SystemColors.Control;
			this.tbPersonalInfo.Controls.Add(this.ctrlAddUpdatePersonInfo1);
			this.tbPersonalInfo.Controls.Add(this.btnNext);
			this.tbPersonalInfo.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbPersonalInfo.Location = new System.Drawing.Point(4, 25);
			this.tbPersonalInfo.Name = "tbPersonalInfo";
			this.tbPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
			this.tbPersonalInfo.Size = new System.Drawing.Size(1047, 632);
			this.tbPersonalInfo.TabIndex = 0;
			this.tbPersonalInfo.Text = "Personal Info";
			// 
			// ctrlAddUpdatePersonInfo1
			// 
			this.ctrlAddUpdatePersonInfo1.Location = new System.Drawing.Point(3, 3);
			this.ctrlAddUpdatePersonInfo1.Name = "ctrlAddUpdatePersonInfo1";
			this.ctrlAddUpdatePersonInfo1.Size = new System.Drawing.Size(1002, 568);
			this.ctrlAddUpdatePersonInfo1.TabIndex = 11;
			// 
			// btnNext
			// 
			this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNext.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNext.Image = global::Library.Properties.Resources.Next2;
			this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNext.Location = new System.Drawing.Point(785, 575);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(143, 47);
			this.btnNext.TabIndex = 10;
			this.btnNext.Text = "Next";
			this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// tbReaderInfo
			// 
			this.tbReaderInfo.BackColor = System.Drawing.SystemColors.Control;
			this.tbReaderInfo.Controls.Add(this.gbPermissions);
			this.tbReaderInfo.Controls.Add(this.chkIsActive);
			this.tbReaderInfo.Controls.Add(this.txtConfirmPassword);
			this.tbReaderInfo.Controls.Add(this.pbConfirmPassword);
			this.tbReaderInfo.Controls.Add(this.lblConfirmPassword);
			this.tbReaderInfo.Controls.Add(this.txtPassword);
			this.tbReaderInfo.Controls.Add(this.pbPassword);
			this.tbReaderInfo.Controls.Add(this.lblPassword);
			this.tbReaderInfo.Controls.Add(this.txtUsername);
			this.tbReaderInfo.Controls.Add(this.pictureBox1);
			this.tbReaderInfo.Controls.Add(this.label1);
			this.tbReaderInfo.Controls.Add(this.btnClose);
			this.tbReaderInfo.Controls.Add(this.btnSave);
			this.tbReaderInfo.Controls.Add(this.lblUserID);
			this.tbReaderInfo.Controls.Add(this.label10);
			this.tbReaderInfo.Controls.Add(this.lblTitle);
			this.tbReaderInfo.Controls.Add(this.pbMode);
			this.tbReaderInfo.Controls.Add(this.guna2PictureBox1);
			this.tbReaderInfo.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbReaderInfo.Location = new System.Drawing.Point(4, 25);
			this.tbReaderInfo.Name = "tbReaderInfo";
			this.tbReaderInfo.Padding = new System.Windows.Forms.Padding(3);
			this.tbReaderInfo.Size = new System.Drawing.Size(1047, 632);
			this.tbReaderInfo.TabIndex = 1;
			this.tbReaderInfo.Text = "User Info";
			this.tbReaderInfo.Enter += new System.EventHandler(this.tbReaderInfo_Enter);
			// 
			// gbPermissions
			// 
			this.gbPermissions.Controls.Add(this.chkReservations);
			this.gbPermissions.Controls.Add(this.chkFullAccess);
			this.gbPermissions.Controls.Add(this.chkManageSettings);
			this.gbPermissions.Controls.Add(this.chkManagePayments);
			this.gbPermissions.Controls.Add(this.chkManageBorrows);
			this.gbPermissions.Controls.Add(this.chkManageUsers);
			this.gbPermissions.Controls.Add(this.chkManageReaders);
			this.gbPermissions.Controls.Add(this.chkManageBooks);
			this.gbPermissions.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbPermissions.Location = new System.Drawing.Point(46, 384);
			this.gbPermissions.Name = "gbPermissions";
			this.gbPermissions.Size = new System.Drawing.Size(737, 242);
			this.gbPermissions.TabIndex = 162;
			this.gbPermissions.TabStop = false;
			this.gbPermissions.Text = "Permissions";
			// 
			// chkReservations
			// 
			this.chkReservations.AutoSize = true;
			this.chkReservations.Checked = true;
			this.chkReservations.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkReservations.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkReservations.Location = new System.Drawing.Point(385, 195);
			this.chkReservations.Name = "chkReservations";
			this.chkReservations.Size = new System.Drawing.Size(326, 43);
			this.chkReservations.TabIndex = 11;
			this.chkReservations.Tag = "64";
			this.chkReservations.Text = "Manage Reservations";
			this.chkReservations.UseVisualStyleBackColor = true;
			this.chkReservations.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
			// 
			// chkFullAccess
			// 
			this.chkFullAccess.AutoSize = true;
			this.chkFullAccess.Checked = true;
			this.chkFullAccess.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkFullAccess.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkFullAccess.Location = new System.Drawing.Point(32, 27);
			this.chkFullAccess.Name = "chkFullAccess";
			this.chkFullAccess.Size = new System.Drawing.Size(191, 43);
			this.chkFullAccess.TabIndex = 4;
			this.chkFullAccess.Tag = "-1";
			this.chkFullAccess.Text = "Full Access";
			this.chkFullAccess.UseVisualStyleBackColor = true;
			this.chkFullAccess.CheckedChanged += new System.EventHandler(this.chkFullAccess_CheckedChanged);
			// 
			// chkManageSettings
			// 
			this.chkManageSettings.AutoSize = true;
			this.chkManageSettings.Checked = true;
			this.chkManageSettings.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkManageSettings.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkManageSettings.Location = new System.Drawing.Point(385, 139);
			this.chkManageSettings.Name = "chkManageSettings";
			this.chkManageSettings.Size = new System.Drawing.Size(267, 43);
			this.chkManageSettings.TabIndex = 10;
			this.chkManageSettings.Tag = "32";
			this.chkManageSettings.Text = "Manage Settings";
			this.chkManageSettings.UseVisualStyleBackColor = true;
			this.chkManageSettings.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
			// 
			// chkManagePayments
			// 
			this.chkManagePayments.AutoSize = true;
			this.chkManagePayments.Checked = true;
			this.chkManagePayments.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkManagePayments.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkManagePayments.Location = new System.Drawing.Point(385, 83);
			this.chkManagePayments.Name = "chkManagePayments";
			this.chkManagePayments.Size = new System.Drawing.Size(280, 43);
			this.chkManagePayments.TabIndex = 9;
			this.chkManagePayments.Tag = "16";
			this.chkManagePayments.Text = "Manage Payments";
			this.chkManagePayments.UseVisualStyleBackColor = true;
			this.chkManagePayments.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
			// 
			// chkManageBorrows
			// 
			this.chkManageBorrows.AutoSize = true;
			this.chkManageBorrows.Checked = true;
			this.chkManageBorrows.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkManageBorrows.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkManageBorrows.Location = new System.Drawing.Point(385, 27);
			this.chkManageBorrows.Name = "chkManageBorrows";
			this.chkManageBorrows.Size = new System.Drawing.Size(261, 43);
			this.chkManageBorrows.TabIndex = 8;
			this.chkManageBorrows.Tag = "8";
			this.chkManageBorrows.Text = "Manage Borrows";
			this.chkManageBorrows.UseVisualStyleBackColor = true;
			this.chkManageBorrows.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
			// 
			// chkManageUsers
			// 
			this.chkManageUsers.AutoSize = true;
			this.chkManageUsers.Checked = true;
			this.chkManageUsers.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkManageUsers.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkManageUsers.Location = new System.Drawing.Point(32, 195);
			this.chkManageUsers.Name = "chkManageUsers";
			this.chkManageUsers.Size = new System.Drawing.Size(232, 43);
			this.chkManageUsers.TabIndex = 7;
			this.chkManageUsers.Tag = "4";
			this.chkManageUsers.Text = "Manage Users";
			this.chkManageUsers.UseVisualStyleBackColor = true;
			this.chkManageUsers.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
			// 
			// chkManageReaders
			// 
			this.chkManageReaders.AutoSize = true;
			this.chkManageReaders.Checked = true;
			this.chkManageReaders.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkManageReaders.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkManageReaders.Location = new System.Drawing.Point(32, 139);
			this.chkManageReaders.Name = "chkManageReaders";
			this.chkManageReaders.Size = new System.Drawing.Size(263, 43);
			this.chkManageReaders.TabIndex = 6;
			this.chkManageReaders.Tag = "2";
			this.chkManageReaders.Text = "Manage Readers";
			this.chkManageReaders.UseVisualStyleBackColor = true;
			this.chkManageReaders.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
			// 
			// chkManageBooks
			// 
			this.chkManageBooks.AutoSize = true;
			this.chkManageBooks.Checked = true;
			this.chkManageBooks.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkManageBooks.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkManageBooks.Location = new System.Drawing.Point(32, 83);
			this.chkManageBooks.Name = "chkManageBooks";
			this.chkManageBooks.Size = new System.Drawing.Size(231, 43);
			this.chkManageBooks.TabIndex = 5;
			this.chkManageBooks.Tag = "1";
			this.chkManageBooks.Text = "Manage Books";
			this.chkManageBooks.UseVisualStyleBackColor = true;
			this.chkManageBooks.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
			// 
			// chkIsActive
			// 
			this.chkIsActive.AutoSize = true;
			this.chkIsActive.Checked = true;
			this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkIsActive.Enabled = false;
			this.chkIsActive.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkIsActive.Location = new System.Drawing.Point(519, 251);
			this.chkIsActive.Name = "chkIsActive";
			this.chkIsActive.Size = new System.Drawing.Size(165, 43);
			this.chkIsActive.TabIndex = 147;
			this.chkIsActive.Text = "Is Active";
			this.chkIsActive.UseVisualStyleBackColor = true;
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
			this.txtConfirmPassword.Location = new System.Drawing.Point(804, 319);
			this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtConfirmPassword.Name = "txtConfirmPassword";
			this.txtConfirmPassword.PasswordChar = '*';
			this.txtConfirmPassword.PlaceholderText = "";
			this.txtConfirmPassword.SelectedText = "";
			this.txtConfirmPassword.Size = new System.Drawing.Size(177, 37);
			this.txtConfirmPassword.TabIndex = 3;
			this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
			// 
			// pbConfirmPassword
			// 
			this.pbConfirmPassword.Image = global::Library.Properties.Resources.Confirm;
			this.pbConfirmPassword.Location = new System.Drawing.Point(757, 324);
			this.pbConfirmPassword.Name = "pbConfirmPassword";
			this.pbConfirmPassword.Size = new System.Drawing.Size(26, 26);
			this.pbConfirmPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbConfirmPassword.TabIndex = 144;
			this.pbConfirmPassword.TabStop = false;
			// 
			// lblConfirmPassword
			// 
			this.lblConfirmPassword.AutoSize = true;
			this.lblConfirmPassword.BackColor = System.Drawing.SystemColors.Control;
			this.lblConfirmPassword.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConfirmPassword.ForeColor = System.Drawing.Color.Black;
			this.lblConfirmPassword.Location = new System.Drawing.Point(484, 317);
			this.lblConfirmPassword.Name = "lblConfirmPassword";
			this.lblConfirmPassword.Size = new System.Drawing.Size(267, 39);
			this.lblConfirmPassword.TabIndex = 143;
			this.lblConfirmPassword.Text = "Confirm Password:";
			// 
			// txtPassword
			// 
			this.txtPassword.AutoRoundedCorners = true;
			this.txtPassword.BorderRadius = 17;
			this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPassword.DefaultText = "";
			this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPassword.Location = new System.Drawing.Point(266, 317);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.PlaceholderText = "";
			this.txtPassword.SelectedText = "";
			this.txtPassword.Size = new System.Drawing.Size(177, 37);
			this.txtPassword.TabIndex = 2;
			this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
			// 
			// pbPassword
			// 
			this.pbPassword.Image = global::Library.Properties.Resources.password;
			this.pbPassword.Location = new System.Drawing.Point(219, 323);
			this.pbPassword.Name = "pbPassword";
			this.pbPassword.Size = new System.Drawing.Size(26, 26);
			this.pbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbPassword.TabIndex = 141;
			this.pbPassword.TabStop = false;
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.BackColor = System.Drawing.SystemColors.Control;
			this.lblPassword.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPassword.ForeColor = System.Drawing.Color.Black;
			this.lblPassword.Location = new System.Drawing.Point(62, 317);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(151, 39);
			this.lblPassword.TabIndex = 140;
			this.lblPassword.Text = "Password:";
			// 
			// txtUsername
			// 
			this.txtUsername.AutoRoundedCorners = true;
			this.txtUsername.BorderRadius = 17;
			this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtUsername.DefaultText = "";
			this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtUsername.Location = new System.Drawing.Point(266, 255);
			this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.PasswordChar = '\0';
			this.txtUsername.PlaceholderText = "";
			this.txtUsername.SelectedText = "";
			this.txtUsername.Size = new System.Drawing.Size(177, 37);
			this.txtUsername.TabIndex = 1;
			this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Library.Properties.Resources.Name1;
			this.pictureBox1.Location = new System.Drawing.Point(219, 262);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(26, 26);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 138;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(51, 255);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(162, 39);
			this.label1.TabIndex = 137;
			this.label1.Text = "Username:";
			// 
			// btnClose
			// 
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = global::Library.Properties.Resources.Closebtn;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(846, 547);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(143, 47);
			this.btnClose.TabIndex = 12;
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
			this.btnSave.Location = new System.Drawing.Point(846, 486);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(143, 47);
			this.btnSave.TabIndex = 11;
			this.btnSave.Text = "Save";
			this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// lblUserID
			// 
			this.lblUserID.AutoSize = true;
			this.lblUserID.BackColor = System.Drawing.SystemColors.Control;
			this.lblUserID.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUserID.ForeColor = System.Drawing.Color.MediumVioletRed;
			this.lblUserID.Location = new System.Drawing.Point(178, 198);
			this.lblUserID.Name = "lblUserID";
			this.lblUserID.Size = new System.Drawing.Size(49, 39);
			this.lblUserID.TabIndex = 100;
			this.lblUserID.Text = "??";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.SystemColors.Control;
			this.label10.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(35, 196);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(140, 39);
			this.label10.TabIndex = 99;
			this.label10.Text = "User ID:";
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.BackColor = System.Drawing.SystemColors.Control;
			this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.SteelBlue;
			this.lblTitle.Location = new System.Drawing.Point(371, 153);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(308, 55);
			this.lblTitle.TabIndex = 5;
			this.lblTitle.Text = "Add User Info";
			// 
			// pbMode
			// 
			this.pbMode.BackColor = System.Drawing.Color.Transparent;
			this.pbMode.Image = global::Library.Properties.Resources.Add64_2_;
			this.pbMode.ImageRotate = 0F;
			this.pbMode.Location = new System.Drawing.Point(530, 73);
			this.pbMode.Name = "pbMode";
			this.pbMode.Size = new System.Drawing.Size(60, 70);
			this.pbMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbMode.TabIndex = 4;
			this.pbMode.TabStop = false;
			this.pbMode.UseTransparentBackground = true;
			// 
			// guna2PictureBox1
			// 
			this.guna2PictureBox1.Image = global::Library.Properties.Resources.Person;
			this.guna2PictureBox1.ImageRotate = 0F;
			this.guna2PictureBox1.Location = new System.Drawing.Point(466, 11);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.Size = new System.Drawing.Size(115, 116);
			this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.guna2PictureBox1.TabIndex = 3;
			this.guna2PictureBox1.TabStop = false;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// frmAddUpdateUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1092, 685);
			this.Controls.Add(this.tabCompleteInfo);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmAddUpdateUser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmAddUpdateUser";
			this.Load += new System.EventHandler(this.frmAddUpdateUser_Load);
			this.tabCompleteInfo.ResumeLayout(false);
			this.tbPersonalInfo.ResumeLayout(false);
			this.tbReaderInfo.ResumeLayout(false);
			this.tbReaderInfo.PerformLayout();
			this.gbPermissions.ResumeLayout(false);
			this.gbPermissions.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbConfirmPassword)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbMode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabCompleteInfo;
		private System.Windows.Forms.TabPage tbPersonalInfo;
		private ctrlAddUpdatePersonInfo ctrlAddUpdatePersonInfo1;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.TabPage tbReaderInfo;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label lblUserID;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label lblTitle;
		private Guna.UI2.WinForms.Guna2PictureBox pbMode;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2TextBox txtUsername;
		private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
		private System.Windows.Forms.PictureBox pbConfirmPassword;
		private System.Windows.Forms.Label lblConfirmPassword;
		private Guna.UI2.WinForms.Guna2TextBox txtPassword;
		private System.Windows.Forms.PictureBox pbPassword;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.CheckBox chkIsActive;
		private System.Windows.Forms.CheckBox chkManageReaders;
		private System.Windows.Forms.CheckBox chkManageBooks;
		private System.Windows.Forms.GroupBox gbPermissions;
		private System.Windows.Forms.CheckBox chkFullAccess;
		private System.Windows.Forms.CheckBox chkManageSettings;
		private System.Windows.Forms.CheckBox chkManagePayments;
		private System.Windows.Forms.CheckBox chkManageBorrows;
		private System.Windows.Forms.CheckBox chkManageUsers;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.CheckBox chkReservations;
	}
}