namespace Library
{
	partial class frmSettings
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
			this.lblTitle = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.nudOneMonthSubscription = new Guna.UI2.WinForms.Guna2NumericUpDown();
			this.nudThreeMonthSubscription = new Guna.UI2.WinForms.Guna2NumericUpDown();
			this.nudOneYearSubscription = new Guna.UI2.WinForms.Guna2NumericUpDown();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.nudLateReturnFinesAmount = new Guna.UI2.WinForms.Guna2NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.nudDefaultBorrowDays = new Guna.UI2.WinForms.Guna2NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.nudExtendBorrowDays = new Guna.UI2.WinForms.Guna2NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.nudExtendTimesPerBorrow = new Guna.UI2.WinForms.Guna2NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.nudDamagedFine = new Guna.UI2.WinForms.Guna2NumericUpDown();
			this.nudLostFine = new Guna.UI2.WinForms.Guna2NumericUpDown();
			this.label10 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nudOneMonthSubscription)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudThreeMonthSubscription)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudOneYearSubscription)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudLateReturnFinesAmount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudDefaultBorrowDays)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudExtendBorrowDays)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudExtendTimesPerBorrow)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudDamagedFine)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudLostFine)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.BackColor = System.Drawing.SystemColors.Control;
			this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.SteelBlue;
			this.lblTitle.Location = new System.Drawing.Point(180, 124);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(340, 55);
			this.lblTitle.TabIndex = 42;
			this.lblTitle.Text = "Library Settings";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(24, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(315, 32);
			this.label1.TabIndex = 43;
			this.label1.Text = "1-Month Subscription Fee:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.Control;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(24, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(315, 32);
			this.label2.TabIndex = 44;
			this.label2.Text = "3-Month Subscription Fee:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.Control;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(40, 144);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(299, 32);
			this.label3.TabIndex = 45;
			this.label3.Text = "1-Year Subscription Fee:";
			// 
			// nudOneMonthSubscription
			// 
			this.nudOneMonthSubscription.AutoRoundedCorners = true;
			this.nudOneMonthSubscription.BackColor = System.Drawing.Color.Transparent;
			this.nudOneMonthSubscription.BorderRadius = 17;
			this.nudOneMonthSubscription.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.nudOneMonthSubscription.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.nudOneMonthSubscription.Location = new System.Drawing.Point(395, 40);
			this.nudOneMonthSubscription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.nudOneMonthSubscription.Name = "nudOneMonthSubscription";
			this.nudOneMonthSubscription.Size = new System.Drawing.Size(115, 37);
			this.nudOneMonthSubscription.TabIndex = 46;
			this.nudOneMonthSubscription.UpDownButtonFillColor = System.Drawing.Color.Teal;
			// 
			// nudThreeMonthSubscription
			// 
			this.nudThreeMonthSubscription.AutoRoundedCorners = true;
			this.nudThreeMonthSubscription.BackColor = System.Drawing.Color.Transparent;
			this.nudThreeMonthSubscription.BorderRadius = 17;
			this.nudThreeMonthSubscription.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.nudThreeMonthSubscription.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.nudThreeMonthSubscription.Location = new System.Drawing.Point(395, 92);
			this.nudThreeMonthSubscription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.nudThreeMonthSubscription.Name = "nudThreeMonthSubscription";
			this.nudThreeMonthSubscription.Size = new System.Drawing.Size(115, 37);
			this.nudThreeMonthSubscription.TabIndex = 47;
			this.nudThreeMonthSubscription.UpDownButtonFillColor = System.Drawing.Color.Teal;
			// 
			// nudOneYearSubscription
			// 
			this.nudOneYearSubscription.AutoRoundedCorners = true;
			this.nudOneYearSubscription.BackColor = System.Drawing.Color.Transparent;
			this.nudOneYearSubscription.BorderRadius = 17;
			this.nudOneYearSubscription.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.nudOneYearSubscription.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.nudOneYearSubscription.Location = new System.Drawing.Point(395, 144);
			this.nudOneYearSubscription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.nudOneYearSubscription.Name = "nudOneYearSubscription";
			this.nudOneYearSubscription.Size = new System.Drawing.Size(115, 37);
			this.nudOneYearSubscription.TabIndex = 48;
			this.nudOneYearSubscription.UpDownButtonFillColor = System.Drawing.Color.Teal;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
			this.groupBox1.Controls.Add(this.nudOneYearSubscription);
			this.groupBox1.Controls.Add(this.nudThreeMonthSubscription);
			this.groupBox1.Controls.Add(this.nudOneMonthSubscription);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(74, 187);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(557, 188);
			this.groupBox1.TabIndex = 49;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Subscription Settings";
			// 
			// nudLateReturnFinesAmount
			// 
			this.nudLateReturnFinesAmount.AutoRoundedCorners = true;
			this.nudLateReturnFinesAmount.BackColor = System.Drawing.Color.Transparent;
			this.nudLateReturnFinesAmount.BorderRadius = 17;
			this.nudLateReturnFinesAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.nudLateReturnFinesAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.nudLateReturnFinesAmount.Location = new System.Drawing.Point(395, 38);
			this.nudLateReturnFinesAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.nudLateReturnFinesAmount.Name = "nudLateReturnFinesAmount";
			this.nudLateReturnFinesAmount.Size = new System.Drawing.Size(115, 37);
			this.nudLateReturnFinesAmount.TabIndex = 51;
			this.nudLateReturnFinesAmount.UpDownButtonFillColor = System.Drawing.Color.Teal;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.SystemColors.Control;
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(21, 38);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(316, 32);
			this.label4.TabIndex = 50;
			this.label4.Text = "Late Return Fines Amount:";
			// 
			// nudDefaultBorrowDays
			// 
			this.nudDefaultBorrowDays.AutoRoundedCorners = true;
			this.nudDefaultBorrowDays.BackColor = System.Drawing.Color.Transparent;
			this.nudDefaultBorrowDays.BorderRadius = 17;
			this.nudDefaultBorrowDays.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.nudDefaultBorrowDays.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.nudDefaultBorrowDays.Location = new System.Drawing.Point(395, 89);
			this.nudDefaultBorrowDays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.nudDefaultBorrowDays.Name = "nudDefaultBorrowDays";
			this.nudDefaultBorrowDays.Size = new System.Drawing.Size(115, 37);
			this.nudDefaultBorrowDays.TabIndex = 53;
			this.nudDefaultBorrowDays.UpDownButtonFillColor = System.Drawing.Color.Teal;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.SystemColors.Control;
			this.label5.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(83, 89);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(259, 32);
			this.label5.TabIndex = 52;
			this.label5.Text = "Default Borrow Days:";
			// 
			// nudExtendBorrowDays
			// 
			this.nudExtendBorrowDays.AutoRoundedCorners = true;
			this.nudExtendBorrowDays.BackColor = System.Drawing.Color.Transparent;
			this.nudExtendBorrowDays.BorderRadius = 17;
			this.nudExtendBorrowDays.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.nudExtendBorrowDays.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.nudExtendBorrowDays.Location = new System.Drawing.Point(395, 140);
			this.nudExtendBorrowDays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.nudExtendBorrowDays.Name = "nudExtendBorrowDays";
			this.nudExtendBorrowDays.Size = new System.Drawing.Size(115, 37);
			this.nudExtendBorrowDays.TabIndex = 55;
			this.nudExtendBorrowDays.UpDownButtonFillColor = System.Drawing.Color.Teal;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.SystemColors.Control;
			this.label6.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(89, 140);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(253, 32);
			this.label6.TabIndex = 54;
			this.label6.Text = "Extend Borrow Days:";
			// 
			// nudExtendTimesPerBorrow
			// 
			this.nudExtendTimesPerBorrow.AutoRoundedCorners = true;
			this.nudExtendTimesPerBorrow.BackColor = System.Drawing.Color.Transparent;
			this.nudExtendTimesPerBorrow.BorderRadius = 17;
			this.nudExtendTimesPerBorrow.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.nudExtendTimesPerBorrow.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.nudExtendTimesPerBorrow.Location = new System.Drawing.Point(395, 191);
			this.nudExtendTimesPerBorrow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.nudExtendTimesPerBorrow.Name = "nudExtendTimesPerBorrow";
			this.nudExtendTimesPerBorrow.Size = new System.Drawing.Size(115, 37);
			this.nudExtendTimesPerBorrow.TabIndex = 57;
			this.nudExtendTimesPerBorrow.UpDownButtonFillColor = System.Drawing.Color.Teal;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.SystemColors.Control;
			this.label7.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(29, 191);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(309, 32);
			this.label7.TabIndex = 56;
			this.label7.Text = "Extend Times Per Borrow:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.nudExtendTimesPerBorrow);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.nudExtendBorrowDays);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.nudDefaultBorrowDays);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.nudLateReturnFinesAmount);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(74, 387);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(557, 238);
			this.groupBox2.TabIndex = 58;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Borrow Settings";
			// 
			// btnSave
			// 
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Image = global::Library.Properties.Resources.Savebtn;
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new System.Drawing.Point(488, 786);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(143, 47);
			this.btnSave.TabIndex = 60;
			this.btnSave.Text = "Save";
			this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnClose
			// 
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = global::Library.Properties.Resources.Closebtn;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(323, 786);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(143, 47);
			this.btnClose.TabIndex = 59;
			this.btnClose.Text = "Close";
			this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// guna2PictureBox1
			// 
			this.guna2PictureBox1.Image = global::Library.Properties.Resources.settings128_1_;
			this.guna2PictureBox1.ImageRotate = 0F;
			this.guna2PictureBox1.Location = new System.Drawing.Point(274, 1);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.Size = new System.Drawing.Size(142, 120);
			this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.guna2PictureBox1.TabIndex = 0;
			this.guna2PictureBox1.TabStop = false;
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.nudDamagedFine);
			this.groupBox3.Controls.Add(this.nudLostFine);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox3.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(77, 638);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(557, 137);
			this.groupBox3.TabIndex = 61;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Fine Settings";
			// 
			// nudDamagedFine
			// 
			this.nudDamagedFine.AutoRoundedCorners = true;
			this.nudDamagedFine.BackColor = System.Drawing.Color.Transparent;
			this.nudDamagedFine.BorderRadius = 17;
			this.nudDamagedFine.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.nudDamagedFine.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.nudDamagedFine.Location = new System.Drawing.Point(395, 88);
			this.nudDamagedFine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.nudDamagedFine.Name = "nudDamagedFine";
			this.nudDamagedFine.Size = new System.Drawing.Size(115, 37);
			this.nudDamagedFine.TabIndex = 47;
			this.nudDamagedFine.UpDownButtonFillColor = System.Drawing.Color.Teal;
			// 
			// nudLostFine
			// 
			this.nudLostFine.AutoRoundedCorners = true;
			this.nudLostFine.BackColor = System.Drawing.Color.Transparent;
			this.nudLostFine.BorderRadius = 17;
			this.nudLostFine.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.nudLostFine.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.nudLostFine.Location = new System.Drawing.Point(395, 40);
			this.nudLostFine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.nudLostFine.Name = "nudLostFine";
			this.nudLostFine.Size = new System.Drawing.Size(115, 37);
			this.nudLostFine.TabIndex = 46;
			this.nudLostFine.UpDownButtonFillColor = System.Drawing.Color.Teal;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.SystemColors.Control;
			this.label10.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(60, 41);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(279, 32);
			this.label10.TabIndex = 43;
			this.label10.Text = "Lost Book Fine Amount:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.SystemColors.Control;
			this.label8.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(7, 88);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(332, 32);
			this.label8.TabIndex = 48;
			this.label8.Text = "Damaged Book Fine Amount:";
			// 
			// frmSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(711, 954);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.guna2PictureBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSettings";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmSettings";
			this.Load += new System.EventHandler(this.frmSettings_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudOneMonthSubscription)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudThreeMonthSubscription)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudOneYearSubscription)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudLateReturnFinesAmount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudDefaultBorrowDays)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudExtendBorrowDays)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudExtendTimesPerBorrow)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudDamagedFine)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudLostFine)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private Guna.UI2.WinForms.Guna2NumericUpDown nudOneMonthSubscription;
		private Guna.UI2.WinForms.Guna2NumericUpDown nudThreeMonthSubscription;
		private Guna.UI2.WinForms.Guna2NumericUpDown nudOneYearSubscription;
		private System.Windows.Forms.GroupBox groupBox1;
		private Guna.UI2.WinForms.Guna2NumericUpDown nudLateReturnFinesAmount;
		private System.Windows.Forms.Label label4;
		private Guna.UI2.WinForms.Guna2NumericUpDown nudDefaultBorrowDays;
		private System.Windows.Forms.Label label5;
		private Guna.UI2.WinForms.Guna2NumericUpDown nudExtendBorrowDays;
		private System.Windows.Forms.Label label6;
		private Guna.UI2.WinForms.Guna2NumericUpDown nudExtendTimesPerBorrow;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.GroupBox groupBox3;
		private Guna.UI2.WinForms.Guna2NumericUpDown nudDamagedFine;
		private Guna.UI2.WinForms.Guna2NumericUpDown nudLostFine;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label8;
	}
}