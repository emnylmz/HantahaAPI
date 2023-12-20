using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HantahaAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class englishLanguageName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EnglishName",
                table: "Language",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnglishName",
                table: "Language");
        }
    }
}
