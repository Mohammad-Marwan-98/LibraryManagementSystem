namespace Library
{
	partial class frmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.cmsBackup = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.lblLibrary = new System.Windows.Forms.Label();
			this.Panel = new System.Windows.Forms.Panel();
			this.pbLibrary = new System.Windows.Forms.PictureBox();
			this.borrowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addBookCopiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteBookCopiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manageBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.readersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.paymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SignOuttoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.HomeStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.SettingsStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.backupDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.restoreDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.cmsBackup.SuspendLayout();
			this.Panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLibrary)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.AutoSize = false;
			this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrowsToolStripMenuItem,
            this.booksToolStripMenuItem,
            this.readersToolStripMenuItem,
            this.paymentsToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.HomeStripMenuItem1,
            this.SettingsStripMenuItem2,
            this.SaveStripMenuItem3,
            this.reservationsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1610, 104);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// cmsBackup
			// 
			this.cmsBackup.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.cmsBackup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupDataToolStripMenuItem,
            this.restoreDateToolStripMenuItem});
			this.cmsBackup.Name = "contextMenuStrip1";
			this.cmsBackup.OwnerItem = this.SaveStripMenuItem3;
			this.cmsBackup.Size = new System.Drawing.Size(214, 80);
			// 
			// lblLibrary
			// 
			this.lblLibrary.AutoSize = true;
			this.lblLibrary.BackColor = System.Drawing.SystemColors.Control;
			this.lblLibrary.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLibrary.ForeColor = System.Drawing.Color.SteelBlue;
			this.lblLibrary.Location = new System.Drawing.Point(585, 107);
			this.lblLibrary.Name = "lblLibrary";
			this.lblLibrary.Size = new System.Drawing.Size(966, 168);
			this.lblLibrary.TabIndex = 2;
			this.lblLibrary.Text = "Library System";
			// 
			// Panel
			// 
			this.Panel.Controls.Add(this.lblLibrary);
			this.Panel.Controls.Add(this.pbLibrary);
			this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Panel.Location = new System.Drawing.Point(0, 104);
			this.Panel.Name = "Panel";
			this.Panel.Size = new System.Drawing.Size(1610, 944);
			this.Panel.TabIndex = 3;
			// 
			// pbLibrary
			// 
			this.pbLibrary.BackColor = System.Drawing.SystemColors.Control;
			this.pbLibrary.Image = global::Library.Properties.Resources.Library;
			this.pbLibrary.Location = new System.Drawing.Point(707, 187);
			this.pbLibrary.Name = "pbLibrary";
			this.pbLibrary.Size = new System.Drawing.Size(679, 643);
			this.pbLibrary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbLibrary.TabIndex = 1;
			this.pbLibrary.TabStop = false;
			// 
			// borrowsToolStripMenuItem
			// 
			this.borrowsToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.borrowsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.borrowsToolStripMenuItem.Image = global::Library.Properties.Resources.borrowbook64;
			this.borrowsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.borrowsToolStripMenuItem.Name = "borrowsToolStripMenuItem";
			this.borrowsToolStripMenuItem.Size = new System.Drawing.Size(211, 100);
			this.borrowsToolStripMenuItem.Text = "Borrows";
			this.borrowsToolStripMenuItem.Click += new System.EventHandler(this.borrowsToolStripMenuItem_Click);
			// 
			// booksToolStripMenuItem
			// 
			this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookCopiesToolStripMenuItem,
            this.deleteBookCopiesToolStripMenuItem,
            this.manageBooksToolStripMenuItem});
			this.booksToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.booksToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.booksToolStripMenuItem.Image = global::Library.Properties.Resources.Books64;
			this.booksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
			this.booksToolStripMenuItem.Size = new System.Drawing.Size(178, 100);
			this.booksToolStripMenuItem.Text = "Books";
			this.booksToolStripMenuItem.Click += new System.EventHandler(this.booksToolStripMenuItem_Click);
			// 
			// addBookCopiesToolStripMenuItem
			// 
			this.addBookCopiesToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addBookCopiesToolStripMenuItem.Image = global::Library.Properties.Resources.Addopy32_1_;
			this.addBookCopiesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.addBookCopiesToolStripMenuItem.Name = "addBookCopiesToolStripMenuItem";
			this.addBookCopiesToolStripMenuItem.Size = new System.Drawing.Size(369, 44);
			this.addBookCopiesToolStripMenuItem.Text = "Add Book Copies";
			this.addBookCopiesToolStripMenuItem.Click += new System.EventHandler(this.addBookCopiesToolStripMenuItem_Click);
			// 
			// deleteBookCopiesToolStripMenuItem
			// 
			this.deleteBookCopiesToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deleteBookCopiesToolStripMenuItem.Image = global::Library.Properties.Resources.deleteCopy32_1_;
			this.deleteBookCopiesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.deleteBookCopiesToolStripMenuItem.Name = "deleteBookCopiesToolStripMenuItem";
			this.deleteBookCopiesToolStripMenuItem.Size = new System.Drawing.Size(369, 44);
			this.deleteBookCopiesToolStripMenuItem.Text = "Delete Book Copies";
			this.deleteBookCopiesToolStripMenuItem.Click += new System.EventHandler(this.deleteBookCopiesToolStripMenuItem_Click);
			// 
			// manageBooksToolStripMenuItem
			// 
			this.manageBooksToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.manageBooksToolStripMenuItem.Image = global::Library.Properties.Resources.ManageBook32_1_;
			this.manageBooksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.manageBooksToolStripMenuItem.Name = "manageBooksToolStripMenuItem";
			this.manageBooksToolStripMenuItem.Size = new System.Drawing.Size(369, 44);
			this.manageBooksToolStripMenuItem.Text = "Manage Books";
			this.manageBooksToolStripMenuItem.Click += new System.EventHandler(this.manageBooksToolStripMenuItem_Click);
			// 
			// readersToolStripMenuItem
			// 
			this.readersToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.readersToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.readersToolStripMenuItem.Image = global::Library.Properties.Resources.readers__1_64;
			this.readersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.readersToolStripMenuItem.Name = "readersToolStripMenuItem";
			this.readersToolStripMenuItem.Size = new System.Drawing.Size(208, 100);
			this.readersToolStripMenuItem.Text = "Readers";
			this.readersToolStripMenuItem.Click += new System.EventHandler(this.readersToolStripMenuItem_Click);
			// 
			// paymentsToolStripMenuItem
			// 
			this.paymentsToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.paymentsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.paymentsToolStripMenuItem.Image = global::Library.Properties.Resources.Fees64;
			this.paymentsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.paymentsToolStripMenuItem.Name = "paymentsToolStripMenuItem";
			this.paymentsToolStripMenuItem.Size = new System.Drawing.Size(227, 100);
			this.paymentsToolStripMenuItem.Text = "Payments";
			this.paymentsToolStripMenuItem.Click += new System.EventHandler(this.paymentsToolStripMenuItem_Click);
			// 
			// usersToolStripMenuItem
			// 
			this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageUsersToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.SignOuttoolStripMenuItem});
			this.usersToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usersToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.usersToolStripMenuItem.Image = global::Library.Properties.Resources.Users64;
			this.usersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
			this.usersToolStripMenuItem.Size = new System.Drawing.Size(178, 100);
			this.usersToolStripMenuItem.Text = "Users";
			// 
			// manageUsersToolStripMenuItem
			// 
			this.manageUsersToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.manageUsersToolStripMenuItem.Image = global::Library.Properties.Resources.User32u;
			this.manageUsersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
			this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(342, 44);
			this.manageUsersToolStripMenuItem.Text = "Manage Users";
			this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
			// 
			// changePasswordToolStripMenuItem
			// 
			this.changePasswordToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.changePasswordToolStripMenuItem.Image = global::Library.Properties.Resources.ChangePassword32;
			this.changePasswordToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
			this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(342, 44);
			this.changePasswordToolStripMenuItem.Text = "Change Password";
			this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
			// 
			// SignOuttoolStripMenuItem
			// 
			this.SignOuttoolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SignOuttoolStripMenuItem.Image = global::Library.Properties.Resources.exit_door;
			this.SignOuttoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.SignOuttoolStripMenuItem.Name = "SignOuttoolStripMenuItem";
			this.SignOuttoolStripMenuItem.Size = new System.Drawing.Size(342, 44);
			this.SignOuttoolStripMenuItem.Text = "Sign Out";
			this.SignOuttoolStripMenuItem.Click += new System.EventHandler(this.SignOuttoolStripMenuItem_Click);
			// 
			// HomeStripMenuItem1
			// 
			this.HomeStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.HomeStripMenuItem1.Image = global::Library.Properties.Resources.house;
			this.HomeStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.HomeStripMenuItem1.Name = "HomeStripMenuItem1";
			this.HomeStripMenuItem1.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
			this.HomeStripMenuItem1.Size = new System.Drawing.Size(108, 100);
			this.HomeStripMenuItem1.Click += new System.EventHandler(this.HomeStripMenuItem1_Click);
			// 
			// SettingsStripMenuItem2
			// 
			this.SettingsStripMenuItem2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.SettingsStripMenuItem2.Image = global::Library.Properties.Resources.setting64;
			this.SettingsStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.SettingsStripMenuItem2.Name = "SettingsStripMenuItem2";
			this.SettingsStripMenuItem2.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
			this.SettingsStripMenuItem2.Size = new System.Drawing.Size(108, 100);
			this.SettingsStripMenuItem2.Click += new System.EventHandler(this.SettingsStripMenuItem2_Click);
			// 
			// SaveStripMenuItem3
			// 
			this.SaveStripMenuItem3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.SaveStripMenuItem3.DropDown = this.cmsBackup;
			this.SaveStripMenuItem3.Image = global::Library.Properties.Resources.save64;
			this.SaveStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.SaveStripMenuItem3.Name = "SaveStripMenuItem3";
			this.SaveStripMenuItem3.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
			this.SaveStripMenuItem3.Size = new System.Drawing.Size(108, 100);
			// 
			// backupDataToolStripMenuItem
			// 
			this.backupDataToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.backupDataToolStripMenuItem.Image = global::Library.Properties.Resources.backup;
			this.backupDataToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.backupDataToolStripMenuItem.Name = "backupDataToolStripMenuItem";
			this.backupDataToolStripMenuItem.Size = new System.Drawing.Size(213, 38);
			this.backupDataToolStripMenuItem.Text = "Backup Data";
			this.backupDataToolStripMenuItem.Click += new System.EventHandler(this.backupDataToolStripMenuItem_Click);
			// 
			// restoreDateToolStripMenuItem
			// 
			this.restoreDateToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.restoreDateToolStripMenuItem.Image = global::Library.Properties.Resources.restore;
			this.restoreDateToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.restoreDateToolStripMenuItem.Name = "restoreDateToolStripMenuItem";
			this.restoreDateToolStripMenuItem.Size = new System.Drawing.Size(213, 38);
			this.restoreDateToolStripMenuItem.Text = "Restore Date";
			this.restoreDateToolStripMenuItem.Click += new System.EventHandler(this.restoreDateToolStripMenuItem_Click);
			// 
			// reservationsToolStripMenuItem
			// 
			this.reservationsToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.reservationsToolStripMenuItem.Image = global::Library.Properties.Resources.reserve;
			this.reservationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.reservationsToolStripMenuItem.Name = "reservationsToolStripMenuItem";
			this.reservationsToolStripMenuItem.Size = new System.Drawing.Size(274, 100);
			this.reservationsToolStripMenuItem.Text = "Reservations";
			this.reservationsToolStripMenuItem.Click += new System.EventHandler(this.reservationsToolStripMenuItem_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1610, 1048);
			this.Controls.Add(this.Panel);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmMain";
			this.Text = "Library Managment System";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.cmsBackup.ResumeLayout(false);
			this.Panel.ResumeLayout(false);
			this.Panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLibrary)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem borrowsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem readersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
		private System.Windows.Forms.PictureBox pbLibrary;
		private System.Windows.Forms.Label lblLibrary;
		private System.Windows.Forms.ToolStripMenuItem HomeStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem SettingsStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem SaveStripMenuItem3;
		private System.Windows.Forms.Panel Panel;
		private System.Windows.Forms.ContextMenuStrip cmsBackup;
		private System.Windows.Forms.ToolStripMenuItem backupDataToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem restoreDateToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SignOuttoolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addBookCopiesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteBookCopiesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem manageBooksToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reservationsToolStripMenuItem;
	}
}

