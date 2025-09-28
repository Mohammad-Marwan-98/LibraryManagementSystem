namespace Library.Books
{
	partial class ctrlFindBook
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.ctrlBookDetails1 = new Library.ctrlBookDetails();
			this.label10 = new System.Windows.Forms.Label();
			this.txtBookId = new Guna.UI2.WinForms.Guna2TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// ctrlBookDetails1
			// 
			this.ctrlBookDetails1.Location = new System.Drawing.Point(3, 3);
			this.ctrlBookDetails1.Name = "ctrlBookDetails1";
			this.ctrlBookDetails1.Size = new System.Drawing.Size(1162, 691);
			this.ctrlBookDetails1.TabIndex = 0;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.SystemColors.Control;
			this.label10.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(49, 143);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(139, 39);
			this.label10.TabIndex = 72;
			this.label10.Text = "Book ID:";
			// 
			// txtBookId
			// 
			this.txtBookId.AutoRoundedCorners = true;
			this.txtBookId.BorderRadius = 18;
			this.txtBookId.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtBookId.DefaultText = "";
			this.txtBookId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtBookId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtBookId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtBookId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtBookId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtBookId.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtBookId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtBookId.Location = new System.Drawing.Point(194, 144);
			this.txtBookId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtBookId.Name = "txtBookId";
			this.txtBookId.PasswordChar = '\0';
			this.txtBookId.PlaceholderText = "";
			this.txtBookId.SelectedText = "";
			this.txtBookId.Size = new System.Drawing.Size(190, 38);
			this.txtBookId.TabIndex = 73;
			this.txtBookId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBookId_KeyPress);
			this.txtBookId.Validating += new System.ComponentModel.CancelEventHandler(this.txtBookId_Validating);
			// 
			// btnSearch
			// 
			this.btnSearch.Image = global::Library.Properties.Resources.Search32;
			this.btnSearch.Location = new System.Drawing.Point(401, 142);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(46, 44);
			this.btnSearch.TabIndex = 74;
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// ctrlFindBook
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtBookId);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.ctrlBookDetails1);
			this.Name = "ctrlFindBook";
			this.Size = new System.Drawing.Size(1173, 705);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ctrlBookDetails ctrlBookDetails1;
		private System.Windows.Forms.Label label10;
		private Guna.UI2.WinForms.Guna2TextBox txtBookId;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}
