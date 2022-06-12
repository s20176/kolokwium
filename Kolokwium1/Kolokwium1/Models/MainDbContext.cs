using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium1.Models
{
    public class MainDbContext: DbContext
    {
        protected MainDbContext()
        {

        }

        public MainDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Musican> Musicans { get; set; }
        public DbSet<Musican_Track> Musican_Tracks { get; set; }
        public DbSet<Musiclabel> Musiclabels { get; set; }
        public DbSet<Track> Tracks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Musican_Track>(p =>
            {
                p.HasKey(e => new
                {
                    e.IdMusican,
                    e.IdTrack
                });
            });

            modelBuilder.Entity<Album>(p =>
            {
                p.HasData(
                    new Album { IdAlbum = 1, AlbumName = "album1", IdMusiclabel = 1, PublishDate = DateTime.Parse("2000-01-01") },
                    new Album { IdAlbum = 2, AlbumName = "album2", IdMusiclabel = 2, PublishDate = DateTime.Parse("2000-01-01") }
                    );
            });

            modelBuilder.Entity<Musican>(p =>
            {
                p.HasData(
                    new Musican { IdMusican = 1, FirstName = "Jan", LastName = "Kowalski", Nickname = "aaaaaa" },
                    new Musican { IdMusican = 2, FirstName = "Jan", LastName = "Nowak", Nickname = "aaaaaa" }
                    );
            });

            modelBuilder.Entity<Musican_Track>(p =>
            {
                p.HasData(
                    new Musican_Track { IdTrack = 1, IdMusican = 1},
                    new Musican_Track { IdTrack = 2, IdMusican = 2 }
                    );
            });

            modelBuilder.Entity<Musiclabel>(p =>
            {
                p.HasData(
                    new Musiclabel { IdMusicLabel = 1, Name = "musiclabel1"},
                    new Musiclabel { IdMusicLabel = 2, Name = "musiclabel2" }
                    );
            });

            modelBuilder.Entity<Track>(p =>
            {
                p.HasData(
                    new Track { IdTrack = 1, Trackname = "track1", Duration = 2.5f, IdMusicAlbum = 1 },
                    new Track { IdTrack = 2, Trackname = "track2", Duration = 3.5f, IdMusicAlbum = 2 }
                    );
            });


        }
    }
}
