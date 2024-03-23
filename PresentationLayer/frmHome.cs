using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NtofosApplication.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NtofosApplication.PresentationLayer
{
	public partial class frmHome : Form
	{
		private NtofosContext context;
		WMPLib.WindowsMediaPlayer player;
		private int PlayingIndex;
		private string type = null;
		private const string SONGPATH = @"C:\Users\acer\OneDrive\Documents\CS\NtofosApplication\Data\Songs\";
		private const string VIDEOPATH = @"C:\Users\acer\OneDrive\Documents\CS\NtofosApplication\Data\Films\";
		public double currentPosition;
		private dynamic ItemInfo;


		public frmHome()
		{
			InitializeComponent();
			context = new NtofosContext();
			player = new WMPLib.WindowsMediaPlayer();
		}

		private void frmHome_Load(object sender, EventArgs e)
		{

			LoadSongs();
			LoadVideos();
			txtSearch.TextChanged += TxtSearch_TextChanged;
		}

		private void ViewAccount(object? sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void TxtSearch_TextChanged(object? sender, EventArgs e)
		{
			var searchText = txtSearch.Text;
			var songs = context.Songs.Where(s => s.SongName.ToLower().Contains(searchText))
				.Select(s => new { s.SongName }).ToList();
			dgvSongs.DataSource = songs;
			var films = context.Films.Where(f => f.FilmName.ToLower().Contains(searchText))
				.Select(s => new { s.FilmName }).ToList();
			dgvVideos.DataSource = films;
		}

		private void LoadSongs()
		{
			var listSong = context.Songs.Select(s => new
			{
				s.SongName
			}).ToList();
			dgvSongs.BorderStyle = BorderStyle.None;
			dgvSongs.DataSource = listSong;
		}
		private void LoadVideos()
		{
			var listVideos = context.Films.Select(s => new
			{
				s.FilmName,
			}).ToList();
			dgvVideos.BorderStyle = BorderStyle.None;
			dgvVideos.DataSource = listVideos;
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void Play(int index, string type)
		{
			switch (type)
			{
				case "mp3":
					var songName = dgvSongs.Rows[index].Cells[0].FormattedValue.ToString();
					var song = context.Songs.FirstOrDefault(s => s.SongName.Equals(songName));
					lbTitle.Text = songName;
					ItemInfo = song;
					player.URL = Path.Combine(SONGPATH, song.FilePath);
					player.controls.play();
					break;
				case "mp4":
					var videoName = dgvVideos.Rows[index].Cells[0].FormattedValue.ToString();
					var films = context.Films.FirstOrDefault(f => f.FilmName.Equals(videoName));
					lbTitle.Text = videoName;
					ItemInfo = films;
					player.URL = Path.Combine(VIDEOPATH, films.FilePath);
					player.controls.play();
					break;
			}
		}

		private void dgvSongs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			type = "mp3";
			PlayingIndex = e.RowIndex;
			Play(PlayingIndex, type);
		}

		private void dgvVideos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			type = "mp4";
			PlayingIndex = e.RowIndex;
			Play(PlayingIndex, type);

		}
		private void btnPreview_Click(object sender, EventArgs e)
		{
			if (PlayingIndex == 0 && type.Equals("mp3"))
			{
				PlayingIndex = dgvSongs.RowCount - 1;
			}
			else if (PlayingIndex == 0 && type.Equals("mp4"))
			{
				PlayingIndex = dgvVideos.RowCount - 1;
			}
			else
			{
				PlayingIndex--;
			}
			Play(PlayingIndex, type);
		}


		private void btnNext_Click(object sender, EventArgs e)
		{
			if (PlayingIndex == dgvSongs.RowCount - 1 && type.Equals("mp3"))
			{
				PlayingIndex = 0;
			}
			else if (PlayingIndex == dgvVideos.RowCount - 1 && type.Equals("mp4"))
			{
				PlayingIndex = 0;
			}
			else
			{
				PlayingIndex++;
			}
			Play(PlayingIndex, type);
		}

		private void btnPlay_Click(object sender, EventArgs e)
		{
			player.controls.play();
		}

		private void btnPause_Click(object sender, EventArgs e)
		{
			lbTitle.Text = "Paused";
			player.controls.pause();
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			lbTitle.Text = "Stopped";
			player.controls.stop();
		}

		private void btnVideo_Click(object sender, EventArgs e)
		{
			if (ItemInfo != null)
			{
				player.controls.pause();
				currentPosition = player.controls.currentPosition;
				frmVideo frmVideo = new frmVideo
				{
					ItemInfo = ItemInfo,
					StartingPosition = currentPosition,
				};
				frmVideo.ShowDialog();
			}
			else
			{
				MessageBox.Show("Choose a song or film", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
	}
}
