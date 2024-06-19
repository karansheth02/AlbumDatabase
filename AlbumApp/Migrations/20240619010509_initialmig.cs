using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlbumApp.Migrations
{
    public partial class initialmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Song = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "Author", "Rating", "Song", "Title" },
                values: new object[,]
                {
                    { 1, "The Clash", 9.8m, "Lost In The Supermarket", "To Seek the Truth of The Cosmos" },
                    { 2, "George Harrison", 9.5m, "All Things Must Pass", "Beyond The Veil of Time" },
                    { 3, "The Beatles", 9.5m, "Let It Be", "Bad Company" },
                    { 4, "John Lennon", 9.1m, "Imagine", "Ready, Set, Go!" },
                    { 5, "Elton John", 8.8m, "Your Song", "The Rhythm of Life" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albums");
        }
    }
}
