using System;
using System.Collections.Generic;

namespace NtofosApplication.DataAccess
{
    public partial class Song
    {
        public Song()
        {
            Reviews = new HashSet<Review>();
        }

        public int SongId { get; set; }
        public string SongName { get; set; } = null!;
        public string Artists { get; set; } = null!;
        public string? Composer { get; set; }
        public string? Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string FilePath { get; set; } = null!;
        public int? UploadedBy { get; set; }

        public virtual User? UploadedByNavigation { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
