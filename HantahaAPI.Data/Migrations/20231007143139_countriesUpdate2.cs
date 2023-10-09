using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HantahaAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class countriesUpdate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "EnglishName", "ImageURL", "Name" },
                values: new object[] { 215, "Thailand", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/TH.svg", "Tayland" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 215);
        }
    }
}
