using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Spotify.Models
{
    public class Playlist
    {
        public int PlaylistId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        [Column("Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<PlaylistSong>? PlaylistSongs { get; set; }

        // Tilføj bruger-ID for at forbinde til IdentityUser
        public string? UserId { get; set; }

        //// Navigationsegenskab
        //public IdentityUser? User { get; set; }

    }
}
