namespace Library
{
	partial class frmListFines
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
			this.dgvFines = new Guna.UI2.WinForms.Guna2DataGridView();
			this.lblManageFines = new System.Windows.Forms.Label();
			this.lblRecords = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
			this.cmsFines = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.payFineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dgvFines)).BeginInit();
			this.cmsFines.SuspendLayout();
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
			this.txtFilter.Location = new System.Drawing.Point(504, 232);
			this.txtFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtFilter.Name = "txtFilter";
			this.txtFilter.PasswordChar = '\0';
			this.txtFilter.PlaceholderText = "";
			this.txtFilter.SelectedText = "";
			this.txtFilter.Size = new System.Drawing.Size(244, 43);
			this.txtFilter.TabIndex = 13;
			this.txtFilter.Visible = false;
			this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
			this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
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
            "Full Name",
            "Borrowing Record ID",
            "Payment Status"});
			this.cbFilter.Location = new System.Drawing.Point(247, 232);
			this.cbFilter.Name = "cbFilter";
			this.cbFilter.Size = new System.Drawing.Size(240, 36);
			this.cbFilter.StartIndex = 0;
			this.cbFilter.TabIndex = 12;
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
			this.label1.TabIndex = 11;
			this.label1.Text = "Filter By :";
			// 
			// dgvFines
			// 
			this.dgvFines.AllowUserToAddRows = false;
			this.dgvFines.AllowUserToDeleteRows = false;
			this.dgvFines.AllowUserToOrderColumns = true;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dgvFines.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvFines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvFines.ColumnHeadersHeight = 20;
			this.dgvFines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvFines.ContextMenuStrip = this.cmsFines;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvFines.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvFines.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvFines.Location = new System.Drawing.Point(48, 291);
			this.dgvFines.Name = "dgvFines";
			this.dgvFines.ReadOnly = true;
			this.dgvFines.RowHeadersVisible = false;
			this.dgvFines.RowHeadersWidth = 51;
			this.dgvFines.RowTemplate.Height = 24;
			this.dgvFines.Size = new System.Drawing.Size(1398, 506);
			this.dgvFines.TabIndex = 10;
			this.dgvFines.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvFines.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgvFines.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgvFines.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgvFines.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgvFines.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgvFines.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvFines.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dgvFines.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvFines.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvFines.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dgvFines.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvFines.ThemeStyle.HeaderStyle.Height = 20;
			this.dgvFines.ThemeStyle.ReadOnly = true;
			this.dgvFines.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvFines.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvFines.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvFines.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvFines.ThemeStyle.RowsStyle.Height = 24;
			this.dgvFines.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvFines.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// lblManageFines
			// 
			this.lblManageFines.AutoSize = true;
			this.lblManageFines.BackColor = System.Drawing.SystemColors.Control;
			this.lblManageFines.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblManageFines.ForeColor = System.Drawing.Color.SteelBlue;
			this.lblManageFines.Location = new System.Drawing.Point(911, 165);
			this.lblManageFines.Name = "lblManageFines";
			this.lblManageFines.Size = new System.Drawing.Size(334, 65);
			this.lblManageFines.TabIndex = 9;
			this.lblManageFines.Text = "Manage Fines";
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
			this.lblRecords.TabIndex = 15;
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
			this.label2.TabIndex = 14;
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
            "Paid",
            "Unpaid"});
			this.cbStatus.Location = new System.Drawing.Point(520, 232);
			this.cbStatus.Name = "cbStatus";
			this.cbStatus.Size = new System.Drawing.Size(209, 36);
			this.cbStatus.StartIndex = 0;
			this.cbStatus.TabIndex = 18;
			this.cbStatus.Visible = false;
			this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
			// 
			// cmsFines
			// 
			this.cmsFines.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.cmsFines.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.payFineToolStripMenuItem});
			this.cmsFines.Name = "contextMenuStrip1";
			this.cmsFines.Size = new System.Drawing.Size(227, 70);
			this.cmsFines.Opening += new System.ComponentModel.CancelEventHandler(this.cmsFines_Opening);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Library.Properties.Resources.Fine128;
			this.pictureBox1.Location = new System.Drawing.Point(997, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(171, 162);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// payFineToolStripMenuItem
			// 
			this.payFineToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.payFineToolStripMenuItem.Image = global::Library.Properties.Resources.Pay;
			this.payFineToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.payFineToolStripMenuItem.Name = "payFineToolStripMenuItem";
			this.payFineToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
			this.payFineToolStripMenuItem.Text = "Pay Fine";
			this.payFineToolStripMenuItem.Click += new System.EventHandler(this.payFineToolStripMenuItem_Click);
			// 
			// frmListFines
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1942, 941);
			this.Controls.Add(this.cbStatus);
			this.Controls.Add(this.lblRecords);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtFilter);
			this.Controls.Add(this.cbFilter);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvFines);
			this.Controls.Add(this.lblManageFines);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmListFines";
			this.Text = "frmListFines";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmListFines_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvFines)).EndInit();
			this.cmsFines.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2TextBox txtFilter;
		private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2DataGridView dgvFines;
		private System.Windows.Forms.Label lblManageFines;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblRecords;
		private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2ComboBox cbStatus;
		private System.Windows.Forms.ContextMenuStrip cmsFines;
		private System.Windows.Forms.ToolStripMenuItem payFineToolStripMenuItem;
	}
}