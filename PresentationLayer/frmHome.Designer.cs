namespace NtofosApplication.PresentationLayer
{
	partial class frmHome
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
			lbLabel = new Label();
			gbBox = new GroupBox();
			btnLogout = new Button();
			gbPlay = new GroupBox();
			lbTitle = new Label();
			btnVideo = new Button();
			btnStop = new Button();
			btnPause = new Button();
			btnPlay = new Button();
			btnNext = new Button();
			btnPreview = new Button();
			prgSeek = new ProgressBar();
			txtSearch = new TextBox();
			picUser = new PictureBox();
			dgvSongs = new DataGridView();
			dgvVideos = new DataGridView();
			label1 = new Label();
			label2 = new Label();
			gbBox.SuspendLayout();
			gbPlay.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgvSongs).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgvVideos).BeginInit();
			SuspendLayout();
			// 
			// lbLabel
			// 
			lbLabel.AutoSize = true;
			lbLabel.Font = new Font("Vivaldi", 22.2F, FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout, GraphicsUnit.Point);
			lbLabel.Location = new Point(22, 23);
			lbLabel.Name = "lbLabel";
			lbLabel.Size = new Size(116, 44);
			lbLabel.TabIndex = 0;
			lbLabel.Text = "Ntofos";
			// 
			// gbBox
			// 
			gbBox.Controls.Add(btnLogout);
			gbBox.Controls.Add(lbLabel);
			gbBox.Location = new Point(15, 25);
			gbBox.Name = "gbBox";
			gbBox.Size = new Size(165, 513);
			gbBox.TabIndex = 1;
			gbBox.TabStop = false;
			// 
			// btnLogout
			// 
			btnLogout.DialogResult = DialogResult.Cancel;
			btnLogout.Location = new Point(22, 464);
			btnLogout.Name = "btnLogout";
			btnLogout.Size = new Size(116, 43);
			btnLogout.TabIndex = 1;
			btnLogout.Text = "Logout";
			btnLogout.UseVisualStyleBackColor = true;
			btnLogout.Click += btnLogout_Click;
			// 
			// gbPlay
			// 
			gbPlay.Controls.Add(lbTitle);
			gbPlay.Controls.Add(btnVideo);
			gbPlay.Controls.Add(btnStop);
			gbPlay.Controls.Add(btnPause);
			gbPlay.Controls.Add(btnPlay);
			gbPlay.Controls.Add(btnNext);
			gbPlay.Controls.Add(btnPreview);
			gbPlay.Controls.Add(prgSeek);
			gbPlay.Location = new Point(15, 556);
			gbPlay.Name = "gbPlay";
			gbPlay.Size = new Size(1013, 96);
			gbPlay.TabIndex = 3;
			gbPlay.TabStop = false;
			// 
			// lbTitle
			// 
			lbTitle.AutoSize = true;
			lbTitle.Location = new Point(28, 45);
			lbTitle.Name = "lbTitle";
			lbTitle.Size = new Size(66, 20);
			lbTitle.TabIndex = 8;
			lbTitle.Text = "Playing...";
			// 
			// btnVideo
			// 
			btnVideo.BackColor = SystemColors.HighlightText;
			btnVideo.BackgroundImage = Properties.Resources.video;
			btnVideo.BackgroundImageLayout = ImageLayout.Zoom;
			btnVideo.Cursor = Cursors.Hand;
			btnVideo.Location = new Point(930, 33);
			btnVideo.Name = "btnVideo";
			btnVideo.Size = new Size(47, 44);
			btnVideo.TabIndex = 7;
			btnVideo.UseVisualStyleBackColor = false;
			btnVideo.Click += btnVideo_Click;
			// 
			// btnStop
			// 
			btnStop.BackColor = SystemColors.HighlightText;
			btnStop.BackgroundImage = Properties.Resources.stop;
			btnStop.BackgroundImageLayout = ImageLayout.Zoom;
			btnStop.Cursor = Cursors.Hand;
			btnStop.Location = new Point(601, 33);
			btnStop.Name = "btnStop";
			btnStop.Size = new Size(47, 44);
			btnStop.TabIndex = 6;
			btnStop.UseVisualStyleBackColor = false;
			btnStop.Click += btnStop_Click;
			// 
			// btnPause
			// 
			btnPause.BackColor = SystemColors.HighlightText;
			btnPause.BackgroundImage = Properties.Resources.pause;
			btnPause.BackgroundImageLayout = ImageLayout.Zoom;
			btnPause.Cursor = Cursors.Hand;
			btnPause.Location = new Point(548, 33);
			btnPause.Name = "btnPause";
			btnPause.Size = new Size(47, 44);
			btnPause.TabIndex = 5;
			btnPause.UseVisualStyleBackColor = false;
			btnPause.Click += btnPause_Click;
			// 
			// btnPlay
			// 
			btnPlay.BackColor = SystemColors.HighlightText;
			btnPlay.BackgroundImage = Properties.Resources.play;
			btnPlay.BackgroundImageLayout = ImageLayout.Zoom;
			btnPlay.Cursor = Cursors.Hand;
			btnPlay.Location = new Point(495, 33);
			btnPlay.Name = "btnPlay";
			btnPlay.Size = new Size(47, 44);
			btnPlay.TabIndex = 3;
			btnPlay.UseVisualStyleBackColor = false;
			btnPlay.Click += btnPlay_Click;
			// 
			// btnNext
			// 
			btnNext.BackColor = SystemColors.HighlightText;
			btnNext.BackgroundImage = Properties.Resources.next;
			btnNext.BackgroundImageLayout = ImageLayout.Zoom;
			btnNext.Cursor = Cursors.Hand;
			btnNext.Location = new Point(442, 33);
			btnNext.Name = "btnNext";
			btnNext.Size = new Size(47, 44);
			btnNext.TabIndex = 2;
			btnNext.UseVisualStyleBackColor = false;
			btnNext.Click += btnNext_Click;
			// 
			// btnPreview
			// 
			btnPreview.BackColor = SystemColors.HighlightText;
			btnPreview.BackgroundImage = Properties.Resources.preview;
			btnPreview.BackgroundImageLayout = ImageLayout.Zoom;
			btnPreview.Cursor = Cursors.Hand;
			btnPreview.Location = new Point(389, 33);
			btnPreview.Name = "btnPreview";
			btnPreview.Size = new Size(47, 44);
			btnPreview.TabIndex = 1;
			btnPreview.UseVisualStyleBackColor = false;
			btnPreview.Click += btnPreview_Click;
			// 
			// prgSeek
			// 
			prgSeek.BackColor = SystemColors.ActiveCaptionText;
			prgSeek.Cursor = Cursors.Hand;
			prgSeek.Location = new Point(28, 12);
			prgSeek.Name = "prgSeek";
			prgSeek.Size = new Size(949, 10);
			prgSeek.TabIndex = 0;
			// 
			// txtSearch
			// 
			txtSearch.Location = new Point(251, 25);
			txtSearch.Name = "txtSearch";
			txtSearch.PlaceholderText = "Search...";
			txtSearch.Size = new Size(217, 27);
			txtSearch.TabIndex = 4;
			// 
			// picUser
			// 
			picUser.Image = Properties.Resources.user;
			picUser.Location = new Point(960, 25);
			picUser.Name = "picUser";
			picUser.Size = new Size(43, 39);
			picUser.SizeMode = PictureBoxSizeMode.Zoom;
			picUser.TabIndex = 6;
			picUser.TabStop = false;
			// 
			// dgvSongs
			// 
			dgvSongs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvSongs.BackgroundColor = SystemColors.Control;
			dgvSongs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvSongs.ColumnHeadersVisible = false;
			dgvSongs.Cursor = Cursors.AppStarting;
			dgvSongs.Location = new Point(257, 105);
			dgvSongs.Name = "dgvSongs";
			dgvSongs.ReadOnly = true;
			dgvSongs.RowHeadersVisible = false;
			dgvSongs.RowHeadersWidth = 51;
			dgvSongs.RowTemplate.Height = 29;
			dgvSongs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvSongs.Size = new Size(267, 427);
			dgvSongs.TabIndex = 7;
			dgvSongs.CellDoubleClick += dgvSongs_CellDoubleClick;
			// 
			// dgvVideos
			// 
			dgvVideos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvVideos.BackgroundColor = SystemColors.Control;
			dgvVideos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvVideos.ColumnHeadersVisible = false;
			dgvVideos.Cursor = Cursors.AppStarting;
			dgvVideos.Location = new Point(687, 105);
			dgvVideos.Name = "dgvVideos";
			dgvVideos.ReadOnly = true;
			dgvVideos.RowHeadersVisible = false;
			dgvVideos.RowHeadersWidth = 51;
			dgvVideos.RowTemplate.Height = 29;
			dgvVideos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvVideos.Size = new Size(267, 427);
			dgvVideos.TabIndex = 8;
			dgvVideos.CellContentDoubleClick += dgvVideos_CellDoubleClick;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(361, 78);
			label1.Name = "label1";
			label1.Size = new Size(70, 24);
			label1.TabIndex = 9;
			label1.Text = "Songs";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(788, 78);
			label2.Name = "label2";
			label2.Size = new Size(79, 24);
			label2.TabIndex = 10;
			label2.Text = "Videos";
			// 
			// frmHome
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1051, 665);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(dgvVideos);
			Controls.Add(dgvSongs);
			Controls.Add(picUser);
			Controls.Add(txtSearch);
			Controls.Add(gbPlay);
			Controls.Add(gbBox);
			FormBorderStyle = FormBorderStyle.None;
			Name = "frmHome";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmHome";
			Load += frmHome_Load;
			gbBox.ResumeLayout(false);
			gbBox.PerformLayout();
			gbPlay.ResumeLayout(false);
			gbPlay.PerformLayout();
			((System.ComponentModel.ISupportInitialize)picUser).EndInit();
			((System.ComponentModel.ISupportInitialize)dgvSongs).EndInit();
			((System.ComponentModel.ISupportInitialize)dgvVideos).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lbLabel;
		private GroupBox gbBox;
		private GroupBox gbPlay;
		private Label lbTitle;
		private Button btnVideo;
		private Button btnStop;
		private Button btnPause;
		private Button btnPlay;
		private Button btnNext;
		private Button btnPreview;
		private ProgressBar prgSeek;
		private Button btnLogout;
		private TextBox txtSearch;
		private PictureBox picUser;
		private DataGridView dgvSongs;
		private DataGridView dgvVideos;
		private Label label1;
		private Label label2;
	}
}