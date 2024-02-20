using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Spotify.Models
{
    public class Song
    {
        public int SongId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Title cannot be longer than 50 characters.")]
        [Column("Title")]
        [Display(Name = "Title")]
        public string Title { get; set; }
        public string Duration { get; set; }

        public int AlbumId { get; set; }
        public Album Album { get; set; }

        public ICollection<PlaylistSong> PlaylistSongs { get; set; }
    }
}
