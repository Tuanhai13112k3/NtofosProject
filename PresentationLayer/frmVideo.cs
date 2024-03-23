using NtofosApplication.DataAccess;
using NtofosApplication.PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NtofosApplication
{
    public partial class frmVideo : Form
    {
        public dynamic ItemInfo { get; set; } = null;
        public double StartingPosition { get; set; }
        private const string SONGPATH = @"C:\Users\acer\OneDrive\Documents\CS\NtofosApplication\Data\Songs\";
		private const string VIDEOTPATH = @"C:\Users\acer\OneDrive\Documents\CS\NtofosApplication\Data\Films\";
		public frmVideo()
        {
            InitializeComponent();
        }

        private void frmVideo_Load(object sender, EventArgs e)
        {
            if (ItemInfo.GetType() == typeof(Song))
            {
                Song song = (Song)ItemInfo;
				axWMP.URL = SONGPATH + song.FilePath;
				axWMP.Ctlcontrols.currentPosition = StartingPosition;
				axWMP.Ctlcontrols.play();
			}
			if (ItemInfo.GetType() == typeof(Film))
			{
                Film film = (Film)ItemInfo;
				axWMP.URL = VIDEOTPATH + film.FilePath;
				axWMP.Ctlcontrols.currentPosition = StartingPosition;
				axWMP.Ctlcontrols.play();
			}
			this.FormClosed += FrmVideo_FormClosed;
		}

		private void FrmVideo_FormClosed(object? sender, FormClosedEventArgs e)
		{
			axWMP.Ctlcontrols.pause();
			StartingPosition = axWMP.Ctlcontrols.currentPosition;
			frmHome frmHome = new frmHome
			{
				currentPosition = StartingPosition,
			};
		}
    }
}
