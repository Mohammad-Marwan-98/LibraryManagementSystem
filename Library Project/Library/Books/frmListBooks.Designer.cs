namespace Library
{
	partial class frmListBooks
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListBooks));
			this.lblManageBooks = new System.Windows.Forms.Label();
			this.dgvBooks = new Guna.UI2.WinForms.Guna2DataGridView();
			this.cmsBooks = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.label1 = new System.Windows.Forms.Label();
			this.cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
			this.txtFilter = new Guna.UI2.WinForms.Guna2TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lblRecords = new System.Windows.Forms.Label();
			this.btnAddBook = new System.Windows.Forms.Button();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
			this.cmsBooks.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblManageBooks
			// 
			this.lblManageBooks.AutoSize = true;
			this.lblManageBooks.BackColor = System.Drawing.SystemColors.Control;
			this.lblManageBooks.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblManageBooks.ForeColor = System.Drawing.Color.SteelBlue;
			this.lblManageBooks.Location = new System.Drawing.Point(911, 165);
			this.lblManageBooks.Name = "lblManageBooks";
			this.lblManageBooks.Size = new System.Drawing.Size(346, 65);
			this.lblManageBooks.TabIndex = 3;
			this.lblManageBooks.Text = "Manage Books";
			// 
			// dgvBooks
			// 
			this.dgvBooks.AllowUserToAddRows = false;
			this.dgvBooks.AllowUserToDeleteRows = false;
			this.dgvBooks.AllowUserToOrderColumns = true;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dgvBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvBooks.ColumnHeadersHeight = 20;
			this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvBooks.ContextMenuStrip = this.cmsBooks;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvBooks.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvBooks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvBooks.Location = new System.Drawing.Point(48, 291);
			this.dgvBooks.Name = "dgvBooks";
			this.dgvBooks.ReadOnly = true;
			this.dgvBooks.RowHeadersVisible = false;
			this.dgvBooks.RowHeadersWidth = 51;
			this.dgvBooks.RowTemplate.Height = 24;
			this.dgvBooks.Size = new System.Drawing.Size(1398, 506);
			this.dgvBooks.TabIndex = 4;
			this.dgvBooks.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvBooks.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgvBooks.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgvBooks.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgvBooks.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgvBooks.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgvBooks.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvBooks.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dgvBooks.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvBooks.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvBooks.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dgvBooks.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvBooks.ThemeStyle.HeaderStyle.Height = 20;
			this.dgvBooks.ThemeStyle.ReadOnly = true;
			this.dgvBooks.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvBooks.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvBooks.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvBooks.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvBooks.ThemeStyle.RowsStyle.Height = 24;
			this.dgvBooks.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvBooks.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// cmsBooks
			// 
			this.cmsBooks.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.cmsBooks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.addBookToolStripMenuItem,
            this.editBookToolStripMenuItem,
            this.deleteToolStripMenuItem});
			this.cmsBooks.Name = "contextMenuStrip1";
			this.cmsBooks.Size = new System.Drawing.Size(218, 162);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(214, 6);
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
			this.label1.TabIndex = 5;
			this.label1.Text = "Filter By :";
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
            "Book ID",
            "Book Title",
            "ISBN",
            "Language",
            "Genre",
            "Author"});
			this.cbFilter.Location = new System.Drawing.Point(247, 232);
			this.cbFilter.Name = "cbFilter";
			this.cbFilter.Size = new System.Drawing.Size(209, 36);
			this.cbFilter.StartIndex = 0;
			this.cbFilter.TabIndex = 6;
			this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
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
			this.txtFilter.TabIndex = 7;
			this.txtFilter.Visible = false;
			this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
			this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
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
			this.label2.TabIndex = 8;
			this.label2.Text = "Records :";
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
			this.lblRecords.TabIndex = 9;
			this.lblRecords.Text = "#";
			// 
			// btnAddBook
			// 
			this.btnAddBook.Image = global::Library.Properties.Resources.AddBook1;
			this.btnAddBook.Location = new System.Drawing.Point(1885, 182);
			this.btnAddBook.Name = "btnAddBook";
			this.btnAddBook.Size = new System.Drawing.Size(98, 94);
			this.btnAddBook.TabIndex = 10;
			this.btnAddBook.UseVisualStyleBackColor = true;
			this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStripMenuItem1.Image = global::Library.Properties.Resources.BookDetails;
			this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(217, 38);
			this.toolStripMenuItem1.Text = "Show Details";
			this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
			// 
			// addBookToolStripMenuItem
			// 
			this.addBookToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addBookToolStripMenuItem.Image = global::Library.Properties.Resources.AddBook32_1_;
			this.addBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
			this.addBookToolStripMenuItem.Size = new System.Drawing.Size(217, 38);
			this.addBookToolStripMenuItem.Text = "Add New Book";
			this.addBookToolStripMenuItem.Click += new System.EventHandler(this.addBookToolStripMenuItem_Click);
			// 
			// editBookToolStripMenuItem
			// 
			this.editBookToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.editBookToolStripMenuItem.Image = global::Library.Properties.Resources.Edit_Book_32__1_;
			this.editBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.editBookToolStripMenuItem.Name = "editBookToolStripMenuItem";
			this.editBookToolStripMenuItem.Size = new System.Drawing.Size(217, 38);
			this.editBookToolStripMenuItem.Text = "Edit ";
			this.editBookToolStripMenuItem.Click += new System.EventHandler(this.editBookToolStripMenuItem_Click);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deleteToolStripMenuItem.Image = global::Library.Properties.Resources.Delete_Book_32__2_;
			this.deleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(217, 38);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(997, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(171, 162);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// frmListBooks
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1942, 941);
			this.Controls.Add(this.btnAddBook);
			this.Controls.Add(this.lblRecords);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtFilter);
			this.Controls.Add(this.cbFilter);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvBooks);
			this.Controls.Add(this.lblManageBooks);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmListBooks";
			this.Text = "frmShowBooks";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmListBooks_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
			this.cmsBooks.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblManageBooks;
		private Guna.UI2.WinForms.Guna2DataGridView dgvBooks;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
		private Guna.UI2.WinForms.Guna2TextBox txtFilter;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblRecords;
		private System.Windows.Forms.Button btnAddBook;
		private System.Windows.Forms.ContextMenuStrip cmsBooks;
		private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editBookToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
	}
}