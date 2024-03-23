using System;
using System.Collections.Generic;

namespace NtofosApplication.DataAccess
{
    public partial class User
    {
        public User()
        {
            Films = new HashSet<Film>();
            Reviews = new HashSet<Review>();
            Songs = new HashSet<Song>();
        }

        public int UserId { get; set; }
        public string Username { get; set; } = null!;
        public string Fullname { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Role { get; set; }

        public virtual ICollection<Film> Films { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
    }
}
