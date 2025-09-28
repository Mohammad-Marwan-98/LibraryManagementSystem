namespace Library
{
	partial class frmAddUpdateReader
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
			this.tbReaderInfo = new System.Windows.Forms.TabPage();
			this.cbSubscriptionStatus = new Guna.UI2.WinForms.Guna2ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.chkIsActive = new System.Windows.Forms.CheckBox();
			this.lblLibraryCard = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.lblReaderID = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lblPersonID = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.dtpExpirtyDate = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.dtpJoinDate = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.cbSubscriptionPeriod = new Guna.UI2.WinForms.Guna2ComboBox();
			this.txtNotes = new Guna.UI2.WinForms.Guna2TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.btnNext = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pbMode = new Guna.UI2.WinForms.Guna2PictureBox();
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.ctrlAddUpdatePersonInfo1 = new Library.ctrlAddUpdatePersonInfo();
			this.tabCompleteInfo.SuspendLayout();
			this.tbPersonalInfo.SuspendLayout();
			this.tbReaderInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbMode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// tabCompleteInfo
			// 
			this.tabCompleteInfo.Controls.Add(this.tbPersonalInfo);
			this.tabCompleteInfo.Controls.Add(this.tbReaderInfo);
			this.tabCompleteInfo.Location = new System.Drawing.Point(12, 12);
			this.tabCompleteInfo.Name = "tabCompleteInfo";
			this.tabCompleteInfo.SelectedIndex = 0;
			this.tabCompleteInfo.Size = new System.Drawing.Size(1055, 661);
			this.tabCompleteInfo.TabIndex = 0;
			this.tabCompleteInfo.Validating += new System.ComponentModel.CancelEventHandler(this.tabCompleteInfo_Validating);
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
			// tbReaderInfo
			// 
			this.tbReaderInfo.BackColor = System.Drawing.SystemColors.Control;
			this.tbReaderInfo.Controls.Add(this.btnClose);
			this.tbReaderInfo.Controls.Add(this.btnSave);
			this.tbReaderInfo.Controls.Add(this.cbSubscriptionStatus);
			this.tbReaderInfo.Controls.Add(this.label11);
			this.tbReaderInfo.Controls.Add(this.chkIsActive);
			this.tbReaderInfo.Controls.Add(this.lblLibraryCard);
			this.tbReaderInfo.Controls.Add(this.label8);
			this.tbReaderInfo.Controls.Add(this.lblReaderID);
			this.tbReaderInfo.Controls.Add(this.label6);
			this.tbReaderInfo.Controls.Add(this.lblPersonID);
			this.tbReaderInfo.Controls.Add(this.label10);
			this.tbReaderInfo.Controls.Add(this.dtpExpirtyDate);
			this.tbReaderInfo.Controls.Add(this.label4);
			this.tbReaderInfo.Controls.Add(this.dtpJoinDate);
			this.tbReaderInfo.Controls.Add(this.label3);
			this.tbReaderInfo.Controls.Add(this.cbSubscriptionPeriod);
			this.tbReaderInfo.Controls.Add(this.txtNotes);
			this.tbReaderInfo.Controls.Add(this.label2);
			this.tbReaderInfo.Controls.Add(this.label1);
			this.tbReaderInfo.Controls.Add(this.lblTitle);
			this.tbReaderInfo.Controls.Add(this.pictureBox5);
			this.tbReaderInfo.Controls.Add(this.pictureBox4);
			this.tbReaderInfo.Controls.Add(this.pictureBox3);
			this.tbReaderInfo.Controls.Add(this.pictureBox2);
			this.tbReaderInfo.Controls.Add(this.pictureBox1);
			this.tbReaderInfo.Controls.Add(this.pbMode);
			this.tbReaderInfo.Controls.Add(this.guna2PictureBox1);
			this.tbReaderInfo.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbReaderInfo.Location = new System.Drawing.Point(4, 25);
			this.tbReaderInfo.Name = "tbReaderInfo";
			this.tbReaderInfo.Padding = new System.Windows.Forms.Padding(3);
			this.tbReaderInfo.Size = new System.Drawing.Size(1047, 632);
			this.tbReaderInfo.TabIndex = 1;
			this.tbReaderInfo.Text = "Reader Info";
			this.tbReaderInfo.Click += new System.EventHandler(this.tabPage2_Click);
			this.tbReaderInfo.Enter += new System.EventHandler(this.tbReaderInfo_Enter);
			// 
			// cbSubscriptionStatus
			// 
			this.cbSubscriptionStatus.BackColor = System.Drawing.Color.Transparent;
			this.cbSubscriptionStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbSubscriptionStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSubscriptionStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbSubscriptionStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbSubscriptionStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbSubscriptionStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbSubscriptionStatus.ItemHeight = 30;
			this.cbSubscriptionStatus.Items.AddRange(new object[] {
            "Active",
            "Expired",
            "Suspended",
            "Banned"});
			this.cbSubscriptionStatus.Location = new System.Drawing.Point(829, 370);
			this.cbSubscriptionStatus.Name = "cbSubscriptionStatus";
			this.cbSubscriptionStatus.Size = new System.Drawing.Size(176, 36);
			this.cbSubscriptionStatus.StartIndex = 0;
			this.cbSubscriptionStatus.TabIndex = 109;
			this.cbSubscriptionStatus.SelectedIndexChanged += new System.EventHandler(this.cbSubscriptionStatus_SelectedIndexChanged);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.SystemColors.Control;
			this.label11.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.Black;
			this.label11.Location = new System.Drawing.Point(482, 368);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(297, 39);
			this.label11.TabIndex = 107;
			this.label11.Text = "Subscription Status:";
			// 
			// chkIsActive
			// 
			this.chkIsActive.AutoSize = true;
			this.chkIsActive.Checked = true;
			this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkIsActive.Enabled = false;
			this.chkIsActive.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkIsActive.Location = new System.Drawing.Point(786, 298);
			this.chkIsActive.Name = "chkIsActive";
			this.chkIsActive.Size = new System.Drawing.Size(165, 43);
			this.chkIsActive.TabIndex = 106;
			this.chkIsActive.Text = "Is Active";
			this.chkIsActive.UseVisualStyleBackColor = true;
			this.chkIsActive.CheckedChanged += new System.EventHandler(this.chkIsActive_CheckedChanged);
			// 
			// lblLibraryCard
			// 
			this.lblLibraryCard.AutoSize = true;
			this.lblLibraryCard.BackColor = System.Drawing.SystemColors.Control;
			this.lblLibraryCard.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLibraryCard.ForeColor = System.Drawing.Color.MediumVioletRed;
			this.lblLibraryCard.Location = new System.Drawing.Point(889, 229);
			this.lblLibraryCard.Name = "lblLibraryCard";
			this.lblLibraryCard.Size = new System.Drawing.Size(49, 39);
			this.lblLibraryCard.TabIndex = 104;
			this.lblLibraryCard.Text = "??";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.SystemColors.Control;
			this.label8.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(683, 227);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(200, 39);
			this.label8.TabIndex = 103;
			this.label8.Text = "Library Card:";
			// 
			// lblReaderID
			// 
			this.lblReaderID.AutoSize = true;
			this.lblReaderID.BackColor = System.Drawing.SystemColors.Control;
			this.lblReaderID.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblReaderID.ForeColor = System.Drawing.Color.MediumVioletRed;
			this.lblReaderID.Location = new System.Drawing.Point(550, 229);
			this.lblReaderID.Name = "lblReaderID";
			this.lblReaderID.Size = new System.Drawing.Size(49, 39);
			this.lblReaderID.TabIndex = 102;
			this.lblReaderID.Text = "??";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.SystemColors.Control;
			this.label6.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(373, 227);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(171, 39);
			this.label6.TabIndex = 101;
			this.label6.Text = "Reader ID:";
			// 
			// lblPersonID
			// 
			this.lblPersonID.AutoSize = true;
			this.lblPersonID.BackColor = System.Drawing.SystemColors.Control;
			this.lblPersonID.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPersonID.ForeColor = System.Drawing.Color.MediumVioletRed;
			this.lblPersonID.Location = new System.Drawing.Point(206, 229);
			this.lblPersonID.Name = "lblPersonID";
			this.lblPersonID.Size = new System.Drawing.Size(49, 39);
			this.lblPersonID.TabIndex = 100;
			this.lblPersonID.Text = "??";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.SystemColors.Control;
			this.label10.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(36, 227);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(164, 39);
			this.label10.TabIndex = 99;
			this.label10.Text = "Person ID:";
			// 
			// dtpExpirtyDate
			// 
			this.dtpExpirtyDate.Enabled = false;
			this.dtpExpirtyDate.Location = new System.Drawing.Point(260, 435);
			this.dtpExpirtyDate.Name = "dtpExpirtyDate";
			this.dtpExpirtyDate.Size = new System.Drawing.Size(200, 26);
			this.dtpExpirtyDate.TabIndex = 84;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.SystemColors.Control;
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(11, 423);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(191, 39);
			this.label4.TabIndex = 82;
			this.label4.Text = "Expiry Date:";
			// 
			// dtpJoinDate
			// 
			this.dtpJoinDate.Enabled = false;
			this.dtpJoinDate.Location = new System.Drawing.Point(260, 368);
			this.dtpJoinDate.Name = "dtpJoinDate";
			this.dtpJoinDate.Size = new System.Drawing.Size(200, 26);
			this.dtpJoinDate.TabIndex = 81;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.Control;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(39, 356);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(163, 39);
			this.label3.TabIndex = 79;
			this.label3.Text = "Join Date:";
			// 
			// cbSubscriptionPeriod
			// 
			this.cbSubscriptionPeriod.BackColor = System.Drawing.Color.Transparent;
			this.cbSubscriptionPeriod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbSubscriptionPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSubscriptionPeriod.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbSubscriptionPeriod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbSubscriptionPeriod.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbSubscriptionPeriod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbSubscriptionPeriod.ItemHeight = 30;
			this.cbSubscriptionPeriod.Items.AddRange(new object[] {
            "1-Month Subscription",
            "3-Month Subscription",
            "1-Year Subscription"});
			this.cbSubscriptionPeriod.Location = new System.Drawing.Point(367, 301);
			this.cbSubscriptionPeriod.Name = "cbSubscriptionPeriod";
			this.cbSubscriptionPeriod.Size = new System.Drawing.Size(267, 36);
			this.cbSubscriptionPeriod.StartIndex = 0;
			this.cbSubscriptionPeriod.TabIndex = 78;
			this.cbSubscriptionPeriod.SelectedIndexChanged += new System.EventHandler(this.cbSubscriptionPeriod_SelectedIndexChanged);
			this.cbSubscriptionPeriod.Validating += new System.ComponentModel.CancelEventHandler(this.cbSubscriptionPeriod_Validating);
			// 
			// txtNotes
			// 
			this.txtNotes.AutoRoundedCorners = true;
			this.txtNotes.BorderRadius = 45;
			this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtNotes.DefaultText = "";
			this.txtNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtNotes.Location = new System.Drawing.Point(256, 496);
			this.txtNotes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtNotes.Multiline = true;
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.PasswordChar = '\0';
			this.txtNotes.PlaceholderText = "";
			this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtNotes.SelectedText = "";
			this.txtNotes.Size = new System.Drawing.Size(487, 93);
			this.txtNotes.TabIndex = 75;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.Control;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(90, 496);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 39);
			this.label2.TabIndex = 76;
			this.label2.Text = "Notes:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(22, 299);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(290, 39);
			this.label1.TabIndex = 73;
			this.label1.Text = "Subscription period:";
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.BackColor = System.Drawing.SystemColors.Control;
			this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.SteelBlue;
			this.lblTitle.Location = new System.Drawing.Point(344, 153);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(354, 55);
			this.lblTitle.TabIndex = 5;
			this.lblTitle.Text = "Add Reader Info";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
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
			this.btnClose.TabIndex = 111;
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
			this.btnSave.TabIndex = 110;
			this.btnSave.Text = "Save";
			this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = global::Library.Properties.Resources.subscription;
			this.pictureBox5.Location = new System.Drawing.Point(786, 378);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(26, 26);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox5.TabIndex = 108;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::Library.Properties.Resources.calendar;
			this.pictureBox4.Location = new System.Drawing.Point(208, 433);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(26, 26);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 83;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::Library.Properties.Resources.calendar;
			this.pictureBox3.Location = new System.Drawing.Point(208, 366);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(26, 26);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 80;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::Library.Properties.Resources.Notes;
			this.pictureBox2.Location = new System.Drawing.Point(206, 504);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(26, 26);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 77;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Library.Properties.Resources.subscription;
			this.pictureBox1.Location = new System.Drawing.Point(318, 309);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(26, 26);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 74;
			this.pictureBox1.TabStop = false;
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
			// ctrlAddUpdatePersonInfo1
			// 
			this.ctrlAddUpdatePersonInfo1.Location = new System.Drawing.Point(3, 3);
			this.ctrlAddUpdatePersonInfo1.Name = "ctrlAddUpdatePersonInfo1";
			this.ctrlAddUpdatePersonInfo1.Size = new System.Drawing.Size(1002, 568);
			this.ctrlAddUpdatePersonInfo1.TabIndex = 11;
			// 
			// frmAddUpdateReader
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1092, 685);
			this.Controls.Add(this.tabCompleteInfo);
			this.Name = "frmAddUpdateReader";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddNewReader";
			this.Load += new System.EventHandler(this.frmAddNewReader_Load);
			this.tabCompleteInfo.ResumeLayout(false);
			this.tbPersonalInfo.ResumeLayout(false);
			this.tbReaderInfo.ResumeLayout(false);
			this.tbReaderInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbMode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabCompleteInfo;
		private System.Windows.Forms.TabPage tbPersonalInfo;
		private System.Windows.Forms.TabPage tbReaderInfo;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Label lblTitle;
		private Guna.UI2.WinForms.Guna2PictureBox pbMode;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
		private Guna.UI2.WinForms.Guna2TextBox txtNotes;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2ComboBox cbSubscriptionPeriod;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dtpJoinDate;
		private System.Windows.Forms.DateTimePicker dtpExpirtyDate;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblLibraryCard;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblReaderID;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblPersonID;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.CheckBox chkIsActive;
		private Guna.UI2.WinForms.Guna2ComboBox cbSubscriptionStatus;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private ctrlAddUpdatePersonInfo ctrlAddUpdatePersonInfo1;
	}
}