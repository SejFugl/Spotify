using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Spotify.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Songs",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Playlists",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Genres",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Genres",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Artists",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[,]
                {
                    { 1, "Artist 1" },
                    { 2, "Artist 2" },
                    { 3, "Artist 3" },
                    { 4, "Artist 4" },
                    { 5, "Artist 5" },
                    { 6, "Artist 6" },
                    { 7, "Artist 7" },
                    { 8, "Artist 8" },
                    { 9, "Artist 9" },
                    { 10, "Artist 10" },
                    { 11, "Artist 11" },
                    { 12, "Artist 12" },
                    { 13, "Artist 13" },
                    { 14, "Artist 14" },
                    { 15, "Artist 15" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Energetic and amplified", "Rock" },
                    { 2, "Popular music with catchy melodies", "Pop" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "AlbumArtUrl", "ArtistId", "GenreId", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "url_to_album_art_1", 1, 2, 9.9900000000000002, "Artist 1 Album" },
                    { 2, "url_to_album_art_2", 2, 1, 9.9900000000000002, "Artist 2 Album" },
                    { 3, "url_to_album_art_3", 3, 2, 9.9900000000000002, "Artist 3 Album" },
                    { 4, "url_to_album_art_4", 4, 1, 9.9900000000000002, "Artist 4 Album" },
                    { 5, "url_to_album_art_5", 5, 2, 9.9900000000000002, "Artist 5 Album" },
                    { 6, "url_to_album_art_6", 6, 1, 9.9900000000000002, "Artist 6 Album" },
                    { 7, "url_to_album_art_7", 7, 2, 9.9900000000000002, "Artist 7 Album" },
                    { 8, "url_to_album_art_8", 8, 1, 9.9900000000000002, "Artist 8 Album" },
                    { 9, "url_to_album_art_9", 9, 2, 9.9900000000000002, "Artist 9 Album" },
                    { 10, "url_to_album_art_10", 10, 1, 9.9900000000000002, "Artist 10 Album" },
                    { 11, "url_to_album_art_11", 11, 2, 9.9900000000000002, "Artist 11 Album" },
                    { 12, "url_to_album_art_12", 12, 1, 9.9900000000000002, "Artist 12 Album" },
                    { 13, "url_to_album_art_13", 13, 2, 9.9900000000000002, "Artist 13 Album" },
                    { 14, "url_to_album_art_14", 14, 1, 9.9900000000000002, "Artist 14 Album" },
                    { 15, "url_to_album_art_15", 15, 2, 9.9900000000000002, "Artist 15 Album" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "AlbumId", "Duration", "Title" },
                values: new object[,]
                {
                    { 1, 1, "3:00", "Song 1 by Artist 1" },
                    { 2, 1, "3:00", "Song 2 by Artist 1" },
                    { 3, 1, "3:00", "Song 3 by Artist 1" },
                    { 4, 1, "3:00", "Song 4 by Artist 1" },
                    { 5, 1, "3:00", "Song 5 by Artist 1" },
                    { 6, 2, "3:00", "Song 6 by Artist 2" },
                    { 7, 2, "3:00", "Song 7 by Artist 2" },
                    { 8, 2, "3:00", "Song 8 by Artist 2" },
                    { 9, 2, "3:00", "Song 9 by Artist 2" },
                    { 10, 2, "3:00", "Song 10 by Artist 2" },
                    { 11, 3, "3:00", "Song 11 by Artist 3" },
                    { 12, 3, "3:00", "Song 12 by Artist 3" },
                    { 13, 3, "3:00", "Song 13 by Artist 3" },
                    { 14, 3, "3:00", "Song 14 by Artist 3" },
                    { 15, 3, "3:00", "Song 15 by Artist 3" },
                    { 16, 4, "3:00", "Song 16 by Artist 4" },
                    { 17, 4, "3:00", "Song 17 by Artist 4" },
                    { 18, 4, "3:00", "Song 18 by Artist 4" },
                    { 19, 4, "3:00", "Song 19 by Artist 4" },
                    { 20, 4, "3:00", "Song 20 by Artist 4" },
                    { 21, 5, "3:00", "Song 21 by Artist 5" },
                    { 22, 5, "3:00", "Song 22 by Artist 5" },
                    { 23, 5, "3:00", "Song 23 by Artist 5" },
                    { 24, 5, "3:00", "Song 24 by Artist 5" },
                    { 25, 5, "3:00", "Song 25 by Artist 5" },
                    { 26, 6, "3:00", "Song 26 by Artist 6" },
                    { 27, 6, "3:00", "Song 27 by Artist 6" },
                    { 28, 6, "3:00", "Song 28 by Artist 6" },
                    { 29, 6, "3:00", "Song 29 by Artist 6" },
                    { 30, 6, "3:00", "Song 30 by Artist 6" },
                    { 31, 7, "3:00", "Song 31 by Artist 7" },
                    { 32, 7, "3:00", "Song 32 by Artist 7" },
                    { 33, 7, "3:00", "Song 33 by Artist 7" },
                    { 34, 7, "3:00", "Song 34 by Artist 7" },
                    { 35, 7, "3:00", "Song 35 by Artist 7" },
                    { 36, 8, "3:00", "Song 36 by Artist 8" },
                    { 37, 8, "3:00", "Song 37 by Artist 8" },
                    { 38, 8, "3:00", "Song 38 by Artist 8" },
                    { 39, 8, "3:00", "Song 39 by Artist 8" },
                    { 40, 8, "3:00", "Song 40 by Artist 8" },
                    { 41, 9, "3:00", "Song 41 by Artist 9" },
                    { 42, 9, "3:00", "Song 42 by Artist 9" },
                    { 43, 9, "3:00", "Song 43 by Artist 9" },
                    { 44, 9, "3:00", "Song 44 by Artist 9" },
                    { 45, 9, "3:00", "Song 45 by Artist 9" },
                    { 46, 10, "3:00", "Song 46 by Artist 10" },
                    { 47, 10, "3:00", "Song 47 by Artist 10" },
                    { 48, 10, "3:00", "Song 48 by Artist 10" },
                    { 49, 10, "3:00", "Song 49 by Artist 10" },
                    { 50, 10, "3:00", "Song 50 by Artist 10" },
                    { 51, 11, "3:00", "Song 51 by Artist 11" },
                    { 52, 11, "3:00", "Song 52 by Artist 11" },
                    { 53, 11, "3:00", "Song 53 by Artist 11" },
                    { 54, 11, "3:00", "Song 54 by Artist 11" },
                    { 55, 11, "3:00", "Song 55 by Artist 11" },
                    { 56, 12, "3:00", "Song 56 by Artist 12" },
                    { 57, 12, "3:00", "Song 57 by Artist 12" },
                    { 58, 12, "3:00", "Song 58 by Artist 12" },
                    { 59, 12, "3:00", "Song 59 by Artist 12" },
                    { 60, 12, "3:00", "Song 60 by Artist 12" },
                    { 61, 13, "3:00", "Song 61 by Artist 13" },
                    { 62, 13, "3:00", "Song 62 by Artist 13" },
                    { 63, 13, "3:00", "Song 63 by Artist 13" },
                    { 64, 13, "3:00", "Song 64 by Artist 13" },
                    { 65, 13, "3:00", "Song 65 by Artist 13" },
                    { 66, 14, "3:00", "Song 66 by Artist 14" },
                    { 67, 14, "3:00", "Song 67 by Artist 14" },
                    { 68, 14, "3:00", "Song 68 by Artist 14" },
                    { 69, 14, "3:00", "Song 69 by Artist 14" },
                    { 70, 14, "3:00", "Song 70 by Artist 14" },
                    { 71, 15, "3:00", "Song 71 by Artist 15" },
                    { 72, 15, "3:00", "Song 72 by Artist 15" },
                    { 73, 15, "3:00", "Song 73 by Artist 15" },
                    { 74, 15, "3:00", "Song 74 by Artist 15" },
                    { 75, 15, "3:00", "Song 75 by Artist 15" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Songs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Playlists",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Genres",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Genres",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Artists",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
