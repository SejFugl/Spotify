namespace Spotify.Models.SpotifyViewModels
{
    public class AlbumIndexData
    {
        public IEnumerable<Album> Albums { get; set; }
        public IEnumerable<Song> Songs { get; set; }

        //public AlbumIndexData()
        //{
        //    Albums = new List<Album>();
        //    Songs = new List<Song>();
        //}
    }
}
