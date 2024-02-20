namespace Spotify.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string AlbumArtUrl { get; set; }

        public int ArtistId { get; set; }
        public Artist Artist { get; set; }

        public int GenreId { get; set; }
        public Genre Genre { get; set; }

        public ICollection<Song> Songs { get; set; }
    }
}
