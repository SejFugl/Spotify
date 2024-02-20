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
    }
}
