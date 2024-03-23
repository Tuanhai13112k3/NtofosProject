using NtofosApplication.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NtofosApplication.PresentationLayer
{
	public partial class frmDetails : Form
	{
		private NtofosContext context;
		private const string SONGPATH = @"C:\Users\acer\OneDrive\Documents\CS\NtofosApplication\Data\Songs\";
		private const string VIDEOPATH = @"C:\Users\acer\OneDrive\Documents\CS\NtofosApplication\Data\Films\";
		public bool InsertOrUpdate { get; set; } //T=Update, F=Insert
		public dynamic ItemInfo { get; set; }
		public frmDetails()
		{
			InitializeComponent();
			context = new NtofosContext();
		}

		private void frmDetails_Load(object sender, EventArgs e)
		{

			if (InsertOrUpdate == true)
			{
				
				if (ItemInfo.GetType() == typeof(Film))
				{
					lbTask.Text = $"{ItemInfo.GetType().Name} Details";
					var film = (Film)ItemInfo;

					lbID.Text = "Film ID";
					txtID.Text = film.FilmId.ToString();

					lbName.Text = "Film Name";
					txtName.Text = film.FilmName;

					txtArtists.Text = film.Artists;

					lbCreator.Text = "Composer";
					txtCreator.Text = film.Creator;

					txtGenre.Text = film.Genre;

					dtpRealeasedDate.Text = film.ReleaseDate.ToString();
					txtFilePath.Text = film.FilePath.ToString();
				}
				if (ItemInfo.GetType() == typeof(Song))
				{
					lbTask.Text = $"{ItemInfo.GetType().Name} Details";
					var song = (Song)ItemInfo;
					lbID.Text = "Song ID";
					txtID.Text = song.SongId.ToString();

					lbName.Text = "Song Name";
					txtName.Text = song.SongName;

					txtArtists.Text = song.Artists;

					lbCreator.Text = "Composer";
					txtCreator.Text = song.Composer;

					txtGenre.Text = song.Genre != null ? song.Genre : string.Empty;

					dtpRealeasedDate.Text = song.ReleaseDate.ToString();
					txtFilePath.Text = song.FilePath;
				}
			}
            else
            {
				if (ItemInfo.GetType() == typeof(Film))
				{
					lbTask.Text = $"Upload {ItemInfo.GetType().Name}";
					lbID.Text = "Film ID";
					lbName.Text = "Film Name";
					lbCreator.Text = "Composer";
				}
				if (ItemInfo.GetType() == typeof(Song))
				{
					lbTask.Text = $"Upload {ItemInfo.GetType().Name}";
					lbID.Text = "Song ID";
					lbName.Text = "Song Name";
					lbCreator.Text = "Composer";
				}
			}
        }

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (ItemInfo.GetType() == typeof(Film))
				{
					var film = new Film
					{
						FilmName = txtName.Text,
						Artists = txtArtists.Text,
						Creator = txtCreator.Text,
						Genre = txtGenre.Text,
						ReleaseDate = dtpRealeasedDate.Value,
						FilePath = txtFilePath.Text,
					};
					if (InsertOrUpdate == false)
					{
						context.Films.Add(film);
						context.SaveChanges();
					}
					else
					{
						film.FilmId = int.Parse(txtID.Text);
						film.UploadedBy = UserSession.CurrentUser.UserId;
						context.Films.Update(film);
						context.SaveChanges();
					}
				}
				if (ItemInfo.GetType() == typeof(Song))
				{
					var song = new Song
					{
						SongName = txtName.Text,
						Artists = txtArtists.Text,
						Composer = txtCreator.Text,
						Genre = txtGenre.Text,
						ReleaseDate = dtpRealeasedDate.Value,
						FilePath = txtFilePath.Text,
					};
					if (InsertOrUpdate == false)
					{
						context.Songs.Add(song);
						context.SaveChanges();
					}
					else
					{
						song.SongId = int.Parse(txtID.Text);
						song.UploadedBy = UserSession.CurrentUser.UserId;
						context.Songs.Update(song);
						context.SaveChanges();
					}
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, InsertOrUpdate == false ? $"Add a new " +
					$"{ItemInfo.GetType().Name}" : $"Update a {ItemInfo.GetType().Name}");
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnUpload_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog1 = new OpenFileDialog();

			openFileDialog1.Filter = "MP3 files (*.mp3)|*.mp3|" +
				"MP4 files (*.mp4)|*.mp4|" +
				"All files (*.*)|*.*";
			openFileDialog1.FilterIndex = 1;
			openFileDialog1.RestoreDirectory = true;

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					string filePath = openFileDialog1.FileName;
					string fileName = Path.GetFileName(filePath);
					string destPath = null;
					
					if (ItemInfo.GetType() == typeof(Film))
					{
						var video= context.Films.FirstOrDefault(v => v.FilePath.Equals(fileName));
						if(video != null)
						{
							Random rnd = new Random();
							var randomUpperChar = (char)(rnd.Next(48, 122));
							fileName = fileName.Replace(".mp4", $"{randomUpperChar}.mp4");
						}
						destPath = Path.Combine(VIDEOPATH, fileName);
					}
					else
					{
						var song = context.Songs.FirstOrDefault(v => v.FilePath.Equals(fileName));
						if (song != null)
						{
							Random rnd = new Random();
							var randomUpperChar = (char)(rnd.Next(48, 122));
							fileName = fileName.Replace(".mp3", $"{randomUpperChar}.mp3");
						}
						destPath = Path.Combine(SONGPATH, fileName);

					}

					File.Copy(filePath, destPath, true);
					txtFilePath.Text = fileName;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message);
				}
			}
		}
	}
}
