using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace NtofosApplication.DataAccess
{
    public partial class NtofosContext : DbContext
    {
        public NtofosContext()
        {
        }

        public NtofosContext(DbContextOptions<NtofosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Film> Films { get; set; } = null!;
        public virtual DbSet<Review> Reviews { get; set; } = null!;
        public virtual DbSet<Song> Songs { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
			optionsBuilder.UseSqlServer(config.GetConnectionString("MyDB"));
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Film>(entity =>
            {
                entity.Property(e => e.FilmId).HasColumnName("FilmID");

                entity.Property(e => e.FilePath)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FilmName).HasMaxLength(255);

                entity.Property(e => e.ReleaseDate).HasColumnType("datetime");

                entity.HasOne(d => d.UploadedByNavigation)
                    .WithMany(p => p.Films)
                    .HasForeignKey(d => d.UploadedBy)
                    .HasConstraintName("FK__Films__UploadedB__3F466844");
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.Property(e => e.ReviewId).HasColumnName("ReviewID");

                entity.Property(e => e.FilmId).HasColumnName("FilmID");

                entity.Property(e => e.ReviewDate).HasColumnType("datetime");

                entity.Property(e => e.SongId).HasColumnName("SongID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Film)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.FilmId)
                    .HasConstraintName("FK__Reviews__FilmID__440B1D61");

                entity.HasOne(d => d.Song)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.SongId)
                    .HasConstraintName("FK__Reviews__SongID__4316F928");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Reviews__UserID__4222D4EF");
            });

            modelBuilder.Entity<Song>(entity =>
            {
                entity.Property(e => e.SongId).HasColumnName("SongID");

                entity.Property(e => e.FilePath)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReleaseDate).HasColumnType("datetime");

                entity.Property(e => e.SongName).HasMaxLength(255);

                entity.HasOne(d => d.UploadedByNavigation)
                    .WithMany(p => p.Songs)
                    .HasForeignKey(d => d.UploadedBy)
                    .HasConstraintName("FK__Songs__UploadedB__3C69FB99");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Username, "UQ__Users__536C85E4BD63996D")
                    .IsUnique();

                entity.HasIndex(e => e.Email, "UQ__Users__A9D10534D30E7678")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Fullname).HasMaxLength(255);

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('User')");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
