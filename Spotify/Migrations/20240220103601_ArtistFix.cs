using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Spotify.Migrations
{
    /// <inheritdoc />
    public partial class ArtistFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "Artists");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GenreId",
                table: "Artists",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
