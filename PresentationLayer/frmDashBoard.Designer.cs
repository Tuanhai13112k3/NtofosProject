namespace NtofosApplication.PresentationLayer
{
	partial class frmDashBoard
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
			components = new System.ComponentModel.Container();
			btnUser = new Button();
			btnFilms = new Button();
			btnSongs = new Button();
			btnLogout = new Button();
			dgvList = new DataGridView();
			picAdmin = new PictureBox();
			lbAdmin = new Label();
			label1 = new Label();
			lbList = new Label();
			menuStrip = new ContextMenuStrip(components);
			btnUpload = new Button();
			((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
			((System.ComponentModel.ISupportInitialize)picAdmin).BeginInit();
			SuspendLayout();
			// 
			// btnUser
			// 
			btnUser.Location = new Point(12, 219);
			btnUser.Name = "btnUser";
			btnUser.Size = new Size(197, 54);
			btnUser.TabIndex = 0;
			btnUser.Text = "Manage Users";
			btnUser.UseVisualStyleBackColor = true;
			btnUser.Click += btnUser_Click;
			// 
			// btnFilms
			// 
			btnFilms.Location = new Point(12, 429);
			btnFilms.Name = "btnFilms";
			btnFilms.Size = new Size(197, 54);
			btnFilms.TabIndex = 1;
			btnFilms.Text = "Manage Videos";
			btnFilms.UseVisualStyleBackColor = true;
			btnFilms.Click += btnFilms_Click;
			// 
			// btnSongs
			// 
			btnSongs.Location = new Point(12, 324);
			btnSongs.Name = "btnSongs";
			btnSongs.Size = new Size(197, 54);
			btnSongs.TabIndex = 2;
			btnSongs.Text = "Manage Songs";
			btnSongs.UseVisualStyleBackColor = true;
			btnSongs.Click += btnSongs_Click;
			// 
			// btnLogout
			// 
			btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnLogout.DialogResult = DialogResult.Cancel;
			btnLogout.Location = new Point(12, 567);
			btnLogout.Name = "btnLogout";
			btnLogout.Size = new Size(197, 54);
			btnLogout.TabIndex = 3;
			btnLogout.Text = "Logout";
			btnLogout.UseVisualStyleBackColor = true;
			btnLogout.Click += btnLogout_Click;
			// 
			// dgvList
			// 
			dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dgvList.BackgroundColor = SystemColors.Window;
			dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvList.Location = new Point(254, 100);
			dgvList.Name = "dgvList";
			dgvList.ReadOnly = true;
			dgvList.RowHeadersVisible = false;
			dgvList.RowHeadersWidth = 51;
			dgvList.RowTemplate.Height = 29;
			dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvList.Size = new Size(1076, 521);
			dgvList.TabIndex = 4;
			dgvList.CellMouseClick += dgvList_CellMouseClick;
			// 
			// picAdmin
			// 
			picAdmin.Image = Properties.Resources.admin;
			picAdmin.Location = new Point(12, 71);
			picAdmin.Name = "picAdmin";
			picAdmin.Size = new Size(197, 62);
			picAdmin.SizeMode = PictureBoxSizeMode.Zoom;
			picAdmin.TabIndex = 5;
			picAdmin.TabStop = false;
			// 
			// lbAdmin
			// 
			lbAdmin.AutoSize = true;
			lbAdmin.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lbAdmin.Location = new Point(24, 136);
			lbAdmin.Name = "lbAdmin";
			lbAdmin.Size = new Size(174, 26);
			lbAdmin.TabIndex = 6;
			lbAdmin.Text = "Administrator";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Underline, GraphicsUnit.Point);
			label1.Location = new Point(254, 71);
			label1.Name = "label1";
			label1.Size = new Size(0, 23);
			label1.TabIndex = 7;
			// 
			// lbList
			// 
			lbList.AutoSize = true;
			lbList.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
			lbList.Location = new Point(254, 74);
			lbList.Name = "lbList";
			lbList.Size = new Size(36, 23);
			lbList.TabIndex = 8;
			lbList.Text = "List";
			// 
			// menuStrip
			// 
			menuStrip.ImageScalingSize = new Size(20, 20);
			menuStrip.Name = "menuStrip";
			menuStrip.RenderMode = ToolStripRenderMode.Professional;
			menuStrip.Size = new Size(61, 4);
			// 
			// btnUpload
			// 
			btnUpload.Location = new Point(1181, 55);
			btnUpload.Name = "btnUpload";
			btnUpload.Size = new Size(149, 39);
			btnUpload.TabIndex = 9;
			btnUpload.Text = "Upload";
			btnUpload.UseVisualStyleBackColor = true;
			btnUpload.Click += btnUpload_Click;
			// 
			// frmDashBoard
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoScroll = true;
			AutoSize = true;
			BackColor = SystemColors.Window;
			ClientSize = new Size(1342, 633);
			Controls.Add(btnUpload);
			Controls.Add(lbList);
			Controls.Add(label1);
			Controls.Add(lbAdmin);
			Controls.Add(picAdmin);
			Controls.Add(dgvList);
			Controls.Add(btnLogout);
			Controls.Add(btnSongs);
			Controls.Add(btnFilms);
			Controls.Add(btnUser);
			Name = "frmDashBoard";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Admin Dashboard";
			Load += frmDashBoard_Load;
			((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
			((System.ComponentModel.ISupportInitialize)picAdmin).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnUser;
		private Button btnFilms;
		private Button btnSongs;
		private Button btnLogout;
		private DataGridView dgvList;
		private PictureBox picAdmin;
		private Label lbAdmin;
		private Label label1;
		private Label lbList;
		private ContextMenuStrip menuStrip;
		private Button btnUpload;
	}
}