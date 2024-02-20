using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Spotify.Models;

namespace Spotify.Data
{
    public class SpotifyDbContext : DbContext
    {
        public SpotifyDbContext(DbContextOptions<SpotifyDbContext> options)
            : base(options)
        {
        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<PlaylistSong> PlaylistSongs { get; set; }
        public DbSet<Song> Songs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            SeedData(modelBuilder);
        }


        private void SeedData(ModelBuilder modelBuilder)
        {
            // Tilføj genrer
            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreId = 1, Name = "Rock", Description = "Energetic and amplified" },
                new Genre { GenreId = 2, Name = "Pop", Description = "Popular music with catchy melodies" }
                // ... flere genrer kan tilføjes her
            );

            // Tilføj kunstnere, albummer og sange
            for (int artistId = 1; artistId <= 15; artistId++)
            {
                var artistName = $"Artist {artistId}";
                var genreId = (artistId % 2) + 1; // Skifter mellem Rock og Pop
                var albumId = artistId;

                // Tilføj kunstner
                modelBuilder.Entity<Artist>().HasData(new Artist { ArtistId = artistId, Name = artistName });

                // Tilføj album
                modelBuilder.Entity<Album>().HasData(new Album { AlbumId = albumId, Title = $"{artistName} Album", Price = 9.99, AlbumArtUrl = $"url_to_album_art_{artistId}", ArtistId = artistId, GenreId = genreId });

                // Tilføj sange til albummet
                for (int songId = 1; songId <= 5; songId++)
                {
                    var globalSongId = (artistId - 1) * 5 + songId;
                    modelBuilder.Entity<Song>().HasData(
                        new Song
                        {
                            SongId = globalSongId,
                            Title = $"Song {globalSongId} by {artistName}",
                            Duration = "3:00",
                            AlbumId = albumId
                        });
                }
            }
        }
    }
}
