namespace Library
{
	partial class frmListBorrowingRecords
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.txtFilter = new Guna.UI2.WinForms.Guna2TextBox();
			this.cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblManageBorrowingRedords = new System.Windows.Forms.Label();
			this.dgvBorrowingRecords = new Guna.UI2.WinForms.Guna2DataGridView();
			this.lblRecords = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
			this.cmsBorrowingRecords = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.damagedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnAddBorrowingRecord = new System.Windows.Forms.Button();
			this.extendBorrowingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.notesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.endBorrowingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvBorrowingRecords)).BeginInit();
			this.cmsBorrowingRecords.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtFilter
			// 
			this.txtFilter.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtFilter.DefaultText = "";
			this.txtFilter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtFilter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtFilter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtFilter.Location = new System.Drawing.Point(471, 232);
			this.txtFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtFilter.Name = "txtFilter";
			this.txtFilter.PasswordChar = '\0';
			this.txtFilter.PlaceholderText = "";
			this.txtFilter.SelectedText = "";
			this.txtFilter.Size = new System.Drawing.Size(244, 43);
			this.txtFilter.TabIndex = 12;
			this.txtFilter.Visible = false;
			this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
			// 
			// cbFilter
			// 
			this.cbFilter.BackColor = System.Drawing.Color.Transparent;
			this.cbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbFilter.ItemHeight = 30;
			this.cbFilter.Items.AddRange(new object[] {
            "None",
            "Book Title",
            "Borrower\'s Name",
            "Borrow Status"});
			this.cbFilter.Location = new System.Drawing.Point(247, 232);
			this.cbFilter.Name = "cbFilter";
			this.cbFilter.Size = new System.Drawing.Size(209, 36);
			this.cbFilter.StartIndex = 0;
			this.cbFilter.TabIndex = 11;
			this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(61, 230);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(176, 46);
			this.label1.TabIndex = 10;
			this.label1.Text = "Filter By :";
			// 
			// lblManageBorrowingRedords
			// 
			this.lblManageBorrowingRedords.AutoSize = true;
			this.lblManageBorrowingRedords.BackColor = System.Drawing.SystemColors.Control;
			this.lblManageBorrowingRedords.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblManageBorrowingRedords.ForeColor = System.Drawing.Color.SteelBlue;
			this.lblManageBorrowingRedords.Location = new System.Drawing.Point(767, 165);
			this.lblManageBorrowingRedords.Name = "lblManageBorrowingRedords";
			this.lblManageBorrowingRedords.Size = new System.Drawing.Size(638, 65);
			this.lblManageBorrowingRedords.TabIndex = 9;
			this.lblManageBorrowingRedords.Text = "Manage Borrowing Records";
			// 
			// dgvBorrowingRecords
			// 
			this.dgvBorrowingRecords.AllowUserToAddRows = false;
			this.dgvBorrowingRecords.AllowUserToDeleteRows = false;
			this.dgvBorrowingRecords.AllowUserToOrderColumns = true;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dgvBorrowingRecords.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvBorrowingRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvBorrowingRecords.ColumnHeadersHeight = 20;
			this.dgvBorrowingRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvBorrowingRecords.ContextMenuStrip = this.cmsBorrowingRecords;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvBorrowingRecords.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvBorrowingRecords.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvBorrowingRecords.Location = new System.Drawing.Point(48, 291);
			this.dgvBorrowingRecords.Name = "dgvBorrowingRecords";
			this.dgvBorrowingRecords.ReadOnly = true;
			this.dgvBorrowingRecords.RowHeadersVisible = false;
			this.dgvBorrowingRecords.RowHeadersWidth = 51;
			this.dgvBorrowingRecords.RowTemplate.Height = 24;
			this.dgvBorrowingRecords.Size = new System.Drawing.Size(1398, 506);
			this.dgvBorrowingRecords.TabIndex = 13;
			this.dgvBorrowingRecords.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvBorrowingRecords.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgvBorrowingRecords.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgvBorrowingRecords.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgvBorrowingRecords.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgvBorrowingRecords.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgvBorrowingRecords.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvBorrowingRecords.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dgvBorrowingRecords.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvBorrowingRecords.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvBorrowingRecords.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dgvBorrowingRecords.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvBorrowingRecords.ThemeStyle.HeaderStyle.Height = 20;
			this.dgvBorrowingRecords.ThemeStyle.ReadOnly = true;
			this.dgvBorrowingRecords.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvBorrowingRecords.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvBorrowingRecords.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvBorrowingRecords.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvBorrowingRecords.ThemeStyle.RowsStyle.Height = 24;
			this.dgvBorrowingRecords.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvBorrowingRecords.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// lblRecords
			// 
			this.lblRecords.AutoSize = true;
			this.lblRecords.BackColor = System.Drawing.SystemColors.Control;
			this.lblRecords.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRecords.ForeColor = System.Drawing.Color.Black;
			this.lblRecords.Location = new System.Drawing.Point(226, 811);
			this.lblRecords.Name = "lblRecords";
			this.lblRecords.Size = new System.Drawing.Size(48, 46);
			this.lblRecords.TabIndex = 16;
			this.lblRecords.Text = "#";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.Control;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(61, 811);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(164, 46);
			this.label2.TabIndex = 15;
			this.label2.Text = "Records :";
			// 
			// cbStatus
			// 
			this.cbStatus.BackColor = System.Drawing.Color.Transparent;
			this.cbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbStatus.ItemHeight = 30;
			this.cbStatus.Items.AddRange(new object[] {
            "None",
            "Borrowed",
            "Returned",
            "OverDue",
            "Lost",
            "Extended",
            "Damaged"});
			this.cbStatus.Location = new System.Drawing.Point(487, 232);
			this.cbStatus.Name = "cbStatus";
			this.cbStatus.Size = new System.Drawing.Size(209, 36);
			this.cbStatus.StartIndex = 0;
			this.cbStatus.TabIndex = 17;
			this.cbStatus.Visible = false;
			this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
			// 
			// cmsBorrowingRecords
			// 
			this.cmsBorrowingRecords.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.cmsBorrowingRecords.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extendBorrowingToolStripMenuItem,
            this.notesToolStripMenuItem,
            this.endBorrowingToolStripMenuItem,
            this.lostToolStripMenuItem,
            this.damagedToolStripMenuItem});
			this.cmsBorrowingRecords.Name = "contextMenuStrip1";
			this.cmsBorrowingRecords.Size = new System.Drawing.Size(238, 194);
			this.cmsBorrowingRecords.Opening += new System.ComponentModel.CancelEventHandler(this.cmsBorrowingRecords_Opening);
			// 
			// damagedToolStripMenuItem
			// 
			this.damagedToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.damagedToolStripMenuItem.Image = global::Library.Properties.Resources.BookDamaged;
			this.damagedToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.damagedToolStripMenuItem.Name = "damagedToolStripMenuItem";
			this.damagedToolStripMenuItem.Size = new System.Drawing.Size(237, 38);
			this.damagedToolStripMenuItem.Text = "Damaged";
			this.damagedToolStripMenuItem.Click += new System.EventHandler(this.damagedToolStripMenuItem_Click);
			// 
			// btnAddBorrowingRecord
			// 
			this.btnAddBorrowingRecord.Image = global::Library.Properties.Resources.AddRecord;
			this.btnAddBorrowingRecord.Location = new System.Drawing.Point(1885, 182);
			this.btnAddBorrowingRecord.Name = "btnAddBorrowingRecord";
			this.btnAddBorrowingRecord.Size = new System.Drawing.Size(98, 94);
			this.btnAddBorrowingRecord.TabIndex = 14;
			this.btnAddBorrowingRecord.UseVisualStyleBackColor = true;
			this.btnAddBorrowingRecord.Click += new System.EventHandler(this.btnAddBorrowingRecord_Click);
			// 
			// extendBorrowingToolStripMenuItem
			// 
			this.extendBorrowingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.extendBorrowingToolStripMenuItem.Image = global::Library.Properties.Resources.ExtendBorrowing;
			this.extendBorrowingToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.extendBorrowingToolStripMenuItem.Name = "extendBorrowingToolStripMenuItem";
			this.extendBorrowingToolStripMenuItem.Size = new System.Drawing.Size(237, 38);
			this.extendBorrowingToolStripMenuItem.Text = "Extend Borrowing";
			this.extendBorrowingToolStripMenuItem.Click += new System.EventHandler(this.extendBorrowingToolStripMenuItem_Click);
			// 
			// notesToolStripMenuItem
			// 
			this.notesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.notesToolStripMenuItem.Image = global::Library.Properties.Resources.BroowingRecordNotes;
			this.notesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.notesToolStripMenuItem.Name = "notesToolStripMenuItem";
			this.notesToolStripMenuItem.Size = new System.Drawing.Size(237, 38);
			this.notesToolStripMenuItem.Text = "Notes";
			this.notesToolStripMenuItem.Click += new System.EventHandler(this.notesToolStripMenuItem_Click);
			// 
			// endBorrowingToolStripMenuItem
			// 
			this.endBorrowingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.endBorrowingToolStripMenuItem.Image = global::Library.Properties.Resources.CompleteBorrowing;
			this.endBorrowingToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.endBorrowingToolStripMenuItem.Name = "endBorrowingToolStripMenuItem";
			this.endBorrowingToolStripMenuItem.Size = new System.Drawing.Size(237, 38);
			this.endBorrowingToolStripMenuItem.Text = "End Borrowing";
			this.endBorrowingToolStripMenuItem.Click += new System.EventHandler(this.endBorrowingToolStripMenuItem_Click);
			// 
			// lostToolStripMenuItem
			// 
			this.lostToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lostToolStripMenuItem.Image = global::Library.Properties.Resources.Lost;
			this.lostToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.lostToolStripMenuItem.Name = "lostToolStripMenuItem";
			this.lostToolStripMenuItem.Size = new System.Drawing.Size(237, 38);
			this.lostToolStripMenuItem.Text = "Lost";
			this.lostToolStripMenuItem.Click += new System.EventHandler(this.lostToolStripMenuItem_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Library.Properties.Resources.BorrowBook128;
			this.pictureBox1.Location = new System.Drawing.Point(997, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(171, 162);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// frmListBorrowingRecords
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1924, 894);
			this.Controls.Add(this.cbStatus);
			this.Controls.Add(this.lblRecords);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnAddBorrowingRecord);
			this.Controls.Add(this.dgvBorrowingRecords);
			this.Controls.Add(this.txtFilter);
			this.Controls.Add(this.cbFilter);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblManageBorrowingRedords);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmListBorrowingRecords";
			this.Text = "frmBorrowingRecords";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmListBorrowingRecords_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvBorrowingRecords)).EndInit();
			this.cmsBorrowingRecords.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2TextBox txtFilter;
		private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblManageBorrowingRedords;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnAddBorrowingRecord;
		private Guna.UI2.WinForms.Guna2DataGridView dgvBorrowingRecords;
		private System.Windows.Forms.Label lblRecords;
		private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2ComboBox cbStatus;
		private System.Windows.Forms.ContextMenuStrip cmsBorrowingRecords;
		private System.Windows.Forms.ToolStripMenuItem extendBorrowingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem notesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem endBorrowingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lostToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem damagedToolStripMenuItem;
	}
}