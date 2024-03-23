namespace NtofosApplication.PresentationLayer
{
	partial class frmDetails
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
			lbID = new Label();
			lbName = new Label();
			lbArtists = new Label();
			lbCreator = new Label();
			lbReleaseDate = new Label();
			lbFilePath = new Label();
			txtID = new TextBox();
			txtFilePath = new TextBox();
			txtCreator = new TextBox();
			txtArtists = new TextBox();
			txtName = new TextBox();
			dtpRealeasedDate = new DateTimePicker();
			btnUpload = new Button();
			btnSave = new Button();
			btnCancel = new Button();
			lbTask = new Label();
			txtGenre = new TextBox();
			lbGenre = new Label();
			SuspendLayout();
			// 
			// lbID
			// 
			lbID.AutoSize = true;
			lbID.Location = new Point(45, 81);
			lbID.Name = "lbID";
			lbID.Size = new Size(24, 20);
			lbID.TabIndex = 0;
			lbID.Text = "ID";
			// 
			// lbName
			// 
			lbName.AutoSize = true;
			lbName.Location = new Point(45, 121);
			lbName.Name = "lbName";
			lbName.Size = new Size(49, 20);
			lbName.TabIndex = 1;
			lbName.Text = "Name";
			// 
			// lbArtists
			// 
			lbArtists.AutoSize = true;
			lbArtists.Location = new Point(45, 161);
			lbArtists.Name = "lbArtists";
			lbArtists.Size = new Size(50, 20);
			lbArtists.TabIndex = 2;
			lbArtists.Text = "Artists";
			// 
			// lbCreator
			// 
			lbCreator.AutoSize = true;
			lbCreator.Location = new Point(45, 201);
			lbCreator.Name = "lbCreator";
			lbCreator.Size = new Size(58, 20);
			lbCreator.TabIndex = 3;
			lbCreator.Text = "Creator";
			// 
			// lbReleaseDate
			// 
			lbReleaseDate.AutoSize = true;
			lbReleaseDate.Location = new Point(45, 281);
			lbReleaseDate.Name = "lbReleaseDate";
			lbReleaseDate.Size = new Size(96, 20);
			lbReleaseDate.TabIndex = 4;
			lbReleaseDate.Text = "Release Date";
			// 
			// lbFilePath
			// 
			lbFilePath.AutoSize = true;
			lbFilePath.Location = new Point(45, 321);
			lbFilePath.Name = "lbFilePath";
			lbFilePath.Size = new Size(64, 20);
			lbFilePath.TabIndex = 5;
			lbFilePath.Text = "File Path";
			// 
			// txtID
			// 
			txtID.Enabled = false;
			txtID.Location = new Point(195, 81);
			txtID.Name = "txtID";
			txtID.PlaceholderText = "ID will be generated automatically";
			txtID.Size = new Size(250, 27);
			txtID.TabIndex = 6;
			// 
			// txtFilePath
			// 
			txtFilePath.Enabled = false;
			txtFilePath.Location = new Point(195, 321);
			txtFilePath.Name = "txtFilePath";
			txtFilePath.Size = new Size(250, 27);
			txtFilePath.TabIndex = 8;
			// 
			// txtCreator
			// 
			txtCreator.Location = new Point(195, 201);
			txtCreator.Name = "txtCreator";
			txtCreator.Size = new Size(250, 27);
			txtCreator.TabIndex = 9;
			// 
			// txtArtists
			// 
			txtArtists.Location = new Point(196, 161);
			txtArtists.Name = "txtArtists";
			txtArtists.Size = new Size(250, 27);
			txtArtists.TabIndex = 10;
			// 
			// txtName
			// 
			txtName.Location = new Point(195, 121);
			txtName.Name = "txtName";
			txtName.Size = new Size(250, 27);
			txtName.TabIndex = 11;
			// 
			// dtpRealeasedDate
			// 
			dtpRealeasedDate.Location = new Point(195, 281);
			dtpRealeasedDate.Name = "dtpRealeasedDate";
			dtpRealeasedDate.Size = new Size(250, 27);
			dtpRealeasedDate.TabIndex = 12;
			// 
			// btnUpload
			// 
			btnUpload.Location = new Point(475, 321);
			btnUpload.Name = "btnUpload";
			btnUpload.Size = new Size(94, 29);
			btnUpload.TabIndex = 13;
			btnUpload.Text = "Upload";
			btnUpload.UseVisualStyleBackColor = true;
			btnUpload.Click += btnUpload_Click;
			// 
			// btnSave
			// 
			btnSave.DialogResult = DialogResult.OK;
			btnSave.Location = new Point(196, 381);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(94, 29);
			btnSave.TabIndex = 14;
			btnSave.Text = "Save";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(352, 381);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(94, 29);
			btnCancel.TabIndex = 15;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			btnCancel.Click += btnCancel_Click;
			// 
			// lbTask
			// 
			lbTask.AutoSize = true;
			lbTask.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lbTask.Location = new Point(12, 25);
			lbTask.Name = "lbTask";
			lbTask.Size = new Size(62, 26);
			lbTask.TabIndex = 16;
			lbTask.Text = "Task";
			// 
			// txtGenre
			// 
			txtGenre.Location = new Point(195, 241);
			txtGenre.Name = "txtGenre";
			txtGenre.Size = new Size(250, 27);
			txtGenre.TabIndex = 18;
			// 
			// lbGenre
			// 
			lbGenre.AutoSize = true;
			lbGenre.Location = new Point(45, 241);
			lbGenre.Name = "lbGenre";
			lbGenre.Size = new Size(48, 20);
			lbGenre.TabIndex = 17;
			lbGenre.Text = "Genre";
			// 
			// frmDetails
			// 
			AcceptButton = btnSave;
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = btnCancel;
			ClientSize = new Size(591, 450);
			Controls.Add(txtGenre);
			Controls.Add(lbGenre);
			Controls.Add(lbTask);
			Controls.Add(btnCancel);
			Controls.Add(btnSave);
			Controls.Add(btnUpload);
			Controls.Add(dtpRealeasedDate);
			Controls.Add(txtName);
			Controls.Add(txtArtists);
			Controls.Add(txtCreator);
			Controls.Add(txtFilePath);
			Controls.Add(txtID);
			Controls.Add(lbFilePath);
			Controls.Add(lbReleaseDate);
			Controls.Add(lbCreator);
			Controls.Add(lbArtists);
			Controls.Add(lbName);
			Controls.Add(lbID);
			Name = "frmDetails";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmDetails";
			Load += frmDetails_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lbID;
		private Label lbName;
		private Label lbArtists;
		private Label lbCreator;
		private Label lbReleaseDate;
		private Label lbFilePath;
		private TextBox txtID;
		private TextBox txtFilePath;
		private TextBox txtCreator;
		private TextBox txtArtists;
		private TextBox txtName;
		private DateTimePicker dtpRealeasedDate;
		private Button btnUpload;
		private Button btnSave;
		private Button btnCancel;
		private Label lbTask;
		private TextBox txtGenre;
		private Label lbGenre;
	}
}