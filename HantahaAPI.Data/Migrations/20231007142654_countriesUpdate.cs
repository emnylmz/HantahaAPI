using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HantahaAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class countriesUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Language",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "EnglishName", "ImageURL", "Name" },
                values: new object[,]
                {
                    { 208, "Spain", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/ES.svg", "İspanya" },
                    { 209, "Belarus", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/BY.svg", "Belarus" },
                    { 210, "Israel", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/IL.svg", "İsrail" },
                    { 211, "Tajikistan", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/TJ.svg", "Tacikistan" },
                    { 212, "France", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/FR.svg", "Fransa" },
                    { 213, "Croatia", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/HR.svg", "Hırvatistan" },
                    { 214, "Hungary", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/HU.svg", "Macaristan" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Language_CreatedBy",
                table: "Language",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Language_UpdatedBy",
                table: "Language",
                column: "UpdatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Language_User_CreatedBy",
                table: "Language",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Language_User_UpdatedBy",
                table: "Language",
                column: "UpdatedBy",
                principalTable: "User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Language_User_CreatedBy",
                table: "Language");

            migrationBuilder.DropForeignKey(
                name: "FK_Language_User_UpdatedBy",
                table: "Language");

            migrationBuilder.DropIndex(
                name: "IX_Language_CreatedBy",
                table: "Language");

            migrationBuilder.DropIndex(
                name: "IX_Language_UpdatedBy",
                table: "Language");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Language",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);
        }
    }
}
