using LibraryBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
	public partial class frmMain : Form
	{
		private Form _frmLogin;
		public frmMain(Form frm)
		{
			InitializeComponent();
			_frmLogin = frm;
		}

		private void frmMain_Load(object sender, EventArgs e)
		{

			foreach (Control ctrl in this.Controls)
			{
				if (ctrl is MdiClient)
				{
					ctrl.BackColor = SystemColors.Control;
				}
			}
		}

		private void booksToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void HomeStripMenuItem1_Click(object sender, EventArgs e)
		{
			Panel.Controls.Clear();
			Panel.Controls.Add(lblLibrary);
			Panel.Controls.Add(pbLibrary);
		}

		private void Panel_Paint(object sender, PaintEventArgs e)
		{

		}

		private void backupDataToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string Path = "";

			using (SaveFileDialog sfd = new SaveFileDialog())
			{
				sfd.Title = "Select Backup Location";
				sfd.Filter = "Backup Files (*.bak)|*.bak|All Files (*.*)|*.*";
				sfd.DefaultExt = "bak";
				sfd.FileName = "LibraryDB_Backup.bak";

				if (sfd.ShowDialog() == DialogResult.OK)
				{
					Path = sfd.FileName;

					if (clsDataBaseMaintenance.BackupDatabase(Path))
					{
						MessageBox.Show("Backup completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("Backup failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void restoreDateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				string path = "";

				using (OpenFileDialog ofd = new OpenFileDialog())
				{
					ofd.Title = "Select Backup File to Restore";
					ofd.Filter = "Backup Files (*.bak)|*.bak|All Files (*.*)|*.*";
					ofd.DefaultExt = "bak";

					if (ofd.ShowDialog() == DialogResult.OK)
					{
						path = ofd.FileName;

						if (string.IsNullOrWhiteSpace(path))
						{
							MessageBox.Show("Please select a valid backup file.", "Invalid Path", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							return;
						}
						string error;
						if (clsDataBaseMaintenance.RestoreDatabase(path, out error))
						{
							MessageBox.Show("Restore completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						else
						{
							MessageBox.Show("Restore failed: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}

					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Restore Error: " + ex.Message);
			}


		}

		private void readersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!((clsUser.enPermissions)clsGlobal.CurrentUser.Permissions).HasFlag(clsUser.enPermissions.Readers))
			{
				MessageBox.Show("You don't have permission to access this section.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			Panel.Controls.Clear();
			Form frm = new frmListReaders();
			frm.TopLevel = false;
			Panel.Controls.Add(frm);
			frm.Show();
		}

		private void SettingsStripMenuItem2_Click(object sender, EventArgs e)
		{
			if (!((clsUser.enPermissions)clsGlobal.CurrentUser.Permissions).HasFlag(clsUser.enPermissions.Settings))
			{
				MessageBox.Show("You don't have permission to access this section.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			Form frm = new frmSettings();
			frm.ShowDialog();
		}

		private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!((clsUser.enPermissions)clsGlobal.CurrentUser.Permissions).HasFlag(clsUser.enPermissions.Users))
			{
				MessageBox.Show("You don't have permission to access this section.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			Panel.Controls.Clear();
			Form frm = new frmListUsers();
			frm.TopLevel = false;
			Panel.Controls.Add(frm);
			frm.Show();
		}

		private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
		{

			Form frm = new frmChangePassword(clsGlobal.CurrentUser.UserID);
			frm.ShowDialog();
		}

		private void SignOuttoolStripMenuItem_Click(object sender, EventArgs e)
		{
			clsGlobal.CurrentUser = null;
			_frmLogin.Show();
			this.Close();
		}

		private void borrowsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!((clsUser.enPermissions)clsGlobal.CurrentUser.Permissions).HasFlag(clsUser.enPermissions.Borrows))
			{
				MessageBox.Show("You don't have permission to access this section.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			Panel.Controls.Clear();
			Form frm = new frmListBorrowingRecords();
			frm.TopLevel = false;
			Panel.Controls.Add(frm);
			frm.Show();
		}

		private void paymentsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!((clsUser.enPermissions)clsGlobal.CurrentUser.Permissions).HasFlag(clsUser.enPermissions.Payments))
			{
				MessageBox.Show("You don't have permission to access this section.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			Panel.Controls.Clear();
			Form frm = new frmListFines();
			frm.TopLevel = false;
			Panel.Controls.Add(frm);
			frm.Show();
		}

		private void manageBooksToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!((clsUser.enPermissions)clsGlobal.CurrentUser.Permissions).HasFlag(clsUser.enPermissions.Books))
			{
				MessageBox.Show("You don't have permission to access this section.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			Panel.Controls.Clear();
			Form frm = new frmListBooks();
			frm.TopLevel = false;
			Panel.Controls.Add(frm);
			frm.Show();
		}

		private void addBookCopiesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!((clsUser.enPermissions)clsGlobal.CurrentUser.Permissions).HasFlag(clsUser.enPermissions.Books))
			{
				MessageBox.Show("You don't have permission to access this section.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			Form frm = new frmAddBookCopies();
			frm.ShowDialog();
		}

		private void deleteBookCopiesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!((clsUser.enPermissions)clsGlobal.CurrentUser.Permissions).HasFlag(clsUser.enPermissions.Books))
			{
				MessageBox.Show("You don't have permission to access this section.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			Form frm = new frmDeleteCopy();
			frm.ShowDialog();
		}

		private void reservationsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!((clsUser.enPermissions)clsGlobal.CurrentUser.Permissions).HasFlag(clsUser.enPermissions.Books))
			{
				MessageBox.Show("You don't have permission to access this section.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			Panel.Controls.Clear();
			Form frm = new frmListReservations();
			frm.TopLevel = false;
			Panel.Controls.Add(frm);
			frm.Show();
		}
	}
}
