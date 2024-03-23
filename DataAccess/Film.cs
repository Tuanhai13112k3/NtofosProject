using System;
using System.Collections.Generic;

namespace NtofosApplication.DataAccess
{
    public partial class Film
    {
        public Film()
        {
            Reviews = new HashSet<Review>();
        }

        public int FilmId { get; set; }
        public string FilmName { get; set; } = null!;
        public string Artists { get; set; } = null!;
        public string Creator { get; set; } = null!;
        public string? Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string FilePath { get; set; } = null!;
        public int? UploadedBy { get; set; }

        public virtual User? UploadedByNavigation { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
