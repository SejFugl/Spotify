﻿namespace Spotify.Models
{
    public class PlaylistSong
    {
        public int PlaylistSongId { get; set; }
        public int SongId { get; set; }

        public Playlist Playlist { get; set; }
        public Song Song { get; set; }
    }
}
