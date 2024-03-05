﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Spotify.Data;

#nullable disable

namespace Spotify.Migrations
{
    [DbContext(typeof(SpotifyDbContext))]
    [Migration("20240305102606_UserPlaylistFix")]
    partial class UserPlaylistFix
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("IdentityUser");
                });

            modelBuilder.Entity("Spotify.Models.Album", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AlbumId"));

                    b.Property<string>("AlbumArtUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AlbumId");

                    b.HasIndex("ArtistId");

                    b.HasIndex("GenreId");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            AlbumId = 1,
                            AlbumArtUrl = "url_to_album_art_1",
                            ArtistId = 1,
                            GenreId = 2,
                            Price = 9.9900000000000002,
                            Title = "Artist 1 Album"
                        },
                        new
                        {
                            AlbumId = 2,
                            AlbumArtUrl = "url_to_album_art_2",
                            ArtistId = 2,
                            GenreId = 1,
                            Price = 9.9900000000000002,
                            Title = "Artist 2 Album"
                        },
                        new
                        {
                            AlbumId = 3,
                            AlbumArtUrl = "url_to_album_art_3",
                            ArtistId = 3,
                            GenreId = 2,
                            Price = 9.9900000000000002,
                            Title = "Artist 3 Album"
                        },
                        new
                        {
                            AlbumId = 4,
                            AlbumArtUrl = "url_to_album_art_4",
                            ArtistId = 4,
                            GenreId = 1,
                            Price = 9.9900000000000002,
                            Title = "Artist 4 Album"
                        },
                        new
                        {
                            AlbumId = 5,
                            AlbumArtUrl = "url_to_album_art_5",
                            ArtistId = 5,
                            GenreId = 2,
                            Price = 9.9900000000000002,
                            Title = "Artist 5 Album"
                        },
                        new
                        {
                            AlbumId = 6,
                            AlbumArtUrl = "url_to_album_art_6",
                            ArtistId = 6,
                            GenreId = 1,
                            Price = 9.9900000000000002,
                            Title = "Artist 6 Album"
                        },
                        new
                        {
                            AlbumId = 7,
                            AlbumArtUrl = "url_to_album_art_7",
                            ArtistId = 7,
                            GenreId = 2,
                            Price = 9.9900000000000002,
                            Title = "Artist 7 Album"
                        },
                        new
                        {
                            AlbumId = 8,
                            AlbumArtUrl = "url_to_album_art_8",
                            ArtistId = 8,
                            GenreId = 1,
                            Price = 9.9900000000000002,
                            Title = "Artist 8 Album"
                        },
                        new
                        {
                            AlbumId = 9,
                            AlbumArtUrl = "url_to_album_art_9",
                            ArtistId = 9,
                            GenreId = 2,
                            Price = 9.9900000000000002,
                            Title = "Artist 9 Album"
                        },
                        new
                        {
                            AlbumId = 10,
                            AlbumArtUrl = "url_to_album_art_10",
                            ArtistId = 10,
                            GenreId = 1,
                            Price = 9.9900000000000002,
                            Title = "Artist 10 Album"
                        },
                        new
                        {
                            AlbumId = 11,
                            AlbumArtUrl = "url_to_album_art_11",
                            ArtistId = 11,
                            GenreId = 2,
                            Price = 9.9900000000000002,
                            Title = "Artist 11 Album"
                        },
                        new
                        {
                            AlbumId = 12,
                            AlbumArtUrl = "url_to_album_art_12",
                            ArtistId = 12,
                            GenreId = 1,
                            Price = 9.9900000000000002,
                            Title = "Artist 12 Album"
                        },
                        new
                        {
                            AlbumId = 13,
                            AlbumArtUrl = "url_to_album_art_13",
                            ArtistId = 13,
                            GenreId = 2,
                            Price = 9.9900000000000002,
                            Title = "Artist 13 Album"
                        },
                        new
                        {
                            AlbumId = 14,
                            AlbumArtUrl = "url_to_album_art_14",
                            ArtistId = 14,
                            GenreId = 1,
                            Price = 9.9900000000000002,
                            Title = "Artist 14 Album"
                        },
                        new
                        {
                            AlbumId = 15,
                            AlbumArtUrl = "url_to_album_art_15",
                            ArtistId = 15,
                            GenreId = 2,
                            Price = 9.9900000000000002,
                            Title = "Artist 15 Album"
                        });
                });

            modelBuilder.Entity("Spotify.Models.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArtistId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Name");

                    b.HasKey("ArtistId");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            ArtistId = 1,
                            Name = "Artist 1"
                        },
                        new
                        {
                            ArtistId = 2,
                            Name = "Artist 2"
                        },
                        new
                        {
                            ArtistId = 3,
                            Name = "Artist 3"
                        },
                        new
                        {
                            ArtistId = 4,
                            Name = "Artist 4"
                        },
                        new
                        {
                            ArtistId = 5,
                            Name = "Artist 5"
                        },
                        new
                        {
                            ArtistId = 6,
                            Name = "Artist 6"
                        },
                        new
                        {
                            ArtistId = 7,
                            Name = "Artist 7"
                        },
                        new
                        {
                            ArtistId = 8,
                            Name = "Artist 8"
                        },
                        new
                        {
                            ArtistId = 9,
                            Name = "Artist 9"
                        },
                        new
                        {
                            ArtistId = 10,
                            Name = "Artist 10"
                        },
                        new
                        {
                            ArtistId = 11,
                            Name = "Artist 11"
                        },
                        new
                        {
                            ArtistId = 12,
                            Name = "Artist 12"
                        },
                        new
                        {
                            ArtistId = 13,
                            Name = "Artist 13"
                        },
                        new
                        {
                            ArtistId = 14,
                            Name = "Artist 14"
                        },
                        new
                        {
                            ArtistId = 15,
                            Name = "Artist 15"
                        });
                });

            modelBuilder.Entity("Spotify.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Name");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreId = 1,
                            Description = "Energetic and amplified",
                            Name = "Rock"
                        },
                        new
                        {
                            GenreId = 2,
                            Description = "Popular music with catchy melodies",
                            Name = "Pop"
                        });
                });

            modelBuilder.Entity("Spotify.Models.Playlist", b =>
                {
                    b.Property<int>("PlaylistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlaylistId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Name");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PlaylistId");

                    b.HasIndex("UserId");

                    b.ToTable("Playlists");
                });

            modelBuilder.Entity("Spotify.Models.PlaylistSong", b =>
                {
                    b.Property<int>("PlaylistSongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlaylistSongId"));

                    b.Property<int>("PlaylistId")
                        .HasColumnType("int");

                    b.Property<int>("SongId")
                        .HasColumnType("int");

                    b.HasKey("PlaylistSongId");

                    b.HasIndex("PlaylistId");

                    b.HasIndex("SongId");

                    b.ToTable("PlaylistSongs");
                });

            modelBuilder.Entity("Spotify.Models.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SongId"));

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Title");

                    b.HasKey("SongId");

                    b.HasIndex("AlbumId");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            SongId = 1,
                            AlbumId = 1,
                            Duration = "3:00",
                            Title = "Song 1 by Artist 1"
                        },
                        new
                        {
                            SongId = 2,
                            AlbumId = 1,
                            Duration = "3:00",
                            Title = "Song 2 by Artist 1"
                        },
                        new
                        {
                            SongId = 3,
                            AlbumId = 1,
                            Duration = "3:00",
                            Title = "Song 3 by Artist 1"
                        },
                        new
                        {
                            SongId = 4,
                            AlbumId = 1,
                            Duration = "3:00",
                            Title = "Song 4 by Artist 1"
                        },
                        new
                        {
                            SongId = 5,
                            AlbumId = 1,
                            Duration = "3:00",
                            Title = "Song 5 by Artist 1"
                        },
                        new
                        {
                            SongId = 6,
                            AlbumId = 2,
                            Duration = "3:00",
                            Title = "Song 6 by Artist 2"
                        },
                        new
                        {
                            SongId = 7,
                            AlbumId = 2,
                            Duration = "3:00",
                            Title = "Song 7 by Artist 2"
                        },
                        new
                        {
                            SongId = 8,
                            AlbumId = 2,
                            Duration = "3:00",
                            Title = "Song 8 by Artist 2"
                        },
                        new
                        {
                            SongId = 9,
                            AlbumId = 2,
                            Duration = "3:00",
                            Title = "Song 9 by Artist 2"
                        },
                        new
                        {
                            SongId = 10,
                            AlbumId = 2,
                            Duration = "3:00",
                            Title = "Song 10 by Artist 2"
                        },
                        new
                        {
                            SongId = 11,
                            AlbumId = 3,
                            Duration = "3:00",
                            Title = "Song 11 by Artist 3"
                        },
                        new
                        {
                            SongId = 12,
                            AlbumId = 3,
                            Duration = "3:00",
                            Title = "Song 12 by Artist 3"
                        },
                        new
                        {
                            SongId = 13,
                            AlbumId = 3,
                            Duration = "3:00",
                            Title = "Song 13 by Artist 3"
                        },
                        new
                        {
                            SongId = 14,
                            AlbumId = 3,
                            Duration = "3:00",
                            Title = "Song 14 by Artist 3"
                        },
                        new
                        {
                            SongId = 15,
                            AlbumId = 3,
                            Duration = "3:00",
                            Title = "Song 15 by Artist 3"
                        },
                        new
                        {
                            SongId = 16,
                            AlbumId = 4,
                            Duration = "3:00",
                            Title = "Song 16 by Artist 4"
                        },
                        new
                        {
                            SongId = 17,
                            AlbumId = 4,
                            Duration = "3:00",
                            Title = "Song 17 by Artist 4"
                        },
                        new
                        {
                            SongId = 18,
                            AlbumId = 4,
                            Duration = "3:00",
                            Title = "Song 18 by Artist 4"
                        },
                        new
                        {
                            SongId = 19,
                            AlbumId = 4,
                            Duration = "3:00",
                            Title = "Song 19 by Artist 4"
                        },
                        new
                        {
                            SongId = 20,
                            AlbumId = 4,
                            Duration = "3:00",
                            Title = "Song 20 by Artist 4"
                        },
                        new
                        {
                            SongId = 21,
                            AlbumId = 5,
                            Duration = "3:00",
                            Title = "Song 21 by Artist 5"
                        },
                        new
                        {
                            SongId = 22,
                            AlbumId = 5,
                            Duration = "3:00",
                            Title = "Song 22 by Artist 5"
                        },
                        new
                        {
                            SongId = 23,
                            AlbumId = 5,
                            Duration = "3:00",
                            Title = "Song 23 by Artist 5"
                        },
                        new
                        {
                            SongId = 24,
                            AlbumId = 5,
                            Duration = "3:00",
                            Title = "Song 24 by Artist 5"
                        },
                        new
                        {
                            SongId = 25,
                            AlbumId = 5,
                            Duration = "3:00",
                            Title = "Song 25 by Artist 5"
                        },
                        new
                        {
                            SongId = 26,
                            AlbumId = 6,
                            Duration = "3:00",
                            Title = "Song 26 by Artist 6"
                        },
                        new
                        {
                            SongId = 27,
                            AlbumId = 6,
                            Duration = "3:00",
                            Title = "Song 27 by Artist 6"
                        },
                        new
                        {
                            SongId = 28,
                            AlbumId = 6,
                            Duration = "3:00",
                            Title = "Song 28 by Artist 6"
                        },
                        new
                        {
                            SongId = 29,
                            AlbumId = 6,
                            Duration = "3:00",
                            Title = "Song 29 by Artist 6"
                        },
                        new
                        {
                            SongId = 30,
                            AlbumId = 6,
                            Duration = "3:00",
                            Title = "Song 30 by Artist 6"
                        },
                        new
                        {
                            SongId = 31,
                            AlbumId = 7,
                            Duration = "3:00",
                            Title = "Song 31 by Artist 7"
                        },
                        new
                        {
                            SongId = 32,
                            AlbumId = 7,
                            Duration = "3:00",
                            Title = "Song 32 by Artist 7"
                        },
                        new
                        {
                            SongId = 33,
                            AlbumId = 7,
                            Duration = "3:00",
                            Title = "Song 33 by Artist 7"
                        },
                        new
                        {
                            SongId = 34,
                            AlbumId = 7,
                            Duration = "3:00",
                            Title = "Song 34 by Artist 7"
                        },
                        new
                        {
                            SongId = 35,
                            AlbumId = 7,
                            Duration = "3:00",
                            Title = "Song 35 by Artist 7"
                        },
                        new
                        {
                            SongId = 36,
                            AlbumId = 8,
                            Duration = "3:00",
                            Title = "Song 36 by Artist 8"
                        },
                        new
                        {
                            SongId = 37,
                            AlbumId = 8,
                            Duration = "3:00",
                            Title = "Song 37 by Artist 8"
                        },
                        new
                        {
                            SongId = 38,
                            AlbumId = 8,
                            Duration = "3:00",
                            Title = "Song 38 by Artist 8"
                        },
                        new
                        {
                            SongId = 39,
                            AlbumId = 8,
                            Duration = "3:00",
                            Title = "Song 39 by Artist 8"
                        },
                        new
                        {
                            SongId = 40,
                            AlbumId = 8,
                            Duration = "3:00",
                            Title = "Song 40 by Artist 8"
                        },
                        new
                        {
                            SongId = 41,
                            AlbumId = 9,
                            Duration = "3:00",
                            Title = "Song 41 by Artist 9"
                        },
                        new
                        {
                            SongId = 42,
                            AlbumId = 9,
                            Duration = "3:00",
                            Title = "Song 42 by Artist 9"
                        },
                        new
                        {
                            SongId = 43,
                            AlbumId = 9,
                            Duration = "3:00",
                            Title = "Song 43 by Artist 9"
                        },
                        new
                        {
                            SongId = 44,
                            AlbumId = 9,
                            Duration = "3:00",
                            Title = "Song 44 by Artist 9"
                        },
                        new
                        {
                            SongId = 45,
                            AlbumId = 9,
                            Duration = "3:00",
                            Title = "Song 45 by Artist 9"
                        },
                        new
                        {
                            SongId = 46,
                            AlbumId = 10,
                            Duration = "3:00",
                            Title = "Song 46 by Artist 10"
                        },
                        new
                        {
                            SongId = 47,
                            AlbumId = 10,
                            Duration = "3:00",
                            Title = "Song 47 by Artist 10"
                        },
                        new
                        {
                            SongId = 48,
                            AlbumId = 10,
                            Duration = "3:00",
                            Title = "Song 48 by Artist 10"
                        },
                        new
                        {
                            SongId = 49,
                            AlbumId = 10,
                            Duration = "3:00",
                            Title = "Song 49 by Artist 10"
                        },
                        new
                        {
                            SongId = 50,
                            AlbumId = 10,
                            Duration = "3:00",
                            Title = "Song 50 by Artist 10"
                        },
                        new
                        {
                            SongId = 51,
                            AlbumId = 11,
                            Duration = "3:00",
                            Title = "Song 51 by Artist 11"
                        },
                        new
                        {
                            SongId = 52,
                            AlbumId = 11,
                            Duration = "3:00",
                            Title = "Song 52 by Artist 11"
                        },
                        new
                        {
                            SongId = 53,
                            AlbumId = 11,
                            Duration = "3:00",
                            Title = "Song 53 by Artist 11"
                        },
                        new
                        {
                            SongId = 54,
                            AlbumId = 11,
                            Duration = "3:00",
                            Title = "Song 54 by Artist 11"
                        },
                        new
                        {
                            SongId = 55,
                            AlbumId = 11,
                            Duration = "3:00",
                            Title = "Song 55 by Artist 11"
                        },
                        new
                        {
                            SongId = 56,
                            AlbumId = 12,
                            Duration = "3:00",
                            Title = "Song 56 by Artist 12"
                        },
                        new
                        {
                            SongId = 57,
                            AlbumId = 12,
                            Duration = "3:00",
                            Title = "Song 57 by Artist 12"
                        },
                        new
                        {
                            SongId = 58,
                            AlbumId = 12,
                            Duration = "3:00",
                            Title = "Song 58 by Artist 12"
                        },
                        new
                        {
                            SongId = 59,
                            AlbumId = 12,
                            Duration = "3:00",
                            Title = "Song 59 by Artist 12"
                        },
                        new
                        {
                            SongId = 60,
                            AlbumId = 12,
                            Duration = "3:00",
                            Title = "Song 60 by Artist 12"
                        },
                        new
                        {
                            SongId = 61,
                            AlbumId = 13,
                            Duration = "3:00",
                            Title = "Song 61 by Artist 13"
                        },
                        new
                        {
                            SongId = 62,
                            AlbumId = 13,
                            Duration = "3:00",
                            Title = "Song 62 by Artist 13"
                        },
                        new
                        {
                            SongId = 63,
                            AlbumId = 13,
                            Duration = "3:00",
                            Title = "Song 63 by Artist 13"
                        },
                        new
                        {
                            SongId = 64,
                            AlbumId = 13,
                            Duration = "3:00",
                            Title = "Song 64 by Artist 13"
                        },
                        new
                        {
                            SongId = 65,
                            AlbumId = 13,
                            Duration = "3:00",
                            Title = "Song 65 by Artist 13"
                        },
                        new
                        {
                            SongId = 66,
                            AlbumId = 14,
                            Duration = "3:00",
                            Title = "Song 66 by Artist 14"
                        },
                        new
                        {
                            SongId = 67,
                            AlbumId = 14,
                            Duration = "3:00",
                            Title = "Song 67 by Artist 14"
                        },
                        new
                        {
                            SongId = 68,
                            AlbumId = 14,
                            Duration = "3:00",
                            Title = "Song 68 by Artist 14"
                        },
                        new
                        {
                            SongId = 69,
                            AlbumId = 14,
                            Duration = "3:00",
                            Title = "Song 69 by Artist 14"
                        },
                        new
                        {
                            SongId = 70,
                            AlbumId = 14,
                            Duration = "3:00",
                            Title = "Song 70 by Artist 14"
                        },
                        new
                        {
                            SongId = 71,
                            AlbumId = 15,
                            Duration = "3:00",
                            Title = "Song 71 by Artist 15"
                        },
                        new
                        {
                            SongId = 72,
                            AlbumId = 15,
                            Duration = "3:00",
                            Title = "Song 72 by Artist 15"
                        },
                        new
                        {
                            SongId = 73,
                            AlbumId = 15,
                            Duration = "3:00",
                            Title = "Song 73 by Artist 15"
                        },
                        new
                        {
                            SongId = 74,
                            AlbumId = 15,
                            Duration = "3:00",
                            Title = "Song 74 by Artist 15"
                        },
                        new
                        {
                            SongId = 75,
                            AlbumId = 15,
                            Duration = "3:00",
                            Title = "Song 75 by Artist 15"
                        });
                });

            modelBuilder.Entity("Spotify.Models.Album", b =>
                {
                    b.HasOne("Spotify.Models.Artist", "Artist")
                        .WithMany("Albums")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Spotify.Models.Genre", "Genre")
                        .WithMany("Albums")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("Spotify.Models.Playlist", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Spotify.Models.PlaylistSong", b =>
                {
                    b.HasOne("Spotify.Models.Playlist", "Playlist")
                        .WithMany("PlaylistSongs")
                        .HasForeignKey("PlaylistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Spotify.Models.Song", "Song")
                        .WithMany("PlaylistSongs")
                        .HasForeignKey("SongId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Playlist");

                    b.Navigation("Song");
                });

            modelBuilder.Entity("Spotify.Models.Song", b =>
                {
                    b.HasOne("Spotify.Models.Album", "Album")
                        .WithMany("Songs")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");
                });

            modelBuilder.Entity("Spotify.Models.Album", b =>
                {
                    b.Navigation("Songs");
                });

            modelBuilder.Entity("Spotify.Models.Artist", b =>
                {
                    b.Navigation("Albums");
                });

            modelBuilder.Entity("Spotify.Models.Genre", b =>
                {
                    b.Navigation("Albums");
                });

            modelBuilder.Entity("Spotify.Models.Playlist", b =>
                {
                    b.Navigation("PlaylistSongs");
                });

            modelBuilder.Entity("Spotify.Models.Song", b =>
                {
                    b.Navigation("PlaylistSongs");
                });
#pragma warning restore 612, 618
        }
    }
}
