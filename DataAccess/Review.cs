using System;
using System.Collections.Generic;

namespace NtofosApplication.DataAccess
{
    public partial class Review
    {
        public int ReviewId { get; set; }
        public int? UserId { get; set; }
        public int? SongId { get; set; }
        public int? FilmId { get; set; }
        public string? ReviewText { get; set; }
        public int? Rating { get; set; }
        public DateTime? ReviewDate { get; set; }

        public virtual Film? Film { get; set; }
        public virtual Song? Song { get; set; }
        public virtual User? User { get; set; }
    }
}
