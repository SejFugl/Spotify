﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Spotify.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        [Column("Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        public ICollection<Album>? Albums { get; set; }
    }
}
