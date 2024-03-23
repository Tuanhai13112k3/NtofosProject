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
	public partial class frmDashBoard : Form
	{
		private NtofosContext context;
		private dynamic searchItem;
		public frmDashBoard()
		{
			InitializeComponent();
			context = new NtofosContext();
			menuStrip = new ContextMenuStrip();
		}

		private void frmDashBoard_Load(object sender, EventArgs e)
		{
			ToolStripMenuItem viewItem = new ToolStripMenuItem("View Details");
			ToolStripMenuItem deleteItem = new ToolStripMenuItem("Delete");
			menuStrip.Items.AddRange(new ToolStripItem[] { viewItem, deleteItem });
			viewItem.Click += new EventHandler(ViewDetails_Click);
			deleteItem.Click += new EventHandler(DeleteItem_Click);
		}

		private void DeleteItem_Click(object? sender, EventArgs e)
		{
			if (searchItem.GetType() == typeof(User))
			{
				context.Users.Remove(searchItem);
				context.SaveChanges();
				LoadUsers();

			}
			if (searchItem.GetType() == typeof(Film))
			{
				context.Films.Remove(searchItem);
				context.SaveChanges();
				LoadVideos();
			}
			if (searchItem.GetType() == typeof(Song))
			{
				context.Songs.Remove(searchItem);
				context.SaveChanges();
				LoadSongs();
			}
			MessageBox.Show("Delete Sucessfully", $"Delete a {searchItem.GetType().Name}", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void ViewDetails_Click(object? sender, EventArgs e)
		{

			if (searchItem.GetType() == typeof(User))
			{
				MessageBox.Show("User must not be changed by another.");
			}
			if (searchItem.GetType() == typeof(Film))
			{
				frmDetails frmDetails = new frmDetails
				{
					Text = "Update a Film",
					InsertOrUpdate = true,
					ItemInfo = searchItem,
				};
				if (frmDetails.ShowDialog() == DialogResult.OK)
				{
					LoadVideos();
				}
			}
			if (searchItem.GetType() == typeof(Song))
			{
				frmDetails frmDetails = new frmDetails
				{
					Text = "Update a Song",
					InsertOrUpdate = true,
					ItemInfo = searchItem,
				};
				if (frmDetails.ShowDialog() == DialogResult.OK)
				{
					LoadSongs();
				}
			}
		}

		private void btnUser_Click(object sender, EventArgs e)
		{
			lbList.Text = "List users:";
			LoadUsers();
		}

		private void btnSongs_Click(object sender, EventArgs e)
		{
			lbList.Text = "List songs:";
			LoadSongs();
		}

		private void btnFilms_Click(object sender, EventArgs e)
		{
			lbList.Text = "List Videos:";
			LoadVideos();
		}
		private void LoadSongs()
		{
			var listSong = context.Songs.Select(s => new
			{
				s.SongId,
				s.SongName,
				s.Artists,
				s.Composer,
				s.Genre,
				s.ReleaseDate,
				UploadedBy = s.UploadedByNavigation.Fullname,
			}).ToList();
			dgvList.BorderStyle = BorderStyle.None;
			dgvList.DataSource = listSong;
		}
		private void LoadUsers()
		{
			var listUsers = context.Users.Select(u => new
			{
				u.UserId,
				u.Username,
				u.Fullname,
				u.Email,
				u.Role,
			}).ToList();
			dgvList.DataSource = listUsers;
		}
		private void LoadVideos()
		{
			var listVideos = context.Films.Select(s => new
			{
				s.FilmId,
				s.FilmName,
				s.Artists,
				s.Creator,
				s.Genre,
				s.ReleaseDate,
				UploadedBy = s.UploadedByNavigation.Fullname,
			}).ToList();
			dgvList.DataSource = listVideos;
		}

		private void dgvList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			var type = lbList.Text.ToLower();
			if (e.Button == MouseButtons.Right && e.RowIndex != -1)
			{
				Rectangle cellRectangle = dgvList.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
				Point cellCorner = new Point(cellRectangle.Right, cellRectangle.Top);

				menuStrip.Show(dgvList, cellCorner);
				int id = int.Parse(dgvList.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());

				if (type.Contains("songs"))
				{
					searchItem = SearchSongByID(id);
				}
				else if (type.Contains("videos"))
				{
					searchItem = SearchFilmByID(id);
				}
				else
				{
					searchItem = SearchUserByID(id);
				}
			}
		}
		private Song SearchSongByID(int id) => context.Songs.Find(id);
		private User SearchUserByID(int id) => context.Users.Find(id);
		private Film SearchFilmByID(int id) => context.Films.Find(id);

		private void btnUpload_Click(object sender, EventArgs e)
		{
			var type = lbList.Text.ToLower();
			if (type.Contains("videos"))
			{
				frmDetails frmDetails = new frmDetails
				{
					Text = "Add a Film",
					InsertOrUpdate = false,
					ItemInfo = new Film()
				};
				if (frmDetails.ShowDialog() == DialogResult.OK)
				{
					LoadVideos();
				}
			}
			if (type.Contains("songs"))
			{
				frmDetails frmDetails = new frmDetails
				{
					Text = "Add a Song",
					InsertOrUpdate = false,
					ItemInfo = new Song()
				};
				if (frmDetails.ShowDialog() == DialogResult.OK)
				{
					LoadSongs();
				}
			}
			if (type.Contains("user"))
			{
				frmRegister frmRegister = new frmRegister
				{
					ForgotOrRegister = false
				};
				frmRegister.ShowDialog();
			}
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
